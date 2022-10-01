
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
    public class ElectricalOperationalCriteria : ModelBase, ILabModel
    {
        
		public string JobNo { get; set; } = "";
		public string Engineer { get; set; } = "";
		public string Customer { get; set; } = "";
		public string Operational { get; set; } = "";
		public string SusCrit { get; set; } = "";


        // public List<TestData> Data { get; set; } = new List<TestData>();
        // public class TestData {}

        public string FormVersion { get; set; } = "";

        public static ElectricalOperationalCriteria Load(string json)
        {
            if (!json.IsValid()) return new ElectricalOperationalCriteria();
            return JsonConvert.DeserializeObject<ElectricalOperationalCriteria>(json);
        }

        public static ElectricalOperationalCriteria Load(TestForm t)
        {

            if (!t.Content.IsValid())
            {
                // Create using Parent LabTest
                LabTest lt = LabTest.Get(t.TestID);
                return new ElectricalOperationalCriteria(t,lt);
            }

            else
            {
                return Load(t.Content);
            }
        }

        // convert instance to json
        public static string Save(ElectricalOperationalCriteria obj)
        {
            return JsonConvert.SerializeObject(obj);
        }



        // Instance Method
        public string Save()
        {
            return ElectricalOperationalCriteria.Save(this);
        }

        public ElectricalOperationalCriteria() {}

        public ElectricalOperationalCriteria(TestForm tf, LabTest t)
        {
            // DateTime.Today.Date.ToString("MM/dd/yyyy");
            
			this.JobNo = t.JobNumber;
			this.Engineer = t.Engineer;
			this.Customer = t.Customer;
            this.FormVersion = GetReportVersion(tf);

        }
    }
}
