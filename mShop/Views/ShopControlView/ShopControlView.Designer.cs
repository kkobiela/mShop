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
            this.tbSearchProductName = new System.Windows.Forms.TextBox();
            this.cbSearchCategory = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbProductsList = new System.Windows.Forms.GroupBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pageChangerControl = new mShop.Views.PageChangerControl();
            this.SuspendLayout();
            // 
            // tbSearchProductName
            // 
            this.tbSearchProductName.Location = new System.Drawing.Point(3, 3);
            this.tbSearchProductName.Name = "tbSearchProductName";
            this.tbSearchProductName.Size = new System.Drawing.Size(100, 20);
            this.tbSearchProductName.TabIndex = 0;
            // 
            // cbSearchCategory
            // 
            this.cbSearchCategory.FormattingEnabled = true;
            this.cbSearchCategory.Location = new System.Drawing.Point(110, 4);
            this.cbSearchCategory.Name = "cbSearchCategory";
            this.cbSearchCategory.Size = new System.Drawing.Size(121, 21);
            this.cbSearchCategory.TabIndex = 1;
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
            this.gbProductsList.Location = new System.Drawing.Point(3, 31);
            this.gbProductsList.Name = "gbProductsList";
            this.gbProductsList.Size = new System.Drawing.Size(596, 336);
            this.gbProductsList.TabIndex = 4;
            this.gbProductsList.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(6, 408);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(76, 23);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pageChangerControl
            // 
            this.pageChangerControl.Location = new System.Drawing.Point(3, 373);
            this.pageChangerControl.MaxNumberOfPages = 1;
            this.pageChangerControl.Name = "pageChangerControl";
            this.pageChangerControl.Size = new System.Drawing.Size(596, 29);
            this.pageChangerControl.TabIndex = 3;
            // 
            // ShopControlView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.gbProductsList);
            this.Controls.Add(this.pageChangerControl);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbSearchCategory);
            this.Controls.Add(this.tbSearchProductName);
            this.Name = "ShopControlView";
            this.Size = new System.Drawing.Size(602, 438);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSearchProductName;
        private System.Windows.Forms.ComboBox cbSearchCategory;
        private System.Windows.Forms.Button btnSearch;
        private PageChangerControl pageChangerControl;
        private System.Windows.Forms.GroupBox gbProductsList;
        private System.Windows.Forms.Button btnLogout;
    }
}
