// Report Broker Switch Statement 

case "ESCL":
    var wESCL = new ElectricalSetupCheckListEditor(testForm);
    wESCL.load();
    return wESCL.Export();
// Test Form Broker Switch Statement 
case "ESCL": return new ElectricalSetupCheckListEditor(formData, isTablet);

// mainwindow Switch statement
case "ESCL":
    var wESCL = new ElectricalSetupCheckListEditor(testForm);
    wESCL.MdiParent = this;
    wESCL.Show();
    break;

/* NOT A C# STATEMENT, Add this test form to the database


INSERT INTO dbo.Reference(
    refTableID, refKey, refName, refValue, refFlags, refSortOrder, 
    refActive, refCreatedBy, refCreatedDate, refModifiedBy, 
    refModifiedDate, refParentID, refModelClass, refReportClass, refWindowClass
    ) 
    VALUES (
        3, 'ESCL', 'Electrical Setup Check List', 'F2022.08.06', 0, 0, 
        1, 'TCSDEV1\Jason', GETDATE(), 'TCSDEV1\Jason',
        GETDATE(), 0, 'ElectricalSetupCheckList', 'ElectricalSetupCheckListReport', 'ElectricalSetupCheckListEditor'
    );


*/