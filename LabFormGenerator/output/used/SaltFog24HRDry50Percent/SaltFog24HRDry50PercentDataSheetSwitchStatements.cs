// Report Broker Switch Statement 

case "SFHRDPDS":
    var wSFHRDPDS = new SaltFog24HRDry50PercentDataSheetEditor(testForm);
    wSFHRDPDS.load();
    return wSFHRDPDS.Export();
// Test Form Broker Switch Statement 
case "SFHRDPDS": return new SaltFog24HRDry50PercentDataSheetEditor(formData, isTablet);

// mainwindow Switch statement
case "SFHRDPDS":
    var wSFHRDPDS = new SaltFog24HRDry50PercentDataSheetEditor(testForm);
    wSFHRDPDS.MdiParent = this;
    wSFHRDPDS.Show();
    break;

/* NOT A C# STATEMENT, Add this test form to the database


INSERT INTO dbo.Reference(
    refTableID, refKey, refName, refValue, refFlags, refSortOrder, 
    refActive, refCreatedBy, refCreatedDate, refModifiedBy, 
    refModifiedDate, refParentID, refModelClass, refReportClass, refWindowClass
    ) 
    VALUES (
        3, 'SFHRDPDS', 'Salt Fog 24HR Dry 50% Data Sheet', 'F2022.08.06', 0, 0, 
        1, 'TCSDEV1\Jason', GETDATE(), 'TCSDEV1\Jason',
        GETDATE(), 0, 'SaltFog24HRDry50PercentDataSheet', 'SaltFog24HRDry50PercentDataSheetReport', 'SaltFog24HRDry50PercentDataSheetEditor'
    );


*/