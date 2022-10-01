
using DevExpress.XtraReports.UI;
using DTB.Lab.Forms.Models;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using static DTB.Lab.Forms.Models.SaltFog2HRPreconditioningDataSheet;

namespace DTB.Lab.Forms.Reports
{
    public partial class SaltFog2HRPreconditioningDataSheetReport : DevExpress.XtraReports.UI.XtraReport, ILabReport
    {
        public SaltFog2HRPreconditioningDataSheetReport(SaltFog2HRPreconditioningDataSheet data)
        {
            InitializeComponent();
            objectDataSource1.DataSource = data;
            // bindingSource1.DataSource = data;
        }

    }
}
