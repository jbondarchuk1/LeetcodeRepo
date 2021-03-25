"""
memoization helps this become O(2n)
the non memoized solution is like O(n^2) 
"""

def fib(n, memo = {}):
    if n == 0 or n == 1:
        return 1
    elif n in memo:
        return memo[n]
    else:
        memo[n] = fib(n-1, memo) + fib(n-2, memo)
        return memo[n]
# print(fib(50))

"""
how many paths can you travel from top left to 
bottom right in an M x N grid
"""
"""
O(2^(n*m)) nonmemo
O(m*n) memo
- only one square
gridTraveler(1,1) will only have 1 way to travel, return 1

- no grid because one of the values is 0, we return 0
gridTraveler(1,0) or gridTraveler(0,1) will return 0
"""
def gridTraveler(m,n):
    if m == 0 or n == 0:
        return 0
    elif m == 1 and n == 1:
        return 1
    return gridTraveler(m-1,n) + gridTraveler(m,n-1)

# memo
def gridTraveler(m,n, memo = {}):
    if m == 0 or n == 0:
        return 0
    elif m == 1 and n == 1:
        return 1

    key = str(m) + ',' + str(n)

    if key in memo:
        return memo[key]
    else:
        # remember to pass the memo to the recursive calls
        memo[key] = gridTraveler(m-1,n,memo) + gridTraveler(m,n-1,memo)
        return memo[key]

# print(gridTraveler(2,3))

"""
first make it work
- visualize as a decision tree
- set base cases
- translate to recursion
- test brute force recursion
make it efficient
- add a memo object (usually a hashmap)
- if the inputs are in the memo, return the value from the memo
- if its not, store the values in the memo and return it
"""

"""
return true if you can generate the target using elements of the arr
we can reuse values

base case: 
    subtraction == 0 ? return true: return false

nonMemoized:
    O(n^m) time
    O(m) space
memoized:
    O(m*n) time
    O(m) space

"""
def canSum(target, arr):
    if target == 0: return True
    if target < 0: return False

    for num in arr:
        newTarget = target - num
        if canSum(newTarget,arr) == True:
            return True
# your cpu will work super fucking hard on this one
# print(canSum(300, [7,14]))
# print(canSum(7,[4,3]))

# memo
def canSum(target, arr, memo={}):
    if target == 0: return True
    if target < 0: return False
    if target in memo:
        return memo[target]

    for num in arr:
        newTarget = target - num
        memo[newTarget] = canSum(newTarget,arr,memo)
        if memo[newTarget] == True:
            return True
    return False
# print(canSum(300, [7,14]))


"""
Tabulation
we will make an array

Time and space is O(n)

initialize a table and iterate through the table
"""

def fib(n):
    table = [0 for i in range(n+1)]
    # table[0] is base case 0, table[1] is base case 1, iterate to find the answer
    table[1] = 1
    for i in range(n):
        if i+1 <= n: table[i+1] += table[i]
        if i+2 <= n: table[i+2] += table[i]
    return table[n]
# print(fib(6))


"""
return number of ways we can go through the grid

Time: O(m*n)
Space: O(m*n)

seed 1,1 with the value 1
then traverse right to left, top to bottom adding the value to the right and bottom values
  0  1  2  3  4
0 0  0  0  0  0  
1 0  1  0  0  0
2 0  0  0  0  0
3 0  0  0  0  0
4 0  0  0  0  0
"""
def gridTraveler(m,n):
    # our table will literally be the grid that we are traversing but with an extra row for the 0x0
    table = [[0 for i in range(n+1)] for i in range(m+1)]
    table[1][1] = 1
    for i in range(m+1):
        for j in range(n+1):
            if i+1 <= m: table[i+1][j] += table[i][j]
            if j+1 <= n: table[i][j+1] += table[i][j]
    return table[m][n]
# print(gridTraveler(3,2))

"""
Tabulation recipe:
    1. visualize the problem as a table
    2. size the table based on inputs
    3. initialize table with default base case values
    4. initialize the seed value which is an answer to a trivially small input to the problem
    5. iterate through the table in a way that fills further positions based on the current position
"""


"""
given a list of nums return true if you can add up to the target number using the list, else return false

DP iterative solution:
    Time: O(target*n) or O(m*n)
    Space: O(target) or O(m)
"""
def canSum(target, nums):
    table = [False for i in range(target+1)]
    # base case of 0 is always true because we can always add to 0 by choosing no numbers
    table[0] = True
    for i in range(len(table)):
        if table[i] == True:
            for j in range(len(nums)):
                if i + nums[j] <= target:
                    table[i+nums[j]] = True
    return table[-1]
            
# print(canSum(300, [7,14]))
# print(canSum(7,[4,3]))

"""
in this case both versions of dp are just as efficient
"""


