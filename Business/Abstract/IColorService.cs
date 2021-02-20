using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAll();
        //<Color> Get(Expression filter);
        IDataResult<List<Color>> GetColorById(int colorId);
        IResult Add(Color color);
        IResult Delete(Color color);
        IResult Update(Color color);

    }
}
