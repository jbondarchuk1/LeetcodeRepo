def getAbbreviation(classname):
    abbreviation = ""
    for l in classname:
        if l.isupper():
            abbreviation += l
    return abbreviation

# DTB.Lab.Forms.ReportBroker Switch statement
def reportBrokerSwitch(classnames, abbreviations):
    for i in range(len(classnames)):
        switches = ""
        abbreviation = abbreviations[i]
        classname = classnames[i]
        if len(classname.replace(" ", "")) > 0:
            switch = f"""
case \"{abbreviation}\":
    var w{abbreviation} = new {classname}Editor(testForm);
    w{abbreviation}.load();
    return w{abbreviation}.Export();"""
            switches += switch + "\n"
        return switches

# DTB.Lab.Forms.TestFormBroker Switch statement
def testFormBrokerSwitch(classnames, abbreviations):
    switches = ""
    for i in range(len(classnames)):
        abbreviation = abbreviations[i]
        classname = classnames[i]
        if len(classname.replace(" ", "")) > 0:
            switch = f"""case "{abbreviation}": return new {classname}Editor(formData, isTablet);"""
            switches += switch + "\n"
    return switches

def mainWindowSwitch(classnames, abbreviations):
    switches = ""
    for i in range(len(classnames)):
        abbreviation = abbreviations[i]
        classname = classnames[i]
        if len(classname.replace(" ", "")) > 0:
            switch = f"""
// mainwindow Switch statement
case "{abbreviation}":
    var w{abbreviation} = new {classname}Editor(testForm);
    w{abbreviation}.MdiParent = this;
    w{abbreviation}.Show();
    break;
"""
            switches += switch + "\n"
    return switches


# dbo.Reference INSERT statement
def dboReferenceINSERT(sheetnames, classnames, abbreviations):
    inserts = ""
    for i in range(len(sheetnames)):
        abbreviation = abbreviations[i]
        sheetname = sheetnames[i]
        if len(sheetname.replace(" ", "")) > 0:
            switch = f"""
INSERT INTO dbo.Reference(
    refTableID, refKey, refName, refValue, refFlags, refSortOrder, 
    refActive, refCreatedBy, refCreatedDate, refModifiedBy, 
    refModifiedDate, refParentID, refModelClass, refReportClass, refWindowClass
    ) 
    VALUES (
        3, '{abbreviation}', '{sheetname}', 'F2022.08.06', 0, 0, 
        1, 'TCSDEV1\Jason', GETDATE(), 'TCSDEV1\Jason',
        GETDATE(), 0, '{classnames[i]}', '{classnames[i]}Report', '{classnames[i]}Editor'
    );
"""
        inserts += switch
    return inserts

