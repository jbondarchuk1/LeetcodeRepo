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
    public class HumProcedureII : ModelBase, ILabModel
    {
		public string JobNo { get; set; } = "";
		public string Test { get; set; } = "";
		public string Date { get; set; } = "";
        public List<TestData> Data { get; set; } = new List<TestData>();
        public class TestData
        {
            public string Time { get; set; } = "";
            public string TestTimeHours { get; set; } = "";
            public string ReqTemp { get; set; } = "";
            public string ActualTemp { get; set; } = "";
            public string ReqRH { get; set; } = "";
            public string ActRH { get; set; } = "";
            public string Remarks { get; set; } = "";
            public string Tech { get; set; } = "";
        }

		public string Engineer { get; set; } = "";


        public static HumProcedureII Load(string json)
        {
            if (!json.IsValid()) return new HumProcedureII();
            return JsonConvert.DeserializeObject<HumProcedureII>(json);
        }

        public static HumProcedureII Load(TestForm t)
        {

            if (!t.Content.IsValid())
            {
                // Create using Parent LabTest
                LabTest lt = LabTest.Get(t.TestID);
                return new HumProcedureII(lt);
            }

            else
            {
                return Load(t.Content);
            }
        }

        // convert instance to json
        public static string Save(HumProcedureII obj)
        {
            return JsonConvert.SerializeObject(obj);
        }



        // Instance Method
        public string Save()
        {
            return HumProcedureII.Save(this);
        }

        public HumProcedureII() {}

        public HumProcedureII(LabTest t)
        {
            // DateTime.Today.Date.ToString("MM/dd/yyyy");
            
			this.JobNo = t.JobNumber;
			this.Date = DateTime.Today.Date.ToString("MM/dd/yyyy");
			this.Engineer = t.Engineer;
        }
    }
}
