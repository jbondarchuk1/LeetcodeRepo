# memoized
def climbStairs(n, memo={}):
    if n == 0 or n==1:
        return 1
    if n in memo:
        return memo[n]
    memo[n] = climbStairs(n-1, memo) + climbStairs(n-2, memo)
    return memo[n]
print(climbStairs(600))

# table
def climbStairs(self,n):
    table = [0 for i in range(n+1)]
    if n <= 1:
        return 1
    table[0] = 1
    for i in range(len(table)):
        if i-1 >= 0:
            table[i]+= table[i-1]
        if i-2 >=0:
            table[i]+= table[i-2]
    return table[n]
print(climbStairs(600))