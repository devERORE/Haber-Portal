using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HaberSistemi.Data.Infrastucture;
using HaberSistemi.Data.Model;

namespace HaberSistemi.Core.Infrastucture
{
    public interface IHaberRepository : IRepository<Haber>
    {
    }
}
