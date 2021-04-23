# i need a break from this brain tired
def maxProduct(nums):
    smneg,currmax = None,nums[0]
    if currmax < 0: smneg = nums[0] 

    for i in range(1,len(nums)):
        start = nums[i]
        if nums[i] == 0: smneg = None
        
        # each spot will start as the highest magnitude between nums of i and i*i-1
        mult = 1
        if nums[i]*nums[i-1] < 0: mult = -1
        nums[i] = max(nums[i],abs(nums[i]*nums[i-1]))*mult

        if nums[i] < 0:
            if smneg == None: smneg = nums[i]
            else:
                nums[i] = nums[i]/smneg

        if nums[i] > currmax: currmax = nums[i]
        if start > currmax: currmax = start
    return currmax

print(maxProduct([2,-5,-2,-4,3]))



