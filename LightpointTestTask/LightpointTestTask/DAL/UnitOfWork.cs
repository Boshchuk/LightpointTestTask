using System;
using LightpointTestTask.Models;

namespace LightpointTestTask.DAL
{
    public class UnitOfWork : IDisposable
    {
        private LightpointContext context = new LightpointContext();
        private GenericRepository<Store> storeRepository;
        private GenericRepository<Product> productRepository;

        public GenericRepository<Store> StoreRepository
        {
            get
            {

                if (this.storeRepository == null)
                {
                    this.storeRepository = new GenericRepository<Store>(context);
                }
                return storeRepository;
            }
        }

        public GenericRepository<Product> ProductRepository
        {
            get
            {

                if (this.productRepository == null)
                {
                    this.productRepository = new GenericRepository<Product>(context);
                }
                return productRepository;
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