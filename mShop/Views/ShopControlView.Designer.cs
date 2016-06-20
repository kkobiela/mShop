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
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.cbSearchOptions = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pageChangerControl = new mShop.Views.PageChangerControl();
            this.gbProductsList = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(3, 3);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(100, 20);
            this.tbSearch.TabIndex = 0;
            // 
            // cbSearchOptions
            // 
            this.cbSearchOptions.FormattingEnabled = true;
            this.cbSearchOptions.Location = new System.Drawing.Point(110, 4);
            this.cbSearchOptions.Name = "cbSearchOptions";
            this.cbSearchOptions.Size = new System.Drawing.Size(121, 21);
            this.cbSearchOptions.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(524, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // pageChangerControl
            // 
            this.pageChangerControl.Location = new System.Drawing.Point(3, 373);
            this.pageChangerControl.Name = "pageChangerControl";
            this.pageChangerControl.Size = new System.Drawing.Size(580, 29);
            this.pageChangerControl.TabIndex = 3;
            // 
            // gbProductsList
            // 
            this.gbProductsList.Location = new System.Drawing.Point(3, 31);
            this.gbProductsList.Name = "gbProductsList";
            this.gbProductsList.Size = new System.Drawing.Size(596, 336);
            this.gbProductsList.TabIndex = 4;
            this.gbProductsList.TabStop = false;
            // 
            // ShopControlView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbProductsList);
            this.Controls.Add(this.pageChangerControl);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbSearchOptions);
            this.Controls.Add(this.tbSearch);
            this.Name = "ShopControlView";
            this.Size = new System.Drawing.Size(602, 405);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ComboBox cbSearchOptions;
        private System.Windows.Forms.Button btnSearch;
        private PageChangerControl pageChangerControl;
        private System.Windows.Forms.GroupBox gbProductsList;
    }
}
