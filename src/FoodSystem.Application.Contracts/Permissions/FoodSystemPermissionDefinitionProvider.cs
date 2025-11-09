using FoodSystem.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace FoodSystem.Permissions;

public class FoodSystemPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(FoodSystemPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(FoodSystemPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<FoodSystemResource>(name);
    }
}
