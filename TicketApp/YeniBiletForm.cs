using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketApp
{
    public partial class YeniBiletForm : DevExpress.XtraEditors.XtraForm
    {
        public YeniBiletForm()
        {
            InitializeComponent();
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        public Bilet kayit { get; set; }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
           var bilet=new Bilet();
            bilet.BiletNo = BiletNo.Text;
            bilet.KoltukNo = txtKoltuk.Text;
            bilet.Arac = txtArac.Text;
            bilet.MusteriAdi=txtMusteri.Text; 
            bilet.MusteriSoyadi=txtMusteriSoyadi.Text;  
            bilet.Nereden=cmbNereden.SelectedItem.ToString();
            bilet.Nereye=cmbNereye.SelectedItem.ToString();
            bilet.Tarih = dtTarih.DateTime;


            kayit = bilet;
         DialogResult= DialogResult.OK; 
        }
        
    }
}