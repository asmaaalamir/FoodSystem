using FoodSystem.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace FoodSystem.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(FoodSystemEntityFrameworkCoreModule),
    typeof(FoodSystemApplicationContractsModule)
    )]
public class FoodSystemDbMigratorModule : AbpModule
{
}
