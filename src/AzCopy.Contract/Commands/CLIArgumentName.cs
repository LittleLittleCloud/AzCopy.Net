namespace AzCopy.Contract
{
    internal class CLIArgumentName : System.Attribute
    {
        public CLIArgumentName(string name, bool useQuotes = false, bool isFlag = false)
        {
            this.ArgumentName = name;
            this.UseQuotes = useQuotes;
            this.IsFlag = isFlag;
        }

        public string ArgumentName { get; private set; }

        public bool UseQuotes { get; private set; }

        public bool IsFlag { get; private set; }
    }
}
