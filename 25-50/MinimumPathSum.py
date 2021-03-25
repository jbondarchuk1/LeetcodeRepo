# 2slow
# wrong answer currently, not sure why
import math
def minPathSum(grid,m=None,n=None):
    if m == None or n == None:
        m = len(grid)
        n = len(grid[0])

    if m <= 0 or n <= 0:
        return math.inf

    currVal = grid[-1][-1]
    if m == 1 and n == 1:
        return grid[0][0]
    
    minusN = grid.copy()
    for i in range(len(minusN)):
        newlist = []
        for item in minusN[i][:n-1]:
            newlist.append(item)
        minusN[i] = newlist
    minusM = grid.copy()[:m-1]

    return min(
        minPathSum(minusM,m-1,n) + currVal,
        minPathSum(minusN,m,n-1) + currVal
        )


def minPathSum(grid,m=None,n=None,memo={}):
    if m == None or n == None:
        m = len(grid)
        n = len(grid[0])
    
    key = str(m)+str(n)
    if key in memo:
        return memo[key]
    
    if m <= 0 or n <= 0:
        memo[key] = math.inf
        return memo[key]

    currVal = grid[-1][-1]
    if m == 1 and n == 1:
        memo[key] = grid[0][0]
        return memo[key]
    
    minusN = grid.copy()
    for i in range(len(minusN)):
        newlist = []
        for item in minusN[i][:n-1]:
            newlist.append(item)
        minusN[i] = newlist
    minusM = grid.copy()[:m-1]

    memo[key] = min(
        minPathSum(minusM,m-1,n) + currVal,
        minPathSum(minusN,m,n-1) + currVal
        )

    return memo[key]



    
# print(minPathSum([[1,3,1],[1,5,1],[4,2,1]]))
print(minPathSum(
    [
        [5,1,0,4,0,1,1,6,7,3,9,9,4,6,8,1],
        [9,1,0,6,4,2,8,0,1,6,0,2,7,9,0,4],
        [3,2,0,3,3,3,1,3,7,3,2,1,1,2,2,0],
        [5,2,8,2,7,6,2,0,5,3,2,4,4,4,8,9],
        [7,0,5,2,4,6,7,1,1,1,2,2,6,6,4,1],
        [0,3,5,9,1,8,0,6,3,4,0,9,9,0,9,8],
        [3,4,0,7,2,8,0,4,9,4,8,5,2,5,9,4],
        [0,4,4,1,4,6,0,7,0,2,7,1,3,8,9,8],
        [2,0,7,4,0,7,0,1,1,1,9,5,6,8,9,6],
        [4,3,9,9,1,9,8,4,2,7,5,7,5,5,5,9],
        [7,4,6,9,1,8,0,4,9,9,9,7,9,8,3,4],
        [4,3,5,7,4,5,1,8,3,7,7,0,4,4,2,3],
        [8,0,2,9,8,2,5,8,4,4,7,3,5,1,9,1],
        [6,4,8,2,2,2,1,7,1,8,7,5,5,1,0,3],
        [1,2,5,0,6,0,0,0,7,7,6,4,0,5,5,8],
        [2,5,1,4,9,4,1,0,2,0,5,7,4,7,3,5],
        [9,8,7,8,8,9,8,5,9,6,9,9,2,6,0,6],
        [4,1,2,3,5,5,4,9,5,1,9,9,9,2,7,0],
        [0,6,8,0,6,9,8,7,5,7,8,9,6,8,5,0]
]))