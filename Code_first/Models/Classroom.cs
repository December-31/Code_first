namespace Code_first.Models
{
    public class Classroom
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
        public virtual ICollection<Student> Students { get; set; } 
    }
}
