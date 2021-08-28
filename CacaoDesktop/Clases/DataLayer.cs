using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacaoDesktop.Clases
{
    public class DataLayer
    {
        public DataLayer()
        {

        }
        public virtual string EjecutarEscalar(string query) { return string.Empty; }

        public virtual string Ejecutar(string query) { return string.Empty; }

    }
}
