
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
using static DTB.Lab.Forms.Models.ElectricalPretestCheckList;
using DevExpress.XtraGrid.Views.Grid;

namespace DTB.Lab.Forms.Windows
{
    public partial class ElectricalPretestCheckListEditor : DevExpress.XtraEditors.XtraForm, ILabForm, ILabWindow
    {
        public TestForm LabTestForm { get; set; } = null;
        public ElectricalPretestCheckList el { get; set; } = null;
        public bool isTablet { get; set; } = false;

        private string _initialContent;
        private string _currentContent;

        public ElectricalPretestCheckListEditor()
        {
            InitializeComponent();
        }

        public ElectricalPretestCheckListEditor(TestForm f, bool isTab = false) : this()
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
                    txtJobNo, txtEngineer, txtCustomer, txtTest, txtReadProcedure, txtReadSpec, txtVerifiedSetup, txtVerifiedTest, txtEquipListGenerated, txtEquipListPrinted, txtPhotosTaken, txtEngineerInit, 
                };

                // all labels that have bold, underline, or italics need to be resized on mobile
                List<LabelControl> labelControls = new List<LabelControl>()
                {
                    lblJobNo, lblEngineer, lblCustomer, lblHeader, lblTest, lblCheck, lblInitials, lblReadProcedure, lblReadSpec, lblVerifiedSetup, lblVerifiedTest, lblEquipListGenerated, lblEquipListPrinted, lblPhotosTaken, lblEngineerInit, lblNote0, 
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
            this.el = ElectricalPretestCheckList.Load(this.LabTestForm);
			txtJobNo.EditValue = this.el.JobNo;
			txtEngineer.EditValue = this.el.Engineer;
			txtCustomer.EditValue = this.el.Customer;
			txtTest.EditValue = this.el.Test;
			txtReadProcedure.EditValue = this.el.ReadProcedure;
			chkReadProcCheck.Checked = this.el.ReadProcCheck;
			txtReadSpec.EditValue = this.el.ReadSpec;
			chkReadSpecCheck.Checked = this.el.ReadSpecCheck;
			txtVerifiedSetup.EditValue = this.el.VerifiedSetup;
			chkVerifiedSetupCheck.Checked = this.el.VerifiedSetupCheck;
			txtVerifiedTest.EditValue = this.el.VerifiedTest;
			chkVerifiedTestCheck.Checked = this.el.VerifiedTestCheck;
			txtEquipListGenerated.EditValue = this.el.EquipListGenerated;
			chkEquipListGeneratedCheck.Checked = this.el.EquipListGeneratedCheck;
			txtEquipListPrinted.EditValue = this.el.EquipListPrinted;
			chkEquipListPrintedCheck.Checked = this.el.EquipListPrintedCheck;
			txtPhotosTaken.EditValue = this.el.PhotosTaken;
			chkPhotosTakenCheck.Checked = this.el.PhotosTakenCheck;
			txtEngineerInit.EditValue = this.el.EngineerInit;

            _initialContent = ElectricalPretestCheckList.Save(this.el);

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
			this.el.ReadProcedure = txtReadProcedure.EditValue.ToString();
			this.el.ReadProcCheck = chkReadProcCheck.Checked;
			this.el.ReadSpec = txtReadSpec.EditValue.ToString();
			this.el.ReadSpecCheck = chkReadSpecCheck.Checked;
			this.el.VerifiedSetup = txtVerifiedSetup.EditValue.ToString();
			this.el.VerifiedSetupCheck = chkVerifiedSetupCheck.Checked;
			this.el.VerifiedTest = txtVerifiedTest.EditValue.ToString();
			this.el.VerifiedTestCheck = chkVerifiedTestCheck.Checked;
			this.el.EquipListGenerated = txtEquipListGenerated.EditValue.ToString();
			this.el.EquipListGeneratedCheck = chkEquipListGeneratedCheck.Checked;
			this.el.EquipListPrinted = txtEquipListPrinted.EditValue.ToString();
			this.el.EquipListPrintedCheck = chkEquipListPrintedCheck.Checked;
			this.el.PhotosTaken = txtPhotosTaken.EditValue.ToString();
			this.el.PhotosTakenCheck = chkPhotosTakenCheck.Checked;
			this.el.EngineerInit = txtEngineerInit.EditValue.ToString();


            this.LabTestForm.Content = ElectricalPretestCheckList.Save(this.el);
            
            FormTools.SaveForm<ElectricalPretestCheckList, ElectricalPretestCheckListEditor>(el, this, ref _initialContent, ref _currentContent, in checkUser);

            
            // this.LabTestForm.Save();
            // this.Close();
        }



        public XtraReport Export()
        {
            return new ElectricalPretestCheckListReport(this.el);
        }

        private void add(GridControl grdControl, GridView grdView)
        {
            // this.el.Data.Add(new ElectricalPretestCheckList.TestData());
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

        private void ElectricalPretestCheckListEditor_Load(object sender, EventArgs e)
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
