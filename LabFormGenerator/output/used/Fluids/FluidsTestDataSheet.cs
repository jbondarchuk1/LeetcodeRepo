
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
    public class FluidsTestDataSheet : ModelBase, ILabModel
    {
        
		public string JobNo { get; set; } = "";
		public string Date { get; set; } = "";
		public string Fluid1Desc { get; set; } = "";
		public string Fluid2Desc { get; set; } = "";
		public string FluidAppMethod { get; set; } = "";
        public List<TestData> Data { get; set; } = new List<TestData>();

        public class TestData
        {
            public string Time { get; set; } = "";
            public string ReqTemp { get; set; } = "";
            public string ActualTemp { get; set; } = "";
            public string Fluid1Applied { get; set; } = "";
            public string ReqTemp1 { get; set; } = "";
            public string ActualTemp1 { get; set; } = "";
            public string Fluid1Applied1 { get; set; } = "";
        }
		
		public string Remarks { get; set; } = "";
		public string Tech { get; set; } = "";
		public string Comments { get; set; } = "";


        public static FluidsTestDataSheet Load(string json)
        {
            if (!json.IsValid()) return new FluidsTestDataSheet();
            return JsonConvert.DeserializeObject<FluidsTestDataSheet>(json);
        }

        public static FluidsTestDataSheet Load(TestForm t)
        {

            if (!t.Content.IsValid())
            {
                // Create using Parent LabTest
                LabTest lt = LabTest.Get(t.TestID);
                return new FluidsTestDataSheet(lt);
            }

            else
            {
                return Load(t.Content);
            }
        }

        // convert instance to json
        public static string Save(FluidsTestDataSheet obj)
        {
            return JsonConvert.SerializeObject(obj);
        }



        // Instance Method
        public string Save()
        {
            return FluidsTestDataSheet.Save(this);
        }

        public FluidsTestDataSheet() {}

        public FluidsTestDataSheet(LabTest t)
        {
            // DateTime.Today.Date.ToString("MM/dd/yyyy");
            
			this.JobNo = t.JobNumber;
			this.Date = DateTime.Today.Date.ToString("MM/dd/yyyy");
        }
    }
}
