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
    public partial class AgregarLectura : System.Web.UI.Page
    {

        private ILecturasDAL lecturaDal = new LecturasDALDB();
        private IMedidoresDAL medidorDal = new MedidoresDALDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.medidorDdl.DataSource = this.medidorDal.ObtenerMedidores();
                this.medidorDdl.DataTextField = "Nombre";
                this.medidorDdl.DataValueField = "Codigo";
                this.medidorDdl.DataBind();
            }
        }


        protected void AgregarLecturaBtn_Click(object sender, EventArgs e)
        {
            Lecturas lectura = new Lecturas();
            lectura.Cantidad = Convert.ToInt32(this.Cantidad.Text.Trim());
            lectura.Fecha = this.Fecha.Text.Trim();
            lectura.Hora = this.Hora.Text.Trim();
            lectura.Minuto = this.Minuto.Text.Trim();
            lectura.IdMedidor = Convert.ToInt32(this.medidorDdl.SelectedItem.Value);

            this.lecturaDal.AgregarLectura(lectura);
            Response.Redirect("VerLecturas.aspx");
        }
        }
    }
