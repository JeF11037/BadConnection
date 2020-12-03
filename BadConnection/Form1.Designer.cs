namespace BadConnection
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
            this.ITEM_textbox = new System.Windows.Forms.TextBox();
            this.BTN_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TABLE_datagrid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDBDataSet = new BadConnection.MyDBDataSet();
            this.tableTableAdapter = new BadConnection.MyDBDataSetTableAdapters.TableTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AMOUNT_num = new System.Windows.Forms.NumericUpDown();
            this.PRICE_num = new System.Windows.Forms.NumericUpDown();
            this.BTN_change = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TABLE_datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AMOUNT_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRICE_num)).BeginInit();
            this.SuspendLayout();
            // 
            // ITEM_textbox
            // 
            this.ITEM_textbox.BackColor = System.Drawing.Color.Wheat;
            this.ITEM_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ITEM_textbox.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ITEM_textbox.Location = new System.Drawing.Point(155, 35);
            this.ITEM_textbox.Name = "ITEM_textbox";
            this.ITEM_textbox.Size = new System.Drawing.Size(161, 40);
            this.ITEM_textbox.TabIndex = 0;
            // 
            // BTN_add
            // 
            this.BTN_add.BackColor = System.Drawing.Color.Wheat;
            this.BTN_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_add.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.BTN_add.Location = new System.Drawing.Point(118, 255);
            this.BTN_add.Name = "BTN_add";
            this.BTN_add.Size = new System.Drawing.Size(94, 32);
            this.BTN_add.TabIndex = 1;
            this.BTN_add.Text = "Add";
            this.BTN_add.UseVisualStyleBackColor = false;
            this.BTN_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Wheat;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Item";
            // 
            // TABLE_datagrid
            // 
            this.TABLE_datagrid.AutoGenerateColumns = false;
            this.TABLE_datagrid.BackgroundColor = System.Drawing.Color.BlanchedAlmond;
            this.TABLE_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TABLE_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.itemDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.TABLE_datagrid.Cursor = System.Windows.Forms.Cursors.Help;
            this.TABLE_datagrid.DataSource = this.tableBindingSource;
            this.TABLE_datagrid.GridColor = System.Drawing.Color.Wheat;
            this.TABLE_datagrid.Location = new System.Drawing.Point(345, 12);
            this.TABLE_datagrid.Name = "TABLE_datagrid";
            this.TABLE_datagrid.Size = new System.Drawing.Size(443, 426);
            this.TABLE_datagrid.TabIndex = 3;
            this.TABLE_datagrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TABLE_datagrid_RowHeaderMouseClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemDataGridViewTextBoxColumn
            // 
            this.itemDataGridViewTextBoxColumn.DataPropertyName = "Item";
            this.itemDataGridViewTextBoxColumn.HeaderText = "Item";
            this.itemDataGridViewTextBoxColumn.Name = "itemDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.myDBDataSet;
            // 
            // myDBDataSet
            // 
            this.myDBDataSet.DataSetName = "MyDBDataSet";
            this.myDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Wheat;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(13, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Wheat;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.Location = new System.Drawing.Point(13, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 35);
            this.label3.TabIndex = 9;
            this.label3.Text = "Price";
            // 
            // AMOUNT_num
            // 
            this.AMOUNT_num.BackColor = System.Drawing.Color.Wheat;
            this.AMOUNT_num.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AMOUNT_num.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.AMOUNT_num.Location = new System.Drawing.Point(155, 106);
            this.AMOUNT_num.Name = "AMOUNT_num";
            this.AMOUNT_num.Size = new System.Drawing.Size(161, 40);
            this.AMOUNT_num.TabIndex = 10;
            // 
            // PRICE_num
            // 
            this.PRICE_num.BackColor = System.Drawing.Color.Wheat;
            this.PRICE_num.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PRICE_num.DecimalPlaces = 1;
            this.PRICE_num.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.PRICE_num.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.PRICE_num.Location = new System.Drawing.Point(155, 175);
            this.PRICE_num.Name = "PRICE_num";
            this.PRICE_num.Size = new System.Drawing.Size(161, 40);
            this.PRICE_num.TabIndex = 11;
            // 
            // BTN_change
            // 
            this.BTN_change.BackColor = System.Drawing.Color.Wheat;
            this.BTN_change.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_change.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.BTN_change.Location = new System.Drawing.Point(118, 305);
            this.BTN_change.Name = "BTN_change";
            this.BTN_change.Size = new System.Drawing.Size(94, 32);
            this.BTN_change.TabIndex = 12;
            this.BTN_change.Text = "Change";
            this.BTN_change.UseVisualStyleBackColor = false;
            this.BTN_change.Click += new System.EventHandler(this.BTN_change_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_change);
            this.Controls.Add(this.PRICE_num);
            this.Controls.Add(this.AMOUNT_num);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TABLE_datagrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_add);
            this.Controls.Add(this.ITEM_textbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TABLE_datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AMOUNT_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRICE_num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ITEM_textbox;
        private System.Windows.Forms.Button BTN_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView TABLE_datagrid;
        private MyDBDataSet myDBDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private MyDBDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown AMOUNT_num;
        private System.Windows.Forms.NumericUpDown PRICE_num;
        private System.Windows.Forms.Button BTN_change;
    }
}

