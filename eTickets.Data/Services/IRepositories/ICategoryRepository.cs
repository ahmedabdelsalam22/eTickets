﻿using eTickets.Data.Services.Repositories;
using eTickets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTickets.Data.Services.IRepositories
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Task Update(Category category);
    }
}
