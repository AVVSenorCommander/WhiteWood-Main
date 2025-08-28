using Content.Shared.Roles;
using Content.Shared.Roles.Components;

namespace Content.Server.Roles;

[RegisterComponent]
public sealed partial class MindcontrolledRoleComponent : BaseMindRoleComponent
{
    [DataField] public EntityUid? MasterUid = null;
}
