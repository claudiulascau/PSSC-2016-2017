using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Teacher
    {
        string first_name;
        string last_name;
        
        public string first_name
        {
            get{return this.first_name;}
            set{this.first_name=value;}
        }
        
        public string last_name
        {
            get{return this.last_name;}
            set{this.last_name=value;}
        }
        
        public Teacher(string first_name, string last_name)
        {
            this.first_name=first_name;
            this.last_name=last_name;
        }
        
        void print(void)
        {
            Console.WriteLine("Teacher name",first_name,last_name);
        }
      }
 }       
        