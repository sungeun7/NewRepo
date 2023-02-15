using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Play
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
            openFileDialog1.FileName = "2_2022-12-16_10-43-59_089.mkv"
            openFileDialog1.Filter = "Video File | *.mp4; *.mpg; *.mkv;"
            openFileDialog1.InitialDirectory = "C:\\Users\\dokki\\OneDrive\\문서\\회사\\Project\\깨끗한나라\\깨나라영상"
            openFileDialog1.ShowDialog()
            
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
