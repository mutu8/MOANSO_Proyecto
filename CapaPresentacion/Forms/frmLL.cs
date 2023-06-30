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
    public partial class frmLL : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        public frmLL()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            ActivateButton(btnLicencias, RGBColors.color4);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            txtIdLicencia.Visible = false;
            LlenarCboEmpleados();
            LlenarCboTiposLicencias();
            listarLicencias();
            ColorDgv();
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
            ActivateButton(sender, RGBColors.color4);
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

        private void LlenarCboEmpleados()
        {
            cboEmpleado.DataSource = logEmpleado.Instancia.ListarEmpleadosCBO();
            cboEmpleado.DisplayMember = "nombre";
            cboEmpleado.ValueMember = "idEmpleado";
            cboEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void LlenarCboTiposLicencias()
        {
            cboTipoLicencia.DataSource = logEmpleado.Instancia.ListarTipoLicenciasCBO();
            cboTipoLicencia.DisplayMember = "nombreTipoLicencia"; // Update the DisplayMember property
            cboTipoLicencia.ValueMember = "idTipoLicencia";
            cboTipoLicencia.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        private void ColorDgv()
        {
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 12);
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Blue;
            this.dataGridView1.DefaultCellStyle.BackColor = Color.Beige;
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Black;

            //test
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ReadOnly = true;

            this.dgvConsulta.DefaultCellStyle.Font = new Font("Tahoma", 12);
            this.dgvConsulta.DefaultCellStyle.ForeColor = Color.Blue;
            this.dgvConsulta.DefaultCellStyle.BackColor = Color.Beige;
            this.dgvConsulta.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            this.dgvConsulta.DefaultCellStyle.SelectionBackColor = Color.Black;

            //test
            dgvConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvConsulta.ReadOnly = true;
        }

        private void listarLicencias()
        {
            dataGridView1.DataSource = logEmpleado.Instancia.ListarLicencias();
        }
        
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            DateTime horaSeleccionada = dateTimePickerFin.Value;

            // Actualizar el texto de la etiqueta con la hora seleccionada
            lblHora.Text = horaSeleccionada.ToString("HH:mm:ss");

            entLicencias licencia = new entLicencias();
            licencia.fecInicioLicencia = DateTime.Now;  // Set the start date of the license as the current date
            licencia.fecFinalLicencia = horaSeleccionada;  // Set the end date of the license as the selected time
            licencia.horaReg = horaSeleccionada.ToString("HH:mm:ss");
            licencia.estLicencia = true;
            licencia.idEmpleado = Convert.ToInt32(cboEmpleado.SelectedValue);  // Replace with the actual employee ID
            licencia.idTipoLicencia = Convert.ToInt32(cboTipoLicencia.SelectedValue);  // Replace with the actual type of license ID

            logEmpleado.Instancia.InsertarLicencia(licencia);
            listarLicencias();
        }

        

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dataGridView1.Rows[e.RowIndex]; //
            txtIdLicencia.Text = filaActual.Cells[0].Value.ToString();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entLicencias c = new entLicencias();
                c.idLicencia = int.Parse(txtIdLicencia.Text.Trim());
                chkEstC.Checked = false;
                c.estLicencia = chkEstC.Checked;
                logEmpleado.Instancia.DeshabilitarLicencia(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            listarLicencias();
            //LimpiarItem();

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int idEmpleado = int.Parse(txtConsulta.Text);

            entLicencias licencia = logEmpleado.Instancia.BuscarLicenciasPorID(idEmpleado);

            if (licencia != null)
            {
                if (dgvConsulta.Columns.Count == 0)
                {
                    
                    // Agregar las columnas al DataGridView si aún no se han agregado
                    dgvConsulta.Columns.Add("idLicencia", "ID Licencia");
                    dgvConsulta.Columns.Add("fecInicioLicencia", "Fecha Inicio");
                    dgvConsulta.Columns.Add("fecFinalLicencia", "Fecha Fin");
                    dgvConsulta.Columns.Add("horaReg", "Hora Registro");
                    dgvConsulta.Columns.Add("estLicencia", "Estado Licencia");
                    dgvConsulta.Columns.Add("idEmpleado", "ID Empleado");
                    dgvConsulta.Columns.Add("idTipoLicencia", "ID Tipo Licencia");
                    dgvConsulta.Columns.Add("nombreEmpleado", "Nombre Empleado");
                }

                // Limpiar el DataGridView antes de agregar los datos
                dgvConsulta.Rows.Clear();

                // Agregar una nueva fila al DataGridView con los datos de la licencia
                dgvConsulta.Rows.Add(
                    licencia.idLicencia,
                    licencia.fecInicioLicencia.ToString("dd/MM/yyyy"),
                    licencia.fecFinalLicencia.ToString("dd/MM/yyyy"),
                    licencia.horaReg,
                    licencia.estLicencia,
                    licencia.idEmpleado,
                    licencia.idTipoLicencia,
                    licencia.nombreEmpleado
                );

                MessageBox.Show("Licencia encontrada para el empleado: " + licencia.nombreEmpleado);
            }
            else
            {
                MessageBox.Show("No se encontraron licencias para el empleado con ID: " + idEmpleado);
            }
        }


    }
}
