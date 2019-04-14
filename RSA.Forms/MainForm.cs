using System;
using System.Collections.Generic;
using System.Numerics;
using System.Windows.Forms;

namespace RSA.Forms
{
    public partial class MainForm : Form
    {
        private static RSA _crypto;

        public MainForm()
        {
            InitializeComponent();

            _crypto = new RSA();

            pTextBox.Text = _crypto.P.ToString();
            qTextBox.Text = _crypto.Q.ToString();

            publicKeyLabel.Text = string.Empty;
            privateKeyLabel.Text = string.Empty;
            inputNumbersLabel.Text = string.Empty;
            cipherLabel.Text = string.Empty;
            outputNumbersLabel.Text = string.Empty;

            outputTextBox.Enabled = false;
        }

        private void MainForm_Load(object sender, EventArgs eventArgs)
        {

        }

        private void calculateButton_Click(object sender, EventArgs eventArgs)
        {
            var p = new BigInteger(Convert.ToInt32(pTextBox.Text));
            var q = new BigInteger(Convert.ToInt32(qTextBox.Text));

            _crypto.Calculate(p, q);

            nTextBox.Text = _crypto.N.ToString();
            eTextBox.Text = _crypto.E.ToString();
            fnTextBox.Text = _crypto.Fn.ToString();
            dTextBox.Text = _crypto.D.ToString();

            publicKeyLabel.Text = $"{{ {_crypto.PublicKey.E}, {_crypto.PublicKey.N} }}";
            privateKeyLabel.Text = $"{{ {_crypto.PrivateKey.D}, {_crypto.PrivateKey.N} }}";
        }

        private void updateValueButton_Click(object sender, EventArgs eventArgs)
        {
            _crypto.P = _crypto.GeneratePrimeNumber();
            _crypto.Q = _crypto.GeneratePrimeNumber();

            pTextBox.Text = _crypto.P.ToString();
            qTextBox.Text = _crypto.Q.ToString();

            nTextBox.Text = string.Empty;
            eTextBox.Text = string.Empty;
            fnTextBox.Text = string.Empty;
            dTextBox.Text = string.Empty;

            publicKeyLabel.Text = string.Empty;
            privateKeyLabel.Text = string.Empty;
        }

        private void encryptButton_Click(object sender, EventArgs eventArgs)
        {
            var message = inputTextBox.Text;
            _crypto.Encrypt(message);
            inputNumbersLabel.Text = GetNumbersString(_crypto.InputNumbers);
            cipherLabel.Text = GetNumbersString(_crypto.Cipher);
        }

        

        private void decryptButton_Click(object sender, EventArgs e)
        {
            _crypto.Decrypt(_crypto.Cipher);

            outputNumbersLabel.Text = GetNumbersString(_crypto.OutputNumbers);
            outputTextBox.Text = _crypto.OutputMessage;
        }

        public static string GetNumbersString(List<BigInteger> numbers)
        {
            var str = $"{{ ";

            foreach (var item in numbers)
            {
                str += $"{item.ToString()}; ";
            }

            str += $"}}";

            return str;
        }
    }
}
