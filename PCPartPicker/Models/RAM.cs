using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class RAM : Component //Ram extending Component class
{
	//fields
	public int Capacity { get; set; }
	public string MemoryType { get; set; }
	public int MemoryFrequency { get; set; }
	public string Latency { get; set; }
	public string Voltage { get; set; }
	public bool ErrorCorrecting { get; set; }

	public RAM(string name, string manufacturer, int performanceScore, int capacity, string memoryType, int memoryFrequency, string latency, string voltage, bool errorCorrecting) : base(name, manufacturer, performanceScore)
    {
		this.Capacity = capacity;
		this.MemoryType = memoryType;
		this.MemoryFrequency = memoryFrequency;
		this.Latency = latency;
		this.Voltage = voltage;
		this.ErrorCorrecting = errorCorrecting;

	}

    public override string[] ToStringArray() //Change behavior of the toStringArray to allow for easier file writing
    {
        return new string[]
        {
            "RAM",
            this.Name,
            this.Manufacturer,
            this.PerformanceScore.ToString(),
            this.Capacity.ToString(),
            this.MemoryType,
            this.MemoryFrequency.ToString(),
            this.Latency,
            this.Voltage,
            this.ErrorCorrecting.ToString(),
    };
    }

    public override string ToString() //Change ToString behavior to list name, manufacturer, and capacity
    {
        return $"{Name} ({Manufacturer}, {Capacity} GB)";
    }
}
