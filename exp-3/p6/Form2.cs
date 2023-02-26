using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string name, string items, string payment)
        {
            InitializeComponent();
            label1.Text = name;
            label2.Text = items;
            label3.Text = payment;
        }
    }
}
