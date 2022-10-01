// Report Broker Switch Statement 

case "BROTDS":
    var wBROTDS = new BlowingRainOutsideTestDataSheetEditor(testForm);
    wBROTDS.load();
    return wBROTDS.Export();
// Test Form Broker Switch Statement 
case "BROTDS": return new BlowingRainOutsideTestDataSheetEditor(formData, isTablet);

// mainwindow Switch statement
case "BROTDS":
    var wBROTDS = new BlowingRainOutsideTestDataSheetEditor(testForm);
    wBROTDS.MdiParent = this;
    wBROTDS.Show();
    break;

/* NOT A C# STATEMENT, Add this test form to the database


INSERT INTO dbo.Reference(
    refTableID, refKey, refName, refValue, refFlags, refSortOrder, 
    refActive, refCreatedBy, refCreatedDate, refModifiedBy, 
    refModifiedDate, refParentID, refModelClass, refReportClass, refWindowClass
    ) 
    VALUES (
        3, 'BROTDS', 'Blowing Rain Test Data Sheet (Outside)', 'F2022.08.06', 0, 0, 
        1, 'TCSDEV1\Jason', GETDATE(), 'TCSDEV1\Jason',
        GETDATE(), 0, 'BlowingRainOutsideTestDataSheet', 'BlowingRainOutsideTestDataSheetReport', 'BlowingRainOutsideTestDataSheetEditor'
    );


*/