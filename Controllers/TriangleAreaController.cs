using Microsoft.AspNetCore.Mvc;

namespace ShapeCalcApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TriangleAreaController : ControllerBase
{
    private readonly ILogger<TriangleAreaController> _logger;
    private readonly ICalculator _calculator;

    public TriangleAreaController(ILogger<TriangleAreaController> logger)
    {
        _logger = logger;
        _calculator = new Calculator();
    }

    [HttpGet()]
    public double Get(double a, double b, double c)
    {
        return _calculator.GetTriangleArea(a, b, c);
    }
}
