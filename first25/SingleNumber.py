# NlogN solution
def singleNumber(self, nums):
    if len(nums) < 1:
        return
    if len(nums) == 1:
        return nums[0]
    nums.sort()
    if nums[0] != nums[1]:
        return nums[0]
    for i in range(1,len(nums)-1):
        if nums[i] != nums[i+1] and nums[i] != nums[i-1]:
            return nums[i]
    if nums[-1] != nums[-2]:
        return nums[-1]
    else:
        print("not found")
        return "not found"

# O(N) time and space solution
# we can sum a set of the numbers *2 (doubles even the single number) and sum the array
# the result of the difference is the number we are looking for since there is only one
def singleNumber(self, nums):
    def singleNumber(self, nums):
        return 2 * sum(set(nums)) - sum(nums)



# bit manipulation my brain is too small for this shit
# basically we use the logic that no matter what combination
# of binary numbers we have, they will cancel each other out all except for the single value
def singleNumber(self, nums):
    """
    :type nums: List[int]
    :rtype: int
    """
    a = 0
    for i in nums:
        a ^= i
    return a

# &	a & b	Bitwise AND
# |	a | b	Bitwise OR
# ^	a ^ b	Bitwise XOR (exclusive OR)
# ~	~a	Bitwise NOT
# <<	a << n	Bitwise left shift
# >>	a >> n	Bitwise right shift