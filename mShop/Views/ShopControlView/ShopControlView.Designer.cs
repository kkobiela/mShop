﻿namespace mShop.Views
{
    partial class ShopControlView
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
            this.tbSearchProducts = new System.Windows.Forms.TextBox();
            this.cbSearchCategory = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbProductsList = new System.Windows.Forms.GroupBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelCart = new System.Windows.Forms.Panel();
            this.btnSell = new System.Windows.Forms.Button();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.labelSumText = new System.Windows.Forms.Label();
            this.labelSumOfAllPrices = new System.Windows.Forms.Label();
            this.pageChangerControl = new mShop.Views.PageChangerControl();
            this.SuspendLayout();
            // 
            // tbSearchProducts
            // 
            this.tbSearchProducts.BackColor = System.Drawing.Color.Ivory;
            this.tbSearchProducts.Location = new System.Drawing.Point(3, 3);
            this.tbSearchProducts.Name = "tbSearchProducts";
            this.tbSearchProducts.Size = new System.Drawing.Size(100, 20);
            this.tbSearchProducts.TabIndex = 0;
            this.tbSearchProducts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterKeyPressSearch);
            // 
            // cbSearchCategory
            // 
            this.cbSearchCategory.BackColor = System.Drawing.Color.Wheat;
            this.cbSearchCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchCategory.FormattingEnabled = true;
            this.cbSearchCategory.Location = new System.Drawing.Point(109, 3);
            this.cbSearchCategory.Name = "cbSearchCategory";
            this.cbSearchCategory.Size = new System.Drawing.Size(121, 21);
            this.cbSearchCategory.TabIndex = 1;
            this.cbSearchCategory.SelectedIndexChanged += new System.EventHandler(this.cbSearchCategory_SelectedIndexChanged);
            this.cbSearchCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterKeyPressSearch);
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnSearch.BackColor = System.Drawing.Color.Wheat;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSearch.Location = new System.Drawing.Point(524, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gbProductsList
            // 
            this.gbProductsList.BackColor = System.Drawing.Color.OldLace;
            this.gbProductsList.Location = new System.Drawing.Point(3, 29);
            this.gbProductsList.Name = "gbProductsList";
            this.gbProductsList.Size = new System.Drawing.Size(596, 373);
            this.gbProductsList.TabIndex = 4;
            this.gbProductsList.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Wheat;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogout.Location = new System.Drawing.Point(929, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(76, 23);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelCart
            // 
            this.panelCart.AutoScroll = true;
            this.panelCart.BackColor = System.Drawing.SystemColors.Window;
            this.panelCart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCart.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panelCart.Location = new System.Drawing.Point(605, 33);
            this.panelCart.Name = "panelCart";
            this.panelCart.Size = new System.Drawing.Size(400, 369);
            this.panelCart.TabIndex = 6;
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSell.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSell.Location = new System.Drawing.Point(929, 408);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(75, 23);
            this.btnSell.TabIndex = 7;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.Color.Wheat;
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(236, 3);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(121, 21);
            this.cbCategory.TabIndex = 2;
            this.cbCategory.Visible = false;
            this.cbCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterKeyPressSearch);
            // 
            // tbLogin
            // 
            this.tbLogin.BackColor = System.Drawing.Color.OldLace;
            this.tbLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLogin.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbLogin.Location = new System.Drawing.Point(753, 9);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.ReadOnly = true;
            this.tbLogin.Size = new System.Drawing.Size(170, 13);
            this.tbLogin.TabIndex = 11;
            this.tbLogin.TabStop = false;
            this.tbLogin.Text = "user";
            this.tbLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelSumText
            // 
            this.labelSumText.AutoSize = true;
            this.labelSumText.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSumText.Location = new System.Drawing.Point(773, 413);
            this.labelSumText.Name = "labelSumText";
            this.labelSumText.Size = new System.Drawing.Size(39, 13);
            this.labelSumText.TabIndex = 10;
            this.labelSumText.Text = "Sum:";
            // 
            // labelSumOfAllPrices
            // 
            this.labelSumOfAllPrices.AutoSize = true;
            this.labelSumOfAllPrices.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSumOfAllPrices.Location = new System.Drawing.Point(810, 411);
            this.labelSumOfAllPrices.Name = "labelSumOfAllPrices";
            this.labelSumOfAllPrices.Size = new System.Drawing.Size(15, 16);
            this.labelSumOfAllPrices.TabIndex = 11;
            this.labelSumOfAllPrices.Text = "-";
            // 
            // pageChangerControl
            // 
            this.pageChangerControl.BackColor = System.Drawing.Color.OldLace;
            this.pageChangerControl.Location = new System.Drawing.Point(201, 406);
            this.pageChangerControl.MaxNumberOfPages = 1;
            this.pageChangerControl.Name = "pageChangerControl";
            this.pageChangerControl.Size = new System.Drawing.Size(227, 29);
            this.pageChangerControl.TabIndex = 5;
            // 
            // ShopControlView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.Controls.Add(this.labelSumOfAllPrices);
            this.Controls.Add(this.labelSumText);
            this.Controls.Add(this.panelCart);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.gbProductsList);
            this.Controls.Add(this.pageChangerControl);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbSearchCategory);
            this.Controls.Add(this.tbSearchProducts);
            this.Name = "ShopControlView";
            this.Size = new System.Drawing.Size(1024, 438);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSearchProducts;
        private System.Windows.Forms.ComboBox cbSearchCategory;
        private System.Windows.Forms.Button btnSearch;
        private PageChangerControl pageChangerControl;
        private System.Windows.Forms.GroupBox gbProductsList;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelCart;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label labelSumText;
        private System.Windows.Forms.Label labelSumOfAllPrices;
    }
}
