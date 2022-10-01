// Report Broker Switch Statement 

case "EPTCL":
    var wEPTCL = new ElectricalPostTestCheckListEditor(testForm);
    wEPTCL.load();
    return wEPTCL.Export();
// Test Form Broker Switch Statement 
case "EPTCL": return new ElectricalPostTestCheckListEditor(formData, isTablet);

// mainwindow Switch statement
case "EPTCL":
    var wEPTCL = new ElectricalPostTestCheckListEditor(testForm);
    wEPTCL.MdiParent = this;
    wEPTCL.Show();
    break;

/* NOT A C# STATEMENT, Add this test form to the database


INSERT INTO dbo.Reference(
    refTableID, refKey, refName, refValue, refFlags, refSortOrder, 
    refActive, refCreatedBy, refCreatedDate, refModifiedBy, 
    refModifiedDate, refParentID, refModelClass, refReportClass, refWindowClass
    ) 
    VALUES (
        3, 'EPTCL', 'Electrical Post Test Check List', 'F2022.08.06', 0, 0, 
        1, 'TCSDEV1\Jason', GETDATE(), 'TCSDEV1\Jason',
        GETDATE(), 0, 'ElectricalPostTestCheckList', 'ElectricalPostTestCheckListReport', 'ElectricalPostTestCheckListEditor'
    );


*/