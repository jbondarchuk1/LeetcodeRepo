// Report Broker Switch Statement 

case "ETCCS":
    var wETCCS = new ElectricalTestChamberCheckSheetEditor(testForm);
    wETCCS.load();
    return wETCCS.Export();
// Test Form Broker Switch Statement 
case "ETCCS": return new ElectricalTestChamberCheckSheetEditor(formData, isTablet);

// mainwindow Switch statement
case "ETCCS":
    var wETCCS = new ElectricalTestChamberCheckSheetEditor(testForm);
    wETCCS.MdiParent = this;
    wETCCS.Show();
    break;

/* NOT A C# STATEMENT, Add this test form to the database


INSERT INTO dbo.Reference(
    refTableID, refKey, refName, refValue, refFlags, refSortOrder, 
    refActive, refCreatedBy, refCreatedDate, refModifiedBy, 
    refModifiedDate, refParentID, refModelClass, refReportClass, refWindowClass
    ) 
    VALUES (
        3, 'ETCCS', 'Electrical Test Chamber Check Sheet', 'F2022.08.06', 0, 0, 
        1, 'TCSDEV1\Jason', GETDATE(), 'TCSDEV1\Jason',
        GETDATE(), 0, 'ElectricalTestChamberCheckSheet', 'ElectricalTestChamberCheckSheetReport', 'ElectricalTestChamberCheckSheetEditor'
    );


*/