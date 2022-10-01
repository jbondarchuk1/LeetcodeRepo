// Report Broker Switch Statement 

case "SFCWTDS":
    var wSFCWTDS = new SaltFogCollectionWithTempDataSheetEditor(testForm);
    wSFCWTDS.load();
    return wSFCWTDS.Export();
// Test Form Broker Switch Statement 
case "SFCWTDS": return new SaltFogCollectionWithTempDataSheetEditor(formData, isTablet);

// mainwindow Switch statement
case "SFCWTDS":
    var wSFCWTDS = new SaltFogCollectionWithTempDataSheetEditor(testForm);
    wSFCWTDS.MdiParent = this;
    wSFCWTDS.Show();
    break;

/* NOT A C# STATEMENT, Add this test form to the database


INSERT INTO dbo.Reference(
    refTableID, refKey, refName, refValue, refFlags, refSortOrder, 
    refActive, refCreatedBy, refCreatedDate, refModifiedBy, 
    refModifiedDate, refParentID, refModelClass, refReportClass, refWindowClass
    ) 
    VALUES (
        3, 'SFCWTDS', 'Salt Fog Collection With Temps Data Sheet', 'F2022.08.06', 0, 0, 
        1, 'TCSDEV1\Jason', GETDATE(), 'TCSDEV1\Jason',
        GETDATE(), 0, 'SaltFogCollectionWithTempDataSheet', 'SaltFogCollectionWithTempDataSheetReport', 'SaltFogCollectionWithTempDataSheetEditor'
    );


*/