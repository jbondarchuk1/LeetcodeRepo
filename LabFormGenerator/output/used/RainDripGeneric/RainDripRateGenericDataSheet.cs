
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
    public class RainDripRateGenericDataSheet : ModelBase, ILabModel
    {
        
		public string JobNo { get; set; } = "";
		public string Date { get; set; } = "";
		public string ReqRainfallDrip { get; set; } = "";
		public string RainDripRateTol { get; set; } = "";
		public string DistFromDripPan { get; set; } = "";
		public string LocationNo { get; set; } = "";
		public string LocationDesc { get; set; } = "";
		public string MeasuredRainDripRate { get; set; } = "";
		public string Remarks { get; set; } = "";
		public string TECH { get; set; } = "";
		public string AvgRainRate5Loc { get; set; } = "";
		public string Engineer { get; set; } = "";

        // public List<TestData> Data { get; set; } = new List<TestData>();
        // public class TestData {}


        public static RainDripRateGenericDataSheet Load(string json)
        {
            if (!json.IsValid()) return new RainDripRateGenericDataSheet();
            return JsonConvert.DeserializeObject<RainDripRateGenericDataSheet>(json);
        }

        public static RainDripRateGenericDataSheet Load(TestForm t)
        {

            if (!t.Content.IsValid())
            {
                // Create using Parent LabTest
                LabTest lt = LabTest.Get(t.TestID);
                return new RainDripRateGenericDataSheet(lt);
            }

            else
            {
                return Load(t.Content);
            }
        }

        // convert instance to json
        public static string Save(RainDripRateGenericDataSheet obj)
        {
            return JsonConvert.SerializeObject(obj);
        }



        // Instance Method
        public string Save()
        {
            return RainDripRateGenericDataSheet.Save(this);
        }

        public RainDripRateGenericDataSheet() {}

        public RainDripRateGenericDataSheet(LabTest t)
        {
            // DateTime.Today.Date.ToString("MM/dd/yyyy");
            
			this.JobNo = t.JobNumber;
			this.Date = DateTime.Today.Date.ToString("MM/dd/yyyy");
			this.Engineer = t.Engineer;
        }
    }
}
