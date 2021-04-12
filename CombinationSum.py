# i literally cant get this wtf
def combinationSum(candidates, target):
    solutions = []
    candidates.sort()
    
    def recurse(arr, target, subbuild=[]):
        for i in range(1,len(arr)+1):
            # print(target, candidates[-i])
            sub = target - candidates[-i]
            if sub == 0:
                newSubBuild = [] + subbuild + [candidates[-i]]
                solutions.append(newSubBuild)
            elif sub > 0:
                newSubBuild = [] + subbuild + [candidates[-i]]
                print(arr[:len(arr)-i])
                recurse(arr[:len(arr)-i],sub,newSubBuild)

    recurse(candidates, target)
    return solutions




# actual answer
def combinationSum(candidates, target):
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


print(combinationSum([2,3,6,7],7))
