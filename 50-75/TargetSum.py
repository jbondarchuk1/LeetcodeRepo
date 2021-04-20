# works but slow
def findTargetSumWays(self,nums,s):
    def recurse(nums,s,pointer,r=0, memo={}):
        h = tuple([pointer]+[r])
        if h in memo:
            return memo[h]
        
        if pointer < 0:
            if r==s:
                return 1
            return 0

        new = nums
        end = new[pointer]
        pointer-=1
        memo[h] = recurse(new,s,pointer,r+end) + recurse(new,s,pointer,r-end)
        return memo[h]

    ans = recurse(nums,s,len(nums)-1)
    return ans

print(findTargetSumWays([6,5,9,5,4,9,1,7,5,5],4))


# iterative
def findTargetSumWays(self,nums,S):
    if not nums or sum(nums)<S: return 0
    dic = {0:1}
    for i in range(len(nums)):
        # defaultdict never raises key error and int makes it default all initial values to 0
        temp_dic = collections.defaultdict(int)
        for key in dic:
            temp_dic[key+nums[i]] += dic[key]
            temp_dic[key-nums[i]] += dic[key]
        dic = temp_dic
    return dic[S]