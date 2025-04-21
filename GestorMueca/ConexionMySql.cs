using EtiquetadoBultos.Models;

using System;
using MySqlConnector;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows;

namespace EtiquetadoBultos
{
    public class ConexionMySql
    {
        // Sql connection
        MySqlConnection conexion = new MySqlConnection("server = 192.168.1.1; port=3306; userid=root; password=kamila; database=sistemaindustrial;");
        MySqlConnection conexionSanlufilm_db = new MySqlConnection("server = 192.168.1.1; port=3306; userid=root; password=kamila; database=sanlufilm_db;");
        string connectionString = "server = 192.168.1.1; port=3306; userid=root; password=kamila; database=sistemaindustrial;";
        internal List<ProtocoloItem> GetItemsPorMaquina(string maquina, string datosEntrantes)
        {
            List<ProtocoloItem> pis = new List<ProtocoloItem>();
            using (var conexion = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                conexion.Open();
                command.Connection = conexion;
                command.CommandText = $@"SELECT fi.id,fi.nombre,fi.unidad,fi.certifica,fi.constante,fi.simbolo,fi.posicion,fi.sector
                                        FROM formato_item fi 
                                        WHERE fi.maquina LIKE '%{maquina}%' AND fi.datos_entrantes LIKE '%{datosEntrantes}%';";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var esCertificado = reader[3] != DBNull.Value ? Convert.ToBoolean(reader.GetInt32(3)) : false;
                        ProtocoloItem pi = new ProtocoloItem
                        {
                            Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                            Nombre = reader.IsDBNull(1) ? "" : reader.GetString(1),
                            Medida = reader.IsDBNull(2) ? "Constante" : reader.GetString(2),
                            EsCertificado = esCertificado,
                            EsConstante = reader[4] != DBNull.Value ? Convert.ToBoolean(reader.GetInt32(4)) : false,
                            EsCertificadoSiNo = esCertificado ? "SI" : "NO",
                            Simbolo = reader.IsDBNull(5) ? "" : reader.GetString(5),
                            Posicion = reader.IsDBNull(6) ? 0 : reader.GetInt32(6),
                            Sector = reader.IsDBNull(7) ? "" : reader.GetString(7),
                        };
                        if (pi.Id == 9)
                        {
                            pi.EspecificacionDato = formEnsayoProduccion.instancia.espAncho.Medio + "±" + formEnsayoProduccion.instancia.espAncho.Maximo;
                        }
                        if (pi.Id == 7)
                        {
                            pi.EspecificacionDato = formEnsayoProduccion.instancia.espLargo.Medio + "±" + formEnsayoProduccion.instancia.espLargo.Maximo;
                        }
                        if (pi.Id == 14) {
                            pi.EspecificacionDato = Math.Round(Convert.ToDouble(formPrincipal.instancia.datosOp[13]) * 1000, 2) + "±" + "5";
                        }
                        pis.Add(pi);
                    }
                }
            }
            return pis;
        }
        internal List<OP> GetOps(string maquina)
        {
            List<OP> pis = new List<OP>();
            using (var conexion = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                conexion.Open();
                command.Connection = conexion;
                command.CommandText = @"SELECT cantidaddeproduccion,numeroOrden,codigoOrden,MaquinaAlternativa,cantidad_realizada,prioridadMaquina,fecha_cargado
                                        FROM produccion_confeccion
                                        WHERE (MaquinaAlternativa <> 'Terminada' AND MaquinaAlternativa=@pMaquina) AND (YEAR(fecha_cargado) = YEAR(CURDATE()) AND
										cantidad_bolsa_conf > cantidad_realizada)
										ORDER BY prioridadMaquina limit 10;";
                command.Parameters.Add("@pMaquina", MySqlDbType.String).Value = maquina;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        OP pi = new OP
                        {
                            CantProduccion = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                            Orden = reader.IsDBNull(1) ? 0 : reader.GetInt32(1),
                            Codigo = reader.IsDBNull(2) ? 0 : Convert.ToInt32(reader.GetDouble(2)),
                            Maquina = reader.IsDBNull(3) ? "" : reader.GetString(3),
                            Cantidad = reader.IsDBNull(4) ? 0 : Convert.ToInt32(reader.GetDouble(4)),
                            Prioridad = reader.IsDBNull(5) ? 0 : Convert.ToInt32(reader.GetDouble(5)),
                        };
                        pis.Add(pi);
                    }
                }
            }
            return pis;
        }
        internal List<Usuario> GetOperarios()
        {
            List<Usuario> us = new List<Usuario>();
            using (var conexion = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                conexion.Open();
                command.Connection = conexion;
                command.CommandText = @"SELECT u.idusuario,u.legajo, u.nombre, u.apellido, u.area
                                        FROM usuarios u 
                                        WHERE u.baja = 0 AND (u.Modulo_9Ext = 1 or u.Modulo_9Imp = 1) AND u.area <> 'Encargado' AND u.area not like '%jefe%' AND u.area not like '%Mantenimiento%';";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Usuario u = new Usuario
                        {
                            Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                            Legajo = reader.IsDBNull(1) ? 0 : reader.GetInt32(1),
                            Nombre = reader.IsDBNull(2) ? "" : reader.GetString(2),
                            Apellido = reader.IsDBNull(3) ? "" : reader.GetString(3),
                        };
                        us.Add(u);
                    }
                }
            }
            return us;
        }
        internal Especificacion GetFichaTecnicaConfeccionLargo(int idCodigo)
        {
            Especificacion esp = new Especificacion();

            using (var conexion = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                conexion.Open();
                command.Connection = conexion;
                command.CommandText = @"SELECT largo,largo_min,largo_max
                                        FROM confeccion 
                                        WHERE idcodigo = @pIdCodigo;";
                command.Parameters.Add("@pIdCodigo", MySqlDbType.Double).Value = idCodigo;
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        esp.Medio = reader.IsDBNull(0) ? 0.0 : reader.GetDouble(0) * 10;
                        esp.Minimo = reader.IsDBNull(1) ? 0.0 : reader.GetDouble(1) * 10;
                        esp.Maximo = reader.IsDBNull(2) ? 0.0 : reader.GetDouble(2) * 10;
                    }

                }

                return esp;
            }
        }

        internal Especificacion GetFichaTecnicaConfeccionAncho(int idCodigo)
        {
            Especificacion esp = new Especificacion();

            using (var conexion = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                conexion.Open();
                command.Connection = conexion;
                command.CommandText = @"SELECT ancho,ancho_min,ancho_max
                                        FROM confeccion 
                                        WHERE idcodigo = @pIdCodigo;";
                command.Parameters.Add("@pIdCodigo", MySqlDbType.Double).Value = idCodigo;
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        esp.Medio = reader.IsDBNull(0) ? 0.0 : reader.GetDouble(0) * 10;
                        esp.Minimo = reader.IsDBNull(1) ? 0.0 : reader.GetDouble(1) * 10;
                        esp.Maximo = reader.IsDBNull(2) ? 0.0 : reader.GetDouble(2) * 10;
                    }

                }

                return esp;
            }
        }

        internal Muestreo VerificarMuestreo(int idOrden, int aConfeccionar)
        {
            Muestreo m = new Muestreo();
            using (var conexion = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                conexion.Open();
                command.Connection = conexion;
                command.CommandText = @"SELECT count(id_op) AS valor FROM formato_ensayo WHERE id_op=@pIdOrden GROUP BY id_op;";
                command.Parameters.Add("@pIdOrden", MySqlDbType.Int32).Value = idOrden;
                var muestrasTotales = command.ExecuteScalar() != DBNull.Value ? Convert.ToInt32(command.ExecuteScalar()) : 0;

                command.CommandText = @"select muestras,desde,hasta,pedir_cada from cantidadmuestreo where @pCantidadDeBosasRequeridas between desde and hasta and sector = 'c';";
                command.Parameters.Add("@pCantidadDeBosasRequeridas", MySqlDbType.Int32).Value = aConfeccionar;
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        m.Requeridas = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                        m.Desde = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
                        m.Hasta = reader.IsDBNull(2) ? 0 : reader.GetInt32(2);
                        m.PedirCada = reader.IsDBNull(3) ? 0 : reader.GetInt32(3);
                        m.Realizadas = muestrasTotales;
                    }
                }
            }
            return m;
        }
        internal bool InsertParada(Parada p)
        {
            bool res = false;
            using (var conexion = new MySqlConnection(connectionString))
            {
                conexion.Open();
                using (var transaction = conexion.BeginTransaction())
                {
                    using (var command = conexion.CreateCommand())
                    {
                        command.Transaction = transaction;
                        try
                        {
                            command.CommandText = @"INSERT INTO paradasconfeccion(maquina,comienzo_hora,fin_hora,total_hora,operario_nombre,auxiliar,auxiliar2,auxiliar3,operador_mantenimiento,turno_encargado,motivo,rubro,liberacionsanitaria,observaciones,fecha_real,orden,codigo) 
                                                    VALUES (@pMaquina,@pInicio,@pFin,@pTotalHora,@pOperario,@pAuxiliar01,@pAuxiliar02,@pAuxiliar03,@pOperarioMantenimiento,@pEncargado,@pMotivo,@pRubro,@pLiberacion,@pObservacion,@pFechaReal,@pOrden,@pCodigo);";
                            command.Parameters.Add("@pMaquina", MySqlDbType.String).Value = p.Maquina;
                            command.Parameters.Add("@pInicio", MySqlDbType.Newdate).Value =p.FechaComienzo;
                            command.Parameters.Add("@pFin", MySqlDbType.Newdate).Value = p.FechaFin;
                            command.Parameters.Add("@pTotalHora", MySqlDbType.String).Value = p.TotalHora;
                            command.Parameters.Add("@pOperario", MySqlDbType.String).Value = p.OperarioNombre;
                            command.Parameters.Add("@pAuxiliar01", MySqlDbType.String).Value = p.Auxiliar01;
                            command.Parameters.Add("@pAuxiliar02", MySqlDbType.String).Value = p.Auxiliar02;
                            command.Parameters.Add("@pAuxiliar03", MySqlDbType.String).Value = p.Auxiliar03;
                            command.Parameters.Add("@pOperarioMantenimiento", MySqlDbType.String).Value = p.OperadorMantenimiento;
                            command.Parameters.Add("@pEncargado", MySqlDbType.String).Value = p.TurnoEncargado;
                            command.Parameters.Add("@pMotivo", MySqlDbType.String).Value = p.Motivo;
                            command.Parameters.Add("@pRubro", MySqlDbType.String).Value = p.Rubro;
                            command.Parameters.Add("@pLiberacion", MySqlDbType.Int32).Value = p.LiberacionSanitaria;
                            command.Parameters.Add("@pObservacion", MySqlDbType.String).Value = p.Observacion;
                            command.Parameters.Add("@pFechaReal", MySqlDbType.Newdate).Value = p.FechaReal;
                            command.Parameters.Add("@pOrden", MySqlDbType.String).Value = p.Orden;
                            command.Parameters.Add("@pCodigo", MySqlDbType.String).Value = p.Codigo;
                            if (command.ExecuteNonQuery() <= 0)
                            {
                                throw new Exception("Error al insertar ensayo");
                            }

                            transaction.Commit();
                            res = true;
                        }
                        catch (Exception)
                        {
                            transaction.Rollback();
                            res = false;
                        }
                    }
                }
            }
            return res;
        }

        internal List<Rubro> GetRubros()
        {
            List<Rubro> rbs = new List<Rubro>();
            using (var conexion = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                conexion.Open();
                command.Connection = conexion;
                command.CommandText = @"SELECT rubro FROM Rubro_Paradas WHERE confeccion = 1 ORDER BY rubro;";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Rubro r = new Rubro
                        {
                            Nombre = reader.IsDBNull(0) ? "" : reader.GetString(0),
                        };
                        rbs.Add(r);
                    }
                }
            }
            return rbs;
        }

        internal List<Maquina> GetMaquinas()
        {
            List<Maquina> pis = new List<Maquina>();
            using (var conexion = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                conexion.Open();
                command.Connection = conexion;
                command.CommandText = @"SELECT DISTINCT(MaquinaAlternativa)
                                        FROM produccion_confeccion;";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Maquina pi = new Maquina
                        {
                            Nombre = reader.IsDBNull(0) ? "" : reader.GetString(0),
                        };
                        pis.Add(pi);
                    }
                }
            }
            return pis;
        }

        internal List<Rubro> GetRubroDescripciones(string rubro)
        {
            List<Rubro> rbs = new List<Rubro>();
            using (var conexion = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                conexion.Open();
                command.Connection = conexion;
                command.CommandText = @"SELECT Motivos_Paradas.Motivos
                                        FROM Motivos_Paradas
                                        WHERE Motivos_Paradas.Rubro = @pRubro AND Motivos_Paradas.Confeccion=True;";
                command.Parameters.Add("@pRubro", MySqlDbType.String).Value = rubro;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Rubro r = new Rubro
                        {
                            Nombre = reader.IsDBNull(0) ? "" : reader.GetString(0),
                        };
                        rbs.Add(r);
                    }
                }
            }
            return rbs;
        }

        internal List<Usuario> GetEncargados()
        {
            List<Usuario> us = new List<Usuario>();
            using (var conexion = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                conexion.Open();
                command.Connection = conexion;
                command.CommandText = @"SELECT u.idusuario,u.legajo, u.nombre, u.apellido, u.area
                                        FROM usuarios u 
                                        WHERE u.baja = 0 AND (u.Modulo_9Ext = 1 or u.Modulo_9Imp = 1) AND (u.area = 'Encargado' Or u.area like '%jefe%');";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Usuario u = new Usuario
                        {
                            Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                            Legajo = reader.IsDBNull(1) ? 0 : reader.GetInt32(1),
                            Nombre = reader.IsDBNull(2) ? "" : reader.GetString(2),
                            Apellido = reader.IsDBNull(3) ? "" : reader.GetString(3),
                        };
                        us.Add(u);
                    }
                }
            }
            return us;
        }
        internal List<Usuario> GetOperariosMantenimiento()
        {
            List<Usuario> us = new List<Usuario>();
            using (var conexion = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                conexion.Open();
                command.Connection = conexion;
                command.CommandText = @"SELECT u.idusuario,u.legajo, u.nombre, u.apellido, u.area
                                        FROM usuarios u 
                                        WHERE u.area like '%Mantenimiento%';";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Usuario u = new Usuario
                        {
                            Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                            Legajo = reader.IsDBNull(1) ? 0 : reader.GetInt32(1),
                            Nombre = reader.IsDBNull(2) ? "" : reader.GetString(2),
                            Apellido = reader.IsDBNull(3) ? "" : reader.GetString(3),
                        };
                        us.Add(u);
                    }
                }
            }
            return us;
        }
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

        internal List<Bobina> buscarBobinasMuestreo(string orden, string codigo, string bobinaSector)
        {
            
            List<Bobina> bobinas = new List<Bobina>();
            using (var command = new MySqlCommand())
            {
                conexion.Open();
                command.Connection = conexion;

                if (bobinaSector == "e" | bobinaSector == "E")
                {
                    command.CommandText = @"select e.indice, e.orden, e.codigo, e.Rollo_Num, e.Longitud_Rollo, e.Neto, e.id_ntintermedio, e.metrosremanentes, e.pallets 
                                            from extrusiones e 
                                            where (orden = @pOrden and codigo = @pCodigo);";
                }
                if (bobinaSector == "i" | bobinaSector == "I")
                {
                    command.CommandText = @"select ipt.indice, ipt.orden, ipt.codigo, ipt.num_bobina, ipt.metros_bobina, ipt.peso_neto, ipt.id_ntintermedio, ipt.metrosremanentes, ipt.pallets
                                            from impresionesproductoterminado ipt 
                                            where (orden = @pOrden and codigo = @pCodigo);";
                }

                command.Parameters.Add("@pOrden", MySqlDbType.String).Value = orden;
                command.Parameters.Add("@pCodigo", MySqlDbType.String).Value = codigo;
                var res = command.ExecuteReader();

                if (bobinaSector == "e" | bobinaSector == "E")
                {
                    while (res.Read())
                    {
                        Bobina bobina = new Bobina
                        {
                            indice = res.GetInt32(0),
                            orden = res.GetString(1),
                            codigo = res.GetDouble(2),
                            numRollo = res.GetInt32(3),
                            longitudRollo = res.GetInt32(4),
                            neto = res.GetDouble(5),
                            idNTIntermedio = res["Id_NTIntermedio"] != DBNull.Value ? int.Parse(res["Id_NTIntermedio"].ToString()) : -1,
                            mtsRemanentesRollo = res["metrosremanentes"] != DBNull.Value ? int.Parse(res["metrosremanentes"].ToString()) : res.GetInt32(4),
                            numPallet = res["pallets"] != DBNull.Value ? int.Parse(res["pallets"].ToString()) : 0,
                        };
                        bobinas.Add(bobina);
                    }

                }
                if (bobinaSector == "i" | bobinaSector == "I")
                {
                    while (res.Read())
                    {
                        Bobina bobina = new Bobina
                        {
                            indice = res.GetInt32(0),
                            orden = res.GetInt32(1).ToString(),
                            codigo = double.Parse(res.GetInt32(2).ToString()),
                            numRollo = res.GetInt32(3),
                            longitudRollo = int.Parse(res.GetDouble(4).ToString()),
                            neto = res.GetDouble(5),
                            idNTIntermedio = res["Id_NTIntermedio"] != DBNull.Value ? int.Parse(res["Id_NTIntermedio"].ToString()) : -1,
                            mtsRemanentesRollo = res["metrosremanentes"] != DBNull.Value ? int.Parse(res["metrosremanentes"].ToString()) : int.Parse(res.GetDouble(4).ToString()),
                            numPallet = res["pallets"] != DBNull.Value ? int.Parse(res["pallets"].ToString()) : 0,
                        };
                        bobinas.Add(bobina);
                    }
                }
                conexion.Close();
            }

            return bobinas;
        }

        internal void buscarOpTW(string text1, string text2)
        {
            throw new NotImplementedException();
        }

        internal List<string> obtenerBolsasConfeccionadas(string orden, string codigo)
        {
            List<string> datos = new List<string>();
            string mySqlQuery = "select pc.cantidad_bolsa_conf, pc.cantidad_realizada from produccion_confeccion pc where pc.numeroorden =@cmdOrden and pc.codigoorden=@cmdCodigo;";

            using (var command = new MySqlCommand(mySqlQuery, conexion))
            {
                command.Parameters.Add("@cmdOrden", MySqlDbType.String).Value = orden;
                command.Parameters.Add("@cmdCodigo", MySqlDbType.String).Value = codigo;
                command.CommandType = CommandType.Text;
                conexion.Open();
                var res = command.ExecuteReader();
                if (res.Read())
                {
                    datos.Add(res["cantidad_bolsa_conf"] != DBNull.Value ? res["cantidad_bolsa_conf"].ToString() : "0");
                    datos.Add(res["cantidad_realizada"] != DBNull.Value ? res["cantidad_realizada"].ToString() : "0");
                }
                conexion.Close();
               
            }
            return datos;
        }

        internal string comprobarSector(string idOrden)
        {
            var resultado = "";
            using (var command = new MySqlCommand())
            {
                conexion.Open();
                command.Connection = conexion;
                command.CommandText = @"select idCodigo from impresion where idCodigo = @Orden;";
                command.Parameters.Add("@Orden", MySqlDbType.Double).Value = idOrden;
                var res = command.ExecuteScalar();
                if (res == null) resultado = "E";
                else resultado = "I";               
                conexion.Close();
            }
            return resultado;
        }

        internal int AgregarMuestra(int idBobina, string text1, string text2, DateTime now, object tag1, object tag2, object tag3,string idOP)
        {
            var respuesta = -1;
            using (var command = new MySqlCommand())
            {
                conexion.Open();
                command.Connection = conexion;

                command.CommandText = @"insert into muestra (id_bobina_muestrada,id_turno,ancho,largo,fechahora,prepicado,bloqueo,soldadura,idop,fueraderango)
                                                     values (444586,1697,@pAncho,@pLargo,current_timestamp,@pPrepicado,@pBloqueo,@pSoldadura,@pIdOp,0);";
                command.Parameters.Add("@pIdBobina", MySqlDbType.Int32).Value = idBobina;
                command.Parameters.Add("@pAncho", MySqlDbType.Double).Value = double.Parse(text1);
                command.Parameters.Add("@pLargo", MySqlDbType.Double).Value = int.Parse(text2);
                command.Parameters.Add("@pPrepicado", MySqlDbType.Int32).Value = int.Parse(tag1.ToString());
                command.Parameters.Add("@pBloqueo", MySqlDbType.Int32).Value = int.Parse(tag2.ToString());
                command.Parameters.Add("@pSoldadura", MySqlDbType.Int32).Value = int.Parse(tag3.ToString());
                command.Parameters.Add("@pIdOp", MySqlDbType.Int32).Value = int.Parse(idOP);

                var consuulta = command.CommandText.ToString();
                respuesta = command.ExecuteNonQuery();
                conexion.Close();
            }
            return respuesta;
        }

        internal string buscarMaquinaPorId(string idMaquina)
        {
            
            string mySqlQuery = "select maquina from ponderaciones where id_maquina = @cmdIdMaquina;";
            string maquina = "";
            using (var command = new MySqlCommand(mySqlQuery, conexion))
            {
                command.Parameters.Add("@cmdIdMaquina", MySqlDbType.String).Value = idMaquina;
                command.CommandType = CommandType.Text;
                conexion.Open();
                var res = command.ExecuteReader();
                if (res.Read())
                {
                    maquina = res["maquina"] != DBNull.Value ? res["maquina"].ToString() : "Otra";
                }
                conexion.Close();
                return maquina;
            }
        }

        internal int modificarCantidadConfeccionada(List<string> datos)
        {
            var respuesta = -1;

            using (var command = new MySqlCommand())
            {
                conexion.Open();
                command.Connection = conexion;  
                command.CommandText = @"update produccion_confeccion pc set pc.cantidad_realizada = pc.cantidad_realizada + @CantBolsas 
                                        where pc.numeroorden = @Orden and pc.codigoorden = @Codigo;";
                command.Parameters.Add("@CantBolsas", MySqlDbType.Int32).Value = datos[6];
                command.Parameters.Add("@Orden", MySqlDbType.Int32).Value = datos[0];
                command.Parameters.Add("@Codigo", MySqlDbType.Int32).Value = datos[1];
                respuesta = command.ExecuteNonQuery();
                
                //Insert Confecciones
                command.CommandText = @"insert into confecciones (Fecha_Cargado,Orden,Codigo,Razon_Social_Confeccion,Ancho,Espesor,Largo,Cantidad_Bolsa,Operador,Auxiliar,Auxiliar2,Encargado,Metros_Bolsas,Confeccionadora,Fecha_Entrega)
                                        values (CURRENT_TIMESTAMP,@Orden,@Codigo,@Razon,@Ancho,@Espesor,@Largo,@CantBolsas,@Operador,@Auxiliar,@Auxiliar2,@Encargado,@MetroBolsas,@Maquina,@Entrega);";
                command.Parameters.Add("@Razon", MySqlDbType.String).Value = datos[2];
                command.Parameters.Add("@Ancho", MySqlDbType.Double).Value = double.Parse(datos[3]);
                command.Parameters.Add("@Espesor", MySqlDbType.Int32).Value = int.Parse(datos[4]);
                command.Parameters.Add("@Largo", MySqlDbType.String).Value = double.Parse(datos[5]);
                command.Parameters.Add("@Operador", MySqlDbType.String).Value = datos[7];
                command.Parameters.Add("@Auxiliar", MySqlDbType.String).Value = datos[8];
                command.Parameters.Add("@Auxiliar2", MySqlDbType.String).Value = datos[9];
                command.Parameters.Add("@Encargado", MySqlDbType.String).Value = datos[10];
                command.Parameters.Add("@MetroBolsas", MySqlDbType.Double).Value = double.Parse(datos[11]);
                command.Parameters.Add("@Maquina", MySqlDbType.String).Value = datos[12];
                command.Parameters.Add("@Entrega", MySqlDbType.DateTime).Value = DateTime.Parse(datos[13]);
                var consuulta = command.CommandText.ToString();
                respuesta = command.ExecuteNonQuery();
                conexion.Close();
            }
            return respuesta;
        }

        internal int modificarBulto(string idBulto, string legajo, string cantBolsas)
        {           
            var respuesta = -1;
            var modificadoPor = "Modificado por " + legajo + " El dia: " + DateTime.Now+" en imprimir ip";
            string mySqlQuery = $"update bultos b set b.cant_bolsas = '{cantBolsas}', b.observacion = '{modificadoPor}'" +
                $"where b.id = '{idBulto}';";
            using (var command = new MySqlCommand(mySqlQuery, conexion))
            {
                command.CommandType = CommandType.Text;
                conexion.Open();
                respuesta = command.ExecuteNonQuery();
                conexion.Close();
            }
            return respuesta;
        }

        internal IList<Bulto> reEtiquetarBultos(int desde, int hasta, string idOrden)
        {
            IList<Bulto> bultosReEtiquetar = new List<Bulto>();
            string mySqlQuery = "select id, b.num_bulto, b.legajo, b.observacion, b.cant_bolsas from bultos b where num_bulto between @cmdDesde and @cmdHasta and id_orden = @cmdIdOrden;";
            using (var command = new MySqlCommand(mySqlQuery, conexion))
            {
                command.Parameters.Add("@cmdDesde", MySqlDbType.String).Value = desde;
                command.Parameters.Add("@cmdHasta", MySqlDbType.String).Value = hasta;
                command.Parameters.Add("@cmdIdOrden", MySqlDbType.String).Value = idOrden;
                command.CommandType = CommandType.Text;
                conexion.Open();
                var res = command.ExecuteReader();
                while (res.Read())
                {

                    Bulto bulto = new Bulto
                    {
                        idBulto = res["id"] != DBNull.Value ? int.Parse(res["id"].ToString()) : 0,
                        numBulto = res["num_bulto"] != DBNull.Value ? int.Parse(res["num_bulto"].ToString()) : 0,
                        legajo = res["legajo"] != DBNull.Value ? res["legajo"].ToString() : "",
                        observacion = res["observacion"] != DBNull.Value ? res["observacion"].ToString() : "",
                        cantBolsas = res["cant_bolsas"] != DBNull.Value ? int.Parse(res["cant_bolsas"].ToString()) : 0,

                    };
                    bultosReEtiquetar.Add(bulto);
                }
                conexion.Close();

            }
            return bultosReEtiquetar;
        }

        internal object totalBolsasCreadas(string cantProduccion)
        {
            var cantBolsasCreadas = 0;
            string mySqlQuery = "select sum(cant_bolsas) as bolsas from bultos where id_orden = @cmdProduccion and estado = 1; ";

            using (var command = new MySqlCommand(mySqlQuery, conexion))
            {
                command.Parameters.Add("@cmdProduccion", MySqlDbType.String).Value = cantProduccion;
                command.CommandType = CommandType.Text;
                conexion.Open();
                var res = command.ExecuteReader();

                if (res.Read())
                {
                    cantBolsasCreadas = res["bolsas"] != DBNull.Value ? int.Parse(res["bolsas"].ToString()) : 0;
                }

                conexion.Close();

            }

            return cantBolsasCreadas;
        }

        internal IList<string> buscarEncargadosNomApe()
        {
            conexion.Open();
            IList<string> encargadosNomApe = new List<string>();

            using (var command = new MySqlCommand("select concat(Nombre,' ',Apellido) from usuarios where Baja=0 and (Modulo_9Ext=1 or Modulo_9Imp =1) and (area = 'Encargado' or area like '%jefe%') order by area desc;", conexion))
            {
                command.CommandType = CommandType.Text;
                var reader2 = command.ExecuteReader();
                while (reader2.Read())
                {
                    encargadosNomApe.Add(reader2.GetString(0));
                }
                conexion.Close();
            }

            return encargadosNomApe;
        }

        internal Muestreo VerificarMuestreo(string idOrden, string aConfeccionar)
        {
            Muestreo m = new Muestreo();
            using (var conexion = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                conexion.Open();
                command.Connection = conexion;
                command.CommandText = @"SELECT count(id_op) AS valor FROM formato_ensayo WHERE id_op=@pIdOrden GROUP BY id_op;";
                command.Parameters.Add("@pIdOrden", MySqlDbType.Int32).Value = idOrden;
                var muestrasTotales = command.ExecuteScalar() != DBNull.Value ? Convert.ToInt32(command.ExecuteScalar()) : 0;

                command.CommandText = @"select muestras,desde,hasta,pedir_cada from cantidadmuestreo where @pCantidadDeBosasRequeridas between desde and hasta and sector = 'c';";
                command.Parameters.Add("@pCantidadDeBosasRequeridas", MySqlDbType.Int32).Value = aConfeccionar;
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        m.Requeridas = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                        m.Desde = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
                        m.Hasta = reader.IsDBNull(2) ? 0 : reader.GetInt32(2);
                        m.PedirCada = reader.IsDBNull(3) ? 0 : reader.GetInt32(3);
                        m.Realizadas = muestrasTotales;
                    }
                }
            }
            return m;
        }

        internal int VerificarMuestreoRealizadas(string idOrden)
        {
            var muestrasTotales = 0;
            using (var conexion = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                conexion.Open();
                command.Connection = conexion;
                command.CommandText = @"SELECT count(id_op) AS valor FROM formato_ensayo WHERE id_op=@pIdOrden GROUP BY id_op;";
                command.Parameters.Add("@pIdOrden", MySqlDbType.Int32).Value = idOrden;
                muestrasTotales = command.ExecuteScalar() != DBNull.Value ? Convert.ToInt32(command.ExecuteScalar()) : 0;              
            }
            return muestrasTotales;
        }

        internal IList<Bulto> buscarBultos(string idOrden)
        {
            IList<Bulto> bultos = new List<Bulto>();
            string mySqlQuery = "select id, num_bulto, creado, cant_bolsas, idorigen1 from bultos where id_orden = @cmdIdOrden and idnt = -1 and estado <> 0;";

            using (var command = new MySqlCommand(mySqlQuery, conexion))
            {
                command.Parameters.Add("@cmdIdOrden", MySqlDbType.String).Value = idOrden;
                command.CommandType = CommandType.Text;
                conexion.Open();
                var res = command.ExecuteReader();


                while (res.Read())
                {
                    Bulto bulto = new Bulto
                    {
                        idBulto = res["id"] != DBNull.Value ? int.Parse(res["id"].ToString()) : 0,
                        numBulto = res["num_bulto"] != DBNull.Value ? int.Parse(res["num_bulto"].ToString()) : 0,
                        fechaCreado = res["creado"] != DBNull.Value ? DateTime.Parse(res["creado"].ToString()) : DateTime.Now,
                        cantBolsas = res["cant_bolsas"] != DBNull.Value ? int.Parse(res["cant_bolsas"].ToString()) : 0,
                        idOrigen1 = res["idorigen1"] != DBNull.Value ? int.Parse(res["idorigen1"].ToString()) : 0,
                    };
                    bultos.Add(bulto);            
                }
                conexion.Close();
            }

            return bultos;
        }

        internal IList<NtIp> buscarPalletsReImp(string op)
        {
            IList<NtIp> palletsNt = new List<NtIp>();
            string mySqlQuery = "select id, nt, o_p, ancho, espesor, largo, maquina, id_embalaje, pallets, bobinas, maquina, operario, creado, cant_bobinas, total_bolsas, peso_tarima_vacia, neto " +
                "from nt " +
                "where o_p = @cmdOP and iddeposito = 0 and recibidopartefinal <> 1;";

            using (var command = new MySqlCommand(mySqlQuery, conexion))
            {
                command.Parameters.Add("@cmdOP", MySqlDbType.String).Value = op;
                command.CommandType = CommandType.Text;
                conexion.Open();
                var res = command.ExecuteReader();


                while (res.Read())
                {
                    NtIp pallet = new NtIp
                    {
                        id = res["id"] != DBNull.Value ? int.Parse(res["id"].ToString()) : 0,
                        idNt = res["nt"] != DBNull.Value ? int.Parse(res["nt"].ToString()) : 0,
                        op = res["o_p"] != DBNull.Value ? res["o_p"].ToString() : "0",
                        ancho = res["ancho"] != DBNull.Value ? res["ancho"].ToString() : "0",
                        espesor = res["espesor"] != DBNull.Value ? res["espesor"].ToString() : "0",
                        maquina = res["maquina"] != DBNull.Value ? res["maquina"].ToString() : "0",
                        largo = res["largo"] != DBNull.Value ? res["largo"].ToString() : "0",
                        idEmbalaje = res["id_embalaje"] != DBNull.Value ? int.Parse(res["id_embalaje"].ToString()) : 0,
                        pallets = res["pallets"] != DBNull.Value ? int.Parse(res["pallets"].ToString()) : 0,
                        bobinas = res["bobinas"] != DBNull.Value ? res["bobinas"].ToString() : "Nada",
                        operario = res["operario"] != DBNull.Value ? res["operario"].ToString() : "Otros",
                        fechaCreado = res["creado"] != DBNull.Value ? res["creado"].ToString() : DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"),
                        cantBobinas = res["cant_bobinas"] != DBNull.Value ? int.Parse(res["cant_bobinas"].ToString()) : 0,
                        totalBolsas = res["total_bolsas"] != DBNull.Value ? int.Parse(res["total_bolsas"].ToString()) : 0,
                        pesoTarimaVacia = res["peso_tarima_vacia"] != DBNull.Value ? double.Parse(res["peso_tarima_vacia"].ToString()) : 0.0,
                        neto = res["neto"] != DBNull.Value ? double.Parse(res["neto"].ToString()) : 0.0,
                    };
                    palletsNt.Add(pallet);
                }
                conexion.Close();
            }
            return palletsNt;
        }

        internal IList<Bulto> buscarBultosPorIdPallet(string ip)
        {
            IList<Bulto> bultos = new List<Bulto>();
            string mySqlQuery = "select id, num_bulto, creado, cant_bolsas, idorigen1 from bultos where idnt = @cmdIp and estado <> 0;";
            using (var command = new MySqlCommand(mySqlQuery, conexion))
            {
                command.Parameters.Add("@cmdIp", MySqlDbType.Int32).Value = ip;
                command.CommandType = CommandType.Text;
                conexion.Open();
                var res = command.ExecuteReader();
                while (res.Read())
                {
                    Bulto bulto = new Bulto
                    {
                        idBulto = res["id"] != DBNull.Value ? int.Parse(res["id"].ToString()) : 0,
                        numBulto = res["num_bulto"] != DBNull.Value ? int.Parse(res["num_bulto"].ToString()) : 0,
                        fechaCreado = res["creado"] != DBNull.Value ? DateTime.Parse(res["creado"].ToString()) : DateTime.Now,
                        cantBolsas = res["cant_bolsas"] != DBNull.Value ? int.Parse(res["cant_bolsas"].ToString()) : 0,
                        idOrigen1 = res["idorigen1"] != DBNull.Value ? int.Parse(res["idorigen1"].ToString()) : 0,
                    };
                    bultos.Add(bulto);
                }
                conexion.Close();
            }
            return bultos;
        }

        internal IList<int> buscarBultosSoloNumero(string idOrden)
        {
            IList<int> bultosNum = new List<int>();
            string mySqlQuery = "select num_bulto from bultos where id_orden = @cmdIdOrden;";

            using (var command = new MySqlCommand(mySqlQuery, conexion))
            {
                command.Parameters.Add("@cmdIdOrden", MySqlDbType.String).Value = idOrden;
                command.CommandType = CommandType.Text;
                conexion.Open();
                var res = command.ExecuteReader();


                while (res.Read())
                {
                    bultosNum.Add(res["num_bulto"] != DBNull.Value ? int.Parse(res["num_bulto"].ToString()) : bultosNum.LastOrDefault()+1);
                }
                conexion.Close();
            }
            return bultosNum;
        }

        internal IList<int> buscarPallets(string op)
        {
            IList<int> numPallet = new List<int>();
            string mySqlQuery = "select pallets from nt where o_p = @cmdOp;";
            
            using (var command = new MySqlCommand(mySqlQuery, conexion))
            {
                command.Parameters.Add("@cmdOp", MySqlDbType.String).Value = op;
                command.CommandType = CommandType.Text;
                conexion.Open();
                var res = command.ExecuteReader();
                while (res.Read())
                {
                    numPallet.Add(res.GetInt32(0));
                }
                conexion.Close();
            }
            return numPallet;
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

        internal bool verificarContraseña(string nomApe, string pass)
        {
            var respuesta = false;
            string mySqlQuery = "select legajo from usuarios where concat(Nombre,' ',Apellido) = @cmdNomApe and password = @cmdPass;";

            using (var command = new MySqlCommand(mySqlQuery, conexion))
            {
                command.Parameters.Add("@cmdNomApe", MySqlDbType.String).Value = nomApe;
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

        internal IList<Bobina> buscarBobinas(string orden, string codigo, string sector)
        {
            string mySqlQuery = "";
            string sqlActualizarMtsRemanentesP1 = "update impresionesproductoterminado set metrosremanentes = (case";
            string sqlActualizarMtsRemanentesP2 = "where indice in (";

            if (sector == "e" | sector == "E")
            {
                mySqlQuery = "select e.indice, e.orden, e.codigo, e.Rollo_Num, e.Longitud_Rollo, e.Neto, e.id_ntintermedio, e.metrosremanentes, e.pallets " +
                 "from extrusiones e " +
                 "where (orden = @cmdOrder and codigo = @cmdCodigo) and metrosremanentes <> 0;";

            }
            if (sector == "i" | sector == "I")
            {
                mySqlQuery = "select ipt.indice, ipt.orden, ipt.codigo, ipt.num_bobina, ipt.metros_bobina, ipt.peso_neto, ipt.id_ntintermedio, ipt.metrosremanentes, ipt.pallets " +
                "from impresionesproductoterminado ipt " +
                "where (orden = @cmdOrder and codigo = @cmdCodigo) and (metrosremanentes <> 0 or metrosremanentes is null);";

            }

            IList<Bobina> bobinas = new List<Bobina>();
            
            using (var command = new MySqlCommand(mySqlQuery, conexion))
            {
                command.Parameters.Add("@cmdOrder", MySqlDbType.String).Value = orden;
                command.Parameters.Add("@cmdCodigo", MySqlDbType.String).Value = codigo;
                command.CommandType = CommandType.Text;
                conexion.Open();
                var res = command.ExecuteReader();

                if (sector == "e" | sector == "E")
                {
                    while (res.Read())
                    {                      
                        Bobina bobina = new Bobina
                        {
                            indice = res.GetInt32(0),
                            orden = res.GetString(1),
                            codigo = res.GetDouble(2),
                            numRollo = res.GetInt32(3),
                            longitudRollo = res.GetInt32(4),
                            neto = res.GetDouble(5),
                            idNTIntermedio = res["Id_NTIntermedio"] != DBNull.Value ? int.Parse(res["Id_NTIntermedio"].ToString()) : -1,
                            mtsRemanentesRollo = res["metrosremanentes"] != DBNull.Value ? int.Parse(res["metrosremanentes"].ToString()) : res.GetInt32(4),
                            numPallet = res["pallets"] != DBNull.Value ? int.Parse(res["pallets"].ToString()) : 0,
                        };
                        bobinas.Add(bobina);
                    }
                    conexion.Close();
                }
                if (sector == "i" | sector == "I")
                {                    
                    while (res.Read())
                    {
                        if (res["metrosremanentes"] == DBNull.Value) {
                            sqlActualizarMtsRemanentesP1 = sqlActualizarMtsRemanentesP1 + " when indice = " + res.GetInt32(0) + " then " + res.GetDouble(4);
                            sqlActualizarMtsRemanentesP2 = sqlActualizarMtsRemanentesP2 + res.GetInt32(0) + ",";
                        }

                        Bobina bobina = new Bobina
                        {
                            indice = res.GetInt32(0),
                            orden = res.GetInt32(1).ToString(),
                            codigo = double.Parse(res.GetInt32(2).ToString()),
                            numRollo = res.GetInt32(3),
                            longitudRollo = int.Parse(res.GetDouble(4).ToString()),
                            neto = res.GetDouble(5),
                            idNTIntermedio = res["Id_NTIntermedio"] != DBNull.Value ? int.Parse(res["Id_NTIntermedio"].ToString()) : -1,
                            mtsRemanentesRollo = res["metrosremanentes"] != DBNull.Value ? int.Parse(res["metrosremanentes"].ToString()) : int.Parse(res.GetDouble(4).ToString()),
                            numPallet = res["pallets"] != DBNull.Value ? int.Parse(res["pallets"].ToString()) : 0,
                        };
                        bobinas.Add(bobina);
                    }

                    sqlActualizarMtsRemanentesP1 = sqlActualizarMtsRemanentesP1 + " end) ";
                    sqlActualizarMtsRemanentesP2 = sqlActualizarMtsRemanentesP2.TrimEnd(',') + ");";
                    sqlActualizarMtsRemanentesP1 = sqlActualizarMtsRemanentesP1 + sqlActualizarMtsRemanentesP2;
                    var contador = sqlActualizarMtsRemanentesP1.Count();             
                    conexion.Close();
                    if (contador != 89) sqlSimpleQuery("", sqlActualizarMtsRemanentesP1);
                }                
                
            }

            return bobinas;
        }

        internal List<Bobina> buscarPalletBobinas(Bobina bobina, string sector)
        {
            string mySqlQuery = "";
            List<Bobina> bobinas = new List<Bobina>();
            if (sector == "e" | sector == "E")
            {
                mySqlQuery = "select e.indice, e.orden, e.codigo, e.Rollo_Num, e.Longitud_Rollo, e.Neto, e.Id_NTIntermedio, e.metrosremanentes, e.pallets " +
                "from extrusiones e " +
                "where (orden = @cmdOrder and codigo = @cmdCodigo) and pallets = @cmdPallet;";

            }
            if (sector == "i" | sector == "I")
            {
                mySqlQuery = "select ipt.indice,ipt.orden, ipt.codigo, ipt.num_bobina, ipt.metros_bobina, ipt.peso_neto, ipt.id_ntintermedio, ipt.metrosremanentes, ipt.pallets " +
                "from impresionesproductoterminado ipt " +
                "where (orden = @cmdOrder and codigo = @cmdCodigo) and pallets = @cmdPallet;";

            }


            using (var command = new MySqlCommand(mySqlQuery, conexion))
            {
                command.Parameters.Add("@cmdOrder", MySqlDbType.String).Value = bobina.orden;
                command.Parameters.Add("@cmdCodigo", MySqlDbType.String).Value = bobina.codigo;
                command.Parameters.Add("@cmdPallet", MySqlDbType.String).Value = bobina.numPallet;

                command.CommandType = CommandType.Text;
                conexion.Open();
                var res = command.ExecuteReader();
                if (sector == "e" | sector == "E")
                {
                    while (res.Read())
                    {
                        Bobina bobinaPallet = new Bobina
                        {
                            indice = res.GetInt32(0),
                            orden = res.GetString(1),
                            codigo = res.GetDouble(2),
                            numRollo = res.GetInt32(3),
                            longitudRollo = res.GetInt32(4),
                            neto = res.GetDouble(5),
                            idNTIntermedio = res["Id_NTIntermedio"] != DBNull.Value ? int.Parse(res["Id_NTIntermedio"].ToString()) : -1,
                            mtsRemanentesRollo = res["metrosremanentes"] != DBNull.Value ? int.Parse(res["metrosremanentes"].ToString()) : res.GetInt32(4),
                            numPallet = res["pallets"] != DBNull.Value ? int.Parse(res["pallets"].ToString()) : 0,
                        };
                        bobinas.Add(bobinaPallet);
                    }
                }
                if (sector == "i" | sector == "I")
                {
                    while (res.Read())
                    {
                        Bobina bobinaPallet = new Bobina
                        {
                            indice = res.GetInt32(0),
                            orden = res.GetInt32(1).ToString(),
                            codigo = double.Parse(res.GetInt32(2).ToString()),
                            numRollo = res.GetInt32(3),
                            longitudRollo = int.Parse(res.GetDouble(4).ToString()),
                            neto = res.GetDouble(5),
                            idNTIntermedio = res["Id_NTIntermedio"] != DBNull.Value ? int.Parse(res["Id_NTIntermedio"].ToString()) : -1,
                            mtsRemanentesRollo = res["metrosremanentes"] != DBNull.Value ? int.Parse(res["metrosremanentes"].ToString()) : int.Parse(res.GetDouble(4).ToString()),
                            numPallet = res["pallets"] != DBNull.Value ? int.Parse(res["pallets"].ToString()) : 0,
                        };
                        bobinas.Add(bobinaPallet);
                    }
                }
                conexion.Close();

            }
            return bobinas;
        }

        public int agregarNtIp(NtIp t)
        {
            int idNt = -1;
            string sql = "insert into nt (nt, cliente, o_p, pallets, bobinas, ancho, espesor, maquina, operario, cantidad, creado, cant_bobinas, sector, largo, total_bolsas, peso_tarima_vacia, codigo, teorico_minimo, teorico_nominal, teorico_maximo, version, revision, id_embalaje, embalaje_fecha, neto, iddeposito, metros) " +
                "values(@cmdIdNt, @cmdCliente, @cmdOP, @cmdPallets, @cmdBobinas, @cmdAncho, @cmdEspesor, @cmdMaquina, @cmdOperario, @cmdCantidad, @cmdCreado, @cmdCantBobinas, @cmdSector, @cmdLargo, @cmdTotalBolsas, @cmdPesoTarima, @cmdCodigo, @cmdTeoricoMin, @cmdTeoricoNom, @cmdTeoricoMax, @cmdVersion, @cmdRevision, @cmdIdEmbalaje, @cmdFechaEmbalaje, @cmdNeto, @cmdDeposito, @cmdMetros); " +
                "select last_insert_id();"; //devuelve el id insertado

            using (var command = new MySqlCommand(sql, conexion))
            {
                
                command.Parameters.AddWithValue("@cmdIdNt", t.idNt);
                command.Parameters.AddWithValue("@cmdCliente", t.cliente);
                command.Parameters.AddWithValue("@cmdOP", t.op);
                command.Parameters.AddWithValue("@cmdPallets", t.pallets);
                command.Parameters.AddWithValue("@cmdBobinas", t.bobinas);
                command.Parameters.AddWithValue("@cmdAncho", t.ancho);
                command.Parameters.AddWithValue("@cmdEspesor", t.espesor);
                command.Parameters.AddWithValue("@cmdMaquina", t.maquina);
                command.Parameters.AddWithValue("@cmdOperario", t.operario);
                command.Parameters.AddWithValue("@cmdCantidad", t.cantidad);
                command.Parameters.AddWithValue("@cmdCreado", t.fechaCreado);
                command.Parameters.AddWithValue("@cmdCantBobinas", t.cantBobinas);
                command.Parameters.AddWithValue("@cmdSector", t.sector);
                command.Parameters.AddWithValue("@cmdLargo", t.largo);
                command.Parameters.AddWithValue("@cmdTotalBolsas", t.totalBolsas);
                command.Parameters.AddWithValue("@cmdPesoTarima", t.pesoTarimaVacia);
                command.Parameters.AddWithValue("@cmdCodigo", t.codigo);
                command.Parameters.AddWithValue("@cmdTeoricoMin", t.teoricoMinimo);
                command.Parameters.AddWithValue("@cmdTeoricoNom", t.teoricoNominal);
                command.Parameters.AddWithValue("@cmdTeoricoMax", t.teoricoMaximo);
                command.Parameters.AddWithValue("@cmdVersion", t.version);
                command.Parameters.AddWithValue("@cmdRevision", t.revision);
                command.Parameters.AddWithValue("@cmdIdEmbalaje", t.idEmbalaje);
                command.Parameters.AddWithValue("@cmdFechaEmbalaje", t.embalajeFecha);
                command.Parameters.AddWithValue("@cmdNeto", t.neto);
                command.Parameters.AddWithValue("@cmdDeposito", t.idDeposito);
                command.Parameters.AddWithValue("@cmdMetros", t.metros);

                command.CommandType = CommandType.Text;

                conexion.Open();
                idNt = Convert.ToInt32(command.ExecuteScalar());
                conexion.Close();
            }


            return idNt;
        }

        internal List<int> GetProximoMayor(int bolsas)
        {
            var res = new List<int>();
            try
            {

                conexionSanlufilm_db.Open();
                using (var command = conexionSanlufilm_db.CreateCommand())
                {
                    command.CommandText = @"SELECT * FROM muestreoconfeccion WHERE id = COALESCE(
                                                (SELECT id FROM muestreoconfeccion WHERE bulto = @pBulto AND col1 IS NOT NULL),
                                                (SELECT id FROM muestreoconfeccion WHERE bulto > @pBulto AND col1 IS NOT NULL ORDER BY id LIMIT 1));";
                    command.Parameters.Add("@pBulto", MySqlDbType.Int32).Value = bolsas;
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                res.Add(reader.IsDBNull(i) ? 0 : reader.GetInt32(i));
                            }
                        }
                    }
                }
                conexionSanlufilm_db.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return res;
        }
      

        internal bool InsertEnsayoLote(List<ItemValor> valores, ProtocoloItem pi)
        {
            bool res = false;
            using (var conexion = new MySqlConnection(connectionString))
            {
                conexion.Open();
                using (var transaction = conexion.BeginTransaction())
                {
                    using (var command = conexion.CreateCommand())
                    {
                        command.Transaction = transaction;
                        try
                        {
                            command.CommandText = @"INSERT INTO formato_ensayo (creado,turno,id_op,id_nt,legajo,paquete_numero) 
                                                                        VALUES (@pCreado,@pTurno,@pIdOp,@pIdNt,@pLegajo,@pPaqueteNum); SELECT LAST_INSERT_ID();";
                            command.Parameters.Add("@pCreado", MySqlDbType.Newdate).Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            command.Parameters.Add("@pTurno", MySqlDbType.String).Value = pi.Turno;
                            command.Parameters.Add("@pIdOp", MySqlDbType.String).Value = pi.OP;
                            command.Parameters.Add("@pIdNt", MySqlDbType.Int32).Value = 0;
                            command.Parameters.Add("@pLegajo", MySqlDbType.Int32).Value = pi.Legajo;
                            command.Parameters.Add("@pPaqueteNum", MySqlDbType.Int32).Value = pi.PaqueteNum;

                            var ultimoID = Convert.ToInt32(command.ExecuteScalar());

                            if (ultimoID <= 0)
                            {
                                throw new Exception("Error al insertar ensayo");
                            }
                            command.CommandText = QryInsertarEnsayo(valores, ultimoID);

                            if (command.ExecuteNonQuery() <= 0)
                            {
                                throw new Exception("Error al insertar ensayo");
                            }

                            transaction.Commit();
                            res = true;
                        }
                        catch (Exception)
                        {
                            transaction.Rollback();
                            res = false;
                        }
                    }
                }
            }
            return res;
        }

        internal string QryInsertarEnsayo(List<ItemValor> valores, int idEnsayo)
        {
            string sqlInsertarProtocoloItem = "INSERT INTO formato_item_valor (id_item,valor,valor_constante,id_bobina_madre,id_ensayo) VALUES ";
            string sqlInsertarProtocoloItem2 = "";

            foreach (ItemValor item in valores)
            {
                sqlInsertarProtocoloItem2 = sqlInsertarProtocoloItem2 + $"('{item.IdItem}','{item.Valor}','{item.ValorConstante}','{item.IdBobinaMadre}','{idEnsayo}'),";
            }
            sqlInsertarProtocoloItem2 = sqlInsertarProtocoloItem2.TrimEnd(',') + ";";
            sqlInsertarProtocoloItem = sqlInsertarProtocoloItem + sqlInsertarProtocoloItem2;

            return sqlInsertarProtocoloItem;
        }

        public IList<string> buscarOp(string orden, string codigo)
        {
            //cambiar
            IList<string> datos = new List<string>();
            var numCliente = "";
            var numVersion = 0;
            string mySqlQuery = "select ct.Razon_Social, c.Ancho, c.Largo, c.Espesor, c.Tipo, c.Soldadura, c.Maquina, pc.Cantidad_Bolsa_conf, pc.NumeroORden, pc.CodigoOrden, pc.FechaEntrega, pc.CantidadDeproduccion, c.BolsasPorPaquete, c.Peso_Millar , pc.cantidad_realizada, c.id_embalaje, num_cliente,pc.version " +
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
                    datos.Add(res["Razon_Social"] != DBNull.Value ? res["Razon_Social"].ToString() : "Sin Razon"); //Razon social
                    datos.Add(res.GetDouble(1).ToString()); //Ancho
                    var largo = res.GetDouble(2) / 100; //Largo
                    datos.Add(largo.ToString()); 
                    datos.Add(res.GetDouble(3).ToString()); //Espesor
                    datos.Add(res.GetString(4)); //Tipo
                    datos.Add(res[5] != DBNull.Value ? res.GetString(5) : "NA"); //Soldadura
                    datos.Add(res["Maquina"] != DBNull.Value ? res["Maquina"].ToString() : "Otra"); //Lugar6-Maquina
                    datos.Add(res.GetInt32(7).ToString()); //Cantidad_Bolsa_conf
                    datos.Add(res.GetInt32(8).ToString()); //NumeroORden
                    datos.Add(res.GetDouble(9).ToString()); //CodigoOrden
                    datos.Add(res.GetDateTime(10).ToString()); //FechaEntrega
                    datos.Add(res.GetInt32(11).ToString()); //CantidadDeproduccion              
                    datos.Add(res["BolsasPorPaquete"] != DBNull.Value ? res["BolsasPorPaquete"].ToString() : "0"); //BolsasPorPaquete
                    var pesoMillar = res.GetDouble(13) / 1000;
                    datos.Add(pesoMillar.ToString()); //Peso_Millar
                    datos.Add(res.GetDouble(14).ToString()); //CantidadRealizada
                    datos.Add(res.GetInt32(15).ToString()); //IdEmbalaje
                    numCliente = res.GetInt32(16).ToString();
                    numVersion = Convert.ToInt32(res.GetInt32(17).ToString());
                }
                conexion.Close();
                if (datos.Count != 0) {
                    var datosExtrusion = artCliente(datos[9]);
                    var datosExcedentes = excedente(numCliente);
                    datos.Add(datosExtrusion[0]); //[16]ArtCliente    
                    datos.Add(datosExtrusion[1]); //[17]IdTipo
                    datos.Add(numCliente); //[18]numero de cliente
                    datos.Add(datosExcedentes[0]);//[19]excedenteMin
                    datos.Add(datosExcedentes[1]);//[20]excedenteMax
                    datos.Add(numVersion.ToString());  //VERSION

                }
            }
            return datos;
        }

        private List<string> excedente(string numCliente)
        {
            var excedenteMinMax = new List<string>();
            conexion.Open();
            using (var command = new MySqlCommand())
            {
                command.Connection = conexion;               
                command.CommandText = @"select excedente_min,excedente_max from ficha_logistica where num_cliente = @cmdNumCliente;";
                command.Parameters.Add("@cmdNumCliente", MySqlDbType.Int32).Value = numCliente;
                var res = command.ExecuteReader();
                if (res.Read())
                {
                    excedenteMinMax.Add(!res.IsDBNull(0) ? res.GetInt32(0).ToString() : "0");
                    excedenteMinMax.Add(!res.IsDBNull(1) ? res.GetInt32(1).ToString() : "0");
                }
                conexion.Close();
            }
            return excedenteMinMax;
        }

        private List<string> artCliente(string idOrden)
        {
            var datos = new List<string>();
            string mySqlQuery = "select numero_art_cliente, idtipo from extrusion e where e.idcodigo = @cmdIdOrden;";
            using (var command = new MySqlCommand(mySqlQuery, conexion))
            {
                command.Parameters.Add("@cmdIdOrden", MySqlDbType.String).Value = idOrden;
                command.CommandType = CommandType.Text;
                conexion.Open();
                var res = command.ExecuteReader();

                if (res.Read())
                {
                   datos.Add(res["numero_art_cliente"] != DBNull.Value ? res["numero_art_cliente"].ToString() : "0");
                   datos.Add(res.GetInt32(1).ToString());//Fungible embalaje_p; 
                }

                conexion.Close();

            }

            return datos;
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

        public int buscarUltimoNtIntermedio()
        {
            var idNtIntermedio = 0;
            string mySqlQuery = "select max(nt) from nt;";

            using (var command = new MySqlCommand(mySqlQuery, conexion))
            {
                conexion.Open();
                idNtIntermedio = Convert.ToInt32(command.ExecuteScalar())+1;
                conexion.Close();

            }

            return idNtIntermedio;
        }

        public List<Insumo> buscarEmbalajeInsumos(string idEmbalaje)
        {
            List<Insumo> insumos = new List<Insumo>();
            string mySqlQuery = "select ei.descripcion as insumo, um.descripcion as unidad " +
                "from embalaje_p ep join embalaje_c ec on ep.id = ec.id_embalaje join embalaje_i ei on ec.id_insumo = ei.id join (costoembalaje ce join unidadmedida um on ce.id_unidadmedida = um.id_unidadmedida) on ei.id = ce.id " +
                "where ep.num_ee = @cmdIdEmbalaje and ep.ultima = 1 and ei.nomostraridentificacionpallets = 0; ";

            using (var command = new MySqlCommand(mySqlQuery, conexion))
            {
                command.Parameters.Add("@cmdIdEmbalaje", MySqlDbType.String).Value = idEmbalaje;
                command.CommandType = CommandType.Text;
                conexion.Open();
                var res = command.ExecuteReader();

                while (res.Read())
                {
                    Insumo insumo = new Insumo
                    {
                        nombre = res["insumo"] != DBNull.Value ? res["insumo"].ToString() : "",
                        unidad = res["unidad"] != DBNull.Value ? res["unidad"].ToString() : "",
                    };
                    insumos.Add(insumo);

                }

                conexion.Close();
            }

            return insumos;
        }

        public List<string> buscarEmbalajeFichaTecnica(string idEmbalaje)
        {
            var embalajeDatosFicha = new List<string>();
            string mySqlQuery = "select ep.descripcion, ep.disposicion, ep.pallets_min_min, ep.pallets_min_max, ep.pallets_med_min, ep.pallets_med_max, ep.fungible, ei.descripcion as Insumo, ec.minimo, ec.medio, ec.maximo, um.descripcion as Unidad " +
                "from embalaje_p ep join embalaje_c ec on ep.id = ec.id_embalaje join embalaje_i ei on ec.id_insumo = ei.id join (costoembalaje ce join unidadmedida um on ce.id_unidadmedida = um.id_unidadmedida) on ei.id = ce.id " +
                "where ep.num_ee = @cmdIdEmbalaje and ep.ultima = 1 and ei.nomostraridentificacionpallets = 0;";

            using (var command = new MySqlCommand(mySqlQuery, conexion))
            {
                command.Parameters.Add("@cmdIdEmbalaje", MySqlDbType.String).Value = idEmbalaje;
                command.CommandType = CommandType.Text;
                conexion.Open();
                var res = command.ExecuteReader();

                while (res.Read())
                {
                    if (embalajeDatosFicha.Count==0) {
                        embalajeDatosFicha.Add(res.GetString(0));//Descripcion embalaje_p;
                        embalajeDatosFicha.Add(res.GetString(1));//Disposicion embalaje_p;
                        embalajeDatosFicha.Add(res.GetInt32(2).ToString());//PalletMinMin embalaje_p;
                        embalajeDatosFicha.Add(res.GetInt32(3).ToString());//PalletMinMax embalaje_p;
                        embalajeDatosFicha.Add(res.GetInt32(4).ToString());//PalletMedMin embalaje_p;
                        embalajeDatosFicha.Add(res.GetInt32(5).ToString());//PalletMedMax embalaje_p;
                        embalajeDatosFicha.Add(res.GetDouble(6).ToString());//Fungible embalaje_p;
                        embalajeDatosFicha.Add(res.GetDouble(8).ToString());//Embalaje_c minimo;
                        embalajeDatosFicha.Add(res.GetDouble(9).ToString());//Embalaje_c medio;
                        embalajeDatosFicha.Add(res.GetDouble(10).ToString());//Embalaje_c maximo;
                        embalajeDatosFicha.Add(res.GetString(11));//Unidad;
                    }
                }

                conexion.Close();
            }

            return embalajeDatosFicha;
        }

        public List<string> buscarEmbalajeFichaTecnicaDescripcion(string idEmbalaje)
        {
            var embalajeDescripcion = new List<string>();
            string mySqlQuery = "select ep.descripcion " +
                "from embalaje_p ep " +
                "where ep.num_ee = @cmdIdEmbalaje and ep.ultima = 1";

            using (var command = new MySqlCommand(mySqlQuery, conexion))
            {
                command.Parameters.Add("@cmdIdEmbalaje", MySqlDbType.String).Value = idEmbalaje;
                command.CommandType = CommandType.Text;
                conexion.Open();
                var res = command.ExecuteReader();

                if (res.Read())
                {
                    embalajeDescripcion.Add(res.GetString(0));//Descripcion embalaje_p;
                }

                conexion.Close();
            }

            return embalajeDescripcion;
        }

        public List<string> buscarEmbalaje(string idCodigo)
        {
            var embalajeDatos = new List<string>();
            string mySqlQuery = "select ep.num_ee, ep.modificada from confeccion c join embalaje_p ep on c.id_embalaje = ep.num_ee " +
                "where c.idcodigo = @cmdIdCodigo and ep.ultima = true; ";

            using (var command = new MySqlCommand(mySqlQuery, conexion))
            {
                command.Parameters.Add("@cmdIdCodigo", MySqlDbType.String).Value = idCodigo;
                command.CommandType = CommandType.Text;
                conexion.Open();
                var res = command.ExecuteReader();

                if (res.Read())
                {
                    embalajeDatos.Add(res.GetInt32(0).ToString());
                    embalajeDatos.Add(res.GetDateTime(1).ToString("dd/MM/yyyy HH:mm:ss"));
                }
                conexion.Close();
            }

            return embalajeDatos;
        }

        public List<string> buscarExtrusion(string idCodigo)
        {
            var extrusionDatos = new List<string>();
            string mySqlQuery = "select e.descripcion, e.version, e.revision, mf.densidad, e.tipo, e.peso_mts_teorico, e.peso_mts_teorico_min, e.peso_mts_teorico_max " +
                "from extrusion e join mat_formulas mf on e.codigo_asociado_material = mf.codigo_asociado_material where e.idcodigo = @cmdIdCodigo;";

            using (var command = new MySqlCommand(mySqlQuery, conexion))
            {
                command.Parameters.Add("@cmdIdCodigo", MySqlDbType.String).Value = idCodigo;
                command.CommandType = CommandType.Text;
                conexion.Open();
                var res = command.ExecuteReader();

                if (res.Read())
                {
                    //double? densidad = res.IsDBNull(3) ? 0.922 : res.GetInt32(3);//Densidad
                    extrusionDatos.Add(res.GetString(0).ToString());//Descripcion
                    extrusionDatos.Add(res.GetInt32(1).ToString());//Version
                    extrusionDatos.Add(res.GetInt32(2).ToString());//Revision
                    extrusionDatos.Add(res.GetDouble(3).ToString());//Densidad
                    extrusionDatos.Add(res.GetString(4).ToString());//Tipo
                    extrusionDatos.Add(res.GetDouble(5).ToString());//PesoMtsTeorico
                    extrusionDatos.Add(res.GetDouble(6).ToString());//PesoMtsTeoricoMin
                    extrusionDatos.Add(res.GetDouble(7).ToString());//PesoMtsTeoricoMax
                }
                conexion.Close();
            }

            return extrusionDatos;
        }

        internal int UpdateBultosMuestreo(string qry1)
        {
            using (var conexion = new MySqlConnection(connectionString))
            {
                conexion.Open();
                using (var command = conexion.CreateCommand())
                {
                    command.CommandText = qry1;
                    return command.ExecuteNonQuery();
                }
            }
        }

        public bool sqlSimpleQuery(string sql01, string sql02)
        {
            conexion.Open();

            MySqlCommand command = conexion.CreateCommand();
            MySqlTransaction tran;
            tran = conexion.BeginTransaction();
            command.Connection = conexion;
            command.Transaction = tran;

            bool respuesta;
            try
            {
                if (sql01 != "" && sql02 != "")
                {
                    command.CommandText = sql01;
                    command.ExecuteNonQuery();

                    command.CommandText = sql02;
                    command.ExecuteNonQuery();
                }
                else if (sql01 == "")
                {
                    command.CommandText = sql02;
                    command.ExecuteNonQuery();
                }
                else
                {
                    command.CommandText = sql01;
                    command.ExecuteNonQuery();
                }


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


            return respuesta;
        }

        public Bobina buscarBobina(string numBob, string codigo, string sector)
        {
            string mySqlQuery = "";
            if (sector == "E" | sector == "e")
            {
                mySqlQuery = "select e.indice, e.orden, e.codigo, e.Rollo_Num, e.Longitud_Rollo, e.Neto, e.Id_NTIntermedio, e.metrosremanentes, e.pallets " +
                    "from extrusiones e " +
                    "where e.indice = @cmdNumBob and e.codigo = @cmdCodigo;";
            }
            if (sector == "I" | sector == "i")
            {
                mySqlQuery = "select ipt.indice,ipt.orden, ipt.codigo, ipt.num_bobina, ipt.metros_bobina, ipt.peso_neto, ipt.id_ntintermedio, ipt.metrosremanentes, ipt.pallets " +
                "from impresionesproductoterminado ipt " +
                "where ipt.indice = @cmdNumBob and ipt.codigo = @cmdCodigo;";
            }

            using (var command = new MySqlCommand(mySqlQuery, conexion))
            {
                Bobina bobina = new Bobina();
                command.Parameters.Add("@cmdNumBob", MySqlDbType.String).Value = numBob;
                command.Parameters.Add("@cmdCodigo", MySqlDbType.String).Value = codigo;
                command.CommandType = CommandType.Text;
                conexion.Open();
                var res = command.ExecuteReader();

                if (sector == "I" | sector == "i")
                {
                    if (res.Read())
                    {
                        bobina.indice = res.GetInt32(0);
                        bobina.orden = res.GetInt32(1).ToString();
                        bobina.codigo = double.Parse(res.GetInt32(2).ToString());
                        bobina.numRollo = res.GetInt32(3);
                        bobina.longitudRollo = int.Parse(res.GetDouble(4).ToString());
                        bobina.neto = res.GetDouble(5);
                        bobina.idNTIntermedio = res["Id_NTIntermedio"] != DBNull.Value ? int.Parse(res["Id_NTIntermedio"].ToString()) : -1;
                        bobina.mtsRemanentesRollo = res["metrosremanentes"] != DBNull.Value ? int.Parse(res["metrosremanentes"].ToString()) : int.Parse(res.GetDouble(4).ToString());
                        bobina.numPallet = res["pallets"] != DBNull.Value ? int.Parse(res["pallets"].ToString()) : 0;
                    }
                }
                if (sector == "E" | sector == "e")
                {

                    if (res.Read())
                    {
                        bobina.indice = res.GetInt32(0);
                        bobina.orden = res.GetString(1);
                        bobina.codigo = res.GetDouble(2);
                        bobina.numRollo = res.GetInt32(3);
                        bobina.longitudRollo = res.GetInt32(4);
                        bobina.neto = res.GetDouble(5);
                        bobina.idNTIntermedio = res["Id_NTIntermedio"] != DBNull.Value ? int.Parse(res["Id_NTIntermedio"].ToString()) : -1;
                        bobina.mtsRemanentesRollo = res["metrosremanentes"] != DBNull.Value ? int.Parse(res["metrosremanentes"].ToString()) : res.GetInt32(4);
                        bobina.numPallet = res["pallets"] != DBNull.Value ? int.Parse(res["pallets"].ToString()) : 0;
                    }

                }
                conexion.Close();
                return bobina;
            }
        }

        internal int modificarBobina(string idBobina, string mtsModificados, string legajo, string sector)
        {
            var respuesta = -1;
            string mySqlQuery = "";
            var modificadoPor = "Modificado por " + legajo + " El dia: " + DateTime.Now;
            if (sector == "E" | sector == "e")
            {
                mySqlQuery = $"update extrusiones e set e.metrosremanentes = '{mtsModificados}', e.longitud_rollo = '{mtsModificados}', e.observaciones ='{modificadoPor}'" +
                             $"where e.indice = '{idBobina}'; ";
            }

            if (sector == "I" | sector == "i")
            {
                mySqlQuery = $"update impresionesproductoterminado ipt set ipt.metrosremanentes = '{mtsModificados}', ipt.metros_bobina = '{mtsModificados}', ipt.observaciones ='{modificadoPor}'" +
                             $"where ipt.indice = '{idBobina}'; ";
            }
            
     
            using (var command = new MySqlCommand(mySqlQuery, conexion))
            {
                command.CommandType = CommandType.Text;
                conexion.Open();
                respuesta = command.ExecuteNonQuery();
                conexion.Close();
            }

            return respuesta;
        }

        internal int modificarBobinaSoloRemanentes(string idBobina, string mtsModificados, string legajo, string sector)
        {

            var respuesta = -1;
            var modificadoPor = "Modificado por " + legajo + " El dia: " + DateTime.Now;
            string mySqlQuery = "";

            if (sector == "E" | sector == "e")
            {
                mySqlQuery = $"update extrusiones e set e.metrosremanentes = '{mtsModificados}', e.observaciones ='{modificadoPor}'" +
                             $"where e.indice = '{idBobina}'; ";
            }

            if (sector == "I" | sector == "i")
            {
                mySqlQuery = $"update impresionesproductoterminado ipt set ipt.metrosremanentes = '{mtsModificados}', ipt.observaciones ='{modificadoPor}'" +
                             $"where ipt.indice = '{idBobina}'; ";
            }

            using (var command = new MySqlCommand(mySqlQuery, conexion))
            {
                command.CommandType = CommandType.Text;
                conexion.Open();
                respuesta = command.ExecuteNonQuery();
                conexion.Close();
            }

            return respuesta;
        }

        internal int comprobarTc(Bobina bob,string sector)
        {
            var totalMtsRemanentes = -1;
            string mySqlQuery = "";
            if (bob.indice != 0)
            {
                if (sector == "i" | sector == "I") {
                    mySqlQuery = "select sum(metrosremanentes) as suma from impresionesproductoterminado where pallets = @cmdPallet and orden = @cmdOrden and codigo = @cmdCodigo limit 1;";
                }
                if (sector == "e" | sector == "E")
                {
                    mySqlQuery = "select sum(metrosremanentes) as suma from extrusiones where pallets = @cmdPallet and orden = @cmdOrden and codigo = @cmdCodigo limit 1;";
                }

                using (var command = new MySqlCommand(mySqlQuery, conexion))
                {
                    conexion.Open();
                    command.Parameters.Add("@cmdPallet", MySqlDbType.Int16).Value = bob.numPallet;
                    command.Parameters.Add("@cmdOrden", MySqlDbType.String).Value = bob.orden;
                    command.Parameters.Add("@cmdCodigo", MySqlDbType.Double).Value = bob.codigo;
                    command.CommandType = CommandType.Text;
                    var mtsRemantes = command.ExecuteScalar();
                    if (mtsRemantes == DBNull.Value)
                    {
                        if (sector == "i" | sector == "I")
                        {
                            command.CommandText = @"select metros_bobina from impresionesproductoterminado where pallets = @cmdPallet and orden = @cmdOrden and codigo = @cmdCodigo limit 1;";
                        }
                        if (sector == "e" | sector == "E")
                        {
                            command.CommandText = @"select longitud_rollo from extrusiones where pallets = @cmdPallet and orden = @cmdOrden and codigo = @cmdCodigo limit 1;";
                        }
                        totalMtsRemanentes = int.Parse(command.ExecuteScalar().ToString());
                    }
                    else totalMtsRemanentes = int.Parse(mtsRemantes.ToString());
                    conexion.Close();
                }
            }
            return totalMtsRemanentes;                    
        }

        internal int bajaLogicaTc(int idNTIntermedio)
        {
            var respuesta = -1;
            string mySqlQuery = $"update nt_intermedio ntI set ntI.terminado = 1 where ntI.id = {idNTIntermedio};";

            using (var command = new MySqlCommand(mySqlQuery, conexion))
            {
                command.CommandType = CommandType.Text;
                conexion.Open();
                respuesta = command.ExecuteNonQuery();
                conexion.Close();
            }
            return respuesta;
        }

        internal int GetIdMaquina(string maqina)
        {
            using (var conexion = new MySqlConnection(connectionString))
            {
                conexion.Open();
                using (var command = conexion.CreateCommand())
                {
                    command.CommandText = "SELECT id FROM maquinas WHERE nombre =" + "'"+maqina+"'" + ";";
                    return command.ExecuteScalar() != DBNull.Value ? Convert.ToInt32(command.ExecuteScalar()) : 0;
                }
            }
        }
    }
}
