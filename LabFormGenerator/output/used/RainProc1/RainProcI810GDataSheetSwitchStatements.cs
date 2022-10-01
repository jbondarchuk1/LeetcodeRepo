// Report Broker Switch Statement 

case "RPIGDS":
    var wRPIGDS = new RainProcI810GDataSheetEditor(testForm);
    wRPIGDS.load();
    return wRPIGDS.Export();
// Test Form Broker Switch Statement 
case "RPIGDS": return new RainProcI810GDataSheetEditor(formData, isTablet);

// mainwindow Switch statement
case "RPIGDS":
    var wRPIGDS = new RainProcI810GDataSheetEditor(testForm);
    wRPIGDS.MdiParent = this;
    wRPIGDS.Show();
    break;

/* NOT A C# STATEMENT, Add this test form to the database


INSERT INTO dbo.Reference(
    refTableID, refKey, refName, refValue, refFlags, refSortOrder, 
    refActive, refCreatedBy, refCreatedDate, refModifiedBy, 
    refModifiedDate, refParentID, refModelClass, refReportClass, refWindowClass
    ) 
    VALUES (
        3, 'RPIGDS', 'Rain Procedure I, 810G Data Sheet', 'F2022.08.06', 0, 0, 
        1, 'TCSDEV1\Jason', GETDATE(), 'TCSDEV1\Jason',
        GETDATE(), 0, 'RainProcI810GDataSheet', 'RainProcI810GDataSheetReport', 'RainProcI810GDataSheetEditor'
    );


*/