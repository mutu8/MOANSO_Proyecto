using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;
using FontAwesome.Sharp;
using static CapaPresentacion.Main;

namespace CapaPresentacion
{
    public partial class frmContratos : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        public frmContratos()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            ActivateButton(btnContratos, RGBColors.color5);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            ColorDgv();
            listarContratos();
            LlenarCboEmpleados();
            LlenarCboTiposContratos();
            txtIdContrato.Visible = false;
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                //iconCurrentChildForm.IconChar = currentBtn.IconChar;
                //iconCurrentChildForm.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }


        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEmpleado frm = new frmEmpleado();
            frm.Show();
        }

        private void btnCargos_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCargos frm = new frmCargos();
            frm.Show();
        }

        private void btnAsistencias_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAsistencia frm = new frmAsistencia();
            frm.Show();
        }

        private void btnLicencias_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLL frm = new frmLL();
            frm.Show();
        }

        private void btnContratos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
        }


        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main frm = new Main();
            frm.Show();
        }
        //Mov_BarraSuperior
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void barraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main frm = new Main();
            frm.Show();
        }

        private void btnTL_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            this.Hide();
            frmTiposLicencia frm = new frmTiposLicencia();
            frm.Show();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            Application.Exit();
        }

        private void btnTC_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            this.Hide();
            frmTiposContratos frm = new frmTiposContratos();
            frm.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            Application.Exit();
        }
        private void ColorDgv()
        {
            this.dgvContratos.DefaultCellStyle.Font = new Font("Tahoma", 12);
            this.dgvContratos.DefaultCellStyle.ForeColor = Color.Blue;
            this.dgvContratos.DefaultCellStyle.BackColor = Color.Beige;
            this.dgvContratos.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            this.dgvContratos.DefaultCellStyle.SelectionBackColor = Color.Black;

            //test
            dgvContratos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvContratos.ReadOnly = true;
        }
        private void LlenarCboEmpleados()
        {
            cboEmpleado.DataSource = logEmpleado.Instancia.ListarEmpleadosCBO();
            cboEmpleado.DisplayMember = "nombre";
            cboEmpleado.ValueMember = "idEmpleado";
            cboEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void LlenarCboTiposContratos()
        {
            cboTipoContratos.DataSource = logEmpleado.Instancia.ListarTipoContratosCBO();
            cboTipoContratos.DisplayMember = "nombreTipoContrato";
            cboTipoContratos.ValueMember = "idTipoContrato";
            cboTipoContratos.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private void listarContratos()
        {
            dgvContratos.DataSource = logEmpleado.Instancia.ListarContratos();
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los campos de entrada del contrato
            DateTime fecInicioContrato = datePikerInicioC.Value;
            DateTime fecFinalContrato = datePikerFinC.Value;
            string horaReg = DateTime.Now.ToString("hh:mm tt"); // Obtener la hora actual en formato de cadena de texto
            bool estContrato = chkEstC.Checked;
            int idEmpleado = Convert.ToInt32(cboEmpleado.SelectedValue);
            int idTipoContrato = Convert.ToInt32(cboTipoContratos.SelectedValue);

            // Verificar si el empleado ya tiene un contrato registrado
            bool empleadoTieneContrato = logEmpleado.Instancia.ValidarContrato(idEmpleado);
            if (empleadoTieneContrato)
            {
                MessageBox.Show("El empleado ya tiene un contrato registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear una instancia del objeto entContratos con los valores obtenidos
            entContratos contrato = new entContratos
            {
                fecInicioContrato = fecInicioContrato,
                fecFinalContrato = fecFinalContrato,
                horaReg = horaReg,
                estContrato = estContrato,
                idEmpleado = idEmpleado,
                idTipoContrato = idTipoContrato
            };

            // Insertar el contrato utilizando el objeto logEmpleado
            try
            {
                logEmpleado.Instancia.InsertarContratos(contrato);
                MessageBox.Show("Contrato insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Realizar otras acciones necesarias después de la inserción exitosa del contrato
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al insertar el contrato: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Realizar acciones adicionales en caso de error durante la inserción del contrato
            }
        }


        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entContratos c = new entContratos();
                c.idContrato = int.Parse(txtIdContrato.Text.Trim());
                chkEstC.Checked = false;
                c.estContrato = chkEstC.Checked;
                logEmpleado.Instancia.DeshabilitarContrato(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            listarContratos();
            //LimpiarItem();
        }

        private void dgvContratos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvContratos.Rows[e.RowIndex]; //
            txtIdContrato.Text = filaActual.Cells[0].Value.ToString();
            datePikerInicioC.Text = filaActual.Cells[1].Value.ToString();
            datePikerFinC.Text = filaActual.Cells[2].Value.ToString();
            chkEstC.Checked = filaActual.Cells[4].Value != null && Convert.ToBoolean(filaActual.Cells[4].Value);
            cboEmpleado.SelectedIndex = int.Parse(filaActual.Cells[7].Value.ToString());
            Console.WriteLine(filaActual.Cells[7].Value.ToString());
            cboTipoContratos.SelectedIndex = int.Parse(filaActual.Cells[8].Value.ToString());
            Console.WriteLine(filaActual.Cells[8].Value.ToString());

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int idEmpleado = int.Parse(txtConsultar.Text); // Obtén el ID del empleado desde algún control de tu formulario

            entContratos contrato = logEmpleado.Instancia.BuscarContratosPorID(idEmpleado);

            if (contrato != null)
            {
                // Mostrar la información en los controles de tu formulario
                lblNombreEmpleado.Text = contrato.nombreEmpleado;
                lblTipoContrato.Text = contrato.nombreTipoContrato;
                lblFechaInicioC.Text = contrato.fecInicioContrato.ToString("dd/MM/yyyy");
                lblFechaFinContrato.Text = contrato.fecFinalContrato.ToString("dd/MM/yyyy");
            }
            else
            {
                // No se encontró contrato para el empleado
                MessageBox.Show("NO SE ENCONTRÓ UN CONTRATO!!");
                lblNombreEmpleado.Text = string.Empty;
                lblTipoContrato.Text = string.Empty;
                lblFechaInicioC.Text = string.Empty;
                lblFechaFinContrato.Text = string.Empty;
            }
        }


    }
}
