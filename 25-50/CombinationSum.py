# i really struggled with this one, please review future jason
# literally a bottom 10 for both memory and time this is horrible
def combinationSum(candidates,target):
    combos = []
    dic = {}
    def recurse(candidates,target,arr=[], mysum = 0):
        myhash = ""
        for val in arr: myhash+= str(val)
        if myhash in dic:
            return
        dic[myhash] = arr

        if mysum == 0:
            mysum = sum(arr)

        if mysum >= target:
            if mysum == target:
                combos.append(arr)
            return

        for i in range(len(candidates)):
            if myhash+str(candidates[i]) not in dic:
                recurse(candidates[i:],target,arr+[candidates[i]], mysum+candidates[i])
            recurse(candidates[i+1:],target,arr,mysum)

    recurse(candidates,target)
    vals = combos
    return vals
# print(combinationSum([2,3,7,6],7))

def combinationSum(candidates,target):
    ans = []
    def driver(temp, current, total):
        if total == target:
            ans.append(temp)
        elif total > target:
            temp.pop(-1)
        else:
            for i in range(current, len(candidates)):
                c = candidates[i]
                driver(temp+[c], i, total+c)

    for i in range(len(candidates)):
        c = candidates[i]
        driver([c], i, c)

    return ans

print(combinationSum([2,3,7,6],7))


def combinationSum(self, candidates: List[int], target: int) -> List[List[int]]:
    solutions = []
    
    def find(candidate_index, combination):
        current_sum = sum(combination)
        if current_sum == target:
            solutions.append(combination[:])
            return
        
        for next_index in range(candidate_index, len(candidates)):
            if current_sum + candidates[candidate_index] > target:
                return
            combination.append(candidates[next_index])
            find(next_index, combination)
            combination.pop()
    
    candidates.sort()
    find(0, [])
    return solutions
