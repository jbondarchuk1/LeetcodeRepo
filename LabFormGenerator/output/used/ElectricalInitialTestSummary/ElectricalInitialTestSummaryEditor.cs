
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
using static DTB.Lab.Forms.Models.ElectricalInitialTestSummary;
using DevExpress.XtraGrid.Views.Grid;

namespace DTB.Lab.Forms.Windows
{
    public partial class ElectricalInitialTestSummaryEditor : DevExpress.XtraEditors.XtraForm, ILabForm, ILabWindow
    {
        public TestForm LabTestForm { get; set; } = null;
        public ElectricalInitialTestSummary el { get; set; } = null;
        public bool isTablet { get; set; } = false;

        private string _initialContent;
        private string _currentContent;

        public ElectricalInitialTestSummaryEditor()
        {
            InitializeComponent();
        }

        public ElectricalInitialTestSummaryEditor(TestForm f, bool isTab = false) : this()
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
                    txtJobNo, txtCustomer, txtEngineer, txtSpecification, txtREEUT, txtREMHzToGHz, txtREAbove, txtRSEUT, txtRSMHzToGHz, txtRSAbove, 
                };

                // all labels that have bold, underline, or italics need to be resized on mobile
                List<LabelControl> labelControls = new List<LabelControl>()
                {
                    lblNote0, lblJobNo, lblCustomer, lblEngineer, lblSpecification, lblSubtitle0, lblSubtitle1, lblSubtitle2, lblNote1, lblRE, lblREEUT, lblRELabel0, lblREMHzToGHz, lblRELabel1, lblREAbove, lblRELabel2, lblRS, lblRSEUT, lblRSLabel0, lblRSMHzToGHz, lblRSLabel1, lblRSAbove, lblRSLabel2, 
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
            this.el = ElectricalInitialTestSummary.Load(this.LabTestForm);
			txtJobNo.EditValue = this.el.JobNo;
			txtCustomer.EditValue = this.el.Customer;
			txtEngineer.EditValue = this.el.Engineer;
			txtSpecification.EditValue = this.el.Specification;
			txtREEUT.EditValue = this.el.REEUT;
			txtREMHzToGHz.EditValue = this.el.REMHzToGHz;
			txtREAbove.EditValue = this.el.REAbove;
			txtRSEUT.EditValue = this.el.RSEUT;
			txtRSMHzToGHz.EditValue = this.el.RSMHzToGHz;
			txtRSAbove.EditValue = this.el.RSAbove;


            // grdTestData.DataSource = this.el.Data;

            _initialContent = ElectricalInitialTestSummary.Save(this.el);
        }

        public void Save()
        {
            Save(false);
        }

        public void Save(bool checkUser = false)
        {
            // this.el.Data = (List<TestData>)grdTestData.DataSource;

			this.el.JobNo = txtJobNo.EditValue.ToString();
			this.el.Customer = txtCustomer.EditValue.ToString();
			this.el.Engineer = txtEngineer.EditValue.ToString();
			this.el.Specification = txtSpecification.EditValue.ToString();
			this.el.REEUT = txtREEUT.EditValue.ToString();
			this.el.REMHzToGHz = txtREMHzToGHz.EditValue.ToString();
			this.el.REAbove = txtREAbove.EditValue.ToString();
			this.el.RSEUT = txtRSEUT.EditValue.ToString();
			this.el.RSMHzToGHz = txtRSMHzToGHz.EditValue.ToString();
			this.el.RSAbove = txtRSAbove.EditValue.ToString();


            FormTools.SaveForm<ElectricalInitialTestSummary, ElectricalInitialTestSummaryEditor>(el, this, ref _initialContent, ref _currentContent, in checkUser);
        }



        public XtraReport Export()
        {
            return new ElectricalInitialTestSummaryReport(this.el);
        }

        private void add(GridControl grdControl, GridView grdView)
        {
            // this.el.Data.Add(new ElectricalInitialTestSummary.TestData());
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

        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            Save();
            this.Close();
        }

        private void ElectricalInitialTestSummaryEditor_Load(object sender, EventArgs e)
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

        private void ElectricalInitialTestSummaryEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Save(true);
            }
            catch (Exception ex)
            {
                ex.Display();
            }

        }
    }
}
