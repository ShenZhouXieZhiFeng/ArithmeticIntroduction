
function MaxNum(arr)

    local tempArr = {}
    
    table.sort(arr, function (a, b)
        local str1 = tostring(a) .. tostring(b)
        local str2 = tostring(b) .. tostring(a)
        return tonumber(str1) > tonumber(str2)
    end)

    local res = ""
    for k, v in ipairs(arr) do
        res = res .. v
    end
    return res
end

local arr = {3,30,34,5,9}
local res = MaxNum(arr)
print(res)