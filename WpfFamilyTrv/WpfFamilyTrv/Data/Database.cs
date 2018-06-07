using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfFamilyTrv.Model;
using WpfFamilyTrv.FamilyDataSetTableAdapters;

namespace WpfFamilyTrv.Data
{
    public class Database
    {
        public ObservableCollection<Person> Items { get; set; }
        #region GetFamilyTree

        public Person GetFamilyTree()
        {
            int idNo;
            //Prepare to get data
            DataTable root = new DataTable();
            root = GetData();

            //Filter data to get the root node
            var results = from myRow in root.AsEnumerable()
                          where myRow.Field<int?>("ParentId") == null
                          select myRow;
            int count = results.Count();

            Person person = new Person();
            //Populate the root node 
            Items = new ObservableCollection<Person>();
            foreach (var a in results)
            {
                var lvl1 = new Person { Name = a["FirstName"].ToString() + " " + a["LastName"].ToString(), Children = new ObservableCollection<Person>() };
                idNo = Convert.ToInt32(a["Id"].ToString());

                //Call the function to get all the children
                Items.Add(getAll(lvl1, idNo));
                person = lvl1;
            }

            return person;

        }

        public Person getAll(Person node, int id)
        {
            int idNo = id;
            var child = getChild(idNo).AsEnumerable();
            foreach (var b in child)
            {
                var lvl2 = new Person { Name = b["FirstName"].ToString() + " " + b["LastName"].ToString(), Children = new ObservableCollection<Person>() };
                idNo = Convert.ToInt32(b["Id"].ToString());
                node.Children.Add(getAll(lvl2, idNo));
            }
            return node;

        }

        public string getName(int id)
        {
            int idNo = id;
            string Name="";
            var child = getChild(idNo).AsEnumerable();
            foreach (var b in child)
            {
               Name =  b["LastName"].ToString();
            }
            return Name;

        }
        public DataTable GetData()
        {

            FDTableAdapter adapter = new FDTableAdapter();
            FamilyDataSet individual = new FamilyDataSet();

            adapter.Fill(individual.Sections);

            DataTable tb;
            tb = new DataTable();

            tb = individual.Tables[0];

         //return table;
            return tb;
        }
        /// <summary>
        /// This function is call each time to filter the data for the each node in the tree
        /// </summary>
        /// <param name="Idno"></param>
        /// <returns></returns>
        public DataTable getChild(int Idno)
        {
            string expression = "ParentId =" + Idno;
            DataTable table = new DataTable();
            table = GetData();
            DataTable results = new DataTable();
            var filteredDataRows = table.Select(expression);
            var filteredDataTable = new DataTable();
            if (filteredDataRows.Length != 0)
                filteredDataTable = filteredDataRows.CopyToDataTable();
            return filteredDataTable;
        }

        #endregion // GetFamilyTree
    }
}
