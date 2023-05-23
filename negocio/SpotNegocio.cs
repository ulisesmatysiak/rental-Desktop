using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class SpotNegocio
    {
        public List<Spot> listar()
        {
            List<Spot> lista = new List<Spot>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select Id, Spots  from SPOT");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Spot aux = new Spot();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Spots = (string)datos.Lector["Spots"];
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
