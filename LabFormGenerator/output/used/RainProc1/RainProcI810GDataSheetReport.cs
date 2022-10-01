
using DevExpress.XtraReports.UI;
using DTB.Lab.Forms.Models;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using static DTB.Lab.Forms.Models.RainProcI810GDataSheet;

namespace DTB.Lab.Forms.Reports
{
    public partial class RainProcI810GDataSheetReport : DevExpress.XtraReports.UI.XtraReport, ILabReport
    {
        public RainProcI810GDataSheetReport(RainProcI810GDataSheet data)
        {
            InitializeComponent();
            objectDataSource1.DataSource = data;
            // bindingSource1.DataSource = data;
        }

    }
}
