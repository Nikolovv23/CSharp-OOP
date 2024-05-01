namespace AuthorProblem
{
    [Author ("Victor")]
    public class StartUp
    {
        [Author ("Todor")]
        public static void Main()
        {
            new Tracker().PrintMethodsByAuthor();
        }
    
    
        [Author ("Ivan")]
        [Author ("David")]
        public void NewMethod()
        {
    
        }
    }
}
