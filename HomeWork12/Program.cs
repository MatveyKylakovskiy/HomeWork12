
//using HomeWork12.FirstTask;

//var list = new List<string>() { "a", "a", "b", "b", "d", "f" , "g", "h"};

// WorkerWithLINQ.GetFirstOfString(list);
// var res = WorkerWithLINQ.GetLastContainEE(list);

//var res1 = WorkerWithLINQ.GetLastWord(list, 5, 78);





//var res3 = WorkerWithLINQ.GetNumberOfUnique(list);




//var res3 = WorkerWithLINQ.GetStartWith5EndWith3(list);
//var res = WorkerWithLINQ.GetLengthOfSmall(list);

//Console.WriteLine(string.Join(" ,", res3));


//var d = new Dictionary<int, string>(){
//    { 1, "a"},
//    { 2, "b"},
//    { 3, "c"}
//};


//var res4 = WorkerWithLINQ.ReplaseDictionaryByList(d);

//Console.WriteLine(string.Join(" ,", res4));



//Second Task


using HomeWork12.SecondTask;

User us = new User("Nda", "Xfsdf", "b");
User us1 = new User("Nfg", "Dvcb", "a");
User us2 = new User("Fgga", "Mc");
User us3 = new User("Fgga", "Mb");
User us4 = new User("Fgga", "Mv");
User us5 = new User("Fgga", "Mv");
User us6 = new User("Fgga", "M1");
User us7 = new User("Fgga", "M2");
User us8 = new User("Fgga", "M3");
User us9 = new User("Fgga", "Mfgfg");
User us10 = new User("Fgga", "Mfgfg");


var users = new List<User>()
{
    us, us1, us2, us3, us4, us5, us6, us7, us8, us9, us10
};



/*var result = users.Select(u => u.LastName).ToList();
users.OrderBy(u => u.LastName);
result.Sort();*/

//us.GetFullName(users);

var result = us.SotredUsers(users);

us.GetFullName(result);
/*
foreach (var user in result)
{
    Console.WriteLine(user);
}
Console.WriteLine("  ");
*/