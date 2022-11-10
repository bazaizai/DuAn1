﻿using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface ISaleServices
    {
        string Add(SaleView sale);
        string Update(SaleView sale);
        string Delete(Guid id);
        List<SaleView> GetAll();
    }
}
