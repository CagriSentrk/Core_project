using BussinesLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Concrete
{
    public class toDoLİstManager : ItoDoListService
    {
        ItoDoListDal _todolistdal;

        public toDoLİstManager(ItoDoListDal todolistdal)
        {
            _todolistdal = todolistdal;
        }

        public void TAdd(ToDoList t)
        {
            _todolistdal.Insert(t);
        }

        public void TDelete(ToDoList t)
        {
            _todolistdal.Delete(t);
        }

        public ToDoList TGetByID(int id)
        {
            return _todolistdal.GetByID(id);
        }

        public List<ToDoList> TGetList()
        {
            return _todolistdal.GetList();
        }

        public void TUpdate(ToDoList t)
        {
            _todolistdal.Update(t);
        }
    }
}
