using RGiesecke.DllExport;
using System.Runtime.InteropServices;
using System.Text;

namespace VehWeapon
{
    public class DllEntry
    {
        [DllExport("_RVExtension@12", CallingConvention = System.Runtime.InteropServices.CallingConvention.Winapi)]
        public static void RVExtension(StringBuilder output, int outputSize, [MarshalAs(UnmanagedType.LPStr)] string function)
        {
            outputSize--;

            string WG_Input = function;
            int WG_Input1 = WG_Input.IndexOf('_');
            string WG_VehWeapon = WG_Input.Substring(0, WG_Input1);
            output.Append(WG_VehWeapon);
            return;
        }
    }
}