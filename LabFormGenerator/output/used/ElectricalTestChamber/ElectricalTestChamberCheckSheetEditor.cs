
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
using static DTB.Lab.Forms.Models.ElectricalTestChamberCheckSheet;
using DevExpress.XtraGrid.Views.Grid;

namespace DTB.Lab.Forms.Windows
{
    public partial class ElectricalTestChamberCheckSheetEditor : DevExpress.XtraEditors.XtraForm, ILabForm, ILabWindow
    {
        public TestForm LabTestForm { get; set; } = null;
        public ElectricalTestChamberCheckSheet el { get; set; } = null;
        public bool isTablet { get; set; } = false;

        private string _initialContent;
        private string _currentContent;

        public ElectricalTestChamberCheckSheetEditor()
        {
            InitializeComponent();
        }

        public ElectricalTestChamberCheckSheetEditor(TestForm f, bool isTab = false) : this()
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
                    txtJobNo, txtEngineer, txtCustomer, 
                };

                // all labels that have bold, underline, or italics need to be resized on mobile
                List<LabelControl> labelControls = new List<LabelControl>()
                {
                    lblNote0, lblJobNo, lblEngineer, lblCustomer, lblTestChamber, lblTableTop, lblVertMount, lblFloorStandMount, lblNonMet, lblBonding, lblCheckAllThatApply0, lblCheckAllThatApply1, lblNote1, lblCheckOne, lblNote2, 
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
            this.el = ElectricalTestChamberCheckSheet.Load(this.LabTestForm);
			txtJobNo.EditValue = this.el.JobNo;
			txtEngineer.EditValue = this.el.Engineer;
			txtCustomer.EditValue = this.el.Customer;
			chkCheck0.Checked = this.el.Check0;
			chkCheck1.Checked = this.el.Check1;
			chkCheck2.Checked = this.el.Check2;
			chkCheck3.Checked = this.el.Check3;
			chkCheck4.Checked = this.el.Check4;
			chkCheck5.Checked = this.el.Check5;
			chkSolidRoom1.Checked = this.el.SolidRoom1;
			chkBigAnech.Checked = this.el.BigAnech;
			chkReverb.Checked = this.el.Reverb;
			chkOATS.Checked = this.el.OATS;
			chkThreeMeter.Checked = this.el.ThreeMeter;
			chkEMILab.Checked = this.el.EMILab;
			chkScreenRoom.Checked = this.el.ScreenRoom;
			chkGTem.Checked = this.el.GTem;
			chkLabFloor.Checked = this.el.LabFloor;
			chkPanelMount.Checked = this.el.PanelMount;
			chkFourInchDiameter.Checked = this.el.FourInchDiameter;
			chkYes.Checked = this.el.Yes;
			chkNo.Checked = this.el.No;

            _initialContent = ElectricalTestChamberCheckSheet.Save(this.el);

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
			this.el.Check0 = chkCheck0.Checked;
			this.el.Check1 = chkCheck1.Checked;
			this.el.Check2 = chkCheck2.Checked;
			this.el.Check3 = chkCheck3.Checked;
			this.el.Check4 = chkCheck4.Checked;
			this.el.Check5 = chkCheck5.Checked;
			this.el.SolidRoom1 = chkSolidRoom1.Checked;
			this.el.BigAnech = chkBigAnech.Checked;
			this.el.Reverb = chkReverb.Checked;
			this.el.OATS = chkOATS.Checked;
			this.el.ThreeMeter = chkThreeMeter.Checked;
			this.el.EMILab = chkEMILab.Checked;
			this.el.ScreenRoom = chkScreenRoom.Checked;
			this.el.GTem = chkGTem.Checked;
			this.el.LabFloor = chkLabFloor.Checked;
			this.el.PanelMount = chkPanelMount.Checked;
			this.el.FourInchDiameter = chkFourInchDiameter.Checked;
			this.el.Yes = chkYes.Checked;
			this.el.No = chkNo.Checked;


            this.LabTestForm.Content = ElectricalTestChamberCheckSheet.Save(this.el);
            
            FormTools.SaveForm<ElectricalTestChamberCheckSheet, ElectricalTestChamberCheckSheetEditor>(el, this, ref _initialContent, ref _currentContent, in checkUser);

            
            // this.LabTestForm.Save();
            // this.Close();
        }



        public XtraReport Export()
        {
            return new ElectricalTestChamberCheckSheetReport(this.el);
        }

        private void add(GridControl grdControl, GridView grdView)
        {
            // this.el.Data.Add(new ElectricalTestChamberCheckSheet.TestData());
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

        private void ElectricalTestChamberCheckSheetEditor_Load(object sender, EventArgs e)
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
