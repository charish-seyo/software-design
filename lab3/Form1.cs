namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }

            public virtual string GetInfo()
            {
                return $"{Title} by {Author}";
            }
        }

        public class Magazine : Book
        {
            public int IssueNumber { get; set; }

            public override string GetInfo()
            {
                return $"{Title} by {Author} - Issue {IssueNumber}";
            }
        }

        public class Ebook : Book
        {
            public double FileSizeMB { get; set; }

            public override string GetInfo()
            {
                return $"{Title} by {Author} - Ebook Size: {FileSizeMB} MB";
            }
        }

        public class Textbook : Book
        {
            public string Subject { get; set; }

            public override string GetInfo()
            {
                return $"{Title} by {Author} - Subject: {Subject}";
            }
        }

        public class AudioBook : Book
        {
            public double Duration { get; set; }
            public string Narrator { get; set; }

            public override string GetInfo()
            {
                return $"{Title} by {Author} - Duration: {Duration} hours, Narrator: {Narrator}";
            }
        }

        public void DisplayBooks(Book[] books)
        {
            lstBookInfo.Items.Clear();

            foreach (Book book in books)
            {
                lstBookInfo.Items.Add(book.GetInfo());
            }
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            Book[] books = new Book[]
            {
                new Book
                {
                    Title = "Introduction to Programming",
                    Author = "Robert Smith"
                },

                new Magazine
                {
                    Title = "National Geographic",
                    Author = "John Doe",
                    IssueNumber = 45
                },

                new Ebook
                {
                    Title = "C# Basics",
                    Author = "Maria Santos",
                    FileSizeMB = 3.5
                },

                new Textbook
                {
                    Title = "Object-Oriented Programming",
                    Author = "Anna Reyes",
                    Subject = "Computer Programming"
                },

                new AudioBook
                {
                    Title = "Learning C#",
                    Author = "Mark Johnson",
                    Duration = 5.5,
                    Narrator = "David Lee"
                }
            };

            DisplayBooks(books);
        }
    }
}