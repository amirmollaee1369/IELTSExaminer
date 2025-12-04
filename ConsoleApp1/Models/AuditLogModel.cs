namespace ConsoleApp1.Models
{
    public abstract class AuditLogModel
    {
        public int UserID { get; set; }
        public DateTime CreateDate { get; set; }
        public int ModifierID { get; set; }
        public DateTime ModifyDate { get; set; }
    }
}
