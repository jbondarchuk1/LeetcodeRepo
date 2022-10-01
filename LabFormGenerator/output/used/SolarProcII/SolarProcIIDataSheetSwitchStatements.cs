// Report Broker Switch Statement 

case "SPIIDS":
    var wSPIIDS = new SolarProcIIDataSheetEditor(testForm);
    wSPIIDS.load();
    return wSPIIDS.Export();
// Test Form Broker Switch Statement 
case "SPIIDS": return new SolarProcIIDataSheetEditor(formData, isTablet);

// mainwindow Switch statement
case "SPIIDS":
    var wSPIIDS = new SolarProcIIDataSheetEditor(testForm);
    wSPIIDS.MdiParent = this;
    wSPIIDS.Show();
    break;

/* NOT A C# STATEMENT, Add this test form to the database


INSERT INTO dbo.Reference(
    refTableID, refKey, refName, refValue, refFlags, refSortOrder, 
    refActive, refCreatedBy, refCreatedDate, refModifiedBy, 
    refModifiedDate, refParentID, refModelClass, refReportClass, refWindowClass
    ) 
    VALUES (
        3, 'SPIIDS', 'Solar 810G-H Procedure II Data Sheet', 'F2022.08.06', 0, 0, 
        1, 'TCSDEV1\Jason', GETDATE(), 'TCSDEV1\Jason',
        GETDATE(), 0, 'SolarProcIIDataSheet', 'SolarProcIIDataSheetReport', 'SolarProcIIDataSheetEditor'
    );


*/