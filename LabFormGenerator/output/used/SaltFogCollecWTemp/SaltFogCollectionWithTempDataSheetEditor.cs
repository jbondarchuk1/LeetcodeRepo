
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
using static DTB.Lab.Forms.Models.SaltFogCollectionWithTempDataSheet;
using DevExpress.XtraGrid.Views.Grid;

namespace DTB.Lab.Forms.Windows
{
    public partial class SaltFogCollectionWithTempDataSheetEditor : DevExpress.XtraEditors.XtraForm, ILabForm, ILabWindow
    {
        public TestForm LabTestForm { get; set; } = null;
        public SaltFogCollectionWithTempDataSheet el { get; set; } = null;
        public bool isTablet { get; set; } = false;
        public SaltFogCollectionWithTempDataSheetEditor()
        {
            InitializeComponent();
        }

        public SaltFogCollectionWithTempDataSheetEditor(TestForm f, bool isTab = false) : this()
        {
            this.LabTestForm = f;
            this.isTablet = isTab;
        }

        public void load()
        {
            this.el = SaltFogCollectionWithTempDataSheet.Load(this.LabTestForm);
			txtJobNo.EditValue= this.el.JobNo;
			txtDate.EditValue= this.el.Date;
			txtSpecification.EditValue= this.el.Specification;
			txtSpecGrav.EditValue= this.el.SpecGrav;
			txtChamTempTol.EditValue= this.el.ChamTempTol;
			txtCollectionRate.EditValue= this.el.CollectionRate;
			txtPHCollectedSol.EditValue= this.el.PHCollectedSol;
			txtWaterDataDate.EditValue= this.el.WaterDataDate;
			txtWaterDataConductivity.EditValue= this.el.WaterDataConductivity;
			txtTemp.EditValue= this.el.Temp;
			txtSpecGrav.EditValue= this.el.SpecGrav;
			txtPH.EditValue= this.el.PH;
			txtComments.EditValue= this.el.Comments;
			txtEngineer.EditValue= this.el.Engineer;

            // grdTestData.DataSource = this.el.Data;


            if (this.isTablet)
            {

                Font tabletFont = new Font(new FontFamily("Tahoma"), 18);

                // all text edits need to be resized on mobile
                List<TextEdit> textEdits = new List<TextEdit>()
                {
                    txtJobNo, txtDate, txtSpecification, txtSpecGrav, txtChamTempTol, txtCollectionRate, txtPHCollectedSol, txtWaterDataDate, txtWaterDataConductivity, txtTemp, txtSpecGrav, txtPH, txtComments, txtEngineer, 
                };

                

                // all labels that have bold, underline, or italics need to be resized on mobile

                List<LabelControl> labelControls = new List<LabelControl>()
                {
                    lblJobNo, lblDate, lblSubtitle, lblSpecification, lblSpecGrav, lblChamTempTol, lblCollectionRate, lblPHCollectedSol, lblNote1, lblWaterData, lblDeionized, lblWaterDataDate, lblWaterDataConductivity, lblmicro, lblmust, lblsubtitle2, lblTemp, lblSpecGrav, lblPH, lblComments, lblEngineer, 
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

			this.el.JobNo = txtJobNo.EditValue.ToString();
			this.el.Date = txtDate.EditValue.ToString();
			this.el.Specification = txtSpecification.EditValue.ToString();
			this.el.SpecGrav = txtSpecGrav.EditValue.ToString();
			this.el.ChamTempTol = txtChamTempTol.EditValue.ToString();
			this.el.CollectionRate = txtCollectionRate.EditValue.ToString();
			this.el.PHCollectedSol = txtPHCollectedSol.EditValue.ToString();
			this.el.WaterDataDate = txtWaterDataDate.EditValue.ToString();
			this.el.WaterDataConductivity = txtWaterDataConductivity.EditValue.ToString();
			this.el.Temp = txtTemp.EditValue.ToString();
			this.el.SpecGrav = txtSpecGrav.EditValue.ToString();
			this.el.PH = txtPH.EditValue.ToString();
			this.el.Comments = txtComments.EditValue.ToString();
			this.el.Engineer = txtEngineer.EditValue.ToString();


            this.LabTestForm.Content = SaltFogCollectionWithTempDataSheet.Save(this.el);
            this.LabTestForm.Save();

            this.Close();
        }



        public XtraReport Export()
        {
            return new SaltFogCollectionWithTempDataSheetReport(this.el);
        }

        private void add(GridControl grdControl, GridView grdView)
        {
            // this.el.Data.Add(new SaltFogCollectionWithTempDataSheet.TestData());
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

        private void SaltFogCollectionWithTempDataSheetEditor_Load(object sender, EventArgs e)
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
