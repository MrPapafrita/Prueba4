using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresInteligentesModel.DAL
{
    public class MedidoresDALDB : IMedidoresDAL
    {
        private MedidoresInteligentesEntities1 medidoresInteligentesDB = new MedidoresInteligentesEntities1();

        public List<Medidores> ObtenerMedidores() { 
            return this.medidoresInteligentesDB.Medidores.ToList();
        }
        public void AgregarMedidor(Medidores medidor) {
            this.medidoresInteligentesDB.Medidores.Add(medidor);
            this.medidoresInteligentesDB.SaveChanges();
        }
    }
}
