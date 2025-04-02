using System;

/// <summary>
/// Summary description for class Component
/// </summary>
public abstract class Component
{

    //Fields
    public string Name { get; set; } = "Unknown"; //Name of component (Manufacturer name, NOT COMPONENT TYPE) (Unknown default)
    public string Manufacturer { get; set; } = "Unknown"; //Name of Manufacturer (Unknown default)
    public int PerformanceScore { get; set; } = 0; //performance score (Need to determine scale) (0 default)
    


    public Component(string name, string manufacturer, int performanceScore)
	{
        this.Name = name;
        this.Manufacturer = manufacturer;
        this.PerformanceScore = performanceScore;   
	}

    public abstract string[] ToStringArray();
}
