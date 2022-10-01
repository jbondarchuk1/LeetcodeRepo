
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
    public class ElectricalCustomerInstructions : ModelBase, ILabModel
    {
        
		public string JobNo { get; set; } = "";
		public string Customer { get; set; } = "";
		public string Engineer { get; set; } = "";
		public string Name0 { get; set; } = "";
		public string Email0 { get; set; } = "";
		public string Name1 { get; set; } = "";
		public string Email1 { get; set; } = "";
		public string Name2 { get; set; } = "";
		public string Email2 { get; set; } = "";


        // public List<TestData> Data { get; set; } = new List<TestData>();
        // public class TestData {}

        public string FormVersion { get; set; } = "";

        public static ElectricalCustomerInstructions Load(string json)
        {
            if (!json.IsValid()) return new ElectricalCustomerInstructions();
            return JsonConvert.DeserializeObject<ElectricalCustomerInstructions>(json);
        }

        public static ElectricalCustomerInstructions Load(TestForm t)
        {

            if (!t.Content.IsValid())
            {
                // Create using Parent LabTest
                LabTest lt = LabTest.Get(t.TestID);
                return new ElectricalCustomerInstructions(t,lt);
            }

            else
            {
                return Load(t.Content);
            }
        }

        // convert instance to json
        public static string Save(ElectricalCustomerInstructions obj)
        {
            return JsonConvert.SerializeObject(obj);
        }



        // Instance Method
        public string Save()
        {
            return ElectricalCustomerInstructions.Save(this);
        }

        public ElectricalCustomerInstructions() {}

        public ElectricalCustomerInstructions(TestForm tf, LabTest t)
        {
            // DateTime.Today.Date.ToString("MM/dd/yyyy");
            
			this.JobNo = t.JobNumber;
			this.Customer = t.Customer;
			this.Engineer = t.Engineer;
            this.FormVersion = GetReportVersion(tf);

        }
    }
}
