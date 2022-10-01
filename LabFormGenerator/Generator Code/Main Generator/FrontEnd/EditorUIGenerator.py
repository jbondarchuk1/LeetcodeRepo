
class Field:
    def __init__(self, name = None, text = None, isBold = False, number = 0, hasLine = True, hasData = True, isBool = False):
        self.name = name
        self.text = text
        self.isBold = isBold
        self.number = number
        self.hasLine = hasLine
        self.hasData = hasData
        self.y = 210
        self.isBool = isBool

    def parseFromString(s):
        parts = s.split("-")
        field = Field()
        field.name = parts[0]
        # handle booleans
        if field.name[0] == "*":
            print(parts[1])
            field.name     = field.name[1:]
            field.text    = parts[1]
            field.isBold  = parts[2]
            field.hasLine = False
            field.hasData = False
            field.isBool  = True

        # handle texts
        elif len(parts) == 6:
            print(parts[1])
            field.name    = parts[0]
            field.text    = parts[1]
            field.isBold  = parts[2] == "T"
            field.hasLine = parts[3] == "T"
            field.hasData = parts[4] == "T"
        else: field.name, field.text = parts[0], parts[0]
        
        if not field.isBool and parts[-1] == "T": return None
        return field 


    def getLabelInfo(self):
        heightDiff = 45
        self.y = self.y + (self.number + 1) * heightDiff
        bold = "Bold"
        if not self.isBold: bold = "Regular"

        textInfo = f"""
            // 
            // txt{self.name}
            // 
            this.txt{self.name}.EditValue = "";
            this.txt{self.name}.Location = new System.Drawing.Point(126, {self.y - 7});
            this.txt{self.name}.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt{self.name}.Name = "txt{self.name}";
            this.txt{self.name}.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.txt{self.name}.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt{self.name}.Properties.Appearance.Options.UseBackColor = true;
            this.txt{self.name}.Properties.Appearance.Options.UseFont = true;
            this.txt{self.name}.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txt{self.name}.Size = new System.Drawing.Size(313, 22);
"""
        labelInfo = f"""
            // 
            // lbl{self.name}
            // 
            this.lbl{self.name}.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.{bold}, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl{self.name}.Appearance.Options.UseFont = true;
            this.lbl{self.name}.Location = new System.Drawing.Point(28, {self.y});
            this.lbl{self.name}.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lbl{self.name}.Name = "lbl{self.name}";
            this.lbl{self.name}.Size = new System.Drawing.Size(82, 18);
            this.lbl{self.name}.Text = "{self.text}";       
"""
        lineInfo = f"""
            // 
            // separatorControl2{self.number}
            // 
            this.separatorControl2{self.number}.Location = new System.Drawing.Point(112, {self.y + 10});
            this.separatorControl2{self.number}.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.separatorControl2{self.number}.Name = "separatorControl2{self.number}";
            this.separatorControl2{self.number}.Size = new System.Drawing.Size(336, 20);
"""            
        checkInfo = f"""
            // 
            // chk{self.name}
            // 
            this.chk{self.name}.Location = new System.Drawing.Point(66, {self.y});
            this.chk{self.name}.Name = "chk{self.name}";
            this.chk{self.name}.Properties.Caption = "{self.text}";
            this.chk{self.name}.Size = new System.Drawing.Size(67, 24);
"""  
        
        out = labelInfo
        if self.hasLine: out += lineInfo
        if self.hasData: out += textInfo
        if self.isBool: return checkInfo
        return out
    
    def getComponent(self):
        out =       f"""\t\t\tthis.lbl{self.name} = new DevExpress.XtraEditors.LabelControl();\n"""
        dataLabel = f"""\t\t\tthis.txt{self.name} = new DevExpress.XtraEditors.TextEdit();\n"""
        check = f"""\t\t\tthis.chk{self.name} = new DevExpress.XtraEditors.CheckEdit();\n"""
        line =      f"""\t\t\tthis.separatorControl2{self.number} = new DevExpress.XtraEditors.SeparatorControl();\n"""
        if self.hasLine: out += line
        if self.hasData: out += dataLabel
        if self.isBool: return check
        return out

    def getScrollableAdd(self):
        out =   f"\t\t\tthis.xtraScrollableControl1.Controls.Add(this.lbl{self.name});\n"
        text =  f"\t\t\tthis.xtraScrollableControl1.Controls.Add(this.txt{self.name});\n"
        line =  f"\t\t\tthis.xtraScrollableControl1.Controls.Add(this.separatorControl2{self.number});\n"
        check = f"\t\t\tthis.xtraScrollableControl1.Controls.Add(this.chk{self.name});\n"
        if self.hasLine: out += line
        if self.hasData: out += text
        if self.isBool:  return check
        return out

    def getSupportInit(self):
        out =   f"""\t\t\t((System.ComponentModel.ISupportInitialize)(this.lbl{self.name})).BeginInit();\n"""
        text =  f"""\t\t\t((System.ComponentModel.ISupportInitialize)(this.txt{self.name}.Properties)).BeginInit();\n"""
        line =  f"""\t\t\t((System.ComponentModel.ISupportInitialize)(this.separatorControl2{self.number})).BeginInit();\n"""
        check = f"""\t\t\t((System.ComponentModel.ISupportInitialize)(this.chk{self.name}.Properties)).BeginInit();\n"""
        if self.hasLine: out += line
        if self.hasData: out += text
        if self.isBool:  return check
        return out

    def getEndInit(self):
        out =   f"\t\t\t((System.ComponentModel.ISupportInitialize)(this.lbl{self.name})).EndInit();\n"
        text =  f"\t\t\t((System.ComponentModel.ISupportInitialize)(this.txt{self.name}).Properties).EndInit();\n"
        line =  f"\t\t\t((System.ComponentModel.ISupportInitialize)(this.separatorControl2{self.number})).EndInit();\n"
        check = f"\t\t\t((System.ComponentModel.ISupportInitialize)(this.chk{self.name}).Properties).EndInit();\n"
        if self.hasLine: out += line
        if self.hasData: out += text
        if self.isBool:  return check
        return out

    def getPrivateDeclaration(self):
        out =   f"""\t\t\tprivate DevExpress.XtraEditors.LabelControl lbl{self.name};\n"""
        text =  f"""\t\t\tprivate DevExpress.XtraEditors.TextEdit txt{self.name};\n"""
        line =  f"""\t\t\tprivate DevExpress.XtraEditors.SeparatorControl separatorControl2{self.number};\n"""
        check = f"""\t\t\tprivate DevExpress.XtraEditors.CheckEdit chk{self.name};\n"""

        if self.hasLine: out += line
        if self.hasData: out += text
        if self.isBool:  return check
        return out

class EditorUI:
    def __init__(self, classname = "", title = "", fields = []):
        self.classname = classname
        self.title = title
        self.components = ""
        self.privateDeclarations = ""
        self.componentInfos = ""
        self.scrollableAdds = ""
        self.endInits = ""
        self.supportInits = ""
        self.fields = fields
        self.scrollableHeight = 945
        self.editorHeight = 1002
    
    def generateFields(self):
        for i in range(len(self.fields)):
            field = self.fields[i]
            field.number = i
            self.components += field.getComponent()
            self.privateDeclarations += field.getPrivateDeclaration()
            self.componentInfos += field.getLabelInfo()
            self.scrollableAdds += field.getScrollableAdd()
            self.endInits += field.getEndInit()
            self.supportInits += field.getSupportInit()

    def generateEditorUI(self):
        self.generateFields()
        return f"""


namespace DTB.Lab.Forms.Windows
{{
    partial class {self.classname}Editor
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof({self.classname}Editor));
            this.btnSaveClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.lblSubtitle = new DevExpress.XtraEditors.LabelControl();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            {self.supportInits}
            this.SuspendLayout();
            {self.components}
            {self.componentInfos}
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveClose.ImageOptions.Image")));
            this.btnSaveClose.Location = new System.Drawing.Point(117, 950);
            this.btnSaveClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(154, 44);
            this.btnSaveClose.TabIndex = 9;
            this.btnSaveClose.Text = "Save and Close";
            this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(8, 950);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 44);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.AllowTouchScroll = true;
            this.xtraScrollableControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraScrollableControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.xtraScrollableControl1.Appearance.Options.UseBackColor = true;
            this.xtraScrollableControl1.Controls.Add(this.pictureBox1);
            this.xtraScrollableControl1.Controls.Add(this.lblTitle);
            this.xtraScrollableControl1.Controls.Add(this.lblSubtitle);
            {self.scrollableAdds}
            this.xtraScrollableControl1.InvertTouchScroll = true;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(-1, -2);
            this.xtraScrollableControl1.Margin = new System.Windows.Forms.Padding(4);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(881, {self.scrollableHeight});
            this.xtraScrollableControl1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(642, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 323;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Location = new System.Drawing.Point(367, 70);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(144, 16);
            this.lblTitle.TabIndex = 999;
            this.lblTitle.Text = "DAYTON T. BROWN, INC.";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubtitle.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.Appearance.Options.UseFont = true;
            this.lblSubtitle.Location = new System.Drawing.Point(387, 90);
            this.lblSubtitle.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(104, 17);
            this.lblSubtitle.TabIndex = 0;
            this.lblSubtitle.Text = "{self.title.upper()}";
            // 
            // {self.classname}Editor
            // 
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.{self.classname}Editor_FormClosing);
            this.Appearance.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, {self.editorHeight});
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "{self.classname}Editor";
            this.Text = "{self.title} Editor";
            this.Load += new System.EventHandler(this.{self.classname}Editor_Load);
            this.xtraScrollableControl1.ResumeLayout(false);
            this.xtraScrollableControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            {self.endInits}
            this.ResumeLayout(false);
        }}

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSaveClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl lblTitle;
        private DevExpress.XtraEditors.LabelControl lblSubtitle;
        {self.privateDeclarations}
    }}
}}

"""