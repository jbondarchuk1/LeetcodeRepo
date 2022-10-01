// Report Broker Switch Statement 

case "ECO":
    var wECO = new ElectricalChangeOrderEditor(testForm);
    wECO.load();
    return wECO.Export();
// Test Form Broker Switch Statement 
case "ECO": return new ElectricalChangeOrderEditor(formData, isTablet);

// mainwindow Switch statement
case "ECO":
    var wECO = new ElectricalChangeOrderEditor(testForm);
    wECO.MdiParent = this;
    wECO.Show();
    break;

/* NOT A C# STATEMENT, Add this test form to the database


INSERT INTO dbo.Reference(
    refTableID, refKey, refName, refValue, refFlags, refSortOrder, 
    refActive, refCreatedBy, refCreatedDate, refModifiedBy, 
    refModifiedDate, refParentID, refModelClass, refReportClass, refWindowClass
    ) 
    VALUES (
        3, 'ECO', 'Electrical Change Order', 'F2022.08.06', 0, 0, 
        1, 'TCSDEV1\Jason', GETDATE(), 'TCSDEV1\Jason',
        GETDATE(), 0, 'ElectricalChangeOrder', 'ElectricalChangeOrderReport', 'ElectricalChangeOrderEditor'
    );


*/