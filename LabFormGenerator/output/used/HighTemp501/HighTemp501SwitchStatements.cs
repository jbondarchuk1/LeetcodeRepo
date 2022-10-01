// Report Broker Switch Statement 

case "HT":
    var wHT = new HighTemp501Editor(testForm);
    wHT.load();
    return wHT.Export();
// Test Form Broker Switch Statement 
case "HT": return new HighTemp501Editor(formData, isTablet);

// mainwindow Switch statement
case "HT":
    var wHT = new HighTemp501Editor(testForm);
    wHT.MdiParent = this;
    wHT.Show();
    break;

/* NOT A C# STATEMENT, Add this test form to the database


INSERT INTO dbo.Reference(
    refTableID, refKey, refName, refValue, refFlags, refSortOrder, 
    refActive, refCreatedBy, refCreatedDate, refModifiedBy, 
    refModifiedDate, refParentID, refModelClass, refReportClass, refWindowClass
    ) 
    VALUES (
        3, 'HT', 'High Temperature 501 Procedure I 810F-H Test Data Sheet', 'F2022.08.06', 0, 0, 
        1, 'TCSDEV1\Jason', GETDATE(), 'TCSDEV1\Jason',
        GETDATE(), 0, 'HighTemp501', 'HighTemp501Report', 'HighTemp501Editor'
    );


*/