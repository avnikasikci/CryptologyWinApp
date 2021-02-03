using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RSAManager.Helpers;
using Service;
using Service.Interface;
using System.Threading;

namespace FINALRSA
{
    public partial class UCWinSenerioController : UserControl
    {
        private RSAHelper _rsa = null;

        BackgroundWorker workerThread = null; // Saniye Hesaplarında Kullanılır
        bool _keepRunning = false; // Ex: Saniye Durdur baslat... 
        public UCWinSenerioController()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;// THREAD ÇAKIŞMASINI ENGELLER
            InstantiateWorkerThread();

        }

        private void InstantiateWorkerThread() // Vakit Kalırsa dinamik progress bar atılacak buraya
        {
            workerThread = new BackgroundWorker();            
            workerThread.WorkerReportsProgress = true;
            workerThread.WorkerSupportsCancellation = true;           

        }


        void FillDdl()
        {
            //CmbKeySize = new ComboBox();
            CmbKeySize.Items.Clear();
            CmbKeySize.DisplayMember = "NameAll";
            CmbKeySize.ValueMember = "Id";
            CmbKeySize.DataSource = new List<int> { 512, 1024, 2048, 4096 };
        }
        private void btnCreateKeys_Click(object sender, EventArgs e)
        {

            StartTimer(true);


            //FillDdl();
            // look for the selcted menu item
            var keySize = getKeySize();
            //keySize = 512;
            if (keySize == 0)
            {
                StopTimer(true);

                MessageBox.Show("Please, selected a key size!");
                return;
            }
            // conver the menu item key size (512, 1024, ....) and generate a key pair
            // attention! you can not use a different private key to decrypt an encrypted data
            // if you realize, we are saving the pair (public and private keys) 
            //lblKeySizeValue.Text = keySize.ToString();
            _rsa = new RSAHelper(keySize);
            txtPublicKey.Text = _rsa.PublicKey();
            txtPrivateKey.Text = _rsa.PrivateKey();


            StopTimer(true);
        }
        public static int? KeySizeSt { get; set; }
        private void CmbKeySize_SelectedIndexChanged(object sender, EventArgs e)
        {
            int KeySizeStVal = 0;
            if (CmbKeySize.SelectedItem != null && CmbKeySize.SelectedValue != null)
            {
                int.TryParse(CmbKeySize.SelectedValue.ToString(), out KeySizeStVal);
            }
            KeySizeSt = KeySizeStVal;
        }

        private int getKeySize()
        {

            return (KeySizeSt != null && KeySizeSt > 0) ? (int)KeySizeSt : 0;
        }
        private void UCWinSenerioController_Load(object sender, EventArgs e)
        {         
            txtEncryptInputContent.Multiline = true;
            txtEncryptInputContent.ScrollBars = ScrollBars.Both;
            txtDecryptOutContent.Multiline = true;
            txtDecryptOutContent.ScrollBars = ScrollBars.Both;
            txtPublicKey.Multiline = true;
            txtPublicKey.ScrollBars = ScrollBars.Both;
            txtPrivateKey.Multiline = true;
            txtPrivateKey.ScrollBars = ScrollBars.Both;
            txtEncryptOutContent.Multiline = true;
            txtEncryptOutContent.ScrollBars = ScrollBars.Both;
            txtDecryptInputContent.Multiline = true;
            txtDecryptInputContent.ScrollBars = ScrollBars.Both;           

            //CmbKeySize = new ComboBox();
            //CmbKeySize.Items.Clear();
            //CmbKeySize.DisplayMember = "NameAll";
            //CmbKeySize.ValueMember = "Id";
            //CmbKeySize.DataSource = new List<int> { 512, 1024, };
            FillDdl();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            StartTimer(true);

            if (_rsa == null)
            {
                MessageBox.Show("Lütfen Anahtar boyunu geriniz.!");
                StopTimer(true);

                return;
            }
            if (string.IsNullOrEmpty(txtEncryptInputContent.Text))
            {
                MessageBox.Show("Lütfen şifrelenecek metini giriniz.!");
                StopTimer(true);

                return;
            }
            try
            {
                txtEncryptOutContent.Text = _rsa.EncryptString(txtEncryptInputContent.Text, txtPublicKey.Text);
            }
            catch (Exception ex)
            {
                StopTimer(true);

                txtEncryptInputContent.Text = "";
                txtEncryptOutContent.Text = "";
                MessageBox.Show("Metin içeriğini şifrelemeye çalışırken bir hata oluştu.Anahtar boyutunun metin boyutuna uygun olup olmadığını kontrol edin!!");
            }

            StopTimer(true);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            StartTimer(true);

            if (_rsa == null)
            {
                MessageBox.Show("Lütfen Anahtar boyunu geriniz.!");
                StopTimer(true);

                return;
            }
            if (string.IsNullOrEmpty(txtDecryptInputContent.Text))
            {
                MessageBox.Show("Lütfen şifrelenmiş metini giriniz.!");
                StopTimer(true);

                return;
            }
            try
            {
                txtDecryptOutContent.Text = _rsa.DecryptString(txtDecryptInputContent.Text, txtPrivateKey.Text);
            }
            catch (Exception ex)
            {
                txtDecryptOutContent.Text = "";
                txtDecryptInputContent.Text = "";
                MessageBox.Show("Metin içeriğini şifrelemeye çalışırken bir hata oluştu.Anahtar boyutunun metin boyutuna uygun olup olmadığını kontrol edin!!");
                StopTimer(true);

            }
            StopTimer(true);

        }







        private void AllButtonEnable(bool Enable)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    Button bt = (Button)c;
                    bt.Enabled = Enable;
                }
            }
            //Application.DoEvents();
        }
        private void StartTimer(bool IsStop)
        {
            AllButtonEnable(false);
        }
        private void StopTimer(bool IsStop)
        {
            AllButtonEnable(true);
        }

    }
}
