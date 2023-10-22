using WebApplication1.Dto;

namespace WebApplication1.Data
{
    public static class StudentData
    {
        public static List<StudentGet> StudentList = new List<StudentGet>
        {
            new StudentGet(1,"Dinesh"),
            new StudentGet(2,"Samu")
        };
    }
}
