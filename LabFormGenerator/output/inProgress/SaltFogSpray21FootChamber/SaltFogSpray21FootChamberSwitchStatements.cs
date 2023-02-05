// Report Broker Switch Statement 

case "SFSFC":
    var wSFSFC = new SaltFogSpray21FootChamberEditor(testForm);
    wSFSFC.load();
    return wSFSFC.Export();
// Test Form Broker Switch Statement 
case "SFSFC": return new SaltFogSpray21FootChamberEditor(formData, isTablet);

// mainwindow Switch statement
case "SFSFC":
    var wSFSFC = new SaltFogSpray21FootChamberEditor(testForm);
    wSFSFC.MdiParent = this;
    wSFSFC.Show();
    break;

/* NOT A C# STATEMENT, Add this test form to the database


INSERT INTO dbo.Reference(
    refTableID, refKey, refName, refValue, refFlags, refSortOrder, 
    refActive, refCreatedBy, refCreatedDate, refModifiedBy, 
    refModifiedDate, refParentID, refModelClass, refReportClass, refWindowClass
    ) 
    VALUES (
        3, 'SFSFC', 'Salt Fog Spray 21 Foot Chamber', 'F2022.08.06', 0, 0, 
        1, 'TCSDEV1\Jason', GETDATE(), 'TCSDEV1\Jason',
        GETDATE(), 0, 'SaltFogSpray21FootChamber', 'SaltFogSpray21FootChamberReport', 'SaltFogSpray21FootChamberEditor'
    );


*/