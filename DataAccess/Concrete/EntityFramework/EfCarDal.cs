using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapProjectContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto,bool>> filter=null)
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.brandId
                             join cl in context.Colors
                             on c.ColorId equals cl.ColorId
                             select new CarDetailDto { 
                                 CarId = c.Id, ColorName=cl.ColorName, BrandName = b.brandName, CarName=c.CarName,
                                 DailyPrice = c.DailyPrice, ModelYear = c.ModelYear, 
                                 ImagePath = (from x in context.CarImages where x.CarId == c.Id select x.ImagePath).FirstOrDefault()
                             };
                return filter == null 
                    ? result.ToList() 
                    : result.Where(filter).ToList();
            }
        }
    }
}
