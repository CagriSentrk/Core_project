﻿using BussinesLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _contactdal;

        public ContactManager(IContactDal contactdal)
        {
            this._contactdal = contactdal;
        }

        public void TAdd(Contact t)
        {
            _contactdal.Insert(t);
        }

        public void TDelete(Contact t)
        {
            _contactdal.Delete(t);
        }

        public Contact TGetByID(int id)
        {
          return  _contactdal.GetByID(id);
        }

        public List<Contact> TGetList()
        {
           return _contactdal.GetList();
        }

        public void TUpdate(Contact t)
        {
            _contactdal.Update(t);
        }
    }
}
