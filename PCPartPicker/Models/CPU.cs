using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Web;

/// <summary>
/// CPU object for parts database
/// </summary>
public class CPU : Component
{
	//Fields
    public int CoreCount { get; set; }
    public double ClockFrequency { get; set; }
    public int MaximumTDP { get; set; }
    public string Architecture { get; set; }
	public bool IntegratedGraphics {  get; set; }
	public string Socket { get; set; }


	//Constructor
    public CPU(string name, string manufacturer, int performanceScore, int coreCount, double clockFrequency, int maximumTDP, string architecture, bool integratedGraphics, string socket) 
	: base(name, manufacturer, performanceScore)
	{
		this.CoreCount = coreCount;
		this.ClockFrequency = clockFrequency;
		this.MaximumTDP = maximumTDP;
		this.Architecture = architecture;
		this.IntegratedGraphics = integratedGraphics;
		this.Socket = socket;

	}

	public override string[] ToStringArray()
	{
		return new string[]
		{
			"CPU",
			this.Name,
			this.Manufacturer,
			this.PerformanceScore.ToString(),
			this.CoreCount.ToString(),
			this.ClockFrequency.ToString(),
			this.MaximumTDP.ToString(),
			this.Architecture,
			this.IntegratedGraphics.ToString(),
			this.Socket

		};
	}
}
