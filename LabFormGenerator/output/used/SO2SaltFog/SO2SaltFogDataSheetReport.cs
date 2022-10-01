
using DevExpress.XtraReports.UI;
using DTB.Lab.Forms.Models;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using static DTB.Lab.Forms.Models.SO2SaltFogDataSheet;

namespace DTB.Lab.Forms.Reports
{
    public partial class SO2SaltFogDataSheetReport : DevExpress.XtraReports.UI.XtraReport, ILabReport
    {
        public SO2SaltFogDataSheetReport(SO2SaltFogDataSheet data)
        {
            InitializeComponent();
            objectDataSource1.DataSource = data;
            // bindingSource1.DataSource = data;
        }

    }
}
