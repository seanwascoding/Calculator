using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class Model
    {
        private double[] temp = new double[2];
        private string method;
        private double sum;

        public Model()
        {
            temp[0] = 0;
            temp[1] = 0;
            method = "";
            sum = 0;
        }

        public void setTemp(double arg)
        {
            if (this.method == "")
            {
                this.temp[0] = arg;
            }
            else
            {
                this.temp[1] = arg;
            }
        }

        public void setMethod(string m)
        {
           this.method = m;
        }

        public double Sum()
        {
            if (this.method == "+")
            {
                sum = temp[0] + temp[1];
                temp[0] = sum;
                return sum;
            }
            else if (this.method == "-")
            {
                sum = temp[0] - temp[1];
                temp[0] = sum;
                return sum;
            }
            else if (this.method == "x")
            {
                sum = temp[0] * temp[1];
                temp[0] = sum;
                return sum;
            }
            else if (this.method == "/")
            {
                sum = temp[0] / temp[1];
                temp[0] = sum;
                return sum;
            }
            else
            {
                return temp[0];
            }
        }

        public void Intialize()
        {
            temp[0] = 0;
            temp[1] = 0;
            method = "";
            sum = 0;
        }
    }
}
