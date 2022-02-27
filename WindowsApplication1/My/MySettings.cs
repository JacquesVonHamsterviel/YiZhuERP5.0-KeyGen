namespace WindowsApplication1.My
{
    using Microsoft.VisualBasic.ApplicationServices;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Configuration;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0"), CompilerGenerated, EditorBrowsable(EditorBrowsableState.Advanced)]
    internal sealed class MySettings : ApplicationSettingsBase
    {
        private static MySettings defaultInstance = ((MySettings) Synchronized(new MySettings()));
        private static bool addedHandler;
        private static object addedHandlerLockObject = new object();

        [EditorBrowsable(EditorBrowsableState.Advanced), DebuggerNonUserCode]
        private static void AutoSaveSettings(object sender, EventArgs e)
        {
            if (MyProject.Application.SaveMySettingsOnExit)
            {
                MySettingsProperty.Settings.Save();
            }
        }

        public static MySettings Default
        {
            get
            {
                if (!addedHandler)
                {
                    object addedHandlerLockObject = MySettings.addedHandlerLockObject;
                    ObjectFlowControl.CheckForSyncLockOnValueType(addedHandlerLockObject);
                    lock (addedHandlerLockObject)
                    {
                        if (!addedHandler)
                        {
                            MyProject.Application.Shutdown += new ShutdownEventHandler(MySettings.AutoSaveSettings);
                            addedHandler = true;
                        }
                    }
                }
                return defaultInstance;
            }
        }

        [UserScopedSetting, DefaultSettingValue("False"), DebuggerNonUserCode]
        public bool TextBox1
        {
            get => 
                Conversions.ToBoolean(this["TextBox1"]);
            set => 
                this["TextBox1"] = value;
        }

        [DebuggerNonUserCode, UserScopedSetting, DefaultSettingValue("False")]
        public bool BASQTY
        {
            get => 
                Conversions.ToBoolean(this["BASQTY"]);
            set => 
                this["BASQTY"] = value;
        }

        [DebuggerNonUserCode, UserScopedSetting, DefaultSettingValue("False")]
        public bool COPQTY
        {
            get => 
                Conversions.ToBoolean(this["COPQTY"]);
            set => 
                this["COPQTY"] = value;
        }

        [DefaultSettingValue("False"), DebuggerNonUserCode, UserScopedSetting]
        public bool CRMQTY
        {
            get => 
                Conversions.ToBoolean(this["CRMQTY"]);
            set => 
                this["CRMQTY"] = value;
        }

        [DebuggerNonUserCode, DefaultSettingValue("False"), UserScopedSetting]
        public bool CWBQTY
        {
            get => 
                Conversions.ToBoolean(this["CWBQTY"]);
            set => 
                this["CWBQTY"] = value;
        }

        [DebuggerNonUserCode, DefaultSettingValue("False"), UserScopedSetting]
        public bool FIBQTY
        {
            get => 
                Conversions.ToBoolean(this["FIBQTY"]);
            set => 
                this["FIBQTY"] = value;
        }

        [DebuggerNonUserCode, DefaultSettingValue("False"), UserScopedSetting]
        public bool GYSQTY
        {
            get => 
                Conversions.ToBoolean(this["GYSQTY"]);
            set => 
                this["GYSQTY"] = value;
        }

        [UserScopedSetting, DebuggerNonUserCode, DefaultSettingValue("False")]
        public bool GZSQTY
        {
            get => 
                Conversions.ToBoolean(this["GZSQTY"]);
            set => 
                this["GZSQTY"] = value;
        }

        [DefaultSettingValue("False"), DebuggerNonUserCode, UserScopedSetting]
        public bool INVQTY
        {
            get => 
                Conversions.ToBoolean(this["INVQTY"]);
            set => 
                this["INVQTY"] = value;
        }

        [UserScopedSetting, DefaultSettingValue("False"), DebuggerNonUserCode]
        public bool JCAQTY
        {
            get => 
                Conversions.ToBoolean(this["JCAQTY"]);
            set => 
                this["JCAQTY"] = value;
        }

        [DefaultSettingValue("False"), UserScopedSetting, DebuggerNonUserCode]
        public bool KJSQTY
        {
            get => 
                Conversions.ToBoolean(this["KJSQTY"]);
            set => 
                this["KJSQTY"] = value;
        }

        [UserScopedSetting, DebuggerNonUserCode, DefaultSettingValue("False")]
        public bool PJMQTY
        {
            get => 
                Conversions.ToBoolean(this["PJMQTY"]);
            set => 
                this["PJMQTY"] = value;
        }

        [UserScopedSetting, DefaultSettingValue("False"), DebuggerNonUserCode]
        public bool PURQTY
        {
            get => 
                Conversions.ToBoolean(this["PURQTY"]);
            set => 
                this["PURQTY"] = value;
        }

        [DefaultSettingValue("False"), DebuggerNonUserCode, UserScopedSetting]
        public bool QMSQTY
        {
            get => 
                Conversions.ToBoolean(this["QMSQTY"]);
            set => 
                this["QMSQTY"] = value;
        }

        [DebuggerNonUserCode, UserScopedSetting, DefaultSettingValue("False")]
        public bool RGSQTY
        {
            get => 
                Conversions.ToBoolean(this["RGSQTY"]);
            set => 
                this["RGSQTY"] = value;
        }

        [UserScopedSetting, DebuggerNonUserCode, DefaultSettingValue("False")]
        public bool RMAQTY
        {
            get => 
                Conversions.ToBoolean(this["RMAQTY"]);
            set => 
                this["RMAQTY"] = value;
        }

        [DefaultSettingValue("False"), DebuggerNonUserCode, UserScopedSetting]
        public bool SCMQTY
        {
            get => 
                Conversions.ToBoolean(this["SCMQTY"]);
            set => 
                this["SCMQTY"] = value;
        }

        [DebuggerNonUserCode, DefaultSettingValue("False"), UserScopedSetting]
        public bool SGMQTY
        {
            get => 
                Conversions.ToBoolean(this["SGMQTY"]);
            set => 
                this["SGMQTY"] = value;
        }

        [DebuggerNonUserCode, DefaultSettingValue("False"), UserScopedSetting]
        public bool SXMQTY
        {
            get => 
                Conversions.ToBoolean(this["SXMQTY"]);
            set => 
                this["SXMQTY"] = value;
        }

        [UserScopedSetting, DefaultSettingValue("False"), DebuggerNonUserCode]
        public bool SYSQTY
        {
            get => 
                Conversions.ToBoolean(this["SYSQTY"]);
            set => 
                this["SYSQTY"] = value;
        }

        [DefaultSettingValue("False"), DebuggerNonUserCode, UserScopedSetting]
        public bool WLBQTY
        {
            get => 
                Conversions.ToBoolean(this["WLBQTY"]);
            set => 
                this["WLBQTY"] = value;
        }

        [DefaultSettingValue("False"), DebuggerNonUserCode, UserScopedSetting]
        public bool YSFQTY
        {
            get => 
                Conversions.ToBoolean(this["YSFQTY"]);
            set => 
                this["YSFQTY"] = value;
        }

        [UserScopedSetting, DefaultSettingValue("False"), DebuggerNonUserCode]
        public bool ZCSQTY
        {
            get => 
                Conversions.ToBoolean(this["ZCSQTY"]);
            set => 
                this["ZCSQTY"] = value;
        }

        [DefaultSettingValue("False"), UserScopedSetting, DebuggerNonUserCode]
        public bool ALLQTY
        {
            get => 
                Conversions.ToBoolean(this["ALLQTY"]);
            set => 
                this["ALLQTY"] = value;
        }
    }
}

