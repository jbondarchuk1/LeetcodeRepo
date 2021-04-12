# naive solution
def sortList(self, head: ListNode) -> ListNode:
    arr = []
    while head:
        arr.append(head.val)
        head = head.next
    arr.sort()
    newhead = ListNode()
    pointer = newhead
    for i in range(len(arr)):
        pointer.val = arr[i]
        if i < len(arr)-1:
            pointer.next = ListNode()
        pointer = pointer.next
        
    return newhead

def sortList(head):
    def quicksort(node,low=0,high=None):
        if high == None:
            pointer = node
            high = low
            while node:
                high+=1
                pointer = pointer.next

        if not node.next:
            return
        if low < high:
            parted = partition(node,low,high)
            quicksort(node,low,parted-1)
            quicksort(node,parted+1,high)

    def partition(node,low,high):
        i = low
        pivot = node
        for j in range(low,high):
            pivot=node.next
        
        pointer = node
        for j in range(low,high)
            if pointer.val <= pivot.val:
                temp = node.val
                node.val = pointer.val
                pointer.val = temp
                node=node.next
                i+=1
            pointer=pointer.next

        node = node.next
        pointer = pointer.next
        temp = node.val
        node.val = pointer.val
        pointer.val = temp

        return i+1

    quicksort(head)
    return head
