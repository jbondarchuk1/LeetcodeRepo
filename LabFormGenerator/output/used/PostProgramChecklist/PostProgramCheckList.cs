
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
    public class PostProgramCheckList : ModelBase, ILabModel
    {
        
		public string JobNo { get; set; } = "";
		public string Engineer { get; set; } = "";
		public string Customer { get; set; } = "";
		public string Initials0 { get; set; } = "";
		public bool Check0 { get; set; } = false;
		public string Initials1 { get; set; } = "";
		public bool Check1 { get; set; } = false;
		public string Initials2 { get; set; } = "";
		public bool Check2 { get; set; } = false;
		public string Initials3 { get; set; } = "";
		public bool Check3 { get; set; } = false;
		public string Initials4 { get; set; } = "";
		public bool Check4 { get; set; } = false;
		public string EngineerInitials { get; set; } = "";


        // public List<TestData> Data { get; set; } = new List<TestData>();
        // public class TestData {}

        public string FormVersion { get; set; } = "";

        public static PostProgramCheckList Load(string json)
        {
            if (!json.IsValid()) return new PostProgramCheckList();
            return JsonConvert.DeserializeObject<PostProgramCheckList>(json);
        }

        public static PostProgramCheckList Load(TestForm t)
        {

            if (!t.Content.IsValid())
            {
                // Create using Parent LabTest
                LabTest lt = LabTest.Get(t.TestID);
                return new PostProgramCheckList(t,lt);
            }

            else
            {
                return Load(t.Content);
            }
        }

        // convert instance to json
        public static string Save(PostProgramCheckList obj)
        {
            return JsonConvert.SerializeObject(obj);
        }



        // Instance Method
        public string Save()
        {
            return PostProgramCheckList.Save(this);
        }

        public PostProgramCheckList() {}

        public PostProgramCheckList(TestForm tf, LabTest t)
        {
            // DateTime.Today.Date.ToString("MM/dd/yyyy");
            
			this.JobNo = t.JobNumber;
			this.Engineer = t.Engineer;
			this.Customer = t.Customer;
            this.FormVersion = GetReportVersion(tf);

        }
    }
}
