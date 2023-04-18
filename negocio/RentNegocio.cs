using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class RentNegocio
    {
        public List<Rent> listar()
        {
            List<Rent> lista = new List<Rent>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select r.Id, r.Cliente,f.CheckIn,f.CheckOut, s.Spots, r.Importe from RENT r, SPOT s, FECHA f where r.IdFecha = f.Id and r.IdSpot = s.Id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Rent aux = new Rent();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Cliente = (string)datos.Lector["Cliente"];
                    aux.Fecha = new Fecha();
                    aux.Fecha.Id = (int)datos.Lector["Id"];
                    aux.Fecha.CheckIn = (DateTime)datos.Lector["CheckIn"];
                    aux.Fecha.CheckOut = (DateTime)datos.Lector["CheckOut"];
                    aux.Spot = new Spot();
                    aux.Spot.Id = (int)datos.Lector["Id"];
                    aux.Spot.Spots = (string)datos.Lector["Spots"];
                    aux.Importe = (decimal)datos.Lector["Importe"];
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
