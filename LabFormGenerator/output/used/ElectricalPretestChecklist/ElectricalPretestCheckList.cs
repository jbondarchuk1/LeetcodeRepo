
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
    public class ElectricalPretestCheckList : ModelBase, ILabModel
    {
        
		public string JobNo { get; set; } = "";
		public string Engineer { get; set; } = "";
		public string Customer { get; set; } = "";
		public string Test { get; set; } = "";
		public string ReadProcedure { get; set; } = "";
		public bool ReadProcCheck { get; set; } = false;
		public string ReadSpec { get; set; } = "";
		public bool ReadSpecCheck { get; set; } = false;
		public string VerifiedSetup { get; set; } = "";
		public bool VerifiedSetupCheck { get; set; } = false;
		public string VerifiedTest { get; set; } = "";
		public bool VerifiedTestCheck { get; set; } = false;
		public string EquipListGenerated { get; set; } = "";
		public bool EquipListGeneratedCheck { get; set; } = false;
		public string EquipListPrinted { get; set; } = "";
		public bool EquipListPrintedCheck { get; set; } = false;
		public string PhotosTaken { get; set; } = "";
		public bool PhotosTakenCheck { get; set; } = false;
		public string EngineerInit { get; set; } = "";


        // public List<TestData> Data { get; set; } = new List<TestData>();
        // public class TestData {}

        public string FormVersion { get; set; } = "";

        public static ElectricalPretestCheckList Load(string json)
        {
            if (!json.IsValid()) return new ElectricalPretestCheckList();
            return JsonConvert.DeserializeObject<ElectricalPretestCheckList>(json);
        }

        public static ElectricalPretestCheckList Load(TestForm t)
        {

            if (!t.Content.IsValid())
            {
                // Create using Parent LabTest
                LabTest lt = LabTest.Get(t.TestID);
                return new ElectricalPretestCheckList(t,lt);
            }

            else
            {
                return Load(t.Content);
            }
        }

        // convert instance to json
        public static string Save(ElectricalPretestCheckList obj)
        {
            return JsonConvert.SerializeObject(obj);
        }



        // Instance Method
        public string Save()
        {
            return ElectricalPretestCheckList.Save(this);
        }

        public ElectricalPretestCheckList() {}

        public ElectricalPretestCheckList(TestForm tf, LabTest t)
        {
            // DateTime.Today.Date.ToString("MM/dd/yyyy");
            
			this.JobNo = t.JobNumber;
			this.Engineer = t.Engineer;
			this.Customer = t.Customer;
            this.FormVersion = GetReportVersion(tf);

        }
    }
}
