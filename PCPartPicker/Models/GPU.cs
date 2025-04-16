using System;
using System.Runtime.InteropServices;

/// <summary>
/// GPU object for parts database
/// </summary>
public class GPU : Component
{
    //Fields
    public int CoreCount {  get; set; } 
    public int BaseClock {  get; set; } 
    public int MaxClock { get; set; }   
    public string Architecture { get; set; } 
    public int VRAM { get; set; }   
    public string MemType { get; set; }
    public int MaximumTDP { get; set; }
    public bool RayTracing { get; set; }
    public string RecentGraphicsAPI { get; set; }



	public GPU(string name, string manufacturer, int performanceScore, int coreCount, int baseClock, int maxClock, string architecture, int VRAM, string memType, int maximumTDP, bool rayTracing, string recentGraphicsAPI) : base(name, manufacturer, performanceScore)
    {
        this.CoreCount = coreCount;
        this.BaseClock = baseClock;
        this.MaxClock = maxClock;
        this.Architecture = architecture;
        this.VRAM = VRAM;   
        this.MemType = memType;
        this.MaximumTDP = maximumTDP;
        this.RayTracing = rayTracing;
        this.RecentGraphicsAPI = recentGraphicsAPI;


    }

    public override string[] ToStringArray()
    {
        return new string[]
        {
            "GPU",
            this.Name,
            this.Manufacturer,
            this.PerformanceScore.ToString(),
            this.CoreCount.ToString(),
            this.BaseClock.ToString(),
            this.MaxClock.ToString(),
            this.Architecture,
            this.VRAM.ToString(),
            this.MemType,
            this.MaximumTDP.ToString(),
            this.RayTracing.ToString(),
            this.RecentGraphicsAPI
        };
    }

    public override string ToString()
    {
        return $"{Name} ({Manufacturer}, {VRAM}GB VRAM)";
    }
}
