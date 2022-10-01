
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
    public class SaltFog24HRDry50PercentDataSheet : ModelBase, ILabModel
    {
        
		public string JobNo { get; set; } = "";
		public string Date { get; set; } = "";
		public string Time { get; set; } = "";
		public string HoursIntoTest { get; set; } = "";
		public string ReqTemp { get; set; } = "";
		public string ActualTemp { get; set; } = "";
		public string ReqRH { get; set; } = "";
		public string ActualRH { get; set; } = "";
		public string Remarks { get; set; } = "";
		public string Tech { get; set; } = "";
		public string Engineer { get; set; } = "";

        // public List<TestData> Data { get; set; } = new List<TestData>();
        // public class TestData {}


        public static SaltFog24HRDry50PercentDataSheet Load(string json)
        {
            if (!json.IsValid()) return new SaltFog24HRDry50PercentDataSheet();
            return JsonConvert.DeserializeObject<SaltFog24HRDry50PercentDataSheet>(json);
        }

        public static SaltFog24HRDry50PercentDataSheet Load(TestForm t)
        {

            if (!t.Content.IsValid())
            {
                // Create using Parent LabTest
                LabTest lt = LabTest.Get(t.TestID);
                return new SaltFog24HRDry50PercentDataSheet(lt);
            }

            else
            {
                return Load(t.Content);
            }
        }

        // convert instance to json
        public static string Save(SaltFog24HRDry50PercentDataSheet obj)
        {
            return JsonConvert.SerializeObject(obj);
        }



        // Instance Method
        public string Save()
        {
            return SaltFog24HRDry50PercentDataSheet.Save(this);
        }

        public SaltFog24HRDry50PercentDataSheet() {}

        public SaltFog24HRDry50PercentDataSheet(LabTest t)
        {
            // DateTime.Today.Date.ToString("MM/dd/yyyy");
            
			this.JobNo = t.JobNumber;
			this.Date = DateTime.Today.Date.ToString("MM/dd/yyyy");
			this.Engineer = t.Engineer;
        }
    }
}
