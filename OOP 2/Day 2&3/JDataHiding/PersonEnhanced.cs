namespace JDataHiding;

internal class PersonEnhanced
{
    private string name;

    public string Name
    {
        get { return name; }
        set
        {
            if (String.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException("name");
            name = value;
        }
    }

}