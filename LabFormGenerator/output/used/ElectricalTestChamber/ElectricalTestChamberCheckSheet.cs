
using DTB.Lab.Core;
using DTB.Lab.Data;
using DTB.Lab.Data.AthenaModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTB.Lab.Forms.Models
{
    public class ElectricalTestChamberCheckSheet : ModelBase, ILabModel
    {
        
		public string JobNo { get; set; } = "";
		public string Engineer { get; set; } = "";
		public string Customer { get; set; } = "";
		public bool Check0 { get; set; } = "";
		public bool Check1 { get; set; } = "";
		public bool Check2 { get; set; } = "";
		public bool Check3 { get; set; } = "";
		public bool Check4 { get; set; } = "";
		public bool Check5 { get; set; } = "";
		public bool SolidRoom1 { get; set; } = "";
		public bool BigAnech { get; set; } = "";
		public bool Reverb { get; set; } = "";
		public bool OATS { get; set; } = "";
		public bool ThreeMeter { get; set; } = "";
		public bool EMILab { get; set; } = "";
		public bool ScreenRoom { get; set; } = "";
		public bool GTem { get; set; } = "";
		public bool LabFloor { get; set; } = "";
		public bool PanelMount { get; set; } = "";
		public bool FourInchDiameter { get; set; } = "";
		public bool Yes { get; set; } = "";
		public bool No { get; set; } = "";


        // public List<TestData> Data { get; set; } = new List<TestData>();
        // public class TestData {}

        public string FormVersion { get; set; } = "";

        public static ElectricalTestChamberCheckSheet Load(string json)
        {
            if (!json.IsValid()) return new ElectricalTestChamberCheckSheet();
            return JsonConvert.DeserializeObject<ElectricalTestChamberCheckSheet>(json);
        }

        public static ElectricalTestChamberCheckSheet Load(TestForm t)
        {

            if (!t.Content.IsValid())
            {
                // Create using Parent LabTest
                LabTest lt = LabTest.Get(t.TestID);
                return new ElectricalTestChamberCheckSheet(t,lt);
            }

            else
            {
                return Load(t.Content);
            }
        }

        // convert instance to json
        public static string Save(ElectricalTestChamberCheckSheet obj)
        {
            return JsonConvert.SerializeObject(obj);
        }



        // Instance Method
        public string Save()
        {
            return ElectricalTestChamberCheckSheet.Save(this);
        }

        public ElectricalTestChamberCheckSheet() {}

        public ElectricalTestChamberCheckSheet(TestForm tf, LabTest t)
        {
            // DateTime.Today.Date.ToString("MM/dd/yyyy");
            
			this.JobNo = t.JobNumber;
			this.Engineer = t.Engineer;
			this.Customer = t.Customer;
            this.FormVersion = GetReportVersion(tf);

        }
    }
}
