**Discord Server: https://discord.gg/GxwmAK7aRE**  
C# operating system demo, using Native AOT (Core RT) boot via GNU-EFI  
| Items | Implemented | Working On Real Hardware (Tested on Supermicro X9DRI-LN4F+) | Note |
| ----- | ----------- | ----------------------------------------------------------- | ----- |
| Error Throwing / Catching | ❌ | ❌ |
| PS2 Keyboard/Mouse(USB Compatible) | ✅ | ❓ | UEFI will disable PS/2 Controller |
| Nintendo Family Computer Emulator | ✅ | ✅ |
| Intel® Gigabit Ethernet Network | ✅ | ❌ | Interrupt not work |
| Realtek RTL8139 | ✅ | ❌ | Interrupt not work |
| I/O APIC | ✅ | ✅ |
| Local APIC | ✅ | ✅ |
| SATA | ⚠️ | ❌ | Can't read more than one sec at once, Can't detect sata controller on real hardware |
| IDE | ✅ | ❓ |
| SMBIOS | ✅ | ✅ |
| ACPI | ✅ | ✅ |
| IPv4 | ✅ | ❓ |
| IPv6 | ❌ | ❌ |
| TCP(WIP) | ⚠️ | ❓ | Can't receive large package |
| UDP | ✅ | ❓ |
| Lan | ✅ | ❓ |
| Wan | ✅ | ❓ |
| ![image](https://github.com/nifanfa/Solution1/blob/uefi/Screenshot.png) | | | **Solution1 On Virtual Box** |
