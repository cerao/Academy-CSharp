// See https://aka.ms/new-console-template for more information
using CustomListNs;

Person person = new Person() {Author= "Author0", Titlee="sad", Year=0,Birthday=new DateTime() };
Person person1 = new Person() { Author = "Author1", Titlee = "sad", Year = 1, Birthday = new DateTime() };
Person person2 = new Person() { Author = "Author2", Titlee = "sad", Year = 2, Birthday = new DateTime() };
Person person3 = new Person() { Author = "Author3", Titlee = "sad", Year = 3, Birthday = new DateTime() };
Person person4 = new Person() { Author = "Author4", Titlee = "sad", Year = 4, Birthday = new DateTime() };
Person person5 = new Person() { Author = "Author5", Titlee = "sad", Year = 5, Birthday = new DateTime() };
Person person6 = new Person() { Author = "Author6", Titlee = "sad", Year = 6, Birthday = new DateTime() };
Person person7 = new Person() { Author = "Author7", Titlee = "sad", Year = 7, Birthday = new DateTime() };
Person person8 = new Person() { Author = "Author8", Titlee = "sad", Year = 8, Birthday = new DateTime() };

PersonList<Person> per = new PersonList<Person>();
per.AddElement(person5);
per.AddElement(person6);

PersonList<Person> per2 = new PersonList<Person>();
per2.AddElement(person7);
per2.AddElement(person8);

PersonList <Person> PersonList  = new PersonList<Person>();
PersonList.AddElement(person);
PersonList.AddElement(person1);
PersonList.AddElement(person2);
PersonList.AddElement(person3);
PersonList.AddElement(person4);
PersonList.AddList(PersonList);

PersonList.InsertElement(1, person);
PersonList.InsertList(8, per2);

var p = PersonList.GetElement(0,out Person element);
var p1 = PersonList.GetList(0,10,out List<Person> ElementList);

PersonList.RemoveElement(element);

PersonList.RemoveList(ElementList);

Console.WriteLine(PersonList.Count());

PersonList.ClearList();

Console.WriteLine(PersonList.Count());









