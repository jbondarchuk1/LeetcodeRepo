// Report Broker Switch Statement 

case "EEUTI":
    var wEEUTI = new ElectricalEUTInformationEditor(testForm);
    wEEUTI.load();
    return wEEUTI.Export();
// Test Form Broker Switch Statement 
case "EEUTI": return new ElectricalEUTInformationEditor(formData, isTablet);

// mainwindow Switch statement
case "EEUTI":
    var wEEUTI = new ElectricalEUTInformationEditor(testForm);
    wEEUTI.MdiParent = this;
    wEEUTI.Show();
    break;

/* NOT A C# STATEMENT, Add this test form to the database


INSERT INTO dbo.Reference(
    refTableID, refKey, refName, refValue, refFlags, refSortOrder, 
    refActive, refCreatedBy, refCreatedDate, refModifiedBy, 
    refModifiedDate, refParentID, refModelClass, refReportClass, refWindowClass
    ) 
    VALUES (
        3, 'EEUTI', 'Electrical EUT Information', 'F2022.08.06', 0, 0, 
        1, 'TCSDEV1\Jason', GETDATE(), 'TCSDEV1\Jason',
        GETDATE(), 0, 'ElectricalEUTInformation', 'ElectricalEUTInformationReport', 'ElectricalEUTInformationEditor'
    );


*/