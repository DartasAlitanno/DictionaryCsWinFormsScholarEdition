using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1_F {
    public partial class SettingForm : Form {
        public SettingForm() {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void CloseBut_Click(object sender, EventArgs e) {
            this.Close();
        }

        Point lastPoint;
        private void HeadText_MouseMove(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void HeadText_MouseDown(object sender, MouseEventArgs e) {
            lastPoint = new Point(e.X, e.Y);
        }

        private void CloseBut_MouseEnter_1(object sender, EventArgs e) { CloseBut.Image = Image.FromFile(@"..\..\Images\exitOn.png"); }
        private void CloseBut_MouseLeave_1(object sender, EventArgs e) { CloseBut.Image = Image.FromFile(@"..\..\Images\exitOff.png"); }

    }
}
