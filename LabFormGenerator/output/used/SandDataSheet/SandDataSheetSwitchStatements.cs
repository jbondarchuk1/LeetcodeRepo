// Report Broker Switch Statement 

case "SDS":
    var wSDS = new SandDataSheetEditor(testForm);
    wSDS.load();
    return wSDS.Export();
// Test Form Broker Switch Statement 
case "SDS": return new SandDataSheetEditor(formData, isTablet);

// mainwindow Switch statement
case "SDS":
    var wSDS = new SandDataSheetEditor(testForm);
    wSDS.MdiParent = this;
    wSDS.Show();
    break;

/* NOT A C# STATEMENT, Add this test form to the database


INSERT INTO dbo.Reference(
    refTableID, refKey, refName, refValue, refFlags, refSortOrder, 
    refActive, refCreatedBy, refCreatedDate, refModifiedBy, 
    refModifiedDate, refParentID, refModelClass, refReportClass, refWindowClass
    ) 
    VALUES (
        3, 'SDS', 'Sand Data Sheet', 'F2022.08.06', 0, 0, 
        1, 'TCSDEV1\Jason', GETDATE(), 'TCSDEV1\Jason',
        GETDATE(), 0, 'SandDataSheet', 'SandDataSheetReport', 'SandDataSheetEditor'
    );


*/