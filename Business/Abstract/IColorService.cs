﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll();
        //<Color> Get(Expression filter);
        List<Color> GetColorById(int colorId);
        void Add(Color color);
        void Delete(Color color);
        void Update(Color color);

    }
}
