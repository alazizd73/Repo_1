using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Groep9_SE7
{
    public class Employees
    {
        public int ID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip_Code { get; set; }
        public string Phone { get; set; }
        public string Status { get; set; }
        public string Ss_Number { get; set; }
        public decimal? Salary { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime? Termination_Date { get; set; }
        public DateTime? Birth_Date { get; set; }
        public char? Bene_health_ins { get; set; }
        public char? Bene_life_ins { get; set; }
        public char? Bene_day_care { get; set; }
        public char? Sex { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Extension { get; set; }
        public string TargetMissed { get; set; }
        public int? Manager { get; set; }
        public int? Job_ID { get; set; }
        public int? Dept_ID { get; set; }

        public override string ToString()
        {
            return $"ID: {ID}\nFirst Name: {First_Name}\nLast Name: {Last_Name}\nStreet: {Street}\nCity: {City}\nState: {State}\nZip_Code: {Zip_Code}\nPhone: {Phone}\nStatus: {Status}\nSocial Security: {Ss_Number}\nSalary: {Salary}\nStart Date: {Start_Date.ToShortDateString()}\nTermination Date: {Termination_Date}\nBirth Date: {Birth_Date}\nHealth Insurance: {Bene_health_ins}\nLife Insurance: {Bene_life_ins}\nDay Care: {Bene_day_care}\nSex: {Sex}\nFax: {Fax}\nEmail: {Email}\nExtension: {Extension}\nTarget Missed: {TargetMissed}\nManager: {Manager}\nJob: {Job_ID}\nDepartment: {Dept_ID} ";
        }
    }
}
