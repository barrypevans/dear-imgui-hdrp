using Unity.Collections.LowLevel.Unsafe;  using System.Runtime.CompilerServices;

namespace ImGuiNET
{
    public unsafe partial struct ImFontConfigPtr
    {
        public ImFontConfigPtr(ref ImFontConfig fontConfig)
        {
            NativePtr = (ImFontConfig*)UnsafeUtility.AddressOf(ref fontConfig);
        }
    }
}
