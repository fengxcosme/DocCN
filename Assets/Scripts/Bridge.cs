using System.Runtime.InteropServices;

namespace DocCN
{
    public static class Bridge
    {        
#if UNITY_WEBGL
        [DllImport("__Internal")]
        public static extern void Hello();

        [DllImport("__Internal")]
        public static extern void ChangeCursor(string cursor);
#endif
    }
}