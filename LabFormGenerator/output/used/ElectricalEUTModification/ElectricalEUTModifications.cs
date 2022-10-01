
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
    public class ElectricalEUTModifications : ModelBase, ILabModel
    {
        
		public string JobNo { get; set; } = "";
		public string Customer { get; set; } = "";
		public string Engineer { get; set; } = "";
		public bool Check0 { get; set; } = false;
		public bool Check1 { get; set; } = false;
		public string Test { get; set; } = "";
		public string Modifications { get; set; } = "";
		public string Date { get; set; } = "";


        // public List<TestData> Data { get; set; } = new List<TestData>();
        // public class TestData {}

        public string FormVersion { get; set; } = "";

        public static ElectricalEUTModifications Load(string json)
        {
            if (!json.IsValid()) return new ElectricalEUTModifications();
            return JsonConvert.DeserializeObject<ElectricalEUTModifications>(json);
        }

        public static ElectricalEUTModifications Load(TestForm t)
        {

            if (!t.Content.IsValid())
            {
                // Create using Parent LabTest
                LabTest lt = LabTest.Get(t.TestID);
                return new ElectricalEUTModifications(t,lt);
            }

            else
            {
                return Load(t.Content);
            }
        }

        // convert instance to json
        public static string Save(ElectricalEUTModifications obj)
        {
            return JsonConvert.SerializeObject(obj);
        }



        // Instance Method
        public string Save()
        {
            return ElectricalEUTModifications.Save(this);
        }

        public ElectricalEUTModifications() {}

        public ElectricalEUTModifications(TestForm tf, LabTest t)
        {
            // DateTime.Today.Date.ToString("MM/dd/yyyy");
            
			this.JobNo = t.JobNumber;
			this.Customer = t.Customer;
			this.Engineer = t.Engineer;
			this.Date = DateTime.Today.Date.ToString("MM/dd/yyyy");
            this.FormVersion = GetReportVersion(tf);

        }
    }
}
