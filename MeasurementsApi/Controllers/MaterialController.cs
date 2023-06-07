using MeasurementsApi.Model;
using Microsoft.AspNetCore.Mvc;
using MeasurementsApi.Services.MaterialService;

namespace materialAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class materialController : ControllerBase
    {
        private readonly IMaterialService _materialService;
        public materialController(IMaterialService materialService)

        {
            _materialService = materialService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Material>>> GetMaterials()
        {

            return await _materialService.GetMaterials();


        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Material>>> GetMaterial(int id)
        {
            var result = await _materialService.GetMaterial(id);
            if (result == null) return NotFound("Material not found");
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Material>>> AddMaterial(Material material)
        {
            var result = await _materialService.AddMaterial(material);


            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Material>>> UpdateMaterial(int id, Material request)
        {
            var result = await _materialService.UpdateMaterial(id, request);
            if (result is null) return NotFound("Material not found");

            return Ok(result);
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Material>>> DeleteMaterial(int id)
        {
            var result = await _materialService.DeleteMaterial(id);
            if (result is null) return NotFound("Material not found");

            return Ok(result);
        }

    }
}
