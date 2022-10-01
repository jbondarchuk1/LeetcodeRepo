// Report Broker Switch Statement 

case "EIPC":
    var wEIPC = new ElectricalInputPowerCableEditor(testForm);
    wEIPC.load();
    return wEIPC.Export();
// Test Form Broker Switch Statement 
case "EIPC": return new ElectricalInputPowerCableEditor(formData, isTablet);

// mainwindow Switch statement
case "EIPC":
    var wEIPC = new ElectricalInputPowerCableEditor(testForm);
    wEIPC.MdiParent = this;
    wEIPC.Show();
    break;

/* NOT A C# STATEMENT, Add this test form to the database


INSERT INTO dbo.Reference(
    refTableID, refKey, refName, refValue, refFlags, refSortOrder, 
    refActive, refCreatedBy, refCreatedDate, refModifiedBy, 
    refModifiedDate, refParentID, refModelClass, refReportClass, refWindowClass
    ) 
    VALUES (
        3, 'EIPC', 'Electrical Input Power Cable', 'F2022.08.06', 0, 0, 
        1, 'TCSDEV1\Jason', GETDATE(), 'TCSDEV1\Jason',
        GETDATE(), 0, 'ElectricalInputPowerCable', 'ElectricalInputPowerCableReport', 'ElectricalInputPowerCableEditor'
    );


*/