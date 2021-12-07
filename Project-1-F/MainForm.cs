using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Project_1_F {
    public partial class MainForm : Form {
        private Controller controller = new Controller();
        private XmlDocument xDoc = new XmlDocument();
        private string xPath = @"..\..\DataFile\";
        public MainForm() {
            InitializeComponent();
            SelecterBoxDic.DropDownStyle = ComboBoxStyle.DropDownList;
            this.StartPosition = FormStartPosition.CenterScreen;

            DirectoryInfo directoryInfo = new DirectoryInfo(xPath);
            FileInfo[] fileInfo = directoryInfo.GetFiles("*.xml");
            foreach (var item in fileInfo)  SelecterBoxDic.Items.Add(item.Name);
        }

        private void CloseBut_Click(object sender, EventArgs e) {
            Application.Exit();
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

        private void SearchIcon_Click(object sender, EventArgs e) {
            if (SelecterBoxDic.SelectedIndex != -1) {
                CenterText.Text = controller.Find(xDoc, WordTextInputBox.Text);
            } else CenterText.Text = "Словарь не выбран.";
        }

        private void WordTextInputBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                CenterText.Text = controller.Find(xDoc, WordTextInputBox.Text);
            }
        }

        private void SelecterBoxDic_SelectedIndexChanged(object sender, EventArgs e) {
            xDoc.Load(xPath + SelecterBoxDic.SelectedItem);
        }

        private void SettingBut_Click(object sender, EventArgs e) {
            SettingForm settingForm = new SettingForm();
            settingForm.Show();
        }

        private void DeleteWordBut_Click(object sender, EventArgs e) {
            if (SelecterBoxDic.SelectedIndex != -1) {
                DialogResult dialogResult = MessageBox.Show($"Вы уверены, что хотите удалить элемент \"{WordTextInputBox.Text}\"?", "Подтвердите", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) {
                    try {
                        if (WordTextInputBox.Text != "") CenterText.Text = controller.Remove(xDoc, WordTextInputBox.Text, xPath + SelecterBoxDic.SelectedItem.ToString());
                        else CenterText.Text = "Введите слово.";
                    } catch (Exception ex) {
                        CenterText.Text = "Исключение: " + ex.Message;
                    }
                } else if (dialogResult == DialogResult.No) {
                    CenterText.Text = "Удаление элемента отменено.";
                }
            } else CenterText.Text = "Словарь не выбран.";
        }

        //Изменение элемента при наведении на него курсора

        private void CloseBut_MouseEnter(object sender, EventArgs e) { CloseBut.ForeColor = Color.DarkOrange; }
        private void CloseBut_MouseLeave(object sender, EventArgs e) { CloseBut.ForeColor = Color.Black; }

        private void SearchIcon_MouseEnter(object sender, EventArgs e) { SearchIcon.Image = Image.FromFile(@"..\..\Images\searchIconOn.png"); }
        private void SearchIcon_MouseLeave(object sender, EventArgs e) { SearchIcon.Image = Image.FromFile(@"..\..\Images\searchIconOff.png"); }

        private void SettingBut_MouseEnter(object sender, EventArgs e) { SettingBut.Image = Image.FromFile(@"..\..\Images\settingOn.png"); }
        private void SettingBut_MouseLeave(object sender, EventArgs e) { SettingBut.Image = Image.FromFile(@"..\..\Images\settingOff.png"); }

        private void CloseBut_MouseEnter_1(object sender, EventArgs e) { CloseBut.Image = Image.FromFile(@"..\..\Images\exitOn.png"); }
        private void CloseBut_MouseLeave_1(object sender, EventArgs e) { CloseBut.Image = Image.FromFile(@"..\..\Images\exitOff.png"); }

        private void DeleteWordBut_MouseEnter(object sender, EventArgs e) { DeleteWordBut.Image = Image.FromFile(@"..\..\Images\deleteOn.png"); }
        private void DeleteWordBut_MouseLeave(object sender, EventArgs e) { DeleteWordBut.Image = Image.FromFile(@"..\..\Images\deleteOff.png"); }
    }
}
