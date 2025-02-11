﻿using NBSoft.Domain.Model.MasterPanel;

namespace CleanArchitectureDemo.Application.Interfaces.Repositories
{
    public interface ICountryRepository
    {
        public interface IPlayerRepository
        {
            Task<List<Country>> GetCountries();
        }
    }
}
