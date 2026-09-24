using System.Text;

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

            #region Q3

            //Dictionary<string, string> phoneBook = new()
            //{
            //    {"01012879474" , "Ahmed" },
            //    {"01012876574" , "Ali" },
            //    {"01012854874" , "Sara" },
            //    {"01012874674" , "Mohamed" }

            //};
            //phoneBook["01012879474"] = "thtoh";
            //Console.WriteLine("\n======== Exiption ========\n");

            //try
            //{ 
            //    phoneBook.Add("01012876574", "Ali");
            //}
            //catch(ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.WriteLine("\n======== Try add ========\n");
            //bool add = phoneBook.TryAdd("01012876574", "Ali");
            //Console.WriteLine(add);
            //Console.WriteLine("\n======== Exists ========\n");
            //bool exit = phoneBook.ContainsValue("Mariam");
            //Console.WriteLine(exit);
            //Console.WriteLine("\n======== All keys ========\n");
            //foreach (var i in phoneBook)
            //{
            //    Console.Write($"{i.Key},");
            //}
            //Console.WriteLine("\n");
            //Console.WriteLine("\n======== All values ========\n");
            //foreach (var i in phoneBook)
            //{
            //    Console.Write($"{i.Value},");
            //}
            //Console.WriteLine("\n"); 
            #endregion

            #region Q4
            //HashSet<string> EmailValidator = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            //{
            //  "ahmed@test.com",
            //  "AHMED@test.com",
            //  "sara@test.com",
            //  "Sara@Test.Com"
            //};
            //Console.WriteLine("\n======== Count ========\n");
            //Console.WriteLine(EmailValidator.Count());//2 because hash set remove any dublicated data
            //Console.WriteLine("\n======== UnionWith to Copy from SetA ========\n");
            //HashSet<int> setA = new() { 1, 2, 3, 4, 5 };
            //HashSet<int> setB = new() { 4,5,6,7,8 };
            //HashSet<int> copy = new(setA);
            //copy.UnionWith(setB);
            //foreach (var i in copy)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("\n======== IntersectWith to SetA ========\n");
            //setA.IntersectWith(setB);
            //foreach (var i in setA)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("\n======== ExceptWith to SetB ========\n");
            //setB.ExceptWith(setA);
            //foreach (var i in setB)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("\n======== IsSubSet ========\n");
            //bool IsSubSet = setA.IsSubsetOf(new int[] { 1, 2 });
            //Console.WriteLine(IsSubSet);

            #endregion

            #region Q5
            //Queue<string> Documents = new();
            //Documents.Enqueue("Report.pdf");
            //Documents.Enqueue("Invoice.pdf");
            //Documents.Enqueue("Letter.docx");
            //Documents.Enqueue("Resume.pdf");
            //Documents.Enqueue("Photo.jpg");
            //Console.WriteLine("\n======== Print all ========\n");
            //Console.WriteLine(string.Join(" , ", Documents));
            //Console.WriteLine("\n======== Count ========\n");
            //Console.WriteLine(Documents.Count());
            //Console.WriteLine("\n======== Peak ========\n");
            //var Peak = Documents.Peek();
            //Console.WriteLine(Peak);
            //Console.WriteLine("\n======== Dequeue ========\n");
            //string? Box;
            //do
            //{
            //    Box = Documents.Dequeue();
            //    Console.WriteLine(Box);

            //} while (0 < Documents.Count());
            //Console.WriteLine("\n======== TryDequeue ========\n");
            //Documents.TryDequeue(out string? value);//nothing will happened because tryDocument handel if it can't remove it will return false 
            #endregion



        }
    }
}
