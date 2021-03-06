﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace dblp_reducer_src.Model
{
    public class Author
    {   
        [XmlText]
        public string NameW { get; set; }

        [XmlAttribute("count")]
        public int count { get; set; }

        [XmlElement("id")]
        public int Id { get; set; }

        [XmlAttribute("urlpt")]
        public string url { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }

        public override bool Equals(Object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Author a = (Author)obj;
                return (Id == a.Id) && (Name == a.Name);
            }
        }
        
        public override int GetHashCode()
        {
            return Id+NameW.GetHashCode();
        }
    }
}
