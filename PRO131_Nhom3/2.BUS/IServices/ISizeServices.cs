﻿using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface ISizeServices
    {
        string Add(SizeViews obj);
        string Update(SizeViews obj);
        string Delete(SizeViews obj);
        List<SizeViews> GetSizes();
    }
}
