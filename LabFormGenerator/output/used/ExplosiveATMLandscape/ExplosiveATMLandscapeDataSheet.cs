
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
    public class ExplosiveATMLandscapeDataSheet : ModelBase, ILabModel
    {
        
		public string JobNo { get; set; } = "";
		public string Date { get; set; } = "";
		public string Test { get; set; } = "";
		public string Time { get; set; } = "";
		public string FuelQty { get; set; } = "";
		public string ChamberAltitude { get; set; } = "";
		public string TC1ChamberAmbientTemp { get; set; } = "";
		public string TC2EastWallTemp { get; set; } = "";
		public string TC3WestWallTemp { get; set; } = "";
		public string TC4UnitTemp { get; set; } = "";
		public string TC5PlenumTemp { get; set; } = "";
		public string Remarks { get; set; } = "";
		public string Tech { get; set; } = "";
		public string Remarks { get; set; } = "";
		public string Engineer { get; set; } = "";


        public static ExplosiveATMLandscapeDataSheet Load(string json)
        {
            if (!json.IsValid()) return new ExplosiveATMLandscapeDataSheet();
            return JsonConvert.DeserializeObject<ExplosiveATMLandscapeDataSheet>(json);
        }

        public static ExplosiveATMLandscapeDataSheet Load(TestForm t)
        {

            if (!t.Content.IsValid())
            {
                // Create using Parent LabTest
                LabTest lt = LabTest.Get(t.TestID);
                return new ExplosiveATMLandscapeDataSheet(lt);
            }

            else
            {
                return Load(t.Content);
            }
        }

        // convert instance to json
        public static string Save(ExplosiveATMLandscapeDataSheet obj)
        {
            return JsonConvert.SerializeObject(obj);
        }



        // Instance Method
        public string Save()
        {
            return ExplosiveATMLandscapeDataSheet.Save(this);
        }

        public ExplosiveATMLandscapeDataSheet() {}

        public ExplosiveATMLandscapeDataSheet(LabTest t)
        {
            // DateTime.Today.Date.ToString("MM/dd/yyyy");
            
			this.JobNo = t.JobNo;
			this.Date = t.Date;
			this.Test = t.Test;
			this.Time = t.Time;
			this.FuelQty = t.FuelQty;
			this.ChamberAltitude = t.ChamberAltitude;
			this.TC1ChamberAmbientTemp = t.TC1ChamberAmbientTemp;
			this.TC2EastWallTemp = t.TC2EastWallTemp;
			this.TC3WestWallTemp = t.TC3WestWallTemp;
			this.TC4UnitTemp = t.TC4UnitTemp;
			this.TC5PlenumTemp = t.TC5PlenumTemp;
			this.Remarks = t.Remarks;
			this.Tech = t.Tech;
			this.Remarks = t.Remarks;
			this.Engineer = t.Engineer;
        }
    }
}
