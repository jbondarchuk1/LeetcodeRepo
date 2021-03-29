import re
def evaluate(s, knowledge):
    hmap = {}
    for arr in knowledge:
        hmap[arr[0]] = arr[1]

    arr = re.split('\(|\)',s)
    for i in range(len(arr)):
        if i%2 == 1:
            if arr[i] in hmap:
                arr[i] = hmap[arr[i]]
            else:
                arr[i] = '?'

    s2 = ''
    for i in range(len(arr)):
        s2+=arr[i]
    return s2

print(evaluate("hi(name)", knowledge = [["a","b"]]))
