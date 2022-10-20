using Microsoft.AspNetCore.Mvc;

namespace ShapeCalcApi.Controllers;

[ApiController]
[Route("[controller]")]
public class RectangleAreaController : ControllerBase
{
    private readonly ILogger<RectangleAreaController> _logger;
    private readonly ICalculator _calculator;

    public RectangleAreaController(ILogger<RectangleAreaController> logger)
    {
        _logger = logger;
        _calculator = new Calculator();
    }

    [HttpGet()]
    public double Get(double a, double b)
    {
        return _calculator.GetRectArea(a, b);
    }
}
