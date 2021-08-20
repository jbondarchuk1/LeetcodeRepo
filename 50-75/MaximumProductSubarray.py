# i need a break from this brain tired

def maxProduct(nums):
    smneg,currmax = None,nums[0]
    if currmax < 0: smneg = nums[0] 

    for i in range(1,len(nums)):
        start = nums[i]
        prev = nums[i-1]

        if nums[i] == 0: smneg = None

        # each spot will start as the highest magnitude between nums of i and i*i-1
        mag = None
        if abs(start) > abs(start*prev):mag = start
        else: mag = prev*start
        nums[i] = mag

        if nums[i] < 0:
            if smneg == None: smneg = nums[i]
            elif nums[i] > smneg: smneg = nums[i]
            else:currmax = max(   nums[i]/smneg,   currmax   )
        
        if nums[i] > currmax: currmax = nums[i]
        if start > currmax: currmax = start
    return int(currmax)
    

print(maxProduct([2,3,-2,4]))



