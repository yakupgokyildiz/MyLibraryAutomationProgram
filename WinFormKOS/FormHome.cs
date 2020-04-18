using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormKOS.Model;

namespace WinFormKOS
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            FormKitapEkle formKitapEkle = new FormKitapEkle();
            formKitapEkle.Show();

        }

        private void btnOkuyucuEkle_Click(object sender, EventArgs e)
        {
            FormOkuyucuEkle formOkuyucuEkle = new FormOkuyucuEkle();
            formOkuyucuEkle.Show();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            FormEdit formEdit = new FormEdit();
            formEdit.Show();
        }

        private void btnEmanetIslemleri_Click(object sender, EventArgs e)
        {
            FormEmanet formEmanet = new FormEmanet();
            formEmanet.Show();
        }

        private void btnIstatistik_Click(object sender, EventArgs e)
        {
            FormIstatistik formIstatistik = new FormIstatistik();
            formIstatistik.Show();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            
        }
        void dataGridViewLoad()
        {
            dgEmanetKitaplar.DataSource = IDataBase.DataToDataTable("select * from kitaplar where aktif=1 and durum=0");
            dgEmanetKitaplar.Columns["id"].Visible = false;
            dgMevcutKitaplar.DataSource = IDataBase.DataToDataTable("select * from kitaplar where aktif=1 and durum=1");
            dgMevcutKitaplar.Columns["id"].Visible = false;
            dgOkuyucular.DataSource = IDataBase.DataToDataTable("select * from okuyucular where aktif=1");
            dgOkuyucular.Columns["id"].Visible = false;
        }

        private void FormHome_Activated(object sender, EventArgs e)
        {
            dataGridViewLoad();
        }
    }
}
