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
            this.ADD_btn = new System.Windows.Forms.Button();
            this.ITEM_lbl = new System.Windows.Forms.Label();
            this.TABLE_datagrid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDBDataSet = new BadConnection.MyDBDataSet();
            this.tableTableAdapter = new BadConnection.MyDBDataSetTableAdapters.TableTableAdapter();
            this.AMOUNT_lbl = new System.Windows.Forms.Label();
            this.PRICE_lbl = new System.Windows.Forms.Label();
            this.AMOUNT_num = new System.Windows.Forms.NumericUpDown();
            this.PRICE_num = new System.Windows.Forms.NumericUpDown();
            this.change_btn = new System.Windows.Forms.Button();
            this.DELETE_btn = new System.Windows.Forms.Button();
            this.DELETEALL_btn = new System.Windows.Forms.Button();
            this.IMAGECANVAS_picbox = new System.Windows.Forms.PictureBox();
            this.IMAGESOURCE_textbox = new System.Windows.Forms.TextBox();
            this.IMAGESOURCE_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TABLE_datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AMOUNT_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRICE_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMAGECANVAS_picbox)).BeginInit();
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
            // ADD_btn
            // 
            this.ADD_btn.BackColor = System.Drawing.Color.Wheat;
            this.ADD_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ADD_btn.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ADD_btn.Location = new System.Drawing.Point(118, 393);
            this.ADD_btn.Name = "ADD_btn";
            this.ADD_btn.Size = new System.Drawing.Size(94, 32);
            this.ADD_btn.TabIndex = 1;
            this.ADD_btn.Text = "Add";
            this.ADD_btn.UseVisualStyleBackColor = false;
            this.ADD_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ITEM_lbl
            // 
            this.ITEM_lbl.AutoSize = true;
            this.ITEM_lbl.BackColor = System.Drawing.Color.Wheat;
            this.ITEM_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ITEM_lbl.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ITEM_lbl.Location = new System.Drawing.Point(13, 35);
            this.ITEM_lbl.Name = "ITEM_lbl";
            this.ITEM_lbl.Size = new System.Drawing.Size(68, 35);
            this.ITEM_lbl.TabIndex = 2;
            this.ITEM_lbl.Text = "Item";
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
            this.TABLE_datagrid.Size = new System.Drawing.Size(444, 426);
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
            // AMOUNT_lbl
            // 
            this.AMOUNT_lbl.AutoSize = true;
            this.AMOUNT_lbl.BackColor = System.Drawing.Color.Wheat;
            this.AMOUNT_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AMOUNT_lbl.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.AMOUNT_lbl.Location = new System.Drawing.Point(13, 106);
            this.AMOUNT_lbl.Name = "AMOUNT_lbl";
            this.AMOUNT_lbl.Size = new System.Drawing.Size(103, 35);
            this.AMOUNT_lbl.TabIndex = 7;
            this.AMOUNT_lbl.Text = "amount";
            // 
            // PRICE_lbl
            // 
            this.PRICE_lbl.AutoSize = true;
            this.PRICE_lbl.BackColor = System.Drawing.Color.Wheat;
            this.PRICE_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PRICE_lbl.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.PRICE_lbl.Location = new System.Drawing.Point(13, 180);
            this.PRICE_lbl.Name = "PRICE_lbl";
            this.PRICE_lbl.Size = new System.Drawing.Size(70, 35);
            this.PRICE_lbl.TabIndex = 9;
            this.PRICE_lbl.Text = "Price";
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
            // change_btn
            // 
            this.change_btn.BackColor = System.Drawing.Color.Wheat;
            this.change_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.change_btn.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.change_btn.Location = new System.Drawing.Point(118, 431);
            this.change_btn.Name = "change_btn";
            this.change_btn.Size = new System.Drawing.Size(94, 32);
            this.change_btn.TabIndex = 12;
            this.change_btn.Text = "Change";
            this.change_btn.UseVisualStyleBackColor = false;
            this.change_btn.Click += new System.EventHandler(this.BTN_change_Click);
            // 
            // DELETE_btn
            // 
            this.DELETE_btn.BackColor = System.Drawing.Color.Wheat;
            this.DELETE_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DELETE_btn.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.DELETE_btn.Location = new System.Drawing.Point(118, 469);
            this.DELETE_btn.Name = "DELETE_btn";
            this.DELETE_btn.Size = new System.Drawing.Size(94, 32);
            this.DELETE_btn.TabIndex = 13;
            this.DELETE_btn.Text = "Delete";
            this.DELETE_btn.UseVisualStyleBackColor = false;
            this.DELETE_btn.Click += new System.EventHandler(this.BTN_delete_Click);
            // 
            // DELETEALL_btn
            // 
            this.DELETEALL_btn.BackColor = System.Drawing.Color.Tomato;
            this.DELETEALL_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DELETEALL_btn.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.DELETEALL_btn.Location = new System.Drawing.Point(109, 507);
            this.DELETEALL_btn.Name = "DELETEALL_btn";
            this.DELETEALL_btn.Size = new System.Drawing.Size(110, 32);
            this.DELETEALL_btn.TabIndex = 14;
            this.DELETEALL_btn.Text = "Delete All";
            this.DELETEALL_btn.UseVisualStyleBackColor = false;
            this.DELETEALL_btn.Click += new System.EventHandler(this.BTN_deleteAll_Click);
            // 
            // IMAGECANVAS_picbox
            // 
            this.IMAGECANVAS_picbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IMAGECANVAS_picbox.Cursor = System.Windows.Forms.Cursors.Help;
            this.IMAGECANVAS_picbox.Location = new System.Drawing.Point(795, 12);
            this.IMAGECANVAS_picbox.Name = "IMAGECANVAS_picbox";
            this.IMAGECANVAS_picbox.Size = new System.Drawing.Size(451, 426);
            this.IMAGECANVAS_picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IMAGECANVAS_picbox.TabIndex = 15;
            this.IMAGECANVAS_picbox.TabStop = false;
            // 
            // IMAGESOURCE_textbox
            // 
            this.IMAGESOURCE_textbox.BackColor = System.Drawing.Color.Wheat;
            this.IMAGESOURCE_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IMAGESOURCE_textbox.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.IMAGESOURCE_textbox.Location = new System.Drawing.Point(13, 300);
            this.IMAGESOURCE_textbox.Name = "IMAGESOURCE_textbox";
            this.IMAGESOURCE_textbox.Size = new System.Drawing.Size(303, 40);
            this.IMAGESOURCE_textbox.TabIndex = 16;
            // 
            // IMAGESOURCE_lbl
            // 
            this.IMAGESOURCE_lbl.AutoSize = true;
            this.IMAGESOURCE_lbl.BackColor = System.Drawing.Color.Wheat;
            this.IMAGESOURCE_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IMAGESOURCE_lbl.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.IMAGESOURCE_lbl.Location = new System.Drawing.Point(83, 251);
            this.IMAGESOURCE_lbl.Name = "IMAGESOURCE_lbl";
            this.IMAGESOURCE_lbl.Size = new System.Drawing.Size(164, 35);
            this.IMAGESOURCE_lbl.TabIndex = 17;
            this.IMAGESOURCE_lbl.Text = "Image Source";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1258, 609);
            this.Controls.Add(this.IMAGESOURCE_lbl);
            this.Controls.Add(this.IMAGESOURCE_textbox);
            this.Controls.Add(this.IMAGECANVAS_picbox);
            this.Controls.Add(this.DELETEALL_btn);
            this.Controls.Add(this.DELETE_btn);
            this.Controls.Add(this.change_btn);
            this.Controls.Add(this.PRICE_num);
            this.Controls.Add(this.AMOUNT_num);
            this.Controls.Add(this.PRICE_lbl);
            this.Controls.Add(this.AMOUNT_lbl);
            this.Controls.Add(this.TABLE_datagrid);
            this.Controls.Add(this.ITEM_lbl);
            this.Controls.Add(this.ADD_btn);
            this.Controls.Add(this.ITEM_textbox);
            this.Name = "Form1";
            this.Text = "BadConnection";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TABLE_datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AMOUNT_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRICE_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMAGECANVAS_picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ITEM_textbox;
        private System.Windows.Forms.Button ADD_btn;
        private System.Windows.Forms.Label ITEM_lbl;
        private System.Windows.Forms.DataGridView TABLE_datagrid;
        private MyDBDataSet myDBDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private MyDBDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label AMOUNT_lbl;
        private System.Windows.Forms.Label PRICE_lbl;
        private System.Windows.Forms.NumericUpDown AMOUNT_num;
        private System.Windows.Forms.NumericUpDown PRICE_num;
        private System.Windows.Forms.Button change_btn;
        private System.Windows.Forms.Button DELETE_btn;
        private System.Windows.Forms.Button DELETEALL_btn;
        private System.Windows.Forms.PictureBox IMAGECANVAS_picbox;
        private System.Windows.Forms.TextBox IMAGESOURCE_textbox;
        private System.Windows.Forms.Label IMAGESOURCE_lbl;
    }
}

