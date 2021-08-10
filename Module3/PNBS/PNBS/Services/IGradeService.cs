using PNBS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PNBS.Services
{
    public interface IGradeService
    {
        Task<List<Grade>> Gets();
    }
}
