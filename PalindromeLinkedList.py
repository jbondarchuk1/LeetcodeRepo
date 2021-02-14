def isPalindrome(self, head: ListNode) -> bool:
    if not head:
        return True
    if not head.next:
        return True
    
    slow = head
    fast = head
    while fast:
        if fast.next:
            fast = fast.next.next
            slow = slow.next
        else:
            fast = fast.next
            slow = slow.next
            
    previous = None
    while slow:
        nxt = slow.next
        slow.next = previous
        previous = slow
        slow = nxt
    
    while previous:
        if previous.val != head.val:
            return False
        previous = previous.next
        head = head.next
    return True