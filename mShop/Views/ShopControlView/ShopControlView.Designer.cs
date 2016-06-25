namespace mShop.Views
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
            this.pageChangerControl = new mShop.Views.PageChangerControl();
            this.SuspendLayout();
            // 
            // tbSearchProducts
            // 
            this.tbSearchProducts.Location = new System.Drawing.Point(3, 3);
            this.tbSearchProducts.Name = "tbSearchProducts";
            this.tbSearchProducts.Size = new System.Drawing.Size(100, 20);
            this.tbSearchProducts.TabIndex = 0;
            // 
            // cbSearchCategory
            // 
            this.cbSearchCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchCategory.FormattingEnabled = true;
            this.cbSearchCategory.Location = new System.Drawing.Point(109, 3);
            this.cbSearchCategory.Name = "cbSearchCategory";
            this.cbSearchCategory.Size = new System.Drawing.Size(121, 21);
            this.cbSearchCategory.TabIndex = 1;
            this.cbSearchCategory.SelectedIndexChanged += new System.EventHandler(this.cbSearchCategory_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(524, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gbProductsList
            // 
            this.gbProductsList.Location = new System.Drawing.Point(3, 29);
            this.gbProductsList.Name = "gbProductsList";
            this.gbProductsList.Size = new System.Drawing.Size(596, 373);
            this.gbProductsList.TabIndex = 4;
            this.gbProductsList.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(781, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(76, 23);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelCart
            // 
            this.panelCart.AutoScroll = true;
            this.panelCart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCart.Location = new System.Drawing.Point(605, 29);
            this.panelCart.Name = "panelCart";
            this.panelCart.Size = new System.Drawing.Size(251, 373);
            this.panelCart.TabIndex = 0;
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(781, 408);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(75, 23);
            this.btnSell.TabIndex = 6;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(236, 3);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(121, 21);
            this.cbCategory.TabIndex = 7;
            this.cbCategory.Visible = false;
            // 
            // tbLogin
            // 
            this.tbLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLogin.Location = new System.Drawing.Point(605, 10);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.ReadOnly = true;
            this.tbLogin.Size = new System.Drawing.Size(170, 13);
            this.tbLogin.TabIndex = 8;
            this.tbLogin.Text = "tbLogin";
            this.tbLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pageChangerControl
            // 
            this.pageChangerControl.Location = new System.Drawing.Point(201, 406);
            this.pageChangerControl.MaxNumberOfPages = 1;
            this.pageChangerControl.Name = "pageChangerControl";
            this.pageChangerControl.Size = new System.Drawing.Size(227, 29);
            this.pageChangerControl.TabIndex = 3;
            // 
            // ShopControlView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.panelCart);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.gbProductsList);
            this.Controls.Add(this.pageChangerControl);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbSearchCategory);
            this.Controls.Add(this.tbSearchProducts);
            this.Name = "ShopControlView";
            this.Size = new System.Drawing.Size(860, 438);
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
    }
}
