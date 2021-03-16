def generateParenthesis(n):
    parens = []
        
    def recurse(opennum, closenum,s=''):
        if len(s)==n*2 and s[-1] != '(':
            return s

        if opennum > closenum and opennum <=n:
            plusopen = s + '('
            recurseopen = recurse(opennum+1,closenum,plusopen)
            if recurseopen != None:
                parens.append(recurseopen)
            
            plusclose = s + ')'
            recurseclose = recurse(opennum,closenum+1,plusclose)
            if recurseclose !=None:
                parens.append(recurseclose)

        if opennum == closenum and opennum <=n:
            plusopen = s + '('
            recurseopen = recurse(opennum+1,closenum,plusopen)
            if recurseopen != None:
                parens.append(recurseopen)
            

    recurse(0,0)
    print(parens)
    return parens

generateParenthesis(4)