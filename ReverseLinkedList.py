# recursive
def reverseList(self,head,previous=None):
    """
    :type head: ListNode
    :rtype: ListNode
    """
    if not head:
        return previous
    else:
        nxt = head.next
        head.next = previous
        previous = head
        head = nxt
        head = self.reverseList(head,previous)
    return head

# iterative
def reverseList(self, head, previous=None):
    while head:
        nxt = head.next
        head.next = previous
        previous = head
        head = nxt  
    return previous