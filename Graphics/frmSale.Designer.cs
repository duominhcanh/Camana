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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlCount = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmmount = new System.Windows.Forms.TextBox();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnProAdd = new System.Windows.Forms.Button();
            this.btnProRemove = new System.Windows.Forms.Button();
            this.pnlProAction = new System.Windows.Forms.Panel();
            this.btnBillPay = new System.Windows.Forms.Button();
            this.btnBillCancel = new System.Windows.Forms.Button();
            this.pnlPay = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSumAll = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnFindBill = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblUserEmpName = new System.Windows.Forms.Label();
            this.lsProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSelectedID = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.txtSelectedName = new System.Windows.Forms.Label();
            this.txtSelectedPrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlItemEdit = new System.Windows.Forms.Panel();
            this.btnEditContinue = new System.Windows.Forms.Button();
            this.btnEditOut = new System.Windows.Forms.Button();
            this.btnEditOK = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.txtnewBillID = new System.Windows.Forms.Label();
            this.pnlCount.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlProAction.SuspendLayout();
            this.pnlPay.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.panel4.SuspendLayout();
            this.pnlItemEdit.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCount
            // 
            this.pnlCount.BackColor = System.Drawing.Color.White;
            this.pnlCount.Controls.Add(this.panel8);
            this.pnlCount.Controls.Add(this.label1);
            this.pnlCount.Controls.Add(this.txtAmmount);
            this.pnlCount.Controls.Add(this.btnSub);
            this.pnlCount.Controls.Add(this.btnAdd);
            this.pnlCount.Location = new System.Drawing.Point(457, 421);
            this.pnlCount.Name = "pnlCount";
            this.pnlCount.Size = new System.Drawing.Size(259, 122);
            this.pnlCount.TabIndex = 0;
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
            this.btnSub.Text = "- Số lượng";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
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
            this.btnAdd.Text = "+ Số lượng";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(191)))), ((int)(((byte)(107)))));
            this.panel2.Location = new System.Drawing.Point(12, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(403, 1);
            this.panel2.TabIndex = 4;
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
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
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
            this.btnProAdd.Text = "Thêm vào bill";
            this.btnProAdd.UseVisualStyleBackColor = false;
            this.btnProAdd.Click += new System.EventHandler(this.btnProAdd_Click);
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
            this.btnProRemove.Click += new System.EventHandler(this.btnProRemove_Click);
            // 
            // pnlProAction
            // 
            this.pnlProAction.BackColor = System.Drawing.Color.White;
            this.pnlProAction.Controls.Add(this.btnProRemove);
            this.pnlProAction.Controls.Add(this.btnProAdd);
            this.pnlProAction.Location = new System.Drawing.Point(457, 557);
            this.pnlProAction.Name = "pnlProAction";
            this.pnlProAction.Size = new System.Drawing.Size(259, 78);
            this.pnlProAction.TabIndex = 0;
            // 
            // btnBillPay
            // 
            this.btnBillPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(191)))), ((int)(((byte)(107)))));
            this.btnBillPay.FlatAppearance.BorderSize = 0;
            this.btnBillPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillPay.ForeColor = System.Drawing.Color.White;
            this.btnBillPay.Location = new System.Drawing.Point(224, 53);
            this.btnBillPay.Name = "btnBillPay";
            this.btnBillPay.Size = new System.Drawing.Size(193, 62);
            this.btnBillPay.TabIndex = 0;
            this.btnBillPay.Text = "Thanh toán";
            this.btnBillPay.UseVisualStyleBackColor = false;
            this.btnBillPay.Click += new System.EventHandler(this.btnBillPay_Click);
            // 
            // btnBillCancel
            // 
            this.btnBillCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(77)))), ((int)(((byte)(75)))));
            this.btnBillCancel.FlatAppearance.BorderSize = 0;
            this.btnBillCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillCancel.ForeColor = System.Drawing.Color.White;
            this.btnBillCancel.Location = new System.Drawing.Point(14, 53);
            this.btnBillCancel.Name = "btnBillCancel";
            this.btnBillCancel.Size = new System.Drawing.Size(198, 62);
            this.btnBillCancel.TabIndex = 0;
            this.btnBillCancel.Text = "Hủy";
            this.btnBillCancel.UseVisualStyleBackColor = false;
            this.btnBillCancel.Click += new System.EventHandler(this.btnBillCancel_Click);
            // 
            // pnlPay
            // 
            this.pnlPay.BackColor = System.Drawing.Color.White;
            this.pnlPay.Controls.Add(this.btnBillCancel);
            this.pnlPay.Controls.Add(this.btnBillPay);
            this.pnlPay.Controls.Add(this.label9);
            this.pnlPay.Controls.Add(this.lblSumAll);
            this.pnlPay.Location = new System.Drawing.Point(734, 502);
            this.pnlPay.Name = "pnlPay";
            this.pnlPay.Size = new System.Drawing.Size(428, 135);
            this.pnlPay.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(236, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tổng";
            // 
            // lblSumAll
            // 
            this.lblSumAll.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSumAll.Location = new System.Drawing.Point(285, 8);
            this.lblSumAll.Name = "lblSumAll";
            this.lblSumAll.Size = new System.Drawing.Size(128, 30);
            this.lblSumAll.TabIndex = 0;
            this.lblSumAll.Text = "Sl+ đg";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitle.Location = new System.Drawing.Point(7, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(246, 35);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Bán hàng";
            // 
            // btnFindBill
            // 
            this.btnFindBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(191)))), ((int)(((byte)(107)))));
            this.btnFindBill.FlatAppearance.BorderSize = 0;
            this.btnFindBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindBill.ForeColor = System.Drawing.Color.White;
            this.btnFindBill.Location = new System.Drawing.Point(982, 9);
            this.btnFindBill.Name = "btnFindBill";
            this.btnFindBill.Size = new System.Drawing.Size(164, 42);
            this.btnFindBill.TabIndex = 0;
            this.btnFindBill.Text = "Tra cứu đơn hàng";
            this.btnFindBill.UseVisualStyleBackColor = false;
            this.btnFindBill.Click += new System.EventHandler(this.btnFindBill_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.lblUserEmpName);
            this.pnlTop.Controls.Add(this.btnFindBill);
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Location = new System.Drawing.Point(10, 12);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1153, 62);
            this.pnlTop.TabIndex = 10;
            // 
            // lblUserEmpName
            // 
            this.lblUserEmpName.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserEmpName.Location = new System.Drawing.Point(15, 39);
            this.lblUserEmpName.Name = "lblUserEmpName";
            this.lblUserEmpName.Size = new System.Drawing.Size(378, 23);
            this.lblUserEmpName.TabIndex = 5;
            this.lblUserEmpName.Text = "Tên Emp";
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
            // dgvBill
            // 
            this.dgvBill.AllowUserToDeleteRows = false;
            this.dgvBill.AllowUserToResizeRows = false;
            this.dgvBill.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.dgvBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.dgvBill.Location = new System.Drawing.Point(734, 140);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.ReadOnly = true;
            this.dgvBill.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(237)))), ((int)(((byte)(159)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBill.RowHeadersWidth = 30;
            this.dgvBill.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(224)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.dgvBill.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBill.Size = new System.Drawing.Size(429, 345);
            this.dgvBill.TabIndex = 9;
            this.dgvBill.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBill_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gray;
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
            this.txtSelectedID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSelectedID.Location = new System.Drawing.Point(48, 104);
            this.txtSelectedID.Name = "txtSelectedID";
            this.txtSelectedID.Size = new System.Drawing.Size(32, 30);
            this.txtSelectedID.TabIndex = 0;
            this.txtSelectedID.Text = "ID";
            // 
            // lblSum
            // 
            this.lblSum.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSum.Location = new System.Drawing.Point(122, 279);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(128, 30);
            this.lblSum.TabIndex = 0;
            this.lblSum.Text = "Sl+ đg";
            // 
            // txtSelectedName
            // 
            this.txtSelectedName.AutoSize = true;
            this.txtSelectedName.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelectedName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSelectedName.Location = new System.Drawing.Point(48, 167);
            this.txtSelectedName.Name = "txtSelectedName";
            this.txtSelectedName.Size = new System.Drawing.Size(45, 30);
            this.txtSelectedName.TabIndex = 0;
            this.txtSelectedName.Text = "Tên";
            // 
            // txtSelectedPrice
            // 
            this.txtSelectedPrice.AutoSize = true;
            this.txtSelectedPrice.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelectedPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSelectedPrice.Location = new System.Drawing.Point(48, 211);
            this.txtSelectedPrice.Name = "txtSelectedPrice";
            this.txtSelectedPrice.Size = new System.Drawing.Size(43, 30);
            this.txtSelectedPrice.TabIndex = 0;
            this.txtSelectedPrice.Text = "Giá";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(73, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tổng";
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(9, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã";
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(9, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên";
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(9, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Giá";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(12, 275);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(234, 1);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.pnlItemEdit);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.txtSelectedPrice);
            this.panel4.Controls.Add(this.txtSelectedName);
            this.panel4.Controls.Add(this.lblSum);
            this.panel4.Controls.Add(this.txtSelectedID);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(457, 87);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(259, 318);
            this.panel4.TabIndex = 0;
            // 
            // pnlItemEdit
            // 
            this.pnlItemEdit.Controls.Add(this.btnEditContinue);
            this.pnlItemEdit.Controls.Add(this.btnEditOut);
            this.pnlItemEdit.Controls.Add(this.btnEditOK);
            this.pnlItemEdit.Location = new System.Drawing.Point(9, 34);
            this.pnlItemEdit.Name = "pnlItemEdit";
            this.pnlItemEdit.Size = new System.Drawing.Size(241, 67);
            this.pnlItemEdit.TabIndex = 5;
            // 
            // btnEditContinue
            // 
            this.btnEditContinue.BackColor = System.Drawing.Color.Purple;
            this.btnEditContinue.FlatAppearance.BorderSize = 0;
            this.btnEditContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditContinue.ForeColor = System.Drawing.Color.White;
            this.btnEditContinue.Location = new System.Drawing.Point(0, 6);
            this.btnEditContinue.Name = "btnEditContinue";
            this.btnEditContinue.Size = new System.Drawing.Size(104, 47);
            this.btnEditContinue.TabIndex = 1;
            this.btnEditContinue.Text = "Tiếp tục";
            this.btnEditContinue.UseVisualStyleBackColor = false;
            this.btnEditContinue.Click += new System.EventHandler(this.btnEditContinue_Click);
            // 
            // btnEditOut
            // 
            this.btnEditOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(77)))), ((int)(((byte)(75)))));
            this.btnEditOut.FlatAppearance.BorderSize = 0;
            this.btnEditOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditOut.ForeColor = System.Drawing.Color.White;
            this.btnEditOut.Location = new System.Drawing.Point(110, 6);
            this.btnEditOut.Name = "btnEditOut";
            this.btnEditOut.Size = new System.Drawing.Size(62, 47);
            this.btnEditOut.TabIndex = 2;
            this.btnEditOut.Text = "Bỏ khỏi bill";
            this.btnEditOut.UseVisualStyleBackColor = false;
            this.btnEditOut.Click += new System.EventHandler(this.btnEditOut_Click);
            // 
            // btnEditOK
            // 
            this.btnEditOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(191)))), ((int)(((byte)(107)))));
            this.btnEditOK.FlatAppearance.BorderSize = 0;
            this.btnEditOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditOK.ForeColor = System.Drawing.Color.White;
            this.btnEditOK.Location = new System.Drawing.Point(178, 6);
            this.btnEditOK.Name = "btnEditOK";
            this.btnEditOK.Size = new System.Drawing.Size(62, 47);
            this.btnEditOK.TabIndex = 3;
            this.btnEditOK.Text = "OK";
            this.btnEditOK.UseVisualStyleBackColor = false;
            this.btnEditOK.Click += new System.EventHandler(this.btnEditOK_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.lblDateTime);
            this.panel5.Controls.Add(this.txtnewBillID);
            this.panel5.Location = new System.Drawing.Point(734, 87);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(429, 58);
            this.panel5.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(191)))), ((int)(((byte)(107)))));
            this.panel6.Location = new System.Drawing.Point(1, 52);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(429, 1);
            this.panel6.TabIndex = 4;
            // 
            // lblDateTime
            // 
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.Gray;
            this.lblDateTime.Location = new System.Drawing.Point(224, 4);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(189, 17);
            this.lblDateTime.TabIndex = 0;
            this.lblDateTime.Text = "date";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtnewBillID
            // 
            this.txtnewBillID.AutoSize = true;
            this.txtnewBillID.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnewBillID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtnewBillID.Location = new System.Drawing.Point(9, 9);
            this.txtnewBillID.Name = "txtnewBillID";
            this.txtnewBillID.Size = new System.Drawing.Size(32, 30);
            this.txtnewBillID.TabIndex = 0;
            this.txtnewBillID.Text = "ID";
            this.txtnewBillID.Click += new System.EventHandler(this.txtnewBillID_Click);
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
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pnlPay);
            this.Controls.Add(this.pnlProAction);
            this.Controls.Add(this.pnlCount);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Canama- Bán hàng";
            this.pnlCount.ResumeLayout(false);
            this.pnlCount.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlProAction.ResumeLayout(false);
            this.pnlPay.ResumeLayout(false);
            this.pnlPay.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnlItemEdit.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlCount;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmmount;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnProAdd;
        private System.Windows.Forms.Button btnProRemove;
        private System.Windows.Forms.Panel pnlProAction;
        private System.Windows.Forms.Button btnBillPay;
        private System.Windows.Forms.Button btnBillCancel;
        private System.Windows.Forms.Panel pnlPay;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnFindBill;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.FlowLayoutPanel lsProducts;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtSelectedID;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label txtSelectedName;
        private System.Windows.Forms.Label txtSelectedPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSumAll;
        private System.Windows.Forms.Panel pnlItemEdit;
        private System.Windows.Forms.Button btnEditContinue;
        private System.Windows.Forms.Button btnEditOut;
        private System.Windows.Forms.Button btnEditOK;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblUserEmpName;
        private System.Windows.Forms.Label txtnewBillID;
    }
}