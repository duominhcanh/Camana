namespace Graphics
{
    partial class SaleProductListItem
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblID.Location = new System.Drawing.Point(10, 18);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(83, 41);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblID.Click += new System.EventHandler(this.Clicked);
            this.lblID.MouseEnter += new System.EventHandler(this.SaleProductListItem_MouseEnter);
            this.lblID.MouseLeave += new System.EventHandler(this.SaleProductListItem_MouseLeave);
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblName.Location = new System.Drawing.Point(99, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(176, 41);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Tên";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblName.Click += new System.EventHandler(this.Clicked);
            this.lblName.MouseEnter += new System.EventHandler(this.SaleProductListItem_MouseEnter);
            this.lblName.MouseLeave += new System.EventHandler(this.SaleProductListItem_MouseLeave);
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPrice.Location = new System.Drawing.Point(281, 18);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(123, 41);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "Giá";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPrice.Click += new System.EventHandler(this.Clicked);
            this.lblPrice.MouseEnter += new System.EventHandler(this.SaleProductListItem_MouseEnter);
            this.lblPrice.MouseLeave += new System.EventHandler(this.SaleProductListItem_MouseLeave);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(191)))), ((int)(((byte)(107)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(5, 77);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Click += new System.EventHandler(this.Clicked);
            // 
            // SaleProductListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SaleProductListItem";
            this.Size = new System.Drawing.Size(407, 77);
            this.Click += new System.EventHandler(this.Clicked);
            this.MouseEnter += new System.EventHandler(this.SaleProductListItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.SaleProductListItem_MouseLeave);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
