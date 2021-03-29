# extra space
def flatten(self, root: TreeNode) -> None:
    """
    Do not return anything, modify root in-place instead.
    """
    arr = []
    def recurse(root):
        if root:
            arr.append(root.val)
            recurse(root.left)
            recurse(root.right)
    recurse(root)
    node = root
    if node:
        node.left = None
        for i in range(1,len(arr)):
            node.right=TreeNode(arr[i])
            node = node.right

# in place solution LEARN IT! 
def flatten(self, root: TreeNode) -> None:
    if root:
        right = root.right
        root.right = self.flatten(root.left)
        root.left = None
        
        node = root
        while node.right:
            node = node.right
        node.right  = self.flatten(right)
    return root