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
    public partial class FrmNasabah : Form
    {
        private IList<Nasabah> listOfNasabah = new List<Nasabah>();
        private GeneralSettings setting;

        private int totalDebit = 0;
        private int totalKredit = 0;

        public FrmNasabah()
        {
            InitializeComponent();
            InisialisasiListView();
        }

        // atur kolom listview
        private void InisialisasiListView()
        {            
            lvwHistoriPemasukanPengeluaran.View = View.Details;
            lvwHistoriPemasukanPengeluaran.FullRowSelect = true;
            lvwHistoriPemasukanPengeluaran.GridLines = true;

            lvwHistoriPemasukanPengeluaran.Columns.Add("No.", 40, HorizontalAlignment.Center);
            lvwHistoriPemasukanPengeluaran.Columns.Add("Tanggal", 100, HorizontalAlignment.Center);
            lvwHistoriPemasukanPengeluaran.Columns.Add("Debit", 100, HorizontalAlignment.Right);
            lvwHistoriPemasukanPengeluaran.Columns.Add("Kredit", 100, HorizontalAlignment.Right);
        }

        private void OnCreateEventHandler(Nasabah nasabah)
        {
            listOfNasabah.Add(nasabah);
            setting = new GeneralSettings();

            int noUrut = lvwHistoriPemasukanPengeluaran.Items.Count + 1;

            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(nasabah.TanggalTransaksi.ToShortDateString());

            // Menampung nilai untuk pemisah ribuan
            var nominal = setting.SetThousandSeparatorInteger(nasabah.Nominal);

            if (nasabah.JenisTransaksi == 0)
            {
                item.SubItems.Add(nominal);
                item.SubItems.Add("0");
                totalDebit += nasabah.Nominal;
            }
            else
            {
                item.SubItems.Add("0");
                item.SubItems.Add(nominal);
                totalKredit += nasabah.Nominal;
            }

            lvwHistoriPemasukanPengeluaran.Items.Add(item);

            lblTotalDebit.Text = setting.SetThousandSeparatorInteger(totalDebit);
            lblTotalKredit.Text = setting.SetThousandSeparatorInteger(totalKredit);
        }

        private void btnInputPemasukanPengeluaran_Click(object sender, EventArgs e)
        {
            // Deklarasi dan inisiasi nilai untuk parameter constuctor form entry
            string header = "Entri Pemasukan/Pengeluaran";
            string noRekening = txtNoRekening.Text;
            string nasabah = txtNasabah.Text;

            FrmEntriPemasukanPengeluaran frmEntry = new FrmEntriPemasukanPengeluaran(header, noRekening, nasabah);
            frmEntry.onCreate += OnCreateEventHandler;
            frmEntry.ShowDialog();
        }

        private void txtNoRekening_KeyPress(object sender, KeyPressEventArgs e)
        {
            var validasi = new GeneralSettings();
            e.Handled = validasi.NumericOnly(e);
        }
    }
}
