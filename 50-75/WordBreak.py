# works insanely fast
def wordBreak(self, s: str, wordDict: List[str]) -> bool:
    d = {}
    # initialize the dictionary
    for word in wordDict:
        if word[0] in d: d[word[0]].append(word)
        else: d[word[0]] = [word]

    def recurse(s,d,end=0,check=False,memo={}):
        if s[end] not in d or end > len(s): return False
        if end in memo: return memo[end]
        for word in d[s[end]]:
            sword = s[end:len(word)+end]
            if word == sword:
                newend=end + len(word)
                if newend >= len(s): 
                    return True
                check = check or recurse(s,d,newend,check)
                memo[end] = check
        return check
    return recurse(s,d) 

print(wordBreak("cars",["car","ca","rs"]))
    