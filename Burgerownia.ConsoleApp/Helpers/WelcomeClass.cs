
namespace Burgerownia.ConsoleApp.Helpers
{
    public static class WelcomeClass
    {
        public static void Welcome()
        {
            string textMessage = "Hello, welcome to Our Burger Joint.";
            Message.Display(textMessage);
            textMessage = "How may I serve you?";
            Message.PressAnyKeyToContinue(textMessage);
        }
    }
}
