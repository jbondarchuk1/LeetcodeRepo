// Report Broker Switch Statement 

case "ESEDS":
    var wESEDS = new ElectricalSupportEquipmentDataSheetEditor(testForm);
    wESEDS.load();
    return wESEDS.Export();
// Test Form Broker Switch Statement 
case "ESEDS": return new ElectricalSupportEquipmentDataSheetEditor(formData, isTablet);

// mainwindow Switch statement
case "ESEDS":
    var wESEDS = new ElectricalSupportEquipmentDataSheetEditor(testForm);
    wESEDS.MdiParent = this;
    wESEDS.Show();
    break;

/* NOT A C# STATEMENT, Add this test form to the database


INSERT INTO dbo.Reference(
    refTableID, refKey, refName, refValue, refFlags, refSortOrder, 
    refActive, refCreatedBy, refCreatedDate, refModifiedBy, 
    refModifiedDate, refParentID, refModelClass, refReportClass, refWindowClass
    ) 
    VALUES (
        3, 'ESEDS', 'Electrical Support Equipment Data Sheet', 'F2022.08.06', 0, 0, 
        1, 'TCSDEV1\Jason', GETDATE(), 'TCSDEV1\Jason',
        GETDATE(), 0, 'ElectricalSupportEquipmentDataSheet', 'ElectricalSupportEquipmentDataSheetReport', 'ElectricalSupportEquipmentDataSheetEditor'
    );


*/