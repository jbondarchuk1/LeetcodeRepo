
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
    public class Hum48Cyc : ModelBase, ILabModel
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


        public static Hum48Cyc Load(string json)
        {
            if (!json.IsValid()) return new Hum48Cyc();
            return JsonConvert.DeserializeObject<Hum48Cyc>(json);
        }

        public static Hum48Cyc Load(TestForm t)
        {

            if (!t.Content.IsValid())
            {
                // Create using Parent LabTest
                LabTest lt = LabTest.Get(t.TestID);
                return new Hum48Cyc(lt);
            }

            else
            {
                return Load(t.Content);
            }
        }

        // convert instance to json
        public static string Save(Hum48Cyc obj)
        {
            return JsonConvert.SerializeObject(obj);
        }



        // Instance Method
        public string Save()
        {
            return Hum48Cyc.Save(this);
        }

        public Hum48Cyc() {}

        public Hum48Cyc(LabTest t)
        {
            // DateTime.Today.Date.ToString("MM/dd/yyyy");
            
			this.JobNo = t.JobNo;
			this.Test = t.Test;
			this.Date = t.Date;
			this.Time = t.Time;
			this.TestTimeHours = t.TestTimeHours;
			this.ReqTemp = t.ReqTemp;
			this.ActualTemp = t.ActualTemp;
			this.ReqRH = t.ReqRH;
			this.ActRH = t.ActRH;
			this.Remarks = t.Remarks;
			this.Tech = t.Tech;
			this.Engineer = t.Engineer;
        }
    }
}
