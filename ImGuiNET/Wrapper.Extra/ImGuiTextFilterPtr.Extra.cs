using Unity.Collections.LowLevel.Unsafe;  using System.Runtime.CompilerServices;

namespace ImGuiNET
{
    // TODO: remake the filter in pure C#

    public unsafe partial struct ImGuiTextFilterPtr
    {
        public ImGuiTextFilterPtr(ref ImGuiTextFilter filter)
        {
            NativePtr = (ImGuiTextFilter*)UnsafeUtility.AddressOf(ref filter);
        }
    }
}
