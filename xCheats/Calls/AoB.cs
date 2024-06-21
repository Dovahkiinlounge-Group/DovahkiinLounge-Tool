using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace xCheats.Calls
{
    public class AoBScanner
    {
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [Out] byte[] lpBuffer, uint nSize, out int lpNumberOfBytesRead);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out int lpNumberOfBytesWritten);

        [DllImport("kernel32.dll")]
        public static extern bool CloseHandle(IntPtr hObject);

        public static IEnumerable<long> AoBScanAndPatch(int processId, long startAddress, long endAddress, string pattern, byte[] patchBytes)
        {
            byte[] patternBytes = ParsePattern(pattern);
            List<long> results = new List<long>();

            IntPtr processHandle = OpenProcess(0x10 | 0x20 | 0x1F0FFF, false, processId); // PROCESS_VM_READ (0x10) | PROCESS_QUERY_INFORMATION (0x20) | PROCESS_VM_WRITE (0x20)

            if (processHandle != IntPtr.Zero)
            {
                for (long address = startAddress; address < endAddress; address++)
                {
                    byte[] buffer = new byte[patternBytes.Length];
                    int bytesRead;

                    if (ReadProcessMemory(processHandle, (IntPtr)address, buffer, (uint)patternBytes.Length, out bytesRead) && bytesRead == patternBytes.Length)
                    {
                        if (CompareByteArrays(buffer, patternBytes))
                        {
                            results.Add(address);

                            // Patch the memory with the specified bytes
                            WriteProcessMemory(processHandle, (IntPtr)address, patchBytes, (uint)patchBytes.Length, out _);
                        }
                    }
                }

                CloseHandle(processHandle);
            }

            return results;
        }

        private static byte[] ParsePattern(string pattern)
        {
            List<byte> patternBytes = new List<byte>();

            foreach (string byteString in pattern.Split(' '))
            {
                if (byteString != "?")
                {
                    patternBytes.Add(Convert.ToByte(byteString, 16));
                }
            }

            return patternBytes.ToArray();
        }

        private static bool CompareByteArrays(byte[] array1, byte[] array2)
        {
            if (array1.Length != array2.Length)
            {
                return false;
            }

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i] && array2[i] != 0xFF) // Ignore wildcards represented by 0xFF
                {
                    return false;
                }
            }

            return true;
        }
    }
}

