# HAHA ITS SO SLOW LMAOOO
def countBits(self, num: int) -> List[int]:
    ones = []
    def maxDenom(number):
        denom = 1
        while number//denom > 0:
            if number//(denom*2) == 0:
                break
            denom*=2
        return denom
    
    for i in range(num+1):
        number = i
        denom = maxDenom(number)  
            
        r = number%denom
        count = 1
        if number == 0:
            count = 0
            
        while r>0:
            number = r
            denom=maxDenom(number)
            count+=1
            r = number%denom
            
        ones.append(count)
    return ones

# better solution
def countBits(self, num: int) -> List[int]:
    res = []
    prev = 1
    
    for i in range(num + 1):
        if i == 0:
            res.append(0)
        elif i == prev:
            res.append(1)
            prev = 2 * prev
        else:
            res.append(1 + res[i - prev])
    
    return res