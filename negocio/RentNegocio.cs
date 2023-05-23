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
                datos.setearConsulta("select r.Id, r.Cliente,r.CheckIn,r.CheckOut, s.Spots, r.Importe from RENT r, SPOT s where r.IdSpot = s.Id order by CheckIn asc");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Rent aux = new Rent();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Cliente = (string)datos.Lector["Cliente"];                   
                    aux.CheckIn = (DateTime)datos.Lector["CheckIn"];
                    aux.CheckOut = (DateTime)datos.Lector["CheckOut"];
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

        public void agregar(Rent nueva)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("insert into RENT(Cliente,CheckIn,CheckOut,IdSpot,Importe) values(@Cliente,@CheckIn,@CheckOut,@IdSpot,@Importe)");
                datos.setearParametro("@Cliente",nueva.Cliente);
                datos.setearParametro("@CheckIn",nueva.CheckIn);
                datos.setearParametro("@CheckOut", nueva.CheckOut);
                datos.setearParametro("@IdSpot",nueva.Spot.Id);
                datos.setearParametro("@Importe",nueva.Importe);
                datos.ejecutarAccion();
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

        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("delete from RENT where Id = @Id");
                datos.setearParametro("@Id",id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
