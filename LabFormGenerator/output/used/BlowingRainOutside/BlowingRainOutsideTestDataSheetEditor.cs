
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
using static DTB.Lab.Forms.Models.BlowingRainOutsideTestDataSheet;
using DevExpress.XtraGrid.Views.Grid;

namespace DTB.Lab.Forms.Windows
{
    public partial class BlowingRainOutsideTestDataSheetEditor : DevExpress.XtraEditors.XtraForm, ILabForm, ILabWindow
    {
        public TestForm LabTestForm { get; set; } = null;
        public BlowingRainOutsideTestDataSheet el { get; set; } = null;
        public bool isTablet { get; set; } = false;
        public BlowingRainOutsideTestDataSheetEditor()
        {
            InitializeComponent();
        }

        public BlowingRainOutsideTestDataSheetEditor(TestForm f, bool isTab = false) : this()
        {
            this.LabTestForm = f;
            this.isTablet = isTab;
        }

        public void load()
        {
            this.el = BlowingRainOutsideTestDataSheet.Load(this.LabTestForm);
			txtInchesPerHour.EditValue= this.el.InchesPerHour;
			txtPressure.EditValue= this.el.Pressure;
			txtVelocityMph.EditValue= this.el.VelocityMph;
			txtVelocityFtMin.EditValue= this.el.VelocityFtMin;
			txtDistance.EditValue= this.el.Distance;
			txtDetail0.EditValue= this.el.Detail0;
			txtDetail1.EditValue= this.el.Detail1;
			txtDetail2.EditValue= this.el.Detail2;
			txtDetail3.EditValue= this.el.Detail3;
			txtDetail4.EditValue= this.el.Detail4;
			txtDetail5.EditValue= this.el.Detail5;
			txtDetail6.EditValue= this.el.Detail6;
			txtDetail7.EditValue= this.el.Detail7;
			txtJobNo.EditValue= this.el.JobNo;
			txtDate.EditValue= this.el.Date;
			txtEngineer.EditValue= this.el.Engineer;
			txttitle1.EditValue= this.el.title1;
			txtNote.EditValue= this.el.Note;
			txtJobNo1.EditValue= this.el.JobNo1;
			txtDate1.EditValue= this.el.Date1;
			txtEngineer1.EditValue= this.el.Engineer1;

            grdTestData.DataSource = this.el.Data;


            if (this.isTablet)
            {

                Font tabletFont = new Font(new FontFamily("Tahoma"), 18);

                // all text edits need to be resized on mobile
                List<TextEdit> textEdits = new List<TextEdit>()
                {
                    // txtInchesPerHour, txtPressure, txtVelocityMph, txtVelocityFtMin, txtDistance, txtDetail0, txtDetail1, txtDetail2, txtDetail3, txtDetail4, txtDetail5, txtDetail6, txtDetail7, txtJobNo, txtDate, txtEngineer, txttitle1, txtNote, txtJobNo1, txtDate1, txtEngineer1, 
                };

                

                // all labels that have bold, underline, or italics need to be resized on mobile

                List<LabelControl> labelControls = new List<LabelControl>()
                {
                    // lblInchesPerHour, lblPressure, lblVelocityMph, lblVelocityFtMin, lblDistance, lblDetail0, lblDetail1, lblDetail2, lblDetail3, lblDetail4, lblDetail5, lblDetail6, lblDetail7, lblJobNo, lblDate, lblEngineer, lbltitle1, lblNote, lblJobNo1, lblDate1, lblEngineer1, 
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
			this.el.InchesPerHour = txtInchesPerHour.EditValue.ToString();
			this.el.Pressure = txtPressure.EditValue.ToString();
			this.el.VelocityMph = txtVelocityMph.EditValue.ToString();
			this.el.VelocityFtMin = txtVelocityFtMin.EditValue.ToString();
			this.el.Distance = txtDistance.EditValue.ToString();
			this.el.Detail0 = txtDetail0.EditValue.ToString();
			this.el.Detail1 = txtDetail1.EditValue.ToString();
			this.el.Detail2 = txtDetail2.EditValue.ToString();
			this.el.Detail3 = txtDetail3.EditValue.ToString();
			this.el.Detail4 = txtDetail4.EditValue.ToString();
			this.el.Detail5 = txtDetail5.EditValue.ToString();
			this.el.Detail6 = txtDetail6.EditValue.ToString();
			this.el.Detail7 = txtDetail7.EditValue.ToString();
			this.el.JobNo = txtJobNo.EditValue.ToString();
			this.el.Date = txtDate.EditValue.ToString();
			this.el.Engineer = txtEngineer.EditValue.ToString();
			this.el.title1 = txttitle1.EditValue.ToString();
			this.el.Note = txtNote.EditValue.ToString();
			this.el.JobNo1 = txtJobNo1.EditValue.ToString();
			this.el.Date1 = txtDate1.EditValue.ToString();
			this.el.Engineer1 = txtEngineer1.EditValue.ToString();


            this.LabTestForm.Content = BlowingRainOutsideTestDataSheet.Save(this.el);
            this.LabTestForm.Save();

            this.Close();
        }



        //public XtraReport Export()
        //{
        //    return new BlowingRainOutsideTestDataSheetReport(this.el);
        //}

        private void add(GridControl grdControl, GridView grdView)
        {
            this.el.Data.Add(new BlowingRainOutsideTestDataSheet.TestData());
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
    }
}
