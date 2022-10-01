
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
using static DTB.Lab.Forms.Models.ElectricalInputPowerCable;
using DevExpress.XtraGrid.Views.Grid;

namespace DTB.Lab.Forms.Windows
{
    public partial class ElectricalInputPowerCableEditor : DevExpress.XtraEditors.XtraForm, ILabForm, ILabWindow
    {
        public TestForm LabTestForm { get; set; } = null;
        public ElectricalInputPowerCable el { get; set; } = null;
        public bool isTablet { get; set; } = false;

        private string _initialContent;
        private string _currentContent;

        public ElectricalInputPowerCableEditor()
        {
            InitializeComponent();
        }

        public ElectricalInputPowerCableEditor(TestForm f, bool isTab = false) : this()
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
                    txtJobNo, txtCustomer, txtEngineer, txtVoltage, txtFrequency, txtPhases, txtNoLeads, 
                };

                // all labels that have bold, underline, or italics need to be resized on mobile
                List<LabelControl> labelControls = new List<LabelControl>()
                {
                    lblNote0, lblNote1, lblJobNo, lblCustomer, lblEngineer, lblSubtitle0, lblVoltage, lblFrequency, lblPhases, lblNoLeads, lblNote2, lblSubtitle1, lblNote3, lblSubtitle2, lblNote4, lblNote5, 
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
            this.el = ElectricalInputPowerCable.Load(this.LabTestForm);
			txtJobNo.EditValue = this.el.JobNo;
			txtCustomer.EditValue = this.el.Customer;
			txtEngineer.EditValue = this.el.Engineer;
			txtVoltage.EditValue = this.el.Voltage;
			txtFrequency.EditValue = this.el.Frequency;
			txtPhases.EditValue = this.el.Phases;
			txtNoLeads.EditValue = this.el.NoLeads;


            // grdTestData.DataSource = this.el.Data;

            _initialContent = ElectricalInputPowerCable.Save(this.el);
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
			this.el.Voltage = txtVoltage.EditValue.ToString();
			this.el.Frequency = txtFrequency.EditValue.ToString();
			this.el.Phases = txtPhases.EditValue.ToString();
			this.el.NoLeads = txtNoLeads.EditValue.ToString();


            FormTools.SaveForm<ElectricalInputPowerCable, ElectricalInputPowerCableEditor>(el, this, ref _initialContent, ref _currentContent, in checkUser);
        }



        public XtraReport Export()
        {
            return new ElectricalInputPowerCableReport(this.el);
        }

        private void add(GridControl grdControl, GridView grdView)
        {
            // this.el.Data.Add(new ElectricalInputPowerCable.TestData());
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

        private void ElectricalInputPowerCableEditor_Load(object sender, EventArgs e)
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

        private void ElectricalInputPowerCableEditor_FormClosing(object sender, FormClosingEventArgs e)
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
