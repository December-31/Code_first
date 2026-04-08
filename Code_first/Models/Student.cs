namespace Code_first.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ClassroomId { get; set; } 
        public virtual Classroom Classroom { get; set; }
    }
}
