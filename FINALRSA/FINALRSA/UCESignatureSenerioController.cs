using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FINALRSA.Utulity;
using FINALRSA.Collection.Entity;
using Service.Interface;
using System.Numerics;
using System.Threading;
//using System.Threading.Tasks;

namespace FINALRSA
{
    public partial class UCESignatureSenerioController : UserControl
    {

        RSAKeyManager CurrenyRsaKeyEntity = new RSAKeyManager();
        private readonly IRSAKeyService _RSAKeyService;
        BackgroundWorker workerThread = null; // Saniye Hesaplarında Kullanılır
        bool _keepRunning = false; // Ex: Saniye Durdur baslat...   

        public UCESignatureSenerioController()
        {

            Control.CheckForIllegalCrossThreadCalls = false;// THREAD ÇAKIŞMASINI ENGELLER
            InstantiateWorkerThread();
            InitializeComponent();
        }
        private void InstantiateWorkerThread() // Vakit Kalırsa dinamik progress bar atılacak buraya
        {
            workerThread = new BackgroundWorker();
            workerThread.WorkerReportsProgress = true;
            workerThread.WorkerSupportsCancellation = true;



            backgroundWorker1 = new BackgroundWorker();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        public UCESignatureSenerioController(IRSAKeyService RSAKeyService)
        {
            InitializeComponent();
            this._RSAKeyService = RSAKeyService;

        }
        private void UCESignatureSenerioController_Load(object sender, EventArgs e)
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
        }

        private void CreatePrimerNumbers_Click(object sender, EventArgs e)
        {
            StartTimer(true);

            //Random Iki Adet asal sayı üterimi
            var ReturnList = UUtilityManager.RandomPrimerGenerateTwoNumber();
            if (ReturnList != null && ReturnList.Count > 1)
            {
                CurrenyRsaKeyEntity.pPrimeNumber1 = ReturnList[0];
                CurrenyRsaKeyEntity.qPrimeNumber2 = ReturnList[1];
                txtPrimerNumber1.Text = ReturnList[0].ToString();
                txtPrimerNumber2.Text = ReturnList[1].ToString();
            }
            //2 adet asal sayı belirle.


            StopTimer(true);


        }


        private bool checkPrimerNumberTxt(object sender, EventArgs e)
        {
            StartTimer(true);


            var Primer1 = CurrenyRsaKeyEntity.pPrimeNumber1;
            var Primer2 = CurrenyRsaKeyEntity.qPrimeNumber2;
            if (string.IsNullOrEmpty(txtPrimerNumber1.Text) && !int.TryParse(txtPrimerNumber1.Text, out Primer1))
            {
                MessageBox.Show("Asal sayı 1 alanı zorunludur!");
                return false;
            }
            if (string.IsNullOrEmpty(txtPrimerNumber2.Text) && !int.TryParse(txtPrimerNumber2.Text, out Primer2))
            {
                MessageBox.Show("Asal sayı 2 alanı zorunludur!");
                return false;
            }

            var CheckPrimer = UUtilityManager.CheckIfPrime(Primer1);
            if (!CheckPrimer)
            {
                MessageBox.Show("Asal sayı 1 alanı asal sayı olmalıdır girilen değer asal değil düzenleyip tekrar deneyiniz!");
                return false;
            }
            CheckPrimer = UUtilityManager.CheckIfPrime(Primer2);
            if (!CheckPrimer)
            {
                MessageBox.Show("Asal sayı 2 alanı asal sayı olmalıdır girilen değer asal değil düzenleyip tekrar deneyiniz!");
                return false;
            }

            CurrenyRsaKeyEntity.pPrimeNumber1 = Primer1;
            CurrenyRsaKeyEntity.qPrimeNumber2 = Primer2;

            StopTimer(true);

            return true;

        }



        private void btnCreateKeys_Click(object sender, EventArgs e)
        {
            StartTimer(true);

            var CheckPrimer = checkPrimerNumberTxt(sender, e);

            if (!CheckPrimer)
            {
                return;
            }
            var Primer1 = CurrenyRsaKeyEntity.pPrimeNumber1;
            var Primer2 = CurrenyRsaKeyEntity.qPrimeNumber2;
            CurrenyRsaKeyEntity.pPrimeNumber1 = Primer1;
            CurrenyRsaKeyEntity.qPrimeNumber2 = Primer2;

            var Modules = Primer1 * Primer2;//n=p-q            
            var TotientValue = UUtilityManager.EulerFunction(Primer1, Primer2); //primer olması zorunlu olduğu için  φ(n) = (p-1)(q-1) olarak bulunur.            
            //TotientValue ile aralarında asal bir sayı belirle 1<e<TotientValue
            //var ReturnPublicKey = _RSAKeyService.GenaretePublicKey(CurrenyRsaKeyEntity);
            //var ReturnPublicKey = new RSAKeyService(CurrenyRsaKeyEntity).GenaretePublicKey(CurrenyRsaKeyEntity);
            var ReturnPublicKey = new RSAKeyService(CurrenyRsaKeyEntity).setGenaretePublicKey();
            CurrenyRsaKeyEntity.ePublicKey = ReturnPublicKey.Sign;

            //var ReturnPrivateKey = new RSAKeyService(CurrenyRsaKeyEntity).GenaretePrivateKey(CurrenyRsaKeyEntity);
            var ReturnPrivateKey = new RSAKeyService(CurrenyRsaKeyEntity).setGenaretePrivateKey();
            CurrenyRsaKeyEntity.dPrivateKey = ReturnPrivateKey.Sign;


            txtPublicKey.Text = ReturnPublicKey.ToString();
            txtPrivateKey.Text = ReturnPrivateKey.ToString();
            StopTimer(true);




        }
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            StartTimer(true);
            var CheckPrimer = checkPrimerNumberTxt(sender, e);

            if (!CheckPrimer)
            {
                return;
            }

            string Text = txtEncryptInputContent.Text;
            int CheckEncValue = 0;
            if (string.IsNullOrEmpty(txtEncryptInputContent.Text) && !Int32.TryParse(Text, out CheckEncValue))
            {
                MessageBox.Show("Please, inform some content!");
                return;
            }
            int.TryParse(Text, out CheckEncValue);
            //var ReturnPrivateChiper = new RSAKeyService(CurrenyRsaKeyEntity).Encrypt(CurrenyRsaKeyEntity, CheckEncValue.ToString());
            //var ReturnPrivateChiper = new RSAKeyService(CurrenyRsaKeyEntity).Encrypt(CurrenyRsaKeyEntity, Text);
            var ReturnPrivateChiper = new RSAKeyService(CurrenyRsaKeyEntity).encryptInput(Text);
            txtEncryptOutContent.Text = ReturnPrivateChiper;

            StopTimer(true);



        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {

            StartTimer(true);
            var CheckPrimer = checkPrimerNumberTxt(sender, e);

            if (!CheckPrimer)
            {
                return;
            }


            string Text = txtDecryptInputContent.Text;

            int CheckDecrValue = 0;
            if (string.IsNullOrEmpty(txtEncryptInputContent.Text) && !int.TryParse(txtDecryptInputContent.Text, out CheckDecrValue))
            {
                MessageBox.Show("Please, inform some content!");
                return;
            }
            int.TryParse(Text, out CheckDecrValue);

            //var ReturnPublicChiper = new RSAKeyService(CurrenyRsaKeyEntity).Decrypt(CurrenyRsaKeyEntity, CheckDecrValue.ToString());
            //var ReturnPublicChiper = new RSAKeyService(CurrenyRsaKeyEntity).Decrypt(CurrenyRsaKeyEntity, Text);
            var ReturnPublicChiper = new RSAKeyService(CurrenyRsaKeyEntity).decryptInput(Text);

            //txtDecryptOutContent.Text = ReturnPublicChiper.ToString();
            txtDecryptOutContent.Text = ReturnPublicChiper;

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
