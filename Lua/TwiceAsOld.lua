--[[
    Your function takes two arguments:

    current father's age (years)
    current age of his son (years)
    Сalculate how many years ago the father was twice as old as his son (or in how many years he will be twice as old).
]]

local kata = {}

function kata.twice_as_old(dad, son)
    for i=0,son-1,1 do
        local aDad = dad - i
        local aSon = son - i
        local res = aDad / aSon
        if res == 2 then
            return i
        end
    end
    for i=1,100,1 do
        local aDad = dad + i
        local aSon = son + i
        local res = aDad / aSon
        if res == 2 then
            return i
        end
    end
    return 0
end

function kata.twice_as_old2(dad, son)
    ---f+x = s*(s+x)
    return math.abs(dad - 2 * son)
end

local func = kata.twice_as_old
func = kata.twice_as_old2
-- return kata
local res = func(36, 7)
print(res)
res = func(55,30)
print(res)

