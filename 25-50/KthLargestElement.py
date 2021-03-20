# why is this a medium problem wtf
def findKthLargest(self, nums: List[int], k: int) -> int:
    nums.sort()
    return nums[-k]

# heap just as efficient. heappush is logn and so is heappop so total time is nlogn
import heapq
def findKthLargest(self,nums):
    arr = []
    for num in nums:
        if len(arr)<k:
            heappush(arr,num)
        else:
            heappushpop(arr,num)
    print(arr)
    return arr[0]

