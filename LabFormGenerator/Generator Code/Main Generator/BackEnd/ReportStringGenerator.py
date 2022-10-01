def createReportFile(classname):
    return f"""
using DevExpress.XtraReports.UI;
using DTB.Lab.Forms.Models;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using static DTB.Lab.Forms.Models.{classname};

namespace DTB.Lab.Forms.Reports
{{
    public partial class {classname}Report : DevExpress.XtraReports.UI.XtraReport, ILabReport
    {{
        public {classname}Report({classname} data)
        {{
            InitializeComponent();
            objectDataSource1.DataSource = data;
            // bindingSource1.DataSource = data;
        }}

    }}
}}
"""