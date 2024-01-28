namespace phrase_web.Models
{
    public class SearchResult
    {   
        public  Guid Id { get;}
        public string Result { get; set; }

        public SearchResult(string result)
        {
            Result = result;
            Id = Guid.NewGuid();
        }
    }
}
