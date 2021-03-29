def decodeString(s):
    newS = ''
    regidx = 0
    for i in range(len(s)):
        if s[i].isdigit() and i >= regidx:
            numidx = i
            while s[numidx].isdigit():
                numidx+=1
            num = int(s[i:numidx])
            #s[i+1] is '(', s[i+2] is a char
            start = end = numidx+1
            # assume we passed an open bracket
            opn = 1
            while opn != 0:
                if s[end] == '[':
                    opn += 1
                elif s[end] == ']':
                    opn -=1
                end += 1
            # recurse the function starting at the first non '[' char and ending on the first non ']' char
            # multiply the inside by the integer
            regidx = end
            # print(s[start:end-1])
            newS += num*decodeString(s[start:end-1])

            # print(regidx)
        elif i >= regidx:
            newS+= s[i]
    return newS


print(decodeString("3[a]2[bc]")=="aaabcbc")
print(decodeString("2[abc]3[cd]ef")=="abcabccdcdcdef")
print(decodeString("abc3[cd]xyz")=="abccdcdcdxyz")
print(decodeString("3[a2[c]]")=="accaccacc") # =="accaccacc"
# print(decodeString("100[leetcode]"))