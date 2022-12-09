using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AppEntriPemasukanPengeluaran.Controller;

namespace AppEntriPemasukanPengeluaran
{
    public partial class FrmEntriPemasukanPengeluaran : Form
    {
        // Delegate
        public delegate void ProsesEventHandler(Nasabah nasabah);
        // Event
        public event ProsesEventHandler onCreate;
        private GeneralSettings setting;
        
        private Nasabah nasabah;

        // constructor default
        public FrmEntriPemasukanPengeluaran()
        {
            InitializeComponent();
            cmbDebitKredit.SelectedIndex = 0;
        }

        public FrmEntriPemasukanPengeluaran(string header, string noRekening, string nasabah)
            : this() // panggil constructor default
        {
            this.Text = header;
            lblHeader.Text = header;

            txtNoRekening.Text = noRekening;
            txtNasabah.Text = nasabah;
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Instance object dari class Nasabah
            nasabah = new Nasabah();

            // Mengisi data kedalam objek nasabah
            nasabah.NomorRekening = txtNoRekening.Text;
            nasabah.NamaNasabah = txtNasabah.Text;
            nasabah.TanggalTransaksi = dtpTanggal.Value;
            nasabah.Nominal = setting.GetNumericString(txtNominal.Text);
            nasabah.JenisTransaksi = cmbDebitKredit.SelectedIndex;

            onCreate(nasabah);

            txtNominal.Text = "0";
            cmbDebitKredit.SelectedIndex = 0;
            dtpTanggal.Value = DateTime.Today;
        }

        private void txtNominal_KeyPress(object sender, KeyPressEventArgs e)
        {
            var validasi = new GeneralSettings();
            e.Handled = validasi.NumericOnly(e);
        }

        private void txtNominal_TextChanged(object sender, EventArgs e)
        {
            setting = new GeneralSettings();
            setting.SetThousandSeparatorTextChanged(txtNominal);
        }

        private void txtNominal_Click(object sender, EventArgs e)
        {
            txtNominal.Clear();
        }
    }
}
