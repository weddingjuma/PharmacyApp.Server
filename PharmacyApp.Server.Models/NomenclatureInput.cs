﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyApp.Server.Models
{
    [DataContract]
    public class NomenclatureInput
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Name { get; set; }
        
        [DataMember]
        public string ValidationRegex { get; set; }
        
        [DataMember]
        public string Length { get; set; }
        
        [DataMember]
        public NomenclatureInputType Type { get; set; }
        
        [DataMember]
        public double X { get; set; }
        
        [DataMember]
        public double Y { get; set; }
    }
}
