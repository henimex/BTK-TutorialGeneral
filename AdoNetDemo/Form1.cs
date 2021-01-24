using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetDemo
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
            // TODO: This line of code loads data into the 'tradeDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.tradeDataSet.Products);

            LoadList();
        }

        private void LoadList()
        {
            dgwProducts.DataSource = productDal.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            productDal.Add(new Product
            {
                Name = txtUrunAdi.Text,
                UnitPrice = Convert.ToDecimal(txtUrunFiyat.Text),
                Stock = Convert.ToInt32(txtStok.Text)
            });

            MessageBox.Show("Ürün Eklendi");
            LoadList();
            txtStok.Clear();
            txtUrunAdi.Clear();
            txtUrunFiyat.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = txtUrunAdi.Text,
                UnitPrice = Convert.ToDecimal(txtUrunFiyat.Text),
                Stock = Convert.ToInt32(txtStok.Text)
            };
            productDal.Update(product);
            LoadList();
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUrunAdi.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            txtUrunFiyat.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            txtStok.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value);
            productDal.Delete(id);
            MessageBox.Show("Kayıt Silindi");
            LoadList();
        }

        private void dgwProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
