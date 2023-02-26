namespace Zzz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Form2();
            f.MdiParent = this;
            f.Show();
        }

        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Form3();
            f.MdiParent = this;
            f.Show();
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form fr in MdiChildren)
                fr.Close();
        }

        private void noOfChildsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No. of childred is " + MdiChildren.Length);
        }

        private void maximizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Form fr in MdiChildren)
                fr.WindowState = FormWindowState.Maximized;
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form fr in MdiChildren)
                fr.WindowState = FormWindowState.Normal;
        }
        private void minimizeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form fr in MdiChildren)
                fr.WindowState = FormWindowState.Minimized;
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }
    }
}