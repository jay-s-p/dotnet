namespace p6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string name = null;
        string items = null;
        string payment = null;

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            name = "Hello " + inputName.Text;
            if (checkTV.Checked)
            {
                items = "Television";
                if (checkRadio.Checked)
                    items += " and Radio.";
            }
            else
                items = "Radio.";
            items = "Your items are " + items;
            if (radioCOD.Checked)
                payment = "COD";
            else
                payment = "Online Payment";
            payment = "Your payment is " + payment;

            Form2 form2 = new Form2(name, items, payment);
            form2.Show();
        }
    }
}