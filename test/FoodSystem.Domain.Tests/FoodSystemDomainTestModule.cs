using Volo.Abp.Modularity;

namespace FoodSystem;

[DependsOn(
    typeof(FoodSystemDomainModule),
    typeof(FoodSystemTestBaseModule)
)]
public class FoodSystemDomainTestModule : AbpModule
{

}
