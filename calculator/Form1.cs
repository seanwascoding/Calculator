using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        // declared
        Model _model;
        List<char> _temp = new List<char>();
        bool _state = false; 
        const char CHAR_ZERO = '0';
        const string STRING_ZERO = "0";
        const char CHAR_ONE = '1';
        const char CHAR_TWO = '2';
        const char CHAR_THREE = '3';
        const char CHAR_FOUR = '4';
        const char CHAR_FIVE = '5';
        const char CHAR_SIX = '6';
        const char CHAR_SEVEN = '7';
        const char CHAR_EIGHT = '8';
        const char CHAR_NINE = '9';
        const char DOT_SIGN = '.';
        const string AVOID_MESSAGE = "Pls Enter the num";
        const string RESET = "RESET first";
        const string PLUS_SIGN = "+";
        const string MINUS_SIGN = "-";
        const string TIMES_SIGN = "x";
        const string SLASH_SIGN = "/";

        // windows instance
        public Form1(Model model)
        {
            this._model = model;
            InitializeComponent();
        }

        // +
        private void ClickPlus(object sender, EventArgs e)
        {
            if (_temp.Count == 0)
            {
                MessageBox.Show(AVOID_MESSAGE);
                return;
            }
            else if (_state && _temp.Count > 1)
            {
                MessageBox.Show(RESET);
                return;
            }
            _model.SetParameter(double.Parse(new string(_temp.ToArray())));
            _results.Text = _model.GetSum().ToString();
            _model.SetMethod(PLUS_SIGN);
            _temp.Clear();
            _state = false;
        }

        // -
        private void ClickMinus(object sender, EventArgs e)
        {
            if (_temp.Count == 0)
            {
                MessageBox.Show(AVOID_MESSAGE);
                return;
            }
            else if (_state && _temp.Count > 1)
            {
                MessageBox.Show(RESET);
                return;
            }
            _model.SetParameter(double.Parse(new string(_temp.ToArray())));
            _results.Text = _model.GetSum().ToString();
            _model.SetMethod(MINUS_SIGN);
            _temp.Clear();
            _state = false;
        }

        // x
        private void ClickTimes(object sender, EventArgs e)
        {
            if (_temp.Count == 0)
            {
                MessageBox.Show(AVOID_MESSAGE);
                return;
            }
            else if (_state && _temp.Count > 1)
            {
                MessageBox.Show(RESET);
                return;
            }
            _model.SetParameter(double.Parse(new string(_temp.ToArray())));
            _results.Text = _model.GetSum().ToString();
            _model.SetMethod(TIMES_SIGN);
            _temp.Clear();
            _state = false;
        }

        // ÷
        private void ClickSlash(object sender, EventArgs e)
        {
            if (_temp.Count == 0)
            {
                MessageBox.Show(AVOID_MESSAGE);
                return;
            }
            else if (_state && _temp.Count > 1)
            {
                MessageBox.Show(RESET);
                return;
            }
            _model.SetParameter(double.Parse(new string(_temp.ToArray())));
            _results.Text = _model.GetSum().ToString();
            _model.SetMethod(SLASH_SIGN);
            _temp.Clear();
            _state = false;
        }

        // =
        private void ClickEqual(object sender, EventArgs e)
        {
            if (_temp.Count == 0)
            {
                MessageBox.Show(AVOID_MESSAGE);
                return;
            }
            else if (_state && _temp.Count > 1)
            {
                MessageBox.Show(RESET);
                return;
            }
            _model.SetParameter(double.Parse(new string(_temp.ToArray())));
            _results.Text = _model.GetSum().ToString();
            _temp.Clear();
            _model.SetMethod(PLUS_SIGN);
            _temp.Add(CHAR_ZERO);
            _state = true;
        }

        // C
        private void ClearClick(object sender, EventArgs e)
        {
            _model.Reset();
            _temp.Clear();
            _results.Text = "";
            _state = false;
        }

        //CE
        private void ClearEntryClick(object sender, EventArgs e)
        {
            if (_temp.Count == 0 || new string(_temp.ToArray()) == STRING_ZERO)
            {
                MessageBox.Show(AVOID_MESSAGE);
            }
            else
            {
                _temp.Clear();
                _results.Text = "";
            }
        }

        // 0
        private void ClickZero(object sender, EventArgs e)
        {
            _temp.Add(CHAR_ZERO);
            _results.Text = new string(_temp.ToArray());
        }

        // 1
        private void ClickOne(object sender, EventArgs e)
        {
            _temp.Add(CHAR_ONE);
            _results.Text = new string(_temp.ToArray());
        }

        // 2
        private void ClickTwo(object sender, EventArgs e)
        {
            _temp.Add(CHAR_TWO);
            _results.Text = new string(_temp.ToArray());
        }

        // 3
        private void ClickThree(object sender, EventArgs e)
        {
            _temp.Add(CHAR_THREE);
            _results.Text = new string(_temp.ToArray());
        }

        // 4
        private void ClickFour(object sender, EventArgs e)
        {
            _temp.Add(CHAR_FOUR);
            _results.Text = new string(_temp.ToArray());
        }

        // 5
        private void ClickFive(object sender, EventArgs e)
        {
            _temp.Add(CHAR_FIVE);
            _results.Text = new string(_temp.ToArray());
        }

        // 6
        private void ClickSix(object sender, EventArgs e)
        {
            _temp.Add(CHAR_SIX);
            _results.Text = new string(_temp.ToArray());
        }

        // 7
        private void ClickSeven(object sender, EventArgs e)
        {
            _temp.Add(CHAR_SEVEN);
            _results.Text = new string(_temp.ToArray());
        }

        // 8
        private void ClickEight(object sender, EventArgs e)
        {
            _temp.Add(CHAR_EIGHT);
            _results.Text = new string(_temp.ToArray());
        }

        // 9
        private void ClickNine(object sender, EventArgs e)
        {
            _temp.Add(CHAR_NINE);
            _results.Text = new string(_temp.ToArray());
        }

        // .
        private void ClickDot(object sender, EventArgs e)
        {
            _temp.Add(DOT_SIGN);
            _results.Text = new string(_temp.ToArray());
        }
    }
}
