
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
    public class BlowingDust810GHDataSheet : ModelBase, ILabModel
    {
		public string JobNo { get; set; } = "";
		public string Date { get; set; } = "";
		public string ReqNumSide { get; set; } = "";
		public string ReqDurPerSide { get; set; } = "";
		public string PretestTestItemTemp { get; set; } = "";
		public string DegreesF { get; set; } = "";
		public string Time { get; set; } = "";
		public string HoursIntoTest { get; set; } = "";
		public string AirTempReq { get; set; } = "";
		public string AirTempAct { get; set; } = "";
		public string RelativeHumidityReq { get; set; } = "";
		public string RelativeHumidityAct { get; set; } = "";
		public string AirFlowVelReq { get; set; } = "";
		public string AirFlowVelAct { get; set; } = "";
		public string DustDensityReq { get; set; } = "";
		public string DustDensityAct { get; set; } = "";
		public string Remarks { get; set; } = "";
		public string Tech { get; set; } = "";
		public string title1 { get; set; } = "";
		public string JobNo1 { get; set; } = "";
		public string Date1 { get; set; } = "";
		public string Engineer1 { get; set; } = "";
		public string Remarks1 { get; set; } = "";


        public static BlowingDust810GHDataSheet Load(string json)
        {
            if (!json.IsValid()) return new BlowingDust810GHDataSheet();
            return JsonConvert.DeserializeObject<BlowingDust810GHDataSheet>(json);
        }

        public static BlowingDust810GHDataSheet Load(TestForm t)
        {

            if (!t.Content.IsValid())
            {
                // Create using Parent LabTest
                LabTest lt = LabTest.Get(t.TestID);
                return new BlowingDust810GHDataSheet(lt);
            }

            else
            {
                return Load(t.Content);
            }
        }

        // convert instance to json
        public static string Save(BlowingDust810GHDataSheet obj)
        {
            return JsonConvert.SerializeObject(obj);
        }



        // Instance Method
        public string Save()
        {
            return BlowingDust810GHDataSheet.Save(this);
        }

        public BlowingDust810GHDataSheet() {}

        public BlowingDust810GHDataSheet(LabTest t)
        {
            // DateTime.Today.Date.ToString("MM/dd/yyyy");
            
			this.JobNo = t.JobNo;
			this.Date = t.Date;
			this.ReqNumSide = t.ReqNumSide;
			this.ReqDurPerSide = t.ReqDurPerSide;
			this.PretestTestItemTemp = t.PretestTestItemTemp;
			this.DegreesF = t.DegreesF;
			this.Time = t.Time;
			this.HoursIntoTest = t.HoursIntoTest;
			this.AirTempReq = t.AirTempReq;
			this.AirTempAct = t.AirTempAct;
			this.RelativeHumidityReq = t.RelativeHumidityReq;
			this.RelativeHumidityAct = t.RelativeHumidityAct;
			this.AirFlowVelReq = t.AirFlowVelReq;
			this.AirFlowVelAct = t.AirFlowVelAct;
			this.DustDensityReq = t.DustDensityReq;
			this.DustDensityAct = t.DustDensityAct;
			this.Remarks = t.Remarks;
			this.Tech = t.Tech;
			this.title1 = t.title1;
			this.JobNo1 = t.JobNo1;
			this.Date1 = t.Date1;
			this.Engineer1 = t.Engineer1;
			this.Remarks1 = t.Remarks1;
        }
    }
}
