# slow but simple version, low memory
def countSubstrings(self,s):
    palin = 0

    for i in range(len(s)):
        for j in range(i,len(s)):
            # s[i:j+1] could be s[0:1] which is still just s[0]
            # since j+1 would be noninclusive
            substring = s[i:j+1]
            if substring == substring[::-1]:
                palin+=1
    return palin

# dp fast
def countSubstrings(self,s):
    ans = 0
    for i in range(len(s)):
        ans += self.helper(s, i, i)
        ans += self.helper(s, i, i + 1)
    return ans
            
    def helper(self, s, l, r):
        ans = 0
        while l >= 0 and r < len(s) and s[l] == s[r]:
            l -= 1
            r += 1
            ans += 1
            
        return ans
