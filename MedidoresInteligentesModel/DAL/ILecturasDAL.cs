using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresInteligentesModel.DAL
{
    public interface ILecturasDAL
    {
        List<Lecturas> ObtenerLecturas();

        void AgregarLectura(Lecturas lectura);
    }
}
