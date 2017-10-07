using DataAcces.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Repository
{
    interface IShoppingRepository:IDisposable
    {
        IEnumerable<ItemDetail> GetItem();
        ItemDetail GetItemByID(int itemId);
        void Insert(ItemDetail item);
        void Delete(int itemId);
        void Update(ItemDetail item);
        void Save();
    }
}
