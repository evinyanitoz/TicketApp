using DevExpress.Utils.Extensions;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicketApp
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
        List<Bilet> bilets = new List<Bilet>()
            {

                new Bilet{

                BiletNo = "1",
                MusteriAdi="Evin",
                MusteriSoyadi="Yanitoz",
                Tarih=DateTime.Now,
                KoltukNo="1",
                Nereden="Adana",
                Nereye="Muğla",
                Arac="A280"
            }


            };
        private void Form1_Load(object sender, EventArgs e)
        {


            gridControl1.DataSource = bilets;




        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            YeniBiletForm yeniBiletForm = new YeniBiletForm();
            var r = yeniBiletForm.ShowDialog();
            if (r == DialogResult.OK)
            {
                bilets.Add(yeniBiletForm.kayit);
                gridControl1.RefreshDataSource();
            }



        }
    }

    public class Bilet
    {


        public string BiletNo { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriSoyadi { get; set; }
        public DateTime Tarih { get; set; }
        public string KoltukNo { get; set; }
        public string Nereden { get; set; }
        public string Nereye { get; set; }
        public string Arac { get; set; }


    }

}
