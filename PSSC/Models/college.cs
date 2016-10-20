using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
     class College
     {
        string name;
        string phone;
        Adress adress;
        
        
        public College(string name, string phone, Adress adress)
        {
            this.name=name;
            this.phone=phone;
            this.adress=adress;
        }
        
        public string name
        {
            get { return name;}
            set {name=value;}
        }
        
        public string phone
        {
           get{return phone;}
           set{phone=value;}
        }
        
        public Adress Adress
        {
            get{return adress;}
            set{adress=value;}
        }
      }
 }      