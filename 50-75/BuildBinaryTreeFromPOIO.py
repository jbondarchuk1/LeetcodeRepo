def buildTree(self, preorder: List[int], inorder: List[int]) -> TreeNode:
    def recurse(stop):
        if inorder and stop!=inorder[0]:
            root = TreeNode(preorder.pop(0))
            root.left = recurse(root.val)
            inorder.pop(0)
            root.right = recurse(stop)
            return root
    return recurse(None)