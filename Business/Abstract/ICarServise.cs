using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarServise
    {
        List<Car> GetAll();

        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);
        

    }
}
