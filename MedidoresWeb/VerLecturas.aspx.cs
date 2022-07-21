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

   
    public partial class VerLecturas : System.Web.UI.Page
    {

        private ILecturasDAL lecturaDal = new LecturasDALDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                this.CargaGrilla();
            }
        }

        private void CargaGrilla()
        {

            List<Lecturas> lecturas = lecturaDal.ObtenerLecturas();
            this.grillaLecturas.DataSource = lecturas;
            this.grillaLecturas.DataBind();
        }
        
    }
}