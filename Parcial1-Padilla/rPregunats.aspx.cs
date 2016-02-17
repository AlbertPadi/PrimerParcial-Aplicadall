using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
namespace Parcial1_Padilla
{
    public partial class rPregunats : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            Preguntas pregunats = new Preguntas();

            if (PreguntaIdTextBox.Text.Length == 0)
            {
                pregunats.Fecha = FechaTextBox.Text;
                pregunats.Descripcion = DescripcionTextBox.Text;
                pregunats.RespuestasPosibles = RespuestasTextBox.Text;

                if (pregunats.Insertar())
                {
                    HttpContext.Current.Response.Write("<Script>alert('Se han guardado los datos')</Script>");
                }
                else
                {
                    HttpContext.Current.Response.Write("<Script>alert('Error al guardar los datos')</Script>");
                }
            }
            else
            {
                int id;
                id = Convert.ToInt32(PreguntaIdTextBox.Text);
                pregunats.PreguntaId = id;
                pregunats.Fecha = FechaTextBox.Text;
                pregunats.Descripcion = DescripcionTextBox.Text;
                pregunats.RespuestasPosibles = RespuestasTextBox.Text;

                if (pregunats.Editar())
                {
                    HttpContext.Current.Response.Write("<Script>alert('se han actualizado los datos')</Script>");
                }
                else
                {
                    HttpContext.Current.Response.Write("<Script>alert('Error al actualizar los datos')</Script>");
                }
            }
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            Preguntas pregunats = new Preguntas();
            int id;
            id = Convert.ToInt32(PreguntaIdTextBox.Text);
            pregunats.PreguntaId = id;
            if (pregunats.Eliminar())
            {
                HttpContext.Current.Response.Write("<Script>alert('Se han eliminado los datos')</Script>");
            }
            else
            {
                HttpContext.Current.Response.Write("<Script>alert('Error al eliminar los datos')</Script>");
            }
            
        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            PreguntaIdTextBox.Text = string.Empty;
            FechaTextBox.Text = string.Empty;
            DescripcionTextBox.Text = string.Empty;
            RespuestasTextBox.Text = string.Empty;
        }

        protected void BuascarButton_Click(object sender, EventArgs e)
        {
            int id;
            Preguntas preguntas = new Preguntas();
            id = Convert.ToInt32(PreguntaIdTextBox.Text);
            preguntas.PreguntaId = id;
            if (preguntas.Buscar(id))
            {
                FechaTextBox.Text = preguntas.Fecha;
                DescripcionTextBox.Text = preguntas.Descripcion;
               RespuestasTextBox.Text = preguntas.RespuestasPosibles;
            }
        }
    }
}