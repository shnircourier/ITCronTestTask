namespace ITCronTestTask.Data.Entities;

public class IpInfoHistory
{
    public string Ip { get; set; } = string.Empty;

    public string? Hostname { get; set; }

    public string City { get; set; } = string.Empty;

    public string Region { get; set; } = string.Empty;

    public string Country { get; set; } = string.Empty;

    public string Loc { get; set; } = string.Empty;

    public string Org { get; set; } = string.Empty;

    public string? Postal { get; set; }

    public string Timezone { get; set; } = string.Empty;

    public string Readme { get; set; } = string.Empty;
}