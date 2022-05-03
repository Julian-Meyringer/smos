﻿namespace SMOS.Model;

public class TShirt : Product
{
    public TShirt(int id, string name, int price,  string size,string color,string countryOfManufacturer,string material) : base(id, name, price)
    {
        Size = size;
        Color = color;
        Material = material;
        CountryOfManufacturer = countryOfManufacturer;
    }
    public string Size { get; }
    public string Color { get; }
    public string Material { get; }

    public string CountryOfManufacturer { get; }
}