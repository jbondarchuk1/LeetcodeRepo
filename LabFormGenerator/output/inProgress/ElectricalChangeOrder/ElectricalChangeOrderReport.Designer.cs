namespace DTB.Lab.Forms.Reports
{
    partial class ElectricalChangeOrderReport
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
            this.xrLabel21.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
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
            this.xrLabel01.Text = "Customer:";
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
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Customer]")});
            this.xrLabel22.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
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
            this.xrLabel02.Text = "Engineer:";
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
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Engineer]")});
            this.xrLabel23.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(135.7085F, 284.2499F);
            this.xrLabel23.Multiline = true;
            this.xrLabel23.Name = "xrLabel23";
            this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel23.SizeF = new System.Drawing.SizeF(155.8749F, 23.00001F);
            this.xrLabel23.StylePriority.UseFont = false;
            this.xrLabel23.Text = "xrLabel23";        

            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 25F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel20});
            this.BottomMargin.HeightF = 64.16666F;
            this.BottomMargin.Name = "BottomMargin";

            // 
            // xrLabel20
            // 
            this.xrLabel20.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[FormVersion]")});
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

            });
            this.ReportHeader.HeightF = 661.7499F;
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
            this.xrLabel32.Text = "ELECTRICAL CHANGE ORDER";
            this.xrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // ReportFooter
            // 
            this.ReportFooter.HeightF = 0F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // objectDataSource1
            // 
            this.objectDataSource1.DataSource = typeof(DTB.Lab.Forms.Models.ElectricalChangeOrder);
            this.objectDataSource1.Name = "objectDataSource1";
            // 
            // ElectricalChangeOrderReport
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

    }
}