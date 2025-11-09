using Volo.Abp.Modularity;

namespace FoodSystem;

/* Inherit from this class for your domain layer tests. */
public abstract class FoodSystemDomainTestBase<TStartupModule> : FoodSystemTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
