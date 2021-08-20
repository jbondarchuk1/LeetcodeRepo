def numIslands(self, grid):
    def dfs(grid,i,j):
        if 0 <= i <= len(grid)-1 and 0 <= j <= len(grid[0])-1:
            if grid[i][j] == '1':
                grid[i][j] = '#'
                dfs(grid,i-1,j)
                dfs(grid,i,j-1)
                dfs(grid,i+1,j)
                dfs(grid,i,j+1)

    ans = 0
    for i in range(len(grid)-1,-1,-1):
        for j in range(len(grid[0])-1,-1,-1):
            if grid[i][j] == '1':
                ans+=1
                dfs(grid,i,j)
                
    return ans