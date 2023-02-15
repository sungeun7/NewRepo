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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<string> words = new List<string>();

            words.Add("A");
            words.Add("B");
            words.Add("C");
            words.Add("D");
            words.Add("E");
            words.Add("F");

            words.Remove("A"); // B, C, D, E, F
            words.RemoveAt(3); // B, C, D, F
            words.RemoveRange(0, 2); // D, F
            words.RemoveAll(s => s.StartsWith("D")); // F

            words.ForEach(
                delegate (string prime)
                {
                    Console.WriteLine(prime);
                }
            );
        }
    }
}
