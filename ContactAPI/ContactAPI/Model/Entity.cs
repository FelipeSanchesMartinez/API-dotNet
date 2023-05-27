namespace ContactAPI.Model
{
    public abstract class Entity
    {
        public long Id { get; set; }
        public DateTime CreatAt { get; set; }
        public DateTime UpdatedAt { get; set; } 
        public bool Deleted { get; set; }
    }
}
