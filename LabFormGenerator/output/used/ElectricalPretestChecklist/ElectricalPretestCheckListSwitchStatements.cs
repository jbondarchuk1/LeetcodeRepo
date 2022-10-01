// Report Broker Switch Statement 

case "EPCL":
    var wEPCL = new ElectricalPretestCheckListEditor(testForm);
    wEPCL.load();
    return wEPCL.Export();
// Test Form Broker Switch Statement 
case "EPCL": return new ElectricalPretestCheckListEditor(formData, isTablet);

// mainwindow Switch statement
case "EPCL":
    var wEPCL = new ElectricalPretestCheckListEditor(testForm);
    wEPCL.MdiParent = this;
    wEPCL.Show();
    break;

/* NOT A C# STATEMENT, Add this test form to the database


INSERT INTO dbo.Reference(
    refTableID, refKey, refName, refValue, refFlags, refSortOrder, 
    refActive, refCreatedBy, refCreatedDate, refModifiedBy, 
    refModifiedDate, refParentID, refModelClass, refReportClass, refWindowClass
    ) 
    VALUES (
        3, 'EPCL', 'Electrical Pretest Check List', 'F2022.08.06', 0, 0, 
        1, 'TCSDEV1\Jason', GETDATE(), 'TCSDEV1\Jason',
        GETDATE(), 0, 'ElectricalPretestCheckList', 'ElectricalPretestCheckListReport', 'ElectricalPretestCheckListEditor'
    );


*/