﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Bulky.Data.Access.Data;
using Bulky.Data.Access.Repository.IRepository;
using Bulky.Models;

namespace Bulky.Data.Access.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
  

        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
}
