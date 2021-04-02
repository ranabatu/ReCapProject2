using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GetByBrandId(int brandId)
        {
            return _brandDal.Get(b => b.BrandId == brandId);
        }

        IDataResult<List<Brand>> IBrandService.GetAll()
        {
            throw new NotImplementedException();
        }

        IDataResult<List<Brand>> IBrandService.GetByBrandId(int brandId)
        {
            throw new NotImplementedException();
        }
    }  
}
