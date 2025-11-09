using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using FoodSystem.Data;
using Volo.Abp.DependencyInjection;

namespace FoodSystem.EntityFrameworkCore;

public class EntityFrameworkCoreFoodSystemDbSchemaMigrator
    : IFoodSystemDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreFoodSystemDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the FoodSystemDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<FoodSystemDbContext>()
            .Database
            .MigrateAsync();
    }
}
