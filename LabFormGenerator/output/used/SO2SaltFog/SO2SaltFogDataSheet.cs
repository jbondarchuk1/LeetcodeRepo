
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
    public class SO2SaltFogDataSheet : ModelBase, ILabModel
    {
        
		public string JobNo { get; set; } = "";
		public string Date { get; set; } = "";
		public string Time { get; set; } = "";
		public string HoursIntoCycle { get; set; } = "";
		public string ChamberAmbientTemp { get; set; } = "";
		public string AirPressurePSI { get; set; } = "";
		public string WaterTowerTemp { get; set; } = "";
		public string WaterTowerLevel { get; set; } = "";
		public string SaltResevoirLevel { get; set; } = "";
		public string Tech { get; set; } = "";
		public string Comments { get; set; } = "";
		public string Engineer { get; set; } = "";

        // public List<TestData> Data { get; set; } = new List<TestData>();
        // public class TestData {}


        public static SO2SaltFogDataSheet Load(string json)
        {
            if (!json.IsValid()) return new SO2SaltFogDataSheet();
            return JsonConvert.DeserializeObject<SO2SaltFogDataSheet>(json);
        }

        public static SO2SaltFogDataSheet Load(TestForm t)
        {

            if (!t.Content.IsValid())
            {
                // Create using Parent LabTest
                LabTest lt = LabTest.Get(t.TestID);
                return new SO2SaltFogDataSheet(lt);
            }

            else
            {
                return Load(t.Content);
            }
        }

        // convert instance to json
        public static string Save(SO2SaltFogDataSheet obj)
        {
            return JsonConvert.SerializeObject(obj);
        }



        // Instance Method
        public string Save()
        {
            return SO2SaltFogDataSheet.Save(this);
        }

        public SO2SaltFogDataSheet() {}

        public SO2SaltFogDataSheet(LabTest t)
        {
            // DateTime.Today.Date.ToString("MM/dd/yyyy");
            
			this.JobNo = t.JobNumber;
			this.Date = DateTime.Today.Date.ToString("MM/dd/yyyy");
			this.Engineer = t.Engineer;
        }
    }
}
