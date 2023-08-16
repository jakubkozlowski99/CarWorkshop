﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Domain.Interfaces
{
    public interface ICarWorkshopRepository
    {
        Task Create(Entities.CarWorkshop carWorkshop);
        Task<Domain.Entities.CarWorkshop?> GetByName(string name);
        Task<IEnumerable<Domain.Entities.CarWorkshop>> GetAll();
        Task<Domain.Entities.CarWorkshop> GetByEncodedName(string encodedName);
        Task Commit();
    }
}
