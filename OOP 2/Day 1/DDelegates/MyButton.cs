namespace DDelegates
{
    internal class MyButton
    {
        public string Text { get; set; }

        protected virtual void OnClick()
        {

        }

        private void InternalWorks()
        {
            //..Click detected.
            OnClick();
            
        }
    }
}
