using System;

namespace areaCalc
{
    public class AreaCalc
    {
        static void Main()
        {
            const string MsgChooseFigure = "De quina figura vols calcular l'area?\n a. quadrat\n b. rectangle\n c. cercle\n d. pentagon";
            const string MsgFigureError = "Aquesta figura no esta disponible. Introdueix una altre:";
            const string MsgInputBase = "Introdueix la base de la figura: ";
            const string MsgInputRadius = "Introdueix el radi del cercle: ";
            const string MsgInputApothem = "Introdueix l'apotema: ";
            const string MsgInputHeight = "Introdueix la altura: ";
            const string MsgArea = "Area: ";

            char figure;

            float area, apothem;

            int baseFig, height;

            bool figError = false;

            Console.WriteLine(MsgChooseFigure);
            do
            {
                if (figError)
                {
                    Console.WriteLine(MsgFigureError);
                }
                figure = Convert.ToChar(Console.ReadLine());
                figure = char.ToLower(figure);
                figError = ValidateFigure(figure);
            } while (figError);

            switch (figure)
            {
                case 'a':
                    Console.WriteLine(MsgInputBase);
                    baseFig = Convert.ToInt32(Console.ReadLine());
                    area = Calc(baseFig);
                    Console.WriteLine(MsgArea + area);
                    break;

                case 'b':
                    Console.WriteLine(MsgInputBase);
                    baseFig = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(MsgInputHeight);
                    height = Convert.ToInt32(Console.ReadLine());
                    area = Calc(baseFig, height);
                    Console.WriteLine(MsgArea + area);
                    break;

                case 'c':
                    Console.WriteLine(MsgInputRadius);
                    baseFig = Convert.ToInt32(Console.ReadLine());
                    area = Calc(baseFig, Math.PI);
                    Console.WriteLine(MsgArea + area);
                    break;

                case 'd':
                    Console.WriteLine(MsgInputBase);
                    baseFig = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(MsgInputApothem);
                    apothem = Convert.ToSingle(Console.ReadLine());
                    area = Calc(baseFig, apothem);
                    Console.WriteLine(MsgArea + area);
                    break;
            }
        }
        public static int Calc(int baseFig)
        {
            return baseFig * baseFig;
        }
        public static int Calc(int baseFig, int height)
        {
            return baseFig * height;
        }
        public static float Calc(int radius, double PI)
        {
            return (float)(PI * (radius * radius));
        }
        public static float Calc(int baseFig, float apothem)
        {
            int sides = 5, Two = 2;
            int perim = baseFig * sides;
            return perim * apothem / Two;
        }
        public static bool ValidateFigure(char fig)
        {
            return !(fig == 'a' || fig == 'b' || fig == 'c' || fig == 'd');
        }
    }
}