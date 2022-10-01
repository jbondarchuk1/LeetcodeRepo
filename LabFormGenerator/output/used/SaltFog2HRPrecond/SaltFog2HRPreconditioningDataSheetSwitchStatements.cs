// Report Broker Switch Statement 

case "SFHRPDS":
    var wSFHRPDS = new SaltFog2HRPreconditioningDataSheetEditor(testForm);
    wSFHRPDS.load();
    return wSFHRPDS.Export();
// Test Form Broker Switch Statement 
case "SFHRPDS": return new SaltFog2HRPreconditioningDataSheetEditor(formData, isTablet);

// mainwindow Switch statement
case "SFHRPDS":
    var wSFHRPDS = new SaltFog2HRPreconditioningDataSheetEditor(testForm);
    wSFHRPDS.MdiParent = this;
    wSFHRPDS.Show();
    break;

/* NOT A C# STATEMENT, Add this test form to the database


INSERT INTO dbo.Reference(
    refTableID, refKey, refName, refValue, refFlags, refSortOrder, 
    refActive, refCreatedBy, refCreatedDate, refModifiedBy, 
    refModifiedDate, refParentID, refModelClass, refReportClass, refWindowClass
    ) 
    VALUES (
        3, 'SFHRPDS', 'Salt Fog 2HR Preconditioning Period Data Sheet', 'F2022.08.06', 0, 0, 
        1, 'TCSDEV1\Jason', GETDATE(), 'TCSDEV1\Jason',
        GETDATE(), 0, 'SaltFog2HRPreconditioningDataSheet', 'SaltFog2HRPreconditioningDataSheetReport', 'SaltFog2HRPreconditioningDataSheetEditor'
    );


*/