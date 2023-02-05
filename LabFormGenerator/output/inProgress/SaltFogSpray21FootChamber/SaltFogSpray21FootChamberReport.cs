
using DevExpress.XtraReports.UI;
using DTB.Lab.Forms.Models;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using static DTB.Lab.Forms.Models.SaltFogSpray21FootChamber;

namespace DTB.Lab.Forms.Reports
{
    public partial class SaltFogSpray21FootChamberReport : DevExpress.XtraReports.UI.XtraReport, ILabReport
    {
        public SaltFogSpray21FootChamberReport(SaltFogSpray21FootChamber data)
        {
            InitializeComponent();
            objectDataSource1.DataSource = data;
            // bindingSource1.DataSource = data;
        }

    }
}
