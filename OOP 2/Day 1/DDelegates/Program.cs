namespace DDelegates
{
    internal class Program
    {
        class MyClickMeButtonClicker : ButtonClicker
        {
            public override void OnClick()
            {
                Console.WriteLine("I am clicked!");
            }
        }

        static void SuperClicked(MySuperiorButton sender)
        {
            Console.WriteLine("I am clicked!");
        }

        static void Main(string[] args)
        {
            MyBetterButton myBetterButton = new MyBetterButton();
            myBetterButton.Text = "Click me";
            myBetterButton.Clicker = new MyClickMeButtonClicker();
        
            MySuperiorButton superBtn = new MySuperiorButton();
            superBtn.Text = "Click me!";
            superBtn.OnClicked = SuperClicked;
        }
    }
}
