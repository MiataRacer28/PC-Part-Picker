using System;
using System.Net.Sockets;
using System.Runtime.InteropServices;

/// <summary>
/// Motherboard object for parts database
/// </summary>
public class Motherboard : Component
{
	//Fields
	public string FormFactor { get; set; }	
	public string Socket {  get; set; }	
	public string Chipset { get; set; }	
	public string MemoryType { get; set; }
	public int MaximumMemory { get; set; }
	public int MaximumMemorySpeed { get; set; }
	public int NumberOfPCIeSlots { get; set; }
	public string MaxPCIeSlotType { get; set; }
	public string PCIeVer { get; set; }


	public Motherboard(string name, string manufacturer, int performanceScore, string formFactor, string socket, string chipset, string memoryType, int maximumMemory, int maximumMemorySpeed, int numberOfPCIeSlots, string maxPCIeSlotType, string pcieVer) : base(name, manufacturer, performanceScore)
	{
		this.FormFactor = formFactor;
		this.Socket = socket;
		this.Chipset = chipset;
		this.MemoryType = memoryType;
		this.MaximumMemory = maximumMemory;
		this.MaximumMemorySpeed = maximumMemorySpeed;
		this.NumberOfPCIeSlots = numberOfPCIeSlots;
		this.MaxPCIeSlotType = maxPCIeSlotType;
		this.PCIeVer = pcieVer;

	}

    public override string[] ToStringArray()
    {
        return new string[]
        {
            "Motherboard",
            this.Name,
            this.Manufacturer,
            this.PerformanceScore.ToString(),
			this.FormFactor,
			this.Socket,
			this.Chipset,
			this.MemoryType,
			this.MaximumMemory.ToString(),
			this.MaximumMemorySpeed.ToString(),
			this.NumberOfPCIeSlots.ToString(),
			this.MaxPCIeSlotType,
			this.PCIeVer
    };
    }
}
