def createModelFile(classname, fields):
    hmap = {
        "JobNo": "t.JobNumber", 
        "JobNumber": "t.JobNumber", 
        "Date": "DateTime.Today.Date.ToString(\"MM/dd/yyyy\")", 
        "Engineer":"t.Engineer", 
        "Customer": "t.Customer" 
        }
    fieldsStringBuilder = ""
    finalConstructor = ""

    for i in range(len(fields)):
        field = fields[i]
        if len(field) > 0:
            # handle boolean values
            if field[0] == "*":
                field = field[1:]
                fieldsStringBuilder += f"\n\t\t" + f"public bool {field} {{ get; set; }} = false;"
            # handle text values
            else: 
                fieldsStringBuilder += f"\n\t\t" + f"public string {field} {{ get; set; }} = \"\";"
            if field in hmap.keys(): finalConstructor += f"\n\t\t\t" + f"this.{field} = {hmap[field]};"


    return f"""
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
{{
    public class {classname} : ModelBase, ILabModel
    {{
        {fieldsStringBuilder}


        // public List<TestData> Data {{ get; set; }} = new List<TestData>();
        // public class TestData {{}}

        public string FormVersion {{ get; set; }} = "";

        public static {classname} Load(string json)
        {{
            if (!json.IsValid()) return new {classname}();
            return JsonConvert.DeserializeObject<{classname}>(json);
        }}

        public static {classname} Load(TestForm t)
        {{

            if (!t.Content.IsValid())
            {{
                // Create using Parent LabTest
                LabTest lt = LabTest.Get(t.TestID);
                return new {classname}(t,lt);
            }}

            else
            {{
                return Load(t.Content);
            }}
        }}

        // convert instance to json
        public static string Save({classname} obj)
        {{
            return JsonConvert.SerializeObject(obj);
        }}



        // Instance Method
        public string Save()
        {{
            return {classname}.Save(this);
        }}

        public {classname}() {{}}

        public {classname}(TestForm tf, LabTest t)
        {{
            // DateTime.Today.Date.ToString("MM/dd/yyyy");
            {finalConstructor}
            this.FormVersion = GetReportVersion(tf);

        }}
    }}
}}
"""