/*	
    Main Project        : TugasCalculatorApp
    Nama Program		: Form1.cs
	Deskripsi Program	: Memvisualisasikan kalkulator dengan menggunakan Windows Form App
	Dibuat oleh			: Nurul Afini
	NIM					: 18.21.1179
	Taggal dibuat		: 21 September 2018
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasCalculatorWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
     
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            //deklarasi variabel awal dan proses casting 
            int a = int.Parse(txtNilaiA.Text);
            var b = Convert.ToInt32(txtNilaiB.Text);
            int intTotal;
            intTotal = 0; //variabel intTotal untuk menampung hasil kedua variabel sesuai dengan operasi yang dipilih

            //proses pengoperasian variabel (penambahan/pengurangan/perkalian/pembagian) yang dapat dipilih sesuai dengan keinginan user/pengguna
            switch (cmbOperasi.Text) //pilihan operasi menggunakan combobox
            {
                case "Penambahan":
                    intTotal = a + b; //eksekusi sesuai operasi
                    break;
                case "Pengurangan":
                    intTotal = a - b;
                    break;
                case "Perkalian":
                    intTotal = a * b;
                    break;
                case "Pembagian":
                    intTotal = a / b;
                    break;
            }

            txtHasil.Text = intTotal.ToString(); //hasil akhir pada textbox Hasil diambil dari variabel intTotal 
        }

    }
}
