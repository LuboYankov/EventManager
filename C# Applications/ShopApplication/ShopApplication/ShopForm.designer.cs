﻿namespace ShopApplication
{
    partial class ShopForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbOrder = new System.Windows.Forms.ListBox();
            this.btnCompleteOrder = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbFood = new System.Windows.Forms.RadioButton();
            this.rbDrinks = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.btnRemoveFromOrder = new System.Windows.Forms.Button();
            this.rbOthers = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbItemName = new System.Windows.Forms.ListBox();
            this.lblCurrentInStock = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddNewProduct = new System.Windows.Forms.Button();
            this.btnUpdateNrInStock = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPriceSingleItem = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(129, 284);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(40, 18);
            this.lblTotalPrice.TabIndex = 8;
            this.lblTotalPrice.Text = "price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total price:";
            // 
            // lbOrder
            // 
            this.lbOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrder.FormattingEnabled = true;
            this.lbOrder.ItemHeight = 15;
            this.lbOrder.Location = new System.Drawing.Point(20, 45);
            this.lbOrder.Name = "lbOrder";
            this.lbOrder.Size = new System.Drawing.Size(410, 214);
            this.lbOrder.TabIndex = 0;
            // 
            // btnCompleteOrder
            // 
            this.btnCompleteOrder.Location = new System.Drawing.Point(20, 322);
            this.btnCompleteOrder.Name = "btnCompleteOrder";
            this.btnCompleteOrder.Size = new System.Drawing.Size(220, 60);
            this.btnCompleteOrder.TabIndex = 9;
            this.btnCompleteOrder.Text = "Complete order";
            this.btnCompleteOrder.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox3.Controls.Add(this.btnCompleteOrder);
            this.groupBox3.Controls.Add(this.lbOrder);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lblTotalPrice);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(631, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(449, 388);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Currently in the order:";
            // 
            // rbFood
            // 
            this.rbFood.AutoSize = true;
            this.rbFood.Location = new System.Drawing.Point(80, 24);
            this.rbFood.Name = "rbFood";
            this.rbFood.Size = new System.Drawing.Size(61, 22);
            this.rbFood.TabIndex = 0;
            this.rbFood.TabStop = true;
            this.rbFood.Text = "Food";
            this.rbFood.UseVisualStyleBackColor = true;
            this.rbFood.CheckedChanged += new System.EventHandler(this.rbFood_CheckedChanged);
            // 
            // rbDrinks
            // 
            this.rbDrinks.AutoSize = true;
            this.rbDrinks.Location = new System.Drawing.Point(147, 24);
            this.rbDrinks.Name = "rbDrinks";
            this.rbDrinks.Size = new System.Drawing.Size(69, 22);
            this.rbDrinks.TabIndex = 1;
            this.rbDrinks.TabStop = true;
            this.rbDrinks.Text = "Drinks";
            this.rbDrinks.UseVisualStyleBackColor = true;
            this.rbDrinks.CheckedChanged += new System.EventHandler(this.rbDrinks_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Item name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(378, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantity:";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantity.Location = new System.Drawing.Point(312, 107);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(197, 22);
            this.nudQuantity.TabIndex = 6;
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.Location = new System.Drawing.Point(312, 172);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(201, 63);
            this.btnAddToOrder.TabIndex = 12;
            this.btnAddToOrder.Text = "Add to order";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // btnRemoveFromOrder
            // 
            this.btnRemoveFromOrder.Location = new System.Drawing.Point(312, 261);
            this.btnRemoveFromOrder.Name = "btnRemoveFromOrder";
            this.btnRemoveFromOrder.Size = new System.Drawing.Size(201, 65);
            this.btnRemoveFromOrder.TabIndex = 13;
            this.btnRemoveFromOrder.Text = "Remove from order";
            this.btnRemoveFromOrder.UseVisualStyleBackColor = true;
            // 
            // rbOthers
            // 
            this.rbOthers.AutoSize = true;
            this.rbOthers.Location = new System.Drawing.Point(222, 24);
            this.rbOthers.Name = "rbOthers";
            this.rbOthers.Size = new System.Drawing.Size(71, 22);
            this.rbOthers.TabIndex = 16;
            this.rbOthers.TabStop = true;
            this.rbOthers.Text = "Others";
            this.rbOthers.UseVisualStyleBackColor = true;
            this.rbOthers.CheckedChanged += new System.EventHandler(this.rbOthers_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lblPriceSingleItem);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lbItemName);
            this.groupBox1.Controls.Add(this.lblCurrentInStock);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.rbOthers);
            this.groupBox1.Controls.Add(this.btnRemoveFromOrder);
            this.groupBox1.Controls.Add(this.btnAddToOrder);
            this.groupBox1.Controls.Add(this.nudQuantity);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rbDrinks);
            this.groupBox1.Controls.Add(this.rbFood);
            this.groupBox1.Location = new System.Drawing.Point(6, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(594, 481);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lbItemName
            // 
            this.lbItemName.FormattingEnabled = true;
            this.lbItemName.ItemHeight = 18;
            this.lbItemName.Location = new System.Drawing.Point(29, 107);
            this.lbItemName.Name = "lbItemName";
            this.lbItemName.Size = new System.Drawing.Size(245, 202);
            this.lbItemName.TabIndex = 21;
            this.lbItemName.SelectedIndexChanged += new System.EventHandler(this.lbItemName_SelectedIndexChanged);
            // 
            // lblCurrentInStock
            // 
            this.lblCurrentInStock.AutoSize = true;
            this.lblCurrentInStock.Location = new System.Drawing.Point(143, 329);
            this.lblCurrentInStock.Name = "lblCurrentInStock";
            this.lblCurrentInStock.Size = new System.Drawing.Size(106, 18);
            this.lblCurrentInStock.TabIndex = 20;
            this.lblCurrentInStock.Text = "current instock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Currently in stock:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(144, 403);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(20, 18);
            this.lblDescription.TabIndex = 18;
            this.lblDescription.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Item description:";
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.Location = new System.Drawing.Point(842, 407);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(183, 64);
            this.btnAddNewProduct.TabIndex = 12;
            this.btnAddNewProduct.Text = "Add a new product";
            this.btnAddNewProduct.UseVisualStyleBackColor = true;
            this.btnAddNewProduct.Click += new System.EventHandler(this.btnAddNewProduct_Click);
            // 
            // btnUpdateNrInStock
            // 
            this.btnUpdateNrInStock.Location = new System.Drawing.Point(631, 407);
            this.btnUpdateNrInStock.Name = "btnUpdateNrInStock";
            this.btnUpdateNrInStock.Size = new System.Drawing.Size(191, 64);
            this.btnUpdateNrInStock.TabIndex = 13;
            this.btnUpdateNrInStock.Text = "Update numbers in stock";
            this.btnUpdateNrInStock.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 18);
            this.label7.TabIndex = 22;
            this.label7.Text = "Price for a single item:";
            // 
            // lblPriceSingleItem
            // 
            this.lblPriceSingleItem.AutoSize = true;
            this.lblPriceSingleItem.Location = new System.Drawing.Point(170, 370);
            this.lblPriceSingleItem.Name = "lblPriceSingleItem";
            this.lblPriceSingleItem.Size = new System.Drawing.Size(0, 18);
            this.lblPriceSingleItem.TabIndex = 23;
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1092, 519);
            this.Controls.Add(this.btnUpdateNrInStock);
            this.Controls.Add(this.btnAddNewProduct);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ShopForm";
            this.Text = "Shop management Application";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShopForm_FormClosed);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbOrder;
        private System.Windows.Forms.Button btnCompleteOrder;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbFood;
        private System.Windows.Forms.RadioButton rbDrinks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.Button btnRemoveFromOrder;
        private System.Windows.Forms.RadioButton rbOthers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddNewProduct;
        private System.Windows.Forms.ListBox lbItemName;
        private System.Windows.Forms.Label lblCurrentInStock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdateNrInStock;
        private System.Windows.Forms.Label lblPriceSingleItem;
        private System.Windows.Forms.Label label7;
    }
}

