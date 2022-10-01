// Report Broker Switch Statement 

case "ECI":
    var wECI = new ElectricalCustomerInstructionsEditor(testForm);
    wECI.load();
    return wECI.Export();
// Test Form Broker Switch Statement 
case "ECI": return new ElectricalCustomerInstructionsEditor(formData, isTablet);

// mainwindow Switch statement
case "ECI":
    var wECI = new ElectricalCustomerInstructionsEditor(testForm);
    wECI.MdiParent = this;
    wECI.Show();
    break;

/* NOT A C# STATEMENT, Add this test form to the database


INSERT INTO dbo.Reference(
    refTableID, refKey, refName, refValue, refFlags, refSortOrder, 
    refActive, refCreatedBy, refCreatedDate, refModifiedBy, 
    refModifiedDate, refParentID, refModelClass, refReportClass, refWindowClass
    ) 
    VALUES (
        3, 'ECI', 'Electrical Customer Instructions', 'F2022.08.06', 0, 0, 
        1, 'TCSDEV1\Jason', GETDATE(), 'TCSDEV1\Jason',
        GETDATE(), 0, 'ElectricalCustomerInstructions', 'ElectricalCustomerInstructionsReport', 'ElectricalCustomerInstructionsEditor'
    );


*/