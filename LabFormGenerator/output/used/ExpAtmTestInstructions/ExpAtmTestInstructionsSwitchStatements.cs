// Report Broker Switch Statement 

case "EATI":
    var EATI = new ExpAtmTestInstructionsEditor(testForm);
    EATI.load();
    return EATI.Export();
// Test Form Broker Switch Statement 
case "EATI": return new ExpAtmTestInstructionsEditor(formData, isTablet);

// mainwindow Switch statement
case "EATI":
    var EATI = new ExpAtmTestInstructionsEditor(testForm);
    EATI.MdiParent = this;
    EATI.Show();
    break;

/* NOT A C# STATEMENT, Add this test form to the database


INSERT INTO dbo.Reference(
    refTableID, refKey, refName, refValue, refFlags, refSortOrder, 
    refActive, refCreatedBy, refCreatedDate, refModifiedBy, 
    refModifiedDate, refParentID, refModelClass, refReportClass, refWindowClass
    ) 
    VALUES (
        3, 'EATI', 'Explosive Atmosphere 810DE or DO160 Test Instructions', 'F2022.08.06', 0, 0, 
        1, 'TCSDEV1\Jason', GETDATE(), 'TCSDEV1\Jason',
        GETDATE(), 0, 'ExpAtmTestInstructions', 'ExpAtmTestInstructionsReport', 'ExpAtmTestInstructionsEditor'
    );


*/