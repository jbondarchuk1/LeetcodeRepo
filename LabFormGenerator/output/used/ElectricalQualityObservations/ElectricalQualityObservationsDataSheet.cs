
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
    public class ElectricalQualityObservationsDataSheet : ModelBase, ILabModel
    {
        
		public string JobNo { get; set; } = "";
		public string Engineer { get; set; } = "";
		public string Customer { get; set; } = "";
		public string Test { get; set; } = "";
		public string Date { get; set; } = "";
		public string Time { get; set; } = "";
		public string Remarks { get; set; } = "";
		public string Init { get; set; } = "";


        // public List<TestData> Data { get; set; } = new List<TestData>();
        // public class TestData {}

        public string FormVersion { get; set; } = "";

        public static ElectricalQualityObservationsDataSheet Load(string json)
        {
            if (!json.IsValid()) return new ElectricalQualityObservationsDataSheet();
            return JsonConvert.DeserializeObject<ElectricalQualityObservationsDataSheet>(json);
        }

        public static ElectricalQualityObservationsDataSheet Load(TestForm t)
        {

            if (!t.Content.IsValid())
            {
                // Create using Parent LabTest
                LabTest lt = LabTest.Get(t.TestID);
                return new ElectricalQualityObservationsDataSheet(t,lt);
            }

            else
            {
                return Load(t.Content);
            }
        }

        // convert instance to json
        public static string Save(ElectricalQualityObservationsDataSheet obj)
        {
            return JsonConvert.SerializeObject(obj);
        }



        // Instance Method
        public string Save()
        {
            return ElectricalQualityObservationsDataSheet.Save(this);
        }

        public ElectricalQualityObservationsDataSheet() {}

        public ElectricalQualityObservationsDataSheet(TestForm tf, LabTest t)
        {
            // DateTime.Today.Date.ToString("MM/dd/yyyy");
            
			this.JobNo = t.JobNumber;
			this.Engineer = t.Engineer;
			this.Customer = t.Customer;
			this.Date = DateTime.Today.Date.ToString("MM/dd/yyyy");
            this.FormVersion = GetReportVersion(tf);

        }
    }
}
