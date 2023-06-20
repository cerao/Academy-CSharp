using System;
using System.Xml.Linq;

namespace CustomListNs
{
    public class Person
    {
        private string _titlee;
        private string _author;
        private int _year;
        private DateTime _birthday;

        public string Titlee
        {
            get { return _titlee; }
            set { _titlee = value; }
        }
        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }
        public DateTime Birthday
        {
            get { return _birthday; }
            set { _birthday = value; }
        }
    }

    public class PersonList<Person>
    {
        private List<Person> _personList;


        public int Count() {

            return _personList.Count; 
        }
        public PersonList()
        {
            _personList = new List<Person>();
        }


        public void AddElement(Person person)
        {

            _personList.Add(person);
        }
        public void AddList(PersonList<Person> pList)
        {
            _personList.AddRange(pList._personList);
        }
        public bool InsertElement(int insertIndex, Person person)
        {
            if(_personList.Count > insertIndex && insertIndex >= 0)
            {
                _personList.Insert(insertIndex, person);
                return true;
            } 
            return false;
        }
        public bool InsertList(int insertIndex, PersonList<Person> pList)
        {
            var LastIndex = pList._personList.Count + insertIndex;
            if (_personList.Count > insertIndex && insertIndex >= 0 && _personList.Count >= LastIndex)
            {
                var j = 0;
                for(int i = insertIndex; i < LastIndex; i++)
                {
                    
                    _personList.Insert(i, pList._personList[j]);
                    j++;
                }
                return true;
            }
            return false;
        }
        public bool GetElement(int i,out Person person)
        {
            if (_personList.Count > i)
            {
                person = _personList[i];
                return true;

            }
            else
                person = default(Person);
                return false;
        }
        public bool GetList(int Index,int QuantityOfElements, out List<Person> pList)
        {
            var LastIndex = Index + QuantityOfElements;
            if (Index >= 0 && LastIndex <= _personList.Count)
            {
                pList = _personList.GetRange(Index, LastIndex);
                return true;
            }
            pList = default(List<Person>);
            return false;
        }
        public void RemoveElement(Person person)
        {
            _personList.Remove(person);
        }
        public void RemoveList(List<Person> pList)
        {
            foreach (Person p in pList)
            {
                _personList.Remove(p);
            }
        }
        public void ClearList()
        {
            _personList.Clear();
        }
        public Person Find(Predicate <Person> Element)
        {
            return _personList.Find(Element);
        }
    }
}


