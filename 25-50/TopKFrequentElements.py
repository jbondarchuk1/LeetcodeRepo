# cheating with python built-ins
from collections import Counter
def topKFrequent1(nums, k):
    count = Counter(nums).most_common(k)
    newcount = []
    for num in count:
        newcount.append(num[0])
    return newcount

topKFrequent1([1,1,1,2,2,3],2)

# nlogn sort dictionary by values after counting
def topKFrequent(nums, k):
    ans=[]
    dic = {}
    for num in nums:
        try:
            dic[num]+=1
        except:
            dic[num] = 1
    sort = sorted(dic.keys(),key=lambda x: dic[x],reverse=True)
    for i in range(k):
        ans.append(sort[i])
    print(ans)

topKFrequent([1,1,1,2,2,3],2)