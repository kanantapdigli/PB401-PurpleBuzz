namespace PB401_PurpleBuzz.Entities
{
    public class WorkCategory : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Work> Works { get; set; }
    }
}
