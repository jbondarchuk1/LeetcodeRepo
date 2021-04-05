# iterative (harder)
def inorderTraversal(self, root: TreeNode) -> List[int]:
    ans = []
    stack = []
    while root:
        if root.left:
            stack.append(root)
            root=root.left
        else:
            ans.append(root.val)
            if root.right:
                root=root.right

            elif stack:
                root=stack.pop()
                root.left=None # mutating the initial data structure might not be good but it worked
                # this just prevented it from going left indefinitely
            else: break
    return ans

# recursive (easy), this had an issue with leetcode which made me need an inner function for the recurse, but this should work
def inorderTraversal(self, root: TreeNode):
    ans=[]
    if root:
        self.inorderTraversal(root.left)
        ans.append(root.val)
        self.inorderTraversal(root.right)
    return ans
