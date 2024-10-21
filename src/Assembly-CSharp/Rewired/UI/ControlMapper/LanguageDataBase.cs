using System;
using UnityEngine;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x020002BA RID: 698
	[Serializable]
	public abstract class LanguageDataBase : ScriptableObject
	{
		// Token: 0x06001E57 RID: 7767
		public abstract void Initialize();

		// Token: 0x06001E58 RID: 7768
		public abstract string GetCustomEntry(string key);

		// Token: 0x06001E59 RID: 7769
		public abstract bool ContainsCustomEntryKey(string key);

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06001E5A RID: 7770
		public abstract string yes { get; }

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06001E5B RID: 7771
		public abstract string no { get; }

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06001E5C RID: 7772
		public abstract string add { get; }

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06001E5D RID: 7773
		public abstract string replace { get; }

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06001E5E RID: 7774
		public abstract string remove { get; }

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06001E5F RID: 7775
		public abstract string swap { get; }

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06001E60 RID: 7776
		public abstract string cancel { get; }

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06001E61 RID: 7777
		public abstract string none { get; }

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06001E62 RID: 7778
		public abstract string okay { get; }

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06001E63 RID: 7779
		public abstract string done { get; }

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06001E64 RID: 7780
		public abstract string default_ { get; }

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06001E65 RID: 7781
		public abstract string assignControllerWindowTitle { get; }

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06001E66 RID: 7782
		public abstract string assignControllerWindowMessage { get; }

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06001E67 RID: 7783
		public abstract string controllerAssignmentConflictWindowTitle { get; }

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06001E68 RID: 7784
		public abstract string elementAssignmentPrePollingWindowMessage { get; }

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06001E69 RID: 7785
		public abstract string elementAssignmentConflictWindowMessage { get; }

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06001E6A RID: 7786
		public abstract string mouseAssignmentConflictWindowTitle { get; }

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06001E6B RID: 7787
		public abstract string calibrateControllerWindowTitle { get; }

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06001E6C RID: 7788
		public abstract string calibrateAxisStep1WindowTitle { get; }

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06001E6D RID: 7789
		public abstract string calibrateAxisStep2WindowTitle { get; }

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06001E6E RID: 7790
		public abstract string inputBehaviorSettingsWindowTitle { get; }

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06001E6F RID: 7791
		public abstract string restoreDefaultsWindowTitle { get; }

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06001E70 RID: 7792
		public abstract string actionColumnLabel { get; }

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06001E71 RID: 7793
		public abstract string keyboardColumnLabel { get; }

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06001E72 RID: 7794
		public abstract string mouseColumnLabel { get; }

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06001E73 RID: 7795
		public abstract string controllerColumnLabel { get; }

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06001E74 RID: 7796
		public abstract string removeControllerButtonLabel { get; }

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06001E75 RID: 7797
		public abstract string calibrateControllerButtonLabel { get; }

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06001E76 RID: 7798
		public abstract string assignControllerButtonLabel { get; }

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06001E77 RID: 7799
		public abstract string inputBehaviorSettingsButtonLabel { get; }

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06001E78 RID: 7800
		public abstract string doneButtonLabel { get; }

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06001E79 RID: 7801
		public abstract string restoreDefaultsButtonLabel { get; }

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06001E7A RID: 7802
		public abstract string controllerSettingsGroupLabel { get; }

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06001E7B RID: 7803
		public abstract string playersGroupLabel { get; }

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06001E7C RID: 7804
		public abstract string assignedControllersGroupLabel { get; }

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06001E7D RID: 7805
		public abstract string settingsGroupLabel { get; }

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06001E7E RID: 7806
		public abstract string mapCategoriesGroupLabel { get; }

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06001E7F RID: 7807
		public abstract string restoreDefaultsWindowMessage { get; }

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06001E80 RID: 7808
		public abstract string calibrateWindow_deadZoneSliderLabel { get; }

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06001E81 RID: 7809
		public abstract string calibrateWindow_zeroSliderLabel { get; }

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06001E82 RID: 7810
		public abstract string calibrateWindow_sensitivitySliderLabel { get; }

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06001E83 RID: 7811
		public abstract string calibrateWindow_invertToggleLabel { get; }

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06001E84 RID: 7812
		public abstract string calibrateWindow_calibrateButtonLabel { get; }

		// Token: 0x06001E85 RID: 7813
		public abstract string GetControllerAssignmentConflictWindowMessage(string joystickName, string otherPlayerName, string currentPlayerName);

		// Token: 0x06001E86 RID: 7814
		public abstract string GetJoystickElementAssignmentPollingWindowMessage(string actionName);

		// Token: 0x06001E87 RID: 7815
		public abstract string GetJoystickElementAssignmentPollingWindowMessage_FullAxisFieldOnly(string actionName);

		// Token: 0x06001E88 RID: 7816
		public abstract string GetKeyboardElementAssignmentPollingWindowMessage(string actionName);

		// Token: 0x06001E89 RID: 7817
		public abstract string GetMouseElementAssignmentPollingWindowMessage(string actionName);

		// Token: 0x06001E8A RID: 7818
		public abstract string GetMouseElementAssignmentPollingWindowMessage_FullAxisFieldOnly(string actionName);

		// Token: 0x06001E8B RID: 7819
		public abstract string GetElementAlreadyInUseBlocked(string elementName);

		// Token: 0x06001E8C RID: 7820
		public abstract string GetElementAlreadyInUseCanReplace(string elementName, bool allowConflicts);

		// Token: 0x06001E8D RID: 7821
		public abstract string GetMouseAssignmentConflictWindowMessage(string otherPlayerName, string thisPlayerName);

		// Token: 0x06001E8E RID: 7822
		public abstract string GetCalibrateAxisStep1WindowMessage(string axisName);

		// Token: 0x06001E8F RID: 7823
		public abstract string GetCalibrateAxisStep2WindowMessage(string axisName);

		// Token: 0x06001E90 RID: 7824
		public abstract string GetPlayerName(int playerId);

		// Token: 0x06001E91 RID: 7825
		public abstract string GetControllerName(Controller controller);

		// Token: 0x06001E92 RID: 7826
		public abstract string GetElementIdentifierName(ActionElementMap actionElementMap);

		// Token: 0x06001E93 RID: 7827
		public abstract string GetElementIdentifierName(Controller controller, int elementIdentifierId, AxisRange axisRange);

		// Token: 0x06001E94 RID: 7828
		public abstract string GetElementIdentifierName(KeyCode keyCode, ModifierKeyFlags modifierKeyFlags);

		// Token: 0x06001E95 RID: 7829
		public abstract string GetActionName(int actionId);

		// Token: 0x06001E96 RID: 7830
		public abstract string GetActionName(int actionId, AxisRange axisRange);

		// Token: 0x06001E97 RID: 7831
		public abstract string GetMapCategoryName(int id);

		// Token: 0x06001E98 RID: 7832
		public abstract string GetActionCategoryName(int id);

		// Token: 0x06001E99 RID: 7833
		public abstract string GetLayoutName(ControllerType controllerType, int id);

		// Token: 0x06001E9A RID: 7834
		public abstract string ModifierKeyFlagsToString(ModifierKeyFlags flags);
	}
}
