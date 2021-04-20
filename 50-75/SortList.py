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


##### review this! 
# workin on it
def sortList(self, head: ListNode) -> ListNode:
    if not head or not head.next:
        return head
    fast, slow = head.next, head
    while fast and fast.next:
        fast = fast.next.next
        slow = slow.next
    start = slow.next
    slow.next = None
    l, r = self.sortList(head), self.sortList(start)
    return self.merge(l, r)
    
    
def merge(self, l, r):
    if not l or not r:
        return l or r
    dummy = p = ListNode(0)
    while l and r:
        if l.val < r.val:
            p.next = l
            l = l.next
        else:
            p.next = r
            r = r.next
        p = p.next
    p.next = l or r
    return dummy.next