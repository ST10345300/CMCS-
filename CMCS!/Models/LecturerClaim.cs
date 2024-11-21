namespace CMCS_.Models;
public class LecturerClaim
{
    public int Id { get; set; }
    public string? LecturerName { get; set; }
    public int HoursWorked { get; set; }
    public decimal HourlyRate { get; set; }
    public decimal FinalPayment { get; set; }
    public string Status { get; set; } = "Pending";
}
