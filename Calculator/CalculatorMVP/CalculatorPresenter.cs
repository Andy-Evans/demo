using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorMVP
{
    public class CalculatorPresenter
    {
        public CalculatorPresenter()
        {
            this.Model = new Calcualtor();
            this.View = new CalculatorView(this.Model) { Presenter = this };
        }

        protected Calcualtor Model { get; set; }

        public CalculatorView View { get; set; }

        public void Calculate()
        {
            double result = this.Model.Add(this.View.Input1, this.View.Input2);
            this.View.SetResult(result);
        }
    }
}
