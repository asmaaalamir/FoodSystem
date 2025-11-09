using Volo.Abp.Modularity;

namespace FoodSystem;

public abstract class FoodSystemApplicationTestBase<TStartupModule> : FoodSystemTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
