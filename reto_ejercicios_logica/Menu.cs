namespace csharp{

    public static class Menu{
        public static string MostrarMenu(){
            Console.WriteLine(@"1. 
2. 
3. 
4. 
5. 
6. 
7. 
8. 
9. 
10. 
11. 
12. 
13. 
14. 
15.");
    string op = Console.ReadLine();
    return op;
        }
    }
}
