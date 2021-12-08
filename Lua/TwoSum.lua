---@diagnostic disable: lowercase-global
---两数之和

function twoSum(nums, target)
    table.sort(nums, function (a, b)
        return a < b
    end)

    local i1 = 1
    local i2 = #nums

    while i1 < i2 do
        local sum = nums[i1] + nums[i2]
        if sum == target then
             return i1-1, i2-1
        end
        if sum > target then
            i2 = i2 - 1
        elseif sum < target then
            i1 = i1 + 1
        end
    end

end

function twoSum2(nums, target)
    
    ---空间换时间
    local temp = {}
    for i, v in ipairs(nums) do
        local diff = target - v
        if temp[diff] ~= nil then
            return temp[diff],i
        else
            temp[v] = i
        end
    end

    return 0,0
end

local mNums = {2,7,11,15}
local target = 9

-- local k1, k2 = twoSum(mNums, target)
local k1, k2 = twoSum2(mNums, target)
print(k1, k2)

