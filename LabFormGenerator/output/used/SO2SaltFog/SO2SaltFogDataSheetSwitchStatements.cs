// Report Broker Switch Statement 

case "SOSFDS":
    var wSOSFDS = new SO2SaltFogDataSheetEditor(testForm);
    wSOSFDS.load();
    return wSOSFDS.Export();
// Test Form Broker Switch Statement 
case "SOSFDS": return new SO2SaltFogDataSheetEditor(formData, isTablet);

// mainwindow Switch statement
case "SOSFDS":
    var wSOSFDS = new SO2SaltFogDataSheetEditor(testForm);
    wSOSFDS.MdiParent = this;
    wSOSFDS.Show();
    break;

/* NOT A C# STATEMENT, Add this test form to the database


INSERT INTO dbo.Reference(
    refTableID, refKey, refName, refValue, refFlags, refSortOrder, 
    refActive, refCreatedBy, refCreatedDate, refModifiedBy, 
    refModifiedDate, refParentID, refModelClass, refReportClass, refWindowClass
    ) 
    VALUES (
        3, 'SOSFDS', 'SO2 Salt Fog Data Sheet', 'F2022.08.06', 0, 0, 
        1, 'TCSDEV1\Jason', GETDATE(), 'TCSDEV1\Jason',
        GETDATE(), 0, 'SO2SaltFogDataSheet', 'SO2SaltFogDataSheetReport', 'SO2SaltFogDataSheetEditor'
    );


*/