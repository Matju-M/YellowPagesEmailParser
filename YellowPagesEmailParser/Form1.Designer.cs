namespace YellowPagesEmailParser
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnStartParse = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridviewMain = new System.Windows.Forms.DataGridView();
            this.iDNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountInstanceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderHeaderIDNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.captionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartParse
            // 
            this.btnStartParse.Location = new System.Drawing.Point(262, 38);
            this.btnStartParse.Name = "btnStartParse";
            this.btnStartParse.Size = new System.Drawing.Size(110, 28);
            this.btnStartParse.TabIndex = 0;
            this.btnStartParse.Text = "Get";
            this.btnStartParse.UseVisualStyleBackColor = true;
            this.btnStartParse.Click += new System.EventHandler(this.btnStartParse_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(72, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(416, 20);
            this.txtInput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter URL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Emails Extracted:";
            // 
            // gridviewMain
            // 
            this.gridviewMain.AllowUserToAddRows = false;
            this.gridviewMain.AllowUserToDeleteRows = false;
            this.gridviewMain.AutoGenerateColumns = false;
            this.gridviewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDNumberDataGridViewTextBoxColumn,
            this.accountInstanceIDDataGridViewTextBoxColumn,
            this.orderHeaderIDNumberDataGridViewTextBoxColumn,
            this.captionDataGridViewTextBoxColumn,
            this.detailTextDataGridViewTextBoxColumn,
            this.productIDNumberDataGridViewTextBoxColumn});
            this.gridviewMain.DataSource = this.modelBindingSource;
            this.gridviewMain.Location = new System.Drawing.Point(26, 112);
            this.gridviewMain.Name = "gridviewMain";
            this.gridviewMain.ReadOnly = true;
            this.gridviewMain.Size = new System.Drawing.Size(444, 192);
            this.gridviewMain.TabIndex = 5;
            // 
            // iDNumberDataGridViewTextBoxColumn
            // 
            this.iDNumberDataGridViewTextBoxColumn.DataPropertyName = "IDNumber";
            this.iDNumberDataGridViewTextBoxColumn.HeaderText = "IDNumber";
            this.iDNumberDataGridViewTextBoxColumn.Name = "iDNumberDataGridViewTextBoxColumn";
            this.iDNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDNumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // accountInstanceIDDataGridViewTextBoxColumn
            // 
            this.accountInstanceIDDataGridViewTextBoxColumn.DataPropertyName = "AccountInstanceID";
            this.accountInstanceIDDataGridViewTextBoxColumn.HeaderText = "AccountInstanceID";
            this.accountInstanceIDDataGridViewTextBoxColumn.Name = "accountInstanceIDDataGridViewTextBoxColumn";
            this.accountInstanceIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.accountInstanceIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // orderHeaderIDNumberDataGridViewTextBoxColumn
            // 
            this.orderHeaderIDNumberDataGridViewTextBoxColumn.DataPropertyName = "OrderHeaderIDNumber";
            this.orderHeaderIDNumberDataGridViewTextBoxColumn.HeaderText = "OrderHeaderIDNumber";
            this.orderHeaderIDNumberDataGridViewTextBoxColumn.Name = "orderHeaderIDNumberDataGridViewTextBoxColumn";
            this.orderHeaderIDNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderHeaderIDNumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // captionDataGridViewTextBoxColumn
            // 
            this.captionDataGridViewTextBoxColumn.DataPropertyName = "Caption";
            this.captionDataGridViewTextBoxColumn.HeaderText = "Caption";
            this.captionDataGridViewTextBoxColumn.Name = "captionDataGridViewTextBoxColumn";
            this.captionDataGridViewTextBoxColumn.ReadOnly = true;
            this.captionDataGridViewTextBoxColumn.Width = 200;
            // 
            // detailTextDataGridViewTextBoxColumn
            // 
            this.detailTextDataGridViewTextBoxColumn.DataPropertyName = "DetailText";
            this.detailTextDataGridViewTextBoxColumn.HeaderText = "E-Mail";
            this.detailTextDataGridViewTextBoxColumn.Name = "detailTextDataGridViewTextBoxColumn";
            this.detailTextDataGridViewTextBoxColumn.ReadOnly = true;
            this.detailTextDataGridViewTextBoxColumn.Width = 200;
            // 
            // productIDNumberDataGridViewTextBoxColumn
            // 
            this.productIDNumberDataGridViewTextBoxColumn.DataPropertyName = "ProductIDNumber";
            this.productIDNumberDataGridViewTextBoxColumn.HeaderText = "ProductIDNumber";
            this.productIDNumberDataGridViewTextBoxColumn.Name = "productIDNumberDataGridViewTextBoxColumn";
            this.productIDNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIDNumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // modelBindingSource
            // 
            this.modelBindingSource.DataSource = typeof(YellowPagesEmailParser.EmailModel);
            this.modelBindingSource.CurrentChanged += new System.EventHandler(this.modelBindingSource_CurrentChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(378, 38);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 28);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 338);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.gridviewMain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnStartParse);
            this.Name = "Form1";
            this.Text = "Yellow Pages E-Mail Parser";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartParse;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridviewMain;
        private System.Windows.Forms.BindingSource modelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountInstanceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderHeaderIDNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn captionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnClear;
    }
}

