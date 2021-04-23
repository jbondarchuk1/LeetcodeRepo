# we gotem boss thats why you're the best
import math
def jump(nums):
    table = [math.inf for i in range(len(nums)-1)] + [0]

    for i in range(len(nums)-2,-1,-1):
        if i+nums[i] >= len(nums)-1:
            table[i] = 1
        elif nums[i] == 0: table[i] = math.inf 

        else:
            count=math.inf
            for j in range(nums[i]+1):
                if i+j < len(nums)-1:
                    count=min(count,table[i+j])
            if count < math.inf: count+=1
            table[i] = count
    return table[0]



arr = [2,3,0,1,4]
print(jump(arr))