using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class Team
    {
        private List<Person> _members = new List<Person>();

        public void Add(Person person)
        {
            _members.Add(person);
        }

        public Person? FindByName(string name)
        {
            return _members.FirstOrDefault(p => p.Name == name);
        }

        public Person? Find(Person person)
        {
            return _members.Contains(person) ? person : null;
        }
    }
}
