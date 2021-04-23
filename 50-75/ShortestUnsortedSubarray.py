def findUnsortedSubarray(nums):
    start = 0
    end = len(nums)-1

    while start<end:
        s,e = start,end
        if nums[start+1] >= nums[start]:
            start+=1
        if nums[end-1] <= nums[end] and end-1 > start:
            end-=1
        if start == s and end == e:
            break
    if start!=end: start-=1
    return end-start

print(findUnsortedSubarray([1,3,2,4,5]))
print(findUnsortedSubarray([2,6,4,8,10,9,15]))
print(findUnsortedSubarray([1,3,2,2,2]))
