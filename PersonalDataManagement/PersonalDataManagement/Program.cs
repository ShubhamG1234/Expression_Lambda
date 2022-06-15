namespace PersonDataManagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Person> listOfPerson = new List<Person>();

            AddRecords(listOfPerson);
            Retrieving_TopTwoRecords_ForAgeIs_LessThanSixty(listOfPerson);
        }
        private static void AddRecords(List<Person> listPersons)
        {
            listPersons.Add(new Person("9454545454", "John", "12 Main Street, Newyork", 15));
            listPersons.Add(new Person("9454545444", "Sam", "12 Main Street, Newyork", 25));
            listPersons.Add(new Person("9454544554", "Elan", "12 Main Street, Newyork", 35));
            listPersons.Add(new Person("9454255454", "Smith", "12 Main Street, Newyork", 45));
            listPersons.Add(new Person("57254545454", "Joe", "12 Main Street, Newyork", 55));
            listPersons.Add(new Person("5514545454", "Sun", "12 Main Street, Newyork", 15));
            listPersons.Add(new Person("1154545454", "Winstonn", "12 Main Street, Newyork", 15));
            listPersons.Add(new Person("1154545454", "Mac", "12 Main Street, Newyork", 15));
            listPersons.Add(new Person("8454545454", "Jen", "12 Main Street, Newyork", 15));
            listPersons.Add(new Person("6454545454", "rita", "12 Main Street, Newyork", 15));
        }
        private static void Retrieving_TopTwoRecords_ForAgeIs_LessThanSixty(List<Person> listPerson)
        {
            foreach (Person person in listPerson.FindAll(e => (e.Age < 60)).Take(2).ToList())
            {
                Console.WriteLine("Name : " + person.Name + "Age : " + person.Age);

            }
        }
        private static void Retrieving_RecordAgeBetween13And18(List<Person> listPerson)
        {
            foreach (Person person in listPerson) ;
        }
    }
}