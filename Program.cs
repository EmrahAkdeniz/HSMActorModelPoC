namespace HSMActorModelPoC
{
    internal static class Program
    {
        [MTAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmMain());
        }
    }
}