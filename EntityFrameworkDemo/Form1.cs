using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProductDal productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            dataGridView1.DataSource = productDal.GetAll();
        }

        private void SearchProducts(string key)
        {
            //dataGridView1.DataSource = productDal.GetAll().Where(p=>p.Name.ToLower().Contains(key.ToLower())).ToList();
            var result = productDal.GetbyName(key);
            dataGridView1.DataSource = result;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            productDal.Add(new Product
            {
                Name = txtUrunAdi.Text,
                UnitPrice = Convert.ToDecimal(txtUrunFiyat.Text),
                Stock = Convert.ToInt32(txtStok.Text)
            });
            MessageBox.Show("Eklendi");
            LoadProducts();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUrunAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtUrunFiyat.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtStok.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            productDal.Update(new Product
            {
                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                Name = txtUrunAdi.Text,
                UnitPrice = Convert.ToDecimal(txtUrunFiyat.Text),
                Stock = Convert.ToInt32(txtStok.Text)
            });
            LoadProducts();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult onay = MessageBox.Show("Silmek İstediğinizden Eminmisiniz.", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (onay == DialogResult.Yes)
            {
                //Silme Onayı
                productDal.Delete(new Product
                {
                    Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)
                });
                MessageBox.Show("Kayıt Silindi");
                LoadProducts();
            }
            else
            {
                MessageBox.Show("Silme işlemi iptal edildi. Madem silmeyecektin neyine bastın mubarek.");
                LoadProducts();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(txtSearch.Text);
        }
    }
}
