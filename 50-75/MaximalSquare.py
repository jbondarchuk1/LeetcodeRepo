def maximalSquare(self, matrix):
    table = matrix
    table.insert(0,[0 for i in range(len(matrix[0]))])
    for i in range(len(table)):
        table[i].insert(0,0)

    maxi = 0

    for m in range(1,len(table)):
        for n in range(1,len(table[0])):
            table[m][n] = int(table[m][n])
            if table[m][n] != 0:
                square = [table[m-1][n],table[m][n-1],table[m-1][n-1]]
                mini = min(square)
                if mini != 0: table[m][n] = mini+1
                if table[m][n] > maxi: maxi = table[m][n]
    return maxi**2



# same thing but no insertion (O(N) time and space to insert)
def maximalSquare(self, matrix: List[List[str]]) -> int:
        if not matrix: return 0
        h, w = len(matrix), len(matrix[0])
        # in-place update
        dp_table = matrix
        max_edge_length = 0

        for x in range(w):
            matrix[0][x] = int( matrix[0][x] )
        for y in range(h):
            matrix[y][0] = int( matrix[y][0] )

        for y in range(h):
            for x in range(w):
                if y > 0 and x > 0:
                    if matrix[y][x] == '1':
                        matrix[y][x] = 1 + min( matrix[y][x-1], matrix[y-1][x-1], matrix[y-1][x])
                    else:
                        matrix[y][x] = 0
                max_edge_length = max(max_edge_length, matrix[y][x])
        return max_edge_length*max_edge_length