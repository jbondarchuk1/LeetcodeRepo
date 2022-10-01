
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
    public class ElectricalEUTReceivedShipped : ModelBase, ILabModel
    {
        
		public string JobNo { get; set; } = "";
		public string Customer { get; set; } = "";
		public string Engineer { get; set; } = "";
		public string TestedYN { get; set; } = "";
		public string DateRcvd { get; set; } = "";
		public string SN { get; set; } = "";
		public string DateShipped { get; set; } = "";
		public string Init { get; set; } = "";
		public string PhotoNo { get; set; } = "";
		public string CameraNo { get; set; } = "";
		public bool IDLabelOnEUTY { get; set; } = false;
		public bool IDLabelOnEUTN { get; set; } = false;
		public string TechInit0 { get; set; } = "";
		public string TechInit1 { get; set; } = "";
		public string TechInit2 { get; set; } = "";
		public string TechInit3 { get; set; } = "";
		public string TechInit4 { get; set; } = "";
		public string TechInit5 { get; set; } = "";
		public string TechInit6 { get; set; } = "";
		public string TechInit7 { get; set; } = "";
		public bool CustomerInfoSheets { get; set; } = false;
		public bool Email { get; set; } = false;
		public string Date { get; set; } = "";
		public string FromWho { get; set; } = "";
		public bool ConferenceCall { get; set; } = false;
		public bool IDLabel { get; set; } = false;
		public bool Other { get; set; } = false;
		public string OtherData { get; set; } = "";
		public bool OnsiteRep { get; set; } = false;
		public bool DTBFilled { get; set; } = false;


        // public List<TestData> Data { get; set; } = new List<TestData>();
        // public class TestData {}

        public string FormVersion { get; set; } = "";

        public static ElectricalEUTReceivedShipped Load(string json)
        {
            if (!json.IsValid()) return new ElectricalEUTReceivedShipped();
            return JsonConvert.DeserializeObject<ElectricalEUTReceivedShipped>(json);
        }

        public static ElectricalEUTReceivedShipped Load(TestForm t)
        {

            if (!t.Content.IsValid())
            {
                // Create using Parent LabTest
                LabTest lt = LabTest.Get(t.TestID);
                return new ElectricalEUTReceivedShipped(t,lt);
            }

            else
            {
                return Load(t.Content);
            }
        }

        // convert instance to json
        public static string Save(ElectricalEUTReceivedShipped obj)
        {
            return JsonConvert.SerializeObject(obj);
        }



        // Instance Method
        public string Save()
        {
            return ElectricalEUTReceivedShipped.Save(this);
        }

        public ElectricalEUTReceivedShipped() {}

        public ElectricalEUTReceivedShipped(TestForm tf, LabTest t)
        {
            // DateTime.Today.Date.ToString("MM/dd/yyyy");
            
			this.JobNo = t.JobNumber;
			this.Customer = t.Customer;
			this.Engineer = t.Engineer;
			this.Date = DateTime.Today.Date.ToString("MM/dd/yyyy");
            this.FormVersion = GetReportVersion(tf);

        }
    }
}
