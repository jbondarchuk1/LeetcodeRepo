
using DevExpress.XtraReports.UI;
using DTB.Lab.Forms.Models;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using static DTB.Lab.Forms.Models.ElectricalCustomerInstructions;

namespace DTB.Lab.Forms.Reports
{
    public partial class ElectricalCustomerInstructionsReport : DevExpress.XtraReports.UI.XtraReport, ILabReport
    {
        public ElectricalCustomerInstructionsReport(ElectricalCustomerInstructions data)
        {
            InitializeComponent();
            objectDataSource1.DataSource = data;
            // bindingSource1.DataSource = data;
        }

    }
}
