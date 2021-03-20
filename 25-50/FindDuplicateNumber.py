def findDuplicate(self, nums: List[int]) -> int:
    nums.sort()
    for i in range(1,len(nums)):
        if nums[i-1] == nums[i]:
            return nums[i]

# floyd's tortoise and hare cycle detection problem
def findDuplicate(nums):
    slow,fast = 0,0
    while True:
        slow = nums[slow]
        fast = [nums[nums[fast]]]
        if slow == fast:
            break
    
    slow = 0
    while slow != fast:
        slow = nums[slow]
        fast = nums[fast]
    
    return slow