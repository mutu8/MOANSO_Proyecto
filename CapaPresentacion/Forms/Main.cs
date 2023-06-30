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
using FontAwesome.Sharp;

namespace CapaPresentacion
{
    public partial class Main : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        public Main()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        public struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
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
            ActivateButton(sender, RGBColors.color1);
            this.Hide();
            frmEmpleado frm = new frmEmpleado();
            frm.Show();
        }

        private void btnCargos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            this.Hide();
            frmCargos frm = new frmCargos();
            frm.Show();
        }

        private void btnAsistencias_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            this.Hide();
            frmAsistencia frm = new frmAsistencia();
            frm.Show();
        }

        private void btnLicencias_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            this.Hide();
            frmLL frm = new frmLL();
            frm.Show();
        }

        private void btnContratos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            this.Hide();
            frmContratos frm = new frmContratos();
            frm.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            this.Hide();
            frmTiposLicencia frm = new frmTiposLicencia();
            frm.Show();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YA SE ENCUENTRA EN EL MENÙ");
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
            MessageBox.Show("YA SE ENCUENTRA EN EL MENÚ DE INICIO");        
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            Application.Exit();
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
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
    }
}
