using System;

namespace areaCalc
{
    public class AreaCalc
    {
        static void Main()
        {
            const string MsgChooseFigure = "De quina figura vols calcular l'area?\n a. quadrat\n b. rectangle\n c. cercle\n d. pentagon";
            const string MsgInputBase = "Introdueix la base de la figura: ";
            const string MsgArea = "Area: ";

            int area, baseFig, height;
            char figure;

            Console.WriteLine(MsgChooseFigure);
            figure = Convert.ToChar(Console.ReadLine());
            figure = char.ToLower(figure);

            switch (figure)
            {
                case 'a':
                    Console.WriteLine(MsgInputBase);
                    baseFig = Convert.ToInt32(Console.ReadLine());
                    area = Calc(baseFig);
                    Console.WriteLine(MsgArea + area);
                    break;
            }
        }
        public static int Calc(int baseFig)
        {
            return baseFig * baseFig;
        }
    }
}