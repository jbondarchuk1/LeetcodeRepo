# level order traversal my solution, high memory usage, faster than 60%
def levelOrder(self, root: TreeNode) -> List[List[int]]:
    lvls = []
    def recurse(node,lvl):
        if node != None:
            if len(lvls) < lvl + 1:
                lvls.append([])
            lvls[lvl].append(node.val)
            recurse(node.left,lvl+1)
            recurse(node.right,lvl+1)
        return
    recurse(root,0)
    return lvls

# faster than 80 memory better than 50
def levelOrder(self, root: TreeNode) -> List[List[int]]:
    if not root: return []
    ans = []
    level = [root]
    while level:
        ans.append([node.val for node in level])
        level = [child for node in level for child in (node.left, node.right) if child]
    return ans

# faster than 95 memory better than 50
def levelOrder(self, root: TreeNode) -> List[List[int]]:
    if not root:
        return []
    res,q,templist = [], [], []
    q.append(root)
    q.append(TreeNode(-1001))
    res.append([root.val])
    while len(q)>1:
        temp = q.pop(0)
        if temp.val==-1001:
            res.append(templist)
            q.append(TreeNode(-1001))
            templist = []
        else:
            if temp.left: 
                q.append(temp.left)
                templist.append(temp.left.val)
            if temp.right:
                q.append(temp.right)
                templist.append(temp.right.val)
    return res