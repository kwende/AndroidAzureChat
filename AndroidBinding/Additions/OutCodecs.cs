using Android.Runtime;
using Java.Interop;
using System;

namespace Com.Skype.Android.Jipc.Omx.Inout
{

    // Metadata.xml XPath class reference: path="/api/package[@name='com.skype.android.jipc.omx.inout']/class[@name='OutCodecs']"
    public partial class OutCodecs : global::Java.Lang.Object, global::Com.Skype.Android.Jipc.Transactor.IOut
    {
        // Metadata.xml XPath method reference: path="/api/package[@name='com.skype.android.jipc.omx.inout']/class[@name='OutCodecs']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
        [Register("parse", "(Landroid/os/Parcel;)Ljava/util/Map;", "GetParse_Landroid_os_Parcel_Handler")]
        public virtual unsafe Java.Lang.Object Parse(global::Android.OS.Parcel reply)
        {
            const string __id = "parse.(Landroid/os/Parcel;)Ljava/util/Map;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue((reply == null) ? IntPtr.Zero : ((global::Java.Lang.Object)reply).Handle);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return (Java.Lang.Object)global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.ICollection<string>>.FromJniHandle(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
                global::System.GC.KeepAlive(reply);
            }
        }
    }
}