using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proces_ile_hesap_makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            process1.StartInfo.FileName = "calc.exe";
            process1.Start();
            //bu yolla bilgisayardaki farklı şeylere de ulaşılabilir...
            //chrome.exe yazılınca mesala chrome açar hemen...
            // mesala: "D:\\YEDEK\\ornekklasör\ornekdosya.txt"
        }

        private void button2_Click(object sender, EventArgs e)
        {

            process1.StartInfo.FileName = txt_acilacak_dosya.Text;
            process1.Start();
        }
    }
}
