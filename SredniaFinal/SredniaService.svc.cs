using System.Linq;

namespace SredniaFinal
{
    
    public class SredniaService : ISredniaService
    {
        public double ObliczSrednia(double[] args)
        {
            int j = 0;
            for (int i = 0; i < args.Length; i++)
            {
                    j++;
            }
            return args.Sum() / j;
        }

        public string CzyPoprawna(double[] args)
                {
                    string info = "";
                    for(int i=0; i<args.Length; i++)
                    {
                        if(args[i]<0 || args[i]>5)
                        {
                            info = "Podano oceny z nieprawidłowego zakresu! Prawidłowy zakres <0.0-5.0>. Używaj kropek zamiast przecinka!";
                            break;
                        }
                        else
                        {
                            info = "Prawidłowo wprowadzono oceny";
                        }
                    }
                    return info;
                }

            public string CzyZdane(double srednia)
            {
            if(srednia>2.5)
                {
                    return "Gratulacje udało się zaliczyć przedmiot! :)";
                }else
                {
                    return "Niestety nie udało się zaliczyć przedmiotu :(";
                }
            }
    }
}
