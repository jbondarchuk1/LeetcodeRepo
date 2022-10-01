// Report Broker Switch Statement 

case "PPCL":
    var wPPCL = new PostProgramCheckListEditor(testForm);
    wPPCL.load();
    return wPPCL.Export();
// Test Form Broker Switch Statement 
case "PPCL": return new PostProgramCheckListEditor(formData, isTablet);

// mainwindow Switch statement
case "PPCL":
    var wPPCL = new PostProgramCheckListEditor(testForm);
    wPPCL.MdiParent = this;
    wPPCL.Show();
    break;

/* NOT A C# STATEMENT, Add this test form to the database


INSERT INTO dbo.Reference(
    refTableID, refKey, refName, refValue, refFlags, refSortOrder, 
    refActive, refCreatedBy, refCreatedDate, refModifiedBy, 
    refModifiedDate, refParentID, refModelClass, refReportClass, refWindowClass
    ) 
    VALUES (
        3, 'PPCL', 'Post Program Check List', 'F2022.08.06', 0, 0, 
        1, 'TCSDEV1\Jason', GETDATE(), 'TCSDEV1\Jason',
        GETDATE(), 0, 'PostProgramCheckList', 'PostProgramCheckListReport', 'PostProgramCheckListEditor'
    );


*/