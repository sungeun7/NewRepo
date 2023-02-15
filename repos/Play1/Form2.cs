using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Player
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = @"C:\Users\dokki\OneDrive\바탕화면\깨나라영상\2_2022-12-16_10-43-59_089.mkv";
            openFileDialog1.Filter = "Video File | *.mkv;";

            //axWindowsMediaPlayer1.URL = @"C:\Users\dokki\OneDrive\바탕화면\깨나라영상\2_2022-12-16_10-43-59_089.mkv";
        }
    }
}