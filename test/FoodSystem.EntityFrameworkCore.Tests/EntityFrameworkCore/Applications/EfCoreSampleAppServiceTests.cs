using FoodSystem.Samples;
using Xunit;

namespace FoodSystem.EntityFrameworkCore.Applications;

[Collection(FoodSystemTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<FoodSystemEntityFrameworkCoreTestModule>
{

}
