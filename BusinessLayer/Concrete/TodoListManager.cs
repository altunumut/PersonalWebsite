using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TodoListManager : ITodoListService
    {
        ITodoListDal _todoListDal;
        public TodoListManager(ITodoListDal todoListDal)
        {
            _todoListDal = todoListDal;
        }

        public void TAdd(TodoList t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(TodoList t)
        {
            throw new NotImplementedException();
        }

        public TodoList TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<TodoList> TGetList()
        {
            return _todoListDal.GetList();
        }

        public void TUpdate(TodoList t)
        {
            throw new NotImplementedException();
        }
    }
}
