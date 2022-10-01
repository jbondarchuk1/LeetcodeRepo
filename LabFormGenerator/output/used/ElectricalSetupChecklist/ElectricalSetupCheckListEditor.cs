
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
using static DTB.Lab.Forms.Models.ElectricalSetupCheckList;
using DevExpress.XtraGrid.Views.Grid;

namespace DTB.Lab.Forms.Windows
{
    public partial class ElectricalSetupCheckListEditor : DevExpress.XtraEditors.XtraForm, ILabForm, ILabWindow
    {
        public TestForm LabTestForm { get; set; } = null;
        public ElectricalSetupCheckList el { get; set; } = null;
        public bool isTablet { get; set; } = false;

        private string _initialContent;
        private string _currentContent;

        public ElectricalSetupCheckListEditor()
        {
            InitializeComponent();
        }

        public ElectricalSetupCheckListEditor(TestForm f, bool isTab = false) : this()
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
                    txtJobNo, txtEngineer, txtCustomer, txtCheckList0, txtCheckList1, txtCheckList2, txtCheckList3, txtEngineerInit, 
                };

                // all labels that have bold, underline, or italics need to be resized on mobile
                List<LabelControl> labelControls = new List<LabelControl>()
                {
                    lblJobNo, lblEngineer, lblCustomer, lblHeader, lblCheck, lblInit, lblCheckList0, lblCheckList1, lblCheckList2, lblCheckList3, lblCheckList4, lblEngineerInit, lblCheckLabel0, 
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
            this.el = ElectricalSetupCheckList.Load(this.LabTestForm);
			txtJobNo.EditValue = this.el.JobNo;
			txtEngineer.EditValue = this.el.Engineer;
			txtCustomer.EditValue = this.el.Customer;
			txtCheckList0.EditValue = this.el.CheckList0;
			chkCheck0.Checked = this.el.Check0;
			txtCheckList1.EditValue = this.el.CheckList1;
			chkCheck1.Checked = this.el.Check1;
			txtCheckList2.EditValue = this.el.CheckList2;
			chkCheck2.Checked = this.el.Check2;
			txtCheckList3.EditValue = this.el.CheckList3;
			chkCheck3.Checked = this.el.Check3;
			txtEngineerInit.EditValue = this.el.EngineerInit;

            _initialContent = ElectricalSetupCheckList.Save(this.el);

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
			this.el.CheckList0 = txtCheckList0.EditValue.ToString();
			this.el.Check0 = chkCheck0.Checked;
			this.el.CheckList1 = txtCheckList1.EditValue.ToString();
			this.el.Check1 = chkCheck1.Checked;
			this.el.CheckList2 = txtCheckList2.EditValue.ToString();
			this.el.Check2 = chkCheck2.Checked;
			this.el.CheckList3 = txtCheckList3.EditValue.ToString();
			this.el.Check3 = chkCheck3.Checked;
			this.el.EngineerInit = txtEngineerInit.EditValue.ToString();


            this.LabTestForm.Content = ElectricalSetupCheckList.Save(this.el);
            
            FormTools.SaveForm<ElectricalSetupCheckList, ElectricalSetupCheckListEditor>(el, this, ref _initialContent, ref _currentContent, in checkUser);

            
            // this.LabTestForm.Save();
            // this.Close();
        }



        public XtraReport Export()
        {
            return new ElectricalSetupCheckListReport(this.el);
        }

        private void add(GridControl grdControl, GridView grdView)
        {
            // this.el.Data.Add(new ElectricalSetupCheckList.TestData());
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

        private void ElectricalSetupCheckListEditor_Load(object sender, EventArgs e)
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
