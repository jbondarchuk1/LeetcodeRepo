# kadane's algorithm finds the max subarray

def maxSubArray(self, nums: List[int]) -> int:
    for i in range(1, len(nums)):
        # nums[i] is the max from every value from 0 to the current value
        # once nums[i-1] is 0, we start a new total
        # calling max(nums) scans for the largest value, this is our answer
        if nums[i-1] > 0:
            nums[i] += nums[i-1]
    return max(nums)

