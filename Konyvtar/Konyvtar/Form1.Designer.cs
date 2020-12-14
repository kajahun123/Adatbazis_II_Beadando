namespace Konyvtar
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
            this.dgv_Konyvek = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_olvasojegy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_kolcsonzonev = new System.Windows.Forms.TextBox();
            this.dtp_kolcsonzoido = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_cim = new System.Windows.Forms.TextBox();
            this.tb_iro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_insert = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.cb_mufaj = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Konyvek)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Konyvek
            // 
            this.dgv_Konyvek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Konyvek.Location = new System.Drawing.Point(12, 12);
            this.dgv_Konyvek.Name = "dgv_Konyvek";
            this.dgv_Konyvek.RowHeadersWidth = 51;
            this.dgv_Konyvek.RowTemplate.Height = 24;
            this.dgv_Konyvek.Size = new System.Drawing.Size(835, 279);
            this.dgv_Konyvek.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Olvasójegy";
            // 
            // tb_olvasojegy
            // 
            this.tb_olvasojegy.Location = new System.Drawing.Point(44, 343);
            this.tb_olvasojegy.Name = "tb_olvasojegy";
            this.tb_olvasojegy.Size = new System.Drawing.Size(203, 22);
            this.tb_olvasojegy.TabIndex = 2;
           // this.tb_olvasojegy.Leave += new System.EventHandler(this.tb_olvasojegy_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kölcsönző neve";
            // 
            // tb_kolcsonzonev
            // 
            this.tb_kolcsonzonev.Location = new System.Drawing.Point(323, 343);
            this.tb_kolcsonzonev.Name = "tb_kolcsonzonev";
            this.tb_kolcsonzonev.Size = new System.Drawing.Size(203, 22);
            this.tb_kolcsonzonev.TabIndex = 4;
            // 
            // dtp_kolcsonzoido
            // 
            this.dtp_kolcsonzoido.Location = new System.Drawing.Point(595, 343);
            this.dtp_kolcsonzoido.Name = "dtp_kolcsonzoido";
            this.dtp_kolcsonzoido.Size = new System.Drawing.Size(200, 22);
            this.dtp_kolcsonzoido.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(636, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kölcsönzés ideje";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Könyv címe";
            // 
            // tb_cim
            // 
            this.tb_cim.Location = new System.Drawing.Point(44, 426);
            this.tb_cim.Name = "tb_cim";
            this.tb_cim.Size = new System.Drawing.Size(203, 22);
            this.tb_cim.TabIndex = 8;
            // 
            // tb_iro
            // 
            this.tb_iro.Location = new System.Drawing.Point(323, 425);
            this.tb_iro.Name = "tb_iro";
            this.tb_iro.Size = new System.Drawing.Size(203, 22);
            this.tb_iro.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Könyv írója";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(646, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Könyv műfaja";
            // 
            // bt_insert
            // 
            this.bt_insert.Location = new System.Drawing.Point(173, 489);
            this.bt_insert.Name = "bt_insert";
            this.bt_insert.Size = new System.Drawing.Size(118, 40);
            this.bt_insert.TabIndex = 13;
            this.bt_insert.Text = "Hozzáad";
            this.bt_insert.UseVisualStyleBackColor = true;
            this.bt_insert.Click += new System.EventHandler(this.bt_insert_Click);
            // 
            // bt_update
            // 
            this.bt_update.Location = new System.Drawing.Point(350, 489);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(127, 40);
            this.bt_update.TabIndex = 14;
            this.bt_update.Text = "Frissít";
            this.bt_update.UseVisualStyleBackColor = true;
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(544, 490);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(110, 39);
            this.bt_delete.TabIndex = 15;
            this.bt_delete.Text = "Töröl";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // cb_mufaj
            // 
            this.cb_mufaj.FormattingEnabled = true;
            this.cb_mufaj.Location = new System.Drawing.Point(595, 426);
            this.cb_mufaj.Name = "cb_mufaj";
            this.cb_mufaj.Size = new System.Drawing.Size(200, 24);
            this.cb_mufaj.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 550);
            this.Controls.Add(this.cb_mufaj);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.bt_insert);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_iro);
            this.Controls.Add(this.tb_cim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_kolcsonzoido);
            this.Controls.Add(this.tb_kolcsonzonev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_olvasojegy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Konyvek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Konyvek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Konyvek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_olvasojegy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_kolcsonzonev;
        private System.Windows.Forms.DateTimePicker dtp_kolcsonzoido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_cim;
        private System.Windows.Forms.TextBox tb_iro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt_insert;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.ComboBox cb_mufaj;
    }
}

