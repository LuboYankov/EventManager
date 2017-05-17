﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApplication
{
    public partial class AddProductForm : Form
    {
        private List<ProductType> typesList;
        private RestClient rClient;
        private ShopForm sForm;
        public AddProductForm(RestClient rClient, ShopForm sForm)
        {
            InitializeComponent();
            this.sForm = sForm;
            this.rClient = rClient;
            #region Putting enums in a list and into the combobox.
            typesList = Enum.GetValues(typeof(ProductType)).Cast<ProductType>().ToList();
            foreach (ProductType pt in typesList)
            {
                cbType.Items.Add(pt);
            }
            #endregion


        }


        private void btnAddProduct_Click(object sender, EventArgs e)
        {
           

            try
            {
                if (tbNewProdName.Text == "" || rtbNewDescription.Text == "" || nudNewQuantity.Value == 0 || nudNewPrice.Value == 0)
                {
                    throw new Exception("Fill in the fields with appropriate values. Don't leave empty" +
                        "textboxes or '0' as a value in either of the numeric up and downs.");
                }
                ProductType type = typesList[cbType.SelectedIndex];

                Product p = new Product(tbNewProdName.Text, rtbNewDescription.Text, Convert.ToDouble(nudNewPrice.Value),
                    Convert.ToInt32(nudNewQuantity.Value), type);

                if (rClient.AddProduct(p))
                {
                    ShopForm.shop.Products = rClient.GetAllProducts();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
