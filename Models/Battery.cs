using System;

public class Battery
{
    public long id { get; set; }
    public string battery_type { get; set; }
    public string status { get; set; }
    public DateTime date_commision { get; set; }
    public DateTime date_last_inspect { get; set; }
    public string certificate_operations { get; set; }
    public string info { get; set; }
    public string notes { get; set; }
    public int building_id { get; set; }
    public int employee_id { get; set; }
}
