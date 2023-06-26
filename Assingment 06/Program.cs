using Task;

Person[] personArray = new Person[3];

Home firstHome = new Home("Belgrade", "Address1");
Person firstPerson = new Person("Novak", 36, "131415", firstHome);
personArray[0] = firstPerson;

Home secondHome = new Home("Tbilisi", "Address2");
Person secondPerson = new Person("Khvicha", 22, "123456", secondHome);
personArray[1] = secondPerson;

Home thirdHome = new Home("Argentina", "Address2");
Person thirdPerson = new Person("Lionel", 36, "101112", thirdHome);
personArray[2] = thirdPerson;
