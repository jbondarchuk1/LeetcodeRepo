
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
    public class ElectricalInitialTestSummary : ModelBase, ILabModel
    {
        
		public string JobNo { get; set; } = "";
		public string Customer { get; set; } = "";
		public string Engineer { get; set; } = "";
		public string Specification { get; set; } = "";
		public string Test { get; set; } = "";
		public string EngInit0 { get; set; } = "";
		public string TestStartDate { get; set; } = "";
		public string TestCompDate { get; set; } = "";
		public string TechInit0 { get; set; } = "";
		public string EngInit1 { get; set; } = "";
		public string Yes { get; set; } = "";
		public string No { get; set; } = "";
		public string REEUT { get; set; } = "";
		public string REMHzToGHz { get; set; } = "";
		public string REAbove { get; set; } = "";
		public string RSEUT { get; set; } = "";
		public string RSMHzToGHz { get; set; } = "";
		public string RSAbove { get; set; } = "";


        // public List<TestData> Data { get; set; } = new List<TestData>();
        // public class TestData {}

        public string FormVersion { get; set; } = "";

        public static ElectricalInitialTestSummary Load(string json)
        {
            if (!json.IsValid()) return new ElectricalInitialTestSummary();
            return JsonConvert.DeserializeObject<ElectricalInitialTestSummary>(json);
        }

        public static ElectricalInitialTestSummary Load(TestForm t)
        {

            if (!t.Content.IsValid())
            {
                // Create using Parent LabTest
                LabTest lt = LabTest.Get(t.TestID);
                return new ElectricalInitialTestSummary(t,lt);
            }

            else
            {
                return Load(t.Content);
            }
        }

        // convert instance to json
        public static string Save(ElectricalInitialTestSummary obj)
        {
            return JsonConvert.SerializeObject(obj);
        }



        // Instance Method
        public string Save()
        {
            return ElectricalInitialTestSummary.Save(this);
        }

        public ElectricalInitialTestSummary() {}

        public ElectricalInitialTestSummary(TestForm tf, LabTest t)
        {
            // DateTime.Today.Date.ToString("MM/dd/yyyy");
            
			this.JobNo = t.JobNumber;
			this.Customer = t.Customer;
			this.Engineer = t.Engineer;
            this.FormVersion = GetReportVersion(tf);

        }
    }
}
