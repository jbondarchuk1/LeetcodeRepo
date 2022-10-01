
using DevExpress.XtraReports.UI;
using DTB.Lab.Forms.Models;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using static DTB.Lab.Forms.Models.HighTemp501;

namespace DTB.Lab.Forms.Reports
{
    public partial class HighTemp501Report : DevExpress.XtraReports.UI.XtraReport, ILabReport
    {
        public HighTemp501Report(HighTemp501 data)
        {
            InitializeComponent();
            // objectDataSource1.DataSource = data;
            // bindingSource1.DataSource = data;
        }

    }
}
