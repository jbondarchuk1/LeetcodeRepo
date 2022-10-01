// Report Broker Switch Statement 

case "EOC":
    var wEOC = new ElectricalOperationalCriteriaEditor(testForm);
    wEOC.load();
    return wEOC.Export();
// Test Form Broker Switch Statement 
case "EOC": return new ElectricalOperationalCriteriaEditor(formData, isTablet);

// mainwindow Switch statement
case "EOC":
    var wEOC = new ElectricalOperationalCriteriaEditor(testForm);
    wEOC.MdiParent = this;
    wEOC.Show();
    break;

/* NOT A C# STATEMENT, Add this test form to the database


INSERT INTO dbo.Reference(
    refTableID, refKey, refName, refValue, refFlags, refSortOrder, 
    refActive, refCreatedBy, refCreatedDate, refModifiedBy, 
    refModifiedDate, refParentID, refModelClass, refReportClass, refWindowClass
    ) 
    VALUES (
        3, 'EOC', 'Electrical Operational Criteria', 'F2022.08.06', 0, 0, 
        1, 'TCSDEV1\Jason', GETDATE(), 'TCSDEV1\Jason',
        GETDATE(), 0, 'ElectricalOperationalCriteria', 'ElectricalOperationalCriteriaReport', 'ElectricalOperationalCriteriaEditor'
    );


*/