using Task;


Person[] personArray = new Person[3];

Home firstHome = new Home("Belgrade", "Address1");
Home secondHome = new Home("Tbilisi", "Address2");
Home thirdHome = new Home("Argentina", "Address2");

Person firstPerson = new Person("Novak", 36, "131415", firstHome);
Person secondPerson = new Person("Khvicha", 22, "123456", secondHome);
Person thirdPerson = new Person("Lionel", 36, "101112", thirdHome);

personArray[0] = firstPerson;
personArray[1] = secondPerson;
personArray[2] = thirdPerson;