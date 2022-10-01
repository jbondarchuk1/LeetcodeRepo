
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
using static DTB.Lab.Forms.Models.ElectricalPostTestCheckList;
using DevExpress.XtraGrid.Views.Grid;

namespace DTB.Lab.Forms.Windows
{
    public partial class ElectricalPostTestCheckListEditor : DevExpress.XtraEditors.XtraForm, ILabForm, ILabWindow
    {
        public TestForm LabTestForm { get; set; } = null;
        public ElectricalPostTestCheckList el { get; set; } = null;
        public bool isTablet { get; set; } = false;

        private string _initialContent;
        private string _currentContent;

        public ElectricalPostTestCheckListEditor()
        {
            InitializeComponent();
        }

        public ElectricalPostTestCheckListEditor(TestForm f, bool isTab = false) : this()
        {
            this.LabTestForm = f;
            this.isTablet = isTab;
        }

        private void configure()
        {
            if (this.isTablet)
            {
                Font tabletFont = new Font(new FontFamily("Tahoma"), 18);

                // all text edits need to be resized on mobile
                List<TextEdit> textEdits = new List<TextEdit>()
                {
                    txtJobNo, txtEngineer, txtCustomer, txtTest, txtDataGenerated, txtSummarySheetFilled, txtMetReqs, txtTimeLogsReviewed, txtEngineerInit, 
                };

                // all labels that have bold, underline, or italics need to be resized on mobile
                List<LabelControl> labelControls = new List<LabelControl>()
                {
                    lblJobNo, lblEngineer, lblCustomer, lblHeader, lblTest, lblCheck, lblInitials, lblDataGenerated, lblSummarySheetFilled, lblMetReqs, lblTimeLogsReviewed, lblEngineerInit, lblNote0, 
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

        public void load()
        {
            FormTools.FormatForm(this);
            this.el = ElectricalPostTestCheckList.Load(this.LabTestForm);
			txtJobNo.EditValue = this.el.JobNo;
			txtEngineer.EditValue = this.el.Engineer;
			txtCustomer.EditValue = this.el.Customer;
			txtTest.EditValue = this.el.Test;
			txtDataGenerated.EditValue = this.el.DataGenerated;
			chkDataGeneratedCheck.Checked = this.el.DataGeneratedCheck;
			txtSummarySheetFilled.EditValue = this.el.SummarySheetFilled;
			chkSummarySheetFilledCheck.Checked = this.el.SummarySheetFilledCheck;
			txtMetReqs.EditValue = this.el.MetReqs;
			chkMetReqsCheck.Checked = this.el.MetReqsCheck;
			txtTimeLogsReviewed.EditValue = this.el.TimeLogsReviewed;
			chkTimeLogsReviewedCheck.Checked = this.el.TimeLogsReviewedCheck;
			txtEngineerInit.EditValue = this.el.EngineerInit;

            _initialContent = ElectricalPostTestCheckList.Save(this.el);

            // grdTestData.DataSource = this.el.Data;

        }

        public void Save()
        {
            Save(false);
        }

        public void Save(bool checkUser = false)
        {

            // this.el.Data = (List<TestData>)grdTestData.DataSource;

			this.el.JobNo = txtJobNo.EditValue.ToString();
			this.el.Engineer = txtEngineer.EditValue.ToString();
			this.el.Customer = txtCustomer.EditValue.ToString();
			this.el.Test = txtTest.EditValue.ToString();
			this.el.DataGenerated = txtDataGenerated.EditValue.ToString();
			this.el.DataGeneratedCheck = chkDataGeneratedCheck.Checked;
			this.el.SummarySheetFilled = txtSummarySheetFilled.EditValue.ToString();
			this.el.SummarySheetFilledCheck = chkSummarySheetFilledCheck.Checked;
			this.el.MetReqs = txtMetReqs.EditValue.ToString();
			this.el.MetReqsCheck = chkMetReqsCheck.Checked;
			this.el.TimeLogsReviewed = txtTimeLogsReviewed.EditValue.ToString();
			this.el.TimeLogsReviewedCheck = chkTimeLogsReviewedCheck.Checked;
			this.el.EngineerInit = txtEngineerInit.EditValue.ToString();


            this.LabTestForm.Content = ElectricalPostTestCheckList.Save(this.el);
            
            FormTools.SaveForm<ElectricalPostTestCheckList, ElectricalPostTestCheckListEditor>(el, this, ref _initialContent, ref _currentContent, in checkUser);

            
            // this.LabTestForm.Save();
            // this.Close();
        }



        public XtraReport Export()
        {
            return new ElectricalPostTestCheckListReport(this.el);
        }

        private void add(GridControl grdControl, GridView grdView)
        {
            // this.el.Data.Add(new ElectricalPostTestCheckList.TestData());
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
            Save();
            this.Close();
        }

        private void ElectricalPostTestCheckListEditor_Load(object sender, EventArgs e)
        {
            try
            {
                configure();
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
