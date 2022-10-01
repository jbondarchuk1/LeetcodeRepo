// Report Broker Switch Statement 

case "FTDS":
    var wFTDS = new FluidsTestDataSheetEditor(testForm);
    wFTDS.load();
    return wFTDS.Export();
// Test Form Broker Switch Statement 
case "FTDS": return new FluidsTestDataSheetEditor(formData, isTablet);

// mainwindow Switch statement
case "FTDS":
    var wFTDS = new FluidsTestDataSheetEditor(testForm);
    wFTDS.MdiParent = this;
    wFTDS.Show();
    break;

/* NOT A C# STATEMENT, Add this test form to the database


INSERT INTO dbo.Reference(
    refTableID, refKey, refName, refValue, refFlags, refSortOrder, 
    refActive, refCreatedBy, refCreatedDate, refModifiedBy, 
    refModifiedDate, refParentID, refModelClass, refReportClass, refWindowClass
    ) 
    VALUES (
        3, 'FTDS', 'Fluids Test Data Sheet', 'F2022.08.06', 0, 0, 
        1, 'TCSDEV1\Jason', GETDATE(), 'TCSDEV1\Jason',
        GETDATE(), 0, 'FluidsTestDataSheet', 'FluidsTestDataSheetReport', 'FluidsTestDataSheetEditor'
    );


*/