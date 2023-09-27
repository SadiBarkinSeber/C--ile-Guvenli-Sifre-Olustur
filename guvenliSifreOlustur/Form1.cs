using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guvenliSifreOlustur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtSifre2_TextChanged(object sender, EventArgs e)
        {
            string password = txtSifre2.Text;

            if (password.Length > 6)
            {
                // Şifre hem özel karakterleri hem de sayıları içeriyorsa yüksek güvenlikli kabul edelim
                if (password.Any(char.IsDigit) && password.Any(IsSpecialCharacter))
                {
                    lblSonuc.Text = "YÜKSEK";
                    lblSonuc.ForeColor = Color.ForestGreen;
                }
                else
                {
                    lblSonuc.Text = "ORTA";
                    lblSonuc.ForeColor = Color.Yellow;
                }
            }
            else
            {
                lblSonuc.Text = "DÜŞÜK";
                lblSonuc.ForeColor = Color.Red;
            }
        }

        private bool IsSpecialCharacter(char c)
        {
            char[] specialCharacters = { '!', '@', '#', '$', '%', '^', '&', '*' };
            return specialCharacters.Contains(c);
        }
    }
}