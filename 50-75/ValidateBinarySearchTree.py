# a fucking legendary play by me im a legend
import math
def isValidBST(self,root, lr=None, parVal=None, prevlr=None, maxi=math.inf, mini=-math.inf):
    if root:
        if lr:
            if (lr == 'left' and (prevlr == 'left' or prevlr == None)) or (lr=='left' and prevlr == 'right'):
                maxi = parVal
            if (lr == 'right' and (prevlr == 'right' or prevlr == None)) or (lr=='right' and prevlr == 'left'):
                mini = parVal
        
        if not mini < root.val < maxi:
            return False
            
        leftchild = self.isValidBST(root.left,'left',root.val,lr,maxi,mini)
        rightchild = self.isValidBST(root.right,'right',root.val,lr,maxi,mini)
        children =  leftchild and rightchild
        
        if children != None:
            return children
        elif leftchild != None  and rightchild==None:
            return leftchild
        elif rightchild != None and leftchild==None:
            return rightchild

    return True
