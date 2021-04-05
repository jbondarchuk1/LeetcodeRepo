def maxProfit(arr):
    small = None
    maxprofit = None
    for i in range(len(arr)):
        if small == None:
            small = arr[i]
            maxprofit = 0

        if arr[i] < small:
            small = arr[i]
        elif arr[i]-small > maxprofit:
            maxprofit = arr[i] - small
    return maxprofit