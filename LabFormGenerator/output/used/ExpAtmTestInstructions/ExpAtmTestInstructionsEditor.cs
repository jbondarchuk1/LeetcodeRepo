
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
using static DTB.Lab.Forms.Models.ExpAtmTestInstructions;
using DevExpress.XtraGrid.Views.Grid;

namespace DTB.Lab.Forms.Windows
{
    public partial class ExpAtmTestInstructionsEditor : DevExpress.XtraEditors.XtraForm, ILabForm, ILabWindow
    {
        public TestForm LabTestForm { get; set; } = null;
        public ExpAtmTestInstructions el { get; set; } = null;
        public bool isTablet { get; set; } = false;
        public ExpAtmTestInstructionsEditor()
        {
            InitializeComponent();
        }

        public ExpAtmTestInstructionsEditor(TestForm f, bool isTab = false) : this()
        {
            this.LabTestForm = f;
            this.isTablet = isTab;
        }

        public void load()
        {
            this.el = ExpAtmTestInstructions.Load(this.LabTestForm);
			txtJobNo.EditValue= this.el.JobNo;
			txtCustomer.EditValue= this.el.Customer;
			txtFacility.EditValue= this.el.Facility;
			txtDate.EditValue= this.el.Date;
			txtEngineer.EditValue= this.el.Engineer;
			txtSpecification.EditValue= this.el.Specification;
			txtReqChamTemp.EditValue= this.el.ReqChamTemp;
			txtFuelTemp.EditValue= this.el.FuelTemp;
			txtVolDisplaced.EditValue= this.el.VolDisplaced;
			txtFuelType.EditValue= this.el.FuelType;
			txtNote00.EditValue= this.el.Note00;
			txtUnitOpReq.EditValue= this.el.UnitOpReq;
			txtSpecialReq.EditValue= this.el.SpecialReq;
			txtNote001.EditValue= this.el.Note001;
			txtNote002.EditValue= this.el.Note002;
			txtNote003.EditValue= this.el.Note003;

            grdTestData.DataSource = this.el.Data;


            if (this.isTablet)
            {

                Font tabletFont = new Font(new FontFamily("Tahoma"), 18);

                // all text edits need to be resized on mobile
                List<TextEdit> textEdits = new List<TextEdit>()
                {
                    // txtJobNo, txtCustomer, txtFacility, txtDate, txtEngineer, txtSpecification, txtReqChamTemp, txtFuelTemp, txtVolDisplaced, txtFuelType, txtNote00, txtUnitOpReq, txtSpecialReq, txtNote001, txtNote002, txtNote003, 
                };

                

                // all labels that have bold, underline, or italics need to be resized on mobile

                List<LabelControl> labelControls = new List<LabelControl>()
                {
                    // lblJobNo, lblCustomer, lblFacility, lblDate, lblEngineer, lblSpecification, lblReqChamTemp, lblFuelTemp, lblVolDisplaced, lblFuelType, lblNote00, lblUnitOpReq, lblSpecialReq, lblNote001, lblNote002, lblNote003, 
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
			this.el.Customer = txtCustomer.EditValue.ToString();
			this.el.Facility = txtFacility.EditValue.ToString();
			this.el.Date = txtDate.EditValue.ToString();
			this.el.Engineer = txtEngineer.EditValue.ToString();
			this.el.Specification = txtSpecification.EditValue.ToString();
			this.el.ReqChamTemp = txtReqChamTemp.EditValue.ToString();
			this.el.FuelTemp = txtFuelTemp.EditValue.ToString();
			this.el.VolDisplaced = txtVolDisplaced.EditValue.ToString();
			this.el.FuelType = txtFuelType.EditValue.ToString();
			this.el.Note00 = txtNote00.EditValue.ToString();
			this.el.UnitOpReq = txtUnitOpReq.EditValue.ToString();
			this.el.SpecialReq = txtSpecialReq.EditValue.ToString();
			this.el.Note001 = txtNote001.EditValue.ToString();
			this.el.Note002 = txtNote002.EditValue.ToString();
			this.el.Note003 = txtNote003.EditValue.ToString();


            this.LabTestForm.Content = ExpAtmTestInstructions.Save(this.el);
            this.LabTestForm.Save();

            this.Close();
        }



        public XtraReport Export()
        {
            return new ExpAtmTestInstructionsReport(this.el);
        }

        private void add(GridControl grdControl, GridView grdView)
        {
            // this.el.Data.Add(new ExpAtmTestInstructions.TestData());
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

        private void ExpAtmTestInstructionsEditor_Load(object sender, EventArgs e)
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
