using System;
using System.Collections.Generic;

namespace IntermediateCoursePost
{
    public class Post
    {
        private string _title;
        private string _description;
        private readonly int _votes;
        private int _count;
        private int _id;
        private DateTime _dateCreated;
        private List<List<string>> _posts = new List<List<string>>();


        public Post(string title, string description)
        {
            if (String.IsNullOrWhiteSpace(title) || String.IsNullOrWhiteSpace(description))
            {
                throw new ArgumentNullException("The title or description cannot be empty");
            }

            _title = title.Trim();
            _description = description.Trim();

            CreatePost();
        }

        public void CreatePost()
        {
            _count++;
            _id = _count;

            if (_count > 1)
            {
                Console.WriteLine("Enter title");
                _title = Console.ReadLine().Trim();

                Console.WriteLine("Enter description");
                _description = Console.ReadLine().Trim();
            }

            _dateCreated = DateTime.Now;

            List<string> _postsInfo = new()
            {
                _title,
                _description,
                _dateCreated.ToString(),
                _id.ToString(),
                _votes.ToString()
            };

            _posts.Add(_postsInfo);
        }


        public void Display(int id)
        {
            _id = id;

            Console.WriteLine("Title: " + _posts[id - 1][0]);
            Console.WriteLine("Description: " + _posts[id - 1][1]);
            Console.WriteLine("Date: " + _posts[id - 1][2]);
            Console.WriteLine("Id: " + _posts[id - 1][3]);
            Console.WriteLine("Votes: " + _posts[id - 1][4]);
        }

        public void Action()
        {
            Display(_id);
            while (true)
            {
                Console.WriteLine("Type 'U' to upvote post, 'D' do downvote post, 'N' to create a new post, 'C' to change the post that is displayed or 'Q' to quit");
                var input = Console.ReadLine().ToUpper();

                int vote = Convert.ToInt32(_posts[_id - 1][4]);
                if (input == "U")
                {
                    vote++;
                    _posts[_id - 1][4] = vote.ToString();
                }
                else if (input == "D")
                {
                    vote--;
                    _posts[_id - 1][4] = vote.ToString();
                }
                else if (input == "Q")
                {
                    return;
                }
                else if (input == "N")
                {
                    CreatePost();
                    Console.Clear();
                    Display(_id);
                    continue;
                }
                else if (input == "C")
                {
                    Console.WriteLine("What is the ID of the post you want to display? Choose a number between 1 and " + _posts.Count);
                    var postId = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Display(postId);
                    continue;


                }

                Console.Clear();

                Display(_id);
            }

        }

    }
}
