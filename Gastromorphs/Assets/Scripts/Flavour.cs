
public class Flavour : Attribute
{
    public Flavour(int id, string name, string description, string IconURI) 
    { 
        this.id = id;
        this.name = name;
        this.description = description;
        this.IconURI = IconURI;
    }
}