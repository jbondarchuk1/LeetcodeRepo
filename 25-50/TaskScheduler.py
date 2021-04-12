from heapq import *
from collections import Counter

def leastInterval(tasks, n):
    if n == 0:
        return len(tasks)
    
    # counter with negative count, O(tasks)
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



def leastInterval(tasks, n):
    counter = Counter(tasks)
    # max heap, less code
    heap = [(-v,k) for k,v in counter.items]
    heapify(heap)
    ans = 0
    while heap:
        count = 0
        cache = []
        while i <= n:
            if heap:
                v,k = heappop(heap)
                if -v > 1:
                    # tuple of [v+1,k]
                    cache.append((v+1,k))
            ans+=1
            if not heap and not cache:
                break
            count+=1
        for kv in cache:
            heappush(heap,l)
    
    return ans

'''
Example explanation:

tasks = ["A","A","A","B","B","B"], n = 2

Procedure:
1.
# Build a dictionary for tasks
# key   : task
# value : occurrence of task

max_occ = 3

number_of_taks_of_max_occ = 2 with {'A', 'B'}

2.
#Make (max_occ - 1) = 2 groups, groups size = n+1 = 3
#Fill each group with uniform iterleaving as even as possible

group = '_ _ _' with size = 3

=> make 2 groups with uniform iterleaving 

A B _ A B _

3.
# At last, execute for the last time of max_occ jobs

A B _ A B _ A B


length of task scheduling with cooling = 8

'''


from collections import Counter

class Solution:
    def leastInterval(self, tasks: List[str], n: int) -> int:
        
        if n == 0:
            # Quick response for special case on n = 0
            # no requirement for cooling, just do those jobs in original order
            return len(tasks)
        
        
        # key   : task
        # value : occurrence of tasks 
        task_occ_dict = Counter( tasks )
        
        # max occurrence among tasks
        max_occ = max( task_occ_dict.values() )
        
        # number of tasks with max occurrence
        number_of_taks_of_max_occ = sum( ( 1 for task, occ in task_occ_dict.items() if occ == max_occ ) )
        
        # Make (max_occ-1) groups, each groups size is (n+1) to meet the requirement of cooling
        # Fill each group with uniform iterleaving as even as possible
        
        # At last, execute for the last time of max_occ jobs
        intervl_for_schedule = ( max_occ-1 )*( n+1 ) + number_of_taks_of_max_occ
        
        # Minimal length is original length on best case.
        # Otherswise, it need some cooling intervals in the middle
        return max( len(tasks), intervl_for_schedule)