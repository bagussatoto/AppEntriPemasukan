namespace AppEntriPemasukanPengeluaran
{
    partial class FrmNasabah
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
            this.txtNasabah = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNoRekening = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvwHistoriPemasukanPengeluaran = new System.Windows.Forms.ListView();
            this.btnInputPemasukanPengeluaran = new System.Windows.Forms.Button();
            this.lblTotalDebit = new System.Windows.Forms.Label();
            this.lblTotalKredit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNasabah
            // 
            this.txtNasabah.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNasabah.Location = new System.Drawing.Point(124, 50);
            this.txtNasabah.Margin = new System.Windows.Forms.Padding(4);
            this.txtNasabah.Name = "txtNasabah";
            this.txtNasabah.Size = new System.Drawing.Size(311, 22);
            this.txtNasabah.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nasabah";
            // 
            // txtNoRekening
            // 
            this.txtNoRekening.Location = new System.Drawing.Point(124, 15);
            this.txtNoRekening.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoRekening.Name = "txtNoRekening";
            this.txtNoRekening.Size = new System.Drawing.Size(132, 22);
            this.txtNoRekening.TabIndex = 0;
            this.txtNoRekening.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoRekening_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "No. Rekening";
            // 
            // lvwHistoriPemasukanPengeluaran
            // 
            this.lvwHistoriPemasukanPengeluaran.HideSelection = false;
            this.lvwHistoriPemasukanPengeluaran.Location = new System.Drawing.Point(23, 106);
            this.lvwHistoriPemasukanPengeluaran.Margin = new System.Windows.Forms.Padding(4);
            this.lvwHistoriPemasukanPengeluaran.Name = "lvwHistoriPemasukanPengeluaran";
            this.lvwHistoriPemasukanPengeluaran.Size = new System.Drawing.Size(463, 261);
            this.lvwHistoriPemasukanPengeluaran.TabIndex = 2;
            this.lvwHistoriPemasukanPengeluaran.UseCompatibleStateImageBehavior = false;
            // 
            // btnInputPemasukanPengeluaran
            // 
            this.btnInputPemasukanPengeluaran.Location = new System.Drawing.Point(213, 418);
            this.btnInputPemasukanPengeluaran.Margin = new System.Windows.Forms.Padding(4);
            this.btnInputPemasukanPengeluaran.Name = "btnInputPemasukanPengeluaran";
            this.btnInputPemasukanPengeluaran.Size = new System.Drawing.Size(267, 28);
            this.btnInputPemasukanPengeluaran.TabIndex = 5;
            this.btnInputPemasukanPengeluaran.Text = "Input Pemasukan/Pengeluaran";
            this.btnInputPemasukanPengeluaran.UseVisualStyleBackColor = true;
            this.btnInputPemasukanPengeluaran.Click += new System.EventHandler(this.btnInputPemasukanPengeluaran_Click);
            // 
            // lblTotalDebit
            // 
            this.lblTotalDebit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblTotalDebit.Location = new System.Drawing.Point(209, 372);
            this.lblTotalDebit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalDebit.Name = "lblTotalDebit";
            this.lblTotalDebit.Size = new System.Drawing.Size(133, 25);
            this.lblTotalDebit.TabIndex = 3;
            this.lblTotalDebit.Text = "0";
            this.lblTotalDebit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalKredit
            // 
            this.lblTotalKredit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblTotalKredit.Location = new System.Drawing.Point(347, 372);
            this.lblTotalKredit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalKredit.Name = "lblTotalKredit";
            this.lblTotalKredit.Size = new System.Drawing.Size(133, 25);
            this.lblTotalKredit.TabIndex = 4;
            this.lblTotalKredit.Text = "0";
            this.lblTotalKredit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmNasabah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 462);
            this.Controls.Add(this.btnInputPemasukanPengeluaran);
            this.Controls.Add(this.lvwHistoriPemasukanPengeluaran);
            this.Controls.Add(this.txtNasabah);
            this.Controls.Add(this.lblTotalKredit);
            this.Controls.Add(this.lblTotalDebit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNoRekening);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmNasabah";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Nasabah";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNasabah;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNoRekening;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvwHistoriPemasukanPengeluaran;
        private System.Windows.Forms.Button btnInputPemasukanPengeluaran;
        private System.Windows.Forms.Label lblTotalDebit;
        private System.Windows.Forms.Label lblTotalKredit;
    }
}

