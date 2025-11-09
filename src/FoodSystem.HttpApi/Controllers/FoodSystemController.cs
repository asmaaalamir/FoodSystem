using FoodSystem.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace FoodSystem.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class FoodSystemController : AbpControllerBase
{
    protected FoodSystemController()
    {
        LocalizationResource = typeof(FoodSystemResource);
    }
}
