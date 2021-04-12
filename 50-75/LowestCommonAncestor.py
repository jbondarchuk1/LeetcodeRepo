# am i not a god amongst men
def lowestCommonAncestor(self, root: 'TreeNode', p: 'TreeNode', q: 'TreeNode') -> 'TreeNode':
    # dfs
    def dfs(node,target):
        if node:
            if node == target:
                return True
            l = dfs(node.left,target)
            r = dfs(node.right,target)
            return l or r
        return False
    
    def checklca(node,target1,target2):
        if node:
            left = checklca(node.left,target1,target2)
            right = checklca(node.right,target1,target2)
            if left!=None:  return left
            if right!=None: return right
            
            if dfs(node,target1) and dfs(node,target2):
                return node
        return None
    return checklca(root,p,q)