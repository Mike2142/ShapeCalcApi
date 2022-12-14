using Microsoft.AspNetCore.Mvc;

namespace ShapeCalcApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CircleAreaController : ControllerBase
{
    private readonly ILogger<CircleAreaController> _logger;
    private readonly ICalculator _calculator;

    public CircleAreaController(ILogger<CircleAreaController> logger)
    {
        _logger = logger;
        _calculator = new Calculator();
    }

    [HttpGet()]
    public double Get(double radius)
    {
        return _calculator.GetCircleArea(radius);
    }
}
