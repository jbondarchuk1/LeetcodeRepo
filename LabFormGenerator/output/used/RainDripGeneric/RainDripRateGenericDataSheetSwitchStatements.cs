// Report Broker Switch Statement 

case "RDRGDS":
    var wRDRGDS = new RainDripRateGenericDataSheetEditor(testForm);
    wRDRGDS.load();
    return wRDRGDS.Export();
// Test Form Broker Switch Statement 
case "RDRGDS": return new RainDripRateGenericDataSheetEditor(formData, isTablet);

// mainwindow Switch statement
case "RDRGDS":
    var wRDRGDS = new RainDripRateGenericDataSheetEditor(testForm);
    wRDRGDS.MdiParent = this;
    wRDRGDS.Show();
    break;

/* NOT A C# STATEMENT, Add this test form to the database


INSERT INTO dbo.Reference(
    refTableID, refKey, refName, refValue, refFlags, refSortOrder, 
    refActive, refCreatedBy, refCreatedDate, refModifiedBy, 
    refModifiedDate, refParentID, refModelClass, refReportClass, refWindowClass
    ) 
    VALUES (
        3, 'RDRGDS', 'Rain/Drip Rate Generic Data Sheet', 'F2022.08.06', 0, 0, 
        1, 'TCSDEV1\Jason', GETDATE(), 'TCSDEV1\Jason',
        GETDATE(), 0, 'RainDripRateGenericDataSheet', 'RainDripRateGenericDataSheetReport', 'RainDripRateGenericDataSheetEditor'
    );


*/