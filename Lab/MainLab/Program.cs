using System;

interface ILamp
{
    string Type { get; set; }
    string Manufacturer { get; set; }
    int LuminousPower { get; set; }
    string LightType { get; set; }
    int NumberOfElements { get; set; }

    void DisplayInfo();
    void ChangePower(int newPower);
}

interface ICamera
{
    string Type { get; set; }
    string Manufacturer { get; set; }
    int LightSensitivity { get; set; }

    void DisplayInfo();
    void ChangeSensitivity(int newSensitivity);
}

class PhotoStudio : ILamp, ICamera
{
    public string Type { get; set; }
    public string Manufacturer { get; set; }
    public int LuminousPower { get; set; }
    public string LightType { get; set; }
    public int NumberOfElements { get; set; }

    public int LightSensitivity { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Type: {Type}");
        Console.WriteLine($"Manufacturer: {Manufacturer}");
        Console.WriteLine($"Luminous Power: {LuminousPower} lumens");
        Console.WriteLine($"Light Type: {LightType}");
        Console.WriteLine($"Number of Elements: {NumberOfElements}");

        Console.WriteLine($"Light Sensitivity: {LightSensitivity}");
    }

    public void ChangePower(int newPower)
    {
        LuminousPower = newPower;
        Console.WriteLine($"Luminous Power changed to: {newPower} lumens");
    }

    public void ChangeSensitivity(int newSensitivity)
    {
        LightSensitivity = newSensitivity;
        Console.WriteLine($"Light Sensitivity changed to: {newSensitivity}");
    }
}

class Program
{
    static void Main()
    {
        PhotoStudio studio1 = new PhotoStudio
        {
            Type = "Studio Light",
            Manufacturer = "Example Manufacturer",
            LuminousPower = 1000,
            LightType = "LED",
            NumberOfElements = 5,
            LightSensitivity = 200
        };

        PhotoStudio studio2 = new PhotoStudio
        {
            Type = "Camera Flash",
            Manufacturer = "Another Manufacturer",
            LuminousPower = 800,
            LightType = "Xenon",
            NumberOfElements = 3,
            LightSensitivity = 150
        };

        Console.WriteLine("Photo Studio 1 Info:");
        studio1.DisplayInfo();
        Console.WriteLine();

        Console.WriteLine("Photo Studio 2 Info:");
        studio2.DisplayInfo();
        Console.WriteLine();

        studio1.ChangeSensitivity(250);

        Console.WriteLine("Updated Photo Studio 1 Info:");
        studio1.DisplayInfo();
    }
}
