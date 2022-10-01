
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
    public class SaltFog2HRPreconditioningDataSheet : ModelBase, ILabModel
    {
        
		public string JobNo { get; set; } = "";
		public string Date { get; set; } = "";
		public string Time { get; set; } = "";
		public string ChamberAmbientTemp { get; set; } = "";
		public string HoursIntoSoak { get; set; } = "";
		public string Remarks { get; set; } = "";
		public string Tech { get; set; } = "";
		public string Engineer { get; set; } = "";

        // public List<TestData> Data { get; set; } = new List<TestData>();
        // public class TestData {}


        public static SaltFog2HRPreconditioningDataSheet Load(string json)
        {
            if (!json.IsValid()) return new SaltFog2HRPreconditioningDataSheet();
            return JsonConvert.DeserializeObject<SaltFog2HRPreconditioningDataSheet>(json);
        }

        public static SaltFog2HRPreconditioningDataSheet Load(TestForm t)
        {

            if (!t.Content.IsValid())
            {
                // Create using Parent LabTest
                LabTest lt = LabTest.Get(t.TestID);
                return new SaltFog2HRPreconditioningDataSheet(lt);
            }

            else
            {
                return Load(t.Content);
            }
        }

        // convert instance to json
        public static string Save(SaltFog2HRPreconditioningDataSheet obj)
        {
            return JsonConvert.SerializeObject(obj);
        }



        // Instance Method
        public string Save()
        {
            return SaltFog2HRPreconditioningDataSheet.Save(this);
        }

        public SaltFog2HRPreconditioningDataSheet() {}

        public SaltFog2HRPreconditioningDataSheet(LabTest t)
        {
            // DateTime.Today.Date.ToString("MM/dd/yyyy");
            
			this.JobNo = t.JobNumber;
			this.Date = DateTime.Today.Date.ToString("MM/dd/yyyy");
			this.Engineer = t.Engineer;
        }
    }
}
