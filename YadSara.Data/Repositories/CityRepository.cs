﻿using YadSara.Core.Entities;
using YadSara.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YadSara.Data.Repositories
{
    public class CityRepository: ICityRepository
    {
        private readonly DataContext _context;

        public CityRepository(DataContext context)
        {
            _context = context;
        }
        public List<City> GetAll()
        {
            return _context.City;
        }
        public City GetById(int id)
        {
            return _context.City.FirstOrDefault(bN => bN.CityId.Equals(id));
        }
        public City Add(City c)
        {
            _context.City.Add(c);
            return c;
        }
        public City Update(City c)
        {
            var index = _context.City.FindIndex(f => f.CityId == c.CityId);
            _context.City[index].CityName = c.CityName;
            _context.City[index].CityId = c.CityId;
            return c;
        }
        public void Delete(int id)
        {
            var index = _context.City.FindIndex(f => f.CityId.Equals( id));
            _context.City.RemoveAt(index);
        }


    }
}
