// Report Broker Switch Statement 

case "ERTS":
    var wERTS = new ElectricalRetestTestSummaryEditor(testForm);
    wERTS.load();
    return wERTS.Export();
// Test Form Broker Switch Statement 
case "ERTS": return new ElectricalRetestTestSummaryEditor(formData, isTablet);

// mainwindow Switch statement
case "ERTS":
    var wERTS = new ElectricalRetestTestSummaryEditor(testForm);
    wERTS.MdiParent = this;
    wERTS.Show();
    break;

/* NOT A C# STATEMENT, Add this test form to the database


INSERT INTO dbo.Reference(
    refTableID, refKey, refName, refValue, refFlags, refSortOrder, 
    refActive, refCreatedBy, refCreatedDate, refModifiedBy, 
    refModifiedDate, refParentID, refModelClass, refReportClass, refWindowClass
    ) 
    VALUES (
        3, 'ERTS', 'Electrical Retest Test Summary', 'F2022.08.06', 0, 0, 
        1, 'TCSDEV1\Jason', GETDATE(), 'TCSDEV1\Jason',
        GETDATE(), 0, 'ElectricalRetestTestSummary', 'ElectricalRetestTestSummaryReport', 'ElectricalRetestTestSummaryEditor'
    );


*/