
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
    public class SaltFogCollectionWithTempDataSheet : ModelBase, ILabModel
    {
        
		public string JobNo { get; set; } = "";
		public string Date { get; set; } = "";
		public string Specification { get; set; } = "";
		public string SpecGrav { get; set; } = "";
		public string ChamTempTol { get; set; } = "";
		public string CollectionRate { get; set; } = "";
		public string PHCollectedSol { get; set; } = "";
		public string WaterDataDate { get; set; } = "";
		public string WaterDataConductivity { get; set; } = "";
		public string Temp { get; set; } = "";
		public string SpecGrav { get; set; } = "";
		public string PH { get; set; } = "";

		public string DateAndTech { get; set; } = "";
		public string Start { get; set; } = "";
		public string Stop { get; set; } = "";
		public string TotalCollectionHours { get; set; } = "";
		public string MlDish { get; set; } = "";
		public string MlDishHour { get; set; } = "";
		public string Temp { get; set; } = "";
		public string SpecificGravity { get; set; } = "";
		public string PH { get; set; } = "";
		public string Temp1 { get; set; } = "";
		public string SpecificGravity1 { get; set; } = "";
		public string PH1 { get; set; } = "";
        
		public string Comments { get; set; } = "";
		public string Engineer { get; set; } = "";

        // public List<TestData> Data { get; set; } = new List<TestData>();
        // public class TestData {}


        public static SaltFogCollectionWithTempDataSheet Load(string json)
        {
            if (!json.IsValid()) return new SaltFogCollectionWithTempDataSheet();
            return JsonConvert.DeserializeObject<SaltFogCollectionWithTempDataSheet>(json);
        }

        public static SaltFogCollectionWithTempDataSheet Load(TestForm t)
        {

            if (!t.Content.IsValid())
            {
                // Create using Parent LabTest
                LabTest lt = LabTest.Get(t.TestID);
                return new SaltFogCollectionWithTempDataSheet(lt);
            }

            else
            {
                return Load(t.Content);
            }
        }

        // convert instance to json
        public static string Save(SaltFogCollectionWithTempDataSheet obj)
        {
            return JsonConvert.SerializeObject(obj);
        }



        // Instance Method
        public string Save()
        {
            return SaltFogCollectionWithTempDataSheet.Save(this);
        }

        public SaltFogCollectionWithTempDataSheet() {}

        public SaltFogCollectionWithTempDataSheet(LabTest t)
        {
            // DateTime.Today.Date.ToString("MM/dd/yyyy");
            
			this.JobNo = t.JobNumber;
			this.Date = DateTime.Today.Date.ToString("MM/dd/yyyy");
			this.Engineer = t.Engineer;
        }
    }
}
