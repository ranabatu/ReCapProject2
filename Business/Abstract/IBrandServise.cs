using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandServise
    {
        List<Brand> GetAll();
        Brand GetByBrandId(int brandId);
    }
}
