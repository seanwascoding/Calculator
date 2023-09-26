using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class Model
    {
        const string PLUS_SIGN = "+";
        const string MINUS_SIGN = "-";
        const string TIMES_SIGN = "x";
        const string SLASH_SIGN = "/";
        const int SIZE = 2;
        private double[] _temp = new double[SIZE];
        private string _method;
        private double _sum;
        
        public Model()
        {
            _temp[0] = 0;
            _temp[1] = 0;
            _method = "";
            _sum = 0;
        }

        // operand
        public void SetParameter(double value)
        {
            if (_method == "")
            {
                _temp[0] = value;
            }
            else
            {
                _temp[1] = value;
            }
        }

        // operation
        public void SetMethod(string method)
        {
            _method = method;
        }

        // Total
        public double GetSum()
        {
            if (_method == PLUS_SIGN)
                _sum = _temp[0] + _temp[1];
            else if (_method == MINUS_SIGN)
                _sum = _temp[0] - _temp[1];
            else if (_method == TIMES_SIGN)
                _sum = _temp[0] * _temp[1];
            else if (_method == SLASH_SIGN)
                _sum = _temp[0] / _temp[1];
            else
                _sum = _temp[0];
            _temp[0] = _sum;
            return _sum;
        }

        // Reset
        public void Reset()
        {
            _temp[0] = 0;
            _temp[1] = 0;
            _method = "";
            _sum = 0;
        }
    }
}
