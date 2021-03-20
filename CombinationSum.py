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

print(combinationSum([2,3,6,7],7))