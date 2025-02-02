﻿namespace Restaurant
{
    partial class ReportsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsForm));
            this.BtnDaily = new System.Windows.Forms.Button();
            this.DgrReports = new System.Windows.Forms.DataGridView();
            this.IdCollum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WaiterIDCollum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderAmountCollum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderContentsCollum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderTableCollum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDateCollum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderStatusCollum = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TableStatusCollum = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LblReportsName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgrReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnDaily
            // 
            this.BtnDaily.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDaily.Location = new System.Drawing.Point(364, 83);
            this.BtnDaily.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDaily.Name = "BtnDaily";
            this.BtnDaily.Size = new System.Drawing.Size(90, 42);
            this.BtnDaily.TabIndex = 0;
            this.BtnDaily.Text = " Reports";
            this.BtnDaily.UseVisualStyleBackColor = true;
            this.BtnDaily.Click += new System.EventHandler(this.BtnDaily_Click);
            // 
            // DgrReports
            // 
            this.DgrReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgrReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgrReports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCollum,
            this.WaiterIDCollum,
            this.OrderAmountCollum,
            this.OrderContentsCollum,
            this.OrderTableCollum,
            this.OrderDateCollum,
            this.OrderStatusCollum,
            this.TableStatusCollum});
            this.DgrReports.Location = new System.Drawing.Point(22, 171);
            this.DgrReports.Margin = new System.Windows.Forms.Padding(2);
            this.DgrReports.Name = "DgrReports";
            this.DgrReports.RowHeadersWidth = 51;
            this.DgrReports.RowTemplate.Height = 24;
            this.DgrReports.Size = new System.Drawing.Size(790, 222);
            this.DgrReports.TabIndex = 3;
            // 
            // IdCollum
            // 
            this.IdCollum.HeaderText = "ID";
            this.IdCollum.MinimumWidth = 6;
            this.IdCollum.Name = "IdCollum";
            // 
            // WaiterIDCollum
            // 
            this.WaiterIDCollum.HeaderText = "WaiterID";
            this.WaiterIDCollum.MinimumWidth = 6;
            this.WaiterIDCollum.Name = "WaiterIDCollum";
            // 
            // OrderAmountCollum
            // 
            this.OrderAmountCollum.HeaderText = "OrderAmount";
            this.OrderAmountCollum.MinimumWidth = 6;
            this.OrderAmountCollum.Name = "OrderAmountCollum";
            // 
            // OrderContentsCollum
            // 
            this.OrderContentsCollum.HeaderText = "OrderContents";
            this.OrderContentsCollum.MinimumWidth = 6;
            this.OrderContentsCollum.Name = "OrderContentsCollum";
            // 
            // OrderTableCollum
            // 
            this.OrderTableCollum.HeaderText = "OrderTable";
            this.OrderTableCollum.MinimumWidth = 6;
            this.OrderTableCollum.Name = "OrderTableCollum";
            // 
            // OrderDateCollum
            // 
            this.OrderDateCollum.HeaderText = "OrderDate";
            this.OrderDateCollum.MinimumWidth = 6;
            this.OrderDateCollum.Name = "OrderDateCollum";
            // 
            // OrderStatusCollum
            // 
            this.OrderStatusCollum.HeaderText = "OrderStatus";
            this.OrderStatusCollum.MinimumWidth = 6;
            this.OrderStatusCollum.Name = "OrderStatusCollum";
            this.OrderStatusCollum.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderStatusCollum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // TableStatusCollum
            // 
            this.TableStatusCollum.HeaderText = "TableStatus";
            this.TableStatusCollum.MinimumWidth = 6;
            this.TableStatusCollum.Name = "TableStatusCollum";
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            // 
            // LblReportsName
            // 
            this.LblReportsName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReportsName.Location = new System.Drawing.Point(47, 125);
            this.LblReportsName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblReportsName.Name = "LblReportsName";
            this.LblReportsName.Size = new System.Drawing.Size(160, 28);
            this.LblReportsName.TabIndex = 4;
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(852, 457);
            this.Controls.Add(this.LblReportsName);
            this.Controls.Add(this.DgrReports);
            this.Controls.Add(this.BtnDaily);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReportsForm";
            this.Text = "ReportsForm";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgrReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnDaily;
        private System.Windows.Forms.DataGridView DgrReports;
        
        private System.Windows.Forms.BindingSource ordersBindingSource;
        
        private System.Windows.Forms.Label LblReportsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCollum;
        private System.Windows.Forms.DataGridViewTextBoxColumn WaiterIDCollum;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderAmountCollum;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderContentsCollum;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderTableCollum;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDateCollum;
        private System.Windows.Forms.DataGridViewCheckBoxColumn OrderStatusCollum;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TableStatusCollum;
    }
}