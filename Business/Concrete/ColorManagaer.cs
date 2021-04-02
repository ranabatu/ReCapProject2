using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    
    public class ColorManagaer : IColorService
    {
        IColorDal _colorDal;

        public ColorManagaer(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public Color GetByColorId(int colorId)
        {
            return _colorDal.Get(co => co.ColorId == colorId);
        }

        IDataResult<List<Color>> IColorService.GetAll()
        {
            throw new NotImplementedException();
        }
    
        IDataResult<List<Color>> IColorService.GetByColorId(int colorId)
        {
            throw new NotImplementedException();
        }
    }
}
