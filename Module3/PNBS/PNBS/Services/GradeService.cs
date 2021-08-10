using Microsoft.EntityFrameworkCore;
using PNBS.Contexts;
using PNBS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PNBS.Services
{
    public class GradeService : IGradeService
    {
        private readonly AppDbContext context;

        public GradeService(AppDbContext context)
        {
            this.context = context;
        }
        public async Task<List<Grade>> Gets()
        {
            return await context.Grades.ToListAsync();
        }
    }
}
