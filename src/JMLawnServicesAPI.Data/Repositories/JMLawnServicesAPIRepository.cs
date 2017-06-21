using System;
using System.Collections.Generic;
using System.Data;
using JMLawnServicesAPI.Data.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace JMLawnServicesAPI.Data
{
    class JMLawnServicesAPIRepository : IMatrixServicesApiRepository
    {
        private JMLawnServicesAPIDbContext _context;

        public JMLawnServicesAPIRepository(JMLawnServicesAPIDbContext context)
        {
            _context = context;
        }

        public Estimate CreateEstimate (Estimate newEstimate) 
        {
            var estimate = _context.Estimates.Add(newEstimate); 

            _context.SaveChanges();

            var estimate2 = GetEstimate(estimate.Entity.ID);

            return estimate2; 
        }

        public Estimate GetEstimate (int estimateID) 
        {
            return _context.Estimates.FirstOrDefault(o => o.ID == estimateID); 
        }
   
   
    }
}