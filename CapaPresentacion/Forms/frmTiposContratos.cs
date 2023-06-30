using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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
    public partial class frmTiposContratos : Form
    {
        private IconButton currentBtn;
        private System.Windows.Forms.Panel leftBorderBtn;

        public frmTiposContratos()
        {
            InitializeComponent();
            leftBorderBtn = new System.Windows.Forms.Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            ActivateButton(btnTC, RGBColors.color2);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            btnGuardar.Visible = false;
            txtID.Visible = false;
            ColorDgv();
            listarTiz();
        }

        private void ColorDgv()
        {
            this.dgvTC.DefaultCellStyle.Font = new Font("Tahoma", 12);
            this.dgvTC.DefaultCellStyle.ForeColor = Color.Blue;
            this.dgvTC.DefaultCellStyle.BackColor = Color.Beige;
            this.dgvTC.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            this.dgvTC.DefaultCellStyle.SelectionBackColor = Color.Black;

            //test
            dgvTC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvTC.ReadOnly = true;
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
            this.Hide();
            frmTiposLicencia frm = new frmTiposLicencia();
            frm.Show();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            Application.Exit();
        }

        private void listarTiz()
        {
            dgvTC.DataSource = logEmpleado.Instancia.ListarTipoContratos();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                entTipoContrato c = new entTipoContrato();
                c.nombre = txtNombre.Text;
                c.descripcion = txtDescripcion.Text;
                c.salario = Convert.ToDecimal(txtSalario.Text);
                logEmpleado.Instancia.InsertarTipoContrato(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            listarTiz();
            //LimpiarItem();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                entTipoContrato c = new entTipoContrato();
                c.idTipoContrato = int.Parse(txtID.Text.Trim());
                c.nombre = txtNombre.Text;
                c.descripcion = txtDescripcion.Text;
                c.salario = Convert.ToDecimal(txtSalario.Text);
                logEmpleado.Instancia.editarTipoContrato(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            btnGuardar.Visible = false;
            txtID.Visible = false;
            btnRegistrar.Visible = true;
            listarTiz();
            //LimpiarItem();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnGuardar.Visible = true;
            btnRegistrar.Visible = false;
            txtID.Visible = true;
            txtID.Enabled = false;
        }

        private void dgvTC_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow filaActual = dgvTC.Rows[e.RowIndex];
                    int idTipoContrato = Convert.ToInt32(filaActual.Cells["idTipoContrato"].Value);
                    string nombre = filaActual.Cells["nombre"].Value.ToString();
                    string descripcion = filaActual.Cells["descripcion"].Value.ToString();
                    decimal salario = Convert.ToDecimal(filaActual.Cells["salario"].Value);

                    // Crear objeto de la clase entTipoContrato
                    entTipoContrato tipoContrato = new entTipoContrato()
                    {
                        idTipoContrato = idTipoContrato,
                        nombre = nombre,
                        descripcion = descripcion,
                        salario = salario
                    };

                    // Asignar los valores a los controles del formulario
                    txtID.Text = tipoContrato.idTipoContrato.ToString();
                    txtNombre.Text = tipoContrato.nombre;
                    txtDescripcion.Text = tipoContrato.descripcion;
                    txtSalario.Text = tipoContrato.salario.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos del tipo de contrato: " + ex.Message);
                }
            }
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el ID del tipo de contrato desde el control TextBox
                int idTipoContrato = int.Parse(txtID.Text.Trim());

                // Invocar al método de la capa lógica para deshabilitar el tipo de contrato
                logEmpleado.Instancia.DeshabilitarTiposContrato(idTipoContrato);

                // Actualizar la vista (por ejemplo, recargar la lista de tipos de contrato)
                listarTiz();

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

    }
}
