def permute(self, nums: List[int]) -> List[List[int]]:
    perms = []
    if len(nums)==0:
        return [[]]
    for i in range(len(nums)):
        first = nums[i]
        rest = nums[:i] + nums[i+1:]
        for element in self.permute(rest):
            perms.append([first] + element)
    return perms