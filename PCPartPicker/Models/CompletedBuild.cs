using System;

/// <summary>
/// Refers to selected parts forming a PC created by a user
/// Will be used to generate performance scores, and to save builds to a list
/// </summary>
public class CompletedBuild
{
    public CPU Cpu { get; set; } = null;
    public GPU Gpu { get; set; } = null;
	public RAM Ram { get; set; } = null;
	public Motherboard Mobo { get; set; }  = null;


    public CompletedBuild(CPU Cpu, GPU Gpu, RAM Ram, Motherboard Mobo)
	{
		this.Cpu = Cpu;
		this.Gpu = Gpu;
		this.Ram = Ram;
		this.Mobo = Mobo;
	}

	
	public string generateBuildSummary() 
	{

        String CpuSum;
        String GpuSum;
        String RamSum;
        String MoboSum;
        String MainSum;
        String GeneralBuild;


        int CpuPerformanceScore = this.Cpu.PerformanceScore;
        int GpuPerformanceScore = this.Gpu.PerformanceScore;
        int RamPerformanceScore = this.Ram.PerformanceScore;
        int MotherboardPerformanceScore = Mobo.PerformanceScore;

		string CpuName = this.Cpu.Name;
        string GpuName = this.Gpu.Name;
        string RamName = this.Ram.Name;
        string MotherboardName = this.Mobo.Name;

        double MainPerformanceScore = this.avgPerformance();

        if (MainPerformanceScore >= 7)
        {
            GeneralBuild = "Overall, this system will have excellent performance across a wide range of applications";
        }
        else if (MainPerformanceScore > 5 && MainPerformanceScore < 7)
        {
            GeneralBuild = "Overall, this system will have solid performance across a multitude of applications, though it may fall short on some more professional or \'prosumer\' workloads";
        }
        else
        {
            GeneralBuild = "Overall, this system will not be able to handle many modern day tasks. However, depending on power constraints, this system may be able to serve as a home media system or a very small server of sorts";
        }

        //CPU Performance Logic
        CpuSum = this.CpuSummary(this.Cpu);

        //GPU Performance Logic
        GpuSum = this.GpuSummary(this.Gpu);

        //RAM Performance Logic
        RamSum = this.RamSummary(this.Ram);

        //Motherboard Performance Logic
        MoboSum = this.MoboSummary(this.Mobo);

        //General Summary
        MainSum = CpuSum + "\n" + GpuSum + "\n" + RamSum + "\n" + MoboSum + "\n" + "\n" + GeneralBuild;
        return MainSum;

    }
	

    //Helper Methods
	public double avgPerformance() //Return an integer value signaling build performance.
	{
        double CpuPerformanceScore = this.Cpu.PerformanceScore;
        double GpuPerformanceScore = this.Gpu.PerformanceScore;
        double RamPerformanceScore = this.Ram.PerformanceScore;
        double MotherboardPerformanceScore = Mobo.PerformanceScore;

		return (CpuPerformanceScore + GpuPerformanceScore + RamPerformanceScore + MotherboardPerformanceScore) / 4;


    }

    public String CpuSummary(CPU Cpu)
    {
        String CpuSummary;
        if (Cpu.PerformanceScore >= 7)
        {
            CpuSummary = "The " + Cpu.Name + " with a performance score greater than 7, is indicated to have " +
                "excellent performance across a multitide of application types. It should excell in both Heavy workloads as well as gaming.";
        }
        else if (Cpu.PerformanceScore > 5 && Cpu.PerformanceScore < 7)
        {
            CpuSummary = "The " + Cpu.Name + " with a performance score of " + this.Cpu.PerformanceScore + " is indicated to have solid performance across various computing applications. While not top of the line, the " + this.Cpu.Name + " can still be a solid choice for those on a budget";
        }
        else
        {
            CpuSummary = "The " + Cpu.Name + "has a rather low performance score and will only really be capable of basic tasks such as web browsing or older gaming titles. ";
        }

        return CpuSummary;
    } //CPU Summary

    public String GpuSummary(GPU Gpu)
    {
        String GpuSummary;
        if (Gpu.PerformanceScore >= 7)
        {
            GpuSummary = "The " + Gpu.Name + " is a real beast of a GPU, and should be suitable for almost any consumer task, and even some professional use cases such as artificial intelligence";
        }
        else if (Gpu.PerformanceScore > 5 && Gpu.PerformanceScore < 7)
        {
            GpuSummary = "The " + Gpu.Name + " is a solid choice for those who want get into PC gaming without breaking the bank on a multi-thousand dollar GPU.";
        }
        else
        {
            GpuSummary = "The " + Gpu.Name + "has rather low performance and will most likely not be suitable for modern titles or workloads.";
        }

        return GpuSummary;
    } //Gpu Summary

    public String RamSummary(RAM Ram)
    {
        String RamSummary;
        if (Ram.PerformanceScore >= 7)
        {
            RamSummary = "The " + Ram.Name + "is a suitable unit for heavy and intensive professional workloads such as VM clusters, game servers, etc";
        }
        else if (Ram.PerformanceScore > 5 && Ram.PerformanceScore < 7)
        {
            RamSummary = "The " + Ram.Name + " is a solid choice for gamers and enthusiasts on a budget";
        }
        else
        {
            RamSummary = "The " + Ram.Name + "will most likely not be suitable for heavy use or for modern day tasks.";
        }

        return RamSummary;
    } //Ram Summary

    public String MoboSummary(Motherboard Mobo)
    {
        String MoboSummary;
        if (Mobo.PerformanceScore >= 7)
        {
            MoboSummary = "The " + Mobo.Name + " has excellent compatibility with newer features and standards, and will be an excellent choice for those needing a basis for a rather high end system.";
        }
        else if (Mobo.PerformanceScore > 5 && Mobo.PerformanceScore < 7)
        {
            MoboSummary = "The " + Mobo.Name + " is a solid choice for gamers and enthusiasts";
        }
        else
        {
            MoboSummary = "The " + Mobo.Name + "will most likely not be suitable for heavy use or for modern day tasks.";
        }

        return MoboSummary;
    } //Ram Summary



}
