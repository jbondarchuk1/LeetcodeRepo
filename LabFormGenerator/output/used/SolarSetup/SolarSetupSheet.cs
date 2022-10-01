
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
    public class SolarSetupSheet : ModelBase, ILabModel
    {
        
		public string Customer { get; set; } = "";
		public string JobNo { get; set; } = "";
		public string Date { get; set; } = "";
		public string DistanceFromLight { get; set; } = "";
		public string AirVelOverArea { get; set; } = "";
		public string PyranometerNo { get; set; } = "";
		public string LampNo0 { get; set; } = "";
		public string LampNo1 { get; set; } = "";
		public string LampNo2 { get; set; } = "";
		public string LampNo3 { get; set; } = "";
		public string LampNo4 { get; set; } = "";
		public string ReqSolarLvl { get; set; } = "";
		public string ControllerOutput0 { get; set; } = "";
		public string MeasuredSolarLevel0 { get; set; } = "";
		public string ControllerOutput1 { get; set; } = "";
		public string MeasuredSolarLevel1 { get; set; } = "";
		public string ControllerOutput2 { get; set; } = "";
		public string MeasuredSolarLevel2 { get; set; } = "";
		public string ControllerOutput3 { get; set; } = "";
		public string MeasuredSolarLevel3 { get; set; } = "";
		public string ControllerOutput4 { get; set; } = "";
		public string MeasuredSolarLevel4 { get; set; } = "";
		public string VerPerformed { get; set; } = "";
		public string Technician { get; set; } = "";
		public string Engineer { get; set; } = "";

        // public List<TestData> Data { get; set; } = new List<TestData>();
        // public class TestData {}


        public static SolarSetupSheet Load(string json)
        {
            if (!json.IsValid()) return new SolarSetupSheet();
            return JsonConvert.DeserializeObject<SolarSetupSheet>(json);
        }

        public static SolarSetupSheet Load(TestForm t)
        {

            if (!t.Content.IsValid())
            {
                // Create using Parent LabTest
                LabTest lt = LabTest.Get(t.TestID);
                return new SolarSetupSheet(lt);
            }

            else
            {
                return Load(t.Content);
            }
        }

        // convert instance to json
        public static string Save(SolarSetupSheet obj)
        {
            return JsonConvert.SerializeObject(obj);
        }



        // Instance Method
        public string Save()
        {
            return SolarSetupSheet.Save(this);
        }

        public SolarSetupSheet() {}

        public SolarSetupSheet(LabTest t)
        {
            // DateTime.Today.Date.ToString("MM/dd/yyyy");
            
			this.Customer = t.Customer;
			this.JobNo = t.JobNumber;
			this.Date = DateTime.Today.Date.ToString("MM/dd/yyyy");
			this.Engineer = t.Engineer;
        }
    }
}
