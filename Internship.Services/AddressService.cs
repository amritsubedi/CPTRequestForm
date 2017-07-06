﻿using Internship.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Internship.Services
{

    public class AddressService : GenericService<Address>, IAddressService
    {
        public AddressService(DbContext _context) : base(_context)
        {
        }
        
    }
}
