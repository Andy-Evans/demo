using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorMVC
{
    public partial class CalculatorView : Form
    {
        public CalculatorView()
        {
            InitializeComponent();
        }

        public void OnCalculate(EventHandler eventHandler)
        {
            this.btnCalculate.Click += eventHandler;
        }

        public double Input1 {
            get
            {
                return Convert.ToDouble(this.txtInput1.Text);
            }
        }

        internal void SetResult(double result)
        {
            this.lblResult.Text = result.ToString();
        }

        public double Input2
        {
            get
            {
                return Convert.ToDouble(this.txtInput2.Text);
            }
        }

        internal void ShowError(string errorMsg)
        {
            MessageBox.Show(errorMsg);
        }
    }
}
