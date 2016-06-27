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
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbItem
            // 
            this.tbItem.BackColor = System.Drawing.SystemColors.Window;
            this.tbItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbItem.Location = new System.Drawing.Point(0, 8);
            this.tbItem.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.tbItem.Name = "tbItem";
            this.tbItem.Size = new System.Drawing.Size(345, 13);
            this.tbItem.TabIndex = 0;
            this.tbItem.TabStop = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(348, 2);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.btnRemove.Size = new System.Drawing.Size(26, 26);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "-";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // ShoppingCartControlView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.tbItem);
            this.Name = "ShoppingCartControlView";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(378, 31);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbItem;
        private System.Windows.Forms.Button btnRemove;
    }
}
