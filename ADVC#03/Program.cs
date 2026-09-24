namespace ADVC_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //List<int> grades = new()
            //{
            //    85,92,78,95,88,70,100,65
            //};
            //Console.WriteLine("\n======== Print all ========\n");
            //Console.WriteLine(string.Join(",",grades));
            //Console.WriteLine("\n======== Count ========\n");
            //Console.WriteLine(grades.Count());
            //Console.WriteLine("\n======== Sprted list ========\n");
            //grades.Sort();
            //Console.WriteLine(string.Join(",",grades));
            //Console.WriteLine("\n======== Above 90 ========\n");
            //int above90 = grades.Find(x => x > 90);
            //Console.WriteLine(above90);
            //Console.WriteLine("\n======== Failing grades ========\n");
            //List<int> FailingGrades = grades.FindAll(x => x < 75);
            //Console.WriteLine(string.Join(",",FailingGrades));
            //Console.WriteLine("\n======== After removed all below 75 ========\n");
            //grades.RemoveAll(x => x < 75);
            //Console.WriteLine(string.Join(",", grades));
            //Console.WriteLine("\n======== Checking ========\n");
            //Console.WriteLine(grades.Contains(100) ? $"Found it in index : {grades.IndexOf(100)}" : "not found");
            //Console.WriteLine("\n======== Convert to atring ========\n");
            //List<string> stringList = new();
            //foreach(var i in grades)
            //{
            //    stringList.Add($"Grade: {i}");
            //}
            //Console.WriteLine(string.Join("\n" , stringList)); 
            #endregion

            #region Q2
            //SortedDictionary<int, string> Leaderboard = new()
            //{
            //    {500 ,"Ahmed" },
            //    {200 ,"Sara" },
            //    {800 ,"Ali" },
            //    {350 ,"Mona" }


            //};
            //Console.WriteLine("\n======== All entries ========\n");
            //foreach (var i in Leaderboard)
            //{
            //    Console.WriteLine($"{i.Key}: {i.Value}\n");
            //}
            //Console.WriteLine("\n======== First K&V ========\n");
            //foreach (var i in Leaderboard)
            //{
            //    Console.WriteLine($"First key is : {i.Key}");
            //    Console.WriteLine($"First value is : {i.Value}");
            //    break;
            //}
            //Console.WriteLine("\n======== Chek for score 500 ========\n");
            //Console.WriteLine(Leaderboard.ContainsKey(500) ? $"Found his name is : {Leaderboard[500]}" : "not found");
            //Console.WriteLine("\n======== Safely Find ========\n");
            //Console.WriteLine(Leaderboard.TryGetValue(999, out string? value)?$"founf his name is: {value}":"no data");
            //Console.WriteLine("\n======== After remove player ========\n");
            //Leaderboard.Remove(200);
            //foreach (var i in Leaderboard)
            //{
            //    Console.WriteLine($"{i.Key}: {i.Value}\n");
            //} 
            #endregion



        }
    }
}
