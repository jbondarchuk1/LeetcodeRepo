def kthSmallest(self, root: TreeNode, k: int) -> int:
    vals = []
    def inorderTrav(node):
        if node!=None:
            inorderTrav(node.left)
            if len(vals) == k:
                return
            vals.append(node.val)
            inorderTrav(node.right)
    
    inorderTrav(root)
    print(vals)
    return vals[k-1]


# fast and low space
def kthSmallest(self, root: TreeNode, k: int) -> int:
    stack = []
    cur = root
    while stack or cur:
        while cur:
            stack.append(cur)
            cur = cur.left
             
        if stack:
            node = stack.pop()
            if k == 1:
                return node.val 
            k -= 1
            if node.right:
                cur = node.right

    # the algorithm never hits this
    return -1