def isValid(self, s: str) -> bool:
    if not s:
        return False
    start = {
        '(':')',
        '[':']',
        '{':'}'
    }
    close = {
        ']':True,
        '}':True,
        ')':True
    }
    try:
        close[s[0]]
        return False
    except:
        stack = deque()
        for i in range(len(s)):
            try:
                start[s[i]]
                stack.append(start[s[i]])
            except:
                if not stack:
                    return False
                if stack.pop() != s[i]:
                    return False
        if stack:
            return False
    return True