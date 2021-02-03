# Leetcode merge two binary trees
# Definition for a binary tree node.
class TreeNode(object):
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right

def mergeTrees(node1, node2):
    if not node1:
        return node2
    if not node2:
        return node1
    t = TreeNode(node1.val+node2.val)
    t.left = mergeTrees(node1.left,node2.left)
    t.right = mergeTrees(node1.right,node2.right)
    return t
    