
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
using static DTB.Lab.Forms.Models.BlowingDustDO160EFG;
using DevExpress.XtraGrid.Views.Grid;

namespace DTB.Lab.Forms.Windows
{
    public partial class BlowingDustDO160EFGEditor : DevExpress.XtraEditors.XtraForm, ILabForm, ILabWindow
    {
        public TestForm LabTestForm { get; set; } = null;
        public BlowingDustDO160EFG el { get; set; } = null;
        public bool isTablet { get; set; } = false;
        public BlowingDustDO160EFGEditor()
        {
            InitializeComponent();
        }

        public BlowingDustDO160EFGEditor(TestForm f, bool isTab = false) : this()
        {
            this.LabTestForm = f;
            this.isTablet = isTab;
        }

        public void load()
        {
            this.el = BlowingDustDO160EFG.Load(this.LabTestForm);
			txtJobNo.EditValue= this.el.JobNo;
			txtDate.EditValue= this.el.Date;
			txtReqNumSides.EditValue= this.el.ReqNumSides;
			txtReqDurPerSide.EditValue= this.el.ReqDurPerSide;
			txtRemarks.EditValue= this.el.Remarks;
			txtEngineer.EditValue= this.el.Engineer;

            // grdTestData.DataSource = this.el.Data;


            if (this.isTablet)
            {

                Font tabletFont = new Font(new FontFamily("Tahoma"), 18);

                // all text edits need to be resized on mobile
                List<TextEdit> textEdits = new List<TextEdit>()
                {
                    txtJobNo, txtDate, txtReqNumSides, txtReqDurPerSide, txtRemarks, txtEngineer, 
                };

                

                // all labels that have bold, underline, or italics need to be resized on mobile

                List<LabelControl> labelControls = new List<LabelControl>()
                {
                    lblJobNo, lblDate, lblReqNumSides, lblReqDurPerSide, lblRemarks, lblEngineer, 
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

            // this.el.Data = grdTestData.DataSource;

			this.el.JobNo = txtJobNo.EditValue.ToString();
			this.el.Date = txtDate.EditValue.ToString();
			this.el.ReqNumSides = txtReqNumSides.EditValue.ToString();
			this.el.ReqDurPerSide = txtReqDurPerSide.EditValue.ToString();
			this.el.Remarks = txtRemarks.EditValue.ToString();
			this.el.Engineer = txtEngineer.EditValue.ToString();


            this.LabTestForm.Content = BlowingDustDO160EFG.Save(this.el);
            this.LabTestForm.Save();

            this.Close();
        }



        public XtraReport Export()
        {
            return new BlowingDustDO160EFGReport(this.el);
        }

        private void add(GridControl grdControl, GridView grdView)
        {
            // this.el.Data.Add(new BlowingDustDO160EFG.TestData());
            // grdView.FocusedRowHandle = grdView.RowCount - 1;
            // grdControl.RefreshDataSource();
        }

        private void remove(GridControl grdControl, GridView grdView)
        {
            // if (grdView.RowCount == 0) return;

            // if (MessageBox.Show("Are you sure you want to delete the selected item?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                // return;

            // TestData dataRow = (TestData)grdView.GetFocusedRow();
            // ((List<TestData>)grdControl.DataSource).Remove(dataRow);

            // grdControl.RefreshDataSource();
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

        private void BlowingDustDO160EFGEditor_Load(object sender, EventArgs e)
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

        //private void cmdAdd_Click(object sender, EventArgs e)
        //{
            //try
            //{
                //add(grdTestData, vwTestData);
            //}
            //catch (Exception ex)
            //{
                //ex.Display();
            //}
        //}

        //private void cmdRemove_Click(object sender, EventArgs e)
        //{
            //try
            //{
                //remove(grdTestData, vwTestData);
            //}
            //catch (Exception ex)
            //{
                //ex.Display();
            //}
        //}
    }
}
