namespace LungDiseaseDiagnosis.Models;

public class Diagnosis
{
    public int ID { get; set; }
    public string? Result { get; set; }
    public double ConfidenceScore { get; set; }
    public string? image { get; set; }
}
