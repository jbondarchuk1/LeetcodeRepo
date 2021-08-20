# good idea, but flawed
def findUnsortedSubarray(nums):
    start = 0
    end = len(nums)-1
    startreps = 0
    endreps = 0

    while start<end:
        s,e = start,end
        if nums[start+1] > nums[start] and nums[start] <= nums[end]:
            start+=1
            startreps=0
        elif nums[start+1] == nums[start]:
            start+=1
            startreps+=1
            
        if nums[end-1] < nums[end] and nums[start] <= nums[end]:
            end-=1
            endreps = 0
        elif nums[end-1] == nums[end]:
            end-=1
            endreps+=1
        if start == s and end == e:
            return 0
    return end-start+1+startreps+endreps

# the real solution
def findUnsortedSubarray(nums):
    start = 0
    end = len(nums)-1

    if len(nums) < 2: return 0

    while start < end and nums[start] <= nums[start+1]:
        start+=1
    while end > 0 and nums[end] >= nums[end-1]:
        end-=1

    if start > end: return 0

    new = nums[start:end+1]
    maxi = max(new)
    mini = min(new)

    while start > 0 and nums[start-1] > mini:
        start-=1
    while end < len(nums)-1 and nums[end+1] < maxi:
        end+=1

    return end-start+1