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
    public partial class frmCargos : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        public frmCargos()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            ActivateButton(btnCargos, RGBColors.color2);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            datePiker.Value = DateTime.Now;
            datePiker.Enabled = false;
            btnGuardar.Visible = false;
            label5.Visible = false;
            txtID.Visible = false;
            //Metodos
            ColorDgv();
            listarCargos();
            LlenarCboArea();      
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
                btnGuardar.Visible = false;

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
            ActivateButton(sender, RGBColors.color2);
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
            this.Hide();
            frmTiposLicencia frm = new frmTiposLicencia();
            frm.Show();
        }



        private void iconButton1_Click(object sender, EventArgs e)
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
        private void ColorDgv() 
        {
            this.dgvCargos.DefaultCellStyle.Font = new Font("Tahoma", 12);
            this.dgvCargos.DefaultCellStyle.ForeColor = Color.Blue;
            this.dgvCargos.DefaultCellStyle.BackColor = Color.Beige;
            this.dgvCargos.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            this.dgvCargos.DefaultCellStyle.SelectionBackColor = Color.Black;

            //test
            dgvCargos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCargos.ReadOnly = true;
        }

        private void LlenarCboArea() 
        {
            cboArea.DataSource = logEmpleado.Instancia.ListarArea();
            cboArea.DisplayMember = "nombre";
            cboArea.ValueMember = "idArea";
            cboArea.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                entCargos c = new entCargos();
                c.nombre = txtNombre.Text.Trim();
                c.descripcion = txtDescripcion.Text.Trim();
                c.fecRegCargo = datePiker.Value;
                c.estCargo = chkEst.Checked;
                c.idArea = (int)cboArea.SelectedValue;
                logEmpleado.Instancia.InsertarCargos(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            listarCargos();
            LimpiarItem();
        }
        private void listarCargos()
        {
            dgvCargos.DataSource = logEmpleado.Instancia.ListarCargos();
        }
        private void LimpiarItem() 
        {
            cboArea.SelectedIndex = -1;
            txtDescripcion.Text = "";
            txtNombre.Text = "";
            datePiker.Value = DateTime.Now;
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
                label5.Visible = true;
                datePiker.Enabled = true;
                btnGuardar.Visible = true;
                btnRegistrar.Visible = false;
                txtID.Visible = true;
                txtID.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                entCargos c = new entCargos();
                c.idCargo = int.Parse(txtID.Text.Trim());
                c.nombre = txtNombre.Text.Trim();
                c.descripcion = txtDescripcion.Text.Trim();
                c.fecRegCargo = datePiker.Value;
                c.estCargo = chkEst.Checked;
                c.idArea = (int)cboArea.SelectedValue;
                logEmpleado.Instancia.EditaCargos(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            btnGuardar.Visible = false;
            label5.Visible = false;
            txtID.Visible = false;
            btnRegistrar.Visible = true;
            listarCargos();
            LimpiarItem();
        }

        private void dgvCargos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvCargos.Rows[e.RowIndex]; //
            txtID.Text = filaActual.Cells[0].Value.ToString();
            txtNombre.Text = filaActual.Cells[1].Value.ToString();
            txtDescripcion.Text = filaActual.Cells[2].Value.ToString();
            datePiker.Text = filaActual.Cells[3].Value.ToString();
            chkEst.Checked = Convert.ToBoolean(filaActual.Cells[4].Value);
            cboArea.Text = filaActual.Cells[5].Value.ToString(); 
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                entCargos c = new entCargos();
                c.idCargo = int.Parse(txtID.Text.Trim());
                chkEst.Checked = false;
                c.estCargo = chkEst.Checked;
                logEmpleado.Instancia.DeshabilitarCargos(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            
            listarCargos();
        }
    }
}
