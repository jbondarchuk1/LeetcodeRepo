// Report Broker Switch Statement 

case "EEUTM":
    var wEEUTM = new ElectricalEUTModificationsEditor(testForm);
    wEEUTM.load();
    return wEEUTM.Export();
// Test Form Broker Switch Statement 
case "EEUTM": return new ElectricalEUTModificationsEditor(formData, isTablet);

// mainwindow Switch statement
case "EEUTM":
    var wEEUTM = new ElectricalEUTModificationsEditor(testForm);
    wEEUTM.MdiParent = this;
    wEEUTM.Show();
    break;

/* NOT A C# STATEMENT, Add this test form to the database


INSERT INTO dbo.Reference(
    refTableID, refKey, refName, refValue, refFlags, refSortOrder, 
    refActive, refCreatedBy, refCreatedDate, refModifiedBy, 
    refModifiedDate, refParentID, refModelClass, refReportClass, refWindowClass
    ) 
    VALUES (
        3, 'EEUTM', 'Electrical EUT Modifications', 'F2022.08.06', 0, 0, 
        1, 'TCSDEV1\Jason', GETDATE(), 'TCSDEV1\Jason',
        GETDATE(), 0, 'ElectricalEUTModifications', 'ElectricalEUTModificationsReport', 'ElectricalEUTModificationsEditor'
    );


*/