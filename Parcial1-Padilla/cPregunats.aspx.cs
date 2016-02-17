using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;
namespace Parcial1_Padilla
{
    public partial class cPregunats : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BuascarButton_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Preguntas preguntas = new Preguntas();
            string filtro = "1=1";

            if (DatosTextBox.Text.Trim().Length == 0 && DeTextBox.Text.Trim().Length == 0 && HastaTextBox.Text.Trim().Length == 0)
            {
                filtro = "1=1";
                dt = preguntas.Listado(" * ", filtro, "");
                DatosGridView.DataSource = dt;
                DatosGridView.DataBind();

            }

            if (DatosTextBox.Text.Trim().Length != 0)
            {
                filtro = "1=1";
            }
            else
            {

                filtro = "Descripcion like '%" + DatosTextBox.Text + "%'";
            }
            dt = preguntas.Listado(" * ", filtro, "");
            DatosGridView.DataSource = dt;
            DatosGridView.DataBind();

            if (DatosTextBox.Text.Trim().Length == 0 && DeTextBox.Text.Trim().Length != 0 && HastaTextBox.Text.Trim().Length != 0)
            {
                filtro = "1=1";
            }
            else
            {

                filtro = "Descripcion like '%" + DatosTextBox.Text + "%'";
            }
            dt = preguntas.Listado(" * ", filtro, "");
            DatosGridView.DataSource = dt;
            DatosGridView.DataBind();
        }
    }
}