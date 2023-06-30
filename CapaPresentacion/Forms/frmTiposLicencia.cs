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
    public partial class frmTiposLicencia : Form
    {
        private IconButton currentBtn;
        private System.Windows.Forms.Panel leftBorderBtn;

        public frmTiposLicencia()
        {
            InitializeComponent();
            leftBorderBtn = new System.Windows.Forms.Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            ActivateButton(btnTL, RGBColors.color1);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            txtID.Visible = false;
            ColorDgv();
            listarTL();
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
            this.dgvTL.DefaultCellStyle.Font = new Font("Tahoma", 12);
            this.dgvTL.DefaultCellStyle.ForeColor = Color.Blue;
            this.dgvTL.DefaultCellStyle.BackColor = Color.Beige;
            this.dgvTL.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            this.dgvTL.DefaultCellStyle.SelectionBackColor = Color.Black;

            //test
            dgvTL.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvTL.ReadOnly = true;
        }
        private void listarTL()
        {
            dgvTL.DataSource = logEmpleado.Instancia.ListarTipoLicencia();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                entTipoLicencia c = new entTipoLicencia();
                c.nombre = txtNombre.Text.Trim();
                c.estPagada = chkLicenciaCompensada.Checked;
                logEmpleado.Instancia.InsertarTipoLicencia(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            listarTL();
            //LimpiarItem();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnGuardar.Visible = true;
            btnRegistrar.Visible = false;
            txtID.Visible = true;
            txtID.Enabled = false;
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el ID del tipo de contrato desde el control TextBox
                int idTipoContrato = int.Parse(txtID.Text.Trim());

                // Invocar al método de la capa lógica para deshabilitar el tipo de contrato
                logEmpleado.Instancia.DeshabilitarTiposLicencia(idTipoContrato);

                // Actualizar la vista (por ejemplo, recargar la lista de tipos de contrato)
                listarTL();

                // Mostrar un mensaje de éxito
                MessageBox.Show("Tipo de contrato deshabilitado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar el control TextBox
                txtID.Text = string.Empty;
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error si ocurre una excepción
                MessageBox.Show("Error al deshabilitar el tipo de contrato: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTL_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvTL.Rows[e.RowIndex]; //
            txtID.Text = filaActual.Cells[0].Value.ToString();
            txtNombre.Text = filaActual.Cells[1].Value.ToString();
            chkLicenciaCompensada.Checked= Convert.ToBoolean(filaActual.Cells[2].Value);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                entTipoLicencia c = new entTipoLicencia();
                c.idTipoLicencia = int.Parse(txtID.Text.Trim());
                c.nombre = txtNombre.Text.Trim();
                c.estPagada = chkLicenciaCompensada.Checked;
                logEmpleado.Instancia.editarTipoLicencia(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            btnGuardar.Visible = false;
            txtID.Visible = false;
            btnRegistrar.Visible = true;
            listarTL();
            //LimpiarItem();
        }
    }
}
