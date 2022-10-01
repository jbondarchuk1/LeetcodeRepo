
using DevExpress.XtraReports.UI;
using DTB.Lab.Forms.Models;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using static DTB.Lab.Forms.Models.ElectricalRetestTestSummary;

namespace DTB.Lab.Forms.Reports
{
    public partial class ElectricalRetestTestSummaryReport : DevExpress.XtraReports.UI.XtraReport, ILabReport
    {
        public ElectricalRetestTestSummaryReport(ElectricalRetestTestSummary data)
        {
            InitializeComponent();
            objectDataSource1.DataSource = data;
            // bindingSource1.DataSource = data;
        }

    }
}
