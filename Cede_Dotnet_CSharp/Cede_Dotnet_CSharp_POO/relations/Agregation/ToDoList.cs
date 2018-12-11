using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cede_Dotnet_CSharp_POO.relations.Agregation
{
    public class ToDoList
    {
        List<Item> Items { get; set; } = new List<Item>();

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public void RemoveItem(Item item)
        {
            Items.Remove(item);
        }

        public void MoveToDone(string ID)
        {
            var itemTemp = new Item(); 
            foreach (var item in Items)
            {
                if (item.ID.ToString() == ID)                
                    itemTemp = item;
            }

            itemTemp.IsDone = true;
        }
    }
}
