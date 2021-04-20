def quicksort(head,low=0,high=None):
    # high is the index of the final node in the list
    if high==None:
        high = 0
        node = head
        while node.next:
            high+=1
            node = node.next
    
    if high-low <= 1:
        return head

    if low < high:)
        parted = partition(head,low,high)
        quicksort(head,parted+1,high)
        quicksort(head,low,parted-1)

def partition(node,low,high):
    i=low-1
    lownode = node
    for i in range(low): lownode = lownode.next
    highnode = lownode
    for i in range(high-low): highnode = highnode.next
    pivot = highnode.val

    pointer = lownode.next
    for j in range(low,high):
        if lownode.val <= pivot:
            i+=1
            if i > 0: lownode=lownode.next
            lownode.val,pointer.val = pointer.val,lownode.val
    i+=1
    lownode=lownode.next
    lownode.val,highnode.val = highnode.val,lownode.val
    return i

arr = [2,6,3,1,25,7,8,6,5,3,2,3,456,7,65,43,2,3,45,67,765,432,1,3,456,78,7]
quicksort(arr)
print(arr)