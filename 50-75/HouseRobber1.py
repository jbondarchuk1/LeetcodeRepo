# works but slow, dynamic programming?
def rob(nums, idx=0,last=None, total=0):
    if idx >= len(nums):
        return total
    if last == True:
        w = rob(nums,idx+2,False,total)
        return w
    else:
        w = rob(nums,idx+1,False,total)
        wo = rob(nums,idx,True,total+nums[idx])
        return max(w,wo)

def rob(nums, idx=0, memo={}):
    if idx in memo: return memo[idx]
    
    if idx >= len(nums): return 0
    w = rob(nums,idx+2) + nums[idx]
    wo = rob(nums,idx+1)
    memo[idx] = max(w,wo)
    return memo[idx]


def rob(nums):
    for i in range(len(nums)):
        wo = 0
        w = nums[i]
        if i-1 >= 0:
            wo = nums[i-1]
        if i-2 >= 0:
            w+= nums[i-2]
        nums[i] = max(w,wo)
    return nums[-1]
