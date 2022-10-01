// Report Broker Switch Statement 

case "ECS":
    var wECS = new ElectricalCoverSheetEditor(testForm);
    wECS.load();
    return wECS.Export();
// Test Form Broker Switch Statement 
case "ECS": return new ElectricalCoverSheetEditor(formData, isTablet);

// mainwindow Switch statement
case "ECS":
    var wECS = new ElectricalCoverSheetEditor(testForm);
    wECS.MdiParent = this;
    wECS.Show();
    break;

/* NOT A C# STATEMENT, Add this test form to the database


INSERT INTO dbo.Reference(
    refTableID, refKey, refName, refValue, refFlags, refSortOrder, 
    refActive, refCreatedBy, refCreatedDate, refModifiedBy, 
    refModifiedDate, refParentID, refModelClass, refReportClass, refWindowClass
    ) 
    VALUES (
        3, 'ECS', 'Electrical Cover Sheet', 'F2022.08.06', 0, 0, 
        1, 'TCSDEV1\Jason', GETDATE(), 'TCSDEV1\Jason',
        GETDATE(), 0, 'ElectricalCoverSheet', 'ElectricalCoverSheetReport', 'ElectricalCoverSheetEditor'
    );


*/