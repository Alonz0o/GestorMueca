using EtiquetadoBultos.Models;

using System;
using MySqlConnector;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtiquetadoBultos
{
    public class ConexionMySql
    {
        // Sql connection
        MySqlConnection conexion = new MySqlConnection("server = localhost; port=3306; userid=root; password=kamila; database=sistemaindustrial;");

        public IList<Usuario> buscarPersonal()
        {
            conexion.Open();
            IList<Usuario> personal = new List<Usuario>();

            using (var command = new MySqlCommand("Select Nombre, Apellido, Area, Legajo From Usuarios Where ((Baja=0) and ((Modulo_9Ext=1) or (Modulo_9Imp =1))) order by Legajo;", conexion))
            {

                command.CommandType = CommandType.Text;
                var reader2 = command.ExecuteReader();
                while (reader2.Read())
                {
                    Usuario usuario = new Usuario
                    {
                        Nombre = reader2.GetString(0),
                        Apellido = reader2.GetString(1),
                        Area = reader2.GetString(2),
                        Legajo = reader2.GetInt32(3),
                    };
                    personal.Add(usuario);

                }
                conexion.Close();
            }

            return personal;
        }

        internal IList<int> buscarBustos(string idOrden)
        {
            IList<int> numBultos = new List<int>();
            string mySqlQuery = "select num_bulto from bultos where id_orden = @cmdIdOrden;";

            using (var command = new MySqlCommand(mySqlQuery, conexion))
            {
                command.Parameters.Add("@cmdIdOrden", MySqlDbType.String).Value = idOrden;
                command.CommandType = CommandType.Text;
                conexion.Open();
                var res = command.ExecuteReader();
                while (res.Read())
                {
                    numBultos.Add(res.GetInt32(0));
                }
                conexion.Close();
            }
            return numBultos;
        }

        public IList<Usuario> buscarEncargados()
        {
            conexion.Open();
            IList<Usuario> personal = new List<Usuario>();

            using (var command = new MySqlCommand("select u.nombre, u.apellido, u.area, u.legajo from usuarios u where u.baja = 0 and(u.Modulo_9Ext = 1 or u.Modulo_9Imp = 1) and(u.area = 'Encargado' Or u.area like '%jefe%') order by u.legajo;", conexion))
            {

                command.CommandType = CommandType.Text;
                var reader2 = command.ExecuteReader();
                while (reader2.Read())
                {
                    Usuario usuario = new Usuario
                    {
                        Nombre = reader2.GetString(0),
                        Apellido = reader2.GetString(1),
                        Area = reader2.GetString(2),
                        Legajo = reader2.GetInt32(3),
                    };
                    personal.Add(usuario);

                }
                conexion.Close();
            }

            return personal;
        }

        internal bool verificarContraseña(string legajo, string pass)
        {
            var respuesta = false;
            string mySqlQuery = "select u.nombre, u.apellido, u.area, u.legajo, u.password " +
                "from usuarios u " +
                "where u.legajo=@cmdLegajo and u.password=@cmdPass and u.baja=0 and(u.Modulo_9Ext=1 or u.Modulo_9Imp=1) and(u.area='Encargado' Or u.area like '%jefe%'); ";

            using (var command = new MySqlCommand(mySqlQuery, conexion))
            {
                command.Parameters.Add("@cmdLegajo", MySqlDbType.String).Value = legajo;
                command.Parameters.Add("@cmdPass", MySqlDbType.String).Value = pass;
                command.CommandType = CommandType.Text;
                conexion.Open();
                var res = command.ExecuteReader();
                if (res.Read())
                {
                    respuesta = true;
                }
                conexion.Close();

            }

            return respuesta;
        }

        internal IList<Bobina> buscarBobinas(string orden, string codigo)
        {
            IList<Bobina> bobinas = new List<Bobina>();
            string mySqlQuery = "select e.indice, e.Rollo_Num, e.Longitud_Rollo, e.Neto, e.Id_NTIntermedio, e.metrosremanentes " +
                "from extrusiones e " +
                "where orden = @cmdOrder and codigo = @cmdCodigo;";

            using (var command = new MySqlCommand(mySqlQuery, conexion))
            {
                command.Parameters.Add("@cmdOrder", MySqlDbType.String).Value = orden;
                command.Parameters.Add("@cmdCodigo", MySqlDbType.String).Value = codigo;
                command.CommandType = CommandType.Text;
                conexion.Open();
                var res = command.ExecuteReader();
                while (res.Read())
                {
                    Bobina bobina = new Bobina
                    {
                        indice = res.GetInt32(0),
                        numRollo = res.GetInt32(1),
                        longitudRollo = res.GetInt32(2),
                        neto = res.GetDouble(3),
                        idNTIntermedio = res.GetInt32(4),
                        mtsRemanentesRollo = res.GetInt32(5),
                    };
                    bobinas.Add(bobina);
                }
                conexion.Close();

            }

            return bobinas;
        }

        public IList<string> buscarOp(string orden, string codigo)
        {
            IList<string> datos = new List<string>();
            string mySqlQuery = "select ct.Razon_Social, c.Ancho, c.Largo, c.Espesor, c.Tipo, c.Soldadura, c.Maquina, pc.Cantidad_Bolsa_conf, pc.NumeroORden, pc.CodigoOrden, pc.FechaEntrega, pc.CantidadDeproduccion, c.BolsasPorPaquete  " +
                "from Produccion_Confeccion pc join confeccion c on pc.CodigoOrden = c.idCodigo join clientes_total ct on ct.num_cliente = c.numeroCliente " +
                "where NumeroOrden = @cmdOrder and CodigoOrden = @cmdCodigo;";

            using (var command = new MySqlCommand(mySqlQuery, conexion))
            {
                command.Parameters.Add("@cmdOrder", MySqlDbType.String).Value = orden;
                command.Parameters.Add("@cmdCodigo", MySqlDbType.String).Value = codigo;

                command.CommandType = CommandType.Text;
                conexion.Open();
                var res = command.ExecuteReader();

                if (res.Read())
                {

                    datos.Add(res.GetString(0));
                    datos.Add(res.GetDouble(1).ToString());
                    var largo = res.GetDouble(2) / 100;
                    datos.Add(largo.ToString());
                    datos.Add(res.GetDouble(3).ToString());
                    datos.Add(res.GetString(4));
                    datos.Add(res.GetString(5));
                    datos.Add(res.GetString(6).ToString());
                    datos.Add(res.GetInt32(7).ToString());
                    datos.Add(res.GetInt32(8).ToString());
                    datos.Add(res.GetDouble(9).ToString());
                    datos.Add(res.GetDateTime(10).ToString());
                    datos.Add(res.GetInt32(11).ToString());
                    datos.Add(res.GetInt32(12).ToString());
                }
                conexion.Close();

            }

            return datos;
        }

        public int agregarBultos(Bulto b)
        {
            int res = -1;
            string mySqlQuery = "insert into bultos (Id_Orden, Num_Bulto, Creado, Legajo, Cant_Bolsas, IdOrigen1, IdOrigen2, IdOrigen3, SectorOrigen )" +
                "Values(@cmdIdOrden, @cmdNumBulto, current_timestamp, @cmdLegajo, @cmdCantBolsas, @cmdIdOrigen1, @cmdIdOrigen2, @cmdIdOrigen3, 'E' );" +
                "SELECT LAST_INSERT_ID();";

            using (var command = new MySqlCommand(mySqlQuery, conexion))
            {
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@cmdIdOrden", b.idOrden);
                command.Parameters.AddWithValue("@cmdNumBulto", b.numBulto);
                command.Parameters.AddWithValue("@cmdLegajo", b.legajo);
                command.Parameters.AddWithValue("@cmdCantBolsas", b.cantBolsas);
                command.Parameters.AddWithValue("@cmdIdOrigen1", b.idOrigen1);
                command.Parameters.AddWithValue("@cmdIdOrigen2", b.idOrigen2);
                command.Parameters.AddWithValue("@cmdIdOrigen3", b.idOrigen3);
                conexion.Open();
                res = Convert.ToInt32(command.ExecuteScalar());

                conexion.Close();
            }
            return res;

        }

        public int buscarUltimoBulto(int idOrden)
        {
            var numBulto = 0;
            string mySqlQuery = "select Num_Bulto " +
                "from bultos " +
                "where id_orden = @cmdIdOrder " +
                "order by Num_Bulto desc " +
                "limit 1;";

            using (var command = new MySqlCommand(mySqlQuery, conexion))
            {

                command.Parameters.Add("@cmdIdOrder", MySqlDbType.String).Value = idOrden;
                command.CommandType = CommandType.Text;
                conexion.Open();
                var res = command.ExecuteReader();

                if (res.Read())
                {
                    numBulto = res.GetInt32(0) + 1;
                }
                else numBulto = 1;

                conexion.Close();

            }

            return numBulto;
        }

        public bool sqlSimpleQuery(string sql)
        {
            var respuesta = false;

            using (var command = new MySqlCommand(sql, conexion))
            {
                conexion.Open();
                MySqlTransaction tran;
                tran = conexion.BeginTransaction();
                command.Transaction = tran;

                try
                {
                    command.CommandText = sql;
                    command.ExecuteNonQuery();

                    tran.Commit();
                    respuesta = true;
                }
                catch (Exception ex)
                {
                    respuesta = false;
                    Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                    Console.WriteLine("  Message: {0}", ex.Message);
                    try
                    {
                        tran.Rollback();
                    }
                    catch (Exception ex1)
                    {
                        Console.WriteLine("Rollback Exception Type: {0}", ex1.GetType());
                        Console.WriteLine("  Message: {0}", ex1.Message);

                    }
                }

                conexion.Close();
            }

            return respuesta;
        }

        public Bobina buscarBobina(string numBob, string codigo)
        {
            string mySqlQuery = "select e.indice, e.Rollo_Num, e.Longitud_Rollo, e.Neto, e.Id_NTIntermedio, e.metrosremanentes " +
                "from extrusiones e " +
                "where e.indice = @cmdNumBob and e.codigo = @cmdCodigo;";

            using (var command = new MySqlCommand(mySqlQuery, conexion))
            {
                Bobina bobina = new Bobina();
                command.Parameters.Add("@cmdNumBob", MySqlDbType.String).Value = numBob;
                command.Parameters.Add("@cmdCodigo", MySqlDbType.String).Value = codigo;
                command.CommandType = CommandType.Text;
                conexion.Open();
                var res = command.ExecuteReader();
                if (res.Read())
                {
                    bobina.indice = res.GetInt32(0);
                    bobina.numRollo = res.GetInt32(1);
                    bobina.longitudRollo = res.GetInt32(2);
                    bobina.neto = res.GetDouble(3);
                    bobina.idNTIntermedio = res.IsDBNull(res.GetOrdinal("Id_NTIntermedio")) ? 0 : res.GetInt32(4);
                    bobina.mtsRemanentesRollo = res.IsDBNull(res.GetOrdinal("metrosremanentes")) ? 0 : res.GetInt32(5);

                }
                conexion.Close();
                return bobina;
            }
        }

        internal int modificarBobina(string idBobina, string mtsModificados, string legajo)
        {
            var respuesta = -1;
            var modificadoPor = "Modificado por LEGAJO " + legajo + " El dia: " + DateTime.Now;
            string mySqlQuery = $"update extrusiones e set e.metrosremanentes = '{mtsModificados}', e.longitud_rollo = '{mtsModificados}', e.observaciones ='{modificadoPor}'" +
                $"where e.indice = '{idBobina}'; ";

            using (var command = new MySqlCommand(mySqlQuery, conexion))
            {
                command.CommandType = CommandType.Text;
                conexion.Open();
                respuesta = command.ExecuteNonQuery();
                conexion.Close();
            }

            return respuesta;
        }
    }
}
