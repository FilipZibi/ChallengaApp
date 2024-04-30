using Console123;
User user1 = new User("Adam", "Mleko", "33");
User user2 = new User("Monika", "Maslo", "35");
User user3 = new User("Zuzia", "Dzem", "37");


user1.AddScore(5);
user1.AddScore(2);
user1.AddScore(3);
user1.AddScore(4);
user1.AddScore(6);

user2.AddScore(1);
user2.AddScore(2);
user2.AddScore(3);
user2.AddScore(4);
user2.AddScore(5);

user3.AddScore(10);
user3.AddScore(9);
user3.AddScore(8);
user3.AddScore(7);
user3.AddScore(6);


List<User> users = new List<User>()
{
    user1, user2, user3,
};

int maxResult = -1;
User userWithMaxResult = null;
var result = user1.Result;


foreach (var user in users)
{
    if (user.Result > maxResult)
    {
        userWithMaxResult = user;

    }

}

Console.WriteLine("Najlepszy pracownik to");
Console.WriteLine(userWithMaxResult.Name);
Console.WriteLine(userWithMaxResult.Surname);
Console.WriteLine("z rezultatem");
Console.WriteLine(userWithMaxResult.Result);
