﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyApp.Server.Models
{
    [DataContract]
    public enum NomenclatureInputType
    {
        Text,
        Date
    }
}