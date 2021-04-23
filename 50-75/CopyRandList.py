def copyRandomList(self, head):
    def copy(head,count=0,dic={}):
        pointer = head
        copyhead = Node(0)
        copypointer = copyhead

        while pointer:
            copypointer.next = Node(pointer.val)
            dic[pointer] = copypointer.next
            count+=1
            pointer=pointer.next
            copypointer=copypointer.next

        pointer=head
        copyhead=copyhead.next
        copypointer=copyhead

        for i in range(count):
            if pointer.random == None:copypointer.random=None
            else:copypointer.random=dic[pointer.random]
            copypointer=copypointer.next
            pointer=pointer.next

        return copyhead
    return copy(head)