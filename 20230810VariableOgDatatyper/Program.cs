namespace _20230810VariableOgDatatyper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Opgave a):
            int length = 16;
            double width = 5.1;
            Console.WriteLine(length * width);

            // Opgave b):
            int area = width * height;
            // Visual Studio compiler vil ikke oversætte det,
            // fordi datatype for width er double, derfor datatype for area skal også være double

            // Opgave c):
            double d = width * length;
            Console.WriteLine(d);
            // Her vil Visual Studio gerne oversætte din kode, men hvorfor nu det?
            // Fordi nu er dataytpe double.
        }
    }
}