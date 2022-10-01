
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
using static DTB.Lab.Forms.Models.HighTemp501;
using DevExpress.XtraGrid.Views.Grid;

namespace DTB.Lab.Forms.Windows
{
    public partial class HighTemp501Editor : DevExpress.XtraEditors.XtraForm, ILabForm, ILabWindow
    {
        public TestForm LabTestForm { get; set; } = null;
        public HighTemp501 el { get; set; } = null;
        public bool isTablet { get; set; } = false;
        public HighTemp501Editor()
        {
            InitializeComponent();
        }

        public HighTemp501Editor(TestForm f, bool isTab = false) : this()
        {
            this.LabTestForm = f;
            this.isTablet = isTab;
        }

        public void load()
        {
            this.el = HighTemp501.Load(this.LabTestForm);
			txtJobNo.EditValue= this.el.JobNo;
			txtDate.EditValue= this.el.Date;
			txtTest.EditValue= this.el.Test;
			txtCycleDesc.EditValue= this.el.CycleDesc;
			txtBasicHot.EditValue= this.el.BasicHot;
			txtCycle.EditValue= this.el.Cycle;
			txtEngineer.EditValue= this.el.Engineer;

            grdTestData.DataSource = this.el.Data;


            if (this.isTablet)
            {

                Font tabletFont = new Font(new FontFamily("Tahoma"), 18);

                // all text edits need to be resized on mobile
                List<TextEdit> textEdits = new List<TextEdit>()
                {
                    // txtJobNo, txtDate, txtTest, txtCycleDesc, txtBasicHot, txtCycle, txtEngineer, 
                };

                

                // all labels that have bold, underline, or italics need to be resized on mobile

                List<LabelControl> labelControls = new List<LabelControl>()
                {
                    // lblNote0, lblNote1, lblNote2, lblNote3, lblJobNo, lblDate, lblTest, lblCycleDesc, lblBasicHot, lblCycle, lblEngineer, lblNote001, lblNote002, lblNote003, 
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
			this.el.Test = txtTest.EditValue.ToString();
			this.el.CycleDesc = txtCycleDesc.EditValue.ToString();
			this.el.BasicHot = txtBasicHot.EditValue.ToString();
			this.el.Cycle = txtCycle.EditValue.ToString();
			this.el.Engineer = txtEngineer.EditValue.ToString();


            this.LabTestForm.Content = HighTemp501.Save(this.el);
            this.LabTestForm.Save();

            this.Close();
        }



        public XtraReport Export()
        {
            return new HighTemp501Report(this.el);
        }

        private void add(GridControl grdControl, GridView grdView)
        {
            // this.el.Data.Add(new HighTemp501.TestData());
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

        private void HighTemp501Editor_Load(object sender, EventArgs e)
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
