using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsApplication1.My.Resources
{
	// Token: 0x02000009 RID: 9
	[StandardModule]
	[CompilerGenerated]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
	[DebuggerNonUserCode]
	[HideModuleName]
	internal sealed class Resources
	{
		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000112 RID: 274 RVA: 0x000021C0 File Offset: 0x000005C0
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(Resources.resourceMan, null))
				{
					ResourceManager resourceManager = new ResourceManager("WindowsApplication1.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000113 RID: 275 RVA: 0x00002200 File Offset: 0x00000600
		// (set) Token: 0x06000114 RID: 276 RVA: 0x00002214 File Offset: 0x00000614
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x0400007D RID: 125
		private static ResourceManager resourceMan;

		// Token: 0x0400007E RID: 126
		private static CultureInfo resourceCulture;
	}
}
