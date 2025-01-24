namespace postitOOP;

internal class Postit
{
    private string color;
    private string text;

    public Postit(string color)
    {
        this.color = color;
        this.text = "";
    }

    public string Color { get => color; }
    public string Text
    {
        get => text;
        set => text = (text + value).Length <= 100 ? text + value : text;
    }
    public override string ToString()
    {
        return $"{this.color} postit, tartalom: {this.text}";
    }
}
