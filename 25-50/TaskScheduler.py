from heapq import *
# in progress goin to bed
def leastInterval(tasks, n):
    if n == 0:
        return len(tasks)
    
    # counter with negative count
    dic = {}
    for task in tasks:
        if task in dic:
            dic[task]-=1
        else:
            dic[task] = -1
    
    # max heap with (val,key)
    heap = []
    for key in dic.keys():
        val = dic[key]
        heappush(heap,(val, key))
    
    # answer will be returned, cache will hold values we pop until we are ready to push them again
    ans = []
    cache = []
    
    count = n + 1
    while heap:
        while count > 0:
            if heap:
                valkey = heappop(heap)
                if valkey[0] < 0:
                    ans.append(valkey[1])
                    # print(valkey[1],count)
                    cache.append(valkey[1])
                    dic[valkey[1]] += 1
                    count-=1
            else:
                ans.append(" ")
                count -=1
                    
        for i in range(len(cache)):
            key = cache.pop()
            if dic[key] < 0:
                val = dic[key]
                heappush(heap,(val,key))
        count = n + 1

    for i in range(1,n+1):
        if ans[-1] == ' ':
            ans.pop()
    return len(ans)

print(leastInterval(["A","A","A","A","A","A","B","C","D","E","F","G"], 2))
print(leastInterval(["A","A","A","B","B","B"], 2))
print(leastInterval(["A","A","A","A","A","A","B","C","D","E","F","G"], 1))
print(leastInterval(["A","A","A","B","B","B"], 0))
