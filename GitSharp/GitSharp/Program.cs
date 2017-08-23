using System;

using LibGit2Sharp;

namespace GitSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var repoPath = "";
            using (var repo = new Repository(repoPath))
            {
                Console.WriteLine("Hello git");
            }
        }
    }
}
