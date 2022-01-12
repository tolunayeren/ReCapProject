using Business.Abstract;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _iuserDal;

        public UserManager(IUserDal userDal)
        {
            _iuserDal = userDal;
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _iuserDal.GetClaims(user);
        }

        public void Add(User user)
        {
            _iuserDal.Add(user);
        }

        public User GetByMail(string email)
        {
            return _iuserDal.Get(u => u.Email == email);
        }
    }
}
