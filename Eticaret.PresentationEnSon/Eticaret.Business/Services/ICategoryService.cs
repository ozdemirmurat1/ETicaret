﻿using Eticaret.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Business.Services
{
    public interface ICategoryService
    {
        List<Category> List();

        Category GetCategory(string seoName);
    }
}
