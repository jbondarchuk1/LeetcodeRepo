
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
    public class ElectricalChangeOrder : ModelBase, ILabModel
    {
        
		public string JobNo { get; set; } = "";
		public string Customer { get; set; } = "";
		public string Engineer { get; set; } = "";
		public string Date { get; set; } = "";
		public string Test { get; set; } = "";
		public string SubNo { get; set; } = "";
		public string Duration { get; set; } = "";
		public string DescriptionOfCharge { get; set; } = "";


        // public List<TestData> Data { get; set; } = new List<TestData>();
        // public class TestData {}

        public string FormVersion { get; set; } = "";

        public static ElectricalChangeOrder Load(string json)
        {
            if (!json.IsValid()) return new ElectricalChangeOrder();
            return JsonConvert.DeserializeObject<ElectricalChangeOrder>(json);
        }

        public static ElectricalChangeOrder Load(TestForm t)
        {

            if (!t.Content.IsValid())
            {
                // Create using Parent LabTest
                LabTest lt = LabTest.Get(t.TestID);
                return new ElectricalChangeOrder(t,lt);
            }

            else
            {
                return Load(t.Content);
            }
        }

        // convert instance to json
        public static string Save(ElectricalChangeOrder obj)
        {
            return JsonConvert.SerializeObject(obj);
        }



        // Instance Method
        public string Save()
        {
            return ElectricalChangeOrder.Save(this);
        }

        public ElectricalChangeOrder() {}

        public ElectricalChangeOrder(TestForm tf, LabTest t)
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
