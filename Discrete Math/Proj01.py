statements = """
Paul says, \"Ray is guilty\"
Quinn says, \"If Steve is guilty, then so is Ray\"
Ray says, \"Both Steve and Todd are guilty\"
Steve says, \"Both Quinn and Ray are guilty\"
Todd says, \"At least one of Paul or Ray is guilty\"
"""

stringGuilty = "guilty."
stringInnocent = "innocent."

class Statement:
    nameToIsGuilty = {}
    def __init__(self, stringStatement = ""):
        self.stringStatement = stringStatement
        self.parseStatement()
    
    def parseStatement(self):
        words = self.stringStatement.strip().split(" ")
        if words.find("is"):
            isIdx = words.index("is")
            

