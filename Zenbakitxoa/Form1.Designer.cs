namespace Zenbakitxoa
{
    partial class zenbakitxoa
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tik = new System.Windows.Forms.NumericUpDown();
            this.ra = new System.Windows.Forms.NumericUpDown();
            this.nor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nz = new System.Windows.Forms.TextBox();
            this.bbehera = new System.Windows.Forms.Button();
            this.bgora = new System.Windows.Forms.Button();
            this.bbardin = new System.Windows.Forms.Button();
            this.bHasi = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tik
            // 
            this.tik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tik.Location = new System.Drawing.Point(9, 68);
            this.tik.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.tik.Name = "tik";
            this.tik.Size = new System.Drawing.Size(55, 31);
            this.tik.TabIndex = 0;
            this.tik.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tik.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // ra
            // 
            this.ra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ra.Location = new System.Drawing.Point(113, 68);
            this.ra.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.ra.Name = "ra";
            this.ra.Size = new System.Drawing.Size(55, 31);
            this.ra.TabIndex = 0;
            this.ra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ra.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nor
            // 
            this.nor.Location = new System.Drawing.Point(6, 31);
            this.nor.Name = "nor";
            this.nor.Size = new System.Drawing.Size(92, 20);
            this.nor.TabIndex = 1;
            this.nor.Text = "nor";
            this.nor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "-tik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "-ra";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(2, 108);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(238, 259);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Column1";
            this.Column1.Items.AddRange(new object[] {
            "Ardo",
            "Geni",
            "Iñaki Pilar",
            "Pelos",
            "Tamayo",
            "Txabi",
            "Txomin",
            "Txus Loiu",
            "Txus Txino"});
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column2
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Red;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Width = 40;
            // 
            // nz
            // 
            this.nz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nz.Location = new System.Drawing.Point(167, 27);
            this.nz.Name = "nz";
            this.nz.Size = new System.Drawing.Size(37, 26);
            this.nz.TabIndex = 4;
            // 
            // bbehera
            // 
            this.bbehera.Location = new System.Drawing.Point(204, 48);
            this.bbehera.Name = "bbehera";
            this.bbehera.Size = new System.Drawing.Size(29, 22);
            this.bbehera.TabIndex = 5;
            this.bbehera.Text = "↓";
            this.bbehera.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bbehera.UseVisualStyleBackColor = true;
            this.bbehera.Click += new System.EventHandler(this.bbehera_Click);
            // 
            // bgora
            // 
            this.bgora.Location = new System.Drawing.Point(204, 10);
            this.bgora.Name = "bgora";
            this.bgora.Size = new System.Drawing.Size(29, 22);
            this.bgora.TabIndex = 5;
            this.bgora.Text = "↑";
            this.bgora.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bgora.UseVisualStyleBackColor = true;
            this.bgora.Click += new System.EventHandler(this.bgora_Click);
            // 
            // bbardin
            // 
            this.bbardin.Location = new System.Drawing.Point(204, 30);
            this.bbardin.Name = "bbardin";
            this.bbardin.Size = new System.Drawing.Size(29, 20);
            this.bbardin.TabIndex = 5;
            this.bbardin.Text = "=";
            this.bbardin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bbardin.UseVisualStyleBackColor = true;
            this.bbardin.Click += new System.EventHandler(this.bbardin_Click);
            // 
            // bHasi
            // 
            this.bHasi.Location = new System.Drawing.Point(204, 74);
            this.bHasi.Name = "bHasi";
            this.bHasi.Size = new System.Drawing.Size(29, 20);
            this.bHasi.TabIndex = 6;
            this.bHasi.Text = "⟲";
            this.bHasi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bHasi.UseVisualStyleBackColor = true;
            this.bHasi.Click += new System.EventHandler(this.bHasi_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(100, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // zenbakitxoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 368);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bHasi);
            this.Controls.Add(this.bgora);
            this.Controls.Add(this.bbardin);
            this.Controls.Add(this.bbehera);
            this.Controls.Add(this.nz);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nor);
            this.Controls.Add(this.ra);
            this.Controls.Add(this.tik);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "zenbakitxoa";
            this.ShowIcon = false;
            this.Text = "ZENBAKITXOA";
            ((System.ComponentModel.ISupportInitialize)(this.tik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown tik;
        private System.Windows.Forms.NumericUpDown ra;
        private System.Windows.Forms.Label nor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox nz;
        private System.Windows.Forms.Button bbehera;
        private System.Windows.Forms.Button bgora;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button bbardin;
        private System.Windows.Forms.Button bHasi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

