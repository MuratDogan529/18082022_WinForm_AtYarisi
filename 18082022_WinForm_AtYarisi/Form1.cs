using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18082022_WinForm_AtYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AtDurumDegistir(false);
            
        }
        //üstteki form1load için metot yazalım
        void AtDurumDegistir(bool durum,PictureBox at)
        {

            atAlver.Enabled = atGolgeYele.Enabled = atPoyraz.Enabled = atRuzgarGulu.
                Enabled = atYagiz.Enabled = durum;//atları durdurduk gif hareketsiz oldu
            at.Enabled = true;
        }
        void AtDurumDegistir(bool durum)//metot overload yaptık.
        {
            atAlver.Enabled = atGolgeYele.Enabled = atPoyraz.Enabled = atRuzgarGulu.
                Enabled = atYagiz.Enabled = durum;//atları durdurduk gif hareketsiz oldu
        }
        private void btnBaslat_Click(object sender, EventArgs e)
        {
            
            AtDurumDegistir(true);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            atYagiz.Left += rnd.Next(1,5); //next metoduyla rnd içinden değer seçiyoruz
            atRuzgarGulu.Left+= rnd.Next(1,5);//yani resimler rastgele ilerleyecek
            atPoyraz.Left+=rnd.Next(1,5);
            atAlver.Left+=rnd.Next(1,5);
            atGolgeYele.Left+=rnd.Next(1,5);

            KimKazandi(atYagiz);
            KimKazandi(atRuzgarGulu);
            KimKazandi(atPoyraz);
            KimKazandi(atAlver);
            KimKazandi(atGolgeYele);
        }
        void KimKazandi(PictureBox kazanan)
        {
            if (kazanan.Right - 17 >= label1.Left)
            {
                timer1.Stop();
                AtDurumDegistir(false, kazanan);
                MessageBox.Show(kazanan.Name);
            }
        }
    }
}
