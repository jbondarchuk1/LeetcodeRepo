
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
    public class BlowingRainInsideTestDataSheet : ModelBase, ILabModel
    {
        
		public string InchesPerHour { get; set; } = "";
		public string Pressure { get; set; } = "";
		public string VelocityMph { get; set; } = "";
		public string VelocityFtMin { get; set; } = "";
		public string Distance { get; set; } = "";
		public string Detail0 { get; set; } = "";
		public string Detail1 { get; set; } = "";
		public string Detail2 { get; set; } = "";
		public string Detail3 { get; set; } = "";
		public string Detail4 { get; set; } = "";
		public string Detail5 { get; set; } = "";
		public string Detail6 { get; set; } = "";
		public string Detail7 { get; set; } = "";
		public string JobNo { get; set; } = "";
		public string Date { get; set; } = "";
		public string Time { get; set; } = "";
		public string Duration { get; set; } = "";
		public string WaterPressure { get; set; } = "";
		public string SideTested { get; set; } = "";
		public string UnitOp { get; set; } = "";
		public string Remarks { get; set; } = "";
		public string Tech { get; set; } = "";
		public string Note { get; set; } = "";
		public string Engineer { get; set; } = "";
		public string JobNo1 { get; set; } = "";
		public string Date1 { get; set; } = "";
		public string SideToBeTested { get; set; } = "";
		public string TestItemTemp { get; set; } = "";
		public string Remarks { get; set; } = "";
		public string Tech { get; set; } = "";
		public string Engineer1 { get; set; } = "";


        public static BlowingRainInsideTestDataSheet Load(string json)
        {
            if (!json.IsValid()) return new BlowingRainInsideTestDataSheet();
            return JsonConvert.DeserializeObject<BlowingRainInsideTestDataSheet>(json);
        }

        public static BlowingRainInsideTestDataSheet Load(TestForm t)
        {

            if (!t.Content.IsValid())
            {
                // Create using Parent LabTest
                LabTest lt = LabTest.Get(t.TestID);
                return new BlowingRainInsideTestDataSheet(lt);
            }

            else
            {
                return Load(t.Content);
            }
        }

        // convert instance to json
        public static string Save(BlowingRainInsideTestDataSheet obj)
        {
            return JsonConvert.SerializeObject(obj);
        }



        // Instance Method
        public string Save()
        {
            return BlowingRainInsideTestDataSheet.Save(this);
        }

        public BlowingRainInsideTestDataSheet() {}

        public BlowingRainInsideTestDataSheet(LabTest t)
        {
            
			this.InchesPerHour = t.InchesPerHour;
			this.Pressure = t.Pressure;
			this.VelocityMph = t.VelocityMph;
			this.VelocityFtMin = t.VelocityFtMin;
			this.Distance = t.Distance;
			this.Detail0 = t.Detail0;
			this.Detail1 = t.Detail1;
			this.Detail2 = t.Detail2;
			this.Detail3 = t.Detail3;
			this.Detail4 = t.Detail4;
			this.Detail5 = t.Detail5;
			this.Detail6 = t.Detail6;
			this.Detail7 = t.Detail7;
			this.JobNo = t.JobNo;
			this.Date = t.Date;
			this.Time = t.Time;
			this.Duration = t.Duration;
			this.WaterPressure = t.WaterPressure;
			this.SideTested = t.SideTested;
			this.UnitOp = t.UnitOp;
			this.Remarks = t.Remarks;
			this.Tech = t.Tech;
			this.Note = t.Note;
			this.Engineer = t.Engineer;
			this.JobNo1 = t.JobNo1;
			this.Date1 = t.Date1;
			this.SideToBeTested = t.SideToBeTested;
			this.TestItemTemp = t.TestItemTemp;
			this.Remarks = t.Remarks;
			this.Tech = t.Tech;
			this.Engineer1 = t.Engineer1;
        }
    }
}
