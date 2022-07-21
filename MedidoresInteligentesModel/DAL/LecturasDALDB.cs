using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresInteligentesModel.DAL
{
    public class LecturasDALDB : ILecturasDAL
    {
        private MedidoresInteligentesEntities1 medidoresInteligentesDB = new MedidoresInteligentesEntities1();

        public void AgregarLectura(Lecturas lectura) {
            this.medidoresInteligentesDB.Lecturas.Add(lectura);
            this.medidoresInteligentesDB.SaveChanges();
        }

        public List<Lecturas> ObtenerLecturas() { 
            return this.medidoresInteligentesDB.Lecturas.ToList();
        }    
    }
}
