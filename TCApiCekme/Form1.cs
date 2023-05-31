using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCApiCekme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sorgulaBtn_Click(object sender, EventArgs e)
        {

            /*
           WEB SERVİSLER HTTP PROTOKOLUNU KULLANARAK HİZMET SAĞLARLAR 
           İSTEMCİ YANİ CLİENT İSTEK ATAR VE BİR GERİ DÖNÜŞ GERÇEKLEŞİR 
           BU GERİ DÖNÜŞTE KULLLANILAN SERVİSE GÖRE XML , JSON VB YAPILAR KULLANILIR
           VE BİLGİ ALIŞVERİŞİ SAĞLANMIŞ OLUR
           BURADA TEXTBOXLAR ÜZERİNDEN GİRİLEN VERİLER ALINIP SORGULAMA YAPILIR VE GERİ DÖNÜŞ TİP OLARAK 
           TRUE YADA FALSE OLAN BOOL BİR DEĞER DÖNDÜRDÜK.
           AYRICA PROJEMİZE ADD SERVİCE REFERENCE DİYEREK DE URL MİZİ GEÇİRDİK


           */


            long kimlikNo = long.Parse(tcTxb.Text);
            int yil = int.Parse(dogumYiliTxb.Text);
            bool durum;

            try
            {
                using (Kimlik1.KPSPublicSoapClient service = new Kimlik1.KPSPublicSoapClient { })
                {
                    durum = service.TCKimlikNoDogrula(kimlikNo, adTxb.Text, soyadTxb.Text, yil);

                }

            }

            catch (Exception)
            {
                throw;

            }


            MessageBox.Show(durum.ToString());

        }
    }



}

