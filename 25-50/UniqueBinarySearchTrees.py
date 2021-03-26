# JASON
# REMEMBER THAT COMBINATIONS OF TWO THINGS ARE X * Y
# i was trying to add left combinations and right combinations but the number of combinations between the two are x*y
from functools import reduce
def numTrees1(self,n):
    def recurse(mini,maxi,memo={}):
        if mini >= maxi:
            return 1
        if (mini,maxi) in memo:
            return memo[(mini,maxi)]

        total=0
        # from start index (min of 1) to n (up to n+1)

        for i in range(mini,maxi+1):
            
            leftVals = recurse(mini,i-1,memo)
            rightVals = recurse(i+1,maxi,memo)
            
            total+= leftVals * rightVals
        
        memo[(mini,maxi)] = total
        return memo[(mini,maxi)]

    return recurse(1,n)

# im not seeing why this works
def numTrees(n):
    table = [0 for i in range(n+1)]
    table[0] = 1
    for i in range(1,n+1):
        for j in range(i):
            table[i] +=  table[j] * table[i-1-j]
    return table[n]
print(numTrees(3))


# Catalan Number  (2n)!/((n+1)!*n!)  
def numTrees(self, n):
    return math.factorial(2*n)/(math.factorial(n)*math.factorial(n+1))