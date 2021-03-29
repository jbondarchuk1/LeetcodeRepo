import re
def numDifferentIntegers(word):
    arr = re.split(r'\D', word.strip())
    print(arr)
    hmap = {}
    for item in arr:
        if item!='':
            if item[0] == '0':
                end = 0
                for i in range(len(item)):
                    if end == 0 and item[i] != '0':
                        end = i
                item = item[end:]
            if item not in hmap:
                hmap[item] = True
    return len(hmap)

word = "a1b01c001"
print(numDifferentIntegers(word))