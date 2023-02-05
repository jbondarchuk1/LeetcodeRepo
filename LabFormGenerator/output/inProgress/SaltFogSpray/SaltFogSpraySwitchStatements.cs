// Report Broker Switch Statement 

case "SFS":
    var wSFS = new SaltFogSprayEditor(testForm);
    wSFS.load();
    return wSFS.Export();
// Test Form Broker Switch Statement 
case "SFS": return new SaltFogSprayEditor(formData, isTablet);

// mainwindow Switch statement
case "SFS":
    var wSFS = new SaltFogSprayEditor(testForm);
    wSFS.MdiParent = this;
    wSFS.Show();
    break;

/* NOT A C# STATEMENT, Add this test form to the database


INSERT INTO dbo.Reference(
    refTableID, refKey, refName, refValue, refFlags, refSortOrder, 
    refActive, refCreatedBy, refCreatedDate, refModifiedBy, 
    refModifiedDate, refParentID, refModelClass, refReportClass, refWindowClass
    ) 
    VALUES (
        3, 'SFS', 'Salt Fog Spray', 'F2022.08.06', 0, 0, 
        1, 'TCSDEV1\Jason', GETDATE(), 'TCSDEV1\Jason',
        GETDATE(), 0, 'SaltFogSpray', 'SaltFogSprayReport', 'SaltFogSprayEditor'
    );


*/