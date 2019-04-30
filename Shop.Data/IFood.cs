﻿using Shop.Data.Models;
using System.Collections.Generic;

namespace Shop.Data
{
    public interface IFood
    {
        IEnumerable<Food> GetAll();
        IEnumerable<Food> GetPreferred();
        IEnumerable<Food> GetFoodsByCategoryId(int categoryId);
        Food GetById(int id);
    }
}
