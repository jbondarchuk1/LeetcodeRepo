import math
def minPathSum(grid):
    m = len(grid)-1
    n = len(grid[0])-1

    def recurse(grid,m,n,memo={}):
        key = (m,n)
        if key in memo:
            return memo[key]

        if m < 0 or n < 0:
            memo[key] = math.inf
            return memo[key]

        currVal = grid[m][n]
        if m == 0 and n == 0:
            memo[key] = currVal
            return memo[key]

        memo[key] = currVal + min(
            recurse(grid,m-1,n,memo),
            recurse(grid,m,n-1,memo)
            )

        return memo[key]
    return recurse(grid,m,n)

# fantastic solution
def minPathSum(grid):
    table = [[math.inf for i in range(len(grid[0])+1)] for i in range(len(grid)+1)]

    for i in range(1,len(grid)+1):
        for j in range(1,len(grid[0])+1):
            if i == 1 and j == 1:
                table[1][1] = grid[0][0]
            else:
                table[i][j] = min(table[i-1][j],table[i][j-1]) + grid[i-1][j-1]
    return table[-1][-1]
    
print(minPathSum([[1,3,1],[1,5,1],[4,2,1]]))