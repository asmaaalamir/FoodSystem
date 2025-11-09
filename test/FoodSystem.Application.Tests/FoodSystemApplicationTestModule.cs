using Volo.Abp.Modularity;

namespace FoodSystem;

[DependsOn(
    typeof(FoodSystemApplicationModule),
    typeof(FoodSystemDomainTestModule)
)]
public class FoodSystemApplicationTestModule : AbpModule
{

}
