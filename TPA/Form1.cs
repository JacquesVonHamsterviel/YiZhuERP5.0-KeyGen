using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using WindowsApplication1.My;

namespace WindowsApplication1
{
	// Token: 0x02000008 RID: 8
	//[DesignerGenerated]
	public partial class Form1 : Form
	{
		// Token: 0x0600001D RID: 29 RVA: 0x00002B98 File Offset: 0x00000F98
		[DebuggerNonUserCode]
		public Form1()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000020 RID: 32 RVA: 0x000076A0 File Offset: 0x00005AA0
		// (set) Token: 0x06000021 RID: 33 RVA: 0x000076B4 File Offset: 0x00005AB4
		internal virtual Button Button1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button1_Click);
				if (this._Button1 != null)
				{
					this._Button1.Click -= value2;
				}
				this._Button1 = value;
				if (this._Button1 != null)
				{
					this._Button1.Click += value2;
				}
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00007700 File Offset: 0x00005B00
		// (set) Token: 0x06000023 RID: 35 RVA: 0x00007714 File Offset: 0x00005B14
		internal virtual TextBox SN
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SN;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SN = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00007720 File Offset: 0x00005B20
		// (set) Token: 0x06000025 RID: 37 RVA: 0x00007734 File Offset: 0x00005B34
		internal virtual TextBox KEY
		{
			[DebuggerNonUserCode]
			get
			{
				return this._KEY;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._KEY = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00007740 File Offset: 0x00005B40
		// (set) Token: 0x06000027 RID: 39 RVA: 0x00007754 File Offset: 0x00005B54
		internal virtual GroupBox GroupBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox1 = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00007760 File Offset: 0x00005B60
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00007774 File Offset: 0x00005B74
		internal virtual CheckBox BAS
		{
			[DebuggerNonUserCode]
			get
			{
				return this._BAS;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.BAS_CheckStateChanged);
				if (this._BAS != null)
				{
					this._BAS.CheckStateChanged -= value2;
				}
				this._BAS = value;
				if (this._BAS != null)
				{
					this._BAS.CheckStateChanged += value2;
				}
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600002A RID: 42 RVA: 0x000077C0 File Offset: 0x00005BC0
		// (set) Token: 0x0600002B RID: 43 RVA: 0x000077D4 File Offset: 0x00005BD4
		internal virtual Label Label10
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label10;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label10 = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600002C RID: 44 RVA: 0x000077E0 File Offset: 0x00005BE0
		// (set) Token: 0x0600002D RID: 45 RVA: 0x000077F4 File Offset: 0x00005BF4
		internal virtual Label Label8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label8 = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00007800 File Offset: 0x00005C00
		// (set) Token: 0x0600002F RID: 47 RVA: 0x00007814 File Offset: 0x00005C14
		internal virtual Label Label6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label6 = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00007820 File Offset: 0x00005C20
		// (set) Token: 0x06000031 RID: 49 RVA: 0x00007834 File Offset: 0x00005C34
		internal virtual Label Label4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label4 = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00007840 File Offset: 0x00005C40
		// (set) Token: 0x06000033 RID: 51 RVA: 0x00007854 File Offset: 0x00005C54
		internal virtual Label Label2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label2 = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00007860 File Offset: 0x00005C60
		// (set) Token: 0x06000035 RID: 53 RVA: 0x00007874 File Offset: 0x00005C74
		internal virtual Label Label9
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label9;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label9 = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00007880 File Offset: 0x00005C80
		// (set) Token: 0x06000037 RID: 55 RVA: 0x00007894 File Offset: 0x00005C94
		internal virtual Label Label7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label7 = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000038 RID: 56 RVA: 0x000078A0 File Offset: 0x00005CA0
		// (set) Token: 0x06000039 RID: 57 RVA: 0x000078B4 File Offset: 0x00005CB4
		internal virtual Label Label5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label5 = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600003A RID: 58 RVA: 0x000078C0 File Offset: 0x00005CC0
		// (set) Token: 0x0600003B RID: 59 RVA: 0x000078D4 File Offset: 0x00005CD4
		internal virtual Label Label3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label3 = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600003C RID: 60 RVA: 0x000078E0 File Offset: 0x00005CE0
		// (set) Token: 0x0600003D RID: 61 RVA: 0x000078F4 File Offset: 0x00005CF4
		internal virtual Label Label1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label1 = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00007900 File Offset: 0x00005D00
		// (set) Token: 0x0600003F RID: 63 RVA: 0x00007914 File Offset: 0x00005D14
		internal virtual TextBox CWBQTY
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CWBQTY;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CWBQTY = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00007920 File Offset: 0x00005D20
		// (set) Token: 0x06000041 RID: 65 RVA: 0x00007934 File Offset: 0x00005D34
		internal virtual TextBox CRMQTY
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CRMQTY;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CRMQTY = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00007940 File Offset: 0x00005D40
		// (set) Token: 0x06000043 RID: 67 RVA: 0x00007954 File Offset: 0x00005D54
		internal virtual CheckBox CRM
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CRM;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.BAS_CheckStateChanged);
				if (this._CRM != null)
				{
					this._CRM.CheckStateChanged -= value2;
				}
				this._CRM = value;
				if (this._CRM != null)
				{
					this._CRM.CheckStateChanged += value2;
				}
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000044 RID: 68 RVA: 0x000079A0 File Offset: 0x00005DA0
		// (set) Token: 0x06000045 RID: 69 RVA: 0x000079B4 File Offset: 0x00005DB4
		internal virtual TextBox COPQTY
		{
			[DebuggerNonUserCode]
			get
			{
				return this._COPQTY;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._COPQTY = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000046 RID: 70 RVA: 0x000079C0 File Offset: 0x00005DC0
		// (set) Token: 0x06000047 RID: 71 RVA: 0x000079D4 File Offset: 0x00005DD4
		internal virtual CheckBox COP
		{
			[DebuggerNonUserCode]
			get
			{
				return this._COP;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.BAS_CheckStateChanged);
				if (this._COP != null)
				{
					this._COP.CheckStateChanged -= value2;
				}
				this._COP = value;
				if (this._COP != null)
				{
					this._COP.CheckStateChanged += value2;
				}
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00007A20 File Offset: 0x00005E20
		// (set) Token: 0x06000049 RID: 73 RVA: 0x00007A34 File Offset: 0x00005E34
		internal virtual TextBox BASQTY
		{
			[DebuggerNonUserCode]
			get
			{
				return this._BASQTY;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._BASQTY = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00007A40 File Offset: 0x00005E40
		// (set) Token: 0x0600004B RID: 75 RVA: 0x00007A54 File Offset: 0x00005E54
		internal virtual Label Label50
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label50;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label50 = value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00007A60 File Offset: 0x00005E60
		// (set) Token: 0x0600004D RID: 77 RVA: 0x00007A74 File Offset: 0x00005E74
		internal virtual Label Label40
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label40;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label40 = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00007A80 File Offset: 0x00005E80
		// (set) Token: 0x0600004F RID: 79 RVA: 0x00007A94 File Offset: 0x00005E94
		internal virtual Label Label30
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label30;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label30 = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00007AA0 File Offset: 0x00005EA0
		// (set) Token: 0x06000051 RID: 81 RVA: 0x00007AB4 File Offset: 0x00005EB4
		internal virtual Label Label20
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label20;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label20 = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00007AC0 File Offset: 0x00005EC0
		// (set) Token: 0x06000053 RID: 83 RVA: 0x00007AD4 File Offset: 0x00005ED4
		internal virtual Label Label49
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label49;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label49 = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00007AE0 File Offset: 0x00005EE0
		// (set) Token: 0x06000055 RID: 85 RVA: 0x00007AF4 File Offset: 0x00005EF4
		internal virtual Label Label39
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label39;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label39 = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00007B00 File Offset: 0x00005F00
		// (set) Token: 0x06000057 RID: 87 RVA: 0x00007B14 File Offset: 0x00005F14
		internal virtual Label Label29
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label29;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label29 = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00007B20 File Offset: 0x00005F20
		// (set) Token: 0x06000059 RID: 89 RVA: 0x00007B34 File Offset: 0x00005F34
		internal virtual Label Label19
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label19;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label19 = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00007B40 File Offset: 0x00005F40
		// (set) Token: 0x0600005B RID: 91 RVA: 0x00007B54 File Offset: 0x00005F54
		internal virtual Label Label48
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label48;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label48 = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00007B60 File Offset: 0x00005F60
		// (set) Token: 0x0600005D RID: 93 RVA: 0x00007B74 File Offset: 0x00005F74
		internal virtual Label Label38
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label38;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label38 = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00007B80 File Offset: 0x00005F80
		// (set) Token: 0x0600005F RID: 95 RVA: 0x00007B94 File Offset: 0x00005F94
		internal virtual Label Label28
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label28;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label28 = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00007BA0 File Offset: 0x00005FA0
		// (set) Token: 0x06000061 RID: 97 RVA: 0x00007BB4 File Offset: 0x00005FB4
		internal virtual Label Label18
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label18;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label18 = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00007BC0 File Offset: 0x00005FC0
		// (set) Token: 0x06000063 RID: 99 RVA: 0x00007BD4 File Offset: 0x00005FD4
		internal virtual Label Label57
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label57;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label57 = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00007BE0 File Offset: 0x00005FE0
		// (set) Token: 0x06000065 RID: 101 RVA: 0x00007BF4 File Offset: 0x00005FF4
		internal virtual Label Label47
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label47;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label47 = value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00007C00 File Offset: 0x00006000
		// (set) Token: 0x06000067 RID: 103 RVA: 0x00007C14 File Offset: 0x00006014
		internal virtual Label Label37
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label37;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label37 = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00007C20 File Offset: 0x00006020
		// (set) Token: 0x06000069 RID: 105 RVA: 0x00007C34 File Offset: 0x00006034
		internal virtual Label Label27
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label27;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label27 = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00007C40 File Offset: 0x00006040
		// (set) Token: 0x0600006B RID: 107 RVA: 0x00007C54 File Offset: 0x00006054
		internal virtual Label Label17
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label17;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label17 = value;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00007C60 File Offset: 0x00006060
		// (set) Token: 0x0600006D RID: 109 RVA: 0x00007C74 File Offset: 0x00006074
		internal virtual Label Label56
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label56;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label56 = value;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00007C80 File Offset: 0x00006080
		// (set) Token: 0x0600006F RID: 111 RVA: 0x00007C94 File Offset: 0x00006094
		internal virtual Label Label46
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label46;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label46 = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00007CA0 File Offset: 0x000060A0
		// (set) Token: 0x06000071 RID: 113 RVA: 0x00007CB4 File Offset: 0x000060B4
		internal virtual Label Label36
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label36;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label36 = value;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00007CC0 File Offset: 0x000060C0
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00007CD4 File Offset: 0x000060D4
		internal virtual Label Label26
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label26;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label26 = value;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00007CE0 File Offset: 0x000060E0
		// (set) Token: 0x06000075 RID: 117 RVA: 0x00007CF4 File Offset: 0x000060F4
		internal virtual Label Label16
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label16;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label16 = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00007D00 File Offset: 0x00006100
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00007D14 File Offset: 0x00006114
		internal virtual Label Label45
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label45;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label45 = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00007D20 File Offset: 0x00006120
		// (set) Token: 0x06000079 RID: 121 RVA: 0x00007D34 File Offset: 0x00006134
		internal virtual Label Label35
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label35;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label35 = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00007D40 File Offset: 0x00006140
		// (set) Token: 0x0600007B RID: 123 RVA: 0x00007D54 File Offset: 0x00006154
		internal virtual Label Label25
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label25;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label25 = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00007D60 File Offset: 0x00006160
		// (set) Token: 0x0600007D RID: 125 RVA: 0x00007D74 File Offset: 0x00006174
		internal virtual Label Label15
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label15;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label15 = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00007D80 File Offset: 0x00006180
		// (set) Token: 0x0600007F RID: 127 RVA: 0x00007D94 File Offset: 0x00006194
		internal virtual Label Label44
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label44;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label44 = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00007DA0 File Offset: 0x000061A0
		// (set) Token: 0x06000081 RID: 129 RVA: 0x00007DB4 File Offset: 0x000061B4
		internal virtual Label Label34
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label34;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label34 = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00007DC0 File Offset: 0x000061C0
		// (set) Token: 0x06000083 RID: 131 RVA: 0x00007DD4 File Offset: 0x000061D4
		internal virtual Label Label24
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label24;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label24 = value;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00007DE0 File Offset: 0x000061E0
		// (set) Token: 0x06000085 RID: 133 RVA: 0x00007DF4 File Offset: 0x000061F4
		internal virtual Label Label14
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label14;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label14 = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00007E00 File Offset: 0x00006200
		// (set) Token: 0x06000087 RID: 135 RVA: 0x00007E14 File Offset: 0x00006214
		internal virtual Label Label43
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label43;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label43 = value;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00007E20 File Offset: 0x00006220
		// (set) Token: 0x06000089 RID: 137 RVA: 0x00007E34 File Offset: 0x00006234
		internal virtual Label Label33
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label33;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label33 = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00007E40 File Offset: 0x00006240
		// (set) Token: 0x0600008B RID: 139 RVA: 0x00007E54 File Offset: 0x00006254
		internal virtual Label Label23
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label23;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label23 = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00007E60 File Offset: 0x00006260
		// (set) Token: 0x0600008D RID: 141 RVA: 0x00007E74 File Offset: 0x00006274
		internal virtual Label Label13
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label13;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label13 = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00007E80 File Offset: 0x00006280
		// (set) Token: 0x0600008F RID: 143 RVA: 0x00007E94 File Offset: 0x00006294
		internal virtual Label Label52
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label52;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label52 = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00007EA0 File Offset: 0x000062A0
		// (set) Token: 0x06000091 RID: 145 RVA: 0x00007EB4 File Offset: 0x000062B4
		internal virtual Label Label42
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label42;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label42 = value;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00007EC0 File Offset: 0x000062C0
		// (set) Token: 0x06000093 RID: 147 RVA: 0x00007ED4 File Offset: 0x000062D4
		internal virtual Label Label32
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label32;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label32 = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00007EE0 File Offset: 0x000062E0
		// (set) Token: 0x06000095 RID: 149 RVA: 0x00007EF4 File Offset: 0x000062F4
		internal virtual Label Label22
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label22;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label22 = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00007F00 File Offset: 0x00006300
		// (set) Token: 0x06000097 RID: 151 RVA: 0x00007F14 File Offset: 0x00006314
		internal virtual Label Label12
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label12;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label12 = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00007F20 File Offset: 0x00006320
		// (set) Token: 0x06000099 RID: 153 RVA: 0x00007F34 File Offset: 0x00006334
		internal virtual Label Label51
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label51;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label51 = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00007F40 File Offset: 0x00006340
		// (set) Token: 0x0600009B RID: 155 RVA: 0x00007F54 File Offset: 0x00006354
		internal virtual Label Label41
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label41;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label41 = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00007F60 File Offset: 0x00006360
		// (set) Token: 0x0600009D RID: 157 RVA: 0x00007F74 File Offset: 0x00006374
		internal virtual Label Label31
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label31;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label31 = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00007F80 File Offset: 0x00006380
		// (set) Token: 0x0600009F RID: 159 RVA: 0x00007F94 File Offset: 0x00006394
		internal virtual Label Label21
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label21;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label21 = value;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00007FA0 File Offset: 0x000063A0
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x00007FB4 File Offset: 0x000063B4
		internal virtual Label Label11
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label11;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label11 = value;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00007FC0 File Offset: 0x000063C0
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x00007FD4 File Offset: 0x000063D4
		internal virtual TextBox WLBQTY
		{
			[DebuggerNonUserCode]
			get
			{
				return this._WLBQTY;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._WLBQTY = value;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00007FE0 File Offset: 0x000063E0
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x00007FF4 File Offset: 0x000063F4
		internal virtual TextBox SCMQTY
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SCMQTY;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SCMQTY = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x00008000 File Offset: 0x00006400
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x00008014 File Offset: 0x00006414
		internal virtual TextBox PURQTY
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PURQTY;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PURQTY = value;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00008020 File Offset: 0x00006420
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x00008034 File Offset: 0x00006434
		internal virtual TextBox INVQTY
		{
			[DebuggerNonUserCode]
			get
			{
				return this._INVQTY;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._INVQTY = value;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00008040 File Offset: 0x00006440
		// (set) Token: 0x060000AB RID: 171 RVA: 0x00008054 File Offset: 0x00006454
		internal virtual CheckBox WLB
		{
			[DebuggerNonUserCode]
			get
			{
				return this._WLB;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.BAS_CheckStateChanged);
				if (this._WLB != null)
				{
					this._WLB.CheckStateChanged -= value2;
				}
				this._WLB = value;
				if (this._WLB != null)
				{
					this._WLB.CheckStateChanged += value2;
				}
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000AC RID: 172 RVA: 0x000080A0 File Offset: 0x000064A0
		// (set) Token: 0x060000AD RID: 173 RVA: 0x000080B4 File Offset: 0x000064B4
		internal virtual CheckBox SCM
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SCM;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.BAS_CheckStateChanged);
				if (this._SCM != null)
				{
					this._SCM.CheckStateChanged -= value2;
				}
				this._SCM = value;
				if (this._SCM != null)
				{
					this._SCM.CheckStateChanged += value2;
				}
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00008100 File Offset: 0x00006500
		// (set) Token: 0x060000AF RID: 175 RVA: 0x00008114 File Offset: 0x00006514
		internal virtual CheckBox PUR
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PUR;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.BAS_CheckStateChanged);
				if (this._PUR != null)
				{
					this._PUR.CheckStateChanged -= value2;
				}
				this._PUR = value;
				if (this._PUR != null)
				{
					this._PUR.CheckStateChanged += value2;
				}
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00008160 File Offset: 0x00006560
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x00008174 File Offset: 0x00006574
		internal virtual CheckBox INV
		{
			[DebuggerNonUserCode]
			get
			{
				return this._INV;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.BAS_CheckStateChanged);
				if (this._INV != null)
				{
					this._INV.CheckStateChanged -= value2;
				}
				this._INV = value;
				if (this._INV != null)
				{
					this._INV.CheckStateChanged += value2;
				}
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x000081C0 File Offset: 0x000065C0
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x000081D4 File Offset: 0x000065D4
		internal virtual TextBox SYSQTY
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SYSQTY;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SYSQTY = value;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x000081E0 File Offset: 0x000065E0
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x000081F4 File Offset: 0x000065F4
		internal virtual TextBox RMAQTY
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RMAQTY;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RMAQTY = value;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x00008200 File Offset: 0x00006600
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x00008214 File Offset: 0x00006614
		internal virtual TextBox PJMQTY
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PJMQTY;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PJMQTY = value;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00008220 File Offset: 0x00006620
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x00008234 File Offset: 0x00006634
		internal virtual TextBox GZSQTY
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GZSQTY;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GZSQTY = value;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00008240 File Offset: 0x00006640
		// (set) Token: 0x060000BB RID: 187 RVA: 0x00008254 File Offset: 0x00006654
		internal virtual CheckBox SYS
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SYS;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.BAS_CheckStateChanged);
				if (this._SYS != null)
				{
					this._SYS.CheckStateChanged -= value2;
				}
				this._SYS = value;
				if (this._SYS != null)
				{
					this._SYS.CheckStateChanged += value2;
				}
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000BC RID: 188 RVA: 0x000082A0 File Offset: 0x000066A0
		// (set) Token: 0x060000BD RID: 189 RVA: 0x000082B4 File Offset: 0x000066B4
		internal virtual CheckBox RMA
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RMA;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.BAS_CheckStateChanged);
				if (this._RMA != null)
				{
					this._RMA.CheckStateChanged -= value2;
				}
				this._RMA = value;
				if (this._RMA != null)
				{
					this._RMA.CheckStateChanged += value2;
				}
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000BE RID: 190 RVA: 0x00008300 File Offset: 0x00006700
		// (set) Token: 0x060000BF RID: 191 RVA: 0x00008314 File Offset: 0x00006714
		internal virtual CheckBox PJM
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PJM;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.BAS_CheckStateChanged);
				if (this._PJM != null)
				{
					this._PJM.CheckStateChanged -= value2;
				}
				this._PJM = value;
				if (this._PJM != null)
				{
					this._PJM.CheckStateChanged += value2;
				}
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00008360 File Offset: 0x00006760
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x00008374 File Offset: 0x00006774
		internal virtual CheckBox GZS
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GZS;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.BAS_CheckStateChanged);
				if (this._GZS != null)
				{
					this._GZS.CheckStateChanged -= value2;
				}
				this._GZS = value;
				if (this._GZS != null)
				{
					this._GZS.CheckStateChanged += value2;
				}
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x000083C0 File Offset: 0x000067C0
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x000083D4 File Offset: 0x000067D4
		internal virtual TextBox ZCSQTY
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ZCSQTY;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ZCSQTY = value;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x000083E0 File Offset: 0x000067E0
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x000083F4 File Offset: 0x000067F4
		internal virtual TextBox SXMQTY
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SXMQTY;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SXMQTY = value;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x00008400 File Offset: 0x00006800
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x00008414 File Offset: 0x00006814
		internal virtual TextBox RGSQTY
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RGSQTY;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RGSQTY = value;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00008420 File Offset: 0x00006820
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x00008434 File Offset: 0x00006834
		internal virtual TextBox KJSQTY
		{
			[DebuggerNonUserCode]
			get
			{
				return this._KJSQTY;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._KJSQTY = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00008440 File Offset: 0x00006840
		// (set) Token: 0x060000CB RID: 203 RVA: 0x00008454 File Offset: 0x00006854
		internal virtual TextBox GYSQTY
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GYSQTY;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GYSQTY = value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00008460 File Offset: 0x00006860
		// (set) Token: 0x060000CD RID: 205 RVA: 0x00008474 File Offset: 0x00006874
		internal virtual CheckBox ZCS
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ZCS;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.BAS_CheckStateChanged);
				if (this._ZCS != null)
				{
					this._ZCS.CheckStateChanged -= value2;
				}
				this._ZCS = value;
				if (this._ZCS != null)
				{
					this._ZCS.CheckStateChanged += value2;
				}
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000CE RID: 206 RVA: 0x000084C0 File Offset: 0x000068C0
		// (set) Token: 0x060000CF RID: 207 RVA: 0x000084D4 File Offset: 0x000068D4
		internal virtual CheckBox RGS
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RGS;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.BAS_CheckStateChanged);
				if (this._RGS != null)
				{
					this._RGS.CheckStateChanged -= value2;
				}
				this._RGS = value;
				if (this._RGS != null)
				{
					this._RGS.CheckStateChanged += value2;
				}
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00008520 File Offset: 0x00006920
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x00008534 File Offset: 0x00006934
		internal virtual CheckBox KJS
		{
			[DebuggerNonUserCode]
			get
			{
				return this._KJS;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.BAS_CheckStateChanged);
				if (this._KJS != null)
				{
					this._KJS.CheckStateChanged -= value2;
				}
				this._KJS = value;
				if (this._KJS != null)
				{
					this._KJS.CheckStateChanged += value2;
				}
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00008580 File Offset: 0x00006980
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x00008594 File Offset: 0x00006994
		internal virtual CheckBox GYS
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GYS;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.BAS_CheckStateChanged);
				if (this._GYS != null)
				{
					this._GYS.CheckStateChanged -= value2;
				}
				this._GYS = value;
				if (this._GYS != null)
				{
					this._GYS.CheckStateChanged += value2;
				}
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x000085E0 File Offset: 0x000069E0
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x000085F4 File Offset: 0x000069F4
		internal virtual TextBox YSFQTY
		{
			[DebuggerNonUserCode]
			get
			{
				return this._YSFQTY;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._YSFQTY = value;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00008600 File Offset: 0x00006A00
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x00008614 File Offset: 0x00006A14
		internal virtual CheckBox YSF
		{
			[DebuggerNonUserCode]
			get
			{
				return this._YSF;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.BAS_CheckStateChanged);
				if (this._YSF != null)
				{
					this._YSF.CheckStateChanged -= value2;
				}
				this._YSF = value;
				if (this._YSF != null)
				{
					this._YSF.CheckStateChanged += value2;
				}
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00008660 File Offset: 0x00006A60
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x00008674 File Offset: 0x00006A74
		internal virtual TextBox SGMQTY
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SGMQTY;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SGMQTY = value;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060000DA RID: 218 RVA: 0x00008680 File Offset: 0x00006A80
		// (set) Token: 0x060000DB RID: 219 RVA: 0x00008694 File Offset: 0x00006A94
		internal virtual CheckBox SGM
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SGM;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.BAS_CheckStateChanged);
				if (this._SGM != null)
				{
					this._SGM.CheckStateChanged -= value2;
				}
				this._SGM = value;
				if (this._SGM != null)
				{
					this._SGM.CheckStateChanged += value2;
				}
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060000DC RID: 220 RVA: 0x000086E0 File Offset: 0x00006AE0
		// (set) Token: 0x060000DD RID: 221 RVA: 0x000086F4 File Offset: 0x00006AF4
		internal virtual TextBox QMSQTY
		{
			[DebuggerNonUserCode]
			get
			{
				return this._QMSQTY;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._QMSQTY = value;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00008700 File Offset: 0x00006B00
		// (set) Token: 0x060000DF RID: 223 RVA: 0x00008714 File Offset: 0x00006B14
		internal virtual CheckBox QMS
		{
			[DebuggerNonUserCode]
			get
			{
				return this._QMS;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.BAS_CheckStateChanged);
				if (this._QMS != null)
				{
					this._QMS.CheckStateChanged -= value2;
				}
				this._QMS = value;
				if (this._QMS != null)
				{
					this._QMS.CheckStateChanged += value2;
				}
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00008760 File Offset: 0x00006B60
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x00008774 File Offset: 0x00006B74
		internal virtual TextBox JCAQTY
		{
			[DebuggerNonUserCode]
			get
			{
				return this._JCAQTY;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._JCAQTY = value;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x00008780 File Offset: 0x00006B80
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x00008794 File Offset: 0x00006B94
		internal virtual CheckBox JCA
		{
			[DebuggerNonUserCode]
			get
			{
				return this._JCA;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.BAS_CheckStateChanged);
				if (this._JCA != null)
				{
					this._JCA.CheckStateChanged -= value2;
				}
				this._JCA = value;
				if (this._JCA != null)
				{
					this._JCA.CheckStateChanged += value2;
				}
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x000087E0 File Offset: 0x00006BE0
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x000087F4 File Offset: 0x00006BF4
		internal virtual TextBox FIBQTY
		{
			[DebuggerNonUserCode]
			get
			{
				return this._FIBQTY;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._FIBQTY = value;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00008800 File Offset: 0x00006C00
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x00008814 File Offset: 0x00006C14
		internal virtual CheckBox FIB
		{
			[DebuggerNonUserCode]
			get
			{
				return this._FIB;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.BAS_CheckStateChanged);
				if (this._FIB != null)
				{
					this._FIB.CheckStateChanged -= value2;
				}
				this._FIB = value;
				if (this._FIB != null)
				{
					this._FIB.CheckStateChanged += value2;
				}
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00008860 File Offset: 0x00006C60
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x00008874 File Offset: 0x00006C74
		internal virtual TextBox REGSTR
		{
			[DebuggerNonUserCode]
			get
			{
				return this._REGSTR;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._REGSTR = value;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00008880 File Offset: 0x00006C80
		// (set) Token: 0x060000EB RID: 235 RVA: 0x00008894 File Offset: 0x00006C94
		internal virtual Label Label61
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label61;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label61 = value;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060000EC RID: 236 RVA: 0x000088A0 File Offset: 0x00006CA0
		// (set) Token: 0x060000ED RID: 237 RVA: 0x000088B4 File Offset: 0x00006CB4
		internal virtual Label Label62
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label62;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label62 = value;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060000EE RID: 238 RVA: 0x000088C0 File Offset: 0x00006CC0
		// (set) Token: 0x060000EF RID: 239 RVA: 0x000088D4 File Offset: 0x00006CD4
		internal virtual TextBox PW
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PW;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PW = value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x000088E0 File Offset: 0x00006CE0
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x000088F4 File Offset: 0x00006CF4
		internal virtual Label Label63
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label63;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label63 = value;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00008900 File Offset: 0x00006D00
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x00008914 File Offset: 0x00006D14
		internal virtual Label Label64
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label64;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label64 = value;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x00008920 File Offset: 0x00006D20
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x00008934 File Offset: 0x00006D34
		internal virtual Label Label54
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label54;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label54 = value;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x00008940 File Offset: 0x00006D40
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x00008954 File Offset: 0x00006D54
		internal virtual Label Label53
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label53;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label53 = value;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x00008960 File Offset: 0x00006D60
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x00008974 File Offset: 0x00006D74
		internal virtual TextBox ALLQTY
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ALLQTY;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ALLQTY = value;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060000FA RID: 250 RVA: 0x00008980 File Offset: 0x00006D80
		// (set) Token: 0x060000FB RID: 251 RVA: 0x00008994 File Offset: 0x00006D94
		internal virtual CheckBox ALL
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ALL;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ALL_CheckStateChanged);
				if (this._ALL != null)
				{
					this._ALL.CheckStateChanged -= value2;
				}
				this._ALL = value;
				if (this._ALL != null)
				{
					this._ALL.CheckStateChanged += value2;
				}
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060000FC RID: 252 RVA: 0x000089E0 File Offset: 0x00006DE0
		// (set) Token: 0x060000FD RID: 253 RVA: 0x000089F4 File Offset: 0x00006DF4
		internal virtual CheckBox CWB
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CWB;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.BAS_CheckStateChanged);
				if (this._CWB != null)
				{
					this._CWB.CheckStateChanged -= value2;
				}
				this._CWB = value;
				if (this._CWB != null)
				{
					this._CWB.CheckStateChanged += value2;
				}
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060000FE RID: 254 RVA: 0x00008A40 File Offset: 0x00006E40
		// (set) Token: 0x060000FF RID: 255 RVA: 0x00008A54 File Offset: 0x00006E54
		internal virtual ToolTip ToolTip1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolTip1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolTip1 = value;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00008A60 File Offset: 0x00006E60
		// (set) Token: 0x06000101 RID: 257 RVA: 0x00008A74 File Offset: 0x00006E74
		internal virtual CheckBox SXM
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SXM;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.BAS_CheckStateChanged);
				if (this._SXM != null)
				{
					this._SXM.CheckStateChanged -= value2;
				}
				this._SXM = value;
				if (this._SXM != null)
				{
					this._SXM.CheckStateChanged += value2;
				}
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000102 RID: 258 RVA: 0x00008AC0 File Offset: 0x00006EC0
		// (set) Token: 0x06000103 RID: 259 RVA: 0x00008AD4 File Offset: 0x00006ED4
		internal virtual Label Label55
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label55;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label55 = value;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000104 RID: 260 RVA: 0x00008AE0 File Offset: 0x00006EE0
		// (set) Token: 0x06000105 RID: 261 RVA: 0x00008AF4 File Offset: 0x00006EF4
		internal virtual TextBox CCode
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CCode;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CCode = value;
			}
		}

		// Token: 0x06000106 RID: 262
		private void Button1_Click(object sender, EventArgs e)
		{
			string text = this.CCode.Text;
			string text2 = "@@@2";
			string text3 = "";
			string qty = this.GetQty();
			string fn = this.GetFn();
			string fnAndQty = this.GetFnAndQty();
			string text4 = "%%%" + this.GetROL(this.REGSTR.Text);
			if (Operators.CompareString(this.SN.Text, null, false) == 0)
			{
				MessageBox.Show("请输入安装代号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			if (Operators.CompareString(this.CCode.Text, null, false) == 0)
			{
				MessageBox.Show("请输入客户代号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			checked
			{
				if (this.ALL.Checked)
				{
					string[] array = new string[]
					{
						null,
						text,
						qty,
						fn,
						text2,
						text4
					};
					int num = 1;
					do
					{
						if (num % 2 != 0)
						{
							text3 += Strings.Left(array[num], 1);
						}
						else
						{
							text3 += Strings.Right(array[num], 1);
						}
						num++;
					}
					while (num <= 5);
				}
				else
				{
					string[] array2 = new string[]
					{
						null,
						text,
						qty,
						fn,
						fnAndQty,
						text2,
						text4
					};
					int num2 = 1;
					do
					{
						if (num2 % 2 != 0)
						{
							text3 += Strings.Left(array2[num2], 1);
						}
						else
						{
							text3 += Strings.Right(array2[num2], 1);
						}
						num2++;
					}
					while (num2 <= 6);
				}
				text3 = this.GetROL(text3);
				text3 = this.getMd5Hash(string.Concat(new string[]
				{
					text,
					qty,
					fn,
					fnAndQty,
					text2,
					text4,
					text3
				}));
				string text5 = Strings.Left(text3, 8);
				if (this.ALL.Checked)
				{
					this.KEY.Text = string.Concat(new string[]
					{
						text,
						"-",
						qty,
						"-",
						fn,
						"-",
						text2,
						"-",
						text4,
						"-",
						text5
					});
				}
				else
				{
					this.KEY.Text = string.Concat(new string[]
					{
						text,
						"-",
						qty,
						"-",
						fn,
						"-",
						fnAndQty,
						"-",
						text2,
						"-",
						text4,
						"-",
						text5
					});
				}
				text3 = null;
				if (this.ALL.Checked)
				{
					string[] array3 = new string[]
					{
						null,
						text,
						qty,
						fn,
						text2,
						text4,
						text5,
						this.SN.Text.Trim()
					};
					int num3 = 1;
					do
					{
						if (num3 % 2 != 0)
						{
							text3 += Strings.Left(array3[num3], 1);
						}
						else
						{
							text3 += Strings.Right(array3[num3], 1);
						}
						num3++;
					}
					while (num3 <= 7);
				}
				else
				{
					string[] array4 = new string[]
					{
						null,
						text,
						qty,
						fn,
						fnAndQty,
						text2,
						text4,
						text5,
						this.SN.Text.Trim()
					};
					int num4 = 1;
					do
					{
						if (num4 % 2 != 0)
						{
							text3 += Strings.Left(array4[num4], 1);
						}
						else
						{
							text3 += Strings.Right(array4[num4], 1);
						}
						num4++;
					}
					while (num4 <= 8);
				}
				text3 = this.GetROL(text3);
				text3 = this.getMd5Hash(string.Concat(new string[]
				{
					text,
					qty,
					fn,
					fnAndQty,
					text2,
					text4,
					text5,
					this.SN.Text.Trim(),
					text3
				}));
				this.PW.Text = Strings.Mid(text3, 9, 8);
			}
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00008F68 File Offset: 0x00007368
		public string GetROL(string str)
		{
			string text = "";
			byte[] bytes = Encoding.Default.GetBytes(str);
			int num = 1;
			int num2 = bytes.Length;
			checked
			{
				for (int i = num; i <= num2; i++)
				{
					string text2 = this.d_to_b((int)bytes[i - 1]);
					text2 = Strings.StrDup(8 - text2.Length, "0") + text2;
					if (i < 8)
					{
						string str2 = Strings.Right(text2, i);
						text2 = str2 + Strings.Left(text2, 8 - i);
						text += this.b_to_h(text2).ToUpper();
					}
					else if (i > 8)
					{
						string str2 = Strings.Right(text2, i % 8);
						text2 = str2 + Strings.Left(text2, 8 - i % 8);
						text += this.b_to_h(text2).ToUpper();
					}
					else
					{
						text += this.b_to_h(text2).ToUpper();
					}
				}
				return text;
			}
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00009050 File Offset: 0x00007450
		public string GetQty()
		{
			if (this.ALL.Checked)
			{
				return Strings.Format(Conversion.Val(this.ALLQTY.Text), "00");
			}
			return Strings.Format(Conversion.Val(this.BASQTY.Text) + Conversion.Val(this.COPQTY.Text) + Conversion.Val(this.CRMQTY.Text) + Conversion.Val(this.CWBQTY.Text) + Conversion.Val(this.FIBQTY.Text) + Conversion.Val(this.GYSQTY.Text) + Conversion.Val(this.GZSQTY.Text) + Conversion.Val(this.INVQTY.Text) + Conversion.Val(this.JCAQTY.Text) + Conversion.Val(this.KJSQTY.Text) + Conversion.Val(this.PJMQTY.Text) + Conversion.Val(this.PURQTY.Text) + Conversion.Val(this.QMSQTY.Text) + Conversion.Val(this.RGSQTY.Text) + Conversion.Val(this.RMAQTY.Text) + Conversion.Val(this.SCMQTY.Text) + Conversion.Val(this.SGMQTY.Text) + Conversion.Val(this.SXMQTY.Text) + Conversion.Val(this.SYSQTY.Text) + Conversion.Val(this.WLBQTY.Text) + Conversion.Val(this.YSFQTY.Text) + Conversion.Val(this.ZCSQTY.Text), "00");
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00009210 File Offset: 0x00007610
		public string GetFnAndQty()
		{
			string text = "";
			char[] array = Conversions.ToCharArrayRankOne("mjpdruebwynkatqf~!@#$%^&*(){}=+?");
			if (this.ALL.Checked)
			{
				return "";
			}
			if (this.YSF.Checked)
			{
				text = text + Conversions.ToString(array[2]) + Strings.Format(Conversion.Val(this.YSFQTY.Text), "00");
			}
			if (this.PJM.Checked)
			{
				text = text + Conversions.ToString(array[3]) + Strings.Format(Conversion.Val(this.PJMQTY.Text), "00");
			}
			if (this.KJS.Checked)
			{
				text = text + Conversions.ToString(array[4]) + Strings.Format(Conversion.Val(this.KJSQTY.Text), "00");
			}
			if (this.RGS.Checked)
			{
				text = text + Conversions.ToString(array[5]) + Strings.Format(Conversion.Val(this.RGSQTY.Text), "00");
			}
			if (this.SGM.Checked)
			{
				text = text + Conversions.ToString(array[6]) + Strings.Format(Conversion.Val(this.SGMQTY.Text), "00");
			}
			if (this.CRM.Checked)
			{
				text = text + Conversions.ToString(array[7]) + Strings.Format(Conversion.Val(this.CRMQTY.Text), "00");
			}
			if (this.GZS.Checked)
			{
				text = text + Conversions.ToString(array[8]) + Strings.Format(Conversion.Val(this.GZSQTY.Text), "00");
			}
			if (this.ZCS.Checked)
			{
				text = text + Conversions.ToString(array[9]) + Strings.Format(Conversion.Val(this.ZCSQTY.Text), "00");
			}
			if (this.SXM.Checked)
			{
				text = text + Conversions.ToString(array[10]) + Strings.Format(Conversion.Val(this.SXMQTY.Text), "00");
			}
			if (this.SCM.Checked)
			{
				text = text + Conversions.ToString(array[11]) + Strings.Format(Conversion.Val(this.SCMQTY.Text), "00");
			}
			if (this.GYS.Checked)
			{
				text = text + Conversions.ToString(array[12]) + Strings.Format(Conversion.Val(this.GYSQTY.Text), "00");
			}
			if (this.JCA.Checked)
			{
				text = text + Conversions.ToString(array[13]) + Strings.Format(Conversion.Val(this.JCAQTY.Text), "00");
			}
			if (this.CWB.Checked)
			{
				text = text + Conversions.ToString(array[14]) + Strings.Format(Conversion.Val(this.CWBQTY.Text), "00");
			}
			if (this.COP.Checked)
			{
				text = text + Conversions.ToString(array[15]) + Strings.Format(Conversion.Val(this.COPQTY.Text), "00");
			}
			if (this.PUR.Checked)
			{
				text = text + Conversions.ToString(array[16]) + Strings.Format(Conversion.Val(this.PURQTY.Text), "00");
			}
			if (this.INV.Checked)
			{
				text = text + Conversions.ToString(array[17]) + Strings.Format(Conversion.Val(this.INVQTY.Text), "00");
			}
			if (this.WLB.Checked)
			{
				text = text + Conversions.ToString(array[18]) + Strings.Format(Conversion.Val(this.WLBQTY.Text), "00");
			}
			if (this.FIB.Checked)
			{
				text = text + Conversions.ToString(array[19]) + Strings.Format(Conversion.Val(this.FIBQTY.Text), "00");
			}
			if (this.SYS.Checked)
			{
				text = text + Conversions.ToString(array[20]) + Strings.Format(Conversion.Val(this.SYSQTY.Text), "00");
			}
			if (this.BAS.Checked)
			{
				text = text + Conversions.ToString(array[21]) + Strings.Format(Conversion.Val(this.BASQTY.Text), "00");
			}
			if (this.QMS.Checked)
			{
				text = text + Conversions.ToString(array[22]) + Strings.Format(Conversion.Val(this.QMSQTY.Text), "00");
			}
			if (this.RMA.Checked)
			{
				text = text + Conversions.ToString(array[23]) + Strings.Format(Conversion.Val(this.RMAQTY.Text), "00");
			}
			return text;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00009764 File Offset: 0x00007B64
		public string GetFn()
		{
			char[] array = Conversions.ToCharArrayRankOne("00000000000000000000000000000000");
			if (this.ALL.Checked)
			{
				return "ffffffff";
			}
			if (this.YSF.Checked)
			{
				array[2] = '1';
			}
			if (this.PJM.Checked)
			{
				array[3] = '1';
			}
			if (this.KJS.Checked)
			{
				array[4] = '1';
			}
			if (this.RGS.Checked)
			{
				array[5] = '1';
			}
			if (this.SGM.Checked)
			{
				array[6] = '1';
			}
			if (this.CRM.Checked)
			{
				array[7] = '1';
			}
			if (this.GZS.Checked)
			{
				array[8] = '1';
			}
			if (this.ZCS.Checked)
			{
				array[9] = '1';
			}
			if (this.SXM.Checked)
			{
				array[10] = '1';
			}
			if (this.SCM.Checked)
			{
				array[11] = '1';
			}
			if (this.GYS.Checked)
			{
				array[12] = '1';
			}
			if (this.JCA.Checked)
			{
				array[13] = '1';
			}
			if (this.CWB.Checked)
			{
				array[14] = '1';
			}
			if (this.COP.Checked)
			{
				array[15] = '1';
			}
			if (this.PUR.Checked)
			{
				array[16] = '1';
			}
			if (this.INV.Checked)
			{
				array[17] = '1';
			}
			if (this.WLB.Checked)
			{
				array[18] = '1';
			}
			if (this.FIB.Checked)
			{
				array[19] = '1';
			}
			if (this.SYS.Checked)
			{
				array[20] = '1';
			}
			if (this.BAS.Checked)
			{
				array[21] = '1';
			}
			if (this.QMS.Checked)
			{
				array[22] = '1';
			}
			if (this.RMA.Checked)
			{
				array[23] = '1';
			}
			return this.b_to_h(new string(array));
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00009938 File Offset: 0x00007D38
		public string d_to_b(int dec)
		{
			string text = null;
			do
			{
				text = Conversions.ToString(dec % 2) + text;
				dec /= 2;
			}
			while (dec != 0);
			return text;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00009964 File Offset: 0x00007D64
		public string h_to_b(string hex)
		{
			string text = null;
			hex = Strings.UCase(hex);
			int num = 1;
			int num2 = Strings.Len(hex);
			checked
			{
				for (int i = num; i <= num2; i++)
				{
					string left = Strings.Mid(hex, i, 1);
					if (Operators.CompareString(left, "0", false) == 0)
					{
						text += "0000";
					}
					else if (Operators.CompareString(left, "1", false) == 0)
					{
						text += "0001";
					}
					else if (Operators.CompareString(left, "2", false) == 0)
					{
						text += "0010";
					}
					else if (Operators.CompareString(left, "3", false) == 0)
					{
						text += "0011";
					}
					else if (Operators.CompareString(left, "4", false) == 0)
					{
						text += "0100";
					}
					else if (Operators.CompareString(left, "5", false) == 0)
					{
						text += "0101";
					}
					else if (Operators.CompareString(left, "6", false) == 0)
					{
						text += "0110";
					}
					else if (Operators.CompareString(left, "7", false) == 0)
					{
						text += "0111";
					}
					else if (Operators.CompareString(left, "8", false) == 0)
					{
						text += "1000";
					}
					else if (Operators.CompareString(left, "9", false) == 0)
					{
						text += "1001";
					}
					else if (Operators.CompareString(left, "a", false) == 0)
					{
						text += "1010";
					}
					else if (Operators.CompareString(left, "b", false) == 0)
					{
						text += "1011";
					}
					else if (Operators.CompareString(left, "c", false) == 0)
					{
						text += "1100";
					}
					else if (Operators.CompareString(left, "d", false) == 0)
					{
						text += "1101";
					}
					else if (Operators.CompareString(left, "e", false) == 0)
					{
						text += "1110";
					}
					else if (Operators.CompareString(left, "f", false) == 0)
					{
						text += "1111";
					}
				}
				return text;
			}
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00009BA0 File Offset: 0x00007FA0
		public string b_to_h(string bin)
		{
			string text = null;
			checked
			{
				if (Strings.Len(bin) % 4 != 0)
				{
					bin = Strings.StrDup(4 - Strings.Len(bin) % 4, "0") + bin;
				}
				int num = 1;
				int num2 = Strings.Len(bin);
				for (int i = num; i <= num2; i += 4)
				{
					string left = Strings.Mid(bin, i, 4);
					if (Operators.CompareString(left, "0000", false) == 0)
					{
						text += "0";
					}
					else if (Operators.CompareString(left, "0001", false) == 0)
					{
						text += "1";
					}
					else if (Operators.CompareString(left, "0010", false) == 0)
					{
						text += "2";
					}
					else if (Operators.CompareString(left, "0011", false) == 0)
					{
						text += "3";
					}
					else if (Operators.CompareString(left, "0100", false) == 0)
					{
						text += "4";
					}
					else if (Operators.CompareString(left, "0101", false) == 0)
					{
						text += "5";
					}
					else if (Operators.CompareString(left, "0110", false) == 0)
					{
						text += "6";
					}
					else if (Operators.CompareString(left, "0111", false) == 0)
					{
						text += "7";
					}
					else if (Operators.CompareString(left, "1000", false) == 0)
					{
						text += "8";
					}
					else if (Operators.CompareString(left, "1001", false) == 0)
					{
						text += "9";
					}
					else if (Operators.CompareString(left, "1010", false) == 0)
					{
						text += "a";
					}
					else if (Operators.CompareString(left, "1011", false) == 0)
					{
						text += "b";
					}
					else if (Operators.CompareString(left, "1100", false) == 0)
					{
						text += "c";
					}
					else if (Operators.CompareString(left, "1101", false) == 0)
					{
						text += "d";
					}
					else if (Operators.CompareString(left, "1110", false) == 0)
					{
						text += "e";
					}
					else if (Operators.CompareString(left, "1111", false) == 0)
					{
						text += "f";
					}
				}
				return text;
			}
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00009DFC File Offset: 0x000081FC
		public string getMd5Hash(string input)
		{
			MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
			byte[] array = md5CryptoServiceProvider.ComputeHash(Encoding.Default.GetBytes(input));
			StringBuilder stringBuilder = new StringBuilder();
			int num = 0;
			checked
			{
				int num2 = array.Length - 1;
				for (int i = num; i <= num2; i++)
				{
					stringBuilder.Append(array[i].ToString("x2"));
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00009E5C File Offset: 0x0000825C
		public string StrEncrypt(string input, bool ror)
		{
			byte b = Conversions.ToByte(input.Trim());
			return "";
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00009E7C File Offset: 0x0000827C
		private void ALL_CheckStateChanged(object sender, EventArgs e)
		{
			if (Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null)))
			{
				this.BAS.Checked = false;
				this.COP.Checked = false;
				this.CRM.Checked = false;
				this.CWB.Checked = false;
				this.FIB.Checked = false;
				this.GYS.Checked = false;
				this.GZS.Checked = false;
				this.INV.Checked = false;
				this.JCA.Checked = false;
				this.KJS.Checked = false;
				this.PJM.Checked = false;
				this.PUR.Checked = false;
				this.QMS.Checked = false;
				this.RGS.Checked = false;
				this.RMA.Checked = false;
				this.SCM.Checked = false;
				this.SGM.Checked = false;
				this.SXM.Checked = false;
				this.SYS.Checked = false;
				this.WLB.Checked = false;
				this.YSF.Checked = false;
				this.ZCS.Checked = false;
			}
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00009FB0 File Offset: 0x000083B0
		private void BAS_CheckStateChanged(object sender, EventArgs e)
		{
			if (Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null)))
			{
				this.ALL.Checked = false;
			}
		}

		// Token: 0x0400000A RID: 10
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x0400000B RID: 11
		[AccessedThroughProperty("SN")]
		private TextBox _SN;

		// Token: 0x0400000C RID: 12
		[AccessedThroughProperty("KEY")]
		private TextBox _KEY;

		// Token: 0x0400000D RID: 13
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		// Token: 0x0400000E RID: 14
		[AccessedThroughProperty("BAS")]
		private CheckBox _BAS;

		// Token: 0x0400000F RID: 15
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x04000010 RID: 16
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x04000011 RID: 17
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x04000012 RID: 18
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000013 RID: 19
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000014 RID: 20
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x04000015 RID: 21
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x04000016 RID: 22
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x04000017 RID: 23
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000018 RID: 24
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000019 RID: 25
		[AccessedThroughProperty("CWBQTY")]
		private TextBox _CWBQTY;

		// Token: 0x0400001A RID: 26
		[AccessedThroughProperty("CRMQTY")]
		private TextBox _CRMQTY;

		// Token: 0x0400001B RID: 27
		[AccessedThroughProperty("CRM")]
		private CheckBox _CRM;

		// Token: 0x0400001C RID: 28
		[AccessedThroughProperty("COPQTY")]
		private TextBox _COPQTY;

		// Token: 0x0400001D RID: 29
		[AccessedThroughProperty("COP")]
		private CheckBox _COP;

		// Token: 0x0400001E RID: 30
		[AccessedThroughProperty("BASQTY")]
		private TextBox _BASQTY;

		// Token: 0x0400001F RID: 31
		[AccessedThroughProperty("Label50")]
		private Label _Label50;

		// Token: 0x04000020 RID: 32
		[AccessedThroughProperty("Label40")]
		private Label _Label40;

		// Token: 0x04000021 RID: 33
		[AccessedThroughProperty("Label30")]
		private Label _Label30;

		// Token: 0x04000022 RID: 34
		[AccessedThroughProperty("Label20")]
		private Label _Label20;

		// Token: 0x04000023 RID: 35
		[AccessedThroughProperty("Label49")]
		private Label _Label49;

		// Token: 0x04000024 RID: 36
		[AccessedThroughProperty("Label39")]
		private Label _Label39;

		// Token: 0x04000025 RID: 37
		[AccessedThroughProperty("Label29")]
		private Label _Label29;

		// Token: 0x04000026 RID: 38
		[AccessedThroughProperty("Label19")]
		private Label _Label19;

		// Token: 0x04000027 RID: 39
		[AccessedThroughProperty("Label48")]
		private Label _Label48;

		// Token: 0x04000028 RID: 40
		[AccessedThroughProperty("Label38")]
		private Label _Label38;

		// Token: 0x04000029 RID: 41
		[AccessedThroughProperty("Label28")]
		private Label _Label28;

		// Token: 0x0400002A RID: 42
		[AccessedThroughProperty("Label18")]
		private Label _Label18;

		// Token: 0x0400002B RID: 43
		[AccessedThroughProperty("Label57")]
		private Label _Label57;

		// Token: 0x0400002C RID: 44
		[AccessedThroughProperty("Label47")]
		private Label _Label47;

		// Token: 0x0400002D RID: 45
		[AccessedThroughProperty("Label37")]
		private Label _Label37;

		// Token: 0x0400002E RID: 46
		[AccessedThroughProperty("Label27")]
		private Label _Label27;

		// Token: 0x0400002F RID: 47
		[AccessedThroughProperty("Label17")]
		private Label _Label17;

		// Token: 0x04000030 RID: 48
		[AccessedThroughProperty("Label56")]
		private Label _Label56;

		// Token: 0x04000031 RID: 49
		[AccessedThroughProperty("Label46")]
		private Label _Label46;

		// Token: 0x04000032 RID: 50
		[AccessedThroughProperty("Label36")]
		private Label _Label36;

		// Token: 0x04000033 RID: 51
		[AccessedThroughProperty("Label26")]
		private Label _Label26;

		// Token: 0x04000034 RID: 52
		[AccessedThroughProperty("Label16")]
		private Label _Label16;

		// Token: 0x04000035 RID: 53
		[AccessedThroughProperty("Label45")]
		private Label _Label45;

		// Token: 0x04000036 RID: 54
		[AccessedThroughProperty("Label35")]
		private Label _Label35;

		// Token: 0x04000037 RID: 55
		[AccessedThroughProperty("Label25")]
		private Label _Label25;

		// Token: 0x04000038 RID: 56
		[AccessedThroughProperty("Label15")]
		private Label _Label15;

		// Token: 0x04000039 RID: 57
		[AccessedThroughProperty("Label44")]
		private Label _Label44;

		// Token: 0x0400003A RID: 58
		[AccessedThroughProperty("Label34")]
		private Label _Label34;

		// Token: 0x0400003B RID: 59
		[AccessedThroughProperty("Label24")]
		private Label _Label24;

		// Token: 0x0400003C RID: 60
		[AccessedThroughProperty("Label14")]
		private Label _Label14;

		// Token: 0x0400003D RID: 61
		[AccessedThroughProperty("Label43")]
		private Label _Label43;

		// Token: 0x0400003E RID: 62
		[AccessedThroughProperty("Label33")]
		private Label _Label33;

		// Token: 0x0400003F RID: 63
		[AccessedThroughProperty("Label23")]
		private Label _Label23;

		// Token: 0x04000040 RID: 64
		[AccessedThroughProperty("Label13")]
		private Label _Label13;

		// Token: 0x04000041 RID: 65
		[AccessedThroughProperty("Label52")]
		private Label _Label52;

		// Token: 0x04000042 RID: 66
		[AccessedThroughProperty("Label42")]
		private Label _Label42;

		// Token: 0x04000043 RID: 67
		[AccessedThroughProperty("Label32")]
		private Label _Label32;

		// Token: 0x04000044 RID: 68
		[AccessedThroughProperty("Label22")]
		private Label _Label22;

		// Token: 0x04000045 RID: 69
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		// Token: 0x04000046 RID: 70
		[AccessedThroughProperty("Label51")]
		private Label _Label51;

		// Token: 0x04000047 RID: 71
		[AccessedThroughProperty("Label41")]
		private Label _Label41;

		// Token: 0x04000048 RID: 72
		[AccessedThroughProperty("Label31")]
		private Label _Label31;

		// Token: 0x04000049 RID: 73
		[AccessedThroughProperty("Label21")]
		private Label _Label21;

		// Token: 0x0400004A RID: 74
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		// Token: 0x0400004B RID: 75
		[AccessedThroughProperty("WLBQTY")]
		private TextBox _WLBQTY;

		// Token: 0x0400004C RID: 76
		[AccessedThroughProperty("SCMQTY")]
		private TextBox _SCMQTY;

		// Token: 0x0400004D RID: 77
		[AccessedThroughProperty("PURQTY")]
		private TextBox _PURQTY;

		// Token: 0x0400004E RID: 78
		[AccessedThroughProperty("INVQTY")]
		private TextBox _INVQTY;

		// Token: 0x0400004F RID: 79
		[AccessedThroughProperty("WLB")]
		private CheckBox _WLB;

		// Token: 0x04000050 RID: 80
		[AccessedThroughProperty("SCM")]
		private CheckBox _SCM;

		// Token: 0x04000051 RID: 81
		[AccessedThroughProperty("PUR")]
		private CheckBox _PUR;

		// Token: 0x04000052 RID: 82
		[AccessedThroughProperty("INV")]
		private CheckBox _INV;

		// Token: 0x04000053 RID: 83
		[AccessedThroughProperty("SYSQTY")]
		private TextBox _SYSQTY;

		// Token: 0x04000054 RID: 84
		[AccessedThroughProperty("RMAQTY")]
		private TextBox _RMAQTY;

		// Token: 0x04000055 RID: 85
		[AccessedThroughProperty("PJMQTY")]
		private TextBox _PJMQTY;

		// Token: 0x04000056 RID: 86
		[AccessedThroughProperty("GZSQTY")]
		private TextBox _GZSQTY;

		// Token: 0x04000057 RID: 87
		[AccessedThroughProperty("SYS")]
		private CheckBox _SYS;

		// Token: 0x04000058 RID: 88
		[AccessedThroughProperty("RMA")]
		private CheckBox _RMA;

		// Token: 0x04000059 RID: 89
		[AccessedThroughProperty("PJM")]
		private CheckBox _PJM;

		// Token: 0x0400005A RID: 90
		[AccessedThroughProperty("GZS")]
		private CheckBox _GZS;

		// Token: 0x0400005B RID: 91
		[AccessedThroughProperty("ZCSQTY")]
		private TextBox _ZCSQTY;

		// Token: 0x0400005C RID: 92
		[AccessedThroughProperty("SXMQTY")]
		private TextBox _SXMQTY;

		// Token: 0x0400005D RID: 93
		[AccessedThroughProperty("RGSQTY")]
		private TextBox _RGSQTY;

		// Token: 0x0400005E RID: 94
		[AccessedThroughProperty("KJSQTY")]
		private TextBox _KJSQTY;

		// Token: 0x0400005F RID: 95
		[AccessedThroughProperty("GYSQTY")]
		private TextBox _GYSQTY;

		// Token: 0x04000060 RID: 96
		[AccessedThroughProperty("ZCS")]
		private CheckBox _ZCS;

		// Token: 0x04000061 RID: 97
		[AccessedThroughProperty("RGS")]
		private CheckBox _RGS;

		// Token: 0x04000062 RID: 98
		[AccessedThroughProperty("KJS")]
		private CheckBox _KJS;

		// Token: 0x04000063 RID: 99
		[AccessedThroughProperty("GYS")]
		private CheckBox _GYS;

		// Token: 0x04000064 RID: 100
		[AccessedThroughProperty("YSFQTY")]
		private TextBox _YSFQTY;

		// Token: 0x04000065 RID: 101
		[AccessedThroughProperty("YSF")]
		private CheckBox _YSF;

		// Token: 0x04000066 RID: 102
		[AccessedThroughProperty("SGMQTY")]
		private TextBox _SGMQTY;

		// Token: 0x04000067 RID: 103
		[AccessedThroughProperty("SGM")]
		private CheckBox _SGM;

		// Token: 0x04000068 RID: 104
		[AccessedThroughProperty("QMSQTY")]
		private TextBox _QMSQTY;

		// Token: 0x04000069 RID: 105
		[AccessedThroughProperty("QMS")]
		private CheckBox _QMS;

		// Token: 0x0400006A RID: 106
		[AccessedThroughProperty("JCAQTY")]
		private TextBox _JCAQTY;

		// Token: 0x0400006B RID: 107
		[AccessedThroughProperty("JCA")]
		private CheckBox _JCA;

		// Token: 0x0400006C RID: 108
		[AccessedThroughProperty("FIBQTY")]
		private TextBox _FIBQTY;

		// Token: 0x0400006D RID: 109
		[AccessedThroughProperty("FIB")]
		private CheckBox _FIB;

		// Token: 0x0400006E RID: 110
		[AccessedThroughProperty("REGSTR")]
		private TextBox _REGSTR;

		// Token: 0x0400006F RID: 111
		[AccessedThroughProperty("Label61")]
		private Label _Label61;

		// Token: 0x04000070 RID: 112
		[AccessedThroughProperty("Label62")]
		private Label _Label62;

		// Token: 0x04000071 RID: 113
		[AccessedThroughProperty("PW")]
		private TextBox _PW;

		// Token: 0x04000072 RID: 114
		[AccessedThroughProperty("Label63")]
		private Label _Label63;

		// Token: 0x04000073 RID: 115
		[AccessedThroughProperty("Label64")]
		private Label _Label64;

		// Token: 0x04000074 RID: 116
		[AccessedThroughProperty("Label54")]
		private Label _Label54;

		// Token: 0x04000075 RID: 117
		[AccessedThroughProperty("Label53")]
		private Label _Label53;

		// Token: 0x04000076 RID: 118
		[AccessedThroughProperty("ALLQTY")]
		private TextBox _ALLQTY;

		// Token: 0x04000077 RID: 119
		[AccessedThroughProperty("ALL")]
		private CheckBox _ALL;

		// Token: 0x04000078 RID: 120
		[AccessedThroughProperty("CWB")]
		private CheckBox _CWB;

		// Token: 0x04000079 RID: 121
		[AccessedThroughProperty("ToolTip1")]
		private ToolTip _ToolTip1;

		// Token: 0x0400007A RID: 122
		[AccessedThroughProperty("SXM")]
		private CheckBox _SXM;

		// Token: 0x0400007B RID: 123
		[AccessedThroughProperty("Label55")]
		private Label _Label55;

		// Token: 0x0400007C RID: 124
		[AccessedThroughProperty("CCode")]
		private TextBox _CCode;
	}
}
