
namespace CacaoDesktop
{
    partial class Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.listCiudad = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dvgClienteCiudad = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgClienteCiudad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(148, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "REPORTES GENERALES";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CacaoDesktop.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(439, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 39);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 57);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(582, 361);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage1.Controls.Add(this.dgvCliente);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnConsulta);
            this.tabPage1.Controls.Add(this.listCiudad);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(574, 333);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clientes";
            // 
            // dgvCliente
            // 
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCliente.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(46, 71);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.RowTemplate.Height = 25;
            this.dgvCliente.Size = new System.Drawing.Size(486, 239);
            this.dgvCliente.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione una ciudad";
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnConsulta.Location = new System.Drawing.Point(386, 23);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(83, 32);
            this.btnConsulta.TabIndex = 1;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // listCiudad
            // 
            this.listCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listCiudad.FormattingEnabled = true;
            this.listCiudad.Location = new System.Drawing.Point(62, 32);
            this.listCiudad.Name = "listCiudad";
            this.listCiudad.Size = new System.Drawing.Size(175, 23);
            this.listCiudad.TabIndex = 0;
            this.listCiudad.Tag = "Seleccione";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.dgvProducto);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(574, 333);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Productos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(131, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(317, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Reporte de compra de productos por ciudad";
            // 
            // dgvProducto
            // 
            this.dgvProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProducto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProducto.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Location = new System.Drawing.Point(56, 44);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.RowTemplate.Height = 25;
            this.dgvProducto.Size = new System.Drawing.Size(428, 260);
            this.dgvProducto.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage3.Controls.Add(this.dvgClienteCiudad);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(574, 333);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ciudad";
            // 
            // dvgClienteCiudad
            // 
            this.dvgClienteCiudad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvgClienteCiudad.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvgClienteCiudad.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvgClienteCiudad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgClienteCiudad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgClienteCiudad.Location = new System.Drawing.Point(64, 69);
            this.dvgClienteCiudad.Name = "dvgClienteCiudad";
            this.dvgClienteCiudad.RowTemplate.Height = 25;
            this.dvgClienteCiudad.Size = new System.Drawing.Size(427, 205);
            this.dvgClienteCiudad.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(164, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Reporte de Clientes por ciudad";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Image = global::CacaoDesktop.Properties.Resources.back_arrow;
            this.button1.Location = new System.Drawing.Point(236, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 33);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(607, 472);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reports";
            this.Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgClienteCiudad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.ComboBox listCiudad;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dvgClienteCiudad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}