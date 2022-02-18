using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Dillon Krein
//2-11-2022
//Scholarship class for each object with getters and setters
namespace Lab1_Part3_DillonKrein
{
    public class Scholarship
    {
        public int scholarshipID { get; set; }
        private string coordName;
        private String scholarshipName;
        private String scholarshipYear;
        private String scholarshipAmount;

        public static int nextScholarship=0;
        public Scholarship(string scholarshipName, string scholarshipYear, string scholarshipAmount, string coordName)
        {
            this.scholarshipName = scholarshipName;
            this.scholarshipYear = scholarshipYear;
            this.scholarshipAmount = scholarshipAmount;
            this.coordName = coordName;
            scholarshipID = nextScholarship++;
        }
        public string ScholarshipName
        {
            get { return this.scholarshipName; }
            set { scholarshipName = value; }
        }
        public string ScholarshipYear
        {
            get { return this.scholarshipYear; }
            set { scholarshipYear = value; }
        }
        public string ScholarshipAmount
        {
            get { return this.scholarshipAmount; }
            set { scholarshipAmount = value; }
        }
        public string CoordName
        {
            get { return this.coordName; }
            set { coordName = value;  }
        }

    }
    
}