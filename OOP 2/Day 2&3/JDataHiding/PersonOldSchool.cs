namespace JDataHiding;

internal class PersonOldSchool
{
    private string name;

    public string get_Name() {  return name; }

    public void set_Name(string value)
    {
        if (String.IsNullOrWhiteSpace (value)) 
            throw new ArgumentNullException ("value");
        name = value;
    }
}
