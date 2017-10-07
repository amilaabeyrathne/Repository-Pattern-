using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcces.Context;

namespace DataAcces.Repository
{
    public class ShoppingRepository : IShoppingRepository, IDisposable
    {
        private ShoppingDBEntities context;
        private bool disposed = false;

        public ShoppingRepository(ShoppingDBEntities context)
        {
            this.context = context;
        }

        public void Delete(int itemId)
        {
            ItemDetail itme = context.ItemDetails.Find(itemId);
            context.ItemDetails.Remove(itme);

        }

        public IEnumerable<ItemDetail> GetItem()
        {
            return context.ItemDetails.ToList();
        }

        public ItemDetail GetItemByID(int itemId)
        {
            ItemDetail item = context.ItemDetails.Find(itemId);
            return item;
        }

        public void Insert(ItemDetail item)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(ItemDetail item)
        {
            throw new NotImplementedException();
        }

        public void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
