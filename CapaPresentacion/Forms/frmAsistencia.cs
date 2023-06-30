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
    public partial class frmAsistencia : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        public frmAsistencia()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            ActivateButton(btnAsistencias, RGBColors.color3);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            txtID.Visible = false;
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
                ColorDgv();
                LlenarCboEmpleados();
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
            ActivateButton(sender, RGBColors.color3);
        }

        private void btnLicencias_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLL frm = new frmLL();
            frm.Show();
        }

        private void btnContratos_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmContratos frm = new frmContratos();
            frm.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            Application.Exit();
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime horaSeleccionada = dateTimePicker1.Value;

            // Actualizar el texto de la etiqueta con la hora seleccionada
            lblHora.Text = horaSeleccionada.ToString("HH:mm:ss");
            dateTimePicker1.Enabled = false;

        }
        private void ColorDgv()
        {
            this.dgvAsistenciaEmpleados.DefaultCellStyle.Font = new Font("Tahoma", 12);
            this.dgvAsistenciaEmpleados.DefaultCellStyle.ForeColor = Color.Blue;
            this.dgvAsistenciaEmpleados.DefaultCellStyle.BackColor = Color.Beige;
            this.dgvAsistenciaEmpleados.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            this.dgvAsistenciaEmpleados.DefaultCellStyle.SelectionBackColor = Color.Black;

            //test
            dgvAsistenciaEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvAsistenciaEmpleados.ReadOnly = true;
        }

        private void ColorDgvConsulta()
        {
            this.dgvConsulta.DefaultCellStyle.Font = new Font("Tahoma", 12);
            this.dgvConsulta.DefaultCellStyle.ForeColor = Color.Blue;
            this.dgvConsulta.DefaultCellStyle.BackColor = Color.Beige;
            this.dgvConsulta.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            this.dgvConsulta.DefaultCellStyle.SelectionBackColor = Color.Black;

            //test
            dgvConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvConsulta.ReadOnly = true;
        }


        private void LlenarCboEmpleados()
        {
            cboEmpleado.DataSource = logEmpleado.Instancia.ListarEmpleadosCBO();
            cboEmpleado.DisplayMember = "nombre";
            cboEmpleado.ValueMember = "idEmpleado";
            cboEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;

            cboTipoAsistencia.Items.Add("Ingreso");
            cboTipoAsistencia.Items.Add("Salida");
            cboTipoAsistencia.DropDownStyle = ComboBoxStyle.DropDownList;

            cboListadoTipoAsistencia.Items.Add("Ingreso");
            cboListadoTipoAsistencia.Items.Add("Salida");
            cboListadoTipoAsistencia.DropDownStyle = ComboBoxStyle.DropDownList;

        }



        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                int idEmpleado = Convert.ToInt32(cboEmpleado.SelectedValue);

                DateTime horaActual = DateTime.Now;
                //Actualizar el texto del Label con la hora actual
                lblHora.Text = horaActual.ToString("HH:mm:ss");

                entAsistencias c = new entAsistencias();
                c.fecRegAsistencia = dateTimePicker1.Value;
                c.horaRegAsistencia = lblHora.Text;
                c.estAsistencia = chkEst.Checked;
                c.tipoAsistencia = cboTipoAsistencia.Text;
                c.idEmpleado = idEmpleado;
                logEmpleado.Instancia.InsertarAsistencias(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            MessageBox.Show("ASISTENCIA REGISTRADA!!");

            //listar();
            //LimpiarItem();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entAsistencias c = new entAsistencias();
                c.idAsistencia = int.Parse(txtID.Text.Trim());
                chkEst.Checked = false;
                c.estAsistencia = chkEst.Checked;
                logEmpleado.Instancia.DeshabilitarAsistencia(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

        }

        private void cboListadoTipoAsistencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el tipo de asistencia seleccionado del ComboBox
            string tipoAsistenciaSeleccionado = cboListadoTipoAsistencia.SelectedItem.ToString();
            logEmpleado l = new logEmpleado();
            // Filtrar las asistencias según el tipo seleccionado
            List<entAsistencias> asistenciasFiltradas = l.ListarAsistencias(tipoAsistenciaSeleccionado);

            // Actualizar el DataGridView con las asistencias filtradas
            dgvAsistenciaEmpleados.DataSource = asistenciasFiltradas;
        }

        private void dgvAsistenciaEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvAsistenciaEmpleados.Rows[e.RowIndex]; //
            txtID.Text = filaActual.Cells[4].Value.ToString();
            MessageBox.Show("SE DESHABILITÓ LA ASISTENCIA!!");
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ColorDgvConsulta();
            try
            {
                int idEmpleado = int.Parse(txtConsulta.Text);

                // Obtener el empleado por su ID
                entEmpleado empleado = logEmpleado.Instancia.BuscarEmpleadoPorId(idEmpleado);

                if (empleado != null)
                {
                    // Mostrar el nombre del empleado en el Label
                    label13.Text = empleado.nombre;
                }
                else
                {
                    // Si no se encuentra el empleado, mostrar un mensaje de error
                    label13.Text = "Empleado no encontrado";
                }

                // Obtener las asistencias del empleado por su ID
                List<entAsistencias> asistencias = logEmpleado.Instancia.ConsultaAsistenciasPorID(idEmpleado);

                // Asignar los datos al DataGridView
                dgvConsulta.DataSource = asistencias;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar las asistencias: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
