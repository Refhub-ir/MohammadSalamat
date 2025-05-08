namespace RefhubMVC.Models.Entities
{
    public class BookRelation
    {
        public int BookId { get; set; } // کتاب اصلی
        public Book Book { get; set; }
        public int RelatedBookId { get; set; } // کتاب مرتبط
        public Book RelatedBook { get; set; }
    }
}
