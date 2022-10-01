
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
    public class ElectricalEUTInformation : ModelBase, ILabModel
    {
        
		public string JobNo { get; set; } = "";
		public string Customer { get; set; } = "";
		public string Engineer { get; set; } = "";
		public string PartNo0 { get; set; } = "";
		public string ModelNo0 { get; set; } = "";
		public string SerialNo0 { get; set; } = "";
		public string PartNo1 { get; set; } = "";
		public string ModelNo1 { get; set; } = "";
		public string SerialNo1 { get; set; } = "";
		public string PartNo2 { get; set; } = "";
		public string ModelNo2 { get; set; } = "";
		public string SerialNo2 { get; set; } = "";
		public string PartNo3 { get; set; } = "";
		public string ModelNo3 { get; set; } = "";
		public string SerialNo3 { get; set; } = "";
		public string CameraNo { get; set; } = "";


        // public List<TestData> Data { get; set; } = new List<TestData>();
        // public class TestData {}

        public string FormVersion { get; set; } = "";

        public static ElectricalEUTInformation Load(string json)
        {
            if (!json.IsValid()) return new ElectricalEUTInformation();
            return JsonConvert.DeserializeObject<ElectricalEUTInformation>(json);
        }

        public static ElectricalEUTInformation Load(TestForm t)
        {

            if (!t.Content.IsValid())
            {
                // Create using Parent LabTest
                LabTest lt = LabTest.Get(t.TestID);
                return new ElectricalEUTInformation(t,lt);
            }

            else
            {
                return Load(t.Content);
            }
        }

        // convert instance to json
        public static string Save(ElectricalEUTInformation obj)
        {
            return JsonConvert.SerializeObject(obj);
        }



        // Instance Method
        public string Save()
        {
            return ElectricalEUTInformation.Save(this);
        }

        public ElectricalEUTInformation() {}

        public ElectricalEUTInformation(TestForm tf, LabTest t)
        {
            // DateTime.Today.Date.ToString("MM/dd/yyyy");
            
			this.JobNo = t.JobNumber;
			this.Customer = t.Customer;
			this.Engineer = t.Engineer;
            this.FormVersion = GetReportVersion(tf);

        }
    }
}
