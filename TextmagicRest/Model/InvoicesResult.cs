﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp.Deserializers;

namespace TextmagicRest.Model
{
    /// <summary>
    /// List of Invoice resources
    /// </summary>
    public class InvoicesResult : BaseModelList
    {
        [DeserializeAs(Name = "resources")]
        public List<Invoice> Invoices { get; set; }
    }
}
