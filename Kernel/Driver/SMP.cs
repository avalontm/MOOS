namespace Kernel.Driver
{
    public static class SMP
    {
        public static void Initialize() 
        {
            Console.WriteLine("Waking Up All CPU(s)");

            uint LocalID = LocalAPIC.GetId();
            for(int i = 0; i < ACPI.LocalAPIC_CPUIDs.Count; ++i) 
            {
                uint APICID = ACPI.LocalAPIC_CPUIDs[i];
                if (APICID != LocalID) LocalAPIC.SendInit(APICID);
            }

            for (int i = 0; i < ACPI.LocalAPIC_CPUIDs.Count; ++i)
            {
                uint apicId = ACPI.LocalAPIC_CPUIDs[i];
                if (apicId != LocalID)
                {
                    LocalAPIC.SendStartup(apicId, 0x8);
                }
            }
            Console.WriteLine("All CPU(s) Actived");
        }
    }
}
