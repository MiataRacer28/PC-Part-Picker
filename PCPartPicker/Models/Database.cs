using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.IO;

/// <summary>
/// Database class
/// </summary>
public class Database
{
    public static List<Component> PartsList;
    private static string PathToFiles;


    public static void LoadDatabase()
    {

        //pathToFiles = Application.dataPath.Substring(0, Application.dataPath.LastIndexOf("/")) + "/Files/";

        if (PartsList == null)
        {
            PartsList = new List<Component>();
        }
        


        ReadParts(); //Method will read files from database text file and add them to the database
    }

    public static void UpdateDatabase(Component PartToAdd)
    {
        PartsList.Add(PartToAdd);
        WriteToDatabase(PartToAdd); //Write parts to the database file
    }

    public static void ReadParts()
    {
        try
        {
            string filePath = Path.Combine(PathToFiles, "components.txt"); //Combine method will handle OS specific file structure syntax

            if (!File.Exists(filePath)) //if file doesnt exist, create it
            {
                // Default content to initialize the components file
                string[] defaultContent = new string[]
                {
                    // CPU Sample
                    "CPU, \"Intel Core i9-13900K\", \"Intel\", 8, 24, 3.0, 125, \"Raptor Lake\", true, \"LGA1700\"",

                    // GPU Sample (AMD Radeon RX 7800 XT)
                    "GPU, \"AMD Radeon RX 7800 XT\", \"AMD\", 7, 3840, 1900, 2500, \"RDNA 3\", 16384, \"GDDR6\", 300, true, \"DirectX 12, Vulkan\"",

                     // RAM Sample
                     "RAM, \"Corsair Vengeance LPX 32GB\", \"Corsair\", 10, 32000, \"DDR4\", 3200, \"16-18-18-36\", \"1.35V\", false",

                     // Motherboard Sample
                     "Motherboard, \"ASUS ROG Strix Z690-E\", \"ASUS\", 10, \"ATX\", \"LGA1700\", \"Z690\", \"DDR4\", 128, 5333, 4, \"PCIe 5.0\", \"4.0\""
                };

                File.WriteAllLines(filePath, defaultContent);
                //New file created and default temporary contents writted (Will be used for testing)
            }


            string[] lines = File.ReadAllLines(filePath);

            // Process each line
            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;  // Skip empty lines

                // Split the line by commas
                string[] parts = line.Split(',');

                // Trim spaces and remove quotes
                for (int i = 0; i < parts.Length; i++)
                {
                    parts[i] = parts[i].Trim();
                    if (parts[i].StartsWith("\"") && parts[i].EndsWith("\""))
                    {
                        parts[i] = parts[i].Substring(1, parts[i].Length - 2);  // Remove quotes
                    }
                }

                // Handle the creation of different components based on the first part of the line
                string componentType = parts[0];  // The type of component (CPU, GPU, etc.)

                switch (componentType)
                {
                    case "CPU":
                        // Create CPU and add it to the list
                        PartsList.Add(CreateCPU(parts));
                        break;

                    case "GPU":
                        // Create GPU and add it to the list
                        PartsList.Add(CreateGPU(parts));
                        break;

                    case "RAM":
                        // Create RAM and add it to the list
                        PartsList.Add(CreateRAM(parts));
                        break;

                    case "Motherboard":
                        // Create Motherboard and add it to the list
                        PartsList.Add(CreateMotherboard(parts));
                        break;

                    default:
                        // Handle unknown component types (if needed)
                        Console.WriteLine("An error has occured reading the database");
                        break;
                }
            }
            
            Console.WriteLine("Operation Successfull.");
        }
        catch (Exception e)
        {
            Console.WriteLine("An error has occured reading the database");
        }
    }

    public static void WriteToDatabase(Component PartToAdd)
    {
        try
        {
            string filePath = Path.Combine(PathToFiles, "components.txt");
            string lineToAdd = string.Join(",", PartToAdd.ToStringArray());
            File.AppendAllText(filePath, lineToAdd + Environment.NewLine);
        }
        catch(Exception E)
        {
            Console.WriteLine("Database write failure!");
        }
    }





    // Helper method to create a CPU object from the parsed line
    private static CPU CreateCPU(string[] parts)
    {
        string name = parts[1];
        string manufacturer = parts[2];
        int performanceScore = int.Parse(parts[3]);
        int coreCount = int.Parse(parts[4]);
        double clockFrequency = double.Parse(parts[5]);
        int maximumTDP = int.Parse(parts[6]);
        string architecture = parts[7];
        bool integratedGraphics = bool.Parse(parts[8]);
        string socket = parts[9];

        return new CPU(name, manufacturer, performanceScore, coreCount, clockFrequency, maximumTDP, architecture, integratedGraphics, socket);
    }

    // Helper method to create a GPU object from the parsed line
    private static GPU CreateGPU(string[] parts)
    {
        string name = parts[1];
        string manufacturer = parts[2];
        int performanceScore = int.Parse(parts[3]);
        int coreCount = int.Parse(parts[4]);
        int baseClock = int.Parse(parts[5]);
        int maxClock = int.Parse(parts[6]);
        string architecture = parts[7];
        int vram = int.Parse(parts[8]);
        string memType = parts[9];
        int maximumTDP = int.Parse(parts[10]);
        bool rayTracing = bool.Parse(parts[11]);
        string recentGraphicsAPI = parts[12];

        return new GPU(name, manufacturer, performanceScore, coreCount, baseClock, maxClock, architecture, vram, memType, maximumTDP, rayTracing, recentGraphicsAPI);
    }

    // Helper method to create a RAM object from the parsed line
    private static RAM CreateRAM(string[] parts)
    {
        string name = parts[1];
        string manufacturer = parts[2];
        int performanceScore = int.Parse(parts[3]);
        int capacity = int.Parse(parts[4]);
        string memoryType = parts[5];
        int memoryFrequency = int.Parse(parts[6]);
        string latency = parts[7];
        string voltage = parts[8];
        bool errorCorrecting = bool.Parse(parts[9]);

        return new RAM(name, manufacturer, performanceScore, capacity, memoryType, memoryFrequency, latency, voltage, errorCorrecting);
    }

    // Helper method to create a Motherboard object from the parsed line
    private static Motherboard CreateMotherboard(string[] parts)
    {
        string name = parts[1];
        string manufacturer = parts[2];
        int performanceScore = int.Parse(parts[3]);
        string formFactor = parts[4];
        string socket = parts[5];
        string chipset = parts[6];
        string memoryType = parts[7];
        int maximumMemory = int.Parse(parts[8]);
        int maximumMemorySpeed = int.Parse(parts[9]);
        int numberOfPCIeSlots = int.Parse(parts[10]);
        string maxPCIeSlotType = parts[11];
        string pcieVer = parts[12];

        return new Motherboard(name, manufacturer, performanceScore, formFactor, socket, chipset, memoryType, maximumMemory, maximumMemorySpeed, numberOfPCIeSlots, maxPCIeSlotType, pcieVer);
    }

}
