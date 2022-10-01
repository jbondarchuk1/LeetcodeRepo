// Report Broker Switch Statement 

case "BRITDS":
    var wBRITDS = new BlowingRainInsideTestDataSheetEditor(testForm);
    wBRITDS.load();
    return wBRITDS.Export();
// Test Form Broker Switch Statement 
case "BRITDS": return new BlowingRainInsideTestDataSheetEditor(formData, isTablet);

// mainwindow Switch statement
case "BRITDS":
    var wBRITDS = new BlowingRainInsideTestDataSheetEditor(testForm);
    wBRITDS.MdiParent = this;
    wBRITDS.Show();
    break;

/* NOT A C# STATEMENT, Add this test form to the database


INSERT INTO dbo.Reference(
    refTableID, refKey, refName, refValue, refFlags, refSortOrder, 
    refActive, refCreatedBy, refCreatedDate, refModifiedBy, 
    refModifiedDate, refParentID, refModelClass, refReportClass, refWindowClass
    ) 
    VALUES (
        3, 'BRITDS', 'Blowing Rain Test Data Sheet (Inside)', 'F2022.08.06', 0, 0, 
        1, 'TCSDEV1\Jason', GETDATE(), 'TCSDEV1\Jason',
        GETDATE(), 0, 'BlowingRainInsideTestDataSheet', 'BlowingRainInsideTestDataSheetReport', 'BlowingRainInsideTestDataSheetEditor'
    );


*/