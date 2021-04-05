# Merge Sort NLogN time and O(N) memory complexity
# really not too bad to remember on the whole
def mergesort(l):
    if len(l) <= 1:
        return l
    middle = len(l)//2
    left = l[:middle]
    right = l[middle:]

    left = mergesort(left)
    right = mergesort(right)

    return merge(left,right)

def merge(left, right):
    merged = []

    while left and right:
        if left[0] < right[0]:
            merged.append(left.pop(0))
        else:
            merged.append(right.pop(0))
    if left:
        merged+=left
    if right:
        merged+=right
    return merged


# Quicksort NlogN average, N^2 worst
def quicksort(l,low=0,high=None):
    if high == None and low == 0:
        high = len(l) - 1 

    if len(l) == 1:
        return l
    if low < high:
        parted = partition(l,low,high)
        quicksort(l,low,parted-1)
        quicksort(l,parted+1,high)


def partition(l,low,high):
    i = low - 1
    pivot = l[high]

    for j in range(low,high):
        if l[j] <= pivot:
            i+=1
            l[i],l[j] = l[j], l[i]

    l[i+1],l[high] = l[high],l[i+1]
    return i+1

arr = [10, 7, 8, 9, 1, 5]
quicksort(arr)
print(arr)