namespace WebApplication1.Dto
{
    public class StudentGet
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public StudentGet(int Id, string Name) {
           this.Id = Id;
            this.Name = Name;
        }
    }
}
