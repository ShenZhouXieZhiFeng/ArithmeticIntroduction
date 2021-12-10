---@diagnostic disable: lowercase-global

---四数之和

function forSum(nums, target)
    table.sort(nums, function (a, b)
        return a < b
    end)

    local tempArr = {}
    local resArr = {}
    findNSum(nums, target, 4, tempArr, resArr)

    return resArr
end

function findNSum(nums, target, n, tempArr, resArr)
    local length = #nums
    if length < n or n < 2 then
        return
    end

    ---最小子问题，两数之和
    if n == 2 then
        local l = 1
        r = length
        while l < r do
            local sum = nums[l] + nums[r]
            if sum < target then
                l = l + 1
            elseif sum > target then
                r = r - 1
            else
                table.insert(tempArr, nums[l])
                table.insert(tempArr, nums[r])
                table.insert(resArr, tempArr)
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
    else
        for i, v in ipairs(nums) do
            if i == 1 or (i > 1 and nums[i] ~= nums[i]) then
                ---取i+1到最后
                local newNums = {}
                for k=i+1,length do
                    table.insert(newNums,nums[k])
                end
                ---子目标
                local newTarget = target - nums[i]
                local newN = n - 1
                table.insert(tempArr, nums[i])
                findNSum(newNums, newTarget, newN, tempArr, resArr)
            end
        end
    end
end

local arr = {1, 0, -1, 0, -2, 2} --- -2 -1 0 0 1 2
local target = 0

local resArr = forSum(arr, target)
for i, v in ipairs(resArr) do
    print("-----------------")
    local str = ''
    for i2, v2 in ipairs(v) do
        str = str .. v2 .. " "
    end
    print(str)
end