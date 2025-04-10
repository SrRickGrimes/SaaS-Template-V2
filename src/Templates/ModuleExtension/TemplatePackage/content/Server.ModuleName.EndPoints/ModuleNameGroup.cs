using FastEndpoints;

namespace Server.ModuleName.EndPoints;

internal class ModuleNameGroup:Group
{
    public ModuleNameGroup() 
    {
        Configure(nameof(ModuleName).ToLower(), _ =>
        {

        });
    }
}
