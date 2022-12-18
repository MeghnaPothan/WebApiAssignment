using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorWebApiTesting.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {

        [HttpPost]
        public double Addition(double left, double right)
        {
            //using the simple calculator logic class to add 2 numbers
            double result = CalculatorLogic.Calculator.Addition(left, right);

            //return added values in 2 decimal points
            return Math.Round(result, 2);
        }

        [HttpPost]
        public double Substraction(double left, double right)
        {
            //using the simple calculator logic class to substract 2 numbers
            double result = CalculatorLogic.Calculator.Substraction(left, right);

            return Math.Round(result, 2);
        }

        [HttpPost]
        public double Multiplication(double left, double right)
        {
            double result = CalculatorLogic.Calculator.Multiplication(left, right);

            return Math.Round(result, 2);
        }

       

            public double Division(double left, double right)
        {
            double result = 0; 
            try
            {

                return CalculatorLogic.Calculator.Division(left, right);

            }
            catch(DivideByZeroException)
            {
                Response.StatusCode = 400; 
            }
            return result;
        }
    }
}
