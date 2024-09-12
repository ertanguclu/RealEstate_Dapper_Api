using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Dtos.ServiceDtos;
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
            var values = await _serviceRespository.GetAllService();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateService(CreateServiceDto createServiceDto)
        {
            await _serviceRespository.CreateService(createServiceDto);
            return Ok("Hizmet Kısmı Başarılı Bir Şekilde Eklendi");


        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteService(int id)
        {
            await _serviceRespository.DeleteService(id);
            return Ok("Hizmet Kısmı Başarılı Bir Şekilde Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateService(UpdateServiceDto updateServiceDto)
        {
            await _serviceRespository.UpdateService(updateServiceDto);
            return Ok("Hizmet Kısmı Başarıyla Güncellendi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetService(int id)
        {
            var value = await _serviceRespository.GetService(id);
            return Ok(value);
        }
    }
}
