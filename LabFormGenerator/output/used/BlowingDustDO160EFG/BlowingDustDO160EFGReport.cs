
using DevExpress.XtraReports.UI;
using DTB.Lab.Forms.Models;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using static DTB.Lab.Forms.Models.BlowingDustDO160EFG;

namespace DTB.Lab.Forms.Reports
{
    public partial class BlowingDustDO160EFGReport : DevExpress.XtraReports.UI.XtraReport, ILabReport
    {
        public BlowingDustDO160EFGReport(BlowingDustDO160EFG data)
        {
            InitializeComponent();
            objectDataSource1.DataSource = data;
            // bindingSource1.DataSource = data;
        }

    }
}
