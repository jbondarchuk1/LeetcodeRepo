
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
    public class SolarProcIIDataSheet : ModelBase, ILabModel
    {
        
		public string JobNo { get; set; } = "";
		public string Test { get; set; } = "";
		public string Date { get; set; } = "";
		public string UnitResTemp { get; set; } = "";
		public string Time { get; set; } = "";
		public string TestTimeHrs { get; set; } = "";
		public string ReqTemp { get; set; } = "";
		public string ChamTemp { get; set; } = "";
		public string UnitTemp { get; set; } = "";
		public string SolarLightsOnOff { get; set; } = "";
		public string SolarLightsCheck { get; set; } = "";
		public string Remarks { get; set; } = "";
		public string Tech { get; set; } = "";
		public string Cycle { get; set; } = "";
		public string Engineer { get; set; } = "";

        // public List<TestData> Data { get; set; } = new List<TestData>();
        // public class TestData {}


        public static SolarProcIIDataSheet Load(string json)
        {
            if (!json.IsValid()) return new SolarProcIIDataSheet();
            return JsonConvert.DeserializeObject<SolarProcIIDataSheet>(json);
        }

        public static SolarProcIIDataSheet Load(TestForm t)
        {

            if (!t.Content.IsValid())
            {
                // Create using Parent LabTest
                LabTest lt = LabTest.Get(t.TestID);
                return new SolarProcIIDataSheet(lt);
            }

            else
            {
                return Load(t.Content);
            }
        }

        // convert instance to json
        public static string Save(SolarProcIIDataSheet obj)
        {
            return JsonConvert.SerializeObject(obj);
        }



        // Instance Method
        public string Save()
        {
            return SolarProcIIDataSheet.Save(this);
        }

        public SolarProcIIDataSheet() {}

        public SolarProcIIDataSheet(LabTest t)
        {
            // DateTime.Today.Date.ToString("MM/dd/yyyy");
            
			this.JobNo = t.JobNumber;
			this.Date = DateTime.Today.Date.ToString("MM/dd/yyyy");
			this.Engineer = t.Engineer;
        }
    }
}
