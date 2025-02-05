namespace DDelegates
{
    class ButtonClickMe : MyButton
    {
        protected override void OnClick()
        {
            Console.WriteLine("I am clicked.");
        }
    }
}
