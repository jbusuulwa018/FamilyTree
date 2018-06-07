using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfFamilyTrv.Model
{
    public class Person
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public string LastName { get; set; }
        public int? ParentId { get; set; }
        public ObservableCollection<Person> Children { get; set; }

    }
}
