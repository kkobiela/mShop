namespace mShop.Views
{
    partial class ProductControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbBrand = new System.Windows.Forms.TextBox();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbAvailableQuantity = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.labelPriceText = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(3, 3);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(32, 32);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(459, 16);
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(93, 20);
            this.numericUpDownQuantity.TabIndex = 2;
            // 
            // tbName
            // 
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbName.Location = new System.Drawing.Point(41, 11);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(207, 15);
            this.tbName.TabIndex = 4;
            this.tbName.Text = "Proszek do prania";
            // 
            // tbBrand
            // 
            this.tbBrand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbBrand.Location = new System.Drawing.Point(254, 11);
            this.tbBrand.Name = "tbBrand";
            this.tbBrand.ReadOnly = true;
            this.tbBrand.Size = new System.Drawing.Size(118, 15);
            this.tbBrand.TabIndex = 5;
            this.tbBrand.Text = "Ariel";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(456, 0);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(49, 13);
            this.lbQuantity.TabIndex = 6;
            this.lbQuantity.Text = "Quantity:";
            // 
            // lbAvailableQuantity
            // 
            this.lbAvailableQuantity.AutoSize = true;
            this.lbAvailableQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbAvailableQuantity.Location = new System.Drawing.Point(500, 1);
            this.lbAvailableQuantity.Name = "lbAvailableQuantity";
            this.lbAvailableQuantity.Size = new System.Drawing.Size(35, 13);
            this.lbAvailableQuantity.TabIndex = 7;
            this.lbAvailableQuantity.Text = "1021";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.LawnGreen;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.Location = new System.Drawing.Point(558, 3);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(32, 32);
            this.btnAddToCart.TabIndex = 8;
            this.btnAddToCart.Text = "+";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // labelPriceText
            // 
            this.labelPriceText.AutoSize = true;
            this.labelPriceText.Location = new System.Drawing.Point(378, 11);
            this.labelPriceText.Name = "labelPriceText";
            this.labelPriceText.Size = new System.Drawing.Size(34, 13);
            this.labelPriceText.TabIndex = 9;
            this.labelPriceText.Text = "Price:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPrice.Location = new System.Drawing.Point(407, 12);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(47, 13);
            this.labelPrice.TabIndex = 10;
            this.labelPrice.Text = "1,98 zł";
            // 
            // ProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelPriceText);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.lbAvailableQuantity);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.tbBrand);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.pbImage);
            this.Name = "ProductControl";
            this.Size = new System.Drawing.Size(593, 38);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbBrand;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbAvailableQuantity;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Label labelPriceText;
        private System.Windows.Forms.Label labelPrice;
    }
}
