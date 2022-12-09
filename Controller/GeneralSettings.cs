using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AppEntriPemasukanPengeluaran.Controller
{
    public class GeneralSettings
    {
        // Fungsi agar textbox hanya bisa diisi angka
        public bool NumericOnly(KeyPressEventArgs e)
        {
            string strValid = "0123456789.";

            if (strValid.IndexOf(e.KeyChar) < 0 && !(e.KeyChar == Convert.ToChar(Keys.Back)))
                return true;
            else
                return false;
        }

        // Fungsi untuk memisah angka ribuan pada integer event text changed
        public string SetThousandSeparatorInteger(int bilangan)
        {
            string result = "0";

            try
            {
                CultureInfo culture = new CultureInfo("id-ID");
                result = string.Format(culture, "{0:N0}", bilangan);
            }
            catch
            {
            }

            return result;
        }

        // Fungsi untuk memisah angka ribuan pada textbox saat event textchanged
        public void SetThousandSeparatorTextChanged(TextBox txt)
        {
            try
            {
                CultureInfo culture = new CultureInfo("id-ID");
                int valueBefore = int.Parse(txt.Text, NumberStyles.AllowThousands);
                txt.Text = string.Format(culture, "{0:N0}", valueBefore);
                txt.Select(txt.Text.Length, 0);
            }
            catch
            {
            }
        }

        // Fungsi untuk mendapat angka saja pada string
        public int GetNumericString(string text)
        {
            var filter = 0;

            try
            {
                filter = int.Parse(Regex.Replace(text, "[^0-9]+", string.Empty));

            }
            catch
            {
            }

            return filter;
        }

    }
}
