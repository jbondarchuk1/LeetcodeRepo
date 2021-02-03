def maxDepth(self, root, depth=0):
    if not root:
        return depth
    depth = max(self.maxDepth(root.left),self.maxDepth(root.right)) + 1
    return depth

# bruh i got this in like one second goml
