

class ReportField:
    def __init__(self, name = None, text = None, isBold = False, number = 0, hasLine = True, hasData = True, isBool = False):
        self.name = name
        self.text = text
        self.isBold = isBold
        self.number = number
        self.hasLine = hasLine
        self.hasData = hasData
        self.height = 149.2499
        self.isBool = isBool

    def parseFromString(s):
        parts = s.split("-")
        field = ReportField()
        
        field.name = parts[0]
        if field.name[0] == "*":
            field.name = field.name[1:]
            field.text = parts[1]
            field.isBold = parts[2]
            field.hasLine = False
            field.hasData = False
            field.isBool = True
        
        elif len(parts) == 6:
            field.name   = parts[0]
            field.text   = parts[1]
            field.isBold = parts[2] == "T"
            field.hasLine = parts[3] == "T"
            field.hasData = parts[4] == "T"
        else: field.name, field.text = parts[0], parts[0]
        if parts[-1] == "T": return None
        return field

    def getLabelInfo(self):
        text = self.text
        heightDiff = 45
        lineHeightDiff = 25
        self.height = height = self.height + (self.number + 1) * heightDiff
        bold = ", System.Drawing.FontStyle.Bold"
        if not self.isBold: bold = ""

        labelInfo = f"""
            // 
            // xrLabel0{self.number}
            // 
            this.xrLabel0{self.number}.Font = new System.Drawing.Font("Tahoma", 10F{bold});
            this.xrLabel0{self.number}.LocationFloat = new DevExpress.Utils.PointFloat(36.79187F, {height}F);
            this.xrLabel0{self.number}.Multiline = true;
            this.xrLabel0{self.number}.Name = "xrLabel0{self.number}";
            this.xrLabel0{self.number}.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel0{self.number}.SizeF = new System.Drawing.SizeF(97.91653F, 25.08341F);
            this.xrLabel0{self.number}.StylePriority.UseFont = false;
            this.xrLabel0{self.number}.StylePriority.UseTextAlignment = false;
            this.xrLabel0{self.number}.Text = "{text}";
            this.xrLabel0{self.number}.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
"""

        dataLabelInfo = f"""
            // 
            // xrLabel2{self.number + 1}
            // 
            this.xrLabel2{self.number + 1}.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {{
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[{self.name}]")}});
            this.xrLabel2{self.number + 1}.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel2{self.number + 1}.LocationFloat = new DevExpress.Utils.PointFloat(135.7085F, {height}F);
            this.xrLabel2{self.number + 1}.Multiline = true;
            this.xrLabel2{self.number + 1}.Name = "xrLabel2{self.number + 1}";
            this.xrLabel2{self.number + 1}.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2{self.number + 1}.SizeF = new System.Drawing.SizeF(155.8749F, 23.00001F);
            this.xrLabel2{self.number + 1}.StylePriority.UseFont = false;
            this.xrLabel2{self.number + 1}.Text = "xrLabel2{self.number + 1}";        
"""

        lineInfo = f"""
                // 
                // xrLine0{self.number}
                // 
                this.xrLine0{self.number}.LocationFloat = new DevExpress.Utils.PointFloat(135.0835F, {height + lineHeightDiff}F);
                this.xrLine0{self.number}.Name = "xrLine0{self.number}";
                this.xrLine0{self.number}.SizeF = new System.Drawing.SizeF(156.4998F, 2.083328F);
"""    

        checkInfo = f"""
                // 
                // xrCheckBox0{self.number}
                // 
                this.xrCheckBox0{self.number}.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {{
                new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "CheckBoxState", "[{self.name}]")}});
                this.xrCheckBox0{self.number}.Font = new System.Drawing.Font("Tahoma", 10F{bold});
                this.xrCheckBox0{self.number}.LocationFloat = new DevExpress.Utils.PointFloat(34.7084F, {height}F);
                this.xrCheckBox0{self.number}.Name = "xrCheckBox0{self.number}";
                this.xrCheckBox0{self.number}.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
                this.xrCheckBox0{self.number}.SizeF = new System.Drawing.SizeF(100F, 23F);
                this.xrCheckBox0{self.number}.StylePriority.UseFont = false;
                this.xrCheckBox0{self.number}.Text = "{self.text}";        

"""

        
        out = labelInfo
        if self.hasLine: out += lineInfo
        if self.hasData: out += dataLabelInfo
        if self.isBool: return checkInfo
        return out
    
    def getComponent(self):
        out =       f"""\t\t\tthis.xrLabel0{self.number} = new DevExpress.XtraReports.UI.XRLabel();\n"""
        dataLabel = f"""\t\t\tthis.xrLabel2{self.number + 1} = new DevExpress.XtraReports.UI.XRLabel();\n"""
        line =      f"""\t\t\tthis.xrLine0{self.number} =  new DevExpress.XtraReports.UI.XRLine(); \n"""
        check =      f"""\t\t\tthis.xrCheckBox0{self.number} =  new DevExpress.XtraReports.UI.XRCheckBox(); \n"""
        if self.hasLine: out += line
        if self.hasData: out += dataLabel
        if self.isBool: return check
        return out

    def getComponentName(self):
        out = f"\t\t\txrLabel0{self.number},\n"
        line = f"\t\t\txrLine0{self.number},\n"
        dataLabel = f"\t\t\txrLabel2{self.number + 1},\n"
        check = f"\t\t\txrCheckBox0{self.number},\n"
        if self.hasLine: out += line
        if self.hasData: out += dataLabel
        if self.isBool: return check
        return out

    def getPrivateDeclaration(self):
        out =       f"""\t\t\tprivate DevExpress.XtraReports.UI.XRLabel xrLabel0{self.number};\n"""
        dataLabel = f"""\t\t\tprivate DevExpress.XtraReports.UI.XRLabel xrLabel2{self.number + 1};\n"""
        line =      f"""\t\t\tprivate DevExpress.XtraReports.UI.XRLine xrLine0{self.number};  \n"""
        check =      f"""\t\t\tprivate DevExpress.XtraReports.UI.XRCheckBox xrCheckBox0{self.number};  \n"""
        if self.hasLine: out += line
        if self.hasData: out += dataLabel
        if self.isBool: return check
        return out

class ReportUI:
    def __init__(self, classname = "", title = "", reportFields = [], headerHeight = 377.5):
        self.classname = classname
        self.headerHeight = headerHeight
        self.title = title
        self.components = ""
        self.componentNames = ""
        self.privateDeclarations = ""
        self.componentInfos = ""
        self.reportFields = reportFields
    
    def generateFields(self):
        for i in range(len(self.reportFields)):
            field = self.reportFields[i]
            field.number = i
            self.components += field.getComponent()
            self.componentNames += field.getComponentName()
            self.privateDeclarations += field.getPrivateDeclaration()
            self.componentInfos += field.getLabelInfo()

    def generateReportUI(self):
        self.generateFields()
        self.headerHeight += self.reportFields[-1].height
        # classname, components, componentNames, headerHeight, componentInfos, title, privateDeclarations 
        return f"""namespace DTB.Lab.Forms.Reports
{{
    partial class {self.classname}Report
    {{
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {{
            if (disposing && (components != null))
            {{
                components.Dispose();
            }}
            base.Dispose(disposing);
        }}

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {{
            this.components = new System.ComponentModel.Container();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrLabel31 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLabel32 = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            {self.components}

            this.objectDataSource1 = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).BeginInit();

            
            {self.componentInfos}
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 25F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {{
            this.xrLabel20}});
            this.BottomMargin.HeightF = 64.16666F;
            this.BottomMargin.Name = "BottomMargin";

            // 
            // xrLabel20
            // 
            this.xrLabel20.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {{
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[FormVersion]")}});
            this.xrLabel20.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.SizeF = new System.Drawing.SizeF(310.8334F, 23.1666F);
            this.xrLabel20.StylePriority.UseFont = false;
            this.xrLabel20.Text = "xrLabel20";

            // 
            // Detail
            // 
            this.Detail.Expanded = false;
            this.Detail.HeightF = 0F;
            this.Detail.Name = "Detail";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {{
            this.xrLabel31,
            this.xrPictureBox1,
            this.xrLabel32,
            {self.componentNames}
            }});
            this.ReportHeader.HeightF = {self.headerHeight}F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrLabel31
            // 
            this.xrLabel31.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel31.LocationFloat = new DevExpress.Utils.PointFloat(300.8001F, 38.54167F);
            this.xrLabel31.Multiline = true;
            this.xrLabel31.Name = "xrLabel31";
            this.xrLabel31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel31.SizeF = new System.Drawing.SizeF(188.5417F, 23.00001F);
            this.xrLabel31.StylePriority.UseFont = false;
            this.xrLabel31.StylePriority.UseTextAlignment = false;
            this.xrLabel31.Text = "DAYTON T. BROWN, INC.";
            this.xrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource(global::DTB.Lab.Forms.Properties.Resources.DTBLogo, true);
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(593F, 0F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(157F, 66F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            // 
            // xrLabel32
            // 
            this.xrLabel32.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.xrLabel32.LocationFloat = new DevExpress.Utils.PointFloat(265.9835F, 61.54168F);
            this.xrLabel32.Multiline = true;
            this.xrLabel32.Name = "xrLabel32";
            this.xrLabel32.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel32.SizeF = new System.Drawing.SizeF(243.7498F, 17.79168F);
            this.xrLabel32.StylePriority.UseFont = false;
            this.xrLabel32.StylePriority.UseTextAlignment = false;
            this.xrLabel32.Text = "{self.title.upper()}";
            this.xrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // ReportFooter
            // 
            this.ReportFooter.HeightF = 0F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // objectDataSource1
            // 
            this.objectDataSource1.DataSource = typeof(DTB.Lab.Forms.Models.{self.classname});
            this.objectDataSource1.Name = "objectDataSource1";
            // 
            // {self.classname}Report
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {{
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.ReportHeader,
            this.ReportFooter}});            
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {{
            this.objectDataSource1}});
            this.DataSource = this.objectDataSource1;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(48, 52, 25, 64);
            this.Version = "21.2";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }}

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRLabel xrLabel31;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel32;
        private DevExpress.XtraReports.UI.XRLabel xrLabel20;
        private DevExpress.DataAccess.ObjectBinding.ObjectDataSource objectDataSource1;
        {self.privateDeclarations}
    }}
}}
"""
