namespace DDelegates;

delegate void ButtonClick(MySuperiorButton sender);

class MySuperiorButton
{
    public string Text { get; set; }

    public ButtonClick OnClicked { get; set; }

    private void InternalWorks()
    {
        //..Click detected.
        if (OnClicked != null)
        {
            OnClicked(this);
        }
    }
}
