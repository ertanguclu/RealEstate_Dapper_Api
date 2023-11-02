using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Repositories.ServiceRepository;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IServiceRepository _serviceRespository;
        public ServicesController(IServiceRepository serviceRespository)
        {
            _serviceRespository = serviceRespository;
        }

        [HttpGet]
        public async Task<IActionResult> GetServiceList() 
        {
            var values = await _serviceRespository.GetAllServiceAsync();
            return Ok(values);
        }
    }
}
