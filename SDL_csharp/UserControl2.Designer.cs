﻿
namespace SDL_csharp
{
    partial class UserControl2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cat_combo = new System.Windows.Forms.Label();
            this.itemname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.total_t = new System.Windows.Forms.TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.quantity_t = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cate_UC = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cartbox = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tct = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_t)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartbox)).BeginInit();
            this.SuspendLayout();
            // 
            // cat_combo
            // 
            this.cat_combo.AutoSize = true;
            this.cat_combo.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.cat_combo.ForeColor = System.Drawing.Color.White;
            this.cat_combo.Location = new System.Drawing.Point(8, 12);
            this.cat_combo.Name = "cat_combo";
            this.cat_combo.Size = new System.Drawing.Size(87, 20);
            this.cat_combo.TabIndex = 0;
            this.cat_combo.Text = "Category :";
            // 
            // itemname
            // 
            this.itemname.AutoSize = true;
            this.itemname.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.itemname.ForeColor = System.Drawing.Color.White;
            this.itemname.Location = new System.Drawing.Point(24, 9);
            this.itemname.Name = "itemname";
            this.itemname.Size = new System.Drawing.Size(98, 20);
            this.itemname.TabIndex = 1;
            this.itemname.Text = "Item Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(248, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cost :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(248, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total Cost :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(12, 83);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(170, 344);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 38);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 36);
            this.textBox1.TabIndex = 6;
            // 
            // total_t
            // 
            this.total_t.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_t.Location = new System.Drawing.Point(252, 104);
            this.total_t.Multiline = true;
            this.total_t.Name = "total_t";
            this.total_t.Size = new System.Drawing.Size(141, 35);
            this.total_t.TabIndex = 8;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderThickness = 3;
            this.guna2Panel1.Controls.Add(this.textBox2);
            this.guna2Panel1.Controls.Add(this.quantity_t);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.total_t);
            this.guna2Panel1.Controls.Add(this.textBox1);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.itemname);
            this.guna2Panel1.Location = new System.Drawing.Point(188, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(399, 147);
            this.guna2Panel1.TabIndex = 9;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(255, 39);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 35);
            this.textBox2.TabIndex = 11;
            // 
            // quantity_t
            // 
            this.quantity_t.BackColor = System.Drawing.Color.Transparent;
            this.quantity_t.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quantity_t.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.quantity_t.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.quantity_t.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.quantity_t.DisabledState.Parent = this.quantity_t;
            this.quantity_t.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.quantity_t.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.quantity_t.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quantity_t.FocusedState.Parent = this.quantity_t;
            this.quantity_t.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_t.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.quantity_t.Location = new System.Drawing.Point(3, 105);
            this.quantity_t.Name = "quantity_t";
            this.quantity_t.ShadowDecoration.Parent = this.quantity_t;
            this.quantity_t.Size = new System.Drawing.Size(141, 34);
            this.quantity_t.TabIndex = 10;
            this.quantity_t.ValueChanged += new System.EventHandler(this.quantity_t_ValueChanged);
            this.quantity_t.Leave += new System.EventHandler(this.quantity_t_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Quantity :";
            // 
            // cate_UC
            // 
            this.cate_UC.BackColor = System.Drawing.Color.Transparent;
            this.cate_UC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cate_UC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cate_UC.FocusedColor = System.Drawing.Color.Empty;
            this.cate_UC.FocusedState.Parent = this.cate_UC;
            this.cate_UC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cate_UC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cate_UC.FormattingEnabled = true;
            this.cate_UC.HoverState.Parent = this.cate_UC;
            this.cate_UC.ItemHeight = 30;
            this.cate_UC.Items.AddRange(new object[] {
            "South Indian",
            "Punjabi",
            "Mexican",
            "American",
            "Italian",
            "Chinese",
            "Deserts",
            "Softdrinks"});
            this.cate_UC.ItemsAppearance.Parent = this.cate_UC;
            this.cate_UC.Location = new System.Drawing.Point(12, 36);
            this.cate_UC.Name = "cate_UC";
            this.cate_UC.ShadowDecoration.Parent = this.cate_UC;
            this.cate_UC.Size = new System.Drawing.Size(169, 36);
            this.cate_UC.TabIndex = 10;
            this.cate_UC.SelectedIndexChanged += new System.EventHandler(this.cate_UC_SelectedIndexChanged);
            // 
            // cartbox
            // 
            this.cartbox.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.cartbox.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.cartbox.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cartbox.BackgroundColor = System.Drawing.Color.White;
            this.cartbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cartbox.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.cartbox.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cartbox.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.cartbox.ColumnHeadersHeight = 28;
            this.cartbox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cartbox.DefaultCellStyle = dataGridViewCellStyle6;
            this.cartbox.EnableHeadersVisualStyles = false;
            this.cartbox.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.cartbox.Location = new System.Drawing.Point(187, 196);
            this.cartbox.Name = "cartbox";
            this.cartbox.ReadOnly = true;
            this.cartbox.RowHeadersVisible = false;
            this.cartbox.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cartbox.Size = new System.Drawing.Size(398, 191);
            this.cartbox.TabIndex = 12;
            this.cartbox.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.cartbox.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.cartbox.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.cartbox.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.cartbox.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.cartbox.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.cartbox.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.cartbox.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.cartbox.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cartbox.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.cartbox.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartbox.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.cartbox.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.cartbox.ThemeStyle.HeaderStyle.Height = 28;
            this.cartbox.ThemeStyle.ReadOnly = true;
            this.cartbox.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.cartbox.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.cartbox.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cartbox.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.cartbox.ThemeStyle.RowsStyle.Height = 22;
            this.cartbox.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.cartbox.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.cartbox.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.cartbox_RowsAdded);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cost";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total Cost";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(188, 396);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(103, 31);
            this.guna2Button1.TabIndex = 13;
            this.guna2Button1.Text = "Remove";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(472, 396);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(109, 31);
            this.guna2Button2.TabIndex = 14;
            this.guna2Button2.Text = "Order";
            // 
            // guna2Button3
            // 
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Location = new System.Drawing.Point(472, 157);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(109, 31);
            this.guna2Button3.TabIndex = 15;
            this.guna2Button3.Text = "Add To Cart";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(331, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Grand Total";
            // 
            // tct
            // 
            this.tct.AutoSize = true;
            this.tct.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tct.ForeColor = System.Drawing.Color.White;
            this.tct.Location = new System.Drawing.Point(361, 410);
            this.tct.Name = "tct";
            this.tct.Size = new System.Drawing.Size(37, 20);
            this.tct.TabIndex = 17;
            this.tct.Text = "0.00";
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.tct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.cartbox);
            this.Controls.Add(this.cate_UC);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cat_combo);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(590, 450);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_t)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cat_combo;
        private System.Windows.Forms.Label itemname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox total_t;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ComboBox cate_UC;
        private Guna.UI2.WinForms.Guna2NumericUpDown quantity_t;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private Guna.UI2.WinForms.Guna2DataGridView cartbox;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tct;
    }
}
