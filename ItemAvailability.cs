﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace MXTires.Microdata
{
    [Flags]
    public enum ItemAvailability 
    {
        [EnumMember(Value = "http://schema.org/Discontinued")]
        Discontinued,

        [EnumMember(Value = "http://schema.org/InStock")]
        InStock,
        
        [EnumMember(Value = "http://schema.org/InStoreOnly")]
        InStoreOnly,

        [EnumMember(Value = "http://schema.org/LimitedAvailability")]
        LimitedAvailability,
                
        [EnumMember(Value = "http://schema.org/OnlineOnly")]
        OnlineOnly,

        [EnumMember(Value = "http://schema.org/OutOfStock")]
        OutOfStock,
               
        [EnumMember(Value = "http://schema.org/PreOrder")]
        PreOrder,
        
        [EnumMember(Value = "http://schema.org/SoldOut")]
        SoldOut 
    }
}
