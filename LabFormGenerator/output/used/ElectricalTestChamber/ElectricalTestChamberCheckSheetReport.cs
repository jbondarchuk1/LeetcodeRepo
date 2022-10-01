
using DevExpress.XtraReports.UI;
using DTB.Lab.Forms.Models;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using static DTB.Lab.Forms.Models.ElectricalTestChamberCheckSheet;

namespace DTB.Lab.Forms.Reports
{
    public partial class ElectricalTestChamberCheckSheetReport : DevExpress.XtraReports.UI.XtraReport, ILabReport
    {
        public ElectricalTestChamberCheckSheetReport(ElectricalTestChamberCheckSheet data)
        {
            InitializeComponent();
            objectDataSource1.DataSource = data;
            // bindingSource1.DataSource = data;
        }

    }
}
