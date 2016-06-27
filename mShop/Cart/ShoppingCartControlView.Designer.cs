namespace mShop.Cart
{
    partial class ShoppingCartControlView
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
            this.tbItem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbItem
            // 
            this.tbItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbItem.Enabled = false;
            this.tbItem.Location = new System.Drawing.Point(0, 0);
            this.tbItem.Name = "tbItem";
            this.tbItem.ReadOnly = true;
            this.tbItem.Size = new System.Drawing.Size(250, 13);
            this.tbItem.TabIndex = 0;
            // 
            // ShoppingCartControlView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbItem);
            this.Name = "ShoppingCartControlView";
            this.Size = new System.Drawing.Size(300, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbItem;
    }
}
