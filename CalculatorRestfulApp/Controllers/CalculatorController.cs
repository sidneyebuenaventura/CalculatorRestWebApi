using Microsoft.AspNetCore.Mvc;

namespace CalculatorRestfulApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
   
        }

        [HttpGet]
        [Route("Addition")]
        public ActionResult<int> Addition(int addendsOne, int addendsTwo)
        {
            try
            {
                VariableValidation.EnsureValidVariables(addendsOne, addendsTwo);

                int sum = addendsOne + addendsTwo;
               
                return new OkObjectResult(sum);
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }            
        }

        [HttpGet]
        [Route("Multiplication")]
        public ActionResult<int> Multiplication(int multiplier, int multiplicand)
        {
            try
            {
                VariableValidation.EnsureValidVariables(multiplier, multiplicand);

                int prod = multiplier * multiplicand;

                return new OkObjectResult(prod);
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }
        }

        [HttpGet]
        [Route("Subtraction")]
        public ActionResult<int> Subtraction(int num1, int num2)
        {
            try
            {
                VariableValidation.EnsureValidVariables(num1, num2);

                int diff = num1 - num2;

                return new OkObjectResult(diff);
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }
        }

        [HttpGet]
        [Route("Division")]
        public ActionResult<double> Division(double dividend, double divisor)
        {
            try
            {
                // VariableValidation.EnsureValidVariables(dividend, divisor);
                if (divisor == 0)
                    throw new ArgumentException("Divisor must be greater than zero");

                double quotient = dividend / divisor;

                return new OkObjectResult(quotient);
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }
        }
    }
}