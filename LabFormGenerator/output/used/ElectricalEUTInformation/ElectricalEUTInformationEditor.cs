
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
using static DTB.Lab.Forms.Models.ElectricalEUTInformation;
using DevExpress.XtraGrid.Views.Grid;

namespace DTB.Lab.Forms.Windows
{
    public partial class ElectricalEUTInformationEditor : DevExpress.XtraEditors.XtraForm, ILabForm, ILabWindow
    {
        public TestForm LabTestForm { get; set; } = null;
        public ElectricalEUTInformation el { get; set; } = null;
        public bool isTablet { get; set; } = false;

        private string _initialContent;
        private string _currentContent;

        public ElectricalEUTInformationEditor()
        {
            InitializeComponent();
        }

        public ElectricalEUTInformationEditor(TestForm f, bool isTab = false) : this()
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
                    txtJobNo, txtCustomer, txtEngineer, txtPartNo0, txtModelNo0, txtSerialNo0, txtPartNo1, txtModelNo1, txtSerialNo1, txtPartNo2, txtModelNo2, txtSerialNo2, txtPartNo3, txtModelNo3, txtSerialNo3, txtCameraNo, 
                };

                // all labels that have bold, underline, or italics need to be resized on mobile
                List<LabelControl> labelControls = new List<LabelControl>()
                {
                    lblNote0, lblNote1, lblJobNo, lblCustomer, lblEngineer, lblSubtitle0, lblSystemName, lblNote2, lblPartNo0, lblModelNo0, lblSerialNo0, lblNote3, lblSubtitle1, lblComponentName, lblPartNo1, lblModelNo1, lblSerialNo1, lblNote4, lblPartNo2, lblModelNo2, lblSerialNo2, lblNote5, lblPartNo3, lblModelNo3, lblSerialNo3, lblNote6, lblCameraNo, lblNote7, 
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
            this.el = ElectricalEUTInformation.Load(this.LabTestForm);
			txtJobNo.EditValue = this.el.JobNo;
			txtCustomer.EditValue = this.el.Customer;
			txtEngineer.EditValue = this.el.Engineer;
			txtPartNo0.EditValue = this.el.PartNo0;
			txtModelNo0.EditValue = this.el.ModelNo0;
			txtSerialNo0.EditValue = this.el.SerialNo0;
			txtPartNo1.EditValue = this.el.PartNo1;
			txtModelNo1.EditValue = this.el.ModelNo1;
			txtSerialNo1.EditValue = this.el.SerialNo1;
			txtPartNo2.EditValue = this.el.PartNo2;
			txtModelNo2.EditValue = this.el.ModelNo2;
			txtSerialNo2.EditValue = this.el.SerialNo2;
			txtPartNo3.EditValue = this.el.PartNo3;
			txtModelNo3.EditValue = this.el.ModelNo3;
			txtSerialNo3.EditValue = this.el.SerialNo3;
			txtCameraNo.EditValue = this.el.CameraNo;


            // grdTestData.DataSource = this.el.Data;

            _initialContent = ElectricalEUTInformation.Save(this.el);
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
			this.el.PartNo0 = txtPartNo0.EditValue.ToString();
			this.el.ModelNo0 = txtModelNo0.EditValue.ToString();
			this.el.SerialNo0 = txtSerialNo0.EditValue.ToString();
			this.el.PartNo1 = txtPartNo1.EditValue.ToString();
			this.el.ModelNo1 = txtModelNo1.EditValue.ToString();
			this.el.SerialNo1 = txtSerialNo1.EditValue.ToString();
			this.el.PartNo2 = txtPartNo2.EditValue.ToString();
			this.el.ModelNo2 = txtModelNo2.EditValue.ToString();
			this.el.SerialNo2 = txtSerialNo2.EditValue.ToString();
			this.el.PartNo3 = txtPartNo3.EditValue.ToString();
			this.el.ModelNo3 = txtModelNo3.EditValue.ToString();
			this.el.SerialNo3 = txtSerialNo3.EditValue.ToString();
			this.el.CameraNo = txtCameraNo.EditValue.ToString();


            FormTools.SaveForm<ElectricalEUTInformation, ElectricalEUTInformationEditor>(el, this, ref _initialContent, ref _currentContent, in checkUser);
        }



        public XtraReport Export()
        {
            return new ElectricalEUTInformationReport(this.el);
        }

        private void add(GridControl grdControl, GridView grdView)
        {
            // this.el.Data.Add(new ElectricalEUTInformation.TestData());
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

        private void ElectricalEUTInformationEditor_Load(object sender, EventArgs e)
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

        private void ElectricalEUTInformationEditor_FormClosing(object sender, FormClosingEventArgs e)
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
