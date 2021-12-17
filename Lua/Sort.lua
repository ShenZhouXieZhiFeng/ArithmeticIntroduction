---@diagnostic disable: lowercase-global

---选择排序
function selectSort(arr)
    local n = #arr
    for i=1,n-1,1 do
        local maxIndex = i
        for j=i+1,n,1 do
            if arr[j] > arr[maxIndex] then
                maxIndex = j
            end
        end        
        if i ~= maxIndex then
            swap(arr, i, maxIndex)
        end
    end
end

---冒泡排序
function maoPaoSort(arr)
    for i=#arr,1,-1 do
        for j=1,i-1,1 do
            if arr[j] > arr[j+1] then
                swap(arr, j, j+1)
            end 
        end
    end
end

function swap(arr, i, j)
    local temp = arr[i]
    arr[i] = arr[j]
    arr[j] = temp
end

local arr = {4,6,1,8,2}
-- selectSort(arr)
maoPaoSort(arr)
for i, v in ipairs(arr) do
    print(i, v)
end