using System.Collections.Generic;

public class Gastromorph : Attribute
{
    private List<Biome> biomes;
    private List<Element> elements;
    //private List<Flavour> flavours;
    private List<string> AnimURI;

    public Gastromorph(int id, string name, string description, List<Biome> biomes, List<Element> elements, /*List<Flavour> flavours,*/ string IconURI, List<string> AnimURI)
    {
        this.id = id;
        this.name = name;
        this.description = description;
        this.biomes = biomes;
        this.elements = elements;
        //this.flavours = flavours;
        this.IconURI = IconURI;
        this.AnimURI = AnimURI;
    }
}