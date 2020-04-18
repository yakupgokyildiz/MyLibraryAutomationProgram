using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormKOS.Model;

namespace WinFormKOS
{
    public partial class FormEdit : Form
    {
        int rowId = 0;
        public FormEdit()
        {
            InitializeComponent();
        }

        private void FormEkle_Load(object sender, EventArgs e)
        {

        }

        string getTableName()
        {
            switch (cbbTableName.SelectedIndex)
            {
                case 0: 
                    return "yazarlar"; 
                case 1: 
                    return "yayinevleri";
                case 2: 
                    return "turler";
                case 3: 
                    return "dolaplar";
                default: return ""; 
            }
            
        }

        void tableLoad()
        {
            if (!string.IsNullOrEmpty(getTableName()))
            {
                dg.DataSource = IDataBase.DataToDataTable("select * from " + getTableName());
                dg.Columns["id"].Visible = false;
            }
        }

        void ekle()
        {
            IDataBase.executeNonQuery("insert into "+getTableName()+"(adi) values (@adi)",new SqlParameter("@adi", SqlDbType.VarChar){ Value=txtAd.Text});
            tableLoad();
            MessageBox.Show("Ekleme işlemi başarılı!");

        }

        void guncelle()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id", SqlDbType.Int) { Value = rowId });
            parameters.Add(new SqlParameter("@adi", SqlDbType.VarChar){ Value=txtAd.Text});

            IDataBase.executeNonQuery("update "+getTableName()+" set adi=@adi where id=@id",parameters);
            tableLoad();
            MessageBox.Show("Güncelleme işlemi başarılı!");
        }

        void temizle()
        {
            rowId = 0;
            txtAd.Text = "";
        }
        void sil()
        {
            IDataBase.executeNonQuery("Delete "+getTableName()+ " where id=@id", new SqlParameter("@id", SqlDbType.Int) { Value = rowId });
            temizle();
            tableLoad();
        }

        private void cbbTableName_SelectedIndexChanged(object sender, EventArgs e)
        {
            tableLoad();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(getTableName()))
            {
                MessageBox.Show("Lütfen Tablo Seçimi yapınız!");
                return;
            }
            if (rowId>0)
            {
                guncelle();
            }
            else
            {
                ekle();
            }
        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                rowId = Convert.ToInt32(dg.Rows[e.RowIndex].Cells["id"].Value);
                txtAd.Text = dg.Rows[e.RowIndex].Cells["adi"].Value.ToString();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (rowId>0)
            {
                DialogResult dialogResult = MessageBox.Show("Seçili Satırı Silmek İstediğinize Emin misiniz?", "Satırı Sil", MessageBoxButtons.YesNo);
                if (dialogResult==DialogResult.Yes)
                {
                    sil();

                }
                else
                {
                    MessageBox.Show("Silme işlemi iptal edilmiştir!");
                }

            }
            else
            {
                MessageBox.Show("Satır Seçiniz!");
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
