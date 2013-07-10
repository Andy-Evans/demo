namespace CalculatorMVP
{
    using System;
    using System.Windows.Forms;

    public partial class CalculatorView : Form
    {
        public CalculatorView(Calcualtor model)
        {
            this.Model = model;
            this.InitializeComponent();
        }

        public Calcualtor Model { get; set; }

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

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            this.Presenter.Calculate();
        }

        public CalculatorPresenter Presenter { get; set; }
    }
}
