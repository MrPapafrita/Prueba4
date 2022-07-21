using MedidoresInteligentesModel;
using MedidoresInteligentesModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedidoresWeb
{

    public partial class AgregarMedidores : System.Web.UI.Page
    {
        private IMedidoresDAL medidorDal = new MedidoresDALDB();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void AgregarMedidorBtn_Click(object sender, EventArgs e)
        {

            Medidores medidor = new Medidores();
            medidor.Nombre = this.Nombre.Text.Trim();

            this.medidorDal.AgregarMedidor(medidor);
            Response.Redirect("Default.aspx");
        }
    }
}