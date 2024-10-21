using System;
using System.Collections.Generic;
using UnityEngine;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x020002B7 RID: 695
	[Serializable]
	public class LanguageData : LanguageDataBase
	{
		// Token: 0x06001E0F RID: 7695 RVA: 0x00016C42 File Offset: 0x00014E42
		public override void Initialize()
		{
			if (this._initialized)
			{
				return;
			}
			this.customDict = LanguageData.CustomEntry.ToDictionary(this._customEntries);
			this._initialized = true;
		}

		// Token: 0x06001E10 RID: 7696 RVA: 0x000D3738 File Offset: 0x000D1938
		public override string GetCustomEntry(string key)
		{
			if (string.IsNullOrEmpty(key))
			{
				return string.Empty;
			}
			string text;
			if (!this.customDict.TryGetValue(key, out text))
			{
				return string.Empty;
			}
			return text;
		}

		// Token: 0x06001E11 RID: 7697 RVA: 0x00016C65 File Offset: 0x00014E65
		public override bool ContainsCustomEntryKey(string key)
		{
			return !string.IsNullOrEmpty(key) && this.customDict.ContainsKey(key);
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06001E12 RID: 7698 RVA: 0x00016C7D File Offset: 0x00014E7D
		public override string yes
		{
			get
			{
				return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._yes);
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06001E13 RID: 7699 RVA: 0x00016C8F File Offset: 0x00014E8F
		public override string no
		{
			get
			{
				return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._no);
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06001E14 RID: 7700 RVA: 0x00016CA1 File Offset: 0x00014EA1
		public override string add
		{
			get
			{
				return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._add);
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06001E15 RID: 7701 RVA: 0x00016CB3 File Offset: 0x00014EB3
		public override string replace
		{
			get
			{
				return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._replace);
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06001E16 RID: 7702 RVA: 0x00016CC5 File Offset: 0x00014EC5
		public override string remove
		{
			get
			{
				return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._remove);
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06001E17 RID: 7703 RVA: 0x00016CD7 File Offset: 0x00014ED7
		public override string swap
		{
			get
			{
				return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._swap);
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06001E18 RID: 7704 RVA: 0x00016CE9 File Offset: 0x00014EE9
		public override string cancel
		{
			get
			{
				return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._cancel);
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06001E19 RID: 7705 RVA: 0x00016CFB File Offset: 0x00014EFB
		public override string none
		{
			get
			{
				return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._none);
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06001E1A RID: 7706 RVA: 0x00016D0D File Offset: 0x00014F0D
		public override string okay
		{
			get
			{
				return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._okay);
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06001E1B RID: 7707 RVA: 0x00016D1F File Offset: 0x00014F1F
		public override string done
		{
			get
			{
				return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._done);
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06001E1C RID: 7708 RVA: 0x00016D31 File Offset: 0x00014F31
		public override string default_
		{
			get
			{
				return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._default);
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06001E1D RID: 7709 RVA: 0x00016D43 File Offset: 0x00014F43
		public override string assignControllerWindowTitle
		{
			get
			{
				return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._assignControllerWindowTitle);
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06001E1E RID: 7710 RVA: 0x00016D55 File Offset: 0x00014F55
		public override string assignControllerWindowMessage
		{
			get
			{
				return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._assignControllerWindowMessage);
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06001E1F RID: 7711 RVA: 0x00016D67 File Offset: 0x00014F67
		public override string controllerAssignmentConflictWindowTitle
		{
			get
			{
				return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._controllerAssignmentConflictWindowTitle);
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06001E20 RID: 7712 RVA: 0x00016D79 File Offset: 0x00014F79
		public override string elementAssignmentPrePollingWindowMessage
		{
			get
			{
				return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._elementAssignmentPrePollingWindowMessage);
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06001E21 RID: 7713 RVA: 0x00016D8B File Offset: 0x00014F8B
		public override string elementAssignmentConflictWindowMessage
		{
			get
			{
				return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._elementAssignmentConflictWindowMessage);
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06001E22 RID: 7714 RVA: 0x00016D9D File Offset: 0x00014F9D
		public override string mouseAssignmentConflictWindowTitle
		{
			get
			{
				return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._mouseAssignmentConflictWindowTitle);
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06001E23 RID: 7715 RVA: 0x00016DAF File Offset: 0x00014FAF
		public override string calibrateControllerWindowTitle
		{
			get
			{
				return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._calibrateControllerWindowTitle);
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06001E24 RID: 7716 RVA: 0x00016DC1 File Offset: 0x00014FC1
		public override string calibrateAxisStep1WindowTitle
		{
			get
			{
				return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._calibrateAxisStep1WindowTitle);
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06001E25 RID: 7717 RVA: 0x00016DD3 File Offset: 0x00014FD3
		public override string calibrateAxisStep2WindowTitle
		{
			get
			{
				return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._calibrateAxisStep2WindowTitle);
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06001E26 RID: 7718 RVA: 0x00016DE5 File Offset: 0x00014FE5
		public override string inputBehaviorSettingsWindowTitle
		{
			get
			{
				return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._inputBehaviorSettingsWindowTitle);
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06001E27 RID: 7719 RVA: 0x00016DF7 File Offset: 0x00014FF7
		public override string restoreDefaultsWindowTitle
		{
			get
			{
				return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._restoreDefaultsWindowTitle);
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06001E28 RID: 7720 RVA: 0x00016E09 File Offset: 0x00015009
		public override string actionColumnLabel
		{
			get
			{
				return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._actionColumnLabel);
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06001E29 RID: 7721 RVA: 0x00016E1B File Offset: 0x0001501B
		public override string keyboardColumnLabel
		{
			get
			{
				return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._keyboardColumnLabel);
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06001E2A RID: 7722 RVA: 0x00016E2D File Offset: 0x0001502D
		public override string mouseColumnLabel
		{
			get
			{
				return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._mouseColumnLabel);
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06001E2B RID: 7723 RVA: 0x00016E3F File Offset: 0x0001503F
		public override string controllerColumnLabel
		{
			get
			{
				return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._controllerLabel);
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06001E2C RID: 7724 RVA: 0x00016E51 File Offset: 0x00015051
		public override string removeControllerButtonLabel
		{
			get
			{
				return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._removeControllerButtonLabel);
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06001E2D RID: 7725 RVA: 0x00016E63 File Offset: 0x00015063
		public override string calibrateControllerButtonLabel
		{
			get
			{
				return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._calibrateLabel);
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06001E2E RID: 7726 RVA: 0x00016E75 File Offset: 0x00015075
		public override string assignControllerButtonLabel
		{
			get
			{
				return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._assignControllerButtonLabel);
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06001E2F RID: 7727 RVA: 0x00016E87 File Offset: 0x00015087
		public override string inputBehaviorSettingsButtonLabel
		{
			get
			{
				return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._inputBehaviorSettingsButtonLabel);
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06001E30 RID: 7728 RVA: 0x00016D1F File Offset: 0x00014F1F
		public override string doneButtonLabel
		{
			get
			{
				return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._done);
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06001E31 RID: 7729 RVA: 0x00016E99 File Offset: 0x00015099
		public override string restoreDefaultsButtonLabel
		{
			get
			{
				return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._restoreDefaultsButtonLabel);
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06001E32 RID: 7730 RVA: 0x00016EAB File Offset: 0x000150AB
		public override string controllerSettingsGroupLabel
		{
			get
			{
				return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._controllerLabel) + ":";
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06001E33 RID: 7731 RVA: 0x00016EC7 File Offset: 0x000150C7
		public override string playersGroupLabel
		{
			get
			{
				return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._playersLabel) + ":";
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06001E34 RID: 7732 RVA: 0x00016EE3 File Offset: 0x000150E3
		public override string assignedControllersGroupLabel
		{
			get
			{
				return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._assignedControllersGroupLabel);
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06001E35 RID: 7733 RVA: 0x00016EF5 File Offset: 0x000150F5
		public override string settingsGroupLabel
		{
			get
			{
				return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._settingsGroupLabel) + ":";
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06001E36 RID: 7734 RVA: 0x00016F11 File Offset: 0x00015111
		public override string mapCategoriesGroupLabel
		{
			get
			{
				return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._mapCategoriesGroupLabel) + ":";
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06001E37 RID: 7735 RVA: 0x00016F2D File Offset: 0x0001512D
		public override string restoreDefaultsWindowMessage
		{
			get
			{
				if (ReInput.players.playerCount > 1)
				{
					return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._restoreDefaultsWindowMessage_multiPlayer);
				}
				return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._restoreDefaultsWindowMessage_onePlayer);
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06001E38 RID: 7736 RVA: 0x00016F5D File Offset: 0x0001515D
		public override string calibrateWindow_deadZoneSliderLabel
		{
			get
			{
				return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._calibrateWindow_deadZoneSliderLabel) + ":";
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06001E39 RID: 7737 RVA: 0x00016F79 File Offset: 0x00015179
		public override string calibrateWindow_zeroSliderLabel
		{
			get
			{
				return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._calibrateWindow_zeroSliderLabel) + ":";
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06001E3A RID: 7738 RVA: 0x00016F95 File Offset: 0x00015195
		public override string calibrateWindow_sensitivitySliderLabel
		{
			get
			{
				return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._inputBehaviorSettingsButtonLabel) + ":";
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06001E3B RID: 7739 RVA: 0x00016FB1 File Offset: 0x000151B1
		public override string calibrateWindow_invertToggleLabel
		{
			get
			{
				return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._calibrateWindow_invertToggleLabel);
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06001E3C RID: 7740 RVA: 0x00016E63 File Offset: 0x00015063
		public override string calibrateWindow_calibrateButtonLabel
		{
			get
			{
				return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._calibrateLabel);
			}
		}

		// Token: 0x06001E3D RID: 7741 RVA: 0x00016FC3 File Offset: 0x000151C3
		public override string GetControllerAssignmentConflictWindowMessage(string joystickName, string otherPlayerName, string currentPlayerName)
		{
			return string.Format(\u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._controllerAssignmentConflictWindowMessage), joystickName, otherPlayerName, currentPlayerName);
		}

		// Token: 0x06001E3E RID: 7742 RVA: 0x00016FDD File Offset: 0x000151DD
		public override string GetJoystickElementAssignmentPollingWindowMessage(string actionName)
		{
			return string.Format(\u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._joystickElementAssignmentPollingWindowMessage), actionName);
		}

		// Token: 0x06001E3F RID: 7743 RVA: 0x00016FF5 File Offset: 0x000151F5
		public override string GetJoystickElementAssignmentPollingWindowMessage_FullAxisFieldOnly(string actionName)
		{
			return string.Format(\u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._joystickElementAssignmentPollingWindowMessage_fullAxisFieldOnly), actionName);
		}

		// Token: 0x06001E40 RID: 7744 RVA: 0x0001700D File Offset: 0x0001520D
		public override string GetKeyboardElementAssignmentPollingWindowMessage(string actionName)
		{
			return string.Format(\u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._keyboardElementAssignmentPollingWindowMessage), actionName);
		}

		// Token: 0x06001E41 RID: 7745 RVA: 0x00017025 File Offset: 0x00015225
		public override string GetMouseElementAssignmentPollingWindowMessage(string actionName)
		{
			return string.Format(\u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._mouseElementAssignmentPollingWindowMessage), actionName);
		}

		// Token: 0x06001E42 RID: 7746 RVA: 0x0001703D File Offset: 0x0001523D
		public override string GetMouseElementAssignmentPollingWindowMessage_FullAxisFieldOnly(string actionName)
		{
			return string.Format(\u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._mouseElementAssignmentPollingWindowMessage_fullAxisFieldOnly), actionName);
		}

		// Token: 0x06001E43 RID: 7747 RVA: 0x00017055 File Offset: 0x00015255
		public override string GetElementAlreadyInUseBlocked(string elementName)
		{
			return string.Format(\u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._elementAlreadyInUseBlocked), elementName);
		}

		// Token: 0x06001E44 RID: 7748 RVA: 0x0001706D File Offset: 0x0001526D
		public override string GetElementAlreadyInUseCanReplace(string elementName, bool allowConflicts)
		{
			if (!allowConflicts)
			{
				return string.Format(\u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._elementAlreadyInUseCanReplace), elementName);
			}
			return string.Format(\u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._elementAlreadyInUseCanReplace_conflictAllowed), elementName);
		}

		// Token: 0x06001E45 RID: 7749 RVA: 0x0001709F File Offset: 0x0001529F
		public override string GetMouseAssignmentConflictWindowMessage(string otherPlayerName, string thisPlayerName)
		{
			return string.Format(\u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._mouseAssignmentConflictWindowMessage), otherPlayerName, thisPlayerName);
		}

		// Token: 0x06001E46 RID: 7750 RVA: 0x000170B8 File Offset: 0x000152B8
		public override string GetCalibrateAxisStep1WindowMessage(string axisName)
		{
			return string.Format(\u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._calibrateAxisStep1WindowMessage), axisName);
		}

		// Token: 0x06001E47 RID: 7751 RVA: 0x000170D0 File Offset: 0x000152D0
		public override string GetCalibrateAxisStep2WindowMessage(string axisName)
		{
			return string.Format(\u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this._calibrateAxisStep2WindowMessage), axisName);
		}

		// Token: 0x06001E48 RID: 7752 RVA: 0x000D376C File Offset: 0x000D196C
		public override string GetPlayerName(int playerId)
		{
			Player player = ReInput.players.GetPlayer(playerId);
			if (player == null)
			{
				throw new ArgumentException("Invalid player id: " + playerId.ToString());
			}
			return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(player.descriptiveName);
		}

		// Token: 0x06001E49 RID: 7753 RVA: 0x000170E8 File Offset: 0x000152E8
		public override string GetControllerName(Controller controller)
		{
			if (controller == null)
			{
				throw new ArgumentNullException("controller");
			}
			return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(controller.name);
		}

		// Token: 0x06001E4A RID: 7754 RVA: 0x000D37B0 File Offset: 0x000D19B0
		public override string GetElementIdentifierName(ActionElementMap actionElementMap)
		{
			if (actionElementMap == null)
			{
				throw new ArgumentNullException("actionElementMap");
			}
			if (actionElementMap.controllerMap.controllerType == ControllerType.Keyboard)
			{
				return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this.GetElementIdentifierName(actionElementMap.keyCode, actionElementMap.modifierKeyFlags));
			}
			return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this.GetElementIdentifierName(actionElementMap.controllerMap.controller, actionElementMap.elementIdentifierId, actionElementMap.axisRange));
		}

		// Token: 0x06001E4B RID: 7755 RVA: 0x000D381C File Offset: 0x000D1A1C
		public override string GetElementIdentifierName(Controller controller, int elementIdentifierId, AxisRange axisRange)
		{
			if (controller == null)
			{
				throw new ArgumentNullException("controller");
			}
			ControllerElementIdentifier elementIdentifierById = controller.GetElementIdentifierById(elementIdentifierId);
			if (elementIdentifierById == null)
			{
				throw new ArgumentException("Invalid element identifier id: " + elementIdentifierId.ToString());
			}
			Controller.Element elementById = controller.GetElementById(elementIdentifierId);
			if (elementById == null)
			{
				return string.Empty;
			}
			ControllerElementType type = elementById.type;
			if (type == ControllerElementType.Axis)
			{
				return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(elementIdentifierById.GetDisplayName(elementById.type, axisRange));
			}
			if (type != ControllerElementType.Button)
			{
				return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(elementIdentifierById.name);
			}
			return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(elementIdentifierById.name);
		}

		// Token: 0x06001E4C RID: 7756 RVA: 0x00017108 File Offset: 0x00015308
		public override string GetElementIdentifierName(KeyCode keyCode, ModifierKeyFlags modifierKeyFlags)
		{
			if (modifierKeyFlags != ModifierKeyFlags.None)
			{
				return string.Format("{0}{1}{2}", this.ModifierKeyFlagsToString(modifierKeyFlags), this._modifierKeys.separator, Keyboard.GetKeyName(keyCode));
			}
			return Keyboard.GetKeyName(keyCode);
		}

		// Token: 0x06001E4D RID: 7757 RVA: 0x000D38B4 File Offset: 0x000D1AB4
		public override string GetActionName(int actionId)
		{
			InputAction action = ReInput.mapping.GetAction(actionId);
			if (action == null)
			{
				throw new ArgumentException("Invalid action id: " + actionId.ToString());
			}
			return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(action.descriptiveName);
		}

		// Token: 0x06001E4E RID: 7758 RVA: 0x000D38F8 File Offset: 0x000D1AF8
		public override string GetActionName(int actionId, AxisRange axisRange)
		{
			InputAction action = ReInput.mapping.GetAction(actionId);
			if (action == null)
			{
				throw new ArgumentException("Invalid action id: " + actionId.ToString());
			}
			switch (axisRange)
			{
			case AxisRange.Full:
				return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(action.descriptiveName);
			case AxisRange.Positive:
				if (string.IsNullOrEmpty(action.positiveDescriptiveName))
				{
					return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(action.descriptiveName) + "+";
				}
				return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(action.positiveDescriptiveName);
			case AxisRange.Negative:
				if (string.IsNullOrEmpty(action.negativeDescriptiveName))
				{
					return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(action.descriptiveName) + "-";
				}
				return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(action.negativeDescriptiveName);
			default:
				throw new NotImplementedException();
			}
		}

		// Token: 0x06001E4F RID: 7759 RVA: 0x000D39CC File Offset: 0x000D1BCC
		public override string GetMapCategoryName(int id)
		{
			InputMapCategory mapCategory = ReInput.mapping.GetMapCategory(id);
			if (mapCategory == null)
			{
				throw new ArgumentException("Invalid map category id: " + id.ToString());
			}
			return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(mapCategory.descriptiveName);
		}

		// Token: 0x06001E50 RID: 7760 RVA: 0x000D3A10 File Offset: 0x000D1C10
		public override string GetActionCategoryName(int id)
		{
			InputCategory actionCategory = ReInput.mapping.GetActionCategory(id);
			if (actionCategory == null)
			{
				throw new ArgumentException("Invalid action category id: " + id.ToString());
			}
			return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(actionCategory.descriptiveName);
		}

		// Token: 0x06001E51 RID: 7761 RVA: 0x000D3A54 File Offset: 0x000D1C54
		public override string GetLayoutName(ControllerType controllerType, int id)
		{
			InputLayout layout = ReInput.mapping.GetLayout(controllerType, id);
			if (layout == null)
			{
				throw new ArgumentException("Invalid " + controllerType.ToString() + " layout id: " + id.ToString());
			}
			return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(layout.descriptiveName);
		}

		// Token: 0x06001E52 RID: 7762 RVA: 0x000D3AAC File Offset: 0x000D1CAC
		public override string ModifierKeyFlagsToString(ModifierKeyFlags flags)
		{
			int num = 0;
			string text = string.Empty;
			if (Keyboard.ModifierKeyFlagsContain(flags, ModifierKey.Control))
			{
				text += this._modifierKeys.control;
				num++;
			}
			if (Keyboard.ModifierKeyFlagsContain(flags, ModifierKey.Command))
			{
				if (num > 0 && !string.IsNullOrEmpty(this._modifierKeys.separator))
				{
					text += this._modifierKeys.separator;
				}
				text += this._modifierKeys.command;
				num++;
			}
			if (Keyboard.ModifierKeyFlagsContain(flags, ModifierKey.Alt))
			{
				if (num > 0 && !string.IsNullOrEmpty(this._modifierKeys.separator))
				{
					text += this._modifierKeys.separator;
				}
				text += this._modifierKeys.alt;
				num++;
			}
			if (num >= 3)
			{
				return text;
			}
			if (Keyboard.ModifierKeyFlagsContain(flags, ModifierKey.Shift))
			{
				if (num > 0 && !string.IsNullOrEmpty(this._modifierKeys.separator))
				{
					text += this._modifierKeys.separator;
				}
				text += this._modifierKeys.shift;
				num++;
			}
			return text;
		}

		// Token: 0x0400149A RID: 5274
		[SerializeField]
		private string _yes = "Yes";

		// Token: 0x0400149B RID: 5275
		[SerializeField]
		private string _no = "No";

		// Token: 0x0400149C RID: 5276
		[SerializeField]
		private string _add = "Add";

		// Token: 0x0400149D RID: 5277
		[SerializeField]
		private string _replace = "Replace";

		// Token: 0x0400149E RID: 5278
		[SerializeField]
		private string _remove = "Remove";

		// Token: 0x0400149F RID: 5279
		[SerializeField]
		private string _swap = "Swap";

		// Token: 0x040014A0 RID: 5280
		[SerializeField]
		private string _cancel = "Cancel";

		// Token: 0x040014A1 RID: 5281
		[SerializeField]
		private string _none = "None";

		// Token: 0x040014A2 RID: 5282
		[SerializeField]
		private string _okay = "Okay";

		// Token: 0x040014A3 RID: 5283
		[SerializeField]
		private string _done = "Done";

		// Token: 0x040014A4 RID: 5284
		[SerializeField]
		private string _default = "Default";

		// Token: 0x040014A5 RID: 5285
		[SerializeField]
		private string _assignControllerWindowTitle = "mapperAssignControllerTitle";

		// Token: 0x040014A6 RID: 5286
		[SerializeField]
		private string _assignControllerWindowMessage = "mapperAssignControllerMessage";

		// Token: 0x040014A7 RID: 5287
		[SerializeField]
		private string _controllerAssignmentConflictWindowTitle = "mapperAssignControllerAltTitle";

		// Token: 0x040014A8 RID: 5288
		[Tooltip("{0} = Joystick Name\n{1} = Other Player Name\n{2} = This Player Name")]
		[SerializeField]
		private string _controllerAssignmentConflictWindowMessage = "mapperAssignConflict";

		// Token: 0x040014A9 RID: 5289
		[SerializeField]
		private string _elementAssignmentPrePollingWindowMessage = "mapperElementAssignPre";

		// Token: 0x040014AA RID: 5290
		[SerializeField]
		[Tooltip("{0} = Action Name")]
		private string _joystickElementAssignmentPollingWindowMessage = "mapperJoystickElementAssign";

		// Token: 0x040014AB RID: 5291
		[Tooltip("This text is only displayed when split-axis fields have been disabled and the user clicks on the full-axis field. Button/key/D-pad input cannot be assigned to a full-axis field.\n{0} = Action Name")]
		[SerializeField]
		private string _joystickElementAssignmentPollingWindowMessage_fullAxisFieldOnly = "mapperJoystickAssignAxisOnly";

		// Token: 0x040014AC RID: 5292
		[Tooltip("{0} = Action Name")]
		[SerializeField]
		private string _keyboardElementAssignmentPollingWindowMessage = "mapperKeyboardElementAssign";

		// Token: 0x040014AD RID: 5293
		[SerializeField]
		[Tooltip("{0} = Action Name")]
		private string _mouseElementAssignmentPollingWindowMessage = "mapperMouseElementAssign";

		// Token: 0x040014AE RID: 5294
		[SerializeField]
		[Tooltip("This text is only displayed when split-axis fields have been disabled and the user clicks on the full-axis field. Button/key/D-pad input cannot be assigned to a full-axis field.\n{0} = Action Name")]
		private string _mouseElementAssignmentPollingWindowMessage_fullAxisFieldOnly = "mapperMouseAssignAxisOnly";

		// Token: 0x040014AF RID: 5295
		[SerializeField]
		private string _elementAssignmentConflictWindowMessage = "mapperElementAssignConflict";

		// Token: 0x040014B0 RID: 5296
		[Tooltip("{0} = Element Name")]
		[SerializeField]
		private string _elementAlreadyInUseBlocked = "mapperElementInUseAndBlocked";

		// Token: 0x040014B1 RID: 5297
		[SerializeField]
		[Tooltip("{0} = Element Name")]
		private string _elementAlreadyInUseCanReplace = "mapperElementInUse";

		// Token: 0x040014B2 RID: 5298
		[SerializeField]
		[Tooltip("{0} = Element Name")]
		private string _elementAlreadyInUseCanReplace_conflictAllowed = "mapperElementInUseAllowDuplicate";

		// Token: 0x040014B3 RID: 5299
		[SerializeField]
		private string _mouseAssignmentConflictWindowTitle = "mapperMouseAssignTitle";

		// Token: 0x040014B4 RID: 5300
		[Tooltip("{0} = Other Player Name\n{1} = This Player Name")]
		[SerializeField]
		private string _mouseAssignmentConflictWindowMessage = "mapperMouseAssignConflict";

		// Token: 0x040014B5 RID: 5301
		[SerializeField]
		private string _calibrateControllerWindowTitle = "mapperCalibrateControllerTitle";

		// Token: 0x040014B6 RID: 5302
		[SerializeField]
		private string _calibrateAxisStep1WindowTitle = "mapperCalibrateCenterTitle";

		// Token: 0x040014B7 RID: 5303
		[Tooltip("{0} = Axis Name")]
		[SerializeField]
		private string _calibrateAxisStep1WindowMessage = "mapperCalibrateCenterMessage";

		// Token: 0x040014B8 RID: 5304
		[SerializeField]
		private string _calibrateAxisStep2WindowTitle = "mapperCalibrateRangeTitle";

		// Token: 0x040014B9 RID: 5305
		[Tooltip("{0} = Axis Name")]
		[SerializeField]
		private string _calibrateAxisStep2WindowMessage = "mapperCalibrateRangeMessage";

		// Token: 0x040014BA RID: 5306
		[SerializeField]
		private string _inputBehaviorSettingsWindowTitle = "SensitivitySettings";

		// Token: 0x040014BB RID: 5307
		[SerializeField]
		private string _restoreDefaultsWindowTitle = "RestoreDefaults";

		// Token: 0x040014BC RID: 5308
		[SerializeField]
		[Tooltip("Message for a single player game.")]
		private string _restoreDefaultsWindowMessage_onePlayer = "mapperRestoreDefaultSinglePlayer";

		// Token: 0x040014BD RID: 5309
		[SerializeField]
		[Tooltip("Message for a multi-player game.")]
		private string _restoreDefaultsWindowMessage_multiPlayer = "mapperRestoreDefaultMultiPlayer";

		// Token: 0x040014BE RID: 5310
		[SerializeField]
		private string _actionColumnLabel = "Actions";

		// Token: 0x040014BF RID: 5311
		[SerializeField]
		private string _keyboardColumnLabel = "Keyboard";

		// Token: 0x040014C0 RID: 5312
		[SerializeField]
		private string _mouseColumnLabel = "Mouse";

		// Token: 0x040014C1 RID: 5313
		[SerializeField]
		private string _controllerLabel = "Controller";

		// Token: 0x040014C2 RID: 5314
		[SerializeField]
		private string _removeControllerButtonLabel = "Remove";

		// Token: 0x040014C3 RID: 5315
		[SerializeField]
		private string _calibrateLabel = "Calibrate";

		// Token: 0x040014C4 RID: 5316
		[SerializeField]
		private string _assignControllerButtonLabel = "Assign Controller";

		// Token: 0x040014C5 RID: 5317
		[SerializeField]
		private string _inputBehaviorSettingsButtonLabel = "Sensitivity";

		// Token: 0x040014C6 RID: 5318
		[SerializeField]
		private string _restoreDefaultsButtonLabel = "RestoreDefaults";

		// Token: 0x040014C7 RID: 5319
		[SerializeField]
		private string _playersLabel = "Players";

		// Token: 0x040014C8 RID: 5320
		[SerializeField]
		private string _assignedControllersGroupLabel = "Assigned Controllers";

		// Token: 0x040014C9 RID: 5321
		[SerializeField]
		private string _settingsGroupLabel = "Settings";

		// Token: 0x040014CA RID: 5322
		[SerializeField]
		private string _mapCategoriesGroupLabel = "Categories";

		// Token: 0x040014CB RID: 5323
		[SerializeField]
		private string _calibrateWindow_deadZoneSliderLabel = "Dead Zone";

		// Token: 0x040014CC RID: 5324
		[SerializeField]
		private string _calibrateWindow_zeroSliderLabel = "Zero";

		// Token: 0x040014CD RID: 5325
		[SerializeField]
		private string _calibrateWindow_invertToggleLabel = "Invert";

		// Token: 0x040014CE RID: 5326
		[SerializeField]
		private LanguageData.ModifierKeys _modifierKeys;

		// Token: 0x040014CF RID: 5327
		[SerializeField]
		private LanguageData.CustomEntry[] _customEntries;

		// Token: 0x040014D0 RID: 5328
		private bool _initialized;

		// Token: 0x040014D1 RID: 5329
		private Dictionary<string, string> customDict;

		// Token: 0x020002B8 RID: 696
		[Serializable]
		protected class CustomEntry
		{
			// Token: 0x06001E55 RID: 7765 RVA: 0x000D3E0C File Offset: 0x000D200C
			public static Dictionary<string, string> ToDictionary(LanguageData.CustomEntry[] array)
			{
				if (array == null)
				{
					return new Dictionary<string, string>();
				}
				Dictionary<string, string> dictionary = new Dictionary<string, string>();
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i] != null && !string.IsNullOrEmpty(array[i].key) && !string.IsNullOrEmpty(array[i].value))
					{
						if (dictionary.ContainsKey(array[i].key))
						{
							Debug.LogError("Key \"" + array[i].key + "\" is already in dictionary!");
						}
						else
						{
							dictionary.Add(array[i].key, array[i].value);
						}
					}
				}
				return dictionary;
			}

			// Token: 0x040014D2 RID: 5330
			public string key;

			// Token: 0x040014D3 RID: 5331
			public string value;
		}

		// Token: 0x020002B9 RID: 697
		[Serializable]
		protected class ModifierKeys
		{
			// Token: 0x040014D4 RID: 5332
			public string control = "Control";

			// Token: 0x040014D5 RID: 5333
			public string alt = "Alt";

			// Token: 0x040014D6 RID: 5334
			public string shift = "Shift";

			// Token: 0x040014D7 RID: 5335
			public string command = "Command";

			// Token: 0x040014D8 RID: 5336
			public string separator = " + ";
		}
	}
}
