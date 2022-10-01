
using DevExpress.XtraReports.UI;
using DTB.Lab.Forms.Models;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using static DTB.Lab.Forms.Models.ElectricalTestMonitoredDataSheet;

namespace DTB.Lab.Forms.Reports
{
    public partial class ElectricalTestMonitoredDataSheetReport : DevExpress.XtraReports.UI.XtraReport, ILabReport
    {
        public ElectricalTestMonitoredDataSheetReport(ElectricalTestMonitoredDataSheet data)
        {
            InitializeComponent();
            objectDataSource1.DataSource = data;
            // bindingSource1.DataSource = data;
        }

    }
}
