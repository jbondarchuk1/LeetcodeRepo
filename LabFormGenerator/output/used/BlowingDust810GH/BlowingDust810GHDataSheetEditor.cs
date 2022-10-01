
using DevExpress.XtraGrid;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using DTB.Lab.Data;
using DTB.Lab.Forms.Models;
using DTB.Lab.Forms.Reports;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static DTB.Lab.Forms.Models.BlowingDust810GHDataSheet;
using DevExpress.XtraGrid.Views.Grid;

namespace DTB.Lab.Forms.Windows
{
    public partial class BlowingDust810GHDataSheetEditor : DevExpress.XtraEditors.XtraForm, ILabForm, ILabWindow
    {
        public TestForm LabTestForm { get; set; } = null;
        public BlowingDust810GHDataSheet el { get; set; } = null;
        public bool isTablet { get; set; } = false;
        public BlowingDust810GHDataSheetEditor()
        {
            InitializeComponent();
        }

        public BlowingDust810GHDataSheetEditor(TestForm f, bool isTab = false) : this()
        {
            this.LabTestForm = f;
            this.isTablet = isTab;
        }

        public void load()
        {
            this.el = BlowingDust810GHDataSheet.Load(this.LabTestForm);
			txtJobNo.EditValue= this.el.JobNo;
			txtDate.EditValue= this.el.Date;
			txtReqNumSide.EditValue= this.el.ReqNumSide;
			txtReqDurPerSide.EditValue= this.el.ReqDurPerSide;
			txtPretestTestItemTemp.EditValue= this.el.PretestTestItemTemp;
			txtDegreesF.EditValue= this.el.DegreesF;
			txttitle1.EditValue= this.el.title1;
			txtJobNo1.EditValue= this.el.JobNo1;
			txtDate1.EditValue= this.el.Date1;
			txtEngineer1.EditValue= this.el.Engineer1;
			txtRemarks1.EditValue= this.el.Remarks1;

            grdTestData.DataSource = this.el.Data;


            if (this.isTablet)
            {

                Font tabletFont = new Font(new FontFamily("Tahoma"), 18);

                // all text edits need to be resized on mobile
                List<TextEdit> textEdits = new List<TextEdit>()
                {
                    // txtJobNo, txtDate, txtReqNumSide, txtReqDurPerSide, txtPretestTestItemTemp, txtDegreesF, txttitle1, txtJobNo1, txtDate1, txtEngineer1, txtRemarks1, 
                };

                

                // all labels that have bold, underline, or italics need to be resized on mobile

                List<LabelControl> labelControls = new List<LabelControl>()
                {
                    // lblJobNo, lblDate, lblReqNumSide, lblReqDurPerSide, lblPretestTestItemTemp, lblDegreesF, lbltitle1, lblJobNo1, lblDate1, lblEngineer1, lblRemarks1, 
                };


                foreach (TextEdit t in textEdits)
                {
                    FontStyle fontStyle = FontStyle.Regular;
                    if (t.Font.Underline)
                        fontStyle |= FontStyle.Underline;

                    if (t.Font.Bold)
                        fontStyle |= FontStyle.Bold;

                    Font newFont = new Font(new FontFamily("Tahoma"), 18, fontStyle, GraphicsUnit.Point, 1);
                    t.Font = newFont;
                }

                foreach (LabelControl l in labelControls)
                {

                    FontStyle fontStyle = FontStyle.Regular;
                    if (l.Font.Underline)
                        fontStyle |= FontStyle.Underline;

                    if (l.Font.Bold)
                        fontStyle |= FontStyle.Bold;

                    Font newFont = new Font(new FontFamily("Tahoma"), 18, fontStyle, GraphicsUnit.Point, 1);
                    l.Font = newFont;
                }
            }
        }

        public void Save()
        {
			this.el.JobNo = txtJobNo.EditValue.ToString();
			this.el.Date = txtDate.EditValue.ToString();
			this.el.ReqNumSide = txtReqNumSide.EditValue.ToString();
			this.el.ReqDurPerSide = txtReqDurPerSide.EditValue.ToString();
			this.el.PretestTestItemTemp = txtPretestTestItemTemp.EditValue.ToString();
			this.el.DegreesF = txtDegreesF.EditValue.ToString();
			this.el.title1 = txttitle1.EditValue.ToString();
			this.el.JobNo1 = txtJobNo1.EditValue.ToString();
			this.el.Date1 = txtDate1.EditValue.ToString();
			this.el.Engineer1 = txtEngineer1.EditValue.ToString();
			this.el.Remarks1 = txtRemarks1.EditValue.ToString();


            this.LabTestForm.Content = BlowingDust810GHDataSheet.Save(this.el);
            this.LabTestForm.Save();

            this.Close();
        }



        //public XtraReport Export()
        //{
        //    return new BlowingDust810GHDataSheetReport(this.el);
        //}

        private void add(GridControl grdControl, GridView grdView)
        {
            this.el.Data.Add(new BlowingDust810GHDataSheet.TestData());
            grdView.FocusedRowHandle = grdView.RowCount - 1;
            grdControl.RefreshDataSource();
        }

        private void remove(GridControl grdControl, GridView grdView)
        {
            if (grdView.RowCount == 0) return;

            if (MessageBox.Show("Are you sure you want to delete the selected item?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            TestData dataRow = (TestData)grdView.GetFocusedRow();
            ((List<TestData>)grdControl.DataSource).Remove(dataRow);

            grdControl.RefreshDataSource();
        }

                private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Save();
            }
            catch(Exception ex)
            {
                ex.Display();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BlowingDust810GHDataSheetEditor_Load(object sender, EventArgs e)
        {
            try
            {
                load();
            }
            catch(Exception ex)
            {
                ex.Display();
            }
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // add(grdTestData, vwTestData);

            }
            catch (Exception ex)
            {
                ex.Display();
            }
        }

        private void cmdRemove_Click(object sender, EventArgs e)
        {
            try
            {
                // remove(grdTestData, vwTestData);
            }
            catch (Exception ex)
            {
                ex.Display();
            }
        }
    }
}
