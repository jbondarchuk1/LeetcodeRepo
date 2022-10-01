// Report Broker Switch Statement 

case "SPIDS":
    var wSPIDS = new SolarProcIDataSheetEditor(testForm);
    wSPIDS.load();
    return wSPIDS.Export();
// Test Form Broker Switch Statement 
case "SPIDS": return new SolarProcIDataSheetEditor(formData, isTablet);

// mainwindow Switch statement
case "SPIDS":
    var wSPIDS = new SolarProcIDataSheetEditor(testForm);
    wSPIDS.MdiParent = this;
    wSPIDS.Show();
    break;

/* NOT A C# STATEMENT, Add this test form to the database


INSERT INTO dbo.Reference(
    refTableID, refKey, refName, refValue, refFlags, refSortOrder, 
    refActive, refCreatedBy, refCreatedDate, refModifiedBy, 
    refModifiedDate, refParentID, refModelClass, refReportClass, refWindowClass
    ) 
    VALUES (
        3, 'SPIDS', 'Solar 810G-H Procedure I Data Sheet', 'F2022.08.06', 0, 0, 
        1, 'TCSDEV1\Jason', GETDATE(), 'TCSDEV1\Jason',
        GETDATE(), 0, 'SolarProcIDataSheet', 'SolarProcIDataSheetReport', 'SolarProcIDataSheetEditor'
    );


*/