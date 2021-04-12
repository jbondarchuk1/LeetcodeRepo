# even though this passes its bottom 5%
def rob(self, root, parent=False, memo={}):
    # memo is hash the root and will contain the maximum and whether or not it contained the parent [max, parent]
    currSum = 0
    if root:
        if root in memo:
            if parent == memo[root][1]:
                return memo[root][0]
        
        leftSumWO = self.rob(root.left,False, memo) 
        rightSumWO = self.rob(root.right,False, memo)
        lrSumWO = leftSumWO + rightSumWO + currSum
        
        if parent == False:
            withSum = currSum + root.val
            leftSumWith = self.rob(root.left,True, memo) 
            rightSumWith = self.rob(root.right,True, memo)
        
            lrSumWith = leftSumWith + rightSumWith + withSum
        else:
            lrSumWith = lrSumWO
        
        memo[root] = [max(lrSumWith,lrSumWO), parent]
        return memo[root][0]
    return 0

# a much much faster solution bottom up dfs
def rob(self, myroot):
    def traverse(root):
        if root:
            l = traverse(root.left)
            r = traverse(root.right)
            
            curr = max(l[0]+r[0],  l[1]+r[1]+root.val)
            child = l[0]+r[0]
            root.val = curr
            return [curr,child]
            
        # child max, grandchild max
        return [0,0]
    traverse(myroot)
    return myroot.val