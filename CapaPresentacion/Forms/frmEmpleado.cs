using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;
using FontAwesome.Sharp;
using static CapaPresentacion.Main;

namespace CapaPresentacion
{
    public partial class frmEmpleado : Form
    {
        private IconButton currentBtn;
        private System.Windows.Forms.Panel leftBorderBtn;

        public frmEmpleado()
        {
            InitializeComponent();
            leftBorderBtn = new System.Windows.Forms.Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            ActivateButton(btnEmpleados, RGBColors.color1);

            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            listarEmpleados();
            btnGuardar.Visible = false;
            txtID.Visible = false;
            label2.Visible = false;

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
                LlenarCboCargos();
                ColorDgv();
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
            ActivateButton(sender, RGBColors.color1);
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

        private void frmEmpleado_Load(object sender, EventArgs e)
        {

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

        private void LlenarCboCargos()
        {
            cboCargo.DataSource = logEmpleado.Instancia.ListarCargos();
            cboCargo.DisplayMember = "nombre";
            cboCargo.ValueMember = "idCargo";
            cboCargo.DropDownStyle= ComboBoxStyle.DropDownList;

            cboSexo.Items.Add("Masculino");
            cboSexo.Items.Add("Femenino");
            cboSexo.DropDownStyle= ComboBoxStyle.DropDownList;

        }

        private void listarEmpleados()
        {
            dgvEmpleados.DataSource = logEmpleado.Instancia.ListarEmpleados();
        }
        private void LimpiarItem()
        {
            cboSexo.SelectedIndex = -1;
            cboCargo.SelectedIndex = -1;
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtNombre.Text = "";
        }

        private void ColorDgv()
        {
            this.dgvEmpleados.DefaultCellStyle.Font = new Font("Tahoma", 12);
            this.dgvEmpleados.DefaultCellStyle.ForeColor = Color.Blue;
            this.dgvEmpleados.DefaultCellStyle.BackColor = Color.Beige;
            this.dgvEmpleados.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            this.dgvEmpleados.DefaultCellStyle.SelectionBackColor = Color.Black;

            //test
            dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvEmpleados.ReadOnly = true;
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                entEmpleado c = new entEmpleado();
                c.nombre = txtNombre.Text.Trim();
                c.sexo = cboSexo.Text.Trim();
                c.correo = txtEmail.Text.Trim();
                c.telefono = txtTelefono.Text.Trim();
                c.estEmpleado = chkEst.Checked;
                c.idCargo = (int)cboCargo.SelectedValue;
                logEmpleado.Instancia.InsertarEmpleados(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            listarEmpleados();
            LimpiarItem();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entEmpleado c = new entEmpleado();
                c.idEmpleado = int.Parse(txtID.Text.Trim());
                chkEst.Checked = false;
                c.estEmpleado = chkEst.Checked;
                logEmpleado.Instancia.DeshabilitarEmpleado(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            listarEmpleados();
            LimpiarItem();
        }

        private void dgvEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvEmpleados.Rows[e.RowIndex]; //
            txtID.Text = filaActual.Cells[0].Value.ToString();
            txtNombre.Text = filaActual.Cells[1].Value.ToString();
            cboSexo.Text = filaActual.Cells[2].Value.ToString();
            txtEmail.Text = filaActual.Cells[3].Value.ToString();
            txtTelefono.Text = filaActual.Cells[4].Value.ToString();
            chkEst.Checked = Convert.ToBoolean(filaActual.Cells[5].Value);

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            label5.Visible = true;
            btnGuardar.Visible = true;
            btnRegistrar.Visible = false;
            txtID.Visible = true;
            txtID.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                entEmpleado c = new entEmpleado();
                c.idEmpleado = int.Parse(txtID.Text.Trim());
                c.nombre = txtNombre.Text.Trim();
                c.sexo = cboSexo.Text.Trim();
                c.correo = txtEmail.Text.Trim();
                c.telefono = txtTelefono.Text.Trim();
                c.estEmpleado = chkEst.Checked;
                c.idCargo = (int)cboCargo.SelectedValue;
                logEmpleado.Instancia.EditaEmpleado(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            btnGuardar.Visible = false;
            label5.Visible = false;
            txtID.Visible = false;
            btnRegistrar.Visible = true;
            listarEmpleados();
            LimpiarItem();
        }

        private void btnBuscarPorID_Click(object sender, EventArgs e)
        {
            int idEmpleado = Convert.ToInt32(txtConsulta.Text);

            entEmpleado empleadoEncontrado = logEmpleado.Instancia.BuscarEmpleadoPorId(idEmpleado);

            if (empleadoEncontrado != null)
            {
                lblCargoC.Text = empleadoEncontrado.nombreCargo;
                lblEmailC.Text = empleadoEncontrado.correo;
                lblNombreC.Text = empleadoEncontrado.nombre;
                lblSexoC.Text = empleadoEncontrado.sexo;
                lblTelefonoC.Text = empleadoEncontrado.telefono;
            }
            else
            {
                MessageBox.Show("Empleado no encontrado");
            }
        }

    }
}
