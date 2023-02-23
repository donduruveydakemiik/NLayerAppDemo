using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.Business.DependencyResolves.Ninject;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = new CategoryManager(new EfCategoryDal());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private IProductService _productService;
        private ICategoryService _categoryService;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();

        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName"; // görünen kategorinin adı
            cbxCategory.ValueMember = "CategoryId"; // Bize lazım olan kategori ıd
            cbxCategoryIdAdded.DataSource = _categoryService.GetAll();
            cbxCategoryIdAdded.DisplayMember = "CategoryName"; // görünen kategorinin adı
            cbxCategoryIdAdded.ValueMember = "CategoryId"; // Bize lazım olan kategori ıd
        }

        private void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)

        {
            try
            {


                dgwProduct.DataSource = _productService.GetProductByCategory(Convert.ToInt32(cbxCategory.SelectedValue));


            }
            catch
            {


            }

        }

        private void txtProduct_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtProduct.Text))
            {
                dgwProduct.DataSource = _productService.GetProductsByProductName(txtProduct.Text);
            }
            else
            {
                LoadProducts();
            }
        }

        private void btnAdded_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(
               new Product
               {
                   ProductName = txtProductNameAdded.Text,
                   UnitPrice = Convert.ToDecimal(txtProductPriceAdded.Text),
                   CategoryId = Convert.ToInt32(cbxCategoryIdAdded.SelectedValue),
                   UnitsInStock = Convert.ToInt16(txtStocksAmountAdded.Text),
                   QuantityPerUnit = txtUnitAmountAdded.Text

               });
                MessageBox.Show("Ürün Kaydedildi..");
                LoadProducts();

            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
           
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtProduct.Text = dgwProduct.CurrentRow.Cells[2].Value.ToString();
            txtProductNameAdded.Text = dgwProduct.CurrentRow.Cells[2].Value.ToString();
            cbxCategoryIdAdded.SelectedValue = dgwProduct.CurrentRow.Cells[1].Value;
            txtProductPriceAdded.Text = dgwProduct.CurrentRow.Cells[3].Value.ToString();
            txtStocksAmountAdded.Text = dgwProduct.CurrentRow.Cells[5].Value.ToString();
            txtUnitAmountAdded.Text = dgwProduct.CurrentRow.Cells[4].Value.ToString();
            dgwProduct.DataSource = _productService.GetProductsByProductName(dgwProduct.CurrentRow.Cells[2].Value.ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Update(new Product
                {
                    ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                    ProductName = txtProductNameAdded.Text,
                    UnitPrice = Convert.ToDecimal(txtProductPriceAdded.Text),
                    CategoryId = Convert.ToInt32(cbxCategoryIdAdded.SelectedValue),
                    UnitsInStock = Convert.ToInt16(txtStocksAmountAdded.Text),
                    QuantityPerUnit = txtUnitAmountAdded.Text
                });
                MessageBox.Show("Ürün Güncellendi.");
                LoadProducts();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgwProduct.CurrentRow!=null)
            {
                try
                {
                    _productService.Delete(new Product
                    {
                        ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value)
                    });
                    MessageBox.Show("Ürün Silindi.");
                    LoadProducts();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
              
            }
           
        }
    }

}
