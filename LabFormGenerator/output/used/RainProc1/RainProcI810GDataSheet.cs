
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
    public class RainProcI810GDataSheet : ModelBase, ILabModel
    {
        
		public string JobNo { get; set; } = "";
		public string Date { get; set; } = "";
		public string ReqRainRate { get; set; } = "";
		public string DistFromNozzle { get; set; } = "";
		public string LocationNo { get; set; } = "";
		public string LocationDescription { get; set; } = "";
		public string MeasuredRainRate { get; set; } = "";
		public string Remarks { get; set; } = "";
		public string TECH { get; set; } = "";
		public string AvgRainRate5Loc { get; set; } = "";
		public string Engineer { get; set; } = "";

        // public List<TestData> Data { get; set; } = new List<TestData>();
        // public class TestData {}


        public static RainProcI810GDataSheet Load(string json)
        {
            if (!json.IsValid()) return new RainProcI810GDataSheet();
            return JsonConvert.DeserializeObject<RainProcI810GDataSheet>(json);
        }

        public static RainProcI810GDataSheet Load(TestForm t)
        {

            if (!t.Content.IsValid())
            {
                // Create using Parent LabTest
                LabTest lt = LabTest.Get(t.TestID);
                return new RainProcI810GDataSheet(lt);
            }

            else
            {
                return Load(t.Content);
            }
        }

        // convert instance to json
        public static string Save(RainProcI810GDataSheet obj)
        {
            return JsonConvert.SerializeObject(obj);
        }



        // Instance Method
        public string Save()
        {
            return RainProcI810GDataSheet.Save(this);
        }

        public RainProcI810GDataSheet() {}

        public RainProcI810GDataSheet(LabTest t)
        {
            // DateTime.Today.Date.ToString("MM/dd/yyyy");
            
			this.JobNo = t.JobNumber;
			this.Date = t.DateTime.Today.Date.ToString("MM/dd/yyyy");
			this.Engineer = t.Engineer;
        }
    }
}
