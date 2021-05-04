using System;
using System.Collections.Generic;

namespace middleware
{
    public class OperationDb<T>
    {
        public void Insert(T element) {

        }

        public T GetElement(string id) {
            throw new Exception();
        }

        public List<T> GetAll()
        {
            throw new Exception();
        }





    }
}
