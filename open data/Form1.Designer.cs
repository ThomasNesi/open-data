namespace open_data
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_Click = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDepth = new System.Windows.Forms.TextBox();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.data_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 84);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(634, 468);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_Click
            // 
            this.button_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Click.Location = new System.Drawing.Point(718, 485);
            this.button_Click.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Click.Name = "button_Click";
            this.button_Click.Size = new System.Drawing.Size(107, 67);
            this.button_Click.TabIndex = 1;
            this.button_Click.Text = "mostra tutto";
            this.button_Click.UseVisualStyleBackColor = true;
            this.button_Click.Click += new System.EventHandler(this.button_Click_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(955, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "profondità";
            // 
            // textBoxDepth
            // 
            this.textBoxDepth.Location = new System.Drawing.Point(958, 103);
            this.textBoxDepth.Name = "textBoxDepth";
            this.textBoxDepth.Size = new System.Drawing.Size(100, 22);
            this.textBoxDepth.TabIndex = 3;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(958, 142);
            this.buttonFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(75, 23);
            this.buttonFilter.TabIndex = 4;
            this.buttonFilter.Text = "filtra";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(393, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "TERREMOTI IN ITALIA DAL 1980 AL 2020";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(827, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "FILTRI";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(718, 103);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(207, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // data_btn
            // 
            this.data_btn.Location = new System.Drawing.Point(718, 142);
            this.data_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.data_btn.Name = "data_btn";
            this.data_btn.Size = new System.Drawing.Size(75, 23);
            this.data_btn.TabIndex = 8;
            this.data_btn.Text = "filtra";
            this.data_btn.UseVisualStyleBackColor = true;
            this.data_btn.Click += new System.EventHandler(this.data_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(715, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 564);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.data_btn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.textBoxDepth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Click);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Click;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDepth;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button data_btn;
        private System.Windows.Forms.Label label4;
    }
}

