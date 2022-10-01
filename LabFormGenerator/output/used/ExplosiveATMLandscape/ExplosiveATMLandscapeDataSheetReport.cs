
using DevExpress.XtraReports.UI;
using DTB.Lab.Forms.Models;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using static DTB.Lab.Forms.Models.ExplosiveATMLandscapeDataSheet;

namespace DTB.Lab.Forms.Reports
{
    public partial class ExplosiveATMLandscapeDataSheetReport : DevExpress.XtraReports.UI.XtraReport, ILabReport
    {
        public ExplosiveATMLandscapeDataSheetReport(ExplosiveATMLandscapeDataSheet data)
        {
            InitializeComponent();
            // objectDataSource1.DataSource = data;
            // bindingSource1.DataSource = data;
        }

    }
}
