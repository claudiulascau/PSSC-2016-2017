using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Student
    {
        string name_std;
        int year;
        float avr_grades;
        
        public string name_std
        {
            get{return name_std;}
            set{name_std=name_std;}
        }
        
        public int year
        {
            get{return year;}
            set{year=value;}
        }
        
        public float avr_grades
        {  
            get{return avr_grades;}
            set{avr_grades=value;}
        }
        
        public Student(string name_std, int year, float avr_grades)
        {
            this.name_std=name_std;
            this.year=year;
            this.avr_grades=avr_grades;
        }
     }
 }
        