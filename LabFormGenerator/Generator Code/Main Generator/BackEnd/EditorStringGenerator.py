class EditorField:
    def __init__ (self, name = "", hasData = True, isBool = False):
        self.name = name
        self.hasData = hasData
        self.isBool = isBool
    
    def parseFromString(s):
        field = EditorField()
        parts = s.split("-")
        field.name = parts[0]
        if len(field.name) > 0:
            # handle boolean values
            if field.name[0] == "*":
                field.name = field.name[1:]
                field.isBool = True
        # handle text values
        if len(parts) == 6:
            field.hasData = parts[-2] == "T"

        return field

def createEditorFile(classname, fields):
    textValues = ""
    labelValues = ""
    editorSave = ""
    editorLoad = ""

    for i in range(len(fields)):
        field = fields[i]
        if len(field.name) > 0:
            if field.isBool:
                g = [f"chk{field.name}.Checked", "=", f"this.el.{field.name}"]
                editorSave += f"\t\t\t{g[2]} {g[1]} {g[0]};\n"
                g = g[::-1]
                editorLoad += f"\t\t\t{g[2]} {g[1]} {g[0]};\n"
            else:
                if field.hasData == True:
                    textValues += f"txt{field.name}, "
                    g = [f"txt{field.name}.EditValue", "=", f"this.el.{field.name}"]
                    editorSave += f"\t\t\t{g[2]} {g[1]} {g[0]}.ToString();\n"
                    g = g[::-1]
                    editorLoad += f"\t\t\t{g[2]} {g[1]} {g[0]};\n"

                labelValues += f"lbl{field.name}, "

    return f"""
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
using static DTB.Lab.Forms.Models.{classname};
using DevExpress.XtraGrid.Views.Grid;

namespace DTB.Lab.Forms.Windows
{{
    public partial class {classname + "Editor"} : DevExpress.XtraEditors.XtraForm, ILabForm, ILabWindow
    {{
        public TestForm LabTestForm {{ get; set; }} = null;
        public {classname} el {{ get; set; }} = null;
        public bool isTablet {{ get; set; }} = false;

        private string _initialContent;
        private string _currentContent;

        public {classname + "Editor"}()
        {{
            InitializeComponent();
        }}

        public {classname + "Editor"}(TestForm f, bool isTab = false) : this()
        {{
            this.LabTestForm = f;
            this.isTablet = isTab;
        }}

        private void configure()
        {{
            if (this.isTablet)
            {{
                Font tabletFont = new Font(new FontFamily("Tahoma"), 18);

                // all text edits need to be resized on mobile
                List<TextEdit> textEdits = new List<TextEdit>()
                {{
                    {textValues}
                }};

                // all labels that have bold, underline, or italics need to be resized on mobile
                List<LabelControl> labelControls = new List<LabelControl>()
                {{
                    {labelValues}
                }};

                foreach (TextEdit t in textEdits)
                {{
                    FontStyle fontStyle = FontStyle.Regular;
                    if (t.Font.Underline)
                        fontStyle |= FontStyle.Underline;

                    if (t.Font.Bold)
                        fontStyle |= FontStyle.Bold;

                    Font newFont = new Font(new FontFamily("Tahoma"), 18, fontStyle, GraphicsUnit.Point, 1);
                    t.Font = newFont;
                }}

                foreach (LabelControl l in labelControls)
                {{

                    FontStyle fontStyle = FontStyle.Regular;
                    if (l.Font.Underline)
                        fontStyle |= FontStyle.Underline;

                    if (l.Font.Bold)
                        fontStyle |= FontStyle.Bold;

                    Font newFont = new Font(new FontFamily("Tahoma"), 18, fontStyle, GraphicsUnit.Point, 1);
                    l.Font = newFont;
                }}
            }}
        }}

        public void load()
        {{
            FormTools.FormatForm(this);
            this.el = {classname}.Load(this.LabTestForm);
{editorLoad}

            // grdTestData.DataSource = this.el.Data;

            _initialContent = {classname}.Save(this.el);
        }}

        public void Save()
        {{
            Save(false);
        }}

        public void Save(bool checkUser = false)
        {{
            // this.el.Data = (List<TestData>)grdTestData.DataSource;

{editorSave}

            FormTools.SaveForm<{classname}, {classname}Editor>(el, this, ref _initialContent, ref _currentContent, in checkUser);
        }}



        public XtraReport Export()
        {{
            return new {classname + "Report"}(this.el);
        }}

        private void add(GridControl grdControl, GridView grdView)
        {{
            // this.el.Data.Add(new {classname}.TestData());
            // grdView.FocusedRowHandle = grdView.RowCount - 1;
            // grdControl.RefreshDataSource();
        }}

        private void remove(GridControl grdControl, GridView grdView)
        {{
            // if (grdView.RowCount == 0) return;

            // if (MessageBox.Show("Are you sure you want to delete the selected item?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                // return;

            // TestData dataRow = (TestData)grdView.GetFocusedRow();
            // ((List<TestData>)grdControl.DataSource).Remove(dataRow);

            // grdControl.RefreshDataSource();
        }}

        private void btnSave_Click(object sender, EventArgs e)
        {{
            try
            {{
                Save();
            }}
            catch(Exception ex)
            {{
                ex.Display();
            }}
        }}

        private void btnSaveClose_Click(object sender, EventArgs e)
        {{
            Save();
            this.Close();
        }}

        private void {classname}Editor_Load(object sender, EventArgs e)
        {{
            try
            {{
                configure();
                load();
            }}
            catch(Exception ex)
            {{
                ex.Display();
            }}
        }}

        //private void cmdAdd_Click(object sender, EventArgs e)
        //{{
            //try
            //{{
                //add(grdTestData, vwTestData);
            //}}
            //catch (Exception ex)
            //{{
                //ex.Display();
            //}}
        //}}

        //private void cmdRemove_Click(object sender, EventArgs e)
        //{{
            //try
            //{{
                //remove(grdTestData, vwTestData);
            //}}
            //catch (Exception ex)
            //{{
                //ex.Display();
            //}}
        //}}

        private void {classname}Editor_FormClosing(object sender, FormClosingEventArgs e)
        {{
            try
            {{
                Save(true);
            }}
            catch (Exception ex)
            {{
                ex.Display();
            }}

        }}
    }}
}}
"""