using System;
using System.Collections.Generic;
using System.Text;
using FoodSystem.Localization;
using Volo.Abp.Application.Services;

namespace FoodSystem;

/* Inherit your application services from this class.
 */
public abstract class FoodSystemAppService : ApplicationService
{
    protected FoodSystemAppService()
    {
        LocalizationResource = typeof(FoodSystemResource);
    }
}
