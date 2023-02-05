
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
    public class SaltFogSpray : ModelBase, ILabModel
    {
        
		public string JobNo { get; set; } = "";
		public string Date { get; set; } = "";
		public string Time { get; set; } = "";
		public string HoursIntoTest { get; set; } = "";
		public string ChamberAmbientF { get; set; } = "";
		public string AirPressPsi { get; set; } = "";
		public string TempF { get; set; } = "";
		public string Level { get; set; } = "";
		public string SaltResevoirLevel { get; set; } = "";
		public string Tech { get; set; } = "";
		public string Comments { get; set; } = "";
		public string Engineer { get; set; } = "";


        // public List<TestData> Data { get; set; } = new List<TestData>();
        // public class TestData {}

        public string FormVersion { get; set; } = "";

        public static SaltFogSpray Load(string json)
        {
            if (!json.IsValid()) return new SaltFogSpray();
            return JsonConvert.DeserializeObject<SaltFogSpray>(json);
        }

        public static SaltFogSpray Load(TestForm t)
        {

            if (!t.Content.IsValid())
            {
                // Create using Parent LabTest
                LabTest lt = LabTest.Get(t.TestID);
                return new SaltFogSpray(t,lt);
            }

            else
            {
                return Load(t.Content);
            }
        }

        // convert instance to json
        public static string Save(SaltFogSpray obj)
        {
            return JsonConvert.SerializeObject(obj);
        }



        // Instance Method
        public string Save()
        {
            return SaltFogSpray.Save(this);
        }

        public SaltFogSpray() {}

        public SaltFogSpray(TestForm tf, LabTest t)
        {
            // DateTime.Today.Date.ToString("MM/dd/yyyy");
            
			this.JobNo = t.JobNumber;
			this.Date = DateTime.Today.Date.ToString("MM/dd/yyyy");
			this.Engineer = t.Engineer;
            this.FormVersion = GetReportVersion(tf);

        }
    }
}
