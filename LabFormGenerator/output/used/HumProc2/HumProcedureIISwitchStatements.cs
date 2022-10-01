// Report Broker Switch Statement 

case "HPII":
    var wHPII = new HumProcedureIIEditor(testForm);
    wHPII.load();
    return wHPII.Export();
// Test Form Broker Switch Statement 
case "HPII": return new HumProcedureIIEditor(formData, isTablet);

// mainwindow Switch statement
case "HPII":
    var wHPII = new HumProcedureIIEditor(testForm);
    wHPII.MdiParent = this;
    wHPII.Show();
    break;

/* NOT A C# STATEMENT, Add this test form to the database


INSERT INTO dbo.Reference(
    refTableID, refKey, refName, refValue, refFlags, refSortOrder, 
    refActive, refCreatedBy, refCreatedDate, refModifiedBy, 
    refModifiedDate, refParentID, refModelClass, refReportClass, refWindowClass
    ) 
    VALUES (
        3, 'HPII', 'Humidity Procedure II 810G-H Test Data Sheet', 'F2022.08.06', 0, 0, 
        1, 'TCSDEV1\Jason', GETDATE(), 'TCSDEV1\Jason',
        GETDATE(), 0, 'HumProcedureII', 'HumProcedureIIReport', 'HumProcedureIIEditor'
    );


*/