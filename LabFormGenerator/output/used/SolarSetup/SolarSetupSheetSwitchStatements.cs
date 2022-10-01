// Report Broker Switch Statement 

case "SSS":
    var wSSS = new SolarSetupSheetEditor(testForm);
    wSSS.load();
    return wSSS.Export();
// Test Form Broker Switch Statement 
case "SSS": return new SolarSetupSheetEditor(formData, isTablet);

// mainwindow Switch statement
case "SSS":
    var wSSS = new SolarSetupSheetEditor(testForm);
    wSSS.MdiParent = this;
    wSSS.Show();
    break;

/* NOT A C# STATEMENT, Add this test form to the database


INSERT INTO dbo.Reference(
    refTableID, refKey, refName, refValue, refFlags, refSortOrder, 
    refActive, refCreatedBy, refCreatedDate, refModifiedBy, 
    refModifiedDate, refParentID, refModelClass, refReportClass, refWindowClass
    ) 
    VALUES (
        3, 'SSS', 'Solar Setup Sheet', 'F2022.08.06', 0, 0, 
        1, 'TCSDEV1\Jason', GETDATE(), 'TCSDEV1\Jason',
        GETDATE(), 0, 'SolarSetupSheet', 'SolarSetupSheetReport', 'SolarSetupSheetEditor'
    );


*/