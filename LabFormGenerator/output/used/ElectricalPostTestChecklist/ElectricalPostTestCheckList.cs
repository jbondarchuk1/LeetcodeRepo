
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
    public class ElectricalPostTestCheckList : ModelBase, ILabModel
    {
        
		public string JobNo { get; set; } = "";
		public string Engineer { get; set; } = "";
		public string Customer { get; set; } = "";
		public string Test { get; set; } = "";
		public string DataGenerated { get; set; } = "";
		public bool DataGeneratedCheck { get; set; } = false;
		public string SummarySheetFilled { get; set; } = "";
		public bool SummarySheetFilledCheck { get; set; } = false;
		public string MetReqs { get; set; } = "";
		public bool MetReqsCheck { get; set; } = false;
		public string TimeLogsReviewed { get; set; } = "";
		public bool TimeLogsReviewedCheck { get; set; } = false;
		public string EngineerInit { get; set; } = "";


        // public List<TestData> Data { get; set; } = new List<TestData>();
        // public class TestData {}

        public string FormVersion { get; set; } = "";

        public static ElectricalPostTestCheckList Load(string json)
        {
            if (!json.IsValid()) return new ElectricalPostTestCheckList();
            return JsonConvert.DeserializeObject<ElectricalPostTestCheckList>(json);
        }

        public static ElectricalPostTestCheckList Load(TestForm t)
        {

            if (!t.Content.IsValid())
            {
                // Create using Parent LabTest
                LabTest lt = LabTest.Get(t.TestID);
                return new ElectricalPostTestCheckList(t,lt);
            }

            else
            {
                return Load(t.Content);
            }
        }

        // convert instance to json
        public static string Save(ElectricalPostTestCheckList obj)
        {
            return JsonConvert.SerializeObject(obj);
        }



        // Instance Method
        public string Save()
        {
            return ElectricalPostTestCheckList.Save(this);
        }

        public ElectricalPostTestCheckList() {}

        public ElectricalPostTestCheckList(TestForm tf, LabTest t)
        {
            // DateTime.Today.Date.ToString("MM/dd/yyyy");
            
			this.JobNo = t.JobNumber;
			this.Engineer = t.Engineer;
			this.Customer = t.Customer;
            this.FormVersion = GetReportVersion(tf);

        }
    }
}
