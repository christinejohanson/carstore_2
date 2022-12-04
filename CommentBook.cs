using System.Text.Json;

namespace comments
{

    //"managerklass /filen"

    public class CommentBook
    {
        private string filename = @"commentguest.json";
        //private bara i Commentbook
        private List<Comment> comments = new List<Comment>();
        //Commentbook instruerare
        public CommentBook()
        {
            if (File.Exists(@"commentguest.json") == true)
            { // If stored json data exists then read
                string jsonString = File.ReadAllText(filename);
                comments = JsonSerializer.Deserialize<List<Comment>>(jsonString);
            }
        }
        public Comment addComment(Comment comment)
        {
            comments.Add(comment);
            marshal();
            return comment;
        }

        //radera comment. skickar med index.
        public int delCom(int index)
        {
            comments.RemoveAt(index);
            marshal();
            //skriva ut nå felmess??? index behöver inte returneras. 
            return index;
        }

        public List<Comment> getComments()
        {
            return comments;
        }

        //marshal janne
        private void marshal()
        {
            // Serialize all the objects and save to file
            var jsonString = JsonSerializer.Serialize(comments);
            File.WriteAllText(filename, jsonString);
        }
    }

}