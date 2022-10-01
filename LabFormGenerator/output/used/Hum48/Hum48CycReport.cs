
using DevExpress.XtraReports.UI;
using DTB.Lab.Forms.Models;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using static DTB.Lab.Forms.Models.Hum48Cyc;

namespace DTB.Lab.Forms.Reports
{
    public partial class Hum48CycReport : DevExpress.XtraReports.UI.XtraReport, ILabReport
    {
        public Hum48CycReport(Hum48Cyc data)
        {
            InitializeComponent();
            // objectDataSource1.DataSource = data;
            // bindingSource1.DataSource = data;
        }

    }
}
