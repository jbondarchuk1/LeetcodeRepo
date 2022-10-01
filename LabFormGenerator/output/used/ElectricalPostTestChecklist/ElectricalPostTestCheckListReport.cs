
using DevExpress.XtraReports.UI;
using DTB.Lab.Forms.Models;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using static DTB.Lab.Forms.Models.ElectricalPostTestCheckList;

namespace DTB.Lab.Forms.Reports
{
    public partial class ElectricalPostTestCheckListReport : DevExpress.XtraReports.UI.XtraReport, ILabReport
    {
        public ElectricalPostTestCheckListReport(ElectricalPostTestCheckList data)
        {
            InitializeComponent();
            objectDataSource1.DataSource = data;
            // bindingSource1.DataSource = data;
        }

    }
}
