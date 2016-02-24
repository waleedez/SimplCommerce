﻿using System.Collections.Generic;
using System.Threading.Tasks;
using HvCommerce.Core.Domain.Models;

namespace HvCommerce.Core.ApplicationServices
{
    public interface ICategoryService
    {
        void Delete(long id);

        void Delete(Category category);

        Task<bool> CheckExistBySeoTitle(string seoTitle);
    }
}