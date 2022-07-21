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
    public partial class Default : System.Web.UI.Page
    {
        private IMedidoresDAL medidoresDal = new MedidoresDALDB();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                List<Medidores> medidor = medidoresDal.ObtenerMedidores();
                this.grillaMedidores.DataSource = medidor;
                this.grillaMedidores.DataBind();
            }

        }

        protected void CargaGrilla()
        {


            List<Medidores> medidor = medidoresDal.ObtenerMedidores();
            this.grillaMedidores.DataSource = medidor;
            this.grillaMedidores.DataBind();


        }


        protected void grillaMedidores_RowCommand(object sender,GridViewCommandEventArgs e )
        {


        }



    }
}