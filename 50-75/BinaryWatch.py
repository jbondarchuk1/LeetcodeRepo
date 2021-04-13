def readBinaryWatch(self, turnedOn: int) -> List[str]:
    watch = [1,2,4,8,1,2,4,8,16,32]
    indices = [i for i in range(len(watch))]
    # return every combination (order does not matter) in turnedOn C len(watch),
    # then calculate the time for each
    def combos(arr):
        if len(arr)==0: return [[]]
        first,rest = arr[0],arr[1:]
        
        combswithout = combos(rest)
        combswith = []
        for el in combswithout:
            c = el.copy()+[first]
            combswith.append(c)
        return combswith + combswithout
    
    combs = combos(indices)
    ans = []
    for el in combs:
        if len(el) == turnedOn:
            hrs,mins = 0,0
            for light in el:
                if light<=3: hrs+=watch[light]
                else: mins+=watch[light]
            if hrs < 12 and mins < 60:
                s = ''
                s+= str(hrs)+':'
                if mins < 10: s+='0'
                s+=str(mins)
                ans.append(s)
    return ans