using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DcmIncognito
{
    internal static class Randomizer
    {
        private static readonly string poolId = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
        private static readonly string[] poolLastNames = new string[] { "Smith", "Johnson", "Williams", "Jones", "Brown", "Davis", "Miller", "Wilson", "Moore", "Taylor", "Anderson", "Thomas", "Jackson", "White", "Harris", "Martin", "Thompson", "Garcia", "Martinez", "Robinson", "Clark", "Rodriguez", "Lewis", "Lee", "Walker", "Hall", "Allen", "Young", "Hernandez", "King", "Wright", "Lopez", "Hill", "Scott", "Green", "Adams", "Baker", "Gonzalez", "Nelson", "Carter", "Mitchell", "Perez", "Roberts", "Turner", "Phillips", "Campbell", "Parker", "Evans", "Edwards", "Collins", "Stewart", "Sanchez", "Morris", "Rogers", "Reed", "Cook", "Morgan", "Bell", "Murphy", "Bailey", "Rivera", "Cooper", "Richardson", "Cox", "Howard", "Ward", "Torres", "Peterson", "Gray", "Ramirez", "James", "Watson", "Brooks", "Kelly", "Sanders", "Price", "Bennett", "Wood", "Barnes", "Ross", "Henderson", "Coleman", "Jenkins", "Perry", "Powell", "Long", "Patterson", "Hughes", "Flores", "Washington", "Butler", "Simmons", "Foster", "Gonzales", "Bryant", "Alexander", "Russell", "Griffin", "Diaz", "Hayes" };
        private static readonly string[] poolFirstNamesMale = new string[] { "Aiden", "Jackson", "Mason", "Liam", "Jacob", "Jayden", "Ethan", "Noah", "Lucas", "Logan", "Caleb", "Caden", "Jack", "Ryan", "Connor", "Michael", "Elijah", "Brayden", "Benjamin", "Nicholas", "Alexander", "William", "Matthew", "James", "Landon", "Nathan", "Dylan", "Evan", "Luke", "Andrew", "Gabriel", "Gavin", "Joshua", "Owen", "Daniel", "Carter", "Tyler", "Cameron", "Christian", "Wyatt", "Henry", "Eli", "Joseph", "Max", "Isaac", "Samuel", "Anthony", "Grayson", "Zachary", "David", "Christopher", "John", "Isaiah", "Levi", "Jonathan", "Oliver", "Chase", "Cooper", "Tristan", "Colton", "Austin", "Colin", "Charlie", "Dominic", "Parker", "Hunter", "Thomas", "Alex", "Ian", "Jordan", "Cole", "Julian", "Aaron", "Carson", "Miles", "Blake", "Brody", "Adam", "Sebastian", "Adrian", "Nolan", "Sean", "Riley", "Bentley", "Xavier", "Hayden", "Jeremiah", "Jason", "Jake", "Asher", "Micah", "Jace", "Brandon", "Josiah", "Hudson", "Nathaniel", "Bryson", "Ryder", "Justin", "Bryce" };
        private static readonly string[] poolLirstNamesFemale = new string[] { "Sophia", "Emma", "Isabella", "Olivia", "Ava", "Lily", "Chloe", "Madison", "Emily", "Abigail", "Addison", "Mia", "Madelyn", "Ella", "Hailey", "Kaylee", "Avery", "Kaitlyn", "Riley", "Aubrey", "Brooklyn", "Peyton", "Layla", "Hannah", "Charlotte", "Bella", "Natalie", "Sarah", "Grace", "Amelia", "Kylie", "Arianna", "Anna", "Elizabeth", "Sophie", "Claire", "Lila", "Aaliyah", "Gabriella", "Elise", "Lillian", "Samantha", "Makayla", "Audrey", "Alyssa", "Ellie", "Alexis", "Isabelle", "Savannah", "Evelyn", "Leah", "Keira", "Allison", "Maya", "Lucy", "Sydney", "Taylor", "Molly", "Lauren", "Harper", "Scarlett", "Brianna", "Victoria", "Liliana", "Aria", "Kayla", "Annabelle", "Gianna", "Kennedy", "Stella", "Reagan", "Julia", "Bailey", "Alexandra", "Jordyn", "Nora", "Carolin", "Mackenzie", "Jasmine", "Jocelyn", "Kendall", "Morgan", "Nevaeh", "Maria", "Eva", "Juliana", "Abby", "Alexa", "Summer", "Brooke", "Penelope", "Violet", "Kate", "Hadley", "Ashlyn", "Sadie", "Paige", "Katherine", "Sienna", "Piper" };

        private static readonly Dictionary<string, (string id, string firstName, string lastName)> mapping = new Dictionary<string, (string, string, string)>(StringComparer.OrdinalIgnoreCase);
        private static readonly Random random = new Random();

        public static (string id, string firstName, string lastName) Get(string id, int length = 10)
        {
            if (mapping.ContainsKey(id))
                return mapping[id];

            string newId = string.Empty;
            while (newId.Length == 0 || mapping.Any(x=>x.Value.id.Equals(newId, StringComparison.OrdinalIgnoreCase)))
                newId = "Anon" + new string(Enumerable.Range(0, length).Select(x => poolId[random.Next(0, poolId.Length)]).ToArray());
            (string id, string firstName, string lastName) randomData = (newId, FirstName(), LastName());
            mapping.Add(id, randomData);

            return randomData;
        }

        private static string LastName()
        {
            return poolLastNames[random.Next(poolLastNames.Length)];
        }

        private static string FirstName(bool male = true, bool female = true)
        {
            if (!male && !female)
                return string.Empty;
            else if(!female)
                return poolFirstNamesMale[random.Next(poolFirstNamesMale.Length)];
            else if(!male)
                return poolLirstNamesFemale[random.Next(poolLirstNamesFemale.Length)]; 
            else if (random.Next(1) == 0)
                return poolFirstNamesMale[random.Next(poolFirstNamesMale.Length)];
            else
                return poolLirstNamesFemale[random.Next(poolLirstNamesFemale.Length)];
        }
    }
}
