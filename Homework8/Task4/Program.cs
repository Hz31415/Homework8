using System.Xml.Serialization;
using Task4;

Person Person = new Person();

Person.name = "Hafiz";

Person.Address = new PersonAddress();
Person.Address.Street = "Test";
Person.Address.HouseNumber = "sdfa";
Person.Address.FlatNumber = "asdfasdfas";

Person.Phones = new PersonPhones();
Person.Phones.MobilePhone = 78798798798;
Person.Phones.FlatPhone = "8789/79879";


XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));

Stream fstream = new FileStream(@"new_xml.doc", FileMode.Create, FileAccess.Write);

xmlSerializer.Serialize(fstream, Person);

fstream.Close();



