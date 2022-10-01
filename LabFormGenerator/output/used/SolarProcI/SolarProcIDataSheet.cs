
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
    public class SolarProcIDataSheet : ModelBase, ILabModel
    {
        
		public string JobNo { get; set; } = "";
		public string Test { get; set; } = "";
		public string Date { get; set; } = "";
		public string Time { get; set; } = "";
		public string TestTimeHrs { get; set; } = "";
		public string ReqTemp { get; set; } = "";
		public string ChamTemp { get; set; } = "";
		public string UnitTemp { get; set; } = "";
		public string Req { get; set; } = "";
		public string SolarLevelCheck { get; set; } = "";
		public string Remarks { get; set; } = "";
		public string Tech { get; set; } = "";
		public string Cycle { get; set; } = "";
		public string Technician { get; set; } = "";
		public string Engineer { get; set; } = "";

        // public List<TestData> Data { get; set; } = new List<TestData>();
        // public class TestData {}


        public static SolarProcIDataSheet Load(string json)
        {
            if (!json.IsValid()) return new SolarProcIDataSheet();
            return JsonConvert.DeserializeObject<SolarProcIDataSheet>(json);
        }

        public static SolarProcIDataSheet Load(TestForm t)
        {

            if (!t.Content.IsValid())
            {
                // Create using Parent LabTest
                LabTest lt = LabTest.Get(t.TestID);
                return new SolarProcIDataSheet(lt);
            }

            else
            {
                return Load(t.Content);
            }
        }

        // convert instance to json
        public static string Save(SolarProcIDataSheet obj)
        {
            return JsonConvert.SerializeObject(obj);
        }



        // Instance Method
        public string Save()
        {
            return SolarProcIDataSheet.Save(this);
        }

        public SolarProcIDataSheet() {}

        public SolarProcIDataSheet(LabTest t)
        {
            // DateTime.Today.Date.ToString("MM/dd/yyyy");
            
			this.JobNo = t.JobNumber;
			this.Date = DateTime.Today.Date.ToString("MM/dd/yyyy");
			this.Engineer = t.Engineer;
        }
    }
}
