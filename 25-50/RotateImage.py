# this is not difficult at all technically but the trick was hard
def rotate(self, matrix) -> None:
    for i in range(len(matrix)):
        for j in range(i):
            matrix[i][j],matrix[j][i] = matrix[j][i],matrix[i][j]

    print(matrix)
    for i in range(len(matrix)):
        matrix[i] = matrix[i][::-1]

    return
     
