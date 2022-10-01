import HelperMethods

def createSwitchFile(classname, abbreviation, sheetname = None):
    classnames = [classname]
    abbreviations = [abbreviation]
    out = ""
    out += "// Report Broker Switch Statement \n"
    out += HelperMethods.reportBrokerSwitch(classnames, abbreviations)
    out += "// Test Form Broker Switch Statement \n"
    out += HelperMethods.testFormBrokerSwitch(classnames, abbreviations)
    out += HelperMethods.mainWindowSwitch(classnames, abbreviations)

    if sheetname != None:
        sheetnames = [sheetname]
        out += "/* NOT A C# STATEMENT, Add this test form to the database\n\n"
        out += HelperMethods.dboReferenceINSERT(sheetnames, classnames, abbreviations)
        out += "\n\n*/"
    return out
