def disappeared(nums):
    arr = [None for i in range(len(nums)+1)]
    disappear = []
    for i in range(len(nums)):
        if not arr[nums[i]]:
            arr[nums[i]] = nums[i]
    for i in range(1,len(nums)+1):
        if arr[i] == None:
            disappear.append(i)
    return disappear

print(disappeared([1,1]))