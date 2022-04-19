using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    // Eğer temel CRUD operasyonları dışında bir işlem gerçekleştirmek istersek
    // imzasını aboutdal'da atıp işlemi burada yapacağız
    public class EfAboutDal : GenericRepository<About>, IAboutDal
    {
    }
}
