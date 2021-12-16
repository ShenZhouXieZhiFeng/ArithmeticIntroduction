require("Lua/class")

local a = 10
print("a")

-- local loadedModes = package.loaded
-- for k, v in pairs(loadedModes) do
--     print(k, v)
-- end

local TestClass = class("TestClass")

function TestClass:printName()
    print("my name is TestClass")
end
