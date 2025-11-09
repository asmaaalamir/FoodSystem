using System.Threading.Tasks;

namespace FoodSystem.Data;

public interface IFoodSystemDbSchemaMigrator
{
    Task MigrateAsync();
}
