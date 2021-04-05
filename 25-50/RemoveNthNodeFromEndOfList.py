def removeNthFromEnd(head, n):
    length = 1
    if not head or not head.next:
        return None
    pointer1 = head
    pointer2 = head

    while pointer1.next:
        pointer1 = pointer1.next
        pointer2 = pointer2.next
        if length == n:
            pointer2 = head
        length+=1


    if n == length:
        return head.next
    elif pointer2.next:
        pointer2.next = pointer2.next.next
    else:
        pointer2.next = None
    return head





class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next
def buildNode(arr, head=None, pointer=None):
    for i in range(len(arr)):
        if head == None:
            head = ListNode(val=arr[i])
            pointer=head
        else:
            pointer.next = ListNode(arr[i])
            pointer = pointer.next
    return head
    
def checkNode(head):
    arr = []
    while head:
        arr.append(head.val)
        head = head.next
    print(arr)

list1 = buildNode([2])
checkNode(removeNthFromEnd(list1,2))