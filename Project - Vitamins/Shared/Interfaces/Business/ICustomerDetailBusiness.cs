﻿using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Business
{
    public interface ICustomerDetailBusiness
    {
        bool InsertCustomerDetail(CustomerDetail detail);
    }
}
