// Report Broker Switch Statement 

case "ETMDS":
    var wETMDS = new ElectricalTestMonitoredDataSheetEditor(testForm);
    wETMDS.load();
    return wETMDS.Export();
// Test Form Broker Switch Statement 
case "ETMDS": return new ElectricalTestMonitoredDataSheetEditor(formData, isTablet);

// mainwindow Switch statement
case "ETMDS":
    var wETMDS = new ElectricalTestMonitoredDataSheetEditor(testForm);
    wETMDS.MdiParent = this;
    wETMDS.Show();
    break;

/* NOT A C# STATEMENT, Add this test form to the database


INSERT INTO dbo.Reference(
    refTableID, refKey, refName, refValue, refFlags, refSortOrder, 
    refActive, refCreatedBy, refCreatedDate, refModifiedBy, 
    refModifiedDate, refParentID, refModelClass, refReportClass, refWindowClass
    ) 
    VALUES (
        3, 'ETMDS', 'Test Monitored', 'F2022.08.06', 0, 0, 
        1, 'TCSDEV1\Jason', GETDATE(), 'TCSDEV1\Jason',
        GETDATE(), 0, 'ElectricalTestMonitoredDataSheet', 'ElectricalTestMonitoredDataSheetReport', 'ElectricalTestMonitoredDataSheetEditor'
    );


*/