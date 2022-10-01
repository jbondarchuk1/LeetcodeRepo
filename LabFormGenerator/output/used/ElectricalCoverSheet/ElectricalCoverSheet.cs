
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
    public class ElectricalCoverSheet : ModelBase, ILabModel
    {
        
		public string Customer { get; set; } = "";
		public string JobNo { get; set; } = "";
		public string Engineer { get; set; } = "";
		public string Specification { get; set; } = "";
		public string CemeraNo { get; set; } = "";
		public string NOFORN { get; set; } = "";
		public string Test { get; set; } = "";


        // public List<TestData> Data { get; set; } = new List<TestData>();
        // public class TestData {}

        public string FormVersion { get; set; } = "";

        public static ElectricalCoverSheet Load(string json)
        {
            if (!json.IsValid()) return new ElectricalCoverSheet();
            return JsonConvert.DeserializeObject<ElectricalCoverSheet>(json);
        }

        public static ElectricalCoverSheet Load(TestForm t)
        {

            if (!t.Content.IsValid())
            {
                // Create using Parent LabTest
                LabTest lt = LabTest.Get(t.TestID);
                return new ElectricalCoverSheet(t,lt);
            }

            else
            {
                return Load(t.Content);
            }
        }

        // convert instance to json
        public static string Save(ElectricalCoverSheet obj)
        {
            return JsonConvert.SerializeObject(obj);
        }



        // Instance Method
        public string Save()
        {
            return ElectricalCoverSheet.Save(this);
        }

        public ElectricalCoverSheet() {}

        public ElectricalCoverSheet(TestForm tf, LabTest t)
        {
            // DateTime.Today.Date.ToString("MM/dd/yyyy");
            
			this.Customer = t.Customer;
			this.JobNo = t.JobNumber;
			this.Engineer = t.Engineer;
            this.FormVersion = GetReportVersion(tf);

        }
    }
}
