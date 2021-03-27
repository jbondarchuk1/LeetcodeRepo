# do this later
import re
def decodeString(s):
    ans = ''
    maxi = len(s)-1
    point = 0
    stack = []

    while point <= maxi:
        if s[point].isdigit():
            stack.append(point)
            point+=2
        


        point += 1