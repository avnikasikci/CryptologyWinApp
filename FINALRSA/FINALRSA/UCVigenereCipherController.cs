using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service;
using Service.Interface;

namespace FINALRSA
{
    public partial class UCVigenereCipherController : UserControl
    {
        public UCVigenereCipherController()
        {
            InitializeComponent();
        }
        IEncryptionAlgorithm algorithm;
        public static string InputText { get; set; }
        public static string Key { get; set; }

        private void VigenereCipherController_Load(object sender, EventArgs e)
        {
            txtKey.Multiline = true;
            txtKey.ScrollBars = ScrollBars.Both;
            txtEncryptInputContent.Multiline = true;            
            txtEncryptInputContent.ScrollBars = ScrollBars.Both;
            txtDecryptOutContent.Multiline = true;
            txtDecryptOutContent.ScrollBars = ScrollBars.Both;
            txtEncryptOutContent.Multiline = true;
            txtEncryptOutContent.ScrollBars = ScrollBars.Both;
            txtDecryptInputContent.Multiline = true;
            txtDecryptInputContent.ScrollBars = ScrollBars.Both;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            InputText = txtEncryptInputContent.Text;
            Key = txtKey.Text;
            if (string.IsNullOrEmpty(InputText) || string.IsNullOrEmpty(Key))
            {
                MessageBox.Show("Şifrelemek için metin ve anahtar girmek zorunludur.");
                return;
            }           
            algorithm = new VigenereCipher(InputText, Key);
            txtEncryptOutContent.Text = algorithm.Encrypt();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            //InputText = txtEncryptInputContent.Text;
            Key = txtKey.Text;
            if (string.IsNullOrEmpty(InputText) || string.IsNullOrEmpty(Key))
            {
                MessageBox.Show("Şifrelemek için metin ve anahtar girmek zorunludur.");
                return;
            }
            algorithm = new VigenereCipher(InputText, Key);
            txtDecryptOutContent.Text = algorithm.Encrypt();
            txtDecryptOutContent.Text = algorithm.Decrypt();
        }
    }
}
