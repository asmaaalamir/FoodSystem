using FoodSystem.Samples;
using Xunit;

namespace FoodSystem.EntityFrameworkCore.Domains;

[Collection(FoodSystemTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<FoodSystemEntityFrameworkCoreTestModule>
{

}
