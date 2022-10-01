import os
import BackEnd.EditorStringGenerator 
import BackEnd.ModelStringGenerator
import BackEnd.SwitchStringGenerator
import HelperMethods
import BackEnd.ReportStringGenerator
import FrontEnd.EditorUIGenerator
import FrontEnd.ReportUIGenerator

classname = "ElectricalChangeOrder"
sheetname = "Electrical Change Order"
title = sheetname

# boldedOnlyLabel-boldedOnlyLabel-T-F-F-F|
# onlyLabel-onlyLabel-F-F-F-F|
# *regularCheck-regularCheck-F|  
# *boldCheck-boldCheck-T|  
# BoldData-BoldData-T-T-T-F|
# data-data-F-T-T-F|
# list-T|

# "  Name-Text-isBold-hasLine-hasData-isList  "         <= Naming Layout in fields string
# "  Name-isList  "                                     <= Shorthand naming in fields string
# "  *Name-Text-isBold  "                        <= Checks have an asterisk
# "  cafdc-Controller Armed For Capture-T-F-T-T  "      <= Example 1
# "  cafdc-T  "                                         <= Example 2
fields0 = f"""

    JobNo-Job No:-T-T-T-F|
    Customer-Customer:-T-T-T-F|
    Engineer-Engineer:-T-T-T-F|

    Date-T|
    Test-T|
    SubNo-T|
    Duration-T|
    DescriptionOfCharge-T|
"""

fields = fields0.replace("\n", "").split("|")

if len(fields[-1]) == 0: del(fields[-1])

# create lists for all fields and fields that are not in a list
for i in range(len(fields)): fields[i] = fields[i].strip()
fieldNamesAll = []
for field in fields: fieldNamesAll.append(field.strip().split("-")[0])


fieldNamesNonList = []
for field in fields: 
    parts = field.strip().split("-")
    if parts[-1] == 'F': fieldNamesNonList.append(BackEnd.EditorStringGenerator.EditorField.parseFromString(field))

fieldNamesNonLabel = []
for field in fields: 
    parts = field.strip().split("-")
    if len(parts) == 6:
        if parts[-2] == 'T': fieldNamesNonLabel.append(parts[0])
    else: 
        fieldNamesNonLabel.append(parts[0])
 
# generate all of the neccesary backend strings
abbreviation = HelperMethods.getAbbreviation(classname)
mod = BackEnd.ModelStringGenerator.createModelFile(classname, fieldNamesNonLabel)
win = BackEnd.EditorStringGenerator.createEditorFile(classname, fieldNamesNonList)
rep = BackEnd.ReportStringGenerator.createReportFile(classname)

# generate all of the necessary frontend strings
reportFields = []
editorFields = []
for i in range(len(fields)):
    reportField = FrontEnd.ReportUIGenerator.ReportField.parseFromString(fields[i])
    editorField = FrontEnd.EditorUIGenerator.Field.parseFromString(fields[i])

    if reportField != None: reportFields.append(reportField)
    if editorField != None: editorFields.append(editorField)

ReportUI = FrontEnd.ReportUIGenerator.ReportUI(classname, title, reportFields)
EditorUI = FrontEnd.EditorUIGenerator.EditorUI(classname, title, editorFields)
repUI = ReportUI.generateReportUI()
winUI = EditorUI.generateEditorUI()

# create the file for switch statements and sql statements
if len(sheetname) == 0: sheetname = None
sw = BackEnd.SwitchStringGenerator.createSwitchFile(classname, abbreviation, sheetname)

def writeTxt():
    txt = f"""
    classname = "{classname}"
    sheetname = "{sheetname}"
    title = "{title}"

    # boldedOnlyLabel-boldedOnlyLabel-T-F-F-F|
    # onlyLabel-onlyLabel-F-F-F-F|
    # *regularCheck-regularCheck-F|  
    # *boldCheck-boldCheck-T|  
    # BoldData-BoldData-T-T-T-F|
    # data-data-F-T-T-F|
    # list-T|

    # "  Name-Text-isBold-hasLine-hasData-isList  "         <= Naming Layout in fields string
    # "  Name-isList  "                                     <= Shorthand naming in fields string
    # "  *Name-Text-isBold  "                               <= Checks have an asterisk
    # "  cafdc-Controller Armed For Capture-T-F-T-T  "      <= Example 1
    # "  cafdc-T  "                                         <= Example 2
    
    fields0 = \"\"\"
        {fields0}
    \"\"\"
    """

    path = f"LabFormGenerator\\output\\{classname}fields.txt"
    if os.path.exists(path): os.remove(path)
    file = open(path, "w")
    print(path)
    file.write(txt)
    file.close()

# Writes model, window and switch to .cs files
# add more to this file to generate more
def writeToPath(classname, model, window, report, reportUI, windowUI, switch):
    if os.path.exists(f"LabFormGenerator\output\{classname}.cs"):       os.remove(f"LabFormGenerator\output\{classname}.cs")
    if os.path.exists(f"LabFormGenerator\output\{classname}Editor.cs"): os.remove(f"LabFormGenerator\output\{classname}Editor.cs")
    if os.path.exists(f"LabFormGenerator\output\{classname}Report.cs"): os.remove(f"LabFormGenerator\output\{classname}Report.cs")
    if os.path.exists(f"LabFormGenerator\output\{classname}SwitchStatements.cs"): os.remove(f"LabFormGenerator\output\{classname}SwitchStatements.cs")
    if os.path.exists(f"LabFormGenerator\output\{classname}Editor.Designer.cs"): os.remove(f"LabFormGenerator\output\{classname}Editor.Designer.cs")
    if os.path.exists(f"LabFormGenerator\output\{classname}Report.Designer.cs"): os.remove(f"LabFormGenerator\output\{classname}Report.Designer.cs")

    modelFile = open(f"LabFormGenerator\output\{classname}.cs", "w")
    editorFile = open(f"LabFormGenerator\output\{classname}Editor.cs", "w")
    editorUIFile = open(f"LabFormGenerator\output\{classname}Editor.Designer.cs", "w")
    reportUIFile = open(f"LabFormGenerator\output\{classname}Report.Designer.cs", "w")
    reportFile = open(f"LabFormGenerator\output\{classname}Report.cs", "w")
    switchFile = open(f"LabFormGenerator\output\{classname}SwitchStatements.cs", "w")

    modelFile.write(model)
    editorFile.write(window)
    editorUIFile.write(windowUI)
    reportFile.write(report)
    reportUIFile.write(reportUI)
    switchFile.write(switch)

    modelFile.close()
    editorFile.close()
    reportFile.close()
    switchFile.close()
    reportUIFile.close()
    editorUIFile.close()
    
    writeTxt()


# Writes model, window and switch to .cs files directly to the program directory
# add more to this file to generate more
def writeToPathDirect(classname, model, window, report, reportUI, windowUI, switch):
    directory = f"D:\\Jason\\Projects\\LabTestManager\\DTB.Lab.Forms\\"

    modpath = f"{directory}\Models\InProgress\{classname}.cs"
    editorpath = f"{directory}\Windows\InProgress\{classname}Editor.cs"
    reportpath = f"{directory}\Reports\InProgress\{classname}Report.cs"
    EditorUIpath = f"{directory}\Windows\InProgress\{classname}Editor.Designer.cs"
    ReportUIpath = f"{directory}\Reports\InProgress\{classname}Report.Designer.cs"
    switchpath = f"LabFormGenerator\output\{classname}SwitchStatements.cs"
    
    code =  [model,   window,     report,     windowUI,     reportUI,     switch    ]
    paths = [modpath, editorpath, reportpath, EditorUIpath, ReportUIpath, switchpath]
    for i in range(len(paths)):
        path = paths[i]
        if os.path.exists(path): os.remove(path)
        file = open(path, "w")
        print(path)
        file.write(code[i])
        file.close()
    
    writeTxt()

writeToPath(classname, mod, win, rep, repUI, winUI, sw)


