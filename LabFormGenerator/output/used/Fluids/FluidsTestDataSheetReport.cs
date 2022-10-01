
using DevExpress.XtraReports.UI;
using DTB.Lab.Forms.Models;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using static DTB.Lab.Forms.Models.FluidsTestDataSheet;

namespace DTB.Lab.Forms.Reports
{
    public partial class FluidsTestDataSheetReport : DevExpress.XtraReports.UI.XtraReport, ILabReport
    {
        public FluidsTestDataSheetReport(FluidsTestDataSheet data)
        {
            InitializeComponent();
            // objectDataSource1.DataSource = data;
            // bindingSource1.DataSource = data;
        }

    }
}
