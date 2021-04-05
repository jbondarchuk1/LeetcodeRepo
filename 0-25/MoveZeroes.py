def moveZeroes(nums):
    zeroCount = 0
    for i in range(len(nums)):
        if nums[i] == 0:
            zeroCount += 1
        elif nums[i] != 0 and zeroCount > 0:
            nums[i-zeroCount],nums[i] = nums[i],nums[i-zeroCount]
    return nums

mylist = [0,1,0,3,12]
print(moveZeroes(mylist))