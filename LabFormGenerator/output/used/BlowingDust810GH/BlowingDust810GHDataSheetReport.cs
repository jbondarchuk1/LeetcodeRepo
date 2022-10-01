
using DevExpress.XtraReports.UI;
using DTB.Lab.Forms.Models;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using static DTB.Lab.Forms.Models.BlowingDust810GHDataSheet;

namespace DTB.Lab.Forms.Reports
{
    public partial class BlowingDust810GHDataSheetReport : DevExpress.XtraReports.UI.XtraReport, ILabReport
    {
        public BlowingDust810GHDataSheetReport(BlowingDust810GHDataSheet data)
        {
            InitializeComponent();
            // objectDataSource1.DataSource = data;
            // bindingSource1.DataSource = data;
        }

    }
}
