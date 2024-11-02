namespace PB401_PurpleBuzz.Entities
{
    public class Work : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string PhotoPath { get; set; }
        public WorkCategory WorkCategory { get; set; }
        public int WorkCategoryId { get; set; }
    }
}
