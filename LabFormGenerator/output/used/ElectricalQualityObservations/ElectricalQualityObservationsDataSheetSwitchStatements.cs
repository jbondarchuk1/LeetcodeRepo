// Report Broker Switch Statement 

case "EQODS":
    var wEQODS = new ElectricalQualityObservationsDataSheetEditor(testForm);
    wEQODS.load();
    return wEQODS.Export();
// Test Form Broker Switch Statement 
case "EQODS": return new ElectricalQualityObservationsDataSheetEditor(formData, isTablet);

// mainwindow Switch statement
case "EQODS":
    var wEQODS = new ElectricalQualityObservationsDataSheetEditor(testForm);
    wEQODS.MdiParent = this;
    wEQODS.Show();
    break;

/* NOT A C# STATEMENT, Add this test form to the database


INSERT INTO dbo.Reference(
    refTableID, refKey, refName, refValue, refFlags, refSortOrder, 
    refActive, refCreatedBy, refCreatedDate, refModifiedBy, 
    refModifiedDate, refParentID, refModelClass, refReportClass, refWindowClass
    ) 
    VALUES (
        3, 'EQODS', 'Electrical Quality Observations Data Sheet', 'F2022.08.06', 0, 0, 
        1, 'TCSDEV1\Jason', GETDATE(), 'TCSDEV1\Jason',
        GETDATE(), 0, 'ElectricalQualityObservationsDataSheet', 'ElectricalQualityObservationsDataSheetReport', 'ElectricalQualityObservationsDataSheetEditor'
    );


*/