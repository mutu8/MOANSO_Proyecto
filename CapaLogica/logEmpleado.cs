
using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logEmpleado
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logEmpleado _instancia = new logEmpleado();
        //privado para evitar la instanciación directa
        public static logEmpleado Instancia
        {
            get
            {
                return logEmpleado._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado
        public List<entCargos> ListarCargos()
        {
            return procEmpleado.Instancia.ListarCargos();
        }
        ///inserta
        public void InsertarCargos(entCargos cargos)
        {
            procEmpleado.Instancia.InsertarCargos(cargos);
        }
        //edita
        public void EditaCargos(entCargos cargos)
        {
            procEmpleado.Instancia.EditarCargos(cargos);
        }
        public void DeshabilitarCargos(entCargos cargos)
        {
            procEmpleado.Instancia.DeshabilitarCargos(cargos);
        }

        ///listado Area
        public List<entArea> ListarArea()
        {
            return procEmpleado.Instancia.ListarAreas();
        }
        //listado empleados
        public List<entEmpleado> ListarEmpleados()
        {
            return procEmpleado.Instancia.ListarEmpleados();
        }
        //listado empleadosCBO
        public List<entEmpleado> ListarEmpleadosCBO()
        {
            return procEmpleado.Instancia.ListarEmpleados();
        }
        //listado TipoContratosCBO
        public List<entContratos> ListarTipoContratosCBO() 
        {
            return procEmpleado.Instancia.ListarTiposContratosCBO();
        }
        //listado TiposLicenciasCBO
        public List<entLicencias> ListarTipoLicenciasCBO()
        {
            return procEmpleado.Instancia.ListarTiposLicenciasCBO();
        }
        ///inserta Empleados
        public void InsertarEmpleados(entEmpleado e)
        {
            procEmpleado.Instancia.InsertarEmpleados(e);
        }
        //edita
        public void EditaEmpleado(entEmpleado e)
        {
            procEmpleado.Instancia.EditarEmpleado(e);
        }
        //Deshabilita empleado
        public void DeshabilitarEmpleado(entEmpleado e)
        {
            procEmpleado.Instancia.DeshabilitarEmpleado(e);
        }
        //Busqueda Empleado
        public entEmpleado BuscarEmpleadoPorId(int idEmpleado)
        {
            return procEmpleado.Instancia.BuscarEmpleadoPorId(idEmpleado);
        }
        //Listado de asistencias
        public List<entAsistencias> ListarAsistencias(string tipoAsistencia)
        {
            return procEmpleado.Instancia.ObtenerAsistenciasPorTipo(tipoAsistencia);
        }
        ///inserta Asistencias
        public void InsertarAsistencias(entAsistencias e)
        {
            procEmpleado.Instancia.InsertarAsistencia(e);
        }
        //Deshabilita asistencias
        public void DeshabilitarAsistencia(entAsistencias e)
        {
            procEmpleado.Instancia.DeshabilitarAsistencia(e);
        }
        //Consulta de asistencias
        public List<entAsistencias> ConsultaAsistenciasPorID(int ID)
        {
            return procEmpleado.Instancia.BuscarAsistenciasPorIdEmpleado(ID);
        }

        //Listado de contratos
        public List<entContratos> ListarContratos()
        {
            return procEmpleado.Instancia.ListarContratos();
        }
        public bool ValidarContrato(int idEmpleado)
        {
            return procEmpleado.Instancia.ValidarContrato(idEmpleado);
        }
        //Deshabilita contrato
        public void DeshabilitarContrato(entContratos e)
        {
            procEmpleado.Instancia.DeshabilitarContrato(e);
        }

        ///insertado de contratos
        public void InsertarContratos(entContratos c)
        {
            procEmpleado.Instancia.InsertarContrato(c);
        }
        //Busqueda Contrato
  
       public entContratos BuscarContratosPorID(int idEmpleado)
        {
            return procEmpleado.Instancia.BuscarContratosPorID(idEmpleado);
        }
        ///listado Licencias
        public List<entLicencias> ListarLicencias()
        {
            return procEmpleado.Instancia.ListarLicencias();
        }
        ///inserta
        public void InsertarLicencia(entLicencias e)
        {
            procEmpleado.Instancia.InsertarLicencia(e);
        }
        //Deshabilita Licencia
        public void DeshabilitarLicencia(entLicencias e)
        {
            procEmpleado.Instancia.DeshabilitarLicencia(e);
        }
        public entLicencias BuscarLicenciasPorID(int idEmpleado)
        {
            return procEmpleado.Instancia.BuscarLicenciasPorID(idEmpleado);
        }

        public List<entTipoContrato> ListarTipoContratos()
        {
            return procEmpleado.Instancia.ListarTipoContratos();
        }
        ///inserta
        public void InsertarTipoContrato(entTipoContrato c)
        {
            procEmpleado.Instancia.InsertarTipoContrato(c);
        }
        //edita
        public void editarTipoContrato(entTipoContrato c)
        {
            procEmpleado.Instancia.EditarTipoContrato(c);
        }
        public void DeshabilitarTiposContrato(int c)
        {
            procEmpleado.Instancia.EliminarTipoContrato(c);
        }

        public List<entTipoLicencia> ListarTipoLicencia()
        {
            return procEmpleado.Instancia.ListarTipoLicencias();
        }
        ///inserta
        public void InsertarTipoLicencia(entTipoLicencia c)
        {
            procEmpleado.Instancia.InsertarTipoLicencia(c);
        }
        //edita
        public void editarTipoLicencia(entTipoLicencia c)
        {
            procEmpleado.Instancia.EditarTipoLicencia(c);
        }
        public void DeshabilitarTiposLicencia(int c)
        {
            procEmpleado.Instancia.EliminarTipoLicencia(c);
        }

        #endregion singleton

    }
}
