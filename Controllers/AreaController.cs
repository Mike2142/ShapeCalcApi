using Microsoft.AspNetCore.Mvc;

namespace ShapeCalcApi.Controllers;

[ApiController]
[Route("[controller]")]
public class AreaController : ControllerBase
{   
    private readonly ILogger<AreaController> _logger;
    private readonly ICalculator _calculator;

    public AreaController(ILogger<AreaController> logger)
    {
        _logger = logger;
        _calculator = new Calculator();
    }
    
    [HttpGet()]
    public double Get(double a, double b, double c)
    {   
        bool aFlag = Convert.ToBoolean(a);
        bool bFlag = Convert.ToBoolean(b);
        bool cFlag = Convert.ToBoolean(c);

        if (aFlag && !bFlag && !cFlag) 
        {
            // circle area
            return _calculator.GetCircleArea(a);
        } 
        else if (aFlag && bFlag && !cFlag) 
        {
            // rectangle area
            return _calculator.GetRectArea(a, b);
        } 
        else if (aFlag && bFlag && cFlag) 
        {
            // triangle area
            return _calculator.GetTriangleArea(a, b, c);
        }  

        return 0;
    }
}
