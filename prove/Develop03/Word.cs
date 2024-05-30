internal class Word
{
    private string Text { get; }
    private bool Visible { get; set; }

    public Word(string text)
    {
        Text = text;
        Visible = true;
    }

    public string GetText()
    {
        return Visible ? Text : "____";
    }

    public bool IsVisible()
    {
        return Visible;
    }

    public void Hide()
    {
        Visible = false;
    }

    public void Show()
    {
        Visible = true;
    }
}
