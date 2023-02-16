/*
Design form to select image name from list and display in picture box. 
*/
namespace Zzz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex == 0)
            {
                pictureBox.ImageLocation = "z://pic1.jpg";
            }
            else if (listBox.SelectedIndex == 1)
            {
                pictureBox.ImageLocation = "z://pic2.jpg";
            }
            else if (listBox.SelectedIndex == 2)
            {
                pictureBox.ImageLocation = "z://pic3.jpg";
            }
            else
            {
                pictureBox.ImageLocation = "z://pic4.jpg";
            }
        }
    }
}