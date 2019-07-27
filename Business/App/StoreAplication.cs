using Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace App
{
    public class StoreAplication:IAppStore
    {
        IStore _InterfaceStore;

        public StoreAplication(IStore InterfaceStore)
        {
            InterfaceStore = InterfaceStore;
        }

        public void Delete(int id)
        {
            _InterfaceStore.Delete(id);
        }

        public IEnumerable<Stores> GetAll()
        {
            return _InterfaceStore.GetAll();
        }

        public Stores GetById(int id)
        {
            return _InterfaceStore.GetById(id);
        }

        public void Save(Stores entity)
        {
            _InterfaceStore.Save(entity);
        }

        public Stores Update(Stores entity)
        {
            return _InterfaceStore.Update(entity);
        }
    }
}
