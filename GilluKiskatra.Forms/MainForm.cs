using System;
using System.Drawing;
using System.Numerics;
using System.Windows.Forms;

namespace GilluKiskatra.Forms
{
    public partial class MainForm : Form
    {
        #region Consts

        private const string RIGHT_TEXT = "Верно";
        private const string FALSE_TEXT = "Не верно";

        #endregion

        #region Fields

        private static GilluKiskatra _crypto;
        // В случе ошибки в подсчётах, сюда записывается значение для дальнейшей выдачи ожидаемого ответа
        private static GilluKiskatra _falseObject;

        #endregion

        public MainForm()
        {
            InitializeComponent();

            resultLabel.Visible = false;
            _crypto = new GilluKiskatra();

            pTextBox.Text = _crypto.P.ToString();
            qTextBox.Text = _crypto.Q.ToString();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void updateValueButton_Click(object sender, EventArgs e)
        {
            _crypto.P = _crypto.GeneratePrimeNumber();
            _crypto.Q = _crypto.GeneratePrimeNumber();

            pTextBox.Text = _crypto.P.ToString();
            qTextBox.Text = _crypto.Q.ToString();

            _crypto.Calculate(_crypto.P, _crypto.Q);

            nTextBox.Text = string.Empty;
            vTextBox.Text = string.Empty;
            sTextBox.Text = string.Empty;
            idTextBox.Text = string.Empty;
            spTextBox.Text = string.Empty;
            rTextBox.Text = string.Empty;
            xTextBox.Text = string.Empty;
            eTextBox.Text = string.Empty;
            yTextBox.Text = string.Empty;

            resultLabel.Text = string.Empty;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            _crypto.Calculate(_crypto.P, _crypto.Q);

            SetValueInTextBox();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            resultLabel.Visible = true;
            var check = false;

            if (_crypto.Result)
            {
                var X = new BigInteger(Convert.ToInt32(xTextBox.Text));
                var Y = new BigInteger(Convert.ToInt32(yTextBox.Text));
                var V = new BigInteger(Convert.ToInt32(vTextBox.Text));
                var Id = new BigInteger(Convert.ToInt32(idTextBox.Text));
                var E = new BigInteger(Convert.ToInt32(eTextBox.Text));
                var N = new BigInteger(Convert.ToInt32(nTextBox.Text));

                check = _crypto.CheckEquality(X, Y, V, Id, E, N);
            }
            else
            {
                _falseObject = new GilluKiskatra
                {
                    P = new BigInteger(Convert.ToInt32(pTextBox.Text)),
                    Q = new BigInteger(Convert.ToInt32(qTextBox.Text)),
                    N = new BigInteger(Convert.ToInt32(nTextBox.Text)),
                    V = new BigInteger(Convert.ToInt32(vTextBox.Text)),
                    S = new BigInteger(Convert.ToInt32(sTextBox.Text)),
                    Id = new BigInteger(Convert.ToInt32(idTextBox.Text)),
                    Sp = new BigInteger(Convert.ToInt32(spTextBox.Text)),
                    R = new BigInteger(Convert.ToInt32(rTextBox.Text)),
                    X = new BigInteger(Convert.ToInt32(xTextBox.Text)),
                    E = new BigInteger(Convert.ToInt32(eTextBox.Text)),
                    Y = new BigInteger(Convert.ToInt32(yTextBox.Text)),
                };

                check = _crypto.Equals(_falseObject);
            }

            if (check)
            {
                resultLabel.ForeColor = Color.ForestGreen;
                resultLabel.Text = RIGHT_TEXT;
            }
            else
            {
                resultLabel.ForeColor = Color.DarkRed;
                resultLabel.Text = FALSE_TEXT;
            }
        }

        #region Methods

        private void SetValueInTextBox()
        {
            nTextBox.Text = _crypto.N.ToString();
            vTextBox.Text = _crypto.V.ToString();
            sTextBox.Text = _crypto.S.ToString();
            idTextBox.Text = _crypto.Id.ToString();
            spTextBox.Text = _crypto.Sp.ToString();
            rTextBox.Text = _crypto.R.ToString();
            xTextBox.Text = _crypto.X.ToString();
            eTextBox.Text = _crypto.E.ToString();
            yTextBox.Text = _crypto.Y.ToString();
        }

        private void GetValue()
        {
            _crypto.N = new BigInteger(Convert.ToInt32(nTextBox.Text));
            _crypto.V = new BigInteger(Convert.ToInt32(vTextBox.Text));
            _crypto.S = new BigInteger(Convert.ToInt32(sTextBox.Text));
            _crypto.Id = new BigInteger(Convert.ToInt32(idTextBox.Text));
            _crypto.Sp = new BigInteger(Convert.ToInt32(spTextBox.Text));
            _crypto.R = new BigInteger(Convert.ToInt32(rTextBox.Text));
            _crypto.X = new BigInteger(Convert.ToInt32(xTextBox.Text));
            _crypto.E = new BigInteger(Convert.ToInt32(eTextBox.Text));
            _crypto.Y = new BigInteger(Convert.ToInt32(yTextBox.Text));
        }

        #endregion
    }
}
