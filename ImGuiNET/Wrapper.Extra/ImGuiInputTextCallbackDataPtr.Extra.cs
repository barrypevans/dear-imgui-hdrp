using Unity.Collections.LowLevel.Unsafe;  using System.Runtime.CompilerServices;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiInputTextCallbackDataPtr
    {
        public ImGuiInputTextCallbackDataPtr(ref ImGuiInputTextCallbackData data)
        {
            NativePtr = (ImGuiInputTextCallbackData*)UnsafeUtility.AddressOf(ref data);
        }

        public string Text => Util.StringFromPtr(NativePtr->Buf);
    }
}
