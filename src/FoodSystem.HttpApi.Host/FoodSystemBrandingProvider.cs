using Microsoft.Extensions.Localization;
using FoodSystem.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace FoodSystem;

[Dependency(ReplaceServices = true)]
public class FoodSystemBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<FoodSystemResource> _localizer;

    public FoodSystemBrandingProvider(IStringLocalizer<FoodSystemResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
