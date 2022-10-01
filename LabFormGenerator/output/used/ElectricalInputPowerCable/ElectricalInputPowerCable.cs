
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
    public class ElectricalInputPowerCable : ModelBase, ILabModel
    {
		public string JobNo { get; set; } = "";
		public string Customer { get; set; } = "";
		public string Engineer { get; set; } = "";
		public string Voltage { get; set; } = "";
		public string Frequency { get; set; } = "";
		public string Phases { get; set; } = "";
		public string NoLeads { get; set; } = "";
		public string CableLength { get; set; } = "";
		public string CableAndDescription { get; set; } = "";
		public string NominalCurrent { get; set; } = "";
		public string CableLength { get; set; } = "";
		public string CableAndDescription { get; set; } = "";


        // public List<TestData> Data { get; set; } = new List<TestData>();
        // public class TestData {}

        public string FormVersion { get; set; } = "";

        public static ElectricalInputPowerCable Load(string json)
        {
            if (!json.IsValid()) return new ElectricalInputPowerCable();
            return JsonConvert.DeserializeObject<ElectricalInputPowerCable>(json);
        }

        public static ElectricalInputPowerCable Load(TestForm t)
        {

            if (!t.Content.IsValid())
            {
                // Create using Parent LabTest
                LabTest lt = LabTest.Get(t.TestID);
                return new ElectricalInputPowerCable(t,lt);
            }

            else
            {
                return Load(t.Content);
            }
        }

        // convert instance to json
        public static string Save(ElectricalInputPowerCable obj)
        {
            return JsonConvert.SerializeObject(obj);
        }



        // Instance Method
        public string Save()
        {
            return ElectricalInputPowerCable.Save(this);
        }

        public ElectricalInputPowerCable() {}

        public ElectricalInputPowerCable(TestForm tf, LabTest t)
        {
            // DateTime.Today.Date.ToString("MM/dd/yyyy");
            
			this.JobNo = t.JobNumber;
			this.Customer = t.Customer;
			this.Engineer = t.Engineer;
            this.FormVersion = GetReportVersion(tf);

        }
    }
}
