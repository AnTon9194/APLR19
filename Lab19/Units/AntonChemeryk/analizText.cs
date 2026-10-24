namespace UnitStudent
{
    public static class analizText
    {
        public static bool rozdilZnak(char c)
        {
            if (c == ' ' || c == '.' || c == ',' || c == ':' || c == ';' || c == '-')
                return true;
            else
                return false;
        }
    }
}
