"""
just reduces having a second for loop by doing simultaneous subtraction and addition
    - asked in questions about consecutive numbers or running totals
"""

def maxSum(arr, k):
    n = len(arr)
     if n < k:
        return -1

    window_sum = sum(arr[:k])

    max_sum = window_sum

    for i in range(n - k):
        # subtract off least element and add on the next coming element
        window_sum = window_sum - arr[i] + arr[i + k]
        max_sum = max(window_sum, max_sum)
 
    return max_sum
