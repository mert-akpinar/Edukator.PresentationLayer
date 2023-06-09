﻿using Edukator.DataAccessLayer.Abstract;
using Edukator.DataAccessLayer.Concrete;
using Edukator.DataAccessLayer.Repositories;
using Edukator.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.DataAccessLayer.EntityFramework
{
    public class EfContactDal : GenericRepository<Contact>, IContactDal
    {
        public List<Contact> GetLast4Message()
        {
            using var Context = new Context();
            var values = Context.Contacts.OrderByDescending(x => x.ContactID).Take(4).ToList();
            return values;
        }
    }
}