namespace ExpertSystemShell.Tools
{
    public static class StringExtensions
    {
        public static string GetIndex(this string name) =>
            name.ToLower().Replace(" ", string.Empty);
    }
}
