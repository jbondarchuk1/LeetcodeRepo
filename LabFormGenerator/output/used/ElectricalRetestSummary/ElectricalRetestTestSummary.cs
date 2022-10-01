
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
    public class ElectricalRetestTestSummary : ModelBase, ILabModel
    {
        
		public string JobNo { get; set; } = "";
		public string Engineer { get; set; } = "";
		public string Customer { get; set; } = "";
		public string Specification { get; set; } = "";
		public string Test { get; set; } = "";
		public string EngInit0 { get; set; } = "";
		public string TestStartDate { get; set; } = "";
		public string TestCompDate { get; set; } = "";
		public string TechInit { get; set; } = "";
		public string EngInit1 { get; set; } = "";
		public string MetSpecYes { get; set; } = "";
		public string MetSpecNo { get; set; } = "";
		public string REEUT { get; set; } = "";
		public string REMHzToGHz { get; set; } = "";
		public string REAbove { get; set; } = "";
		public string RSEUT { get; set; } = "";
		public string RSMHzToGHz { get; set; } = "";
		public string RSAbove { get; set; } = "";


        // public List<TestData> Data { get; set; } = new List<TestData>();
        // public class TestData {}

        public string FormVersion { get; set; } = "";

        public static ElectricalRetestTestSummary Load(string json)
        {
            if (!json.IsValid()) return new ElectricalRetestTestSummary();
            return JsonConvert.DeserializeObject<ElectricalRetestTestSummary>(json);
        }

        public static ElectricalRetestTestSummary Load(TestForm t)
        {

            if (!t.Content.IsValid())
            {
                // Create using Parent LabTest
                LabTest lt = LabTest.Get(t.TestID);
                return new ElectricalRetestTestSummary(t,lt);
            }

            else
            {
                return Load(t.Content);
            }
        }

        // convert instance to json
        public static string Save(ElectricalRetestTestSummary obj)
        {
            return JsonConvert.SerializeObject(obj);
        }



        // Instance Method
        public string Save()
        {
            return ElectricalRetestTestSummary.Save(this);
        }

        public ElectricalRetestTestSummary() {}

        public ElectricalRetestTestSummary(TestForm tf, LabTest t)
        {
            // DateTime.Today.Date.ToString("MM/dd/yyyy");
            
			this.JobNo = t.JobNumber;
			this.Engineer = t.Engineer;
			this.Customer = t.Customer;
            this.FormVersion = GetReportVersion(tf);

        }
    }
}
