
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
    public class BlowingDustDO160EFG : ModelBase, ILabModel
    {
        
		public string JobNo { get; set; } = "";
		public string Date { get; set; } = "";
		public string ReqNumSides { get; set; } = "";
		public string ReqDurPerSide { get; set; } = "";

		public string Remarks { get; set; } = "";
		public string Engineer { get; set; } = "";

        public List<TestData> Data { get; set; } = new List<TestData>();
        public class TestData 
        {
            public string Time { get; set; } = "";
            public string HoursIntoTest { get; set; } = "";
            public string AirTempReq { get; set; } = "";
            public string AirTempAct { get; set; } = "";
            public string RelativeHumidityReq { get; set; } = "";
            public string RelativeHumidityAct { get; set; } = "";
            public string AirFlowVelocityReq { get; set; } = "";
            public string AirFlowVelocityAct { get; set; } = "";
            public string Remarks { get; set; } = "";
            public string Tech { get; set; } = "";
        }


        public static BlowingDustDO160EFG Load(string json)
        {
            if (!json.IsValid()) return new BlowingDustDO160EFG();
            return JsonConvert.DeserializeObject<BlowingDustDO160EFG>(json);
        }

        public static BlowingDustDO160EFG Load(TestForm t)
        {

            if (!t.Content.IsValid())
            {
                // Create using Parent LabTest
                LabTest lt = LabTest.Get(t.TestID);
                return new BlowingDustDO160EFG(lt);
            }

            else
            {
                return Load(t.Content);
            }
        }

        // convert instance to json
        public static string Save(BlowingDustDO160EFG obj)
        {
            return JsonConvert.SerializeObject(obj);
        }



        // Instance Method
        public string Save()
        {
            return BlowingDustDO160EFG.Save(this);
        }

        public BlowingDustDO160EFG() {}

        public BlowingDustDO160EFG(LabTest t)
        {
            // DateTime.Today.Date.ToString("MM/dd/yyyy");
            
			this.JobNo = t.JobNumber;
			this.Date = t.DateTime.Today.Date.ToString("MM/dd/yyyy");
			this.Engineer = t.Engineer;
        }
    }
}
