---@diagnostic disable: lowercase-global, undefined-field

-- mytable = {}
-- mymetatable = {}
-- setmetatable(mytable,mymetatable)

-- local tab = getmetatable(mytable)

---------------index talbe------------------

-- other = {foo = 3}
-- t = setmetatable({}, {__index = other})
---在查找不存在的键的值时，查找到了index绑定的表
-- print(t.foo)

---------------index function------------------

-- mytable = setmetatable({key1 = "value1"}, {
--     __index = function (mytable, key)
--         print("index find", key)
--         if key == "key2" then
--             return "metablevalue"
--         else
--             return nil
--         end
--     end
-- })
---在查找不存在的键的值时，调用了index绑定的function
-- print(mytable.key1, mytable.key2)

---------------newindex table------------------

-- mymetatable = {}
-- mytable = setmetatable({key1 = "v1"}, 
-- {__newindex = mymetatable})

-- print(mytable.key1)

-- ---newkey的值被添加到mymetatable中
-- mytable.newkey = "new val 2"
-- print(mytable.newkey, mymetatable.newkey)

-- ---key1的值被添加到mytable中
-- mytable.key1 = "new val 1"
-- print(mytable.key1, mymetatable.key1)

---------------newindex function------------------

-- mytable = setmetatable({key1 = "v1"},{
--     __newindex = function (mytable, key, value)
--         print("newindex function set")
--         rawset(mytable, key, value .. "_from newindex")
--     end
-- })

-- mytable.key1 = "new value"
-- ---设置key2时，调用了newindex所绑定的方法
-- mytable.key2 = 4

-- print(mytable.key1, mytable.key2)

---------------add function------------------

-- mytable = setmetatable({1,2,3}, {
--     __add = function (mytable, newtable)
--         print("table add")
--         local mcount = #mytable
--         for i = 1, #newtable do
--             table.insert(mytable, mcount + i, newtable[i])
--         end
--         return mytable
--     end
-- })

-- table2 = {4,5,6}
-- table3 = {7}

-- ---定义表相加的方法
-- mytable = mytable + table2
-- mytable = mytable + table3

-- for i, v in ipairs(mytable) do
--     print(i,v)
-- end

---------------call function------------------

-- mytable = setmetatable({10}, {
--     __call = function (mytable, val)
--         print("call", val)
--         return val .. "_fromcall"
--     end
-- })

---把该表当做方法一样调用时，会执行call绑定的方法
-- print(mytable(123))

---------------tostring function------------------

-- mytable = setmetatable({1,2,3}, {
--     __tostring = function (mytable)
--         print("call tostring")
--         local res = ""
--         for i, v in ipairs(mytable) do
--             res = res .. '_'..  v
--         end
--         return res
--     end
-- })

-- print(mytable)

---------------协同程序------------------

-- co = coroutine.create(function (i)
--     print(i)
-- end)

-- print(coroutine.status(co))
-- coroutine.resume(co, 1)
-- print(2)
-- print(coroutine.status(co))

-- print("-------------------")

-- co = coroutine.wrap(
--     function (i)
--         print(i)
--     end
-- )

-- co(1)

-- co = coroutine.create(function ()
--     for i = 1, 10, 1 do
--         print(i)
--         if i == 3 then
--             print(coroutine.status(co))
--             print(coroutine.running())
--         end
--         coroutine.yield()
--     end
-- end)

-- coroutine.resume(co)
-- coroutine.resume(co)
-- coroutine.resume(co)

-- print(coroutine.status(co))
-- print(coroutine.running())

-- function test()
--     local a = 1
--     assert(a == 2, "a != 2")
--     print(111)
-- end

-- test()
-- print(222)

function test2()
    print(a.b)
end

function printErr()
    print("printErr")
    print(debug.traceback()) 
end

print(11)
-- local res,msg = pcall(test2)
-- print(res,msg)
xpcall(test2, printErr)
print(22)




