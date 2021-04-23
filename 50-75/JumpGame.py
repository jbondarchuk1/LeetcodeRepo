def canJump(nums):
    def recurse(nums,i,memo={}):
        if i == len(nums)-1:
            return True
        if (nums[i] == 0 and i < len(nums)-1) or i >= len(nums):
            return False
        
        if i in memo: return memo[i]
        
        can = False
        for j in range(1,nums[i]+1):
            can = can or recurse(nums,i+j,memo)
        memo[i] = can
        return memo[i]
    return recurse(nums,0)

# print(canJump([2,3,1,1,4]))

def canJump(nums):
    last = len(nums)-1
    # start at the second to last, stop at 0 (-1 is a noninclusive end index), iterate backwards
    for i in range(len(nums)-2,-1,-1):
        if nums[i]+i >= last:
            last = i
    return last == 0