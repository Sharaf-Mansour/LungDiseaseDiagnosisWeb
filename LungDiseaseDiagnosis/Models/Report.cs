namespace LungDiseaseDiagnosis.Models;

public class Report
{
    public int ID { get; set; }
    public int UploaderID { get; set; }
    public int ApprovalID { get; set; }
    public int ApprovalStatus { get; set; }
    public int DiagnosisID { get; set; }
    public string? GeneralNote { get; set; }
}
