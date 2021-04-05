def binarySearch(arr,low,high, target):
    if high >= low:
        mid = (high+low)//2
    
        if arr[mid] == target:
            return mid
        
        elif arr[mid] > target:
            return binarySearch(arr,low,mid-1,target)
        else:
            return binarySearch(arr,mid+1,high,target)
    return -1

arr = [ 2, 3, 4, 10, 40 ]
targ = 4
print(binarySearch(arr,0,len(arr)-1,targ))


# iterative approach just in case they ask it
def binarySearch(arr, target):
    low=0
    high = len(arr) - 1
    mid = 0

    while low <= high:
        mid = (high + low)//2
        if arr[mid] < target:
            low = mid+1
        elif arr[mid] > target:
            high = mid-1
        else: return mid
    
    return -1