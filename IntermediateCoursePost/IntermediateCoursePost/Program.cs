using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace IntermediateCoursePost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var post = new Post("title", "desc");
            post.Action();
        }
    }
}
