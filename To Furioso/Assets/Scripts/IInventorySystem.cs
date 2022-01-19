using System.Collections.Generic;

namespace Adapter
{
    public interface IInventorySystem
    {
        void SyncInventories();

        void AddItem(InventoryItem item, SaveLocation location);

        void RemoveItem(InventoryItem item, SaveLocation location);

        List<InventoryItem> GetInventory(SaveLocation location);
    }

}
