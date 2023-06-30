using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class procEmpleado
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly procEmpleado _instancia = new procEmpleado();
        //privado para evitar la instanciación directa
        public static procEmpleado Instancia
        {
            get
            {
                return procEmpleado._instancia;
            }
        }
        #endregion

        #region metodos
        ////////////////////listado de Cargos
        public List<entCargos> ListarCargos()
        {
            SqlCommand cmd = null;
            List<entCargos> lista = new List<entCargos>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("SELECT C.idCargo, C.nombre, C.descripcion, C.fecRegCargo, C.estCargo, C.idArea, A.nombre AS nombreArea FROM Cargos C INNER JOIN Area A ON C.idArea = A.idArea", cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCargos Cargo = new entCargos();
                    Cargo.idCargo = Convert.ToInt32(dr["idCargo"]);
                    Cargo.nombre = dr["nombre"].ToString();
                    Cargo.descripcion = dr["descripcion"].ToString();
                    Cargo.fecRegCargo = Convert.ToDateTime(dr["fecRegCargo"]);
                    Cargo.estCargo = Convert.ToBoolean(dr["estCargo"]);
                    Cargo.idArea = Convert.ToInt32(dr["idArea"]);
                    Cargo.nombreArea = dr["nombreArea"].ToString();

                    lista.Add(Cargo);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }

        /////////////////////////InsertaCargo
        public Boolean InsertarCargos(entCargos Cargo)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarCargo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", Cargo.nombre);
                cmd.Parameters.AddWithValue("@descripcion", Cargo.descripcion);
                cmd.Parameters.AddWithValue("@fecRegCargo", Cargo.fecRegCargo);
                cmd.Parameters.AddWithValue("@estCargo", Cargo.estCargo);
                cmd.Parameters.AddWithValue("@idArea", Cargo.estCargo);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }
        /////////////////////////EditarCargo
        public Boolean EditarCargos(entCargos Cargo)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("EditarCargo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCargo", Cargo.idCargo);
                cmd.Parameters.AddWithValue("@nombre", Cargo.nombre);
                cmd.Parameters.AddWithValue("@descripcion", Cargo.descripcion);
                cmd.Parameters.AddWithValue("@fecRegCargo", Cargo.fecRegCargo);
                cmd.Parameters.AddWithValue("@estCargo", Cargo.estCargo);
                cmd.Parameters.AddWithValue("@idArea", Cargo.idCargo);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }

        //deshabilitaCargo
        public Boolean DeshabilitarCargos(entCargos Cargo)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("DeshabilitaCargo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCargo", Cargo.idCargo);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    delete = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return delete;
        }

        ////////////////////listado de Area
        public List<entArea> ListarAreas()
        {
            SqlCommand cmd = null;
            List<entArea> lista = new List<entArea>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("ListadoArea", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entArea a = new entArea();
                    a.idArea = Convert.ToInt32(dr["idArea"]);
                    a.nombre = dr["nombre"].ToString();
                    lista.Add(a);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }

        ////////////////////listado de Empleados
        public List<entEmpleado> ListarEmpleados()
        {
            List<entEmpleado> lista = new List<entEmpleado>();
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT E.idEmpleado, E.nombre, E.sexo, E.correo, E.telefono, E.estEmpleado, E.idCargo, C.nombre AS nombreCargo FROM Empleado E INNER JOIN Cargos C ON E.idCargo = C.idCargo", cn))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                entEmpleado e = new entEmpleado();
                                e.idEmpleado = Convert.ToInt32(dr["idEmpleado"]);
                                e.nombre = dr["nombre"].ToString();
                                e.sexo = dr["sexo"].ToString();
                                e.correo = dr["correo"].ToString();
                                e.telefono = dr["telefono"].ToString();
                                e.estEmpleado = Convert.ToBoolean(dr["estEmpleado"]);
                                e.idCargo = Convert.ToInt32(dr["idCargo"]);
                                e.nombreCargo = dr["nombreCargo"].ToString();
                                lista.Add(e);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return lista;
        }

        ////////////////////listado de EmpleadosParaComboBox
        public List<entEmpleado> ListarEmpleadosCBO()
        {
            List<entEmpleado> lista = new List<entEmpleado>();
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT E.idEmpleado, E.nombre", cn))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                entEmpleado e = new entEmpleado();
                                e.idEmpleado = Convert.ToInt32(dr["idEmpleado"]);
                                e.nombre = dr["nombre"].ToString();
                                lista.Add(e);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return lista;
        }

        ////////////////////listado de TiposContratosParaComboBox
        public List<entContratos> ListarTiposContratosCBO()
        {
            List<entContratos> lista = new List<entContratos>();
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT idTipoContrato, nombre FROM TiposContratos", cn))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                entContratos tipoContrato = new entContratos();
                                tipoContrato.idTipoContrato = Convert.ToInt32(dr["idTipoContrato"]);
                                tipoContrato.nombreTipoContrato = dr["nombre"].ToString();
                                lista.Add(tipoContrato);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return lista;
        }

        ////////////////////listado de TiposLicenciasParaComboBox
        public List<entLicencias> ListarTiposLicenciasCBO()
        {
            List<entLicencias> lista = new List<entLicencias>();
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT nombre, idTipoLicencia FROM TiposLicenciasEmpleados", cn))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                entLicencias l = new entLicencias();
                                l.idTipoLicencia = Convert.ToInt32(dr["idTipoLicencia"]);
                                l.nombreTipoLicencia = dr["nombre"].ToString();
                                lista.Add(l);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return lista;
        }


        /////////////////////////InsertaEmpleados
        public Boolean InsertarEmpleados(entEmpleado e)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", e.nombre);
                cmd.Parameters.AddWithValue("@sexo", e.sexo);
                cmd.Parameters.AddWithValue("@correo", e.correo);
                cmd.Parameters.AddWithValue("@telefono", e.telefono);
                cmd.Parameters.AddWithValue("@estEmpleado", e.estEmpleado);
                cmd.Parameters.AddWithValue("@idCargo", e.idCargo);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception u)
            {
                throw u;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }

        /////////////////////////EditarEmpleado
        public Boolean EditarEmpleado(entEmpleado e)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("EditarEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idEmpleado", e.idEmpleado);
                cmd.Parameters.AddWithValue("@nombre", e.nombre);
                cmd.Parameters.AddWithValue("@sexo", e.sexo);
                cmd.Parameters.AddWithValue("@correo", e.correo);
                cmd.Parameters.AddWithValue("@telefono", e.telefono);
                cmd.Parameters.AddWithValue("@estEmpleado", e.estEmpleado);
                cmd.Parameters.AddWithValue("@idCargo", e.idCargo);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception i)
            {
                throw i;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }

        //deshabilitaEmpleado
        public Boolean DeshabilitarEmpleado(entEmpleado e)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("DeshabilitaEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idEmpleado", e.idEmpleado);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    delete = true;
                }
            }
            catch (Exception u)
            {
                throw u;
            }
            finally { cmd.Connection.Close(); }
            return delete;
        }
        //Busqueda de empleado por ID
        public entEmpleado BuscarEmpleadoPorId(int idEmpleado)
        {
            SqlCommand cmd = null;
            entEmpleado empleado = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("SELECT E.idEmpleado, E.nombre, E.sexo, E.correo, E.telefono, E.estEmpleado, E.idCargo, C.nombre AS nombreCargo FROM Empleado E INNER JOIN Cargos C ON E.idCargo = C.idCargo WHERE E.idEmpleado = @idEmpleado", cn);
                cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    empleado = new entEmpleado();
                    empleado.idEmpleado = Convert.ToInt32(dr["idEmpleado"]);
                    empleado.nombre = dr["nombre"].ToString();
                    empleado.sexo = dr["sexo"].ToString();
                    empleado.correo = dr["correo"].ToString();
                    empleado.telefono = dr["telefono"].ToString();
                    empleado.estEmpleado = Convert.ToBoolean(dr["estEmpleado"]);
                    empleado.idCargo = Convert.ToInt32(dr["idCargo"]);
                    empleado.nombreCargo = dr["nombreCargo"].ToString();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }

            return empleado;
        }
        //Listado Asistencias
        public List<entAsistencias> ObtenerAsistenciasPorTipo(string tipoAsistencia)
        {
            List<entAsistencias> asistenciasFiltradas = new List<entAsistencias>();

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cn.Open();

                    string query = "SELECT A.idAsistencia, A.idEmpleado, E.nombre AS nombreEmpleado, A.fecRegAsistencia, A.horaRegAsistencia, A.estAsistencia, A.tipoAsistencia FROM AsistenciasEmpleados A INNER JOIN Empleado E ON A.idEmpleado = E.idEmpleado WHERE A.tipoAsistencia = @tipo";

                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@tipo", tipoAsistencia);

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                entAsistencias asistencia = new entAsistencias();
                             
                                asistencia.fecRegAsistencia = Convert.ToDateTime(dr["fecRegAsistencia"]);
                                asistencia.horaRegAsistencia = dr["horaRegAsistencia"].ToString();
                                asistencia.estAsistencia = Convert.ToBoolean(dr["estAsistencia"]);
                                asistencia.tipoAsistencia = dr["tipoAsistencia"].ToString();
                                asistencia.idAsistencia = Convert.ToInt32(dr["idAsistencia"]);
                                asistencia.idEmpleado = Convert.ToInt32(dr["idEmpleado"]);
                                asistencia.nombreEmpleado = dr["nombreEmpleado"].ToString();

                                asistenciasFiltradas.Add(asistencia);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return asistenciasFiltradas;
        }

        //Insertar asistencias
        public void InsertarAsistencia(entAsistencias asistencia)
        {
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cn.Open();

                    using (SqlCommand cmd = new SqlCommand("InsertarAsistencia", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@idEmpleado", asistencia.idEmpleado);
                        cmd.Parameters.AddWithValue("@fecRegAsistencia", asistencia.fecRegAsistencia);
                        cmd.Parameters.AddWithValue("@horaRegAsistencia", asistencia.horaRegAsistencia);
                        cmd.Parameters.AddWithValue("@estAsistencia", asistencia.estAsistencia);
                        cmd.Parameters.AddWithValue("@tipoAsistencia", asistencia.tipoAsistencia);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //deshabilitaAsistencia
        public Boolean DeshabilitarAsistencia(entAsistencias e)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("DeshabilitarAsistencia", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idAsistencia", e.idAsistencia);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    delete = true;
                }
            }
            catch (Exception u)
            {
                throw u;
            }
            finally { cmd.Connection.Close(); }
            return delete;
        }
        //Consulta de asistencias de empleado
        public List<entAsistencias> BuscarAsistenciasPorIdEmpleado(int idEmpleado)
        {
            List<entAsistencias> asistencias = new List<entAsistencias>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                SqlCommand cmd = new SqlCommand("SELECT A.idAsistencia, A.idEmpleado, A.fecRegAsistencia, A.horaRegAsistencia, A.estAsistencia, A.tipoAsistencia, E.nombre AS nombreEmpleado FROM AsistenciasEmpleados A INNER JOIN Empleado E ON A.idEmpleado = E.idEmpleado WHERE A.idEmpleado = @idEmpleado", cn);
                cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    entAsistencias asistencia = new entAsistencias();
                    asistencia.fecRegAsistencia = Convert.ToDateTime(dr["fecRegAsistencia"]);
                    asistencia.horaRegAsistencia = dr["horaRegAsistencia"].ToString();
                    asistencia.estAsistencia = Convert.ToBoolean(dr["estAsistencia"]);
                    asistencia.tipoAsistencia = dr["tipoAsistencia"].ToString();
                    asistencia.idAsistencia = Convert.ToInt32(dr["idAsistencia"]);
                    asistencia.idEmpleado = Convert.ToInt32(dr["idEmpleado"]);
                    asistencia.nombreEmpleado = dr["nombreEmpleado"].ToString();

                    asistencias.Add(asistencia);
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return asistencias;
        }

        public List<entContratos> ListarContratos()
        {
            SqlCommand cmd = null;
            List<entContratos> lista = new List<entContratos>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); // Singleton
                cmd = new SqlCommand("SELECT CE.idContrato, CE.fecInicioContrato, CE.fecFinalContrato, CE.horaReg, CE.estContrato, CE.idEmpleado, CE.idTipoContrato, E.nombre AS nombreEmpleado, TC.nombre AS nombreTipoContrato FROM ContratosEmpleados CE INNER JOIN Empleado E ON CE.idEmpleado = E.idEmpleado INNER JOIN TiposContratos TC ON CE.idTipoContrato = TC.idTipoContrato", cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entContratos contrato = new entContratos();
                    contrato.idContrato = Convert.ToInt32(dr["idContrato"]);
                    contrato.fecInicioContrato = Convert.ToDateTime(dr["fecInicioContrato"]);
                    contrato.fecFinalContrato = Convert.ToDateTime(dr["fecFinalContrato"]);
                    contrato.horaReg = dr["horaReg"].ToString();
                    contrato.estContrato = Convert.ToBoolean(dr["estContrato"]);
                    contrato.idEmpleado = Convert.ToInt32(dr["idEmpleado"]);
                    contrato.idTipoContrato = Convert.ToInt32(dr["idTipoContrato"]);
                    contrato.nombreEmpleado = dr["nombreEmpleado"].ToString();
                    contrato.nombreTipoContrato = dr["nombreTipoContrato"].ToString();

                    lista.Add(contrato);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }

        public bool EmpleadoTieneContrato(int idEmpleado)
        {
            bool tieneContrato = false;
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM ContratosEmpleados WHERE idEmpleado = @idEmpleado", cn))
                    {
                        cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count > 0)
                        {
                            tieneContrato = true;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return tieneContrato;
        }
        public bool ValidarContrato(int idEmpleado)
        {
            bool empleadoTieneContrato = false;

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM ContratosEmpleados WHERE idEmpleado = @idEmpleado", cn))
                    {
                        cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        empleadoTieneContrato = (count > 0);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return empleadoTieneContrato;
        }

        //Insercion de contratos
        public bool InsertarContrato(entContratos c)
        {
            bool insertado = false;
            try
            {
                int idEmpleado = c.idEmpleado;

                // Verificar si el empleado ya tiene un contrato registrado
                bool empleadoTieneContrato = ValidarContrato(idEmpleado);
                if (empleadoTieneContrato)
                {
                    // El empleado ya tiene un contrato registrado, no se permite insertar uno nuevo
                    return insertado;
                }

                // Si el empleado no tiene contrato, proceder con la inserción del nuevo contrato

                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand("InsertarContrato", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@fecInicioContrato", c.fecInicioContrato);
                        cmd.Parameters.AddWithValue("@fecFinalContrato", c.fecFinalContrato);
                        cmd.Parameters.AddWithValue("@horaReg", c.horaReg);
                        cmd.Parameters.AddWithValue("@estContrato", c.estContrato);
                        cmd.Parameters.AddWithValue("@idEmpleado", c.idEmpleado);
                        cmd.Parameters.AddWithValue("@idTipoContrato", c.idTipoContrato);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            insertado = true;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return insertado;
        }

        //deshabilitaContrato
        public Boolean DeshabilitarContrato(entContratos e)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("DeshabilitarContrato", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idContrato", e.idContrato);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    delete = true;
                }
            }
            catch (Exception u)
            {
                throw u;
            }
            finally { cmd.Connection.Close(); }
            return delete;
        }

        public entContratos BuscarContratosPorID(int idEmpleado)
        {
            SqlCommand cmd = null;
            entContratos contrato = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); // Singleton
                cmd = new SqlCommand("SELECT C.fecInicioContrato, C.fecFinalContrato, E.nombre AS nombreEmpleado, TC.nombre AS nombreTipoContrato FROM ContratosEmpleados C INNER JOIN Empleado E ON C.idEmpleado = E.idEmpleado INNER JOIN TiposContratos TC ON C.idTipoContrato = TC.idTipoContrato WHERE C.idEmpleado = @idEmpleado", cn);
                cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    contrato = new entContratos();
                    contrato.fecInicioContrato = Convert.ToDateTime(dr["fecInicioContrato"]);
                    contrato.fecFinalContrato = Convert.ToDateTime(dr["fecFinalContrato"]);
                    contrato.nombreEmpleado = dr["nombreEmpleado"].ToString();
                    contrato.nombreTipoContrato = dr["nombreTipoContrato"].ToString();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }

            return contrato;
        }

        ////////////////////listado de Tipos de licencia
        public List<entLicencias> ListarLicencias()
        {
            List<entLicencias> lista = new List<entLicencias>();
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT idLicencia, fecInicioLicencia, fecFinalLicencia, horaReg, estLicencia, idEmpleado, idTipoLicencia FROM LicenciasEmpleados", cn))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                entLicencias licencia = new entLicencias();
                                licencia.idLicencia = Convert.ToInt32(dr["idLicencia"]);
                                licencia.fecInicioLicencia = Convert.ToDateTime(dr["fecInicioLicencia"]);
                                licencia.fecFinalLicencia = Convert.ToDateTime(dr["fecFinalLicencia"]);
                                licencia.horaReg = dr["horaReg"].ToString();
                                licencia.estLicencia = Convert.ToBoolean(dr["estLicencia"]);
                                licencia.idEmpleado = Convert.ToInt32(dr["idEmpleado"]);
                                licencia.idTipoLicencia = Convert.ToInt32(dr["idTipoLicencia"]);
                                // Retrieve the nombreTipoLicencia from the LicenseType table using the foreign key idTipoLicencia
                                licencia.nombreTipoLicencia = ObtenerNombreTipoLicencia(licencia.idTipoLicencia);
                                licencia.nombreEmpleado = ObtenerNombreEmpleado(licencia.idEmpleado);
                                lista.Add(licencia);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return lista;
        }

        private string ObtenerNombreTipoLicencia(int idTipoLicencia)
        {
            string nombreTipoLicencia = string.Empty;
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT nombre FROM TiposLicenciasEmpleados WHERE idTipoLicencia = @idTipoLicencia", cn))
                    {
                        cmd.Parameters.AddWithValue("@idTipoLicencia", idTipoLicencia);
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            nombreTipoLicencia = result.ToString();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return nombreTipoLicencia;
        }

        private string ObtenerNombreEmpleado(int idEmpleado)
        {
            string nombreEmpleado = string.Empty;
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT nombre FROM Empleado WHERE idEmpleado = @idEmpleado", cn))
                    {
                        cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            nombreEmpleado = result.ToString();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return nombreEmpleado;
        }




        public bool InsertarLicencia(entLicencias licencia)
        {
            bool insertado = false;
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand("InsertarLicencia", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@fecInicioLicencia", licencia.fecInicioLicencia);
                        cmd.Parameters.AddWithValue("@fecFinalLicencia", licencia.fecFinalLicencia);
                        cmd.Parameters.AddWithValue("@horaReg", licencia.horaReg);
                        cmd.Parameters.AddWithValue("@estLicencia", licencia.estLicencia);
                        cmd.Parameters.AddWithValue("@idEmpleado", licencia.idEmpleado);
                        cmd.Parameters.AddWithValue("@idTipoLicencia", licencia.idTipoLicencia);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            insertado = true;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return insertado;
        }

        //deshabilitaLicencia
        public Boolean DeshabilitarLicencia(entLicencias e)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("DeshabilitarLicencia", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idLicencia", e.idLicencia);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    delete = true;
                }
            }
            catch (Exception u)
            {
                throw u;
            }
            finally { cmd.Connection.Close(); }
            return delete;
        }

        public entLicencias BuscarLicenciasPorID(int idEmpleado)
        {
            SqlCommand cmd = null;
            entLicencias licencia = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); // Singleton
                cmd = new SqlCommand("SELECT L.idLicencia, L.fecInicioLicencia, L.fecFinalLicencia, L.horaReg, L.estLicencia, E.nombre AS nombreEmpleado, TL.nombre AS nombreTipoLicencia FROM LicenciasEmpleados L INNER JOIN Empleado E ON L.idEmpleado = E.idEmpleado LEFT JOIN TiposLicenciasEmpleados TL ON L.idTipoLicencia = TL.idTipoLicencia WHERE L.idEmpleado = @idEmpleado", cn);
                cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    licencia = new entLicencias();
                    licencia.idLicencia = Convert.ToInt32(dr["idLicencia"]);
                    licencia.fecInicioLicencia = Convert.ToDateTime(dr["fecInicioLicencia"]);
                    licencia.fecFinalLicencia = Convert.ToDateTime(dr["fecFinalLicencia"]);
                    licencia.horaReg = dr["horaReg"].ToString();
                    licencia.estLicencia = Convert.ToBoolean(dr["estLicencia"]);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }

            return licencia;
        }


        public List<entTipoContrato> ListarTipoContratos()
        {
            List<entTipoContrato> listaContratos = new List<entTipoContrato>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ListarTipoContratos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entTipoContrato contrato = new entTipoContrato
                    {
                        idTipoContrato = Convert.ToInt32(dr["idTipoContrato"]),
                        nombre = dr["nombre"].ToString(),
                        descripcion = dr["descripcion"].ToString(),
                        salario = Convert.ToDecimal(dr["salario"])
                    };
                    listaContratos.Add(contrato);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd?.Connection.Close();
            }
            return listaContratos;
        }


        public bool InsertarTipoContrato(entTipoContrato tipoContrato)
        {
            SqlCommand cmd = null;
            bool inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarTipoContrato", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", tipoContrato.nombre);
                cmd.Parameters.AddWithValue("@descripcion", tipoContrato.descripcion);
                cmd.Parameters.AddWithValue("@salario", tipoContrato.salario);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return inserta;
        }

        public bool EditarTipoContrato(entTipoContrato tipoContrato)
        {
            SqlCommand cmd = null;
            bool edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("EditarTipoContrato", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idTipoContrato", tipoContrato.idTipoContrato);
                cmd.Parameters.AddWithValue("@nombre", tipoContrato.nombre);
                cmd.Parameters.AddWithValue("@descripcion", tipoContrato.descripcion);
                cmd.Parameters.AddWithValue("@salario", tipoContrato.salario);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return edita;
        }

        public bool EliminarTipoContrato(int idTipoContrato)
        {
            SqlCommand cmd = null;
            bool elimina = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("EliminarTipoContrato", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idTipoContrato", idTipoContrato);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    elimina = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return elimina;
        }

        public List<entTipoLicencia> ListarTipoLicencias()
        {
            List<entTipoLicencia> listaLicencias = new List<entTipoLicencia>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ListarTipoLicencias", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entTipoLicencia licencia = new entTipoLicencia
                    {
                        idTipoLicencia = Convert.ToInt32(dr["idTipoLicencia"]),
                        nombre = dr["nombre"].ToString(),
                        estPagada = Convert.ToBoolean(dr["estPagada"])
                    };
                    listaLicencias.Add(licencia);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd?.Connection.Close();
            }
            return listaLicencias;
        }

        public bool InsertarTipoLicencia(entTipoLicencia tipoLicencia)
        {
            SqlCommand cmd = null;
            bool inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarTipoLicencia", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", tipoLicencia.nombre);
                cmd.Parameters.AddWithValue("@estPagada", tipoLicencia.estPagada);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return inserta;
        }

        public bool EditarTipoLicencia(entTipoLicencia tipoLicencia)
        {
            SqlCommand cmd = null;
            bool edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("EditarTipoLicencia", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idTipoLicencia", tipoLicencia.idTipoLicencia);
                cmd.Parameters.AddWithValue("@nombre", tipoLicencia.nombre);
                cmd.Parameters.AddWithValue("@estPagada", tipoLicencia.estPagada);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return edita;
        }

        public bool EliminarTipoLicencia(int idTipoLicencia)
        {
            SqlCommand cmd = null;
            bool elimina = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("EliminarTipoLicencia", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idTipoLicencia", idTipoLicencia);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    elimina = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return elimina;
        }




        #endregion

    }
}
