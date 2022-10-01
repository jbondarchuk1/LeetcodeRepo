
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
using static DTB.Lab.Forms.Models.SolarSetupSheet;
using DevExpress.XtraGrid.Views.Grid;

namespace DTB.Lab.Forms.Windows
{
    public partial class SolarSetupSheetEditor : DevExpress.XtraEditors.XtraForm, ILabForm, ILabWindow
    {
        public TestForm LabTestForm { get; set; } = null;
        public SolarSetupSheet el { get; set; } = null;
        public bool isTablet { get; set; } = false;
        public SolarSetupSheetEditor()
        {
            InitializeComponent();
        }

        public SolarSetupSheetEditor(TestForm f, bool isTab = false) : this()
        {
            this.LabTestForm = f;
            this.isTablet = isTab;
        }

        public void load()
        {
            this.el = SolarSetupSheet.Load(this.LabTestForm);
			txtCustomer.EditValue= this.el.Customer;
			txtJobNo.EditValue= this.el.JobNo;
			txtDate.EditValue= this.el.Date;
			txtDistanceFromLight.EditValue= this.el.DistanceFromLight;
			txtAirVelOverArea.EditValue= this.el.AirVelOverArea;
			txtPyranometerNo.EditValue= this.el.PyranometerNo;
			txtLampNo0.EditValue= this.el.LampNo0;
			txtLampNo1.EditValue= this.el.LampNo1;
			txtLampNo2.EditValue= this.el.LampNo2;
			txtLampNo3.EditValue= this.el.LampNo3;
			txtLampNo4.EditValue= this.el.LampNo4;
			txtVerPerformed.EditValue= this.el.VerPerformed;
			txtTechnician.EditValue= this.el.Technician;
			txtEngineer.EditValue= this.el.Engineer;

            // grdTestData.DataSource = this.el.Data;


            if (this.isTablet)
            {

                Font tabletFont = new Font(new FontFamily("Tahoma"), 18);

                // all text edits need to be resized on mobile
                List<TextEdit> textEdits = new List<TextEdit>()
                {
                    txtCustomer, txtJobNo, txtDate, txtDistanceFromLight, txtAirVelOverArea, txtPyranometerNo, txtLampNo0, txtLampNo1, txtLampNo2, txtLampNo3, txtLampNo4, txtVerPerformed, txtTechnician, txtEngineer, 
                };

                

                // all labels that have bold, underline, or italics need to be resized on mobile

                List<LabelControl> labelControls = new List<LabelControl>()
                {
                    lblCustomer, lblJobNo, lblDate, lblNote1, lblDistanceFromLight, lblDataType1, lblAirVelOverArea, lblNote2, lblNote3, lblNote4, lblPyranometerNo, lblEnterLamp, lblLampNo0, lblLampNo1, lblLampNo2, lblLampNo3, lblLampNo4, lblNote5, lblVerPerformed, lblNote6, lblTechnician, lblEngineer, 
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

            // this.el.Data = (List<TestData>)grdTestData.DataSource;

			this.el.Customer = txtCustomer.EditValue.ToString();
			this.el.JobNo = txtJobNo.EditValue.ToString();
			this.el.Date = txtDate.EditValue.ToString();
			this.el.DistanceFromLight = txtDistanceFromLight.EditValue.ToString();
			this.el.AirVelOverArea = txtAirVelOverArea.EditValue.ToString();
			this.el.PyranometerNo = txtPyranometerNo.EditValue.ToString();
			this.el.LampNo0 = txtLampNo0.EditValue.ToString();
			this.el.LampNo1 = txtLampNo1.EditValue.ToString();
			this.el.LampNo2 = txtLampNo2.EditValue.ToString();
			this.el.LampNo3 = txtLampNo3.EditValue.ToString();
			this.el.LampNo4 = txtLampNo4.EditValue.ToString();
			this.el.VerPerformed = txtVerPerformed.EditValue.ToString();
			this.el.Technician = txtTechnician.EditValue.ToString();
			this.el.Engineer = txtEngineer.EditValue.ToString();


            this.LabTestForm.Content = SolarSetupSheet.Save(this.el);
            this.LabTestForm.Save();

            this.Close();
        }



        public XtraReport Export()
        {
            return new SolarSetupSheetReport(this.el);
        }

        private void add(GridControl grdControl, GridView grdView)
        {
            // this.el.Data.Add(new SolarSetupSheet.TestData());
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

        private void SolarSetupSheetEditor_Load(object sender, EventArgs e)
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
