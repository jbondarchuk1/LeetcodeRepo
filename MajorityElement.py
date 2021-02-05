def majorityElement(nums):
    counts = {}
    for num in nums:
        try:
            counts[num] += 1
        except:
            counts[num] = 1
    majority = None
    for num in counts.keys():
        if majority == None:
            majority = num
        if counts[num] > counts[majority]:
            majority = num
            
    return majority

print(majorityElement([2,2,1]))