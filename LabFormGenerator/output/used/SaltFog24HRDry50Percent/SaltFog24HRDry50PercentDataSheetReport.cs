
using DevExpress.XtraReports.UI;
using DTB.Lab.Forms.Models;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using static DTB.Lab.Forms.Models.SaltFog24HRDry50PercentDataSheet;

namespace DTB.Lab.Forms.Reports
{
    public partial class SaltFog24HRDry50PercentDataSheetReport : DevExpress.XtraReports.UI.XtraReport, ILabReport
    {
        public SaltFog24HRDry50PercentDataSheetReport(SaltFog24HRDry50PercentDataSheet data)
        {
            InitializeComponent();
            objectDataSource1.DataSource = data;
            // bindingSource1.DataSource = data;
        }

    }
}
