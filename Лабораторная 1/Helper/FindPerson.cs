using System;
using Лабораторная_1.Model;

namespace Лабораторная_1.Helper
{
    class FindPerson
    {
        
            int id;
            public FindPerson(int id)
            {
                this.id = id;
            }
            public bool PersonPredicate(Person role)
            {
                return role.Id == id;
            }
        

    }
}
