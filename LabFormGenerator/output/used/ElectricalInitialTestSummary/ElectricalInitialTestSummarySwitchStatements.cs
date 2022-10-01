// Report Broker Switch Statement 

case "EITS":
    var wEITS = new ElectricalInitialTestSummaryEditor(testForm);
    wEITS.load();
    return wEITS.Export();
// Test Form Broker Switch Statement 
case "EITS": return new ElectricalInitialTestSummaryEditor(formData, isTablet);

// mainwindow Switch statement
case "EITS":
    var wEITS = new ElectricalInitialTestSummaryEditor(testForm);
    wEITS.MdiParent = this;
    wEITS.Show();
    break;

/* NOT A C# STATEMENT, Add this test form to the database


INSERT INTO dbo.Reference(
    refTableID, refKey, refName, refValue, refFlags, refSortOrder, 
    refActive, refCreatedBy, refCreatedDate, refModifiedBy, 
    refModifiedDate, refParentID, refModelClass, refReportClass, refWindowClass
    ) 
    VALUES (
        3, 'EITS', 'Electrical Initial Test Summary', 'F2022.08.06', 0, 0, 
        1, 'TCSDEV1\Jason', GETDATE(), 'TCSDEV1\Jason',
        GETDATE(), 0, 'ElectricalInitialTestSummary', 'ElectricalInitialTestSummaryReport', 'ElectricalInitialTestSummaryEditor'
    );


*/