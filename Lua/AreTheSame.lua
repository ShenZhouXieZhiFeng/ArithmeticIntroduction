
local solution = {}

function solution.comp(a, b)
    if a == nil or b == nil then
        return false
    end
    if #a == 0 and #b == 0 then
        return true
    end
    if #a ~= #b then
        return false
    end
    local c = {}
    local count = 0
    for i, v in ipairs(a) do
        local val = v * v
        local hasFit = false
        for i2, v2 in ipairs(b) do
            if c[i2] == nil then
                if v2 == val then
                    hasFit = true
                    c[i2] = 1
                    count = count + 1
                    break
                end
            end
        end
        if not hasFit then
            return false
        end
    end
    if count ~= #b then
        return false
    end
    return true
end

function solution.comp2(a, b)
    if a == nil or b == nil or #a ~= #b then
        return false
    end
    for i=1,#a do
        a[i] = a[i] * a[i]
    end

    table.sort(a, function (a,b) return a < b end)
    table.sort(b, function (a,b) return a < b end)

    for i=1,#b do
        if a[i] ~=b[i] then
            return false
        end
    end
    return true
end

-- return solution

local a1 = {121, 144, 19, 161, 19, 144, 19, 11}
local a2 = {121, 14641, 20736, 361, 25921, 361, 20736, 361}
local res = solution.comp2(a1, a2)
print(res)