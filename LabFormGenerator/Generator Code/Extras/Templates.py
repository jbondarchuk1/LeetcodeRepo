import HelperMethods

classnames = """
    BounceTestDataSheet,
    BounceTestInstruc,
    DropTestDataSheet,
    DropTestInstruc,
    DropTestWithAccelDataSheet,
    DropTestWithAccelInstruc,
""".replace("\n","").replace("\t","").split(",")

sheetnames = """
    Bounce Test Data Sheet,
    Bounce Test Instructions,
    Drop Test Data Sheet,
    Drop Test Instructions,
    Drop Test With Accelerations Data Sheet,
    Drop Test With Accelerations Instructions,
""".replace("\n","").replace("\t","").split(",")


# generates abbreviations
abbreviations = [HelperMethods.getAbbreviation(name) for name in classnames]
HelperMethods.reportBrokerSwitch(classnames, abbreviations)
HelperMethods.testFormBrokerSwitch(classnames, abbreviations)
HelperMethods.dboReferenceINSERT(sheetnames, classnames)
