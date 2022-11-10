﻿using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IGiaiDauServices
    {
        string Add(GiaiDauView giaiDau);
        string Update(GiaiDauView giaiDau);
        string Delete(Guid id);
        List<GiaiDauView> GetAll();
    }
}
