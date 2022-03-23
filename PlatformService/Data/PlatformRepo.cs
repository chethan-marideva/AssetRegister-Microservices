using System;
using System.Collections.Generic;
using System.Linq;
using PlatformService.Models;

namespace PlatformService.Data{


    public class PlatformRepo : IPlatfromRepo
    {
        private readonly AppDbContext _context;

        public PlatformRepo(AppDbContext context)
        {
            _context= context;
        }
        public void CreatePlatform(Platfrom plat)
        {
            if(plat==null){
                throw new ArgumentNullException(nameof(plat)) ;           }

                _context.Platfroms.Add(plat);
        }

        public IEnumerable<Platfrom> GetAllPlatforms()
        {
            return _context.Platfroms.ToList();
        }

        public Platfrom GetPlatformById(int id)
        {
            return _context.Platfroms.FirstOrDefault(p=>p.Id==id);
        }

        public bool SaveChanges()
        {
            return(_context.SaveChanges()>=0);
        }
    }
}