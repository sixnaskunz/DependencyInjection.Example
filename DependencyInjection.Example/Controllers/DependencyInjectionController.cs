

namespace DependencyInjection.Example.Controllers;

[Route("[controller]")]
public class DependencyInjectionController(ISingletonService singletonService,
                                           IScopedService scopedService1,
                                           IScopedService scopedService2,
                                           ITransientService transientService1,
                                           ITransientService transientService2)
{
    [HttpGet]
    public ActionResult<string> GetValue()
    {
        return $"Singleton: {singletonService.GetDIValue()} \r\n"
        + $"Scoped1: {scopedService1.GetDIValue()} \r\n"
        + $"Scoped2: {scopedService2.GetDIValue()} \r\n"
        + $"Transient1: {transientService1.GetDIValue()} \r\n"
        + $"Transient2: {transientService2.GetDIValue()} \r\n";
    }
}