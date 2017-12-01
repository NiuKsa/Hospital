﻿using System;

namespace Hospital.Pharmacy.PharmacyDomain
{
    interface IMedicine
    {
        string Name { get; set; }
        string Type { get; set; }
        DateTime Validity { get; set; }
        int SupplierID { get; set; }
    }
}
