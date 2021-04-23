# brute force
def subarraySum(self, nums: List[int], k: int) -> int:
    count = 0
    for i in range(1,len(nums)):
        nums[i] += nums[i-1]
    for i in range(len(nums)):
        if nums[i] == k:
            count+=1
        for j in range(i):
            if nums[i]-nums[j] == k:
                count+=1
    return count

from collections import defaultdict
def subarraySum(self,nums, k):
    if not nums:
        return 0
    # hashmap computes running sum of array for each index
    hmap = defaultdict(int)
    hmap[nums[0]] = 1
    count = 0
    if nums[0] == k: count+=1
        
    for i in range(1,len(nums)):
        nums[i] += nums[i-1]
        if nums[i] == k:
            count+=1
        if hmap[nums[i]-k] > 0:
            count+=hmap[nums[i]-k]
        hmap[nums[i]]+=1
    return count