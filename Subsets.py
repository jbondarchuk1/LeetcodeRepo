# this is literally just combinations

def recurse(nums):
    if len(nums) == 0:
        return [[]]
    first = nums[0]
    rest = nums[1:]
    currentSubsets = recurse(rest)

    newSubsets = []

    for element in currentSubsets:
        newEl = []
        for item in element:
            newEl.append(item)
        newEl.append(first)
        newSubsets.append(newEl)
    
    return currentSubsets + newSubsets

print(recurse([1,2,3]))


