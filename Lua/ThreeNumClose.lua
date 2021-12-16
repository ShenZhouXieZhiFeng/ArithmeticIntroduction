---@diagnostic disable: undefined-global

function ThreeSumClose(nums, target)
    table.sort(nums, function (a, b)
        return a < b
    end)

    local res = 100
    local n = #nums
    for i, v in ipairs(nums) do
        if i > 1 and nums[i] == nums[i - 1] then
            do end
        else
            local l = i + 1
            local r = n
            while l < r do
                local sum = nums[i] + nums[l] + nums[r]
                if sum == target then
                    return sum
                end
    
                if math.abs(sum - target) < math.abs(res - target) then
                    res = sum
                end
    
                if sum < target then
                    l = l + 1
                elseif sum > target then
                    r = r - 1
                end
            end
        end
    end
    return res
end

local nums = {-1, 2, 1, -4}
local res = ThreeSumClose(nums, 1)
print(res)