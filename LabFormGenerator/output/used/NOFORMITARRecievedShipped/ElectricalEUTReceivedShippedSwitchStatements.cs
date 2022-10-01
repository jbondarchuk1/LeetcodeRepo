// Report Broker Switch Statement 

case "EEUTRS":
    var wEEUTRS = new ElectricalEUTReceivedShippedEditor(testForm);
    wEEUTRS.load();
    return wEEUTRS.Export();
// Test Form Broker Switch Statement 
case "EEUTRS": return new ElectricalEUTReceivedShippedEditor(formData, isTablet);

// mainwindow Switch statement
case "EEUTRS":
    var wEEUTRS = new ElectricalEUTReceivedShippedEditor(testForm);
    wEEUTRS.MdiParent = this;
    wEEUTRS.Show();
    break;

/* NOT A C# STATEMENT, Add this test form to the database


INSERT INTO dbo.Reference(
    refTableID, refKey, refName, refValue, refFlags, refSortOrder, 
    refActive, refCreatedBy, refCreatedDate, refModifiedBy, 
    refModifiedDate, refParentID, refModelClass, refReportClass, refWindowClass
    ) 
    VALUES (
        3, 'EEUTRS', 'Electrical EUT Received/Shipped', 'F2022.08.06', 0, 0, 
        1, 'TCSDEV1\Jason', GETDATE(), 'TCSDEV1\Jason',
        GETDATE(), 0, 'ElectricalEUTReceivedShipped', 'ElectricalEUTReceivedShippedReport', 'ElectricalEUTReceivedShippedEditor'
    );


*/