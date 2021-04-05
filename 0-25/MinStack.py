class Node:
    def __init__ (self,val=0,previous=None):
        self.val = val
        self.previous = None

class MinStack:
    def __init__(self,Top=None,mini=None):
        self.Top = Top
        self.mini = mini

    def push(self, x: int) -> None:
        if x == None:
            return
        
        node = Node(x)
        
        if self.Top == None:
            self.Top = node
            self.mini = node
            self.Top = node
            
        else:
            node.previous = self.Top
            self.Top = node
            if node.val < self.mini.val:
                self.mini = node
        return
        
    def pop(self) -> None:
        if not self.Top:
            return 
        
        self.Top = self.Top.previous
        if not self.Top:
            self.mini = None
            return

        self.mini = self.Top
        pointer = self.Top
        while pointer:
            if pointer.val < self.mini.val:
                self.mini = pointer
            pointer = pointer.previous   
        

    def top(self) -> int:
        if self.Top:
            return self.Top.val

    def getMin(self) -> int:
        if self.mini:
            return self.mini.val

stack = MinStack()

stack.push(-2)
stack.push(0)
stack.push(-3)

print(stack.getMin())
stack.pop()
print(stack.top())
print(stack.getMin())
