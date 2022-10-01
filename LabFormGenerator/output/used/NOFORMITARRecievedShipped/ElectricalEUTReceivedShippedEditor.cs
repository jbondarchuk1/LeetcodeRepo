
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
using static DTB.Lab.Forms.Models.ElectricalEUTReceivedShipped;
using DevExpress.XtraGrid.Views.Grid;

namespace DTB.Lab.Forms.Windows
{
    public partial class ElectricalEUTReceivedShippedEditor : DevExpress.XtraEditors.XtraForm, ILabForm, ILabWindow
    {
        public TestForm LabTestForm { get; set; } = null;
        public ElectricalEUTReceivedShipped el { get; set; } = null;
        public bool isTablet { get; set; } = false;

        private string _initialContent;
        private string _currentContent;

        public ElectricalEUTReceivedShippedEditor()
        {
            InitializeComponent();
        }

        public ElectricalEUTReceivedShippedEditor(TestForm f, bool isTab = false) : this()
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
                    txtJobNo, txtCustomer, txtEngineer, txtCameraNo, txtTechInit0, txtTechInit1, txtTechInit2, txtTechInit3, txtTechInit4, txtTechInit5, txtTechInit6, txtTechInit7, txtDate, txtFromWho, txtOtherData, 
                };

                // all labels that have bold, underline, or italics need to be resized on mobile
                List<LabelControl> labelControls = new List<LabelControl>()
                {
                    lblNote0, lblJobNo, lblCustomer, lblEngineer, lblSubtitle0, lblCameraNo, lblTechInitLabel, lblTechInit0, lblTechInit1, lblTechInit2, lblTechInit3, lblTechInit4, lblTechInit5, lblTechInit6, lblTechInit7, lblNote01, lblNote1, lblNote2, lblDate, lblFromWho, lblOtherData, lblEndNote, 
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
            this.el = ElectricalEUTReceivedShipped.Load(this.LabTestForm);
			txtJobNo.EditValue = this.el.JobNo;
			txtCustomer.EditValue = this.el.Customer;
			txtEngineer.EditValue = this.el.Engineer;
			txtCameraNo.EditValue = this.el.CameraNo;
			chkIDLabelOnEUTY.Checked = this.el.IDLabelOnEUTY;
			chkIDLabelOnEUTN.Checked = this.el.IDLabelOnEUTN;
			txtTechInit0.EditValue = this.el.TechInit0;
			txtTechInit1.EditValue = this.el.TechInit1;
			txtTechInit2.EditValue = this.el.TechInit2;
			txtTechInit3.EditValue = this.el.TechInit3;
			txtTechInit4.EditValue = this.el.TechInit4;
			txtTechInit5.EditValue = this.el.TechInit5;
			txtTechInit6.EditValue = this.el.TechInit6;
			txtTechInit7.EditValue = this.el.TechInit7;
			chkCustomerInfoSheets.Checked = this.el.CustomerInfoSheets;
			chkEmail.Checked = this.el.Email;
			txtDate.EditValue = this.el.Date;
			txtFromWho.EditValue = this.el.FromWho;
			chkConferenceCall.Checked = this.el.ConferenceCall;
			chkIDLabel.Checked = this.el.IDLabel;
			chkOther.Checked = this.el.Other;
			txtOtherData.EditValue = this.el.OtherData;
			chkOnsiteRep.Checked = this.el.OnsiteRep;
			chkDTBFilled.Checked = this.el.DTBFilled;


            // grdTestData.DataSource = this.el.Data;

            _initialContent = ElectricalEUTReceivedShipped.Save(this.el);
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
			this.el.CameraNo = txtCameraNo.EditValue.ToString();
			this.el.IDLabelOnEUTY = chkIDLabelOnEUTY.Checked;
			this.el.IDLabelOnEUTN = chkIDLabelOnEUTN.Checked;
			this.el.TechInit0 = txtTechInit0.EditValue.ToString();
			this.el.TechInit1 = txtTechInit1.EditValue.ToString();
			this.el.TechInit2 = txtTechInit2.EditValue.ToString();
			this.el.TechInit3 = txtTechInit3.EditValue.ToString();
			this.el.TechInit4 = txtTechInit4.EditValue.ToString();
			this.el.TechInit5 = txtTechInit5.EditValue.ToString();
			this.el.TechInit6 = txtTechInit6.EditValue.ToString();
			this.el.TechInit7 = txtTechInit7.EditValue.ToString();
			this.el.CustomerInfoSheets = chkCustomerInfoSheets.Checked;
			this.el.Email = chkEmail.Checked;
			this.el.Date = txtDate.EditValue.ToString();
			this.el.FromWho = txtFromWho.EditValue.ToString();
			this.el.ConferenceCall = chkConferenceCall.Checked;
			this.el.IDLabel = chkIDLabel.Checked;
			this.el.Other = chkOther.Checked;
			this.el.OtherData = txtOtherData.EditValue.ToString();
			this.el.OnsiteRep = chkOnsiteRep.Checked;
			this.el.DTBFilled = chkDTBFilled.Checked;


            FormTools.SaveForm<ElectricalEUTReceivedShipped, ElectricalEUTReceivedShippedEditor>(el, this, ref _initialContent, ref _currentContent, in checkUser);
        }



        public XtraReport Export()
        {
            return new ElectricalEUTReceivedShippedReport(this.el);
        }

        private void add(GridControl grdControl, GridView grdView)
        {
            // this.el.Data.Add(new ElectricalEUTReceivedShipped.TestData());
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

        private void ElectricalEUTReceivedShippedEditor_Load(object sender, EventArgs e)
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

        private void ElectricalEUTReceivedShippedEditor_FormClosing(object sender, FormClosingEventArgs e)
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
