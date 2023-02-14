using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zzz
{
    public partial class Form1 : Form
    {
        Image img;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            DialogResult dialog = openFileDialog.ShowDialog();

            if(dialog == DialogResult.OK)
            {
                img = Image.FromFile(openFileDialog.FileName);
                pictureBox.Image = img;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DialogResult dialog = saveFileDialog.ShowDialog();

            string ext = saveFileDialog.FileName.Substring(saveFileDialog.FileName.Length - 3).ToLower();

            if (ext == "jpg")
                img.Save(saveFileDialog.FileName,  ImageFormat.Jpeg);
            else if (ext == "png")
                img.Save(saveFileDialog.FileName, ImageFormat.Png);
            else
                MessageBox.Show("Please open file.");
        }
    }
}
