namespace DTB.Lab.Forms.Reports
{
    partial class PostProgramCheckListReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrLabel31 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLabel32 = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            			this.xrLabel00 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLine00 =  new DevExpress.XtraReports.UI.XRLine(); 
			this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel01 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLine01 =  new DevExpress.XtraReports.UI.XRLine(); 
			this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel02 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLine02 =  new DevExpress.XtraReports.UI.XRLine(); 
			this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel03 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel04 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel05 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel06 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLine06 =  new DevExpress.XtraReports.UI.XRLine(); 
			this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrCheckBox07 =  new DevExpress.XtraReports.UI.XRCheckBox(); 
			this.xrLabel08 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLine08 =  new DevExpress.XtraReports.UI.XRLine(); 
			this.xrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrCheckBox09 =  new DevExpress.XtraReports.UI.XRCheckBox(); 
			this.xrLabel010 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLine010 =  new DevExpress.XtraReports.UI.XRLine(); 
			this.xrLabel211 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrCheckBox011 =  new DevExpress.XtraReports.UI.XRCheckBox(); 
			this.xrLabel012 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLine012 =  new DevExpress.XtraReports.UI.XRLine(); 
			this.xrLabel213 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrCheckBox013 =  new DevExpress.XtraReports.UI.XRCheckBox(); 
			this.xrLabel014 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLine014 =  new DevExpress.XtraReports.UI.XRLine(); 
			this.xrLabel215 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrCheckBox015 =  new DevExpress.XtraReports.UI.XRCheckBox(); 
			this.xrLabel016 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLine016 =  new DevExpress.XtraReports.UI.XRLine(); 
			this.xrLabel217 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel017 = new DevExpress.XtraReports.UI.XRLabel();


            this.objectDataSource1 = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).BeginInit();

            
            
            // 
            // xrLabel00
            // 
            this.xrLabel00.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel00.LocationFloat = new DevExpress.Utils.PointFloat(36.79187F, 194.2499F);
            this.xrLabel00.Multiline = true;
            this.xrLabel00.Name = "xrLabel00";
            this.xrLabel00.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel00.SizeF = new System.Drawing.SizeF(97.91653F, 25.08341F);
            this.xrLabel00.StylePriority.UseFont = false;
            this.xrLabel00.StylePriority.UseTextAlignment = false;
            this.xrLabel00.Text = "Job No:";
            this.xrLabel00.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;

                // 
                // xrLine00
                // 
                this.xrLine00.LocationFloat = new DevExpress.Utils.PointFloat(135.0835F, 219.2499F);
                this.xrLine00.Name = "xrLine00";
                this.xrLine00.SizeF = new System.Drawing.SizeF(156.4998F, 2.083328F);

            // 
            // xrLabel21
            // 
            this.xrLabel21.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[JobNo]")});
            this.xrLabel21.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(135.7085F, 194.2499F);
            this.xrLabel21.Multiline = true;
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel21.SizeF = new System.Drawing.SizeF(155.8749F, 23.00001F);
            this.xrLabel21.StylePriority.UseFont = false;
            this.xrLabel21.Text = "xrLabel21";        

            // 
            // xrLabel01
            // 
            this.xrLabel01.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel01.LocationFloat = new DevExpress.Utils.PointFloat(36.79187F, 239.2499F);
            this.xrLabel01.Multiline = true;
            this.xrLabel01.Name = "xrLabel01";
            this.xrLabel01.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel01.SizeF = new System.Drawing.SizeF(97.91653F, 25.08341F);
            this.xrLabel01.StylePriority.UseFont = false;
            this.xrLabel01.StylePriority.UseTextAlignment = false;
            this.xrLabel01.Text = "Engineer:";
            this.xrLabel01.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;

                // 
                // xrLine01
                // 
                this.xrLine01.LocationFloat = new DevExpress.Utils.PointFloat(135.0835F, 264.2499F);
                this.xrLine01.Name = "xrLine01";
                this.xrLine01.SizeF = new System.Drawing.SizeF(156.4998F, 2.083328F);

            // 
            // xrLabel22
            // 
            this.xrLabel22.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Engineer]")});
            this.xrLabel22.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(135.7085F, 239.2499F);
            this.xrLabel22.Multiline = true;
            this.xrLabel22.Name = "xrLabel22";
            this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel22.SizeF = new System.Drawing.SizeF(155.8749F, 23.00001F);
            this.xrLabel22.StylePriority.UseFont = false;
            this.xrLabel22.Text = "xrLabel22";        

            // 
            // xrLabel02
            // 
            this.xrLabel02.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel02.LocationFloat = new DevExpress.Utils.PointFloat(36.79187F, 284.2499F);
            this.xrLabel02.Multiline = true;
            this.xrLabel02.Name = "xrLabel02";
            this.xrLabel02.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel02.SizeF = new System.Drawing.SizeF(97.91653F, 25.08341F);
            this.xrLabel02.StylePriority.UseFont = false;
            this.xrLabel02.StylePriority.UseTextAlignment = false;
            this.xrLabel02.Text = "Customer:";
            this.xrLabel02.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;

                // 
                // xrLine02
                // 
                this.xrLine02.LocationFloat = new DevExpress.Utils.PointFloat(135.0835F, 309.2499F);
                this.xrLine02.Name = "xrLine02";
                this.xrLine02.SizeF = new System.Drawing.SizeF(156.4998F, 2.083328F);

            // 
            // xrLabel23
            // 
            this.xrLabel23.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Customer]")});
            this.xrLabel23.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(135.7085F, 284.2499F);
            this.xrLabel23.Multiline = true;
            this.xrLabel23.Name = "xrLabel23";
            this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel23.SizeF = new System.Drawing.SizeF(155.8749F, 23.00001F);
            this.xrLabel23.StylePriority.UseFont = false;
            this.xrLabel23.Text = "xrLabel23";        

            // 
            // xrLabel03
            // 
            this.xrLabel03.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel03.LocationFloat = new DevExpress.Utils.PointFloat(36.79187F, 329.2499F);
            this.xrLabel03.Multiline = true;
            this.xrLabel03.Name = "xrLabel03";
            this.xrLabel03.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel03.SizeF = new System.Drawing.SizeF(97.91653F, 25.08341F);
            this.xrLabel03.StylePriority.UseFont = false;
            this.xrLabel03.StylePriority.UseTextAlignment = false;
            this.xrLabel03.Text = "Post Program Check List";
            this.xrLabel03.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;

            // 
            // xrLabel04
            // 
            this.xrLabel04.Font = new System.Drawing.Font("Tahoma", 10F);
            this.xrLabel04.LocationFloat = new DevExpress.Utils.PointFloat(36.79187F, 374.2499F);
            this.xrLabel04.Multiline = true;
            this.xrLabel04.Name = "xrLabel04";
            this.xrLabel04.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel04.SizeF = new System.Drawing.SizeF(97.91653F, 25.08341F);
            this.xrLabel04.StylePriority.UseFont = false;
            this.xrLabel04.StylePriority.UseTextAlignment = false;
            this.xrLabel04.Text = "Check";
            this.xrLabel04.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;

            // 
            // xrLabel05
            // 
            this.xrLabel05.Font = new System.Drawing.Font("Tahoma", 10F);
            this.xrLabel05.LocationFloat = new DevExpress.Utils.PointFloat(36.79187F, 419.2499F);
            this.xrLabel05.Multiline = true;
            this.xrLabel05.Name = "xrLabel05";
            this.xrLabel05.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel05.SizeF = new System.Drawing.SizeF(97.91653F, 25.08341F);
            this.xrLabel05.StylePriority.UseFont = false;
            this.xrLabel05.StylePriority.UseTextAlignment = false;
            this.xrLabel05.Text = "Initials";
            this.xrLabel05.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;

            // 
            // xrLabel06
            // 
            this.xrLabel06.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel06.LocationFloat = new DevExpress.Utils.PointFloat(36.79187F, 464.2499F);
            this.xrLabel06.Multiline = true;
            this.xrLabel06.Name = "xrLabel06";
            this.xrLabel06.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel06.SizeF = new System.Drawing.SizeF(97.91653F, 25.08341F);
            this.xrLabel06.StylePriority.UseFont = false;
            this.xrLabel06.StylePriority.UseTextAlignment = false;
            this.xrLabel06.Text = "Reviewed all info sheets are completed";
            this.xrLabel06.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;

                // 
                // xrLine06
                // 
                this.xrLine06.LocationFloat = new DevExpress.Utils.PointFloat(135.0835F, 489.2499F);
                this.xrLine06.Name = "xrLine06";
                this.xrLine06.SizeF = new System.Drawing.SizeF(156.4998F, 2.083328F);

            // 
            // xrLabel27
            // 
            this.xrLabel27.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Initials0]")});
            this.xrLabel27.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(135.7085F, 464.2499F);
            this.xrLabel27.Multiline = true;
            this.xrLabel27.Name = "xrLabel27";
            this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel27.SizeF = new System.Drawing.SizeF(155.8749F, 23.00001F);
            this.xrLabel27.StylePriority.UseFont = false;
            this.xrLabel27.Text = "xrLabel27";        

                // 
                // xrCheckBox07
                // 
                this.xrCheckBox07.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
                new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "CheckBoxState", "[Check0]")});
                this.xrCheckBox07.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
                this.xrCheckBox07.LocationFloat = new DevExpress.Utils.PointFloat(34.7084F, 509.2499F);
                this.xrCheckBox07.Name = "xrCheckBox07";
                this.xrCheckBox07.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
                this.xrCheckBox07.SizeF = new System.Drawing.SizeF(100F, 23F);
                this.xrCheckBox07.StylePriority.UseFont = false;
                this.xrCheckBox07.Text = "";        


            // 
            // xrLabel08
            // 
            this.xrLabel08.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel08.LocationFloat = new DevExpress.Utils.PointFloat(36.79187F, 554.2499F);
            this.xrLabel08.Multiline = true;
            this.xrLabel08.Name = "xrLabel08";
            this.xrLabel08.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel08.SizeF = new System.Drawing.SizeF(97.91653F, 25.08341F);
            this.xrLabel08.StylePriority.UseFont = false;
            this.xrLabel08.StylePriority.UseTextAlignment = false;
            this.xrLabel08.Text = "Tear down complete";
            this.xrLabel08.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;

                // 
                // xrLine08
                // 
                this.xrLine08.LocationFloat = new DevExpress.Utils.PointFloat(135.0835F, 579.2499F);
                this.xrLine08.Name = "xrLine08";
                this.xrLine08.SizeF = new System.Drawing.SizeF(156.4998F, 2.083328F);

            // 
            // xrLabel29
            // 
            this.xrLabel29.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Initials1]")});
            this.xrLabel29.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel29.LocationFloat = new DevExpress.Utils.PointFloat(135.7085F, 554.2499F);
            this.xrLabel29.Multiline = true;
            this.xrLabel29.Name = "xrLabel29";
            this.xrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel29.SizeF = new System.Drawing.SizeF(155.8749F, 23.00001F);
            this.xrLabel29.StylePriority.UseFont = false;
            this.xrLabel29.Text = "xrLabel29";        

                // 
                // xrCheckBox09
                // 
                this.xrCheckBox09.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
                new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "CheckBoxState", "[Check1]")});
                this.xrCheckBox09.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
                this.xrCheckBox09.LocationFloat = new DevExpress.Utils.PointFloat(34.7084F, 599.2499F);
                this.xrCheckBox09.Name = "xrCheckBox09";
                this.xrCheckBox09.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
                this.xrCheckBox09.SizeF = new System.Drawing.SizeF(100F, 23F);
                this.xrCheckBox09.StylePriority.UseFont = false;
                this.xrCheckBox09.Text = "";        


            // 
            // xrLabel010
            // 
            this.xrLabel010.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel010.LocationFloat = new DevExpress.Utils.PointFloat(36.79187F, 644.2499F);
            this.xrLabel010.Multiline = true;
            this.xrLabel010.Name = "xrLabel010";
            this.xrLabel010.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel010.SizeF = new System.Drawing.SizeF(97.91653F, 25.08341F);
            this.xrLabel010.StylePriority.UseFont = false;
            this.xrLabel010.StylePriority.UseTextAlignment = false;
            this.xrLabel010.Text = "Anti room cleaned up";
            this.xrLabel010.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;

                // 
                // xrLine010
                // 
                this.xrLine010.LocationFloat = new DevExpress.Utils.PointFloat(135.0835F, 669.2499F);
                this.xrLine010.Name = "xrLine010";
                this.xrLine010.SizeF = new System.Drawing.SizeF(156.4998F, 2.083328F);

            // 
            // xrLabel211
            // 
            this.xrLabel211.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Initials2]")});
            this.xrLabel211.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel211.LocationFloat = new DevExpress.Utils.PointFloat(135.7085F, 644.2499F);
            this.xrLabel211.Multiline = true;
            this.xrLabel211.Name = "xrLabel211";
            this.xrLabel211.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel211.SizeF = new System.Drawing.SizeF(155.8749F, 23.00001F);
            this.xrLabel211.StylePriority.UseFont = false;
            this.xrLabel211.Text = "xrLabel211";        

                // 
                // xrCheckBox011
                // 
                this.xrCheckBox011.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
                new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "CheckBoxState", "[Check2]")});
                this.xrCheckBox011.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
                this.xrCheckBox011.LocationFloat = new DevExpress.Utils.PointFloat(34.7084F, 689.2499F);
                this.xrCheckBox011.Name = "xrCheckBox011";
                this.xrCheckBox011.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
                this.xrCheckBox011.SizeF = new System.Drawing.SizeF(100F, 23F);
                this.xrCheckBox011.StylePriority.UseFont = false;
                this.xrCheckBox011.Text = "";        


            // 
            // xrLabel012
            // 
            this.xrLabel012.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel012.LocationFloat = new DevExpress.Utils.PointFloat(36.79187F, 734.2499F);
            this.xrLabel012.Multiline = true;
            this.xrLabel012.Name = "xrLabel012";
            this.xrLabel012.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel012.SizeF = new System.Drawing.SizeF(97.91653F, 25.08341F);
            this.xrLabel012.StylePriority.UseFont = false;
            this.xrLabel012.StylePriority.UseTextAlignment = false;
            this.xrLabel012.Text = "Chamber cleaned up";
            this.xrLabel012.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;

                // 
                // xrLine012
                // 
                this.xrLine012.LocationFloat = new DevExpress.Utils.PointFloat(135.0835F, 759.2499F);
                this.xrLine012.Name = "xrLine012";
                this.xrLine012.SizeF = new System.Drawing.SizeF(156.4998F, 2.083328F);

            // 
            // xrLabel213
            // 
            this.xrLabel213.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Initials3]")});
            this.xrLabel213.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel213.LocationFloat = new DevExpress.Utils.PointFloat(135.7085F, 734.2499F);
            this.xrLabel213.Multiline = true;
            this.xrLabel213.Name = "xrLabel213";
            this.xrLabel213.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel213.SizeF = new System.Drawing.SizeF(155.8749F, 23.00001F);
            this.xrLabel213.StylePriority.UseFont = false;
            this.xrLabel213.Text = "xrLabel213";        

                // 
                // xrCheckBox013
                // 
                this.xrCheckBox013.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
                new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "CheckBoxState", "[Check3]")});
                this.xrCheckBox013.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
                this.xrCheckBox013.LocationFloat = new DevExpress.Utils.PointFloat(34.7084F, 779.2499F);
                this.xrCheckBox013.Name = "xrCheckBox013";
                this.xrCheckBox013.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
                this.xrCheckBox013.SizeF = new System.Drawing.SizeF(100F, 23F);
                this.xrCheckBox013.StylePriority.UseFont = false;
                this.xrCheckBox013.Text = "";        


            // 
            // xrLabel014
            // 
            this.xrLabel014.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel014.LocationFloat = new DevExpress.Utils.PointFloat(36.79187F, 824.2499F);
            this.xrLabel014.Multiline = true;
            this.xrLabel014.Name = "xrLabel014";
            this.xrLabel014.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel014.SizeF = new System.Drawing.SizeF(97.91653F, 25.08341F);
            this.xrLabel014.StylePriority.UseFont = false;
            this.xrLabel014.StylePriority.UseTextAlignment = false;
            this.xrLabel014.Text = "Hand log book to report writer";
            this.xrLabel014.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;

                // 
                // xrLine014
                // 
                this.xrLine014.LocationFloat = new DevExpress.Utils.PointFloat(135.0835F, 849.2499F);
                this.xrLine014.Name = "xrLine014";
                this.xrLine014.SizeF = new System.Drawing.SizeF(156.4998F, 2.083328F);

            // 
            // xrLabel215
            // 
            this.xrLabel215.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Initials4]")});
            this.xrLabel215.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel215.LocationFloat = new DevExpress.Utils.PointFloat(135.7085F, 824.2499F);
            this.xrLabel215.Multiline = true;
            this.xrLabel215.Name = "xrLabel215";
            this.xrLabel215.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel215.SizeF = new System.Drawing.SizeF(155.8749F, 23.00001F);
            this.xrLabel215.StylePriority.UseFont = false;
            this.xrLabel215.Text = "xrLabel215";        

                // 
                // xrCheckBox015
                // 
                this.xrCheckBox015.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
                new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "CheckBoxState", "[Check4]")});
                this.xrCheckBox015.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
                this.xrCheckBox015.LocationFloat = new DevExpress.Utils.PointFloat(34.7084F, 869.2499F);
                this.xrCheckBox015.Name = "xrCheckBox015";
                this.xrCheckBox015.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
                this.xrCheckBox015.SizeF = new System.Drawing.SizeF(100F, 23F);
                this.xrCheckBox015.StylePriority.UseFont = false;
                this.xrCheckBox015.Text = "";        


            // 
            // xrLabel016
            // 
            this.xrLabel016.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel016.LocationFloat = new DevExpress.Utils.PointFloat(36.79187F, 914.2499F);
            this.xrLabel016.Multiline = true;
            this.xrLabel016.Name = "xrLabel016";
            this.xrLabel016.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel016.SizeF = new System.Drawing.SizeF(97.91653F, 25.08341F);
            this.xrLabel016.StylePriority.UseFont = false;
            this.xrLabel016.StylePriority.UseTextAlignment = false;
            this.xrLabel016.Text = "Engineer Initials";
            this.xrLabel016.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;

                // 
                // xrLine016
                // 
                this.xrLine016.LocationFloat = new DevExpress.Utils.PointFloat(135.0835F, 939.2499F);
                this.xrLine016.Name = "xrLine016";
                this.xrLine016.SizeF = new System.Drawing.SizeF(156.4998F, 2.083328F);

            // 
            // xrLabel217
            // 
            this.xrLabel217.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[EngineerInitials]")});
            this.xrLabel217.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel217.LocationFloat = new DevExpress.Utils.PointFloat(135.7085F, 914.2499F);
            this.xrLabel217.Multiline = true;
            this.xrLabel217.Name = "xrLabel217";
            this.xrLabel217.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel217.SizeF = new System.Drawing.SizeF(155.8749F, 23.00001F);
            this.xrLabel217.StylePriority.UseFont = false;
            this.xrLabel217.Text = "xrLabel217";        

            // 
            // xrLabel017
            // 
            this.xrLabel017.Font = new System.Drawing.Font("Tahoma", 10F);
            this.xrLabel017.LocationFloat = new DevExpress.Utils.PointFloat(36.79187F, 959.2499F);
            this.xrLabel017.Multiline = true;
            this.xrLabel017.Name = "xrLabel017";
            this.xrLabel017.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel017.SizeF = new System.Drawing.SizeF(97.91653F, 25.08341F);
            this.xrLabel017.StylePriority.UseFont = false;
            this.xrLabel017.StylePriority.UseTextAlignment = false;
            this.xrLabel017.Text = "Must be completed and approved before moving on";
            this.xrLabel017.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;

            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 25F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel19,
            this.xrLabel20});
            this.BottomMargin.HeightF = 64.16666F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // xrLabel19
            // 
            this.xrLabel19.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel19.Multiline = true;
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel19.SizeF = new System.Drawing.SizeF(326.6118F, 23.1666F);
            this.xrLabel19.StylePriority.UseFont = false;
            this.xrLabel19.StylePriority.UseTextAlignment = false;
            this.xrLabel19.Text = "Dept 04 Standard Test Paperwork, RELEASED 6 MAY 2020 FILE NAME: ";
            this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            // 
            // xrLabel20
            // 
            this.xrLabel20.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(439.1666F, 0F);
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.SizeF = new System.Drawing.SizeF(310.8334F, 23.1666F);
            this.xrLabel20.StylePriority.UseFont = false;
            this.xrLabel20.Text = "SHEET: DSHT, ";
            // 
            // Detail
            // 
            this.Detail.Expanded = false;
            this.Detail.HeightF = 0F;
            this.Detail.Name = "Detail";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel31,
            this.xrPictureBox1,
            this.xrLabel32,
            			xrLabel00,
			xrLine00,
			xrLabel21,
			xrLabel01,
			xrLine01,
			xrLabel22,
			xrLabel02,
			xrLine02,
			xrLabel23,
			xrLabel03,
			xrLabel04,
			xrLabel05,
			xrLabel06,
			xrLine06,
			xrLabel27,
			xrCheckBox07,
			xrLabel08,
			xrLine08,
			xrLabel29,
			xrCheckBox09,
			xrLabel010,
			xrLine010,
			xrLabel211,
			xrCheckBox011,
			xrLabel012,
			xrLine012,
			xrLabel213,
			xrCheckBox013,
			xrLabel014,
			xrLine014,
			xrLabel215,
			xrCheckBox015,
			xrLabel016,
			xrLine016,
			xrLabel217,
			xrLabel017,

            });
            this.ReportHeader.HeightF = 1336.7499F;
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
            this.xrLabel32.Text = "POST PROGRAM CHECK LIST";
            this.xrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // ReportFooter
            // 
            this.ReportFooter.HeightF = 0F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // objectDataSource1
            // 
            this.objectDataSource1.DataSource = typeof(DTB.Lab.Forms.Models.PostProgramCheckList);
            this.objectDataSource1.Name = "objectDataSource1";
            // 
            // PostProgramCheckListReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.ReportHeader,
            this.ReportFooter});            
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.objectDataSource1});
            this.DataSource = this.objectDataSource1;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(48, 52, 25, 64);
            this.Version = "21.2";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRLabel xrLabel31;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel32;
        private DevExpress.XtraReports.UI.XRLabel xrLabel19;
        private DevExpress.XtraReports.UI.XRLabel xrLabel20;
        private DevExpress.DataAccess.ObjectBinding.ObjectDataSource objectDataSource1;
        			private DevExpress.XtraReports.UI.XRLabel xrLabel00;
			private DevExpress.XtraReports.UI.XRLine xrLine00;  
			private DevExpress.XtraReports.UI.XRLabel xrLabel21;
			private DevExpress.XtraReports.UI.XRLabel xrLabel01;
			private DevExpress.XtraReports.UI.XRLine xrLine01;  
			private DevExpress.XtraReports.UI.XRLabel xrLabel22;
			private DevExpress.XtraReports.UI.XRLabel xrLabel02;
			private DevExpress.XtraReports.UI.XRLine xrLine02;  
			private DevExpress.XtraReports.UI.XRLabel xrLabel23;
			private DevExpress.XtraReports.UI.XRLabel xrLabel03;
			private DevExpress.XtraReports.UI.XRLabel xrLabel04;
			private DevExpress.XtraReports.UI.XRLabel xrLabel05;
			private DevExpress.XtraReports.UI.XRLabel xrLabel06;
			private DevExpress.XtraReports.UI.XRLine xrLine06;  
			private DevExpress.XtraReports.UI.XRLabel xrLabel27;
			private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox07;  
			private DevExpress.XtraReports.UI.XRLabel xrLabel08;
			private DevExpress.XtraReports.UI.XRLine xrLine08;  
			private DevExpress.XtraReports.UI.XRLabel xrLabel29;
			private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox09;  
			private DevExpress.XtraReports.UI.XRLabel xrLabel010;
			private DevExpress.XtraReports.UI.XRLine xrLine010;  
			private DevExpress.XtraReports.UI.XRLabel xrLabel211;
			private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox011;  
			private DevExpress.XtraReports.UI.XRLabel xrLabel012;
			private DevExpress.XtraReports.UI.XRLine xrLine012;  
			private DevExpress.XtraReports.UI.XRLabel xrLabel213;
			private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox013;  
			private DevExpress.XtraReports.UI.XRLabel xrLabel014;
			private DevExpress.XtraReports.UI.XRLine xrLine014;  
			private DevExpress.XtraReports.UI.XRLabel xrLabel215;
			private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox015;  
			private DevExpress.XtraReports.UI.XRLabel xrLabel016;
			private DevExpress.XtraReports.UI.XRLine xrLine016;  
			private DevExpress.XtraReports.UI.XRLabel xrLabel217;
			private DevExpress.XtraReports.UI.XRLabel xrLabel017;

    }
}
