using MeasurementsApi.Data;
using MeasurementsApi.Model;
using Microsoft.EntityFrameworkCore;

namespace MeasurementsApi.Services.MaterialService
{
    public class MaterialService : IMaterialService
    {
        private readonly DataContext _context;

        public MaterialService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Material>> GetMaterials()
        {
            var materials = await _context.Material.ToListAsync();
            return materials;
        }
        public async Task<Material?> GetMaterial(int id)
        {
            var material = await _context.Material.FindAsync(id);
            if (material is null)
                return null;

            return material;
        }
        public async Task<List<Material>> AddMaterial(Material material)
        {
            _context.Material.Add(material);
            await _context.SaveChangesAsync();
            return await _context.Material.ToListAsync();
        }
        public async Task<List<Material>?> UpdateMaterial(int id, Material request)
        {
            var material = await _context.Material.FindAsync(id);
            if (material is null)
                return null;

            material.Name = request.Name;
            material.PricePerUnit = request.PricePerUnit;
            material.Quantity = request.Quantity;
            material.UnitOfMeasurement = request.UnitOfMeasurement;

            await _context.SaveChangesAsync();

            return await _context.Material.ToListAsync();
        }

        public async Task<List<Material>?> DeleteMaterial(int id)
        {
            var material = await _context.Material.FindAsync(id);
            if (material == null) return null;

            _context.Material.Remove(material);
            await _context.SaveChangesAsync();
            return await _context.Material.ToListAsync();
        }
    }
}
