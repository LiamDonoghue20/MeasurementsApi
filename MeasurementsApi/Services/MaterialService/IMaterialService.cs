using MeasurementsApi.Model;

namespace MeasurementsApi.Services.MaterialService
{
    public interface IMaterialService
    {
        Task<List<Material>> GetMaterials();
        Task<Material?> GetMaterial(int id);
        Task<List<Material>> AddMaterial(Material material);
        Task<List<Material>> UpdateMaterial(int id, Material material);
        Task<List<Material>> DeleteMaterial(int id);

    }
}
