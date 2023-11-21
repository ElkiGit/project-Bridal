namespace BridalSalon.Entities
{
    public enum Experience { beginner=1,middel ,expert }
    public class Dressmaker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Experience experience { get; set; }
        public int Status { get; set; }
    }
}
