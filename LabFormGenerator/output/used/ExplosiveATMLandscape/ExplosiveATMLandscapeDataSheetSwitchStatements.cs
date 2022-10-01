// Report Broker Switch Statement 

case "EATMLDS":
    var wEATMLDS = new ExplosiveATMLandscapeDataSheetEditor(testForm);
    wEATMLDS.load();
    return wEATMLDS.Export();
// Test Form Broker Switch Statement 
case "EATMLDS": return new ExplosiveATMLandscapeDataSheetEditor(formData, isTablet);

// mainwindow Switch statement
case "EATMLDS":
    var wEATMLDS = new ExplosiveATMLandscapeDataSheetEditor(testForm);
    wEATMLDS.MdiParent = this;
    wEATMLDS.Show();
    break;

/* NOT A C# STATEMENT, Add this test form to the database


INSERT INTO dbo.Reference(
    refTableID, refKey, refName, refValue, refFlags, refSortOrder, 
    refActive, refCreatedBy, refCreatedDate, refModifiedBy, 
    refModifiedDate, refParentID, refModelClass, refReportClass, refWindowClass
    ) 
    VALUES (
        3, 'EATMLDS', 'Explosive ATM Landscape Data Sheet', 'F2022.08.06', 0, 0, 
        1, 'TCSDEV1\Jason', GETDATE(), 'TCSDEV1\Jason',
        GETDATE(), 0, 'ExplosiveATMLandscapeDataSheet', 'ExplosiveATMLandscapeDataSheetReport', 'ExplosiveATMLandscapeDataSheetEditor'
    );


*/