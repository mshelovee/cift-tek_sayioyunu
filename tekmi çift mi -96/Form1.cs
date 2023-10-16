using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tekmi_çift_mi__96
{
    public partial class Form1 : Form
    {
        int sayi, puan = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnUret_Click(object sender, EventArgs e)
        {
            //Rastgele sayı sınıfı.
            Random rnd = new Random();

            int sayi = rnd.Next(0, 100);  //0 ile 100 arası rastgele sayı

            lblSayi.Text = sayi.ToString();
            btnCift.Enabled = true;
            btnTek.Enabled = true;
        }

        private void btnTek_Click(object sender, EventArgs e)
        {
            if (sayi % 2 == 0)
            {
                puan += 5;
            }
            else
            {
                puan -= 3;
            }
            lblPuan.Text = puan.ToString();
            btnCift.Enabled = false;
            btnTek.Enabled = false;
        }

        private void btnCift_Click(object sender, EventArgs e)
        {
            if (sayi % 2 != 0)
            {
                puan += 5;
            }
            else
            {
                puan -= 3;
            }
            lblPuan.Text = puan.ToString();
            btnCift.Enabled = false;
            btnTek.Enabled = false;
        }
    }
}
        
    
 