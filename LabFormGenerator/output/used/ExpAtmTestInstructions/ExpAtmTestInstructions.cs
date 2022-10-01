
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
    public class ExpAtmTestInstructions : ModelBase, ILabModel
    {
        
		public string JobNo { get; set; } = "";
		public string Customer { get; set; } = "";
		public string Facility { get; set; } = "";
		public string Date { get; set; } = "";
		public string Engineer { get; set; } = "";
		public string Specification { get; set; } = "";
		public string ReqChamTemp { get; set; } = "";
		public string FuelTemp { get; set; } = "";
		public string VolDisplaced { get; set; } = "";
		public string FuelType { get; set; } = "";
		public string TestAltitude { get; set; } = "";
		public string FuelInjectionAltitude { get; set; } = "";
		public string CommenceAlt { get; set; } = "";
		public string CompletionAlt { get; set; } = "";
		public string ReqFuel { get; set; } = "";
		public string AddFuel { get; set; } = "";
		public string Note00 { get; set; } = "";
		public string UnitOpReq { get; set; } = "";
		public string SpecialReq { get; set; } = "";
		public string Note001 { get; set; } = "";
		public string Note002 { get; set; } = "";
		public string Note003 { get; set; } = "";


        public static ExpAtmTestInstructions Load(string json)
        {
            if (!json.IsValid()) return new ExpAtmTestInstructions();
            return JsonConvert.DeserializeObject<ExpAtmTestInstructions>(json);
        }

        public static ExpAtmTestInstructions Load(TestForm t)
        {

            if (!t.Content.IsValid())
            {
                // Create using Parent LabTest
                LabTest lt = LabTest.Get(t.TestID);
                return new ExpAtmTestInstructions(lt);
            }

            else
            {
                return Load(t.Content);
            }
        }

        // convert instance to json
        public static string Save(ExpAtmTestInstructions obj)
        {
            return JsonConvert.SerializeObject(obj);
        }



        // Instance Method
        public string Save()
        {
            return ExpAtmTestInstructions.Save(this);
        }

        public ExpAtmTestInstructions() {}

        public ExpAtmTestInstructions(LabTest t)
        {
            // DateTime.Today.Date.ToString("MM/dd/yyyy");
            
			this.JobNo = t.JobNo;
			this.Customer = t.Customer;
			this.Facility = t.Facility;
			this.Date = t.Date;
			this.Engineer = t.Engineer;
			this.Specification = t.Specification;
			this.ReqChamTemp = t.ReqChamTemp;
			this.FuelTemp = t.FuelTemp;
			this.VolDisplaced = t.VolDisplaced;
			this.FuelType = t.FuelType;
			this.TestAltitude = t.TestAltitude;
			this.FuelInjectionAltitude = t.FuelInjectionAltitude;
			this.CommenceAlt = t.CommenceAlt;
			this.CompletionAlt = t.CompletionAlt;
			this.ReqFuel = t.ReqFuel;
			this.AddFuel = t.AddFuel;
			this.Note00 = t.Note00;
			this.UnitOpReq = t.UnitOpReq;
			this.SpecialReq = t.SpecialReq;
			this.Note001 = t.Note001;
			this.Note002 = t.Note002;
			this.Note003 = t.Note003;
        }
    }
}
