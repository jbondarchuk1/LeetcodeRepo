
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
    public class SandDataSheet : ModelBase, ILabModel
    {
        
		public string JobNo { get; set; } = "";
		public string Date { get; set; } = "";
		public string ReqTemp { get; set; } = "";
		public string ReqHum { get; set; } = "";
		public string ReqAirVel { get; set; } = "";
		public string ActAirVel { get; set; } = "";
		public string ReqSandDensity { get; set; } = "";
		public string ActSandDensity { get; set; } = "";
		public string Time { get; set; } = "";
		public string TestTime { get; set; } = "";
		public string ChamberTemp { get; set; } = "";
		public string UnitTemp { get; set; } = "";
		public string ChamberHumidity { get; set; } = "";
		public string SideTested { get; set; } = "";
		public string Remarks { get; set; } = "";
		public string Tech { get; set; } = "";
		public string Engineer { get; set; } = "";

        // public List<TestData> Data { get; set; } = new List<TestData>();
        // public class TestData {}


        public static SandDataSheet Load(string json)
        {
            if (!json.IsValid()) return new SandDataSheet();
            return JsonConvert.DeserializeObject<SandDataSheet>(json);
        }

        public static SandDataSheet Load(TestForm t)
        {

            if (!t.Content.IsValid())
            {
                // Create using Parent LabTest
                LabTest lt = LabTest.Get(t.TestID);
                return new SandDataSheet(lt);
            }

            else
            {
                return Load(t.Content);
            }
        }

        // convert instance to json
        public static string Save(SandDataSheet obj)
        {
            return JsonConvert.SerializeObject(obj);
        }



        // Instance Method
        public string Save()
        {
            return SandDataSheet.Save(this);
        }

        public SandDataSheet() {}

        public SandDataSheet(LabTest t)
        {
            // DateTime.Today.Date.ToString("MM/dd/yyyy");
            
			this.JobNo = t.JobNumber;
			this.Date = DateTime.Today.Date.ToString("MM/dd/yyyy");
			this.Engineer = t.Engineer;
        }
    }
}
