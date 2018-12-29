namespace Graphics
{
    partial class frmSale
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnProRemove = new System.Windows.Forms.Button();
            this.btnProAdd = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnBillCancel = new System.Windows.Forms.Button();
            this.btnBillPay = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmmount = new System.Windows.Forms.TextBox();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lsProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSelectedID = new System.Windows.Forms.Label();
            this.txtSelectedPrice = new System.Windows.Forms.Label();
            this.txtSelectedName = new System.Windows.Forms.Label();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.button1);
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Location = new System.Drawing.Point(10, 12);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1153, 62);
            this.pnlTop.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(191)))), ((int)(((byte)(107)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(982, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tra cứu đơn hàng";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitle.Location = new System.Drawing.Point(7, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(246, 35);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Bán hàng";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.txtSelectedPrice);
            this.panel4.Controls.Add(this.txtSelectedName);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txtSelectedID);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(457, 87);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(259, 318);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.btnProRemove);
            this.panel5.Controls.Add(this.btnProAdd);
            this.panel5.Location = new System.Drawing.Point(457, 557);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(259, 78);
            this.panel5.TabIndex = 0;
            // 
            // btnProRemove
            // 
            this.btnProRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(77)))), ((int)(((byte)(75)))));
            this.btnProRemove.FlatAppearance.BorderSize = 0;
            this.btnProRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProRemove.ForeColor = System.Drawing.Color.White;
            this.btnProRemove.Location = new System.Drawing.Point(9, 5);
            this.btnProRemove.Name = "btnProRemove";
            this.btnProRemove.Size = new System.Drawing.Size(115, 64);
            this.btnProRemove.TabIndex = 0;
            this.btnProRemove.Text = "Bỏ ra";
            this.btnProRemove.UseVisualStyleBackColor = false;
            // 
            // btnProAdd
            // 
            this.btnProAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(191)))), ((int)(((byte)(107)))));
            this.btnProAdd.FlatAppearance.BorderSize = 0;
            this.btnProAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProAdd.ForeColor = System.Drawing.Color.White;
            this.btnProAdd.Location = new System.Drawing.Point(132, 5);
            this.btnProAdd.Name = "btnProAdd";
            this.btnProAdd.Size = new System.Drawing.Size(116, 64);
            this.btnProAdd.TabIndex = 0;
            this.btnProAdd.Text = "Thêm vào";
            this.btnProAdd.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.btnBillCancel);
            this.panel6.Controls.Add(this.btnBillPay);
            this.panel6.Location = new System.Drawing.Point(734, 557);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(428, 80);
            this.panel6.TabIndex = 0;
            // 
            // btnBillCancel
            // 
            this.btnBillCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(77)))), ((int)(((byte)(75)))));
            this.btnBillCancel.FlatAppearance.BorderSize = 0;
            this.btnBillCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillCancel.ForeColor = System.Drawing.Color.White;
            this.btnBillCancel.Location = new System.Drawing.Point(14, 10);
            this.btnBillCancel.Name = "btnBillCancel";
            this.btnBillCancel.Size = new System.Drawing.Size(198, 62);
            this.btnBillCancel.TabIndex = 0;
            this.btnBillCancel.Text = "Hủy";
            this.btnBillCancel.UseVisualStyleBackColor = false;
            // 
            // btnBillPay
            // 
            this.btnBillPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(191)))), ((int)(((byte)(107)))));
            this.btnBillPay.FlatAppearance.BorderSize = 0;
            this.btnBillPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillPay.ForeColor = System.Drawing.Color.White;
            this.btnBillPay.Location = new System.Drawing.Point(224, 10);
            this.btnBillPay.Name = "btnBillPay";
            this.btnBillPay.Size = new System.Drawing.Size(193, 62);
            this.btnBillPay.TabIndex = 0;
            this.btnBillPay.Text = "Thanh toán";
            this.btnBillPay.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.txtAmmount);
            this.panel7.Controls.Add(this.btnSub);
            this.panel7.Controls.Add(this.btnAdd);
            this.panel7.Location = new System.Drawing.Point(457, 421);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(259, 122);
            this.panel7.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(191)))), ((int)(((byte)(107)))));
            this.panel8.Location = new System.Drawing.Point(12, 49);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(234, 1);
            this.panel8.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số lượng";
            // 
            // txtAmmount
            // 
            this.txtAmmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtAmmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAmmount.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmmount.Location = new System.Drawing.Point(9, 22);
            this.txtAmmount.Name = "txtAmmount";
            this.txtAmmount.Size = new System.Drawing.Size(239, 26);
            this.txtAmmount.TabIndex = 1;
            this.txtAmmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(77)))), ((int)(((byte)(75)))));
            this.btnSub.FlatAppearance.BorderSize = 0;
            this.btnSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSub.ForeColor = System.Drawing.Color.White;
            this.btnSub.Location = new System.Drawing.Point(9, 66);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(115, 47);
            this.btnSub.TabIndex = 0;
            this.btnSub.Text = "Bớt";
            this.btnSub.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(191)))), ((int)(((byte)(107)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(132, 66);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 47);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // lsProducts
            // 
            this.lsProducts.AutoScroll = true;
            this.lsProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.lsProducts.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.lsProducts.Location = new System.Drawing.Point(10, 140);
            this.lsProducts.Name = "lsProducts";
            this.lsProducts.Size = new System.Drawing.Size(430, 495);
            this.lsProducts.TabIndex = 11;
            this.lsProducts.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtFilter);
            this.panel1.Location = new System.Drawing.Point(10, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 58);
            this.panel1.TabIndex = 0;
            // 
            // txtFilter
            // 
            this.txtFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFilter.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(9, 20);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(408, 26);
            this.txtFilter.TabIndex = 1;
            this.txtFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lọc sản phẩm theo tên";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(191)))), ((int)(((byte)(107)))));
            this.panel2.Location = new System.Drawing.Point(12, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(403, 1);
            this.panel2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thông tin sản phẩm đang chọn";
            // 
            // txtSelectedID
            // 
            this.txtSelectedID.AutoSize = true;
            this.txtSelectedID.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelectedID.Location = new System.Drawing.Point(48, 72);
            this.txtSelectedID.Name = "txtSelectedID";
            this.txtSelectedID.Size = new System.Drawing.Size(32, 30);
            this.txtSelectedID.TabIndex = 0;
            this.txtSelectedID.Text = "ID";
            // 
            // txtSelectedPrice
            // 
            this.txtSelectedPrice.AutoSize = true;
            this.txtSelectedPrice.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelectedPrice.Location = new System.Drawing.Point(48, 188);
            this.txtSelectedPrice.Name = "txtSelectedPrice";
            this.txtSelectedPrice.Size = new System.Drawing.Size(43, 30);
            this.txtSelectedPrice.TabIndex = 0;
            this.txtSelectedPrice.Text = "Giá";
            // 
            // txtSelectedName
            // 
            this.txtSelectedName.AutoSize = true;
            this.txtSelectedName.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelectedName.Location = new System.Drawing.Point(48, 144);
            this.txtSelectedName.Name = "txtSelectedName";
            this.txtSelectedName.Size = new System.Drawing.Size(45, 30);
            this.txtSelectedName.TabIndex = 0;
            this.txtSelectedName.Text = "Tên";
            // 
            // dgvBill
            // 
            this.dgvBill.AllowUserToDeleteRows = false;
            this.dgvBill.AllowUserToResizeRows = false;
            this.dgvBill.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.dgvBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.dgvBill.Location = new System.Drawing.Point(734, 87);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.ReadOnly = true;
            this.dgvBill.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(237)))), ((int)(((byte)(159)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvBill.RowHeadersWidth = 30;
            this.dgvBill.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(224)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.dgvBill.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBill.Size = new System.Drawing.Size(429, 456);
            this.dgvBill.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tổng";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tổng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tổng";
            // 
            // frmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1174, 649);
            this.Controls.Add(this.dgvBill);
            this.Controls.Add(this.lsProducts);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Canama- Bán hàng";
            this.pnlTop.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnBillCancel;
        private System.Windows.Forms.Button btnBillPay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnProRemove;
        private System.Windows.Forms.Button btnProAdd;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmmount;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.FlowLayoutPanel lsProducts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label txtSelectedPrice;
        private System.Windows.Forms.Label txtSelectedName;
        private System.Windows.Forms.Label txtSelectedID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}