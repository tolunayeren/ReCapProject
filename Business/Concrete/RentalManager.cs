using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.DTOs;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _irentalDal;
        public RentalManager(IRentalDal iRentalDal)
        {
            _irentalDal = iRentalDal;
        }

        [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental rental)
        {
            var result = _irentalDal.Get(r => r.CarId == rental.CarId);
            if (result.ReturnDate < DateTime.Now)
            {
                _irentalDal.Add(rental);
                return new SuccessResult(Messages.RentalAdded);
            }
            return new ErrorResult(Messages.ReturnedDontFromRental);
        }

        public IResult Delete(Rental rental)
        {
            Rental delete = _irentalDal.Get(r => r.Id == rental.Id);
            _irentalDal.Delete(delete);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_irentalDal.GetAll(), Messages.RentalListed);
        }

        public IDataResult<Rental> GetById(int rentalId)
        {
            return new SuccessDataResult<Rental>(_irentalDal.Get(r => r.Id == rentalId));
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_irentalDal.GetRentalDetails());
        }

        public IResult Update(Rental rental)
        {
            _irentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }
    }
}
