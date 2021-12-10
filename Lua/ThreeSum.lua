---@diagnostic disable: lowercase-global

function threeSum(nums)
    
    local res = {}

    table.sort(nums, function (a, b)
        return a < b
    end)

    local n = #nums

    for i = 1, n - 2, 1 do
        ---去重
        if i > 1 and nums[i] == nums[i-1] then
            do end
        else
            local l = i + 1
            local r = n
            while l < r do
                if nums[i] + nums[l] + nums[r] < 0 then
                    l = l + 1
                elseif nums[i] + nums[l] + nums[r] > 0 then
                    r = r - 1
                else
                    table.insert(res, {nums[i], nums[l], nums[r]})
                    ---去重
                    while l < r and nums[l] == nums[l + 1] do
                        l = l + 1
                    end
                    while l < r and nums[r] == nums[r - 1] do
                        r = r - 1       
                    end
                    l = l + 1
                    r = r - 1
                end
            end
        end
    end

    return res
end

---查找所有三数之和为0的组合
local a = {-1, 0, 1, 2, -1, -4}
local arr = threeSum(a)
for i, v in ipairs(arr) do
    print("-----------------")
    for i2, v2 in ipairs(v) do
        print(v2)
    end
end