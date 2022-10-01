// Report Broker Switch Statement 

case "BDDOEFG":
    var wBDDOEFG = new BlowingDustDO160EFGEditor(testForm);
    wBDDOEFG.load();
    return wBDDOEFG.Export();
// Test Form Broker Switch Statement 
case "BDDOEFG": return new BlowingDustDO160EFGEditor(formData, isTablet);

// mainwindow Switch statement
case "BDDOEFG":
    var wBDDOEFG = new BlowingDustDO160EFGEditor(testForm);
    wBDDOEFG.MdiParent = this;
    wBDDOEFG.Show();
    break;

/* NOT A C# STATEMENT, Add this test form to the database


INSERT INTO dbo.Reference(
    refTableID, refKey, refName, refValue, refFlags, refSortOrder, 
    refActive, refCreatedBy, refCreatedDate, refModifiedBy, 
    refModifiedDate, refParentID, refModelClass, refReportClass, refWindowClass
    ) 
    VALUES (
        3, 'BDDOEFG', 'Blowing Dust DO-160 E, F, G Data Sheet', 'F2022.08.06', 0, 0, 
        1, 'TCSDEV1\Jason', GETDATE(), 'TCSDEV1\Jason',
        GETDATE(), 0, 'BlowingDustDO160EFG', 'BlowingDustDO160EFGReport', 'BlowingDustDO160EFGEditor'
    );


*/