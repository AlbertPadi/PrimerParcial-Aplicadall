using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL;
namespace BLL
{
    public class Preguntas : ClaseMaestra
    {
        public int PreguntaId { get; set; }
        public string Fecha { get; set; }
        public string Descripcion { get; set; }
        public string RespuestasPosibles { get; set; }

        public Preguntas()
        {
            this.PreguntaId = 0;
            this.Fecha = "";
            this.Descripcion = "";
            this.RespuestasPosibles = "";
        }

        public override bool Insertar()
        {
            ConexionDb conexion = new ConexionDb();
            bool retorno = false;
            retorno = conexion.Ejecutar(String.Format("Insert into Preguntas(Fecha, Descripcion, RespuestasPosibles) values('{0}', '{1}', '{2}')", this.Fecha, this.Descripcion, this.RespuestasPosibles));
            return retorno;
        }

        public override bool Editar()
        {
            ConexionDb conexion = new ConexionDb();
            bool retorno = false;
            retorno = conexion.Ejecutar(String.Format("Update Preguntas set Fecha = '{0}', Descripcion = '{1}', RespuestasPosibles = '{2}' where PreguntaId = {3}", this.Fecha, this.Descripcion, this.RespuestasPosibles, this.PreguntaId));
            return retorno;
        }

        public override bool Eliminar()
        {
            ConexionDb conexion = new ConexionDb();
            bool retorno = false;
            retorno = conexion.Ejecutar(String.Format("Delete from Preguntas where PreguntaId = {0}", this.PreguntaId));
            return retorno;
        }
        public override bool Buscar(int IdBuscado)
        {
            ConexionDb conexion = new ConexionDb();

            DataTable dt = new DataTable();
            dt = conexion.ObtenerDatos(String.Format("Select * from Preguntas where PreguntaId = {0}", IdBuscado));

            if (dt.Rows.Count > 0)
            {
                this.Fecha = dt.Rows[0]["Fecha"].ToString();
                this.Descripcion = dt.Rows[0]["Descripcion"].ToString();
                this.RespuestasPosibles = dt.Rows[0]["RespuestasPosibles"].ToString();
            }

            return dt.Rows.Count > 0;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            ConexionDb conexion = new ConexionDb();

            string ordenFinal;
            if (!Orden.Equals(""))
                ordenFinal = " Orden By " + Orden;
            return conexion.ObtenerDatos(" Select " + Campos + " From Preguntas where " + Condicion + "" + Orden);

        }
    }
}
