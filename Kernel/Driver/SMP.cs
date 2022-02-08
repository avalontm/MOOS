namespace Kernel.Driver
{
    public static class SMP
    {
        public static int NumCPU;

        public static void Initialize() 
        {
            Console.WriteLine("Waking Up All CPU(s)");

            NumCPU = ACPI.LocalAPIC_CPUIDs.Count;
            uint LocalID = LocalAPIC.GetId();
            for(int i = 0; i < NumCPU; ++i) 
            {
                uint APICID = ACPI.LocalAPIC_CPUIDs[i];
                if (APICID != LocalID) LocalAPIC.SendInit(APICID);
            }

            PIT.Wait(10);

            for (int i = 0; i < NumCPU; ++i)
            {
                uint apicId = ACPI.LocalAPIC_CPUIDs[i];
                if (apicId != LocalID)
                {
                    LocalAPIC.SendStartup(apicId, 0x8);
                }
            }
            PIT.Wait(100);
            Console.WriteLine("All CPU(s) Actived");
        }
    }
}
