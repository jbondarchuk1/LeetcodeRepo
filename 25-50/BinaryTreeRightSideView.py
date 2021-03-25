# my solution (70 20)
def rightSideView(self, root: TreeNode) -> List[int]:
    maxlvl = 0
    lvl = 1
    stack = []
    rightView = []
    while root:
        if lvl > maxlvl:
            rightView.append(root.val)
            maxlvl = lvl

        if root.right:
            lvl+=1
            if root.left:
                stack.append([root.left,lvl])
            root = root.right

        elif root.left:
            lvl+=1
            root = root.left

        elif len(stack) > 0:
            top = stack.pop()
            root=top[0]
            lvl = top[1]
        
        else:
            break

    return rightView

# level order traversal 90% speed, 54% memory
def rightSideView(self, root: TreeNode) -> List[int]:
    result = []
    nodes = []
    if root: nodes = [root]
        
    while(len(nodes) > 0):            
        result.append(nodes[-1].val)
        
        newNodes = []
        for node in nodes:
            if node.left: newNodes.append(node.left)
            if node.right: newNodes.append(node.right)
                
        nodes = newNodes
    
    return result

# dfs 37% 20%
def rightSideView(self, root: TreeNode) -> List[int]:
    # Step 1: identify the end of the level
    # Step 2: add last node to the result

    # dfs
    # 1) prioritize right side
    # 2) keep track level of nodes
    def dfs(node, curLevel, res):
        if not node: #base case to return
            return

        if curLevel >= len(res): #push the value in
            res.append(node.val)

        #preorder traversal
        if node.right:
            dfs(node.right, curLevel+1, res)
        if node.left:
            dfs(node.left, curLevel+1, res)
    res = []
    dfs(root, 0, res)
    return res