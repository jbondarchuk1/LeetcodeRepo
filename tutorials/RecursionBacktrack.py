# base case and recursive case required

# heres an example of a recursive function

def factorial(n):
    # base case usually an if statement
    if n == 1 or n == 0:
        return 1 # the return is required when we call the function
    else:
        # call the same function for the recursive case
        return n*factorial(n-1)   
        
"""
combinations:
    O(2^n) time
    O(n^2) space
    collection of items where the order does not matter
"""
def combo(arr):
    if len(arr) == 0:
        # we need a 2d array to pass back in
        return [[]]
    
    first = arr[0]
    rest = arr[1:]
    combsWithoutFirst = combo(rest)
    combsWithFirst = []

    for combination in combsWithoutFirst:
        newComb = []
        for val in combination:
            newComb.append(val)

        newComb.append(first)
        combsWithFirst.append(newComb)

    return combsWithoutFirst + combsWithFirst

print(combo(['a','b','c']))

"""
permutations:
n! number of permutations

collections of items where order matters

time: O(n!)
space: O(n^2)
"""

def permu(arr):
    if len(arr) == 0:
        return [[]]

    perms = []
    # for each value in the array
    for i in range(len(arr)):
        first = arr[i]
        rest = arr[:i] + arr[i+1:]
        for element in permu(rest):
            # add a permutation with each value in front omg this kinda deep
            perms.append([first]+element)

    return perms

print(permu(['a','b','c']))
