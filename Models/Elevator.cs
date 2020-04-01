public class Elevator
{
    public long id { get; set; }
    public long serial_number { get; set; }
    public string model { get; set; }
    public string elevator_type { get; set; }
    public string status { get; set; }
    public string date_commision { get; set; }
    public string date_last_inspect { get; set; }
    public string certificate_inspect { get; set; }
    public string info { get; set; }
    public string notes { get; set; }
    public string created_at { get; set; }
    public string updated_at { get; set; }
    public Column column { get; set; }
}