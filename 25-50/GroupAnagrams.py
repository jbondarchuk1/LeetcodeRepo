def groupAnagrams(strs):
    # hash string's value (key) with index (value)
    dic = {}
    # 2d array with groupings for strings with same string value
    anag = []
    for i in range(len(strs)):
        string = strs[i]
        value = None
        for letter in string:
            if value == None:
                value = hash(letter)
            else:
                value*=hash(letter)
        if value in dic.keys():
            anag[dic[value]].append(string)
        else:
            dic[value] = len(anag)
            anag.append([string])
    return anag

print(groupAnagrams(["eat","tea","tan","ate","nat","bat"]))

# faster still using hashmap
# map.values returns a 2d array of the hashmap values
def groupAnagrams(strs):
    map = {}
    for s in strs:
        sorted_str = ''.join(sorted(s))
        if sorted_str in map:
            map[sorted_str].append(s)
        else:
            map[sorted_str] = [s]
    return map.values()

# sorting uses less on memory and equal speed
def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
    
    d = defaultdict(list)
    
    for s in strs:
        d[''.join(list(sorted(s)))] += [s]
    
    return list(d.values())

