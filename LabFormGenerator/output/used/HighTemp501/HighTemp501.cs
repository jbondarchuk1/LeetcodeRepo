
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
    public class HighTemp501 : ModelBase, ILabModel
    {
        
		public string JobNo { get; set; } = "";
		public string Date { get; set; } = "";
		public string Test { get; set; } = "";
		public string CycleDesc { get; set; } = "";
		public string BasicHot { get; set; } = "";
		public string Cycle { get; set; } = "";
        public List<TestData> Data { get; set; } = new List<TestData>();
        public class TestData
        {
            public string Time { get; set; } = "";
            public string TestTimeHours { get; set; } = "";
            public string ReqChambTemp { get; set; } = "";
            public string ActualChambTemp { get; set; } = "";
            public string TestItemTemp { get; set; } = "";
            public string Remarks { get; set; } = "";
            public string Tech { get; set; } = "";
        }


		public string Engineer { get; set; } = "";


        public static HighTemp501 Load(string json)
        {
            if (!json.IsValid()) return new HighTemp501();
            return JsonConvert.DeserializeObject<HighTemp501>(json);
        }

        public static HighTemp501 Load(TestForm t)
        {

            if (!t.Content.IsValid())
            {
                // Create using Parent LabTest
                LabTest lt = LabTest.Get(t.TestID);
                return new HighTemp501(lt);
            }

            else
            {
                return Load(t.Content);
            }
        }

        // convert instance to json
        public static string Save(HighTemp501 obj)
        {
            return JsonConvert.SerializeObject(obj);
        }



        // Instance Method
        public string Save()
        {
            return HighTemp501.Save(this);
        }

        public HighTemp501() {}

        public HighTemp501(LabTest t)
        {
            // DateTime.Today.Date.ToString("MM/dd/yyyy");
            
			this.JobNo = t.JobNo;
			this.Date = t.Date;
			this.Test = t.Test;
			this.CycleDesc = t.CycleDesc;
			this.BasicHot = t.BasicHot;
			this.Cycle = t.Cycle;
			this.Time = t.Time;
			this.TestTimeHours = t.TestTimeHours;
			this.ReqChambTemp = t.ReqChambTemp;
			this.ActualChambTemp = t.ActualChambTemp;
			this.TestItemTemp = t.TestItemTemp;
			this.Remarks = t.Remarks;
			this.Tech = t.Tech;
			this.Engineer = t.Engineer;
        }
    }
}
