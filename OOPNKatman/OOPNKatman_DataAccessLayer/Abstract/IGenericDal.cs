using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPNKatman_DataAccessLayer.Abstract
{
    // hepsini kapsayacak anlamında I
    // bu tum entityler icin merkezi olacak islemleri aldi.
    public interface IGenericDal<T> where T : class // T turunde deger gelicek ama T class olmalı sadece  
    {
        void Insert(T entity); // ekleme işlemi
        void Update(T entity); // güncelleme işlemi
        void Delete(T entity); // silme işlemi
        List<T> GetAll(); // listeleme işlemi
        T GetById(int id); // id ile bulma işlemi
    }

}
