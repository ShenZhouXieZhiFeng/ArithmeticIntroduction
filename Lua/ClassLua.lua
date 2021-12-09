---@diagnostic disable: lowercase-global

---@class Rectangle
Rectangle = {area = 0, length = 0, breadth = 0}

function Rectangle:new(o, length, breadth)
    o = o or {}
    setmetatable(o, self)
    self.__index = self
    self.length = length or 0
    self.breadth = breadth or 0
    self.area = length * breadth
    return o
end

function Rectangle:printArea()
    print("area is", self.area)
end

---@class RectangleSon : Rectangle
RectangleSon = setmetatable({}, {__index = Rectangle})

function RectangleSon:printArea()
    print("from son: area is", self.area)
end

print('-----------r1---------------')

---@type Rectangle
local r1 = Rectangle:new(nil, 10, 20)
print(r1.length)
r1:printArea()

print('-----------r2---------------')

local r2 = RectangleSon:new(nil, 30, 40)
r2:printArea()

print("begin")

-- function class(classname, super)
--     local cls = {}
--     if super then
--         cls = {}
--         for k, v in pairs(super) do
--             cls[k] = v
--             cls.super = super
--         end
--     else
--         cls = {ctor = function (...) end}
--     end
--     cls.__cname = classname
--     ---将cls的元方法设为自己，这样当cls被当做其他表的元表时，在其他表中查找不到键值时就会查找到cls中
--     cls.__index = cls

--     function cls.new(...)
--         local instance = setmetatable({}, cls)
--         instance.class = cls
--         instance.super.ctor(instance, ...)
--         instance:ctor(...)
--         return instance
--     end

--     return cls
-- end

-- ----------------------------------------

-- BaseClass = class("BaseClass")

-- function BaseClass:ctor(param)
--     print("BaseClass:ctor")
--     self._param = param
--     self._children = {}
-- end

-- function BaseClass:addChild(obj)
--     table.insert(self._children, obj)
-- end

-- ----------------------------------------

-- SonClass = class("SonClass", BaseClass)

-- function SonClass:ctor(param)
--     print("SonClass:ctor")
-- end

-- local ins = SonClass:new("p1")
-- ins:addChild("child1")

function class(classname, super)
    local superType = type(super)
    local cls

    if superType ~= "function" and superType ~= "table" then
        superType = nil
        super = nil
    end

    if superType == "function" or (super and super.__ctype == 1) then
        -- inherited from native C++ Object
        cls = {}

        if superType == "table" then
            -- copy fields from super
            for k,v in pairs(super) do cls[k] = v end
            cls.__create = super.__create
            cls.super    = super
        else
            cls.__create = super
        end

        cls.ctor    = function() end
        cls.__cname = classname
        cls.__ctype = 1

        function cls.new(...)
            local instance = cls.__create(...)
            -- copy fields from class to native object
            for k,v in pairs(cls) do instance[k] = v end
            instance.class = cls
            instance:ctor(...)
            return instance
        end

    else
        -- inherited from Lua Object
        if super then
            cls = clone(super)
            cls.super = super
        else
            cls = {ctor = function() end}
        end

        cls.__cname = classname
        cls.__ctype = 2 -- lua
        cls.__index = cls

        function cls.new(...)
            local instance = setmetatable({}, cls)
            instance.class = cls
            instance:ctor(...)
            return instance
        end
    end

    return cls
end

local _class={}
function class(super)
    local class_type={}
    class_type.ctor     = false
    class_type.super    = super
    class_type.new      = 
        function(...)
            local obj={}
            do
                local create
                create = function(c,...)
                    if c.super then
                        create(c.super,...)
                    end
                    if c.ctor then
                        c.ctor(obj,...)
                    end
                end

                create(class_type,...)
            end
            setmetatable(obj,{ __index = _class[class_type] })
            return obj
        end
    local vtbl={}
    _class[class_type]=vtbl

    setmetatable(class_type,{__newindex=
        function(t,k,v)
            vtbl[k]=v
        end
    })
    
    if super then
        setmetatable(vtbl,{__index=
            function(t,k)
                local ret=_class[super][k]
                vtbl[k]=ret
                return ret
            end
        })
    end

    return class_type
end

base_type=class()       -- 定义一个基类 base_type
function base_type:ctor(x)  -- 定义 base_type 的构造函数
    print("base_type ctor")
    self.x=x
end
function base_type:print_x()    -- 定义一个成员函数 base_type:print_x
    print(self.x)
end
function base_type:hello()  -- 定义另一个成员函数 base_type:hello
    print("hello base_type")
end

test=class(base_type)   -- 定义一个类 test 继承于 base_type
function test:ctor()    -- 定义 test 的构造函数
    print("test ctor")
end
function test:hello()   -- 重载 base_type:hello 为 test:hello
    test.super:hello()
    print("hello test")
end

a=test.new(2)   -- 输出两行，base_type ctor 和 test ctor 。这个对象被正确的构造了。
a:print_x() -- 输出 1 ，这个是基类 base_type 中的成员函数。
a:hello()   -- 输出 hello test ，这个函数被重载了。
