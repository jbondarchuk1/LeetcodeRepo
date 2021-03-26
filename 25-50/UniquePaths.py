# recursive
def uniquePaths(m,n,memo={}):
    if m <= 0 or n <= 0:
        return 0
    if m == 1 and n == 1:
        return 1
    if (m,n) in memo:
        return memo[(m,n)]
    memo[(m,n)] = uniquePaths(m-1,n) + uniquePaths(m,n-1)
    return memo[(m,n)]

# print(uniquePaths(3,7))


# table
def uniquePaths(m,n):
    table = [[0 for i in range(n+1)]for i in range(m+1)]
    
    for i in range(1,len(table)):
        for j in range(1,len(table[0])):
            if i == 1 and j == 1:
                table[i][j] = 1
            else:
                table[i][j] = table[i-1][j] + table[i][j-1]
    return table[-1][-1]

print(uniquePaths(3,2))