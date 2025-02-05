namespace DDelegates
{
    abstract class ButtonClicker
    {
        public abstract void OnClick();
    }

    internal class MyBetterButton
    {
        public string Text { get; set; }

        public ButtonClicker Clicker { get; set; }

        private void InternalWorks()
        {
            //..Click detected.
            if (Clicker != null)
            {
                Clicker.OnClick();  
            }
        }
    }
}
