using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace FoodSystem.Data;

/* This is used if database provider does't define
 * IFoodSystemDbSchemaMigrator implementation.
 */
public class NullFoodSystemDbSchemaMigrator : IFoodSystemDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
