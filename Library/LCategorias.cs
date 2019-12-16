using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemasWeb.Data;

namespace ProyectoWeb.Library
{
    public class LCategorias
    {
        private ApplicationDbContext context;

        public LCategorias(ApplicationDbContext context)
        {
            this.context = context;
        }
    }
}
