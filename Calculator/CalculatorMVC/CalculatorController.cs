using System;

namespace CalculatorMVC
{
    class CalculatorController
    {
        public CalculatorController()
        {
            this.Model = new Calculator();
            this.View = new CalculatorView();

            this.View.OnCalculate((s, e) => DoCalculation());
        }

        public CalculatorView View { get; private set; }
        public Calculator Model { get; private set; }

        private void DoCalculation()
        {
            try
            {
                double result = this.Model.Add(this.View.Input1, this.View.Input2);
                this.View.SetResult(result);
            }
            catch (FormatException ex)
            {
                this.View.ShowError(ex.Message);
            }
        }
    }
}
