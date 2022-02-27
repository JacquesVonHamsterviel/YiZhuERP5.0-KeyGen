using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsApplication1.My
{
	// Token: 0x0200000A RID: 10
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
	[CompilerGenerated]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal sealed partial class MySettings : ApplicationSettingsBase
	{
		// Token: 0x06000117 RID: 279 RVA: 0x0000224C File Offset: 0x0000064C
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[DebuggerNonUserCode]
		private static void AutoSaveSettings(object sender, EventArgs e)
		{
			if (MyProject.Application.SaveMySettingsOnExit)
			{
				MySettingsProperty.Settings.Save();
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000118 RID: 280 RVA: 0x00002264 File Offset: 0x00000664
		public static MySettings Default
		{
			get
			{
				if (!MySettings.addedHandler)
				{
					object obj = MySettings.addedHandlerLockObject;
					ObjectFlowControl.CheckForSyncLockOnValueType(obj);
					lock (obj)
					{
						if (!MySettings.addedHandler)
						{
							MyProject.Application.Shutdown += MySettings.AutoSaveSettings;
							MySettings.addedHandler = true;
						}
					}
				}
				return MySettings.defaultInstance;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000119 RID: 281 RVA: 0x000022CC File Offset: 0x000006CC
		// (set) Token: 0x0600011A RID: 282 RVA: 0x000022EC File Offset: 0x000006EC
		[UserScopedSetting]
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		public bool TextBox1
		{
			get
			{
				return Conversions.ToBoolean(this["TextBox1"]);
			}
			set
			{
				this["TextBox1"] = value;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600011B RID: 283 RVA: 0x00002300 File Offset: 0x00000700
		// (set) Token: 0x0600011C RID: 284 RVA: 0x00002320 File Offset: 0x00000720
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("False")]
		public bool BASQTY
		{
			get
			{
				return Conversions.ToBoolean(this["BASQTY"]);
			}
			set
			{
				this["BASQTY"] = value;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600011D RID: 285 RVA: 0x00002334 File Offset: 0x00000734
		// (set) Token: 0x0600011E RID: 286 RVA: 0x00002354 File Offset: 0x00000754
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("False")]
		public bool COPQTY
		{
			get
			{
				return Conversions.ToBoolean(this["COPQTY"]);
			}
			set
			{
				this["COPQTY"] = value;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600011F RID: 287 RVA: 0x00002368 File Offset: 0x00000768
		// (set) Token: 0x06000120 RID: 288 RVA: 0x00002388 File Offset: 0x00000788
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool CRMQTY
		{
			get
			{
				return Conversions.ToBoolean(this["CRMQTY"]);
			}
			set
			{
				this["CRMQTY"] = value;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000121 RID: 289 RVA: 0x0000239C File Offset: 0x0000079C
		// (set) Token: 0x06000122 RID: 290 RVA: 0x000023BC File Offset: 0x000007BC
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		public bool CWBQTY
		{
			get
			{
				return Conversions.ToBoolean(this["CWBQTY"]);
			}
			set
			{
				this["CWBQTY"] = value;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000123 RID: 291 RVA: 0x000023D0 File Offset: 0x000007D0
		// (set) Token: 0x06000124 RID: 292 RVA: 0x000023F0 File Offset: 0x000007F0
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		public bool FIBQTY
		{
			get
			{
				return Conversions.ToBoolean(this["FIBQTY"]);
			}
			set
			{
				this["FIBQTY"] = value;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000125 RID: 293 RVA: 0x00002404 File Offset: 0x00000804
		// (set) Token: 0x06000126 RID: 294 RVA: 0x00002424 File Offset: 0x00000824
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		public bool GYSQTY
		{
			get
			{
				return Conversions.ToBoolean(this["GYSQTY"]);
			}
			set
			{
				this["GYSQTY"] = value;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000127 RID: 295 RVA: 0x00002438 File Offset: 0x00000838
		// (set) Token: 0x06000128 RID: 296 RVA: 0x00002458 File Offset: 0x00000858
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool GZSQTY
		{
			get
			{
				return Conversions.ToBoolean(this["GZSQTY"]);
			}
			set
			{
				this["GZSQTY"] = value;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000129 RID: 297 RVA: 0x0000246C File Offset: 0x0000086C
		// (set) Token: 0x0600012A RID: 298 RVA: 0x0000248C File Offset: 0x0000088C
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool INVQTY
		{
			get
			{
				return Conversions.ToBoolean(this["INVQTY"]);
			}
			set
			{
				this["INVQTY"] = value;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600012B RID: 299 RVA: 0x000024A0 File Offset: 0x000008A0
		// (set) Token: 0x0600012C RID: 300 RVA: 0x000024C0 File Offset: 0x000008C0
		[UserScopedSetting]
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		public bool JCAQTY
		{
			get
			{
				return Conversions.ToBoolean(this["JCAQTY"]);
			}
			set
			{
				this["JCAQTY"] = value;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600012D RID: 301 RVA: 0x000024D4 File Offset: 0x000008D4
		// (set) Token: 0x0600012E RID: 302 RVA: 0x000024F4 File Offset: 0x000008F4
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool KJSQTY
		{
			get
			{
				return Conversions.ToBoolean(this["KJSQTY"]);
			}
			set
			{
				this["KJSQTY"] = value;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600012F RID: 303 RVA: 0x00002508 File Offset: 0x00000908
		// (set) Token: 0x06000130 RID: 304 RVA: 0x00002528 File Offset: 0x00000928
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool PJMQTY
		{
			get
			{
				return Conversions.ToBoolean(this["PJMQTY"]);
			}
			set
			{
				this["PJMQTY"] = value;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000131 RID: 305 RVA: 0x0000253C File Offset: 0x0000093C
		// (set) Token: 0x06000132 RID: 306 RVA: 0x0000255C File Offset: 0x0000095C
		[UserScopedSetting]
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		public bool PURQTY
		{
			get
			{
				return Conversions.ToBoolean(this["PURQTY"]);
			}
			set
			{
				this["PURQTY"] = value;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000133 RID: 307 RVA: 0x00002570 File Offset: 0x00000970
		// (set) Token: 0x06000134 RID: 308 RVA: 0x00002590 File Offset: 0x00000990
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool QMSQTY
		{
			get
			{
				return Conversions.ToBoolean(this["QMSQTY"]);
			}
			set
			{
				this["QMSQTY"] = value;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000135 RID: 309 RVA: 0x000025A4 File Offset: 0x000009A4
		// (set) Token: 0x06000136 RID: 310 RVA: 0x000025C4 File Offset: 0x000009C4
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("False")]
		public bool RGSQTY
		{
			get
			{
				return Conversions.ToBoolean(this["RGSQTY"]);
			}
			set
			{
				this["RGSQTY"] = value;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000137 RID: 311 RVA: 0x000025D8 File Offset: 0x000009D8
		// (set) Token: 0x06000138 RID: 312 RVA: 0x000025F8 File Offset: 0x000009F8
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool RMAQTY
		{
			get
			{
				return Conversions.ToBoolean(this["RMAQTY"]);
			}
			set
			{
				this["RMAQTY"] = value;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000139 RID: 313 RVA: 0x0000260C File Offset: 0x00000A0C
		// (set) Token: 0x0600013A RID: 314 RVA: 0x0000262C File Offset: 0x00000A2C
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool SCMQTY
		{
			get
			{
				return Conversions.ToBoolean(this["SCMQTY"]);
			}
			set
			{
				this["SCMQTY"] = value;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600013B RID: 315 RVA: 0x00002640 File Offset: 0x00000A40
		// (set) Token: 0x0600013C RID: 316 RVA: 0x00002660 File Offset: 0x00000A60
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		public bool SGMQTY
		{
			get
			{
				return Conversions.ToBoolean(this["SGMQTY"]);
			}
			set
			{
				this["SGMQTY"] = value;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600013D RID: 317 RVA: 0x00002674 File Offset: 0x00000A74
		// (set) Token: 0x0600013E RID: 318 RVA: 0x00002694 File Offset: 0x00000A94
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		public bool SXMQTY
		{
			get
			{
				return Conversions.ToBoolean(this["SXMQTY"]);
			}
			set
			{
				this["SXMQTY"] = value;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600013F RID: 319 RVA: 0x000026A8 File Offset: 0x00000AA8
		// (set) Token: 0x06000140 RID: 320 RVA: 0x000026C8 File Offset: 0x00000AC8
		[UserScopedSetting]
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		public bool SYSQTY
		{
			get
			{
				return Conversions.ToBoolean(this["SYSQTY"]);
			}
			set
			{
				this["SYSQTY"] = value;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000141 RID: 321 RVA: 0x000026DC File Offset: 0x00000ADC
		// (set) Token: 0x06000142 RID: 322 RVA: 0x000026FC File Offset: 0x00000AFC
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool WLBQTY
		{
			get
			{
				return Conversions.ToBoolean(this["WLBQTY"]);
			}
			set
			{
				this["WLBQTY"] = value;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000143 RID: 323 RVA: 0x00002710 File Offset: 0x00000B10
		// (set) Token: 0x06000144 RID: 324 RVA: 0x00002730 File Offset: 0x00000B30
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool YSFQTY
		{
			get
			{
				return Conversions.ToBoolean(this["YSFQTY"]);
			}
			set
			{
				this["YSFQTY"] = value;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000145 RID: 325 RVA: 0x00002744 File Offset: 0x00000B44
		// (set) Token: 0x06000146 RID: 326 RVA: 0x00002764 File Offset: 0x00000B64
		[UserScopedSetting]
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		public bool ZCSQTY
		{
			get
			{
				return Conversions.ToBoolean(this["ZCSQTY"]);
			}
			set
			{
				this["ZCSQTY"] = value;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000147 RID: 327 RVA: 0x00002778 File Offset: 0x00000B78
		// (set) Token: 0x06000148 RID: 328 RVA: 0x00002798 File Offset: 0x00000B98
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool ALLQTY
		{
			get
			{
				return Conversions.ToBoolean(this["ALLQTY"]);
			}
			set
			{
				this["ALLQTY"] = value;
			}
		}

		// Token: 0x0400007F RID: 127
		private static MySettings defaultInstance = (MySettings)SettingsBase.Synchronized(new MySettings());

		// Token: 0x04000080 RID: 128
		private static bool addedHandler;

		// Token: 0x04000081 RID: 129
		private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());
	}
}
