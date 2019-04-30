using System;
using System.Collections.Generic;
using System.Linq;
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

            publicKeyTextBox.Text = string.Empty;
            privateKeyTextBox.Text = string.Empty;
            inputNumbersLabel.Text = string.Empty;
            cipherTextBox.Text = string.Empty;
            outputNumbersLabel.Text = string.Empty;

            outputTextBox.Enabled = false;

            publicKeyTextBox.Enabled = false;
            privateKeyTextBox.Enabled = false;
        }

        private void MainForm_Load(object sender, EventArgs eventArgs)
        {

        }

        private void calculateButton_Click(object sender, EventArgs eventArgs)
        {
            try
            {
                var p = new BigInteger(Convert.ToInt32(pTextBox.Text));
                var q = new BigInteger(Convert.ToInt32(qTextBox.Text));

                _crypto.Calculate(p, q);

                nTextBox.Text = _crypto.N.ToString();
                eTextBox.Text = _crypto.E.ToString();
                fnTextBox.Text = _crypto.Fn.ToString();
                dTextBox.Text = _crypto.D.ToString();

                publicKeyTextBox.Text = $"{{ {_crypto.PublicKey.E}; {_crypto.PublicKey.N} }}";
                privateKeyTextBox.Text = $"{{ {_crypto.PrivateKey.D}; {_crypto.PrivateKey.N} }}";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void updateValueButton_Click(object sender, EventArgs eventArgs)
        {
            try
            {
                _crypto.P = _crypto.GeneratePrimeNumber();
                _crypto.Q = _crypto.GeneratePrimeNumber();

                pTextBox.Text = _crypto.P.ToString();
                qTextBox.Text = _crypto.Q.ToString();

                nTextBox.Text = string.Empty;
                eTextBox.Text = string.Empty;
                fnTextBox.Text = string.Empty;
                dTextBox.Text = string.Empty;

                publicKeyTextBox.Text = string.Empty;
                privateKeyTextBox.Text = string.Empty;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        // TODO: Добавить возможность пользователю изменять значения параметров(хотя это не совсем правильно)
        // Сделанно так с целью того чтобы позволить пользователю изменять значения ключей и других параметров
        // Функционал для этого не сделан
        private void encryptButton_Click(object sender, EventArgs eventArgs)
        {
            try
            {
                var message = inputTextBox.Text;

                _crypto.P = new BigInteger(Convert.ToInt32(pTextBox.Text));
                _crypto.Q = new BigInteger(Convert.ToInt32(qTextBox.Text));
                _crypto.N = new BigInteger(Convert.ToInt32(nTextBox.Text));
                _crypto.Fn = new BigInteger(Convert.ToInt32(fnTextBox.Text));
                _crypto.E = new BigInteger(Convert.ToInt32(eTextBox.Text));
                _crypto.D = new BigInteger(Convert.ToInt32(dTextBox.Text));

                _crypto.PublicKey = new PublicKey
                {
                    E = new BigInteger(Convert.ToInt32(eTextBox.Text)),
                    N = new BigInteger(Convert.ToInt32(nTextBox.Text))
                };

                _crypto.PrivateKey = new PrivateKey
                {
                    D = new BigInteger(Convert.ToInt32(dTextBox.Text)),
                    N = new BigInteger(Convert.ToInt32(nTextBox.Text))
                };

                _crypto.Encrypt(message);
                inputNumbersLabel.Text = GetNumbersString(_crypto.InputNumbers);
                cipherTextBox.Text = GetNumbersString(_crypto.Cipher);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                _crypto.P = new BigInteger(Convert.ToInt32(pTextBox.Text));
                _crypto.Q = new BigInteger(Convert.ToInt32(qTextBox.Text));
                _crypto.N = new BigInteger(Convert.ToInt32(nTextBox.Text));
                _crypto.Fn = new BigInteger(Convert.ToInt32(fnTextBox.Text));
                _crypto.E = new BigInteger(Convert.ToInt32(eTextBox.Text));
                _crypto.D = new BigInteger(Convert.ToInt32(dTextBox.Text));

                _crypto.PublicKey = new PublicKey
                {
                    E = new BigInteger(Convert.ToInt32(eTextBox.Text)),
                    N = new BigInteger(Convert.ToInt32(nTextBox.Text))
                };

                _crypto.PrivateKey = new PrivateKey
                {
                    D = new BigInteger(Convert.ToInt32(dTextBox.Text)),
                    N = new BigInteger(Convert.ToInt32(nTextBox.Text))
                };

                // TODO: Исправить некорректную работу с русскими символами
                // Предположение что что-то не так с кодировкой

                //if (!string.IsNullOrEmpty(result) && result == inputTextBox.Text)
                //{
                outputTextBox.Text = _crypto.Decrypt(ToListBigInteger(cipherTextBox.Text));
                //}
                //else
                //{
                //    outputTextBox.Text = inputTextBox.Text;
                //}
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        public static string GetNumbersString(List<BigInteger> numbers)
        {
            var str = $"{{";

            foreach (var item in numbers)
                str += $"{item.ToString()};";

            str += $"}}";
            
            return str;
        }

        public static List<BigInteger> ToListBigInteger(string numbers)
        {
            var resultList = new List<BigInteger>();

            // Удаление скобок
            var modify = numbers.Substring(1, numbers.Length - 2);

            var arr = modify.Split(';');

            foreach (var item in arr.Take(arr.Length - 1))
                resultList.Add(new BigInteger(Convert.ToInt32(item)));

            return resultList;
        }
    }
}
