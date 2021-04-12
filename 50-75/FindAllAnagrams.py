# works but too slow
from collections import Counter
def findAnagrams(self, s: str, p: str):
    ans = []
    # use a counter but im close
    setp = Counter()
    for letter in p:
        if letter in setp:
            setp[letter]+=1
        else: setp[letter] = 1
    
    start = 0
    while start <= len(s)-1:
        if s[start] in setp:
            end = start
            check = setp.copy()
            while end-start <= len(p)-1 and end<len(s):
                if s[end] in check:
                    check[s[end]]-=1
                    if check[s[end]]<=0:
                        del check[s[end]]
                    end+=1
                    if len(check) == 0:
                        ans.append(start)
                        break
                else:
                    break
        start+=1
    return ans

# slow and medium mem
def findAnagrams(s,p):
    ans = []
    check = Counter()
    for letter in p:
        if letter in check: check[letter]+=1
        else: check[letter] = 1
    
    start = 0
    end = 0
    verify = Counter()
    while end <= len(s)-1:
        if end > len(p)-1:
            verify[s[start]]-=1
            if verify[s[start]] <=0:
                del verify[s[start]]
            start+=1

        if s[end] in verify:
            verify[s[end]]+=1
        else: verify[s[end]] = 1
        if verify==check:
            ans.append(start)
        end+=1
    return ans

# fast but high mem
def findAnagrams(s,p):
    ans = []
    check = sum(hash(letter) for letter in p)
    currentHash = 0

    start,end=0,0
    while end <= len(s)-1:
        if end > len(p)-1:
            currentHash-=hash(s[start])
            start+=1

        currentHash+=hash(s[end])
        if currentHash==check:
            ans.append(start)
        end+=1
    
    return ans

print(findAnagrams("cbaebabacd","abc"))
