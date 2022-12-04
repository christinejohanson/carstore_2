using System;

namespace comments
{
    public class Comment
    {
        //private nås bara i Car
        public string comment_no;
        private string author;
        //typ samma namn för att se så de hör ihop
        //comment_no blir en metod pga set och get
        public string Comment_no
        {
            set { this.comment_no = value; }
            get { return this.comment_no; }
        }
        public string Author
        {
            set { this.author = value; }
            get { return this.author; }
        }
    }

}