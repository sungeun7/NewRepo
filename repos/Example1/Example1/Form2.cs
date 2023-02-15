using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<int> candidates = new List<int>();
            for (int i = 2; i <= 20; i++)
            {
                candidates.Add(i);
            }

            for (int factor = 2; factor <= 10; factor++)
            {
                candidates.RemoveAll(delegate (int x)
                { return x > factor && x % factor == 0; });
            }

            candidates.ForEach(delegate (int prime)
            { Console.WriteLine(prime); }
               );

        }
    }
}
