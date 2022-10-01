
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
    public class ElectricalSetupCheckList : ModelBase, ILabModel
    {
        
		public string JobNo { get; set; } = "";
		public string Engineer { get; set; } = "";
		public string Customer { get; set; } = "";
		public string CheckList0 { get; set; } = "";
		public bool Check0 { get; set; } = false;
		public string CheckList1 { get; set; } = "";
		public bool Check1 { get; set; } = false;
		public string CheckList2 { get; set; } = "";
		public bool Check2 { get; set; } = false;
		public string CheckList3 { get; set; } = "";
		public bool Check3 { get; set; } = false;
		public string EngineerInit { get; set; } = "";


        // public List<TestData> Data { get; set; } = new List<TestData>();
        // public class TestData {}

        public string FormVersion { get; set; } = "";

        public static ElectricalSetupCheckList Load(string json)
        {
            if (!json.IsValid()) return new ElectricalSetupCheckList();
            return JsonConvert.DeserializeObject<ElectricalSetupCheckList>(json);
        }

        public static ElectricalSetupCheckList Load(TestForm t)
        {

            if (!t.Content.IsValid())
            {
                // Create using Parent LabTest
                LabTest lt = LabTest.Get(t.TestID);
                return new ElectricalSetupCheckList(t,lt);
            }

            else
            {
                return Load(t.Content);
            }
        }

        // convert instance to json
        public static string Save(ElectricalSetupCheckList obj)
        {
            return JsonConvert.SerializeObject(obj);
        }



        // Instance Method
        public string Save()
        {
            return ElectricalSetupCheckList.Save(this);
        }

        public ElectricalSetupCheckList() {}

        public ElectricalSetupCheckList(TestForm tf, LabTest t)
        {
            // DateTime.Today.Date.ToString("MM/dd/yyyy");
            
			this.JobNo = t.JobNumber;
			this.Engineer = t.Engineer;
			this.Customer = t.Customer;
            this.FormVersion = GetReportVersion(tf);

        }
    }
}
