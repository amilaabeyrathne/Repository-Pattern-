using DataAcces.Context;
using DataAcces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.UnitOfWorks
{
    public class UnitOfWork:IDisposable
    {
        private ShoppingDBEntities context = new ShoppingDBEntities();
        private GenaricRepository<ItemDetail> shopingItemRepository;

        public GenaricRepository<ItemDetail> ShopingItemRepository
        {
            get
            {

                if (this.shopingItemRepository == null)
                {
                    this.shopingItemRepository = new GenaricRepository<ItemDetail>(context);
                }
                return shopingItemRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
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
