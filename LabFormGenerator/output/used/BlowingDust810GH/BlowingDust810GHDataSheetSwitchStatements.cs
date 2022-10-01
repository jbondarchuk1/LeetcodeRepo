// Report Broker Switch Statement 

case "BDGHDS":
    var wBDGHDS = new BlowingDust810GHDataSheetEditor(testForm);
    wBDGHDS.load();
    return wBDGHDS.Export();
// Test Form Broker Switch Statement 
case "BDGHDS": return new BlowingDust810GHDataSheetEditor(formData, isTablet);

// mainwindow Switch statement
case "BDGHDS":
    var wBDGHDS = new BlowingDust810GHDataSheetEditor(testForm);
    wBDGHDS.MdiParent = this;
    wBDGHDS.Show();
    break;

/* NOT A C# STATEMENT, Add this test form to the database


INSERT INTO dbo.Reference(
    refTableID, refKey, refName, refValue, refFlags, refSortOrder, 
    refActive, refCreatedBy, refCreatedDate, refModifiedBy, 
    refModifiedDate, refParentID, refModelClass, refReportClass, refWindowClass
    ) 
    VALUES (
        3, 'BDGHDS', 'Blowing Dust 810G-H Data Sheet', 'F2022.08.06', 0, 0, 
        1, 'TCSDEV1\Jason', GETDATE(), 'TCSDEV1\Jason',
        GETDATE(), 0, 'BlowingDust810GHDataSheet', 'BlowingDust810GHDataSheetReport', 'BlowingDust810GHDataSheetEditor'
    );


*/