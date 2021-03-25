def twoSum(self, nums: List[int], target: int) -> List[int]:
    dic = {}
    for i in range(len(nums)):
        if nums[i] in dic:
            dic[nums[i]].append(i)
        else:
            dic[nums[i]] = [i]
    for i in range(len(nums)):
        sub = target-nums[i]
        if sub in dic and sub == nums[i] and len(dic[sub])>1:
            return [dic[nums[i]][0],dic[sub][1]]
        elif sub in dic and sub != nums[i]:
            return [dic[nums[i]][0],dic[sub][0]]

# for some reason this was significantly faster even though its O(n^2)
def twoSum(self, nums: List[int], target: int) -> List[int]:
    for i in range(len(nums)):
        for j in range(len(nums)):
            if nums[i] + nums[j] == target and i!=j:
                return [i,j]