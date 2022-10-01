
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
using static DTB.Lab.Forms.Models.PostProgramCheckList;
using DevExpress.XtraGrid.Views.Grid;

namespace DTB.Lab.Forms.Windows
{
    public partial class PostProgramCheckListEditor : DevExpress.XtraEditors.XtraForm, ILabForm, ILabWindow
    {
        public TestForm LabTestForm { get; set; } = null;
        public PostProgramCheckList el { get; set; } = null;
        public bool isTablet { get; set; } = false;

        private string _initialContent;
        private string _currentContent;

        public PostProgramCheckListEditor()
        {
            InitializeComponent();
        }

        public PostProgramCheckListEditor(TestForm f, bool isTab = false) : this()
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
                    txtJobNo, txtEngineer, txtCustomer, txtInitials0, txtInitials1, txtInitials2, txtInitials3, txtInitials4, txtEngineerInitials, 
                };

                // all labels that have bold, underline, or italics need to be resized on mobile
                List<LabelControl> labelControls = new List<LabelControl>()
                {
                    lblJobNo, lblEngineer, lblCustomer, lblSubtitle0, lblCheck, lblInitials, lblInitials0, lblInitials1, lblInitials2, lblInitials3, lblInitials4, lblEngineerInitials, lblNote0, 
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
            this.el = PostProgramCheckList.Load(this.LabTestForm);
			txtJobNo.EditValue = this.el.JobNo;
			txtEngineer.EditValue = this.el.Engineer;
			txtCustomer.EditValue = this.el.Customer;
			txtInitials0.EditValue = this.el.Initials0;
			chkCheck0.Checked = this.el.Check0;
			txtInitials1.EditValue = this.el.Initials1;
			chkCheck1.Checked = this.el.Check1;
			txtInitials2.EditValue = this.el.Initials2;
			chkCheck2.Checked = this.el.Check2;
			txtInitials3.EditValue = this.el.Initials3;
			chkCheck3.Checked = this.el.Check3;
			txtInitials4.EditValue = this.el.Initials4;
			chkCheck4.Checked = this.el.Check4;
			txtEngineerInitials.EditValue = this.el.EngineerInitials;


            // grdTestData.DataSource = this.el.Data;

            _initialContent = PostProgramCheckList.Save(this.el);
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
			this.el.Initials0 = txtInitials0.EditValue.ToString();
			this.el.Check0 = chkCheck0.Checked;
			this.el.Initials1 = txtInitials1.EditValue.ToString();
			this.el.Check1 = chkCheck1.Checked;
			this.el.Initials2 = txtInitials2.EditValue.ToString();
			this.el.Check2 = chkCheck2.Checked;
			this.el.Initials3 = txtInitials3.EditValue.ToString();
			this.el.Check3 = chkCheck3.Checked;
			this.el.Initials4 = txtInitials4.EditValue.ToString();
			this.el.Check4 = chkCheck4.Checked;
			this.el.EngineerInitials = txtEngineerInitials.EditValue.ToString();


            FormTools.SaveForm<PostProgramCheckList, PostProgramCheckListEditor>(el, this, ref _initialContent, ref _currentContent, in checkUser);
        }



        public XtraReport Export()
        {
            return new PostProgramCheckListReport(this.el);
        }

        private void add(GridControl grdControl, GridView grdView)
        {
            // this.el.Data.Add(new PostProgramCheckList.TestData());
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

        private void PostProgramCheckListEditor_Load(object sender, EventArgs e)
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

        private void PostProgramCheckListEditor_FormClosing(object sender, FormClosingEventArgs e)
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
