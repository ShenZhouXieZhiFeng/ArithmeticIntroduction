
function Numerator(num, den)
    local n = math.modf(num / den)
    local remain = math.fmod(num, den)
    if remain == 0 then
        return num / den
    end
    local seen = {}
    local res = tostring(n)
    while not table.find(seen, remain) do
        table.insert(seen, remain)
        n = math.modf(remain * 10 / den)
        remain = math.fmod(remain * 10, den)
        res = res .. n
    end

    return res
end

function table.find(arrs, val)
    for i, v in ipairs(arrs) do
        if v == val then
            return true
        end
    end
    return false
end

print(Numerator(1, 2))
print(Numerator(3, 4))
print(Numerator(2, 1))

-- print(math.fmod(2,3))
-- print(math.modf(20/3))