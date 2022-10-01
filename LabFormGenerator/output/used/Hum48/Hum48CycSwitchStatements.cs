// Report Broker Switch Statement 

case "HC":
    var wHC = new Hum48CycEditor(testForm);
    wHC.load();
    return wHC.Export();
// Test Form Broker Switch Statement 
case "HC": return new Hum48CycEditor(formData, isTablet);

// mainwindow Switch statement
case "HC":
    var wHC = new Hum48CycEditor(testForm);
    wHC.MdiParent = this;
    wHC.Show();
    break;

/* NOT A C# STATEMENT, Add this test form to the database


INSERT INTO dbo.Reference(
    refTableID, refKey, refName, refValue, refFlags, refSortOrder, 
    refActive, refCreatedBy, refCreatedDate, refModifiedBy, 
    refModifiedDate, refParentID, refModelClass, refReportClass, refWindowClass
    ) 
    VALUES (
        3, 'HC', 'Humidity 48Hr Cycle810F Test Data Sheet', 'F2022.08.06', 0, 0, 
        1, 'TCSDEV1\Jason', GETDATE(), 'TCSDEV1\Jason',
        GETDATE(), 0, 'Hum48Cyc', 'Hum48CycReport', 'Hum48CycEditor'
    );


*/