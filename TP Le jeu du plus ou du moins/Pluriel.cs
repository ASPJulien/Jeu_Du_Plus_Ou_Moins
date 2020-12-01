namespace TP_Le_jeu_du_plus_ou_du_moins
{
    public static class Pluriel
    {
        public static string pluriel(int number)
        {
            if (number > 1)
                return "s";
            else
                return "";
        }
    }
}