using Xunit;

namespace FoodSystem.EntityFrameworkCore;

[CollectionDefinition(FoodSystemTestConsts.CollectionDefinitionName)]
public class FoodSystemEntityFrameworkCoreCollection : ICollectionFixture<FoodSystemEntityFrameworkCoreFixture>
{

}
