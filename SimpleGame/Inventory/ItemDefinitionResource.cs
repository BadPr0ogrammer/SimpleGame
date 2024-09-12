using SimpleGame.Inventory;
using SimpleGame.Utils;
using Urho3DNet;

namespace SimpleGame
{
    /// <summary>
    /// Resource container for ItemDefinition.
    /// </summary>
    [ObjectFactory]
    public partial class ItemDefinitionResource: JsonResource<ItemDefinition>
    {
        public ItemDefinitionResource(Context context) : base(context)
        {
        }
    }
}