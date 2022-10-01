import os

class table:
    def __init__(self, abbreviation, model, window, report):
        self.abbreviation = abbreviation
        self.model = model
        self.window = window
        self.report = report

    def toSQL(self):
        return f"UPDATE dbo.Reference SET refModelClass = \'{self.model}\', refWindowClass = \'{self.window}\', refReportClass = \'{self.report}\', refModifiedBy = \'TCSDEV1\\Jason\' WHERE refKey = \'{self.abbreviation}\';"
    def printSQL(self):
        print(self.toSQL())
    
    def toString(self):
        return f"{self.abbreviation}, {self.model}, {self.window}, {self.report}"

windows = """
case "TSTARTCL": return new TestStartChecklistEditor(formData, isTablet);
case "TISUM": return new TestInstructionSummaryEditor(formData, isTablet);
case "PHLOG": return new PhotoLogSheetEditor(formData, isTablet);
case "SVIBTIS": return new SineVibrationTestInstrucEditor(formData, isTablet);
case "RNDVIBTIS": return new RandVibTestInstrucEditor(formData, isTablet);
case "SHOCKIS": return new ShockTestInstrucEditor(formData, isTablet);
case "PRETIC": return new PretestInspectionChecklistEditor(formData, isTablet);
case "TIINFO": return new TestItemInfoEditor(formData, isTablet);
case "EQPLST": return new EquipmentListEditor(formData, isTablet);
case "SVIBTDS": return new SineVibrationTestDataEditor(formData, isTablet);
case "PSTTIC": return new PostTestPhysicalInspectionEditor(formData, isTablet);
case "TEND": return new TestEndChecklistEditor(formData, isTablet);
case "TINCS": return new TestIncidentSheetEditor(formData, isTablet);
case "TTIMLG": return new TestTimeLogEditor(formData, isTablet);
case "TCVR": return new TestSpecBookCoverSheetEditor(formData, isTablet);
case "PHYSI": return new PhysicalInspectionEditor(formData, isTablet);
case "TREPLG": return new TestCustomerRepsLogEditor(formData, isTablet);
case "FPITM": return new TestFullPGTestItemsEditor(formData, isTablet);
case "JTPSUM": return new JobTestProgramSummaryEditor(formData, isTablet);
case "SDFRM": return new SpecificationDeviationFormEditor(formData, isTablet);
case "CPSGN": return new CustomerPropertySignEditor(formData, isTablet);
case "TIIP": return new TestItemInfoEditor(formData, isTablet);
case "ACCSH": return new AccelerometerTestEditor(formData, isTablet);
case "ATI": return new AccelerationTestInstrucEditor(formData, isTablet);
case "VEND": return new VIBSEnduranceTestDataEditor(formData, isTablet);
case "VEXPL": return new VIBSExploratoryTestDataEditor(formData, isTablet);
case "VVAR": return new VIBSVariableTestDataEditor(formData, isTablet);
case "VTI": return new VIBSTestInstrucEditor(formData, isTablet);
case "RVTD": return new RandomVibTestDataEditor(formData, isTablet);
case "ACTDS": return new AccelerationTestDataSheetEditor(formData, isTablet);
case "SHOCKTDS": return new ShockTestDataSheetEditor(formData, isTablet);
case "SRSTI": return new SRSTestInstrucEditor(formData, isTablet);
case "SRSDS": return new SRSTestDataSheetEditor(formData, isTablet);
case "SDTDS": return new SineDwellTestDataSheetEditor(formData, isTablet);
case "BTDS": return new BounceTestDataSheetEditor(formData, isTablet);
case "BTI": return new BounceTestInstrucEditor(formData, isTablet);
case "DTDS": return new DropTestDataSheetEditor(formData, isTablet);
case "DTI": return new DropTestInstrucEditor(formData, isTablet);
case "DTWADS": return new DropTestWithAccelDataSheetEditor(formData, isTablet);
case "DTWAI": return new DropTestWithAccelInstrucEditor(formData, isTablet);
""".split("\n")

tableVals = []
for line in windows:
    if len(line) > 0:
        l = line.split(" ")
        abb = l[1].replace("\"","").replace(":","")
        win = l[4].split("(")[0]
        rep = win.replace("Editor","Report")
        mod = win.replace("Editor","")
        tableVals.append(table(abb,mod,win,rep))


f = """RNDVIBTIS, RandomVibrationTestInstruc, RandVibTestInstrucEditor, RandVibTestInstrucReport
ACCSH, AccelerometerCheckSheet, AccelerometerTestEditor, AccelerometerTestReport
ATI, AccelerationTestInstructions, AccelerationTestInstrucEditor, AccelerationTestInstrucReport
VEND, VIBSEnduranceTestDataSheet, VIBSEnduranceTestDataEditor, VIBSEnduranceTestDataReport
VEXPL, VIBSExploratoryTestDataSheet, VIBSExploratoryTestDataEditor, VIBSExploratoryTestDataReport
VVAR, VIBSVariableTestDataSheet, VIBSVariableTestDataEditor, VIBSVariableTestDataReport
VTI, VIBSTestInstructions, VIBSTestInstrucEditor, VIBSTestInstrucReport
RVTD, RandomVibTestDataSheet, RandomVibTestDataEditor, RandomVibTestDataReport
SRSTI, SRSShockTestInstrucs, SRSTestInstrucEditor, SRSTestInstrucReport
SRSDS, SRSShockTestDataSheet, SRSTestDataSheetEditor, SRSTestDataSheetReport
SDTDS, SineDWELLTestDataSheet, SineDwellTestDataSheetEditor, SineDwellTestDataSheetReport
BTI, BounceTestInstructions, BounceTestInstrucEditor, BounceTestInstrucReport
DTDS, DropTestDataSheet, DropTestDataSheetEditor, DropTestDataSheetReport
DTI, DropTestInstructions, DropTestInstrucEditor, DropTestInstrucReport
DTWADS, DropTestWithAccelDataSheet, DropTestWithAccelDataSheetEditor, DropTestWithAccelDataSheetReport
DTWAI, DropTestWithAccelInstructions, DropTestWithAccelInstrucEditor, DropTestWithAccelInstrucReport""".split("\n")

for line in f:
    l = line.split(", ")
    for val in tableVals:
        if val.abbreviation == l[0]:
            val.model = l[1]

file = open(f"sql.txt", "w")

for v in tableVals:
    file.write(v.toSQL() + "\n")
    print(v.toString())

file.close()