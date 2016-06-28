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
            this.labelSumText = new System.Windows.Forms.Label();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.pageChangerControl = new mShop.Views.PageChangerControl();
            this.SuspendLayout();
            // 
            // tbSearchProducts
            // 
            this.tbSearchProducts.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbSearchProducts.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbSearchProducts.Location = new System.Drawing.Point(3, 3);
            this.tbSearchProducts.Name = "tbSearchProducts";
            this.tbSearchProducts.Size = new System.Drawing.Size(100, 21);
            this.tbSearchProducts.TabIndex = 0;
            this.tbSearchProducts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterKeyPressSearch);
            // 
            // cbSearchCategory
            // 
            this.cbSearchCategory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbSearchCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchCategory.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
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
            this.btnSearch.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(524, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 28);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gbProductsList
            // 
            this.gbProductsList.BackColor = System.Drawing.Color.Gainsboro;
            this.gbProductsList.Location = new System.Drawing.Point(3, 33);
            this.gbProductsList.Name = "gbProductsList";
            this.gbProductsList.Size = new System.Drawing.Size(596, 375);
            this.gbProductsList.TabIndex = 4;
            this.gbProductsList.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogout.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.Location = new System.Drawing.Point(929, 1);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(76, 31);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelCart
            // 
            this.panelCart.AutoScroll = true;
            this.panelCart.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelCart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCart.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panelCart.Location = new System.Drawing.Point(605, 33);
            this.panelCart.Name = "panelCart";
            this.panelCart.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.panelCart.Size = new System.Drawing.Size(400, 371);
            this.panelCart.TabIndex = 6;
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSell.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSell.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSell.Location = new System.Drawing.Point(929, 414);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(75, 31);
            this.btnSell.TabIndex = 7;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
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
            this.tbLogin.BackColor = System.Drawing.Color.Gainsboro;
            this.tbLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLogin.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbLogin.Location = new System.Drawing.Point(753, 9);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.ReadOnly = true;
            this.tbLogin.Size = new System.Drawing.Size(170, 15);
            this.tbLogin.TabIndex = 11;
            this.tbLogin.TabStop = false;
            this.tbLogin.Text = "user";
            this.tbLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelSumText
            // 
            this.labelSumText.AutoSize = true;
            this.labelSumText.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSumText.Location = new System.Drawing.Point(772, 415);
            this.labelSumText.Name = "labelSumText";
            this.labelSumText.Size = new System.Drawing.Size(32, 14);
            this.labelSumText.TabIndex = 10;
            this.labelSumText.Text = "Sum:";
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbTotalPrice.Location = new System.Drawing.Point(810, 415);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(11, 15);
            this.lbTotalPrice.TabIndex = 11;
            this.lbTotalPrice.Text = "-";
            // 
            // pageChangerControl
            // 
            this.pageChangerControl.BackColor = System.Drawing.Color.Gainsboro;
            this.pageChangerControl.Location = new System.Drawing.Point(200, 415);
            this.pageChangerControl.MaxNumberOfPages = 1;
            this.pageChangerControl.Name = "pageChangerControl";
            this.pageChangerControl.Size = new System.Drawing.Size(227, 29);
            this.pageChangerControl.TabIndex = 5;
            // 
            // ShopControlView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.lbTotalPrice);
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
            this.Size = new System.Drawing.Size(1024, 449);
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
        private System.Windows.Forms.Label lbTotalPrice;
    }
}
