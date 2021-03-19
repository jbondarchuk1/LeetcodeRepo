# compare the addition to the left and right nodes to just the depth of the tree
# even after getting this solution it makes no sense wtf
def diameterOfBinaryTree(self, root: TreeNode, count=0) -> int:
    self.ans = 1
    def depth(node):
        if not node:
            return 0
        L = depth(node.left)
        R = depth(node.right)
        self.ans = max(self.ans, L+R+1)
        return max(L, R) + 1

    depth(root)
    return self.ans - 1