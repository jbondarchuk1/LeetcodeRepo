def mergeTwoLists(self, l1: ListNode, l2: ListNode) -> ListNode:
    build = ListNode()
    if l2 == None:
        return l1
    elif l1 == None:
        return l2

    if l1.val < l2.val:
        build = l1
        build.next = self.mergeTwoLists(l1.next,l2)
    else:
        build = l2
        build.next = self.mergeTwoLists(l1,l2.next)
    return build

# in place recursive no extra space
def mergeTwoLists(self, l1: ListNode, l2: ListNode) -> ListNode:
    if l2 == None:
        return l1
    elif l1 == None:
        return l2

    if l1.val < l2.val:
        self.mergeTwoLists(l1.next,l2)
    else:
        temp = ListNode(l1.val,l1.next)
        l1.val = l2.val
        l1.next = temp
        self.mergeTwoLists(l1.next,l2.next)
    return l1

# iterative
def mergeTwoLists(self, l1: ListNode, l2: ListNode) -> ListNode:
    dummy = ListNode()
    cur = dummy
    
    while l1 and l2:
        if l1.val < l2.val:
            cur.next = l1
            l1 = l1.next
        else:
            cur.next = l2
            l2 = l2.next
        cur = cur.next
    
    if l1:
        cur.next = l1
    elif l2:
        cur.next = l2
    
    return dummy.next