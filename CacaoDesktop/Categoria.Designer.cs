
namespace CacaoDesktop
{
    partial class Categoria
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categoria));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameCat = new System.Windows.Forms.TextBox();
            this.desCat = new System.Windows.Forms.TextBox();
            this.btnSaveCat = new System.Windows.Forms.Button();
            this.btnEliminarCat = new System.Windows.Forms.Button();
            this.btnUpdateCat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView1.Location = new System.Drawing.Point(24, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(569, 259);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descripcion";
            // 
            // nameCat
            // 
            this.nameCat.Location = new System.Drawing.Point(118, 43);
            this.nameCat.Name = "nameCat";
            this.nameCat.Size = new System.Drawing.Size(349, 23);
            this.nameCat.TabIndex = 3;
            // 
            // desCat
            // 
            this.desCat.Location = new System.Drawing.Point(118, 78);
            this.desCat.Name = "desCat";
            this.desCat.Size = new System.Drawing.Size(349, 23);
            this.desCat.TabIndex = 4;
            // 
            // btnSaveCat
            // 
            this.btnSaveCat.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSaveCat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveCat.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSaveCat.Location = new System.Drawing.Point(492, 54);
            this.btnSaveCat.Name = "btnSaveCat";
            this.btnSaveCat.Size = new System.Drawing.Size(85, 42);
            this.btnSaveCat.TabIndex = 5;
            this.btnSaveCat.Text = "Guardar";
            this.btnSaveCat.UseVisualStyleBackColor = false;
            this.btnSaveCat.Click += new System.EventHandler(this.btnSaveCat_Click);
            // 
            // btnEliminarCat
            // 
            this.btnEliminarCat.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEliminarCat.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEliminarCat.Location = new System.Drawing.Point(118, 398);
            this.btnEliminarCat.Name = "btnEliminarCat";
            this.btnEliminarCat.Size = new System.Drawing.Size(97, 40);
            this.btnEliminarCat.TabIndex = 6;
            this.btnEliminarCat.Text = "Eliminar";
            this.btnEliminarCat.UseVisualStyleBackColor = false;
            this.btnEliminarCat.Click += new System.EventHandler(this.btnEliminarCat_Click);
            // 
            // btnUpdateCat
            // 
            this.btnUpdateCat.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUpdateCat.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdateCat.Location = new System.Drawing.Point(245, 398);
            this.btnUpdateCat.Name = "btnUpdateCat";
            this.btnUpdateCat.Size = new System.Drawing.Size(92, 40);
            this.btnUpdateCat.TabIndex = 7;
            this.btnUpdateCat.Text = "Actualizar";
            this.btnUpdateCat.UseVisualStyleBackColor = false;
            this.btnUpdateCat.Click += new System.EventHandler(this.btnUpdateCat_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(518, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(626, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUpdateCat);
            this.Controls.Add(this.btnEliminarCat);
            this.Controls.Add(this.btnSaveCat);
            this.Controls.Add(this.desCat);
            this.Controls.Add(this.nameCat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Categoria";
            this.Text = "Categorias";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameCat;
        private System.Windows.Forms.TextBox desCat;
        private System.Windows.Forms.Button btnSaveCat;
        private System.Windows.Forms.Button btnEliminarCat;
        private System.Windows.Forms.Button btnUpdateCat;
        private System.Windows.Forms.Button button1;
    }
}

