using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Rewired.Utils;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x02000288 RID: 648
	[AddComponentMenu("")]
	public class ControlMapper : MonoBehaviour
	{
		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06001B23 RID: 6947 RVA: 0x000147CF File Offset: 0x000129CF
		// (remove) Token: 0x06001B24 RID: 6948 RVA: 0x000147E8 File Offset: 0x000129E8
		public event Action ScreenClosedEvent
		{
			add
			{
				this._ScreenClosedEvent = (Action)Delegate.Combine(this._ScreenClosedEvent, value);
			}
			remove
			{
				this._ScreenClosedEvent = (Action)Delegate.Remove(this._ScreenClosedEvent, value);
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06001B25 RID: 6949 RVA: 0x00014801 File Offset: 0x00012A01
		// (remove) Token: 0x06001B26 RID: 6950 RVA: 0x0001481A File Offset: 0x00012A1A
		public event Action ScreenOpenedEvent
		{
			add
			{
				this._ScreenOpenedEvent = (Action)Delegate.Combine(this._ScreenOpenedEvent, value);
			}
			remove
			{
				this._ScreenOpenedEvent = (Action)Delegate.Remove(this._ScreenOpenedEvent, value);
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06001B27 RID: 6951 RVA: 0x00014833 File Offset: 0x00012A33
		// (remove) Token: 0x06001B28 RID: 6952 RVA: 0x0001484C File Offset: 0x00012A4C
		public event Action PopupWindowClosedEvent
		{
			add
			{
				this._PopupWindowClosedEvent = (Action)Delegate.Combine(this._PopupWindowClosedEvent, value);
			}
			remove
			{
				this._PopupWindowClosedEvent = (Action)Delegate.Remove(this._PopupWindowClosedEvent, value);
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06001B29 RID: 6953 RVA: 0x00014865 File Offset: 0x00012A65
		// (remove) Token: 0x06001B2A RID: 6954 RVA: 0x0001487E File Offset: 0x00012A7E
		public event Action PopupWindowOpenedEvent
		{
			add
			{
				this._PopupWindowOpenedEvent = (Action)Delegate.Combine(this._PopupWindowOpenedEvent, value);
			}
			remove
			{
				this._PopupWindowOpenedEvent = (Action)Delegate.Remove(this._PopupWindowOpenedEvent, value);
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06001B2B RID: 6955 RVA: 0x00014897 File Offset: 0x00012A97
		// (remove) Token: 0x06001B2C RID: 6956 RVA: 0x000148B0 File Offset: 0x00012AB0
		public event Action InputPollingStartedEvent
		{
			add
			{
				this._InputPollingStartedEvent = (Action)Delegate.Combine(this._InputPollingStartedEvent, value);
			}
			remove
			{
				this._InputPollingStartedEvent = (Action)Delegate.Remove(this._InputPollingStartedEvent, value);
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06001B2D RID: 6957 RVA: 0x000148C9 File Offset: 0x00012AC9
		// (remove) Token: 0x06001B2E RID: 6958 RVA: 0x000148E2 File Offset: 0x00012AE2
		public event Action InputPollingEndedEvent
		{
			add
			{
				this._InputPollingEndedEvent = (Action)Delegate.Combine(this._InputPollingEndedEvent, value);
			}
			remove
			{
				this._InputPollingEndedEvent = (Action)Delegate.Remove(this._InputPollingEndedEvent, value);
			}
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06001B2F RID: 6959 RVA: 0x000148FB File Offset: 0x00012AFB
		// (remove) Token: 0x06001B30 RID: 6960 RVA: 0x00014909 File Offset: 0x00012B09
		public event UnityAction onScreenClosed
		{
			add
			{
				this._onScreenClosed.AddListener(value);
			}
			remove
			{
				this._onScreenClosed.RemoveListener(value);
			}
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06001B31 RID: 6961 RVA: 0x00014917 File Offset: 0x00012B17
		// (remove) Token: 0x06001B32 RID: 6962 RVA: 0x00014925 File Offset: 0x00012B25
		public event UnityAction onScreenOpened
		{
			add
			{
				this._onScreenOpened.AddListener(value);
			}
			remove
			{
				this._onScreenOpened.RemoveListener(value);
			}
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06001B33 RID: 6963 RVA: 0x00014933 File Offset: 0x00012B33
		// (remove) Token: 0x06001B34 RID: 6964 RVA: 0x00014941 File Offset: 0x00012B41
		public event UnityAction onPopupWindowClosed
		{
			add
			{
				this._onPopupWindowClosed.AddListener(value);
			}
			remove
			{
				this._onPopupWindowClosed.RemoveListener(value);
			}
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06001B35 RID: 6965 RVA: 0x0001494F File Offset: 0x00012B4F
		// (remove) Token: 0x06001B36 RID: 6966 RVA: 0x0001495D File Offset: 0x00012B5D
		public event UnityAction onPopupWindowOpened
		{
			add
			{
				this._onPopupWindowOpened.AddListener(value);
			}
			remove
			{
				this._onPopupWindowOpened.RemoveListener(value);
			}
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06001B37 RID: 6967 RVA: 0x0001496B File Offset: 0x00012B6B
		// (remove) Token: 0x06001B38 RID: 6968 RVA: 0x00014979 File Offset: 0x00012B79
		public event UnityAction onInputPollingStarted
		{
			add
			{
				this._onInputPollingStarted.AddListener(value);
			}
			remove
			{
				this._onInputPollingStarted.RemoveListener(value);
			}
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06001B39 RID: 6969 RVA: 0x00014987 File Offset: 0x00012B87
		// (remove) Token: 0x06001B3A RID: 6970 RVA: 0x00014995 File Offset: 0x00012B95
		public event UnityAction onInputPollingEnded
		{
			add
			{
				this._onInputPollingEnded.AddListener(value);
			}
			remove
			{
				this._onInputPollingEnded.RemoveListener(value);
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06001B3B RID: 6971 RVA: 0x000149A3 File Offset: 0x00012BA3
		// (set) Token: 0x06001B3C RID: 6972 RVA: 0x000149AB File Offset: 0x00012BAB
		public InputManager rewiredInputManager
		{
			get
			{
				return this._rewiredInputManager;
			}
			set
			{
				this._rewiredInputManager = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06001B3D RID: 6973 RVA: 0x000149BB File Offset: 0x00012BBB
		// (set) Token: 0x06001B3E RID: 6974 RVA: 0x000149C3 File Offset: 0x00012BC3
		public bool dontDestroyOnLoad
		{
			get
			{
				return this._dontDestroyOnLoad;
			}
			set
			{
				if (value != this._dontDestroyOnLoad && value)
				{
					global::UnityEngine.Object.DontDestroyOnLoad(base.transform.gameObject);
				}
				this._dontDestroyOnLoad = value;
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06001B3F RID: 6975 RVA: 0x000149E8 File Offset: 0x00012BE8
		// (set) Token: 0x06001B40 RID: 6976 RVA: 0x000149F0 File Offset: 0x00012BF0
		public int keyboardMapDefaultLayout
		{
			get
			{
				return this._keyboardMapDefaultLayout;
			}
			set
			{
				this._keyboardMapDefaultLayout = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06001B41 RID: 6977 RVA: 0x00014A00 File Offset: 0x00012C00
		// (set) Token: 0x06001B42 RID: 6978 RVA: 0x00014A08 File Offset: 0x00012C08
		public int mouseMapDefaultLayout
		{
			get
			{
				return this._mouseMapDefaultLayout;
			}
			set
			{
				this._mouseMapDefaultLayout = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06001B43 RID: 6979 RVA: 0x00014A18 File Offset: 0x00012C18
		// (set) Token: 0x06001B44 RID: 6980 RVA: 0x00014A20 File Offset: 0x00012C20
		public int joystickMapDefaultLayout
		{
			get
			{
				return this._joystickMapDefaultLayout;
			}
			set
			{
				this._joystickMapDefaultLayout = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06001B45 RID: 6981 RVA: 0x00014A30 File Offset: 0x00012C30
		// (set) Token: 0x06001B46 RID: 6982 RVA: 0x00014A49 File Offset: 0x00012C49
		public bool showPlayers
		{
			get
			{
				return this._showPlayers && ReInput.players.playerCount > 1;
			}
			set
			{
				this._showPlayers = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06001B47 RID: 6983 RVA: 0x00014A59 File Offset: 0x00012C59
		// (set) Token: 0x06001B48 RID: 6984 RVA: 0x00014A61 File Offset: 0x00012C61
		public bool showControllers
		{
			get
			{
				return this._showControllers;
			}
			set
			{
				this._showControllers = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06001B49 RID: 6985 RVA: 0x00014A71 File Offset: 0x00012C71
		// (set) Token: 0x06001B4A RID: 6986 RVA: 0x00014A79 File Offset: 0x00012C79
		public bool showKeyboard
		{
			get
			{
				return this._showKeyboard;
			}
			set
			{
				this._showKeyboard = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06001B4B RID: 6987 RVA: 0x00014A89 File Offset: 0x00012C89
		// (set) Token: 0x06001B4C RID: 6988 RVA: 0x00014A91 File Offset: 0x00012C91
		public bool showMouse
		{
			get
			{
				return this._showMouse;
			}
			set
			{
				this._showMouse = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06001B4D RID: 6989 RVA: 0x00014AA1 File Offset: 0x00012CA1
		// (set) Token: 0x06001B4E RID: 6990 RVA: 0x00014AA9 File Offset: 0x00012CA9
		public int maxControllersPerPlayer
		{
			get
			{
				return this._maxControllersPerPlayer;
			}
			set
			{
				this._maxControllersPerPlayer = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06001B4F RID: 6991 RVA: 0x00014AB9 File Offset: 0x00012CB9
		// (set) Token: 0x06001B50 RID: 6992 RVA: 0x00014AC1 File Offset: 0x00012CC1
		public bool showActionCategoryLabels
		{
			get
			{
				return this._showActionCategoryLabels;
			}
			set
			{
				this._showActionCategoryLabels = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06001B51 RID: 6993 RVA: 0x00014AD1 File Offset: 0x00012CD1
		// (set) Token: 0x06001B52 RID: 6994 RVA: 0x00014AD9 File Offset: 0x00012CD9
		public int keyboardInputFieldCount
		{
			get
			{
				return this._keyboardInputFieldCount;
			}
			set
			{
				this._keyboardInputFieldCount = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06001B53 RID: 6995 RVA: 0x00014AE9 File Offset: 0x00012CE9
		// (set) Token: 0x06001B54 RID: 6996 RVA: 0x00014AF1 File Offset: 0x00012CF1
		public int mouseInputFieldCount
		{
			get
			{
				return this._mouseInputFieldCount;
			}
			set
			{
				this._mouseInputFieldCount = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06001B55 RID: 6997 RVA: 0x00014B01 File Offset: 0x00012D01
		// (set) Token: 0x06001B56 RID: 6998 RVA: 0x00014B09 File Offset: 0x00012D09
		public int controllerInputFieldCount
		{
			get
			{
				return this._controllerInputFieldCount;
			}
			set
			{
				this._controllerInputFieldCount = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06001B57 RID: 6999 RVA: 0x00014B19 File Offset: 0x00012D19
		// (set) Token: 0x06001B58 RID: 7000 RVA: 0x00014B21 File Offset: 0x00012D21
		public bool showFullAxisInputFields
		{
			get
			{
				return this._showFullAxisInputFields;
			}
			set
			{
				this._showFullAxisInputFields = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06001B59 RID: 7001 RVA: 0x00014B31 File Offset: 0x00012D31
		// (set) Token: 0x06001B5A RID: 7002 RVA: 0x00014B39 File Offset: 0x00012D39
		public bool showSplitAxisInputFields
		{
			get
			{
				return this._showSplitAxisInputFields;
			}
			set
			{
				this._showSplitAxisInputFields = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06001B5B RID: 7003 RVA: 0x00014B49 File Offset: 0x00012D49
		// (set) Token: 0x06001B5C RID: 7004 RVA: 0x00014B51 File Offset: 0x00012D51
		public bool allowElementAssignmentConflicts
		{
			get
			{
				return this._allowElementAssignmentConflicts;
			}
			set
			{
				this._allowElementAssignmentConflicts = value;
				this.InspectorPropertyChanged(false);
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06001B5D RID: 7005 RVA: 0x00014B61 File Offset: 0x00012D61
		// (set) Token: 0x06001B5E RID: 7006 RVA: 0x00014B69 File Offset: 0x00012D69
		public bool allowElementAssignmentSwap
		{
			get
			{
				return this._allowElementAssignmentSwap;
			}
			set
			{
				this._allowElementAssignmentSwap = value;
				this.InspectorPropertyChanged(false);
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06001B5F RID: 7007 RVA: 0x00014B79 File Offset: 0x00012D79
		// (set) Token: 0x06001B60 RID: 7008 RVA: 0x00014B81 File Offset: 0x00012D81
		public int actionLabelWidth
		{
			get
			{
				return this._actionLabelWidth;
			}
			set
			{
				this._actionLabelWidth = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06001B61 RID: 7009 RVA: 0x00014B91 File Offset: 0x00012D91
		// (set) Token: 0x06001B62 RID: 7010 RVA: 0x00014B99 File Offset: 0x00012D99
		public int keyboardColMaxWidth
		{
			get
			{
				return this._keyboardColMaxWidth;
			}
			set
			{
				this._keyboardColMaxWidth = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06001B63 RID: 7011 RVA: 0x00014BA9 File Offset: 0x00012DA9
		// (set) Token: 0x06001B64 RID: 7012 RVA: 0x00014BB1 File Offset: 0x00012DB1
		public int mouseColMaxWidth
		{
			get
			{
				return this._mouseColMaxWidth;
			}
			set
			{
				this._mouseColMaxWidth = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06001B65 RID: 7013 RVA: 0x00014BC1 File Offset: 0x00012DC1
		// (set) Token: 0x06001B66 RID: 7014 RVA: 0x00014BC9 File Offset: 0x00012DC9
		public int controllerColMaxWidth
		{
			get
			{
				return this._controllerColMaxWidth;
			}
			set
			{
				this._controllerColMaxWidth = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06001B67 RID: 7015 RVA: 0x00014BD9 File Offset: 0x00012DD9
		// (set) Token: 0x06001B68 RID: 7016 RVA: 0x00014BE1 File Offset: 0x00012DE1
		public int inputRowHeight
		{
			get
			{
				return this._inputRowHeight;
			}
			set
			{
				this._inputRowHeight = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06001B69 RID: 7017 RVA: 0x00014BF1 File Offset: 0x00012DF1
		// (set) Token: 0x06001B6A RID: 7018 RVA: 0x00014BF9 File Offset: 0x00012DF9
		public int inputColumnSpacing
		{
			get
			{
				return this._inputColumnSpacing;
			}
			set
			{
				this._inputColumnSpacing = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06001B6B RID: 7019 RVA: 0x00014C09 File Offset: 0x00012E09
		// (set) Token: 0x06001B6C RID: 7020 RVA: 0x00014C11 File Offset: 0x00012E11
		public int inputRowCategorySpacing
		{
			get
			{
				return this._inputRowCategorySpacing;
			}
			set
			{
				this._inputRowCategorySpacing = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06001B6D RID: 7021 RVA: 0x00014C21 File Offset: 0x00012E21
		// (set) Token: 0x06001B6E RID: 7022 RVA: 0x00014C29 File Offset: 0x00012E29
		public int invertToggleWidth
		{
			get
			{
				return this._invertToggleWidth;
			}
			set
			{
				this._invertToggleWidth = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06001B6F RID: 7023 RVA: 0x00014C39 File Offset: 0x00012E39
		// (set) Token: 0x06001B70 RID: 7024 RVA: 0x00014C41 File Offset: 0x00012E41
		public int defaultWindowWidth
		{
			get
			{
				return this._defaultWindowWidth;
			}
			set
			{
				this._defaultWindowWidth = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06001B71 RID: 7025 RVA: 0x00014C51 File Offset: 0x00012E51
		// (set) Token: 0x06001B72 RID: 7026 RVA: 0x00014C59 File Offset: 0x00012E59
		public int defaultWindowHeight
		{
			get
			{
				return this._defaultWindowHeight;
			}
			set
			{
				this._defaultWindowHeight = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06001B73 RID: 7027 RVA: 0x00014C69 File Offset: 0x00012E69
		// (set) Token: 0x06001B74 RID: 7028 RVA: 0x00014C71 File Offset: 0x00012E71
		public float controllerAssignmentTimeout
		{
			get
			{
				return this._controllerAssignmentTimeout;
			}
			set
			{
				this._controllerAssignmentTimeout = value;
				this.InspectorPropertyChanged(false);
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06001B75 RID: 7029 RVA: 0x00014C81 File Offset: 0x00012E81
		// (set) Token: 0x06001B76 RID: 7030 RVA: 0x00014C89 File Offset: 0x00012E89
		public float preInputAssignmentTimeout
		{
			get
			{
				return this._preInputAssignmentTimeout;
			}
			set
			{
				this._preInputAssignmentTimeout = value;
				this.InspectorPropertyChanged(false);
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06001B77 RID: 7031 RVA: 0x00014C99 File Offset: 0x00012E99
		// (set) Token: 0x06001B78 RID: 7032 RVA: 0x00014CA1 File Offset: 0x00012EA1
		public float inputAssignmentTimeout
		{
			get
			{
				return this._inputAssignmentTimeout;
			}
			set
			{
				this._inputAssignmentTimeout = value;
				this.InspectorPropertyChanged(false);
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06001B79 RID: 7033 RVA: 0x00014CB1 File Offset: 0x00012EB1
		// (set) Token: 0x06001B7A RID: 7034 RVA: 0x00014CB9 File Offset: 0x00012EB9
		public float axisCalibrationTimeout
		{
			get
			{
				return this._axisCalibrationTimeout;
			}
			set
			{
				this._axisCalibrationTimeout = value;
				this.InspectorPropertyChanged(false);
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06001B7B RID: 7035 RVA: 0x00014CC9 File Offset: 0x00012EC9
		// (set) Token: 0x06001B7C RID: 7036 RVA: 0x00014CD1 File Offset: 0x00012ED1
		public bool ignoreMouseXAxisAssignment
		{
			get
			{
				return this._ignoreMouseXAxisAssignment;
			}
			set
			{
				this._ignoreMouseXAxisAssignment = value;
				this.InspectorPropertyChanged(false);
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06001B7D RID: 7037 RVA: 0x00014CE1 File Offset: 0x00012EE1
		// (set) Token: 0x06001B7E RID: 7038 RVA: 0x00014CE9 File Offset: 0x00012EE9
		public bool ignoreMouseYAxisAssignment
		{
			get
			{
				return this._ignoreMouseYAxisAssignment;
			}
			set
			{
				this._ignoreMouseYAxisAssignment = value;
				this.InspectorPropertyChanged(false);
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06001B7F RID: 7039 RVA: 0x00014CF9 File Offset: 0x00012EF9
		// (set) Token: 0x06001B80 RID: 7040 RVA: 0x00014D01 File Offset: 0x00012F01
		public bool universalCancelClosesScreen
		{
			get
			{
				return this._universalCancelClosesScreen;
			}
			set
			{
				this._universalCancelClosesScreen = value;
				this.InspectorPropertyChanged(false);
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06001B81 RID: 7041 RVA: 0x00014D11 File Offset: 0x00012F11
		// (set) Token: 0x06001B82 RID: 7042 RVA: 0x00014D19 File Offset: 0x00012F19
		public bool showInputBehaviorSettings
		{
			get
			{
				return this._showInputBehaviorSettings;
			}
			set
			{
				this._showInputBehaviorSettings = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06001B83 RID: 7043 RVA: 0x00014D29 File Offset: 0x00012F29
		// (set) Token: 0x06001B84 RID: 7044 RVA: 0x00014D31 File Offset: 0x00012F31
		public bool useThemeSettings
		{
			get
			{
				return this._useThemeSettings;
			}
			set
			{
				this._useThemeSettings = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06001B85 RID: 7045 RVA: 0x00014D41 File Offset: 0x00012F41
		// (set) Token: 0x06001B86 RID: 7046 RVA: 0x00014D49 File Offset: 0x00012F49
		public LanguageDataBase language
		{
			get
			{
				return this._language;
			}
			set
			{
				this._language = value;
				if (this._language != null)
				{
					this._language.Initialize();
				}
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06001B87 RID: 7047 RVA: 0x00014D72 File Offset: 0x00012F72
		// (set) Token: 0x06001B88 RID: 7048 RVA: 0x00014D7A File Offset: 0x00012F7A
		public bool showPlayersGroupLabel
		{
			get
			{
				return this._showPlayersGroupLabel;
			}
			set
			{
				this._showPlayersGroupLabel = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06001B89 RID: 7049 RVA: 0x00014D8A File Offset: 0x00012F8A
		// (set) Token: 0x06001B8A RID: 7050 RVA: 0x00014D92 File Offset: 0x00012F92
		public bool showControllerGroupLabel
		{
			get
			{
				return this._showControllerGroupLabel;
			}
			set
			{
				this._showControllerGroupLabel = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06001B8B RID: 7051 RVA: 0x00014DA2 File Offset: 0x00012FA2
		// (set) Token: 0x06001B8C RID: 7052 RVA: 0x00014DAA File Offset: 0x00012FAA
		public bool showAssignedControllersGroupLabel
		{
			get
			{
				return this._showAssignedControllersGroupLabel;
			}
			set
			{
				this._showAssignedControllersGroupLabel = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06001B8D RID: 7053 RVA: 0x00014DBA File Offset: 0x00012FBA
		// (set) Token: 0x06001B8E RID: 7054 RVA: 0x00014DC2 File Offset: 0x00012FC2
		public bool showSettingsGroupLabel
		{
			get
			{
				return this._showSettingsGroupLabel;
			}
			set
			{
				this._showSettingsGroupLabel = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06001B8F RID: 7055 RVA: 0x00014DD2 File Offset: 0x00012FD2
		// (set) Token: 0x06001B90 RID: 7056 RVA: 0x00014DDA File Offset: 0x00012FDA
		public bool showMapCategoriesGroupLabel
		{
			get
			{
				return this._showMapCategoriesGroupLabel;
			}
			set
			{
				this._showMapCategoriesGroupLabel = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06001B91 RID: 7057 RVA: 0x00014DEA File Offset: 0x00012FEA
		// (set) Token: 0x06001B92 RID: 7058 RVA: 0x00014DF2 File Offset: 0x00012FF2
		public bool showControllerNameLabel
		{
			get
			{
				return this._showControllerNameLabel;
			}
			set
			{
				this._showControllerNameLabel = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06001B93 RID: 7059 RVA: 0x00014E02 File Offset: 0x00013002
		// (set) Token: 0x06001B94 RID: 7060 RVA: 0x00014E0A File Offset: 0x0001300A
		public bool showAssignedControllers
		{
			get
			{
				return this._showAssignedControllers;
			}
			set
			{
				this._showAssignedControllers = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06001B95 RID: 7061 RVA: 0x00014E1A File Offset: 0x0001301A
		// (set) Token: 0x06001B96 RID: 7062 RVA: 0x00014E22 File Offset: 0x00013022
		public Action restoreDefaultsDelegate
		{
			get
			{
				return this._restoreDefaultsDelegate;
			}
			set
			{
				this._restoreDefaultsDelegate = value;
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06001B97 RID: 7063 RVA: 0x00014E2B File Offset: 0x0001302B
		public bool isOpen
		{
			get
			{
				if (!this.initialized)
				{
					return this.references.canvas != null && this.references.canvas.gameObject.activeInHierarchy;
				}
				return this.canvas.activeInHierarchy;
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06001B98 RID: 7064 RVA: 0x00014E6B File Offset: 0x0001306B
		private bool isFocused
		{
			get
			{
				return this.initialized && !this.windowManager.isWindowOpen;
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06001B99 RID: 7065 RVA: 0x00014E85 File Offset: 0x00013085
		private bool inputAllowed
		{
			get
			{
				return this.blockInputOnFocusEndTime <= Time.unscaledTime;
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06001B9A RID: 7066 RVA: 0x000CB24C File Offset: 0x000C944C
		private int inputGridColumnCount
		{
			get
			{
				int num = 1;
				if (this._showKeyboard)
				{
					num++;
				}
				if (this._showMouse)
				{
					num++;
				}
				if (this._showControllers)
				{
					num++;
				}
				return num;
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06001B9B RID: 7067 RVA: 0x000CB280 File Offset: 0x000C9480
		private int inputGridWidth
		{
			get
			{
				return this._actionLabelWidth + (this._showKeyboard ? this._keyboardColMaxWidth : 0) + (this._showMouse ? this._mouseColMaxWidth : 0) + (this._showControllers ? this._controllerColMaxWidth : 0) + (this.inputGridColumnCount - 1) * this._inputColumnSpacing;
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06001B9C RID: 7068 RVA: 0x00014E97 File Offset: 0x00013097
		private Player currentPlayer
		{
			get
			{
				return ReInput.players.GetPlayer(this.currentPlayerId);
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06001B9D RID: 7069 RVA: 0x00014EA9 File Offset: 0x000130A9
		private InputCategory currentMapCategory
		{
			get
			{
				return ReInput.mapping.GetMapCategory(this.currentMapCategoryId);
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06001B9E RID: 7070 RVA: 0x000CB2DC File Offset: 0x000C94DC
		private ControlMapper.MappingSet currentMappingSet
		{
			get
			{
				if (this.currentMapCategoryId < 0)
				{
					return null;
				}
				for (int i = 0; i < this._mappingSets.Length; i++)
				{
					if (this._mappingSets[i].mapCategoryId == this.currentMapCategoryId)
					{
						return this._mappingSets[i];
					}
				}
				return null;
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06001B9F RID: 7071 RVA: 0x00014EBB File Offset: 0x000130BB
		private Joystick currentJoystick
		{
			get
			{
				return ReInput.controllers.GetJoystick(this.currentJoystickId);
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06001BA0 RID: 7072 RVA: 0x00014ECD File Offset: 0x000130CD
		private bool isJoystickSelected
		{
			get
			{
				return this.currentJoystickId >= 0;
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06001BA1 RID: 7073 RVA: 0x00014EDB File Offset: 0x000130DB
		private GameObject currentUISelection
		{
			get
			{
				if (!(EventSystem.current != null))
				{
					return null;
				}
				return EventSystem.current.currentSelectedGameObject;
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06001BA2 RID: 7074 RVA: 0x00014EF6 File Offset: 0x000130F6
		private bool showSettings
		{
			get
			{
				return this._showInputBehaviorSettings && this._inputBehaviorSettings.Length != 0;
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06001BA3 RID: 7075 RVA: 0x00014F0C File Offset: 0x0001310C
		private bool showMapCategories
		{
			get
			{
				return this._mappingSets != null && this._mappingSets.Length > 1;
			}
		}

		// Token: 0x06001BA4 RID: 7076 RVA: 0x00014F26 File Offset: 0x00013126
		private void Awake()
		{
			if (this._dontDestroyOnLoad)
			{
				global::UnityEngine.Object.DontDestroyOnLoad(base.transform.gameObject);
			}
			this.PreInitialize();
			if (this.isOpen)
			{
				this.Initialize();
				this.Open(true);
			}
		}

		// Token: 0x06001BA5 RID: 7077 RVA: 0x00014F5B File Offset: 0x0001315B
		private void Start()
		{
			if (this._openOnStart)
			{
				this.Open(false);
			}
		}

		// Token: 0x06001BA6 RID: 7078 RVA: 0x00014F6C File Offset: 0x0001316C
		private void Update()
		{
			if (!this.isOpen)
			{
				return;
			}
			if (!this.initialized)
			{
				return;
			}
			this.CheckUISelection();
		}

		// Token: 0x06001BA7 RID: 7079 RVA: 0x00014F86 File Offset: 0x00013186
		private void OnDestroy()
		{
			ReInput.ControllerConnectedEvent -= this.OnJoystickConnected;
			ReInput.ControllerDisconnectedEvent -= this.OnJoystickDisconnected;
			ReInput.ControllerPreDisconnectEvent -= this.OnJoystickPreDisconnect;
			this.UnsubscribeMenuControlInputEvents();
		}

		// Token: 0x06001BA8 RID: 7080 RVA: 0x00014FC1 File Offset: 0x000131C1
		private void PreInitialize()
		{
			if (!ReInput.isReady)
			{
				Debug.LogError("Rewired Control Mapper: Rewired has not been initialized! Are you missing a Rewired Input Manager in your scene?");
				return;
			}
			this.SubscribeMenuControlInputEvents();
		}

		// Token: 0x06001BA9 RID: 7081 RVA: 0x000CB328 File Offset: 0x000C9528
		private void Initialize()
		{
			if (this.initialized)
			{
				return;
			}
			if (!ReInput.isReady)
			{
				return;
			}
			if (this._rewiredInputManager == null)
			{
				this._rewiredInputManager = global::UnityEngine.Object.FindObjectOfType<InputManager>();
				if (this._rewiredInputManager == null)
				{
					Debug.LogError("Rewired Control Mapper: A Rewired Input Manager was not assigned in the inspector or found in the current scene! Control Mapper will not function.");
					return;
				}
			}
			if (ControlMapper.Instance != null)
			{
				Debug.LogError("Rewired Control Mapper: Only one ControlMapper can exist at one time!");
				return;
			}
			ControlMapper.Instance = this;
			if (this.prefabs == null || !this.prefabs.Check())
			{
				Debug.LogError("Rewired Control Mapper: All prefabs must be assigned in the inspector!");
				return;
			}
			if (this.references == null || !this.references.Check())
			{
				Debug.LogError("Rewired Control Mapper: All references must be assigned in the inspector!");
				return;
			}
			this.references.inputGridLayoutElement = this.references.inputGridContainer.GetComponent<LayoutElement>();
			if (this.references.inputGridLayoutElement == null)
			{
				Debug.LogError("Rewired Control Mapper: InputGridContainer is missing LayoutElement component!");
				return;
			}
			if (this._showKeyboard && this._keyboardInputFieldCount < 1)
			{
				Debug.LogWarning("Rewired Control Mapper: Keyboard Input Fields must be at least 1!");
				this._keyboardInputFieldCount = 1;
			}
			if (this._showMouse && this._mouseInputFieldCount < 1)
			{
				Debug.LogWarning("Rewired Control Mapper: Mouse Input Fields must be at least 1!");
				this._mouseInputFieldCount = 1;
			}
			if (this._showControllers && this._controllerInputFieldCount < 1)
			{
				Debug.LogWarning("Rewired Control Mapper: Controller Input Fields must be at least 1!");
				this._controllerInputFieldCount = 1;
			}
			if (this._maxControllersPerPlayer < 0)
			{
				Debug.LogWarning("Rewired Control Mapper: Max Controllers Per Player must be at least 0 (no limit)!");
				this._maxControllersPerPlayer = 0;
			}
			if (this._useThemeSettings && this._themeSettings == null)
			{
				Debug.LogWarning("Rewired Control Mapper: To use theming, Theme Settings must be set in the inspector! Theming has been disabled.");
				this._useThemeSettings = false;
			}
			if (this._language == null)
			{
				Debug.LogError("Rawired UI: Language must be set in the inspector!");
				return;
			}
			this._language.Initialize();
			this.inputFieldActivatedDelegate = new Action<InputFieldInfo>(this.OnInputFieldActivated);
			this.inputFieldInvertToggleStateChangedDelegate = new Action<ToggleInfo, bool>(this.OnInputFieldInvertToggleStateChanged);
			ReInput.ControllerConnectedEvent += this.OnJoystickConnected;
			ReInput.ControllerDisconnectedEvent += this.OnJoystickDisconnected;
			ReInput.ControllerPreDisconnectEvent += this.OnJoystickPreDisconnect;
			this.playerCount = ReInput.players.playerCount;
			this.canvas = this.references.canvas.gameObject;
			this.windowManager = new ControlMapper.WindowManager(this.prefabs.window, this.prefabs.fader, this.references.canvas.transform);
			this.playerButtons = new List<ControlMapper.GUIButton>();
			this.mapCategoryButtons = new List<ControlMapper.GUIButton>();
			this.assignedControllerButtons = new List<ControlMapper.GUIButton>();
			this.miscInstantiatedObjects = new List<GameObject>();
			this.currentMapCategoryId = this._mappingSets[0].mapCategoryId;
			this.Draw();
			this.CreateInputGrid();
			this.CreateLayout();
			this.SubscribeFixedUISelectionEvents();
			this.initialized = true;
			this.informationText.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("mapperInformation");
			this.windowTitleText.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this.windowTitleText.text);
			this.playersSectionTitleText.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("mapperPlayersLabel");
			this.controllerSectionTitleText.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("mapperControllerLabel");
			this.assignedControllersSectionTitle.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("mapperAssignedControllersTitle") + ":";
		}

		// Token: 0x06001BAA RID: 7082 RVA: 0x00014FDB File Offset: 0x000131DB
		private void OnJoystickConnected(ControllerStatusChangedEventArgs args)
		{
			if (!this.initialized)
			{
				return;
			}
			if (!this._showControllers)
			{
				return;
			}
			this.ClearVarsOnJoystickChange();
			this.ForceRefresh();
		}

		// Token: 0x06001BAB RID: 7083 RVA: 0x00014FDB File Offset: 0x000131DB
		private void OnJoystickDisconnected(ControllerStatusChangedEventArgs args)
		{
			if (!this.initialized)
			{
				return;
			}
			if (!this._showControllers)
			{
				return;
			}
			this.ClearVarsOnJoystickChange();
			this.ForceRefresh();
		}

		// Token: 0x06001BAC RID: 7084 RVA: 0x00014FFB File Offset: 0x000131FB
		private void OnJoystickPreDisconnect(ControllerStatusChangedEventArgs args)
		{
			if (!this.initialized)
			{
				return;
			}
			bool showControllers = this._showControllers;
		}

		// Token: 0x06001BAD RID: 7085 RVA: 0x000CB678 File Offset: 0x000C9878
		public void OnButtonActivated(ButtonInfo buttonInfo)
		{
			if (!this.initialized)
			{
				return;
			}
			if (!this.inputAllowed)
			{
				return;
			}
			string identifier = buttonInfo.identifier;
			uint num = PrivateImplementationDetails.ComputeStringHash(identifier);
			if (num <= 1656078790U)
			{
				if (num <= 1293854844U)
				{
					if (num != 36291085U)
					{
						if (num != 1293854844U)
						{
							return;
						}
						if (!(identifier == "AssignController"))
						{
							return;
						}
						this.ShowAssignControllerWindow();
						return;
					}
					else
					{
						if (!(identifier == "MapCategorySelection"))
						{
							return;
						}
						this.OnMapCategorySelected(buttonInfo.intData, true);
						return;
					}
				}
				else if (num != 1619204974U)
				{
					if (num != 1656078790U)
					{
						return;
					}
					if (!(identifier == "EditInputBehaviors"))
					{
						return;
					}
					this.ShowEditInputBehaviorsWindow();
					return;
				}
				else
				{
					if (!(identifier == "PlayerSelection"))
					{
						return;
					}
					this.OnPlayerSelected(buttonInfo.intData, true);
					return;
				}
			}
			else if (num <= 2379421585U)
			{
				if (num != 2139278426U)
				{
					if (num != 2379421585U)
					{
						return;
					}
					if (!(identifier == "Done"))
					{
						return;
					}
					this.Close(true);
					return;
				}
				else
				{
					if (!(identifier == "CalibrateController"))
					{
						return;
					}
					this.ShowCalibrateControllerWindow();
					return;
				}
			}
			else if (num != 2857234147U)
			{
				if (num != 3019194153U)
				{
					if (num != 3496297297U)
					{
						return;
					}
					if (!(identifier == "AssignedControllerSelection"))
					{
						return;
					}
					this.OnControllerSelected(buttonInfo.intData);
					return;
				}
				else
				{
					if (!(identifier == "RemoveController"))
					{
						return;
					}
					this.OnRemoveCurrentController();
					return;
				}
			}
			else
			{
				if (!(identifier == "RestoreDefaults"))
				{
					return;
				}
				this.OnRestoreDefaults();
				return;
			}
		}

		// Token: 0x06001BAE RID: 7086 RVA: 0x000CB7E0 File Offset: 0x000C99E0
		public void OnInputFieldActivated(InputFieldInfo fieldInfo)
		{
			if (!this.initialized)
			{
				return;
			}
			if (!this.inputAllowed)
			{
				return;
			}
			if (this.currentPlayer == null)
			{
				return;
			}
			InputAction action = ReInput.mapping.GetAction(fieldInfo.actionId);
			if (action == null)
			{
				return;
			}
			AxisRange axisRange = ((action.type == InputActionType.Axis) ? fieldInfo.axisRange : AxisRange.Full);
			string actionName = this._language.GetActionName(action.id, axisRange);
			ControllerMap controllerMap = this.GetControllerMap(fieldInfo.controllerType);
			if (controllerMap == null)
			{
				return;
			}
			ActionElementMap actionElementMap = ((fieldInfo.actionElementMapId >= 0) ? controllerMap.GetElementMap(fieldInfo.actionElementMapId) : null);
			if (actionElementMap != null)
			{
				this.ShowBeginElementAssignmentReplacementWindow(fieldInfo, action, controllerMap, actionElementMap, actionName);
				return;
			}
			this.ShowCreateNewElementAssignmentWindow(fieldInfo, action, controllerMap, actionName);
		}

		// Token: 0x06001BAF RID: 7087 RVA: 0x0001500D File Offset: 0x0001320D
		public void OnInputFieldInvertToggleStateChanged(ToggleInfo toggleInfo, bool newState)
		{
			if (!this.initialized)
			{
				return;
			}
			if (!this.inputAllowed)
			{
				return;
			}
			this.SetActionAxisInverted(newState, toggleInfo.controllerType, toggleInfo.actionElementMapId);
		}

		// Token: 0x06001BB0 RID: 7088 RVA: 0x00015034 File Offset: 0x00013234
		private void OnPlayerSelected(int playerId, bool redraw)
		{
			if (!this.initialized)
			{
				return;
			}
			this.currentPlayerId = playerId;
			this.ClearVarsOnPlayerChange();
			if (redraw)
			{
				this.Redraw(true, true);
			}
		}

		// Token: 0x06001BB1 RID: 7089 RVA: 0x00015057 File Offset: 0x00013257
		private void OnControllerSelected(int joystickId)
		{
			if (!this.initialized)
			{
				return;
			}
			this.currentJoystickId = joystickId;
			this.Redraw(true, true);
		}

		// Token: 0x06001BB2 RID: 7090 RVA: 0x00015071 File Offset: 0x00013271
		private void OnRemoveCurrentController()
		{
			if (this.currentPlayer == null)
			{
				return;
			}
			if (this.currentJoystickId < 0)
			{
				return;
			}
			this.RemoveController(this.currentPlayer, this.currentJoystickId);
			this.ClearVarsOnJoystickChange();
			this.Redraw(false, false);
		}

		// Token: 0x06001BB3 RID: 7091 RVA: 0x000150A6 File Offset: 0x000132A6
		private void OnMapCategorySelected(int id, bool redraw)
		{
			if (!this.initialized)
			{
				return;
			}
			this.currentMapCategoryId = id;
			if (redraw)
			{
				this.Redraw(true, true);
			}
		}

		// Token: 0x06001BB4 RID: 7092 RVA: 0x000150C3 File Offset: 0x000132C3
		private void OnRestoreDefaults()
		{
			if (!this.initialized)
			{
				return;
			}
			this.ShowRestoreDefaultsWindow();
		}

		// Token: 0x06001BB5 RID: 7093 RVA: 0x000150D4 File Offset: 0x000132D4
		private void OnScreenToggleActionPressed(InputActionEventData data)
		{
			if (!this.isOpen)
			{
				this.Open();
				return;
			}
			if (!this.initialized)
			{
				return;
			}
			if (!this.isFocused)
			{
				return;
			}
			this.Close(true);
		}

		// Token: 0x06001BB6 RID: 7094 RVA: 0x000150FE File Offset: 0x000132FE
		private void OnScreenOpenActionPressed(InputActionEventData data)
		{
			this.Open();
		}

		// Token: 0x06001BB7 RID: 7095 RVA: 0x00015106 File Offset: 0x00013306
		private void OnScreenCloseActionPressed(InputActionEventData data)
		{
			if (!this.initialized)
			{
				return;
			}
			if (!this.isOpen)
			{
				return;
			}
			if (!this.isFocused)
			{
				return;
			}
			this.Close(true);
		}

		// Token: 0x06001BB8 RID: 7096 RVA: 0x0001512A File Offset: 0x0001332A
		private void OnUniversalCancelActionPressed(InputActionEventData data)
		{
			if (!this.initialized)
			{
				return;
			}
			if (!this.isOpen)
			{
				return;
			}
			if (this._universalCancelClosesScreen)
			{
				if (this.isFocused)
				{
					this.Close(true);
					return;
				}
			}
			else if (this.isFocused)
			{
				return;
			}
			this.CloseAllWindows();
		}

		// Token: 0x06001BB9 RID: 7097 RVA: 0x00015165 File Offset: 0x00013365
		private void OnWindowCancel(int windowId)
		{
			if (!this.initialized)
			{
				return;
			}
			if (windowId < 0)
			{
				return;
			}
			this.CloseWindow(windowId);
		}

		// Token: 0x06001BBA RID: 7098 RVA: 0x0001517C File Offset: 0x0001337C
		private void OnRemoveElementAssignment(int windowId, ControllerMap map, ActionElementMap aem)
		{
			if (map == null || aem == null)
			{
				return;
			}
			map.DeleteElementMap(aem.id);
			this.CloseWindow(windowId);
		}

		// Token: 0x06001BBB RID: 7099 RVA: 0x000CB888 File Offset: 0x000C9A88
		private void OnBeginElementAssignment(InputFieldInfo fieldInfo, ControllerMap map, ActionElementMap aem, string actionName)
		{
			if (fieldInfo == null || map == null)
			{
				return;
			}
			this.pendingInputMapping = new ControlMapper.InputMapping(actionName, fieldInfo, map, aem, fieldInfo.controllerType, fieldInfo.controllerId);
			switch (fieldInfo.controllerType)
			{
			case ControllerType.Keyboard:
				this.ShowElementAssignmentPollingWindow();
				return;
			case ControllerType.Mouse:
				this.ShowElementAssignmentPollingWindow();
				return;
			case ControllerType.Joystick:
				this.ShowElementAssignmentPrePollingWindow();
				return;
			default:
				throw new NotImplementedException();
			}
		}

		// Token: 0x06001BBC RID: 7100 RVA: 0x00015199 File Offset: 0x00013399
		private void OnControllerAssignmentConfirmed(int windowId, Player player, int controllerId)
		{
			if (windowId < 0 || player == null || controllerId < 0)
			{
				return;
			}
			this.AssignController(player, controllerId);
			this.CloseWindow(windowId);
		}

		// Token: 0x06001BBD RID: 7101 RVA: 0x000CB8F4 File Offset: 0x000C9AF4
		private void OnMouseAssignmentConfirmed(int windowId, Player player)
		{
			if (windowId < 0 || player == null)
			{
				return;
			}
			IList<Player> players = ReInput.players.Players;
			for (int i = 0; i < players.Count; i++)
			{
				if (players[i] != player)
				{
					players[i].controllers.hasMouse = false;
				}
			}
			player.controllers.hasMouse = true;
			this.CloseWindow(windowId);
		}

		// Token: 0x06001BBE RID: 7102 RVA: 0x000CB954 File Offset: 0x000C9B54
		private void OnElementAssignmentConflictReplaceConfirmed(int windowId, ControlMapper.InputMapping mapping, ElementAssignment assignment, bool skipOtherPlayers, bool allowSwap)
		{
			if (this.currentPlayer == null || mapping == null)
			{
				return;
			}
			ElementAssignmentConflictCheck elementAssignmentConflictCheck;
			if (!this.CreateConflictCheck(mapping, assignment, out elementAssignmentConflictCheck))
			{
				Debug.LogError("Rewired Control Mapper: Error creating conflict check!");
				this.CloseWindow(windowId);
				return;
			}
			ElementAssignmentConflictInfo elementAssignmentConflictInfo = default(ElementAssignmentConflictInfo);
			ActionElementMap actionElementMap = null;
			ActionElementMap actionElementMap2 = null;
			bool flag = false;
			if (allowSwap && mapping.aem != null && this.GetFirstElementAssignmentConflict(elementAssignmentConflictCheck, out elementAssignmentConflictInfo, skipOtherPlayers))
			{
				flag = true;
				actionElementMap2 = new ActionElementMap(mapping.aem);
				actionElementMap = new ActionElementMap(elementAssignmentConflictInfo.elementMap);
			}
			IList<Player> allPlayers = ReInput.players.AllPlayers;
			for (int i = 0; i < allPlayers.Count; i++)
			{
				Player player = allPlayers[i];
				if (!skipOtherPlayers || player == this.currentPlayer || player == ReInput.players.SystemPlayer)
				{
					player.controllers.conflictChecking.RemoveElementAssignmentConflicts(elementAssignmentConflictCheck);
				}
			}
			mapping.map.ReplaceOrCreateElementMap(assignment);
			if (allowSwap && flag)
			{
				int actionId = actionElementMap.actionId;
				Pole axisContribution = actionElementMap.axisContribution;
				bool flag2 = actionElementMap.invert;
				AxisRange axisRange = actionElementMap2.axisRange;
				ControllerElementType elementType = actionElementMap2.elementType;
				int elementIdentifierId = actionElementMap2.elementIdentifierId;
				KeyCode keyCode = actionElementMap2.keyCode;
				ModifierKeyFlags modifierKeyFlags = actionElementMap2.modifierKeyFlags;
				if (elementType == actionElementMap.elementType && elementType == ControllerElementType.Axis)
				{
					if (axisRange != actionElementMap.axisRange)
					{
						if (axisRange == AxisRange.Full)
						{
							axisRange = AxisRange.Positive;
						}
						else if (actionElementMap.axisRange == AxisRange.Full)
						{
						}
					}
				}
				else if (elementType == ControllerElementType.Axis && (actionElementMap.elementType == ControllerElementType.Button || (actionElementMap.elementType == ControllerElementType.Axis && actionElementMap.axisRange != AxisRange.Full)) && axisRange == AxisRange.Full)
				{
					axisRange = AxisRange.Positive;
				}
				if (elementType != ControllerElementType.Axis || axisRange != AxisRange.Full)
				{
					flag2 = false;
				}
				int num = 0;
				foreach (ActionElementMap actionElementMap3 in elementAssignmentConflictInfo.controllerMap.ElementMapsWithAction(actionId))
				{
					if (this.SwapIsSameInputRange(elementType, axisRange, axisContribution, actionElementMap3.elementType, actionElementMap3.axisRange, actionElementMap3.axisContribution))
					{
						num++;
					}
				}
				if (num < this.GetControllerInputFieldCount(mapping.controllerType))
				{
					elementAssignmentConflictInfo.controllerMap.ReplaceOrCreateElementMap(ElementAssignment.CompleteAssignment(mapping.controllerType, elementType, elementIdentifierId, axisRange, keyCode, modifierKeyFlags, actionId, axisContribution, flag2));
				}
			}
			this.CloseWindow(windowId);
		}

		// Token: 0x06001BBF RID: 7103 RVA: 0x000151B6 File Offset: 0x000133B6
		private void OnElementAssignmentAddConfirmed(int windowId, ControlMapper.InputMapping mapping, ElementAssignment assignment)
		{
			if (this.currentPlayer == null || mapping == null)
			{
				return;
			}
			mapping.map.ReplaceOrCreateElementMap(assignment);
			this.CloseWindow(windowId);
		}

		// Token: 0x06001BC0 RID: 7104 RVA: 0x000CBB90 File Offset: 0x000C9D90
		private void OnRestoreDefaultsConfirmed(int windowId)
		{
			if (this._restoreDefaultsDelegate == null)
			{
				IList<Player> players = ReInput.players.Players;
				for (int i = 0; i < players.Count; i++)
				{
					Player player = players[i];
					if (this._showControllers)
					{
						player.controllers.maps.LoadDefaultMaps(ControllerType.Joystick);
					}
					if (this._showKeyboard)
					{
						player.controllers.maps.LoadDefaultMaps(ControllerType.Keyboard);
					}
					if (this._showMouse)
					{
						player.controllers.maps.LoadDefaultMaps(ControllerType.Mouse);
					}
				}
			}
			this.CloseWindow(windowId);
			if (this._restoreDefaultsDelegate != null)
			{
				this._restoreDefaultsDelegate();
			}
		}

		// Token: 0x06001BC1 RID: 7105 RVA: 0x000CBC30 File Offset: 0x000C9E30
		private void OnAssignControllerWindowUpdate(int windowId)
		{
			if (this.currentPlayer == null)
			{
				return;
			}
			Window window = this.windowManager.GetWindow(windowId);
			if (windowId < 0)
			{
				return;
			}
			this.InputPollingStarted();
			if (window.timer.finished)
			{
				this.InputPollingStopped();
				this.CloseWindow(windowId);
				return;
			}
			ControllerPollingInfo controllerPollingInfo = ReInput.controllers.polling.PollAllControllersOfTypeForFirstElementDown(ControllerType.Joystick);
			if (!controllerPollingInfo.success)
			{
				window.SetContentText(Mathf.CeilToInt(window.timer.remaining).ToString(), 1);
				return;
			}
			this.InputPollingStopped();
			if (ReInput.controllers.IsControllerAssigned(ControllerType.Joystick, controllerPollingInfo.controllerId) && !this.currentPlayer.controllers.ContainsController(ControllerType.Joystick, controllerPollingInfo.controllerId))
			{
				this.ShowControllerAssignmentConflictWindow(controllerPollingInfo.controllerId);
				return;
			}
			this.OnControllerAssignmentConfirmed(windowId, this.currentPlayer, controllerPollingInfo.controllerId);
		}

		// Token: 0x06001BC2 RID: 7106 RVA: 0x000CBD0C File Offset: 0x000C9F0C
		private void OnElementAssignmentPrePollingWindowUpdate(int windowId)
		{
			if (this.currentPlayer == null)
			{
				return;
			}
			Window window = this.windowManager.GetWindow(windowId);
			if (windowId < 0)
			{
				return;
			}
			if (this.pendingInputMapping == null)
			{
				return;
			}
			this.InputPollingStarted();
			if (!window.timer.finished)
			{
				window.SetContentText(Mathf.CeilToInt(window.timer.remaining).ToString(), 1);
				ControllerType controllerType = this.pendingInputMapping.controllerType;
				ControllerPollingInfo controllerPollingInfo;
				if (controllerType > ControllerType.Mouse)
				{
					if (controllerType != ControllerType.Joystick)
					{
						throw new NotImplementedException();
					}
					if (this.currentPlayer.controllers.joystickCount == 0)
					{
						return;
					}
					controllerPollingInfo = ReInput.controllers.polling.PollControllerForFirstButtonDown(this.pendingInputMapping.controllerType, this.currentJoystick.id);
				}
				else
				{
					controllerPollingInfo = ReInput.controllers.polling.PollControllerForFirstButtonDown(this.pendingInputMapping.controllerType, 0);
				}
				if (!controllerPollingInfo.success)
				{
					return;
				}
			}
			this.ShowElementAssignmentPollingWindow();
		}

		// Token: 0x06001BC3 RID: 7107 RVA: 0x000151D8 File Offset: 0x000133D8
		private static void ReplaceOrCreateDrumModifierElementMap(ControllerMap map, ElementAssignment assignment)
		{
			map.DeleteElementMapsWithAction(assignment.actionId);
			map.CreateElementMap(assignment);
		}

		// Token: 0x06001BC4 RID: 7108 RVA: 0x000CBDF8 File Offset: 0x000C9FF8
		private void OnJoystickElementAssignmentPollingWindowUpdate(int windowId)
		{
			if (this.currentPlayer == null)
			{
				return;
			}
			Window window = this.windowManager.GetWindow(windowId);
			if (windowId < 0)
			{
				return;
			}
			if (this.pendingInputMapping == null)
			{
				return;
			}
			this.InputPollingStarted();
			if (window.timer.finished)
			{
				this.InputPollingStopped();
				this.CloseWindow(windowId);
				return;
			}
			window.SetContentText(Mathf.CeilToInt(window.timer.remaining).ToString(), 1);
			if (this.currentPlayer.controllers.joystickCount == 0)
			{
				return;
			}
			List<ControllerPollingInfo> list = new List<ControllerPollingInfo>(ReInput.controllers.polling.PollControllerForAllElementsDown(ControllerType.Joystick, this.currentJoystick.id));
			ControllerPollingInfo controllerPollingInfo = ReInput.controllers.polling.PollControllerForFirstElementDown(ControllerType.Joystick, this.currentJoystick.id);
			if (!controllerPollingInfo.success)
			{
				return;
			}
			if (!this.IsAllowedAssignment(this.pendingInputMapping, controllerPollingInfo))
			{
				return;
			}
			ElementAssignment elementAssignment = this.pendingInputMapping.ToElementAssignment(controllerPollingInfo);
			int actionId = this.pendingInputMapping.fieldInfo.actionId;
			if ((actionId == 0 || actionId == 2 || actionId == 3 || actionId == 39 || actionId == 37 || actionId == 38) && controllerPollingInfo.elementType == ControllerElementType.Axis)
			{
				return;
			}
			if (list.Count > 1)
			{
				ElementAssignment elementAssignment2 = default(ElementAssignment);
				ElementAssignment elementAssignment3 = default(ElementAssignment);
				if (actionId == 1)
				{
					elementAssignment2 = this.pendingInputMapping.ToElementAssignment(list[1]);
					elementAssignment2.actionId = 40;
					ControlMapper.ReplaceOrCreateDrumModifierElementMap(this.pendingInputMapping.map, elementAssignment2);
				}
				else if (actionId == 0 || actionId == 2 || actionId == 3 || actionId == 39 || actionId == 37 || actionId == 38)
				{
					bool flag = false;
					if (this.CheckMapActionIDForButtonDuplicate(this.pendingInputMapping.map, this.tomCymMap[actionId], controllerPollingInfo.elementIndex))
					{
						this.pendingInputMapping.map.ReplaceOrCreateElementMap(elementAssignment);
						this.InputPollingStopped();
						this.CloseWindow(windowId);
						flag = true;
					}
					ControllerPollingInfo controllerPollingInfo2 = default(ControllerPollingInfo);
					ControllerPollingInfo controllerPollingInfo3 = default(ControllerPollingInfo);
					if (list.Count > 2)
					{
						using (List<ControllerPollingInfo>.Enumerator enumerator = list.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								ControllerPollingInfo controllerPollingInfo4 = enumerator.Current;
								if (controllerPollingInfo4.elementIdentifierName.Contains("up", StringComparison.OrdinalIgnoreCase))
								{
									controllerPollingInfo3 = controllerPollingInfo4;
								}
								else if (controllerPollingInfo4.elementIdentifierName.Contains("down", StringComparison.OrdinalIgnoreCase))
								{
									controllerPollingInfo3 = controllerPollingInfo4;
								}
								else if (controllerPollingInfo4.elementType == ControllerElementType.Button)
								{
									controllerPollingInfo2 = controllerPollingInfo4;
								}
							}
							goto IL_02A0;
						}
					}
					foreach (ControllerPollingInfo controllerPollingInfo5 in list)
					{
						Debug.Log(controllerPollingInfo5);
					}
					controllerPollingInfo2 = list[1];
					IL_02A0:
					if (actionId != 0 && actionId - 2 > 1)
					{
						switch (actionId)
						{
						case 37:
							elementAssignment2 = this.pendingInputMapping.ToElementAssignment(controllerPollingInfo2);
							elementAssignment2.actionId = 41;
							ControlMapper.ReplaceOrCreateDrumModifierElementMap(this.pendingInputMapping.map, elementAssignment2);
							elementAssignment3 = this.pendingInputMapping.ToElementAssignment(controllerPollingInfo3);
							elementAssignment3.actionId = 42;
							ControlMapper.ReplaceOrCreateDrumModifierElementMap(this.pendingInputMapping.map, elementAssignment3);
							break;
						case 38:
							elementAssignment2 = this.pendingInputMapping.ToElementAssignment(controllerPollingInfo2);
							elementAssignment2.actionId = 41;
							ControlMapper.ReplaceOrCreateDrumModifierElementMap(this.pendingInputMapping.map, elementAssignment2);
							elementAssignment3 = this.pendingInputMapping.ToElementAssignment(controllerPollingInfo3);
							elementAssignment3.actionId = 43;
							ControlMapper.ReplaceOrCreateDrumModifierElementMap(this.pendingInputMapping.map, elementAssignment3);
							break;
						case 39:
							elementAssignment2 = this.pendingInputMapping.ToElementAssignment(controllerPollingInfo2);
							elementAssignment2.actionId = 41;
							ControlMapper.ReplaceOrCreateDrumModifierElementMap(this.pendingInputMapping.map, elementAssignment2);
							break;
						}
					}
					else
					{
						elementAssignment2 = this.pendingInputMapping.ToElementAssignment(controllerPollingInfo2);
						elementAssignment2.actionId = 40;
						ControlMapper.ReplaceOrCreateDrumModifierElementMap(this.pendingInputMapping.map, elementAssignment2);
					}
					if (flag)
					{
						return;
					}
				}
			}
			if (!this.HasElementAssignmentConflicts(this.currentPlayer, this.pendingInputMapping, elementAssignment, false))
			{
				this.pendingInputMapping.map.ReplaceOrCreateElementMap(elementAssignment);
				this.InputPollingStopped();
				this.CloseWindow(windowId);
				return;
			}
			this.InputPollingStopped();
			this.ShowElementAssignmentConflictWindow(elementAssignment, false);
		}

		// Token: 0x06001BC5 RID: 7109 RVA: 0x000CC238 File Offset: 0x000CA438
		private bool CheckMapActionIDForButtonDuplicate(ControllerMap map, int v, int elementIndex)
		{
			foreach (ActionElementMap actionElementMap in map.AllMaps)
			{
				if (actionElementMap.actionId == v && actionElementMap.elementIndex == elementIndex)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001BC6 RID: 7110 RVA: 0x000CC298 File Offset: 0x000CA498
		private void OnKeyboardElementAssignmentPollingWindowUpdate(int windowId)
		{
			if (this.currentPlayer == null)
			{
				return;
			}
			Window window = this.windowManager.GetWindow(windowId);
			if (windowId < 0)
			{
				return;
			}
			if (this.pendingInputMapping == null)
			{
				return;
			}
			this.InputPollingStarted();
			if (window.timer.finished)
			{
				this.InputPollingStopped();
				this.CloseWindow(windowId);
				return;
			}
			ControllerPollingInfo controllerPollingInfo;
			bool flag;
			ModifierKeyFlags modifierKeyFlags;
			string text;
			this.PollKeyboardForAssignment(out controllerPollingInfo, out flag, out modifierKeyFlags, out text);
			if (flag)
			{
				window.timer.Start(this._inputAssignmentTimeout);
			}
			window.SetContentText(flag ? string.Empty : Mathf.CeilToInt(window.timer.remaining).ToString(), 2);
			window.SetContentText(text, 1);
			if (!controllerPollingInfo.success)
			{
				return;
			}
			if (!this.IsAllowedAssignment(this.pendingInputMapping, controllerPollingInfo))
			{
				return;
			}
			ElementAssignment elementAssignment = this.pendingInputMapping.ToElementAssignment(controllerPollingInfo, modifierKeyFlags);
			if (!this.HasElementAssignmentConflicts(this.currentPlayer, this.pendingInputMapping, elementAssignment, false))
			{
				this.pendingInputMapping.map.ReplaceOrCreateElementMap(elementAssignment);
				this.InputPollingStopped();
				this.CloseWindow(windowId);
				return;
			}
			this.InputPollingStopped();
			this.ShowElementAssignmentConflictWindow(elementAssignment, false);
		}

		// Token: 0x06001BC7 RID: 7111 RVA: 0x000CC3B0 File Offset: 0x000CA5B0
		private void OnMouseElementAssignmentPollingWindowUpdate(int windowId)
		{
			if (this.currentPlayer == null)
			{
				return;
			}
			Window window = this.windowManager.GetWindow(windowId);
			if (windowId < 0)
			{
				return;
			}
			if (this.pendingInputMapping == null)
			{
				return;
			}
			this.InputPollingStarted();
			if (window.timer.finished)
			{
				this.InputPollingStopped();
				this.CloseWindow(windowId);
				return;
			}
			window.SetContentText(Mathf.CeilToInt(window.timer.remaining).ToString(), 1);
			ControllerPollingInfo controllerPollingInfo;
			if (this._ignoreMouseXAxisAssignment || this._ignoreMouseYAxisAssignment)
			{
				controllerPollingInfo = default(ControllerPollingInfo);
				using (IEnumerator<ControllerPollingInfo> enumerator = ReInput.controllers.polling.PollControllerForAllElementsDown(ControllerType.Mouse, 0).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						ControllerPollingInfo controllerPollingInfo2 = enumerator.Current;
						if (controllerPollingInfo2.elementType != ControllerElementType.Axis || ((!this._ignoreMouseXAxisAssignment || controllerPollingInfo2.elementIndex != 0) && (!this._ignoreMouseYAxisAssignment || controllerPollingInfo2.elementIndex != 1)))
						{
							controllerPollingInfo = controllerPollingInfo2;
							break;
						}
					}
					goto IL_00F9;
				}
			}
			controllerPollingInfo = ReInput.controllers.polling.PollControllerForFirstElementDown(ControllerType.Mouse, 0);
			IL_00F9:
			if (!controllerPollingInfo.success)
			{
				return;
			}
			if (!this.IsAllowedAssignment(this.pendingInputMapping, controllerPollingInfo))
			{
				return;
			}
			ElementAssignment elementAssignment = this.pendingInputMapping.ToElementAssignment(controllerPollingInfo);
			if (!this.HasElementAssignmentConflicts(this.currentPlayer, this.pendingInputMapping, elementAssignment, true))
			{
				this.pendingInputMapping.map.ReplaceOrCreateElementMap(elementAssignment);
				this.InputPollingStopped();
				this.CloseWindow(windowId);
				return;
			}
			this.InputPollingStopped();
			this.ShowElementAssignmentConflictWindow(elementAssignment, true);
		}

		// Token: 0x06001BC8 RID: 7112 RVA: 0x000CC534 File Offset: 0x000CA734
		private void OnCalibrateAxisStep1WindowUpdate(int windowId)
		{
			if (this.currentPlayer == null)
			{
				return;
			}
			Window window = this.windowManager.GetWindow(windowId);
			if (windowId < 0)
			{
				return;
			}
			if (this.pendingAxisCalibration == null || !this.pendingAxisCalibration.isValid)
			{
				return;
			}
			this.InputPollingStarted();
			if (!window.timer.finished)
			{
				window.SetContentText(Mathf.CeilToInt(window.timer.remaining).ToString(), 1);
				if (this.currentPlayer.controllers.joystickCount == 0)
				{
					return;
				}
				if (!this.pendingAxisCalibration.joystick.PollForFirstButtonDown().success)
				{
					return;
				}
			}
			this.pendingAxisCalibration.RecordZero();
			this.CloseWindow(windowId);
			this.ShowCalibrateAxisStep2Window();
		}

		// Token: 0x06001BC9 RID: 7113 RVA: 0x000CC5EC File Offset: 0x000CA7EC
		private void OnCalibrateAxisStep2WindowUpdate(int windowId)
		{
			if (this.currentPlayer == null)
			{
				return;
			}
			Window window = this.windowManager.GetWindow(windowId);
			if (windowId < 0)
			{
				return;
			}
			if (this.pendingAxisCalibration == null || !this.pendingAxisCalibration.isValid)
			{
				return;
			}
			if (!window.timer.finished)
			{
				window.SetContentText(Mathf.CeilToInt(window.timer.remaining).ToString(), 1);
				this.pendingAxisCalibration.RecordMinMax();
				if (this.currentPlayer.controllers.joystickCount == 0)
				{
					return;
				}
				if (!this.pendingAxisCalibration.joystick.PollForFirstButtonDown().success)
				{
					return;
				}
			}
			this.EndAxisCalibration();
			this.InputPollingStopped();
			this.CloseWindow(windowId);
		}

		// Token: 0x06001BCA RID: 7114 RVA: 0x000CC6A4 File Offset: 0x000CA8A4
		private void ShowAssignControllerWindow()
		{
			if (this.currentPlayer == null)
			{
				return;
			}
			if (ReInput.controllers.joystickCount == 0)
			{
				return;
			}
			Window window = this.OpenWindow(true);
			if (window == null)
			{
				return;
			}
			window.SetUpdateCallback(new Action<int>(this.OnAssignControllerWindowUpdate));
			window.CreateTitleText(this.prefabs.windowTitleText, Vector2.zero, this._language.assignControllerWindowTitle);
			window.AddContentText(this.prefabs.windowContentText, UIPivot.TopCenter, UIAnchor.TopHStretch, new Vector2(0f, -100f), this._language.assignControllerWindowMessage);
			window.AddContentText(this.prefabs.windowContentText, UIPivot.BottomCenter, UIAnchor.BottomHStretch, Vector2.zero, "");
			window.timer.Start(this._controllerAssignmentTimeout);
			this.windowManager.Focus(window);
		}

		// Token: 0x06001BCB RID: 7115 RVA: 0x000CC784 File Offset: 0x000CA984
		private void ShowControllerAssignmentConflictWindow(int controllerId)
		{
			if (this.currentPlayer == null)
			{
				return;
			}
			if (ReInput.controllers.joystickCount == 0)
			{
				return;
			}
			Window window = this.OpenWindow(true);
			if (window == null)
			{
				return;
			}
			string text = string.Empty;
			IList<Player> players = ReInput.players.Players;
			for (int i = 0; i < players.Count; i++)
			{
				if (players[i] != this.currentPlayer && players[i].controllers.ContainsController(ControllerType.Joystick, controllerId))
				{
					text = this._language.GetPlayerName(players[i].id);
					break;
				}
			}
			Joystick joystick = ReInput.controllers.GetJoystick(controllerId);
			window.CreateTitleText(this.prefabs.windowTitleText, Vector2.zero, this._language.controllerAssignmentConflictWindowTitle);
			window.AddContentText(this.prefabs.windowContentText, UIPivot.TopCenter, UIAnchor.TopHStretch, new Vector2(0f, -100f), this._language.GetControllerAssignmentConflictWindowMessage(this._language.GetControllerName(joystick), text, this._language.GetPlayerName(this.currentPlayer.id)));
			UnityAction unityAction = delegate
			{
				this.OnWindowCancel(window.id);
			};
			window.cancelCallback = unityAction;
			window.CreateButton(this.prefabs.fitButton, UIPivot.BottomLeft, UIAnchor.BottomLeft, Vector2.zero, this._language.yes, delegate
			{
				this.OnControllerAssignmentConfirmed(window.id, this.currentPlayer, controllerId);
			}, unityAction, true);
			window.CreateButton(this.prefabs.fitButton, UIPivot.BottomRight, UIAnchor.BottomRight, Vector2.zero, this._language.no, unityAction, unityAction, false);
			this.windowManager.Focus(window);
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x000CC978 File Offset: 0x000CAB78
		private void ShowBeginElementAssignmentReplacementWindow(InputFieldInfo fieldInfo, InputAction action, ControllerMap map, ActionElementMap aem, string actionName)
		{
			ControlMapper.GUIInputField guiinputField = this.inputGrid.GetGUIInputField(this.currentMapCategoryId, action.id, fieldInfo.axisRange, fieldInfo.controllerType, fieldInfo.intData);
			if (guiinputField == null)
			{
				return;
			}
			Window window = this.OpenWindow(true);
			if (window == null)
			{
				return;
			}
			window.CreateTitleText(this.prefabs.windowTitleText, Vector2.zero, actionName);
			window.AddContentText(this.prefabs.windowContentText, UIPivot.TopCenter, UIAnchor.TopHStretch, new Vector2(0f, -100f), guiinputField.GetLabel());
			UnityAction unityAction = delegate
			{
				this.OnWindowCancel(window.id);
			};
			window.cancelCallback = unityAction;
			window.CreateButton(this.prefabs.fitButton, UIPivot.BottomLeft, UIAnchor.BottomLeft, Vector2.zero, this._language.replace, delegate
			{
				this.OnBeginElementAssignment(fieldInfo, map, aem, actionName);
			}, unityAction, true);
			window.CreateButton(this.prefabs.fitButton, UIPivot.BottomCenter, UIAnchor.BottomCenter, Vector2.zero, this._language.remove, delegate
			{
				this.OnRemoveElementAssignment(window.id, map, aem);
			}, unityAction, false);
			window.CreateButton(this.prefabs.fitButton, UIPivot.BottomRight, UIAnchor.BottomRight, Vector2.zero, this._language.cancel, unityAction, unityAction, false);
			this.windowManager.Focus(window);
		}

		// Token: 0x06001BCD RID: 7117 RVA: 0x000151EF File Offset: 0x000133EF
		private void ShowCreateNewElementAssignmentWindow(InputFieldInfo fieldInfo, InputAction action, ControllerMap map, string actionName)
		{
			if (this.inputGrid.GetGUIInputField(this.currentMapCategoryId, action.id, fieldInfo.axisRange, fieldInfo.controllerType, fieldInfo.intData) == null)
			{
				return;
			}
			this.OnBeginElementAssignment(fieldInfo, map, null, actionName);
		}

		// Token: 0x06001BCE RID: 7118 RVA: 0x000CCB38 File Offset: 0x000CAD38
		private void ShowElementAssignmentPrePollingWindow()
		{
			if (this.pendingInputMapping == null)
			{
				return;
			}
			Window window = this.OpenWindow(true);
			if (window == null)
			{
				return;
			}
			window.CreateTitleText(this.prefabs.windowTitleText, Vector2.zero, this.pendingInputMapping.actionName);
			window.AddContentText(this.prefabs.windowContentText, UIPivot.TopCenter, UIAnchor.TopHStretch, new Vector2(0f, -100f), this._language.elementAssignmentPrePollingWindowMessage);
			if (this.prefabs.centerStickGraphic != null)
			{
				window.AddContentImage(this.prefabs.centerStickGraphic, UIPivot.BottomCenter, UIAnchor.BottomCenter, new Vector2(0f, 40f));
			}
			window.AddContentText(this.prefabs.windowContentText, UIPivot.BottomCenter, UIAnchor.BottomHStretch, Vector2.zero, "");
			window.SetUpdateCallback(new Action<int>(this.OnElementAssignmentPrePollingWindowUpdate));
			window.timer.Start(this._preInputAssignmentTimeout);
			this.windowManager.Focus(window);
		}

		// Token: 0x06001BCF RID: 7119 RVA: 0x000CCC48 File Offset: 0x000CAE48
		private void ShowElementAssignmentPollingWindow()
		{
			if (this.pendingInputMapping == null)
			{
				return;
			}
			switch (this.pendingInputMapping.controllerType)
			{
			case ControllerType.Keyboard:
				this.ShowKeyboardElementAssignmentPollingWindow();
				return;
			case ControllerType.Mouse:
				if (this.currentPlayer.controllers.hasMouse)
				{
					this.ShowMouseElementAssignmentPollingWindow();
					return;
				}
				this.ShowMouseAssignmentConflictWindow();
				return;
			case ControllerType.Joystick:
				this.ShowJoystickElementAssignmentPollingWindow();
				return;
			default:
				throw new NotImplementedException();
			}
		}

		// Token: 0x06001BD0 RID: 7120 RVA: 0x000CCCB4 File Offset: 0x000CAEB4
		private void ShowJoystickElementAssignmentPollingWindow()
		{
			if (this.pendingInputMapping == null)
			{
				return;
			}
			Window window = this.OpenWindow(true);
			if (window == null)
			{
				return;
			}
			string text = ((this.pendingInputMapping.axisRange == AxisRange.Full && this._showFullAxisInputFields && !this._showSplitAxisInputFields) ? this._language.GetJoystickElementAssignmentPollingWindowMessage_FullAxisFieldOnly(this.pendingInputMapping.actionName) : this._language.GetJoystickElementAssignmentPollingWindowMessage(this.pendingInputMapping.actionName));
			window.CreateTitleText(this.prefabs.windowTitleText, Vector2.zero, this.pendingInputMapping.actionName);
			window.AddContentText(this.prefabs.windowContentText, UIPivot.TopCenter, UIAnchor.TopHStretch, new Vector2(0f, -100f), text);
			window.AddContentText(this.prefabs.windowContentText, UIPivot.BottomCenter, UIAnchor.BottomHStretch, Vector2.zero, "");
			window.SetUpdateCallback(new Action<int>(this.OnJoystickElementAssignmentPollingWindowUpdate));
			window.timer.Start(this._inputAssignmentTimeout);
			this.windowManager.Focus(window);
		}

		// Token: 0x06001BD1 RID: 7121 RVA: 0x000CCDC8 File Offset: 0x000CAFC8
		private void ShowKeyboardElementAssignmentPollingWindow()
		{
			if (this.pendingInputMapping == null)
			{
				return;
			}
			Window window = this.OpenWindow(true);
			if (window == null)
			{
				return;
			}
			window.CreateTitleText(this.prefabs.windowTitleText, Vector2.zero, this.pendingInputMapping.actionName);
			window.AddContentText(this.prefabs.windowContentText, UIPivot.TopCenter, UIAnchor.TopHStretch, new Vector2(0f, -100f), this._language.GetKeyboardElementAssignmentPollingWindowMessage(this.pendingInputMapping.actionName));
			window.AddContentText(this.prefabs.windowContentText, UIPivot.TopCenter, UIAnchor.TopHStretch, new Vector2(0f, -(window.GetContentTextHeight(0) + 50f)), "");
			window.AddContentText(this.prefabs.windowContentText, UIPivot.BottomCenter, UIAnchor.BottomHStretch, Vector2.zero, "");
			window.SetUpdateCallback(new Action<int>(this.OnKeyboardElementAssignmentPollingWindowUpdate));
			window.timer.Start(this._inputAssignmentTimeout);
			this.windowManager.Focus(window);
		}

		// Token: 0x06001BD2 RID: 7122 RVA: 0x000CCEE0 File Offset: 0x000CB0E0
		private void ShowMouseElementAssignmentPollingWindow()
		{
			if (this.pendingInputMapping == null)
			{
				return;
			}
			Window window = this.OpenWindow(true);
			if (window == null)
			{
				return;
			}
			string text = ((this.pendingInputMapping.axisRange == AxisRange.Full && this._showFullAxisInputFields && !this._showSplitAxisInputFields) ? this._language.GetMouseElementAssignmentPollingWindowMessage_FullAxisFieldOnly(this.pendingInputMapping.actionName) : this._language.GetMouseElementAssignmentPollingWindowMessage(this.pendingInputMapping.actionName));
			window.CreateTitleText(this.prefabs.windowTitleText, Vector2.zero, this.pendingInputMapping.actionName);
			window.AddContentText(this.prefabs.windowContentText, UIPivot.TopCenter, UIAnchor.TopHStretch, new Vector2(0f, -100f), text);
			window.AddContentText(this.prefabs.windowContentText, UIPivot.BottomCenter, UIAnchor.BottomHStretch, Vector2.zero, "");
			window.SetUpdateCallback(new Action<int>(this.OnMouseElementAssignmentPollingWindowUpdate));
			window.timer.Start(this._inputAssignmentTimeout);
			this.windowManager.Focus(window);
		}

		// Token: 0x06001BD3 RID: 7123 RVA: 0x000CCFF4 File Offset: 0x000CB1F4
		private void ShowElementAssignmentConflictWindow(ElementAssignment assignment, bool skipOtherPlayers)
		{
			if (this.pendingInputMapping == null)
			{
				return;
			}
			bool flag = this.IsBlockingAssignmentConflict(this.pendingInputMapping, assignment, skipOtherPlayers);
			string text = (flag ? this._language.GetElementAlreadyInUseBlocked(this.pendingInputMapping.elementName) : this._language.GetElementAlreadyInUseCanReplace(this.pendingInputMapping.elementName, this._allowElementAssignmentConflicts));
			Window window = this.OpenWindow(true);
			if (window == null)
			{
				return;
			}
			window.CreateTitleText(this.prefabs.windowTitleText, Vector2.zero, this._language.elementAssignmentConflictWindowMessage);
			window.AddContentText(this.prefabs.windowContentText, UIPivot.TopCenter, UIAnchor.TopHStretch, new Vector2(0f, -100f), text);
			UnityAction unityAction = delegate
			{
				this.OnWindowCancel(window.id);
			};
			window.cancelCallback = unityAction;
			if (flag)
			{
				window.CreateButton(this.prefabs.fitButton, UIPivot.BottomCenter, UIAnchor.BottomCenter, Vector2.zero, this._language.okay, unityAction, unityAction, true);
			}
			else
			{
				window.CreateButton(this.prefabs.fitButton, UIPivot.BottomLeft, UIAnchor.BottomLeft, Vector2.zero, this._language.replace, delegate
				{
					this.OnElementAssignmentConflictReplaceConfirmed(window.id, this.pendingInputMapping, assignment, skipOtherPlayers, false);
				}, unityAction, true);
				if (this._allowElementAssignmentConflicts)
				{
					window.CreateButton(this.prefabs.fitButton, UIPivot.BottomCenter, UIAnchor.BottomCenter, Vector2.zero, this._language.add, delegate
					{
						this.OnElementAssignmentAddConfirmed(window.id, this.pendingInputMapping, assignment);
					}, unityAction, false);
				}
				else if (this.ShowSwapButton(window.id, this.pendingInputMapping, assignment, skipOtherPlayers))
				{
					window.CreateButton(this.prefabs.fitButton, UIPivot.BottomCenter, UIAnchor.BottomCenter, Vector2.zero, this._language.swap, delegate
					{
						this.OnElementAssignmentConflictReplaceConfirmed(window.id, this.pendingInputMapping, assignment, skipOtherPlayers, true);
					}, unityAction, false);
				}
				window.CreateButton(this.prefabs.fitButton, UIPivot.BottomRight, UIAnchor.BottomRight, Vector2.zero, this._language.cancel, unityAction, unityAction, false);
			}
			this.windowManager.Focus(window);
		}

		// Token: 0x06001BD4 RID: 7124 RVA: 0x000CD26C File Offset: 0x000CB46C
		private void ShowMouseAssignmentConflictWindow()
		{
			if (this.currentPlayer == null)
			{
				return;
			}
			Window window = this.OpenWindow(true);
			if (window == null)
			{
				return;
			}
			string text = string.Empty;
			IList<Player> players = ReInput.players.Players;
			for (int i = 0; i < players.Count; i++)
			{
				if (players[i] != this.currentPlayer && players[i].controllers.hasMouse)
				{
					text = this._language.GetPlayerName(players[i].id);
					break;
				}
			}
			window.CreateTitleText(this.prefabs.windowTitleText, Vector2.zero, this._language.mouseAssignmentConflictWindowTitle);
			window.AddContentText(this.prefabs.windowContentText, UIPivot.TopCenter, UIAnchor.TopHStretch, new Vector2(0f, -100f), this._language.GetMouseAssignmentConflictWindowMessage(text, this._language.GetPlayerName(this.currentPlayer.id)));
			UnityAction unityAction = delegate
			{
				this.OnWindowCancel(window.id);
			};
			window.cancelCallback = unityAction;
			window.CreateButton(this.prefabs.fitButton, UIPivot.BottomLeft, UIAnchor.BottomLeft, Vector2.zero, this._language.yes, delegate
			{
				this.OnMouseAssignmentConfirmed(window.id, this.currentPlayer);
			}, unityAction, true);
			window.CreateButton(this.prefabs.fitButton, UIPivot.BottomRight, UIAnchor.BottomRight, Vector2.zero, this._language.no, unityAction, unityAction, false);
			this.windowManager.Focus(window);
		}

		// Token: 0x06001BD5 RID: 7125 RVA: 0x000CD424 File Offset: 0x000CB624
		private void ShowCalibrateControllerWindow()
		{
			if (this.currentPlayer == null)
			{
				return;
			}
			if (this.currentPlayer.controllers.joystickCount == 0)
			{
				return;
			}
			CalibrationWindow calibrationWindow = this.OpenWindow(this.prefabs.calibrationWindow, "CalibrationWindow", true) as CalibrationWindow;
			if (calibrationWindow == null)
			{
				return;
			}
			Joystick currentJoystick = this.currentJoystick;
			calibrationWindow.CreateTitleText(this.prefabs.windowTitleText, Vector2.zero, this._language.calibrateControllerWindowTitle);
			calibrationWindow.SetJoystick(this.currentPlayer.id, currentJoystick);
			calibrationWindow.SetButtonCallback(CalibrationWindow.ButtonIdentifier.Done, new Action<int>(this.CloseWindow));
			calibrationWindow.SetButtonCallback(CalibrationWindow.ButtonIdentifier.Calibrate, new Action<int>(this.StartAxisCalibration));
			calibrationWindow.SetButtonCallback(CalibrationWindow.ButtonIdentifier.Cancel, new Action<int>(this.CloseWindow));
			this.windowManager.Focus(calibrationWindow);
		}

		// Token: 0x06001BD6 RID: 7126 RVA: 0x000CD4F4 File Offset: 0x000CB6F4
		private void ShowCalibrateAxisStep1Window()
		{
			if (this.currentPlayer == null)
			{
				return;
			}
			Window window = this.OpenWindow(false);
			if (window == null)
			{
				return;
			}
			if (this.pendingAxisCalibration == null)
			{
				return;
			}
			Joystick joystick = this.pendingAxisCalibration.joystick;
			if (joystick.axisCount == 0)
			{
				return;
			}
			int axisIndex = this.pendingAxisCalibration.axisIndex;
			if (axisIndex < 0 || axisIndex >= joystick.axisCount)
			{
				return;
			}
			window.CreateTitleText(this.prefabs.windowTitleText, Vector2.zero, this._language.calibrateAxisStep1WindowTitle);
			window.AddContentText(this.prefabs.windowContentText, UIPivot.TopCenter, UIAnchor.TopHStretch, new Vector2(0f, -100f), this._language.GetCalibrateAxisStep1WindowMessage(this._language.GetElementIdentifierName(joystick, joystick.AxisElementIdentifiers[axisIndex].id, AxisRange.Full)));
			if (this.prefabs.centerStickGraphic != null)
			{
				window.AddContentImage(this.prefabs.centerStickGraphic, UIPivot.BottomCenter, UIAnchor.BottomCenter, new Vector2(0f, 40f));
			}
			window.AddContentText(this.prefabs.windowContentText, UIPivot.BottomCenter, UIAnchor.BottomHStretch, Vector2.zero, "");
			window.SetUpdateCallback(new Action<int>(this.OnCalibrateAxisStep1WindowUpdate));
			window.timer.Start(this._axisCalibrationTimeout);
			this.windowManager.Focus(window);
		}

		// Token: 0x06001BD7 RID: 7127 RVA: 0x000CD65C File Offset: 0x000CB85C
		private void ShowCalibrateAxisStep2Window()
		{
			if (this.currentPlayer == null)
			{
				return;
			}
			Window window = this.OpenWindow(false);
			if (window == null)
			{
				return;
			}
			if (this.pendingAxisCalibration == null)
			{
				return;
			}
			Joystick joystick = this.pendingAxisCalibration.joystick;
			if (joystick.axisCount == 0)
			{
				return;
			}
			int axisIndex = this.pendingAxisCalibration.axisIndex;
			if (axisIndex < 0 || axisIndex >= joystick.axisCount)
			{
				return;
			}
			window.CreateTitleText(this.prefabs.windowTitleText, Vector2.zero, this._language.calibrateAxisStep2WindowTitle);
			window.AddContentText(this.prefabs.windowContentText, UIPivot.TopCenter, UIAnchor.TopHStretch, new Vector2(0f, -100f), this._language.GetCalibrateAxisStep2WindowMessage(this._language.GetElementIdentifierName(joystick, joystick.AxisElementIdentifiers[axisIndex].id, AxisRange.Full)));
			if (this.prefabs.moveStickGraphic != null)
			{
				window.AddContentImage(this.prefabs.moveStickGraphic, UIPivot.BottomCenter, UIAnchor.BottomCenter, new Vector2(0f, 40f));
			}
			window.AddContentText(this.prefabs.windowContentText, UIPivot.BottomCenter, UIAnchor.BottomHStretch, Vector2.zero, "");
			window.SetUpdateCallback(new Action<int>(this.OnCalibrateAxisStep2WindowUpdate));
			window.timer.Start(this._axisCalibrationTimeout);
			this.windowManager.Focus(window);
		}

		// Token: 0x06001BD8 RID: 7128 RVA: 0x000CD7C4 File Offset: 0x000CB9C4
		private void ShowEditInputBehaviorsWindow()
		{
			if (this.currentPlayer == null)
			{
				return;
			}
			if (this._inputBehaviorSettings == null)
			{
				return;
			}
			InputBehaviorWindow inputBehaviorWindow = this.OpenWindow(this.prefabs.inputBehaviorsWindow, "EditInputBehaviorsWindow", true) as InputBehaviorWindow;
			if (inputBehaviorWindow == null)
			{
				return;
			}
			inputBehaviorWindow.CreateTitleText(this.prefabs.windowTitleText, Vector2.zero, this._language.inputBehaviorSettingsWindowTitle);
			inputBehaviorWindow.SetData(this.currentPlayer.id, this._inputBehaviorSettings);
			inputBehaviorWindow.SetButtonCallback(InputBehaviorWindow.ButtonIdentifier.Done, new Action<int>(this.CloseWindow));
			inputBehaviorWindow.SetButtonCallback(InputBehaviorWindow.ButtonIdentifier.Cancel, new Action<int>(this.CloseWindow));
			this.windowManager.Focus(inputBehaviorWindow);
		}

		// Token: 0x06001BD9 RID: 7129 RVA: 0x000CD874 File Offset: 0x000CBA74
		private void ShowRestoreDefaultsWindow()
		{
			if (this.currentPlayer == null)
			{
				return;
			}
			this.OpenModal(this._language.restoreDefaultsWindowTitle, this._language.restoreDefaultsWindowMessage, this._language.yes, new Action<int>(this.OnRestoreDefaultsConfirmed), this._language.no, new Action<int>(this.OnWindowCancel), true);
		}

		// Token: 0x06001BDA RID: 7130 RVA: 0x000CD8D8 File Offset: 0x000CBAD8
		private void CreateInputGrid()
		{
			this.InitializeInputGrid();
			this.CreateHeaderLabels();
			this.CreateActionLabelColumn();
			this.CreateKeyboardInputFieldColumn();
			this.CreateMouseInputFieldColumn();
			this.CreateControllerInputFieldColumn();
			this.CreateInputActionLabels();
			this.CreateInputFields();
			this.inputGrid.HideAll();
			this.ResetInputGridScrollBar();
		}

		// Token: 0x06001BDB RID: 7131 RVA: 0x000CD928 File Offset: 0x000CBB28
		private void InitializeInputGrid()
		{
			if (this.inputGrid == null)
			{
				this.inputGrid = new ControlMapper.InputGrid();
			}
			else
			{
				this.inputGrid.ClearAll();
			}
			for (int i = 0; i < this._mappingSets.Length; i++)
			{
				ControlMapper.MappingSet mappingSet = this._mappingSets[i];
				if (mappingSet != null && mappingSet.isValid)
				{
					InputMapCategory mapCategory = ReInput.mapping.GetMapCategory(mappingSet.mapCategoryId);
					if (mapCategory != null && mapCategory.userAssignable)
					{
						this.inputGrid.AddMapCategory(mappingSet.mapCategoryId);
						if (mappingSet.actionListMode == ControlMapper.MappingSet.ActionListMode.ActionCategory)
						{
							IList<int> actionCategoryIds = mappingSet.actionCategoryIds;
							for (int j = 0; j < actionCategoryIds.Count; j++)
							{
								int num = actionCategoryIds[j];
								InputCategory actionCategory = ReInput.mapping.GetActionCategory(num);
								if (actionCategory != null && actionCategory.userAssignable)
								{
									this.inputGrid.AddActionCategory(mappingSet.mapCategoryId, num);
									foreach (InputAction inputAction in ReInput.mapping.UserAssignableActionsInCategory(num))
									{
										if (inputAction.type == InputActionType.Axis)
										{
											if (this._showFullAxisInputFields)
											{
												this.inputGrid.AddAction(mappingSet.mapCategoryId, inputAction, AxisRange.Full);
											}
											if (this._showSplitAxisInputFields)
											{
												this.inputGrid.AddAction(mappingSet.mapCategoryId, inputAction, AxisRange.Positive);
												this.inputGrid.AddAction(mappingSet.mapCategoryId, inputAction, AxisRange.Negative);
											}
										}
										else if (inputAction.type == InputActionType.Button)
										{
											this.inputGrid.AddAction(mappingSet.mapCategoryId, inputAction, AxisRange.Positive);
										}
									}
								}
							}
						}
						else
						{
							IList<int> actionIds = mappingSet.actionIds;
							for (int k = 0; k < actionIds.Count; k++)
							{
								InputAction action = ReInput.mapping.GetAction(actionIds[k]);
								if (action != null)
								{
									if (action.type == InputActionType.Axis)
									{
										if (this._showFullAxisInputFields)
										{
											this.inputGrid.AddAction(mappingSet.mapCategoryId, action, AxisRange.Full);
										}
										if (this._showSplitAxisInputFields)
										{
											this.inputGrid.AddAction(mappingSet.mapCategoryId, action, AxisRange.Positive);
											this.inputGrid.AddAction(mappingSet.mapCategoryId, action, AxisRange.Negative);
										}
									}
									else if (action.type == InputActionType.Button)
									{
										this.inputGrid.AddAction(mappingSet.mapCategoryId, action, AxisRange.Positive);
									}
								}
							}
						}
					}
				}
			}
			this.references.inputGridInnerGroup.GetComponent<HorizontalLayoutGroup>().spacing = (float)this._inputColumnSpacing;
			this.references.inputGridLayoutElement.flexibleWidth = 0f;
			this.references.inputGridLayoutElement.preferredWidth = (float)this.inputGridWidth;
		}

		// Token: 0x06001BDC RID: 7132 RVA: 0x000CDBE4 File Offset: 0x000CBDE4
		private void RefreshInputGridStructure()
		{
			if (this.currentMappingSet == null)
			{
				return;
			}
			this.inputGrid.HideAll();
			this.inputGrid.Show(this.currentMappingSet.mapCategoryId);
			this.references.inputGridInnerGroup.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.inputGrid.GetColumnHeight(this.currentMappingSet.mapCategoryId));
		}

		// Token: 0x06001BDD RID: 7133 RVA: 0x000CDC48 File Offset: 0x000CBE48
		private void CreateHeaderLabels()
		{
			this.references.inputGridHeader1 = this.CreateNewColumnGroup("ActionsHeader", this.references.inputGridHeadersGroup, this._actionLabelWidth).transform;
			this.CreateLabel(this.prefabs.inputGridHeaderLabel, this._language.actionColumnLabel, this.references.inputGridHeader1, Vector2.zero);
			if (this._showKeyboard)
			{
				this.references.inputGridHeader2 = this.CreateNewColumnGroup("KeybordHeader", this.references.inputGridHeadersGroup, this._keyboardColMaxWidth).transform;
				this.CreateLabel(this.prefabs.inputGridHeaderLabel, this._language.keyboardColumnLabel, this.references.inputGridHeader2, Vector2.zero).SetTextAlignment(TextAlignmentOptions.Center);
			}
			if (this._showMouse)
			{
				this.references.inputGridHeader3 = this.CreateNewColumnGroup("MouseHeader", this.references.inputGridHeadersGroup, this._mouseColMaxWidth).transform;
				this.CreateLabel(this.prefabs.inputGridHeaderLabel, this._language.mouseColumnLabel, this.references.inputGridHeader3, Vector2.zero).SetTextAlignment(TextAlignmentOptions.Center);
			}
			if (this._showControllers)
			{
				this.references.inputGridHeader4 = this.CreateNewColumnGroup("ControllerHeader", this.references.inputGridHeadersGroup, this._controllerColMaxWidth).transform;
				this.CreateLabel(this.prefabs.inputGridHeaderLabel, this._language.controllerColumnLabel, this.references.inputGridHeader4, Vector2.zero).SetTextAlignment(TextAlignmentOptions.Center);
			}
		}

		// Token: 0x06001BDE RID: 7134 RVA: 0x000CDDEC File Offset: 0x000CBFEC
		private void CreateActionLabelColumn()
		{
			Transform transform = this.CreateNewColumnGroup("ActionLabelColumn", this.references.inputGridInnerGroup, this._actionLabelWidth).transform;
			this.references.inputGridActionColumn = transform;
		}

		// Token: 0x06001BDF RID: 7135 RVA: 0x00015228 File Offset: 0x00013428
		private void CreateKeyboardInputFieldColumn()
		{
			if (!this._showKeyboard)
			{
				return;
			}
			this.CreateInputFieldColumn("KeyboardColumn", ControllerType.Keyboard, this._keyboardColMaxWidth, this._keyboardInputFieldCount, true);
		}

		// Token: 0x06001BE0 RID: 7136 RVA: 0x0001524C File Offset: 0x0001344C
		private void CreateMouseInputFieldColumn()
		{
			if (!this._showMouse)
			{
				return;
			}
			this.CreateInputFieldColumn("MouseColumn", ControllerType.Mouse, this._mouseColMaxWidth, this._mouseInputFieldCount, false);
		}

		// Token: 0x06001BE1 RID: 7137 RVA: 0x00015270 File Offset: 0x00013470
		private void CreateControllerInputFieldColumn()
		{
			if (!this._showControllers)
			{
				return;
			}
			this.CreateInputFieldColumn("ControllerColumn", ControllerType.Joystick, this._controllerColMaxWidth, this._controllerInputFieldCount, false);
		}

		// Token: 0x06001BE2 RID: 7138 RVA: 0x000CDE28 File Offset: 0x000CC028
		private void CreateInputFieldColumn(string name, ControllerType controllerType, int maxWidth, int cols, bool disableFullAxis)
		{
			Transform transform = this.CreateNewColumnGroup(name, this.references.inputGridInnerGroup, maxWidth).transform;
			switch (controllerType)
			{
			case ControllerType.Keyboard:
				this.references.inputGridKeyboardColumn = transform;
				return;
			case ControllerType.Mouse:
				this.references.inputGridMouseColumn = transform;
				return;
			case ControllerType.Joystick:
				this.references.inputGridControllerColumn = transform;
				return;
			default:
				throw new NotImplementedException();
			}
		}

		// Token: 0x06001BE3 RID: 7139 RVA: 0x000CDE90 File Offset: 0x000CC090
		private void CreateInputActionLabels()
		{
			Transform inputGridActionColumn = this.references.inputGridActionColumn;
			for (int i = 0; i < this._mappingSets.Length; i++)
			{
				ControlMapper.MappingSet mappingSet = this._mappingSets[i];
				if (mappingSet != null && mappingSet.isValid)
				{
					int num = 0;
					if (mappingSet.actionListMode == ControlMapper.MappingSet.ActionListMode.ActionCategory)
					{
						int num2 = 0;
						IList<int> actionCategoryIds = mappingSet.actionCategoryIds;
						for (int j = 0; j < actionCategoryIds.Count; j++)
						{
							InputCategory actionCategory = ReInput.mapping.GetActionCategory(actionCategoryIds[j]);
							if (actionCategory != null && actionCategory.userAssignable && this.CountIEnumerable<InputAction>(ReInput.mapping.UserAssignableActionsInCategory(actionCategory.id)) != 0)
							{
								if (this._showActionCategoryLabels)
								{
									if (num2 > 0)
									{
										num -= this._inputRowCategorySpacing;
									}
									ControlMapper.GUILabel guilabel = this.CreateLabel(this._language.GetActionCategoryName(actionCategory.id), inputGridActionColumn, new Vector2(0f, (float)num));
									guilabel.SetFontStyle(FontStyles.Bold);
									guilabel.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, (float)this._inputRowHeight);
									this.inputGrid.AddActionCategoryLabel(mappingSet.mapCategoryId, actionCategory.id, guilabel);
									num -= this._inputRowHeight;
								}
								foreach (InputAction inputAction in ReInput.mapping.UserAssignableActionsInCategory(actionCategory.id, true))
								{
									if (inputAction.type == InputActionType.Axis)
									{
										if (this._showFullAxisInputFields)
										{
											ControlMapper.GUILabel guilabel2 = this.CreateLabel(this._language.GetActionName(inputAction.id, AxisRange.Full), inputGridActionColumn, new Vector2(0f, (float)num));
											guilabel2.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, (float)this._inputRowHeight);
											this.inputGrid.AddActionLabel(mappingSet.mapCategoryId, inputAction.id, AxisRange.Full, guilabel2);
											num -= this._inputRowHeight;
										}
										if (this._showSplitAxisInputFields)
										{
											string actionName = this._language.GetActionName(inputAction.id, AxisRange.Positive);
											ControlMapper.GUILabel guilabel2 = this.CreateLabel(actionName, inputGridActionColumn, new Vector2(0f, (float)num));
											guilabel2.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, (float)this._inputRowHeight);
											this.inputGrid.AddActionLabel(mappingSet.mapCategoryId, inputAction.id, AxisRange.Positive, guilabel2);
											num -= this._inputRowHeight;
											string actionName2 = this._language.GetActionName(inputAction.id, AxisRange.Negative);
											guilabel2 = this.CreateLabel(actionName2, inputGridActionColumn, new Vector2(0f, (float)num));
											guilabel2.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, (float)this._inputRowHeight);
											this.inputGrid.AddActionLabel(mappingSet.mapCategoryId, inputAction.id, AxisRange.Negative, guilabel2);
											num -= this._inputRowHeight;
										}
									}
									else if (inputAction.type == InputActionType.Button)
									{
										ControlMapper.GUILabel guilabel2 = this.CreateLabel(this._language.GetActionName(inputAction.id), inputGridActionColumn, new Vector2(0f, (float)num));
										guilabel2.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, (float)this._inputRowHeight);
										this.inputGrid.AddActionLabel(mappingSet.mapCategoryId, inputAction.id, AxisRange.Positive, guilabel2);
										num -= this._inputRowHeight;
									}
								}
								num2++;
							}
						}
					}
					else
					{
						IList<int> actionIds = mappingSet.actionIds;
						for (int k = 0; k < actionIds.Count; k++)
						{
							InputAction action = ReInput.mapping.GetAction(actionIds[k]);
							if (action != null && action.userAssignable)
							{
								InputCategory actionCategory2 = ReInput.mapping.GetActionCategory(action.categoryId);
								if (actionCategory2 != null && actionCategory2.userAssignable)
								{
									if (action.type == InputActionType.Axis)
									{
										if (this._showFullAxisInputFields)
										{
											ControlMapper.GUILabel guilabel3 = this.CreateLabel(this._language.GetActionName(action.id, AxisRange.Full), inputGridActionColumn, new Vector2(0f, (float)num));
											guilabel3.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, (float)this._inputRowHeight);
											this.inputGrid.AddActionLabel(mappingSet.mapCategoryId, action.id, AxisRange.Full, guilabel3);
											num -= this._inputRowHeight;
										}
										if (this._showSplitAxisInputFields)
										{
											ControlMapper.GUILabel guilabel3 = this.CreateLabel(this._language.GetActionName(action.id, AxisRange.Positive), inputGridActionColumn, new Vector2(0f, (float)num));
											guilabel3.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, (float)this._inputRowHeight);
											this.inputGrid.AddActionLabel(mappingSet.mapCategoryId, action.id, AxisRange.Positive, guilabel3);
											num -= this._inputRowHeight;
											guilabel3 = this.CreateLabel(this._language.GetActionName(action.id, AxisRange.Negative), inputGridActionColumn, new Vector2(0f, (float)num));
											guilabel3.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, (float)this._inputRowHeight);
											this.inputGrid.AddActionLabel(mappingSet.mapCategoryId, action.id, AxisRange.Negative, guilabel3);
											num -= this._inputRowHeight;
										}
									}
									else if (action.type == InputActionType.Button)
									{
										ControlMapper.GUILabel guilabel3 = this.CreateLabel(this._language.GetActionName(action.id), inputGridActionColumn, new Vector2(0f, (float)num));
										guilabel3.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, (float)this._inputRowHeight);
										this.inputGrid.AddActionLabel(mappingSet.mapCategoryId, action.id, AxisRange.Positive, guilabel3);
										num -= this._inputRowHeight;
									}
								}
							}
						}
					}
					this.inputGrid.SetColumnHeight(mappingSet.mapCategoryId, (float)(-(float)num));
				}
			}
		}

		// Token: 0x06001BE4 RID: 7140 RVA: 0x000CE41C File Offset: 0x000CC61C
		private void CreateInputFields()
		{
			if (this._showControllers)
			{
				this.CreateInputFields(this.references.inputGridControllerColumn, ControllerType.Joystick, this._controllerColMaxWidth, this._controllerInputFieldCount, false);
			}
			if (this._showKeyboard)
			{
				this.CreateInputFields(this.references.inputGridKeyboardColumn, ControllerType.Keyboard, this._keyboardColMaxWidth, this._keyboardInputFieldCount, true);
			}
			if (this._showMouse)
			{
				this.CreateInputFields(this.references.inputGridMouseColumn, ControllerType.Mouse, this._mouseColMaxWidth, this._mouseInputFieldCount, false);
			}
		}

		// Token: 0x06001BE5 RID: 7141 RVA: 0x000CE4A0 File Offset: 0x000CC6A0
		private void CreateInputFields(Transform columnXform, ControllerType controllerType, int maxWidth, int cols, bool disableFullAxis)
		{
			for (int i = 0; i < this._mappingSets.Length; i++)
			{
				ControlMapper.MappingSet mappingSet = this._mappingSets[i];
				if (mappingSet != null && mappingSet.isValid)
				{
					int num = maxWidth / cols;
					int num2 = 0;
					int num3 = 0;
					if (mappingSet.actionListMode == ControlMapper.MappingSet.ActionListMode.ActionCategory)
					{
						IList<int> actionCategoryIds = mappingSet.actionCategoryIds;
						for (int j = 0; j < actionCategoryIds.Count; j++)
						{
							InputCategory actionCategory = ReInput.mapping.GetActionCategory(actionCategoryIds[j]);
							if (actionCategory != null && actionCategory.userAssignable && this.CountIEnumerable<InputAction>(ReInput.mapping.UserAssignableActionsInCategory(actionCategory.id)) != 0)
							{
								if (this._showActionCategoryLabels)
								{
									num2 -= ((num3 > 0) ? (this._inputRowHeight + this._inputRowCategorySpacing) : this._inputRowHeight);
								}
								foreach (InputAction inputAction in ReInput.mapping.UserAssignableActionsInCategory(actionCategory.id, true))
								{
									if (inputAction.type == InputActionType.Axis)
									{
										if (this._showFullAxisInputFields)
										{
											this.CreateInputFieldSet(columnXform, mappingSet.mapCategoryId, inputAction, AxisRange.Full, controllerType, cols, num, ref num2, disableFullAxis);
										}
										if (this._showSplitAxisInputFields)
										{
											this.CreateInputFieldSet(columnXform, mappingSet.mapCategoryId, inputAction, AxisRange.Positive, controllerType, cols, num, ref num2, false);
											this.CreateInputFieldSet(columnXform, mappingSet.mapCategoryId, inputAction, AxisRange.Negative, controllerType, cols, num, ref num2, false);
										}
									}
									else if (inputAction.type == InputActionType.Button)
									{
										this.CreateInputFieldSet(columnXform, mappingSet.mapCategoryId, inputAction, AxisRange.Positive, controllerType, cols, num, ref num2, false);
									}
									num3++;
								}
							}
						}
					}
					else
					{
						IList<int> actionIds = mappingSet.actionIds;
						for (int k = 0; k < actionIds.Count; k++)
						{
							InputAction action = ReInput.mapping.GetAction(actionIds[k]);
							if (action != null && action.userAssignable)
							{
								InputCategory actionCategory2 = ReInput.mapping.GetActionCategory(action.categoryId);
								if (actionCategory2 != null && actionCategory2.userAssignable)
								{
									if (action.type == InputActionType.Axis)
									{
										if (this._showFullAxisInputFields)
										{
											this.CreateInputFieldSet(columnXform, mappingSet.mapCategoryId, action, AxisRange.Full, controllerType, cols, num, ref num2, disableFullAxis);
										}
										if (this._showSplitAxisInputFields)
										{
											this.CreateInputFieldSet(columnXform, mappingSet.mapCategoryId, action, AxisRange.Positive, controllerType, cols, num, ref num2, false);
											this.CreateInputFieldSet(columnXform, mappingSet.mapCategoryId, action, AxisRange.Negative, controllerType, cols, num, ref num2, false);
										}
									}
									else if (action.type == InputActionType.Button)
									{
										this.CreateInputFieldSet(columnXform, mappingSet.mapCategoryId, action, AxisRange.Positive, controllerType, cols, num, ref num2, false);
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001BE6 RID: 7142 RVA: 0x000CE754 File Offset: 0x000CC954
		private void CreateInputFieldSet(Transform parent, int mapCategoryId, InputAction action, AxisRange axisRange, ControllerType controllerType, int cols, int fieldWidth, ref int yPos, bool disableFullAxis)
		{
			GameObject gameObject = this.CreateNewGUIObject("FieldLayoutGroup", parent, new Vector2(0f, (float)yPos));
			HorizontalLayoutGroup horizontalLayoutGroup = gameObject.AddComponent<HorizontalLayoutGroup>();
			horizontalLayoutGroup.padding = this._inputRowPadding;
			horizontalLayoutGroup.spacing = (float)this._inputRowFieldSpacing;
			RectTransform component = gameObject.GetComponent<RectTransform>();
			component.anchorMin = new Vector2(0f, 1f);
			component.anchorMax = new Vector2(1f, 1f);
			component.pivot = new Vector2(0f, 1f);
			component.sizeDelta = Vector2.zero;
			component.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, (float)this._inputRowHeight);
			this.inputGrid.AddInputFieldSet(mapCategoryId, action, axisRange, controllerType, gameObject);
			for (int i = 0; i < cols; i++)
			{
				int num = ((axisRange == AxisRange.Full) ? this._invertToggleWidth : 0);
				ControlMapper.GUIInputField guiinputField = this.CreateInputField(horizontalLayoutGroup.transform, Vector2.zero, "", action.id, axisRange, controllerType, i);
				guiinputField.SetFirstChildObjectWidth(ControlMapper.LayoutElementSizeType.PreferredSize, fieldWidth - num);
				this.inputGrid.AddInputField(mapCategoryId, action, axisRange, controllerType, i, guiinputField);
				if (axisRange == AxisRange.Full)
				{
					if (!disableFullAxis)
					{
						ControlMapper.GUIToggle guitoggle = this.CreateToggle(this.prefabs.inputGridFieldInvertToggle, horizontalLayoutGroup.transform, Vector2.zero, "", action.id, axisRange, controllerType, i);
						guitoggle.SetFirstChildObjectWidth(ControlMapper.LayoutElementSizeType.MinSize, num);
						guiinputField.AddToggle(guitoggle);
					}
					else
					{
						guiinputField.SetInteractible(false, false, true);
					}
				}
				if (controllerType == ControllerType.Joystick && i > 0)
				{
					int id = action.id;
					if (id == 0 || id - 2 <= 1 || id - 37 <= 2)
					{
						guiinputField.SetInteractible(false, false, true);
					}
					else
					{
						if (guiinputField.hasToggle)
						{
							global::UnityEngine.Object.Destroy(guiinputField.toggle.gameObject);
						}
						global::UnityEngine.Object.Destroy(guiinputField.gameObject);
					}
				}
			}
			yPos -= this._inputRowHeight;
		}

		// Token: 0x06001BE7 RID: 7143 RVA: 0x000CE928 File Offset: 0x000CCB28
		private void PopulateInputFields()
		{
			this.inputGrid.InitializeFields(this.currentMapCategoryId);
			if (this.currentPlayer == null)
			{
				return;
			}
			this.inputGrid.SetFieldsActive(this.currentMapCategoryId, true);
			foreach (ControlMapper.InputActionSet inputActionSet in this.inputGrid.GetActionSets(this.currentMapCategoryId))
			{
				if (this._showKeyboard)
				{
					ControllerType controllerType = ControllerType.Keyboard;
					int num = 0;
					int num2 = this._keyboardMapDefaultLayout;
					int num3 = this._keyboardInputFieldCount;
					ControllerMap controllerMapOrCreateNew = this.GetControllerMapOrCreateNew(controllerType, num, num2);
					this.PopulateInputFieldGroup(inputActionSet, controllerMapOrCreateNew, controllerType, num, num3);
				}
				if (this._showMouse)
				{
					ControllerType controllerType = ControllerType.Mouse;
					int num = 0;
					int num2 = this._mouseMapDefaultLayout;
					int num3 = this._mouseInputFieldCount;
					ControllerMap controllerMapOrCreateNew2 = this.GetControllerMapOrCreateNew(controllerType, num, num2);
					if (this.currentPlayer.controllers.hasMouse)
					{
						this.PopulateInputFieldGroup(inputActionSet, controllerMapOrCreateNew2, controllerType, num, num3);
					}
				}
				if (this.isJoystickSelected && this.currentPlayer.controllers.joystickCount > 0)
				{
					ControllerType controllerType = ControllerType.Joystick;
					int num = this.currentJoystick.id;
					int num2 = this._joystickMapDefaultLayout;
					int num3 = this._controllerInputFieldCount;
					ControllerMap controllerMapOrCreateNew3 = this.GetControllerMapOrCreateNew(controllerType, num, num2);
					this.PopulateInputFieldGroup(inputActionSet, controllerMapOrCreateNew3, controllerType, num, num3);
				}
				else
				{
					this.DisableInputFieldGroup(inputActionSet, ControllerType.Joystick, this._controllerInputFieldCount);
				}
			}
		}

		// Token: 0x06001BE8 RID: 7144 RVA: 0x000CEA8C File Offset: 0x000CCC8C
		private void PopulateInputFieldGroup(ControlMapper.InputActionSet actionSet, ControllerMap controllerMap, ControllerType controllerType, int controllerId, int maxFields)
		{
			if (controllerMap == null)
			{
				return;
			}
			int num = 0;
			this.inputGrid.SetFixedFieldData(this.currentMapCategoryId, actionSet.actionId, actionSet.axisRange, controllerType, controllerId);
			foreach (ActionElementMap actionElementMap in controllerMap.ElementMapsWithAction(actionSet.actionId))
			{
				if (actionElementMap.elementType == ControllerElementType.Button)
				{
					if (actionSet.axisRange == AxisRange.Full)
					{
						continue;
					}
					if (actionSet.axisRange == AxisRange.Positive)
					{
						if (actionElementMap.axisContribution == Pole.Negative)
						{
							continue;
						}
					}
					else if (actionSet.axisRange == AxisRange.Negative && actionElementMap.axisContribution == Pole.Positive)
					{
						continue;
					}
					this.inputGrid.PopulateField(this.currentMapCategoryId, actionSet.actionId, actionSet.axisRange, controllerType, controllerId, num, actionElementMap.id, this._language.GetElementIdentifierName(actionElementMap), false);
				}
				else if (actionElementMap.elementType == ControllerElementType.Axis)
				{
					if (actionSet.axisRange == AxisRange.Full)
					{
						if (actionElementMap.axisRange != AxisRange.Full)
						{
							continue;
						}
						this.inputGrid.PopulateField(this.currentMapCategoryId, actionSet.actionId, actionSet.axisRange, controllerType, controllerId, num, actionElementMap.id, this._language.GetElementIdentifierName(actionElementMap), actionElementMap.invert);
					}
					else if (actionSet.axisRange == AxisRange.Positive)
					{
						if ((actionElementMap.axisRange == AxisRange.Full && ReInput.mapping.GetAction(actionSet.actionId).type != InputActionType.Button) || actionElementMap.axisContribution == Pole.Negative)
						{
							continue;
						}
						this.inputGrid.PopulateField(this.currentMapCategoryId, actionSet.actionId, actionSet.axisRange, controllerType, controllerId, num, actionElementMap.id, this._language.GetElementIdentifierName(actionElementMap), false);
					}
					else if (actionSet.axisRange == AxisRange.Negative)
					{
						if (actionElementMap.axisRange == AxisRange.Full || actionElementMap.axisContribution == Pole.Positive)
						{
							continue;
						}
						this.inputGrid.PopulateField(this.currentMapCategoryId, actionSet.actionId, actionSet.axisRange, controllerType, controllerId, num, actionElementMap.id, this._language.GetElementIdentifierName(actionElementMap), false);
					}
				}
				num++;
				if (num > maxFields)
				{
					break;
				}
			}
		}

		// Token: 0x06001BE9 RID: 7145 RVA: 0x000CECAC File Offset: 0x000CCEAC
		private void DisableInputFieldGroup(ControlMapper.InputActionSet actionSet, ControllerType controllerType, int fieldCount)
		{
			for (int i = 0; i < fieldCount; i++)
			{
				ControlMapper.GUIInputField guiinputField = this.inputGrid.GetGUIInputField(this.currentMapCategoryId, actionSet.actionId, actionSet.axisRange, controllerType, i);
				if (guiinputField != null)
				{
					guiinputField.SetInteractible(false, false);
				}
			}
		}

		// Token: 0x06001BEA RID: 7146 RVA: 0x000CECF0 File Offset: 0x000CCEF0
		private void ResetInputGridScrollBar()
		{
			this.references.inputGridInnerGroup.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
			this.references.inputGridVScrollbar.value = 1f;
			this.references.inputGridScrollRect.verticalScrollbarVisibility = ScrollRect.ScrollbarVisibility.AutoHide;
		}

		// Token: 0x06001BEB RID: 7147 RVA: 0x000CED40 File Offset: 0x000CCF40
		private void CreateLayout()
		{
			this.references.playersGroup.gameObject.SetActive(this.showPlayers);
			this.references.controllerGroup.gameObject.SetActive(this._showControllers);
			this.references.assignedControllersGroup.gameObject.SetActive(this._showControllers && this.ShowAssignedControllers());
			this.references.settingsAndMapCategoriesGroup.gameObject.SetActive(this.showSettings || this.showMapCategories);
			this.references.settingsGroup.gameObject.SetActive(this.showSettings);
			this.references.mapCategoriesGroup.gameObject.SetActive(this.showMapCategories);
		}

		// Token: 0x06001BEC RID: 7148 RVA: 0x00015294 File Offset: 0x00013494
		private void Draw()
		{
			this.DrawPlayersGroup();
			this.DrawControllersGroup();
			this.DrawSettingsGroup();
			this.DrawMapCategoriesGroup();
			this.DrawWindowButtonsGroup();
		}

		// Token: 0x06001BED RID: 7149 RVA: 0x000CEE08 File Offset: 0x000CD008
		private void DrawPlayersGroup()
		{
			if (!this.showPlayers)
			{
				return;
			}
			this.references.playersGroup.labelText = this._language.playersGroupLabel;
			this.references.playersGroup.SetLabelActive(this._showPlayersGroupLabel);
			for (int i = 0; i < this.playerCount; i++)
			{
				Player player = ReInput.players.GetPlayer(i);
				if (player != null)
				{
					ControlMapper.GUIButton guibutton = new ControlMapper.GUIButton(UITools.InstantiateGUIObject<ButtonInfo>(this.prefabs.button, this.references.playersGroup.content, "Player" + i.ToString() + "Button"));
					guibutton.SetLabel(this._language.GetPlayerName(player.id));
					guibutton.SetButtonInfoData("PlayerSelection", player.id);
					guibutton.SetOnClickCallback(new Action<ButtonInfo>(this.OnButtonActivated));
					guibutton.buttonInfo.OnSelectedEvent += this.OnUIElementSelected;
					this.playerButtons.Add(guibutton);
				}
			}
		}

		// Token: 0x06001BEE RID: 7150 RVA: 0x000CEF14 File Offset: 0x000CD114
		private void DrawControllersGroup()
		{
			if (!this._showControllers)
			{
				return;
			}
			this.references.controllerSettingsGroup.labelText = this._language.controllerSettingsGroupLabel;
			this.references.controllerSettingsGroup.SetLabelActive(this._showControllerGroupLabel);
			this.references.controllerNameLabel.gameObject.SetActive(this._showControllerNameLabel);
			this.references.controllerGroupLabelGroup.gameObject.SetActive(this._showControllerGroupLabel || this._showControllerNameLabel);
			if (this.ShowAssignedControllers())
			{
				this.references.assignedControllersGroup.labelText = this._language.assignedControllersGroupLabel;
				this.references.assignedControllersGroup.SetLabelActive(this._showAssignedControllersGroupLabel);
			}
			this.references.removeControllerButton.GetComponent<ButtonInfo>().text.text = this._language.removeControllerButtonLabel;
			this.references.calibrateControllerButton.GetComponent<ButtonInfo>().text.text = this._language.calibrateControllerButtonLabel;
			this.references.assignControllerButton.GetComponent<ButtonInfo>().text.text = this._language.assignControllerButtonLabel;
			ControlMapper.GUIButton guibutton = this.CreateButton(this._language.none, this.references.assignedControllersGroup.content, Vector2.zero);
			guibutton.SetInteractible(false, false, true);
			this.assignedControllerButtonsPlaceholder = guibutton;
		}

		// Token: 0x06001BEF RID: 7151 RVA: 0x000CF07C File Offset: 0x000CD27C
		private void DrawSettingsGroup()
		{
			if (!this.showSettings)
			{
				return;
			}
			this.references.settingsGroup.labelText = this._language.settingsGroupLabel;
			this.references.settingsGroup.SetLabelActive(this._showSettingsGroupLabel);
			ControlMapper.GUIButton guibutton = this.CreateButton(this._language.inputBehaviorSettingsButtonLabel, this.references.settingsGroup.content, Vector2.zero);
			this.miscInstantiatedObjects.Add(guibutton.gameObject);
			guibutton.buttonInfo.OnSelectedEvent += this.OnUIElementSelected;
			guibutton.SetButtonInfoData("EditInputBehaviors", 0);
			guibutton.SetOnClickCallback(new Action<ButtonInfo>(this.OnButtonActivated));
		}

		// Token: 0x06001BF0 RID: 7152 RVA: 0x000CF130 File Offset: 0x000CD330
		private void DrawMapCategoriesGroup()
		{
			if (!this.showMapCategories)
			{
				return;
			}
			if (this._mappingSets == null)
			{
				return;
			}
			this.references.mapCategoriesGroup.labelText = this._language.mapCategoriesGroupLabel;
			this.references.mapCategoriesGroup.SetLabelActive(this._showMapCategoriesGroupLabel);
			for (int i = 0; i < this._mappingSets.Length; i++)
			{
				ControlMapper.MappingSet mappingSet = this._mappingSets[i];
				if (mappingSet != null)
				{
					InputMapCategory mapCategory = ReInput.mapping.GetMapCategory(mappingSet.mapCategoryId);
					if (mapCategory != null)
					{
						ControlMapper.GUIButton guibutton = new ControlMapper.GUIButton(UITools.InstantiateGUIObject<ButtonInfo>(this.prefabs.button, this.references.mapCategoriesGroup.content, mapCategory.name + "Button"));
						guibutton.SetLabel(this._language.GetMapCategoryName(mapCategory.id));
						guibutton.SetButtonInfoData("MapCategorySelection", mapCategory.id);
						guibutton.SetOnClickCallback(new Action<ButtonInfo>(this.OnButtonActivated));
						guibutton.buttonInfo.OnSelectedEvent += this.OnUIElementSelected;
						this.mapCategoryButtons.Add(guibutton);
					}
				}
			}
		}

		// Token: 0x06001BF1 RID: 7153 RVA: 0x000CF254 File Offset: 0x000CD454
		private void DrawWindowButtonsGroup()
		{
			this.references.doneButton.GetComponent<ButtonInfo>().text.text = this._language.doneButtonLabel;
			this.references.restoreDefaultsButton.GetComponent<ButtonInfo>().text.text = this._language.restoreDefaultsButtonLabel;
		}

		// Token: 0x06001BF2 RID: 7154 RVA: 0x000152B4 File Offset: 0x000134B4
		private void Redraw(bool listsChanged, bool playTransitions)
		{
			this.RedrawPlayerGroup(playTransitions);
			this.RedrawControllerGroup();
			this.RedrawMapCategoriesGroup(playTransitions);
			this.RedrawInputGrid(listsChanged);
			if (this.currentUISelection == null || !this.currentUISelection.activeInHierarchy)
			{
				this.RestoreLastUISelection();
			}
		}

		// Token: 0x06001BF3 RID: 7155 RVA: 0x000CF2AC File Offset: 0x000CD4AC
		private void RedrawPlayerGroup(bool playTransitions)
		{
			if (!this.showPlayers)
			{
				return;
			}
			for (int i = 0; i < this.playerButtons.Count; i++)
			{
				bool flag = this.currentPlayerId != this.playerButtons[i].buttonInfo.intData;
				this.playerButtons[i].SetInteractible(flag, playTransitions);
			}
		}

		// Token: 0x06001BF4 RID: 7156 RVA: 0x000CF310 File Offset: 0x000CD510
		private void RedrawControllerGroup()
		{
			int num = -1;
			this.references.controllerNameLabel.text = this._language.none;
			UITools.SetInteractable(this.references.removeControllerButton, false, false);
			UITools.SetInteractable(this.references.assignControllerButton, false, false);
			UITools.SetInteractable(this.references.calibrateControllerButton, false, false);
			if (this.ShowAssignedControllers())
			{
				foreach (ControlMapper.GUIButton guibutton in this.assignedControllerButtons)
				{
					if (!(guibutton.gameObject == null))
					{
						if (this.currentUISelection == guibutton.gameObject)
						{
							num = guibutton.buttonInfo.intData;
						}
						global::UnityEngine.Object.Destroy(guibutton.gameObject);
					}
				}
				this.assignedControllerButtons.Clear();
				this.assignedControllerButtonsPlaceholder.SetActive(true);
			}
			Player player = ReInput.players.GetPlayer(this.currentPlayerId);
			if (player == null)
			{
				return;
			}
			if (this.ShowAssignedControllers())
			{
				if (player.controllers.joystickCount > 0)
				{
					this.assignedControllerButtonsPlaceholder.SetActive(false);
				}
				foreach (Joystick joystick in player.controllers.Joysticks)
				{
					ControlMapper.GUIButton guibutton2 = this.CreateButton(this._language.GetControllerName(joystick), this.references.assignedControllersGroup.content, Vector2.zero);
					guibutton2.SetButtonInfoData("AssignedControllerSelection", joystick.id);
					guibutton2.SetOnClickCallback(new Action<ButtonInfo>(this.OnButtonActivated));
					guibutton2.buttonInfo.OnSelectedEvent += this.OnUIElementSelected;
					this.assignedControllerButtons.Add(guibutton2);
					if (joystick.id == this.currentJoystickId)
					{
						guibutton2.SetInteractible(false, true);
					}
				}
				if (player.controllers.joystickCount > 0 && !this.isJoystickSelected)
				{
					this.currentJoystickId = player.controllers.Joysticks[0].id;
					this.assignedControllerButtons[0].SetInteractible(false, false);
				}
				if (num < 0)
				{
					goto IL_02B0;
				}
				using (List<ControlMapper.GUIButton>.Enumerator enumerator = this.assignedControllerButtons.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						ControlMapper.GUIButton guibutton3 = enumerator.Current;
						if (guibutton3.buttonInfo.intData == num)
						{
							this.SetUISelection(guibutton3.gameObject);
							break;
						}
					}
					goto IL_02B0;
				}
			}
			if (player.controllers.joystickCount > 0 && !this.isJoystickSelected)
			{
				this.currentJoystickId = player.controllers.Joysticks[0].id;
			}
			IL_02B0:
			if (this.isJoystickSelected && player.controllers.joystickCount > 0)
			{
				this.references.removeControllerButton.interactable = true;
				this.references.controllerNameLabel.text = this._language.GetControllerName(this.currentJoystick);
				if (this.currentJoystick.axisCount > 0)
				{
					this.references.calibrateControllerButton.interactable = true;
				}
			}
			int joystickCount = player.controllers.joystickCount;
			int joystickCount2 = ReInput.controllers.joystickCount;
			int maxControllersPerPlayer = this.GetMaxControllersPerPlayer();
			bool flag = maxControllersPerPlayer == 0;
			if (joystickCount2 > 0 && joystickCount < joystickCount2 && (maxControllersPerPlayer == 1 || flag || joystickCount < maxControllersPerPlayer))
			{
				UITools.SetInteractable(this.references.assignControllerButton, true, false);
			}
		}

		// Token: 0x06001BF5 RID: 7157 RVA: 0x000CF6AC File Offset: 0x000CD8AC
		private void RedrawMapCategoriesGroup(bool playTransitions)
		{
			if (!this.showMapCategories)
			{
				return;
			}
			for (int i = 0; i < this.mapCategoryButtons.Count; i++)
			{
				bool flag = this.currentMapCategoryId != this.mapCategoryButtons[i].buttonInfo.intData;
				this.mapCategoryButtons[i].SetInteractible(flag, playTransitions);
			}
		}

		// Token: 0x06001BF6 RID: 7158 RVA: 0x000152F2 File Offset: 0x000134F2
		private void RedrawInputGrid(bool listsChanged)
		{
			if (listsChanged)
			{
				this.RefreshInputGridStructure();
			}
			this.PopulateInputFields();
			if (listsChanged)
			{
				this.ResetInputGridScrollBar();
			}
		}

		// Token: 0x06001BF7 RID: 7159 RVA: 0x0001530C File Offset: 0x0001350C
		private void ForceRefresh()
		{
			if (this.windowManager.isWindowOpen)
			{
				this.CloseAllWindows();
				return;
			}
			this.Redraw(false, false);
		}

		// Token: 0x06001BF8 RID: 7160 RVA: 0x000CF710 File Offset: 0x000CD910
		private void CreateInputCategoryRow(ref int rowCount, InputCategory category)
		{
			this.CreateLabel(this._language.GetMapCategoryName(category.id), this.references.inputGridActionColumn, new Vector2(0f, (float)(rowCount * this._inputRowHeight) * -1f));
			rowCount++;
		}

		// Token: 0x06001BF9 RID: 7161 RVA: 0x0001532A File Offset: 0x0001352A
		private ControlMapper.GUILabel CreateLabel(string labelText, Transform parent, Vector2 offset)
		{
			return this.CreateLabel(this.prefabs.inputGridLabel, labelText, parent, offset);
		}

		// Token: 0x06001BFA RID: 7162 RVA: 0x000CF760 File Offset: 0x000CD960
		private ControlMapper.GUILabel CreateLabel(GameObject prefab, string labelText, Transform parent, Vector2 offset)
		{
			GameObject gameObject = this.InstantiateGUIObject(prefab, parent, offset);
			TMP_Text componentInSelfOrChildren = UnityTools.GetComponentInSelfOrChildren<TMP_Text>(gameObject);
			if (componentInSelfOrChildren == null)
			{
				Debug.LogError("Rewired Control Mapper: Label prefab is missing Text component!");
				return null;
			}
			componentInSelfOrChildren.text = labelText;
			return new ControlMapper.GUILabel(gameObject);
		}

		// Token: 0x06001BFB RID: 7163 RVA: 0x00015340 File Offset: 0x00013540
		private ControlMapper.GUIButton CreateButton(string labelText, Transform parent, Vector2 offset)
		{
			ControlMapper.GUIButton guibutton = new ControlMapper.GUIButton(this.InstantiateGUIObject(this.prefabs.button, parent, offset));
			guibutton.SetLabel(labelText);
			return guibutton;
		}

		// Token: 0x06001BFC RID: 7164 RVA: 0x00015361 File Offset: 0x00013561
		private ControlMapper.GUIButton CreateFitButton(string labelText, Transform parent, Vector2 offset)
		{
			ControlMapper.GUIButton guibutton = new ControlMapper.GUIButton(this.InstantiateGUIObject(this.prefabs.fitButton, parent, offset));
			guibutton.SetLabel(labelText);
			return guibutton;
		}

		// Token: 0x06001BFD RID: 7165 RVA: 0x000CF7A4 File Offset: 0x000CD9A4
		private ControlMapper.GUIInputField CreateInputField(Transform parent, Vector2 offset, string label, int actionId, AxisRange axisRange, ControllerType controllerType, int fieldIndex)
		{
			ControlMapper.GUIInputField guiinputField = this.CreateInputField(parent, offset);
			guiinputField.SetLabel("");
			guiinputField.SetFieldInfoData(actionId, axisRange, controllerType, fieldIndex);
			guiinputField.SetOnClickCallback(this.inputFieldActivatedDelegate);
			guiinputField.fieldInfo.OnSelectedEvent += this.OnUIElementSelected;
			return guiinputField;
		}

		// Token: 0x06001BFE RID: 7166 RVA: 0x00015382 File Offset: 0x00013582
		private ControlMapper.GUIInputField CreateInputField(Transform parent, Vector2 offset)
		{
			return new ControlMapper.GUIInputField(this.InstantiateGUIObject(this.prefabs.inputGridFieldButton, parent, offset));
		}

		// Token: 0x06001BFF RID: 7167 RVA: 0x0001539C File Offset: 0x0001359C
		private ControlMapper.GUIToggle CreateToggle(GameObject prefab, Transform parent, Vector2 offset, string label, int actionId, AxisRange axisRange, ControllerType controllerType, int fieldIndex)
		{
			ControlMapper.GUIToggle guitoggle = this.CreateToggle(prefab, parent, offset);
			guitoggle.SetToggleInfoData(actionId, axisRange, controllerType, fieldIndex);
			guitoggle.SetOnSubmitCallback(this.inputFieldInvertToggleStateChangedDelegate);
			guitoggle.toggleInfo.OnSelectedEvent += this.OnUIElementSelected;
			return guitoggle;
		}

		// Token: 0x06001C00 RID: 7168 RVA: 0x000153D8 File Offset: 0x000135D8
		private ControlMapper.GUIToggle CreateToggle(GameObject prefab, Transform parent, Vector2 offset)
		{
			return new ControlMapper.GUIToggle(this.InstantiateGUIObject(prefab, parent, offset));
		}

		// Token: 0x06001C01 RID: 7169 RVA: 0x000CF7F8 File Offset: 0x000CD9F8
		private GameObject InstantiateGUIObject(GameObject prefab, Transform parent, Vector2 offset)
		{
			if (prefab == null)
			{
				Debug.LogError("Rewired Control Mapper: Prefab is null!");
				return null;
			}
			GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(prefab);
			return this.InitializeNewGUIGameObject(gameObject, parent, offset);
		}

		// Token: 0x06001C02 RID: 7170 RVA: 0x000CF82C File Offset: 0x000CDA2C
		private GameObject CreateNewGUIObject(string name, Transform parent, Vector2 offset)
		{
			GameObject gameObject = new GameObject();
			gameObject.name = name;
			gameObject.AddComponent<RectTransform>();
			return this.InitializeNewGUIGameObject(gameObject, parent, offset);
		}

		// Token: 0x06001C03 RID: 7171 RVA: 0x000CF858 File Offset: 0x000CDA58
		private GameObject InitializeNewGUIGameObject(GameObject gameObject, Transform parent, Vector2 offset)
		{
			if (gameObject == null)
			{
				Debug.LogError("Rewired Control Mapper: GameObject is null!");
				return null;
			}
			RectTransform component = gameObject.GetComponent<RectTransform>();
			if (component == null)
			{
				Debug.LogError("Rewired Control Mapper: GameObject does not have a RectTransform component!");
				return gameObject;
			}
			if (parent != null)
			{
				component.SetParent(parent, false);
			}
			component.anchoredPosition = offset;
			return gameObject;
		}

		// Token: 0x06001C04 RID: 7172 RVA: 0x000CF8B0 File Offset: 0x000CDAB0
		private GameObject CreateNewColumnGroup(string name, Transform parent, int maxWidth)
		{
			GameObject gameObject = this.CreateNewGUIObject(name, parent, Vector2.zero);
			this.inputGrid.AddGroup(gameObject);
			LayoutElement layoutElement = gameObject.AddComponent<LayoutElement>();
			if (maxWidth >= 0)
			{
				layoutElement.preferredWidth = (float)maxWidth;
			}
			RectTransform component = gameObject.GetComponent<RectTransform>();
			component.anchorMin = new Vector2(0f, 0f);
			component.anchorMax = new Vector2(1f, 0f);
			return gameObject;
		}

		// Token: 0x06001C05 RID: 7173 RVA: 0x000153E8 File Offset: 0x000135E8
		private Window OpenWindow(bool closeOthers)
		{
			return this.OpenWindow(string.Empty, closeOthers);
		}

		// Token: 0x06001C06 RID: 7174 RVA: 0x000CF91C File Offset: 0x000CDB1C
		private Window OpenWindow(string name, bool closeOthers)
		{
			if (closeOthers)
			{
				this.windowManager.CancelAll();
			}
			Window window = this.windowManager.OpenWindow(name, this._defaultWindowWidth, this._defaultWindowHeight);
			if (window == null)
			{
				return null;
			}
			this.ChildWindowOpened();
			return window;
		}

		// Token: 0x06001C07 RID: 7175 RVA: 0x000153F6 File Offset: 0x000135F6
		private Window OpenWindow(GameObject windowPrefab, bool closeOthers)
		{
			return this.OpenWindow(windowPrefab, string.Empty, closeOthers);
		}

		// Token: 0x06001C08 RID: 7176 RVA: 0x000CF964 File Offset: 0x000CDB64
		private Window OpenWindow(GameObject windowPrefab, string name, bool closeOthers)
		{
			if (closeOthers)
			{
				this.windowManager.CancelAll();
			}
			Window window = this.windowManager.OpenWindow(windowPrefab, name);
			if (window == null)
			{
				return null;
			}
			this.ChildWindowOpened();
			return window;
		}

		// Token: 0x06001C09 RID: 7177 RVA: 0x000CF9A0 File Offset: 0x000CDBA0
		private void OpenModal(string title, string message, string confirmText, Action<int> confirmAction, string cancelText, Action<int> cancelAction, bool closeOthers)
		{
			Window window = this.OpenWindow(closeOthers);
			if (window == null)
			{
				return;
			}
			window.CreateTitleText(this.prefabs.windowTitleText, Vector2.zero, title);
			window.AddContentText(this.prefabs.windowContentText, UIPivot.TopCenter, UIAnchor.TopHStretch, new Vector2(0f, -100f), message);
			UnityAction unityAction = delegate
			{
				this.OnWindowCancel(window.id);
			};
			window.cancelCallback = unityAction;
			window.CreateButton(this.prefabs.fitButton, UIPivot.BottomLeft, UIAnchor.BottomLeft, Vector2.zero, confirmText, delegate
			{
				this.OnRestoreDefaultsConfirmed(window.id);
			}, unityAction, false);
			window.CreateButton(this.prefabs.fitButton, UIPivot.BottomRight, UIAnchor.BottomRight, Vector2.zero, cancelText, unityAction, unityAction, true);
			this.windowManager.Focus(window);
		}

		// Token: 0x06001C0A RID: 7178 RVA: 0x00015405 File Offset: 0x00013605
		private void CloseWindow(int windowId)
		{
			if (!this.windowManager.isWindowOpen)
			{
				return;
			}
			this.windowManager.CloseWindow(windowId);
			this.ChildWindowClosed();
		}

		// Token: 0x06001C0B RID: 7179 RVA: 0x00015427 File Offset: 0x00013627
		private void CloseTopWindow()
		{
			if (!this.windowManager.isWindowOpen)
			{
				return;
			}
			this.windowManager.CloseTop();
			this.ChildWindowClosed();
		}

		// Token: 0x06001C0C RID: 7180 RVA: 0x00015448 File Offset: 0x00013648
		private void CloseAllWindows()
		{
			if (!this.windowManager.isWindowOpen)
			{
				return;
			}
			this.windowManager.CancelAll();
			this.ChildWindowClosed();
			this.InputPollingStopped();
		}

		// Token: 0x06001C0D RID: 7181 RVA: 0x0001546F File Offset: 0x0001366F
		private void ChildWindowOpened()
		{
			if (!this.windowManager.isWindowOpen)
			{
				return;
			}
			this.SetIsFocused(false);
			if (this._PopupWindowOpenedEvent != null)
			{
				this._PopupWindowOpenedEvent();
			}
			if (this._onPopupWindowOpened != null)
			{
				this._onPopupWindowOpened.Invoke();
			}
		}

		// Token: 0x06001C0E RID: 7182 RVA: 0x000154AC File Offset: 0x000136AC
		private void ChildWindowClosed()
		{
			if (this.windowManager.isWindowOpen)
			{
				return;
			}
			this.SetIsFocused(true);
			if (this._PopupWindowClosedEvent != null)
			{
				this._PopupWindowClosedEvent();
			}
			if (this._onPopupWindowClosed != null)
			{
				this._onPopupWindowClosed.Invoke();
			}
		}

		// Token: 0x06001C0F RID: 7183 RVA: 0x000CFAAC File Offset: 0x000CDCAC
		private bool HasElementAssignmentConflicts(Player player, ControlMapper.InputMapping mapping, ElementAssignment assignment, bool skipOtherPlayers)
		{
			if (player == null || mapping == null)
			{
				return false;
			}
			ElementAssignmentConflictCheck elementAssignmentConflictCheck;
			if (!this.CreateConflictCheck(mapping, assignment, out elementAssignmentConflictCheck))
			{
				return false;
			}
			if (skipOtherPlayers)
			{
				return ReInput.players.SystemPlayer.controllers.conflictChecking.DoesElementAssignmentConflict(elementAssignmentConflictCheck) || player.controllers.conflictChecking.DoesElementAssignmentConflict(elementAssignmentConflictCheck);
			}
			return ReInput.controllers.conflictChecking.DoesElementAssignmentConflict(elementAssignmentConflictCheck);
		}

		// Token: 0x06001C10 RID: 7184 RVA: 0x000CFB18 File Offset: 0x000CDD18
		private bool IsBlockingAssignmentConflict(ControlMapper.InputMapping mapping, ElementAssignment assignment, bool skipOtherPlayers)
		{
			ElementAssignmentConflictCheck elementAssignmentConflictCheck;
			if (!this.CreateConflictCheck(mapping, assignment, out elementAssignmentConflictCheck))
			{
				return false;
			}
			if (skipOtherPlayers)
			{
				foreach (ElementAssignmentConflictInfo elementAssignmentConflictInfo in ReInput.players.SystemPlayer.controllers.conflictChecking.ElementAssignmentConflicts(elementAssignmentConflictCheck))
				{
					if (!elementAssignmentConflictInfo.isUserAssignable)
					{
						return true;
					}
				}
				using (IEnumerator<ElementAssignmentConflictInfo> enumerator = this.currentPlayer.controllers.conflictChecking.ElementAssignmentConflicts(elementAssignmentConflictCheck).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						ElementAssignmentConflictInfo elementAssignmentConflictInfo2 = enumerator.Current;
						if (!elementAssignmentConflictInfo2.isUserAssignable)
						{
							return true;
						}
					}
					return false;
				}
			}
			foreach (ElementAssignmentConflictInfo elementAssignmentConflictInfo3 in ReInput.controllers.conflictChecking.ElementAssignmentConflicts(elementAssignmentConflictCheck))
			{
				if (!elementAssignmentConflictInfo3.isUserAssignable)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001C11 RID: 7185 RVA: 0x000154E9 File Offset: 0x000136E9
		private IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(Player player, ControlMapper.InputMapping mapping, ElementAssignment assignment, bool skipOtherPlayers)
		{
			if (player == null || mapping == null)
			{
				yield break;
			}
			ElementAssignmentConflictCheck conflictCheck;
			if (!this.CreateConflictCheck(mapping, assignment, out conflictCheck))
			{
				yield break;
			}
			if (skipOtherPlayers)
			{
				foreach (ElementAssignmentConflictInfo elementAssignmentConflictInfo in ReInput.players.SystemPlayer.controllers.conflictChecking.ElementAssignmentConflicts(conflictCheck))
				{
					if (!elementAssignmentConflictInfo.isUserAssignable)
					{
						yield return elementAssignmentConflictInfo;
					}
				}
				IEnumerator<ElementAssignmentConflictInfo> enumerator = null;
				foreach (ElementAssignmentConflictInfo elementAssignmentConflictInfo2 in player.controllers.conflictChecking.ElementAssignmentConflicts(conflictCheck))
				{
					if (!elementAssignmentConflictInfo2.isUserAssignable)
					{
						yield return elementAssignmentConflictInfo2;
					}
				}
				enumerator = null;
			}
			else
			{
				foreach (ElementAssignmentConflictInfo elementAssignmentConflictInfo3 in ReInput.controllers.conflictChecking.ElementAssignmentConflicts(conflictCheck))
				{
					if (!elementAssignmentConflictInfo3.isUserAssignable)
					{
						yield return elementAssignmentConflictInfo3;
					}
				}
				IEnumerator<ElementAssignmentConflictInfo> enumerator = null;
			}
			yield break;
			yield break;
		}

		// Token: 0x06001C12 RID: 7186 RVA: 0x000CFC3C File Offset: 0x000CDE3C
		private bool CreateConflictCheck(ControlMapper.InputMapping mapping, ElementAssignment assignment, out ElementAssignmentConflictCheck conflictCheck)
		{
			if (mapping == null || this.currentPlayer == null)
			{
				conflictCheck = default(ElementAssignmentConflictCheck);
				return false;
			}
			conflictCheck = assignment.ToElementAssignmentConflictCheck();
			conflictCheck.playerId = this.currentPlayer.id;
			conflictCheck.controllerType = mapping.controllerType;
			conflictCheck.controllerId = mapping.controllerId;
			conflictCheck.controllerMapId = mapping.map.id;
			conflictCheck.controllerMapCategoryId = mapping.map.categoryId;
			if (mapping.aem != null)
			{
				conflictCheck.elementMapId = mapping.aem.id;
			}
			return true;
		}

		// Token: 0x06001C13 RID: 7187 RVA: 0x000CFCD0 File Offset: 0x000CDED0
		private void PollKeyboardForAssignment(out ControllerPollingInfo pollingInfo, out bool modifierKeyPressed, out ModifierKeyFlags modifierFlags, out string label)
		{
			pollingInfo = default(ControllerPollingInfo);
			label = string.Empty;
			modifierKeyPressed = false;
			modifierFlags = ModifierKeyFlags.None;
			int num = 0;
			ControllerPollingInfo controllerPollingInfo = default(ControllerPollingInfo);
			ControllerPollingInfo controllerPollingInfo2 = default(ControllerPollingInfo);
			ModifierKeyFlags modifierKeyFlags = ModifierKeyFlags.None;
			foreach (ControllerPollingInfo controllerPollingInfo3 in ReInput.controllers.Keyboard.PollForAllKeys())
			{
				KeyCode keyboardKey = controllerPollingInfo3.keyboardKey;
				if (keyboardKey != KeyCode.AltGr)
				{
					if (Keyboard.IsModifierKey(controllerPollingInfo3.keyboardKey))
					{
						if (num == 0)
						{
							controllerPollingInfo2 = controllerPollingInfo3;
						}
						modifierKeyFlags |= Keyboard.KeyCodeToModifierKeyFlags(keyboardKey);
						num++;
					}
					else if (controllerPollingInfo.keyboardKey == KeyCode.None)
					{
						controllerPollingInfo = controllerPollingInfo3;
					}
				}
			}
			if (controllerPollingInfo.keyboardKey == KeyCode.None)
			{
				if (num > 0)
				{
					modifierKeyPressed = true;
					if (num == 1)
					{
						if (ReInput.controllers.Keyboard.GetKeyTimePressed(controllerPollingInfo2.keyboardKey) > 1.0)
						{
							pollingInfo = controllerPollingInfo2;
							return;
						}
						label = Keyboard.GetKeyName(controllerPollingInfo2.keyboardKey);
						return;
					}
					else
					{
						label = this._language.ModifierKeyFlagsToString(modifierKeyFlags);
					}
				}
				return;
			}
			if (!ReInput.controllers.Keyboard.GetKeyDown(controllerPollingInfo.keyboardKey))
			{
				return;
			}
			if (num == 0)
			{
				pollingInfo = controllerPollingInfo;
				return;
			}
			pollingInfo = controllerPollingInfo;
			modifierFlags = modifierKeyFlags;
		}

		// Token: 0x06001C14 RID: 7188 RVA: 0x000CFE1C File Offset: 0x000CE01C
		private bool GetFirstElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, out ElementAssignmentConflictInfo conflict, bool skipOtherPlayers)
		{
			if (this.GetFirstElementAssignmentConflict(this.currentPlayer, conflictCheck, out conflict))
			{
				return true;
			}
			if (this.GetFirstElementAssignmentConflict(ReInput.players.SystemPlayer, conflictCheck, out conflict))
			{
				return true;
			}
			if (!skipOtherPlayers)
			{
				IList<Player> players = ReInput.players.Players;
				for (int i = 0; i < players.Count; i++)
				{
					Player player = players[i];
					if (player != this.currentPlayer && this.GetFirstElementAssignmentConflict(player, conflictCheck, out conflict))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06001C15 RID: 7189 RVA: 0x000CFE90 File Offset: 0x000CE090
		private bool GetFirstElementAssignmentConflict(Player player, ElementAssignmentConflictCheck conflictCheck, out ElementAssignmentConflictInfo conflict)
		{
			using (IEnumerator<ElementAssignmentConflictInfo> enumerator = player.controllers.conflictChecking.ElementAssignmentConflicts(conflictCheck).GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					ElementAssignmentConflictInfo elementAssignmentConflictInfo = enumerator.Current;
					conflict = elementAssignmentConflictInfo;
					return true;
				}
			}
			conflict = default(ElementAssignmentConflictInfo);
			return false;
		}

		// Token: 0x06001C16 RID: 7190 RVA: 0x000CFEF8 File Offset: 0x000CE0F8
		private void StartAxisCalibration(int axisIndex)
		{
			if (this.currentPlayer == null)
			{
				return;
			}
			if (this.currentPlayer.controllers.joystickCount == 0)
			{
				return;
			}
			Joystick currentJoystick = this.currentJoystick;
			if (axisIndex < 0 || axisIndex >= currentJoystick.axisCount)
			{
				return;
			}
			this.pendingAxisCalibration = new ControlMapper.AxisCalibrator(currentJoystick, axisIndex);
			this.ShowCalibrateAxisStep1Window();
		}

		// Token: 0x06001C17 RID: 7191 RVA: 0x00015516 File Offset: 0x00013716
		private void EndAxisCalibration()
		{
			if (this.pendingAxisCalibration == null)
			{
				return;
			}
			this.pendingAxisCalibration.Commit();
			this.pendingAxisCalibration = null;
		}

		// Token: 0x06001C18 RID: 7192 RVA: 0x00015533 File Offset: 0x00013733
		private void SetUISelection(GameObject selection)
		{
			if (EventSystem.current == null)
			{
				return;
			}
			EventSystem.current.SetSelectedGameObject(selection);
		}

		// Token: 0x06001C19 RID: 7193 RVA: 0x0001554E File Offset: 0x0001374E
		private void RestoreLastUISelection()
		{
			if (this.lastUISelection == null || !this.lastUISelection.activeInHierarchy)
			{
				this.SetDefaultUISelection();
				return;
			}
			this.SetUISelection(this.lastUISelection);
		}

		// Token: 0x06001C1A RID: 7194 RVA: 0x0001557E File Offset: 0x0001377E
		private void SetDefaultUISelection()
		{
			if (!this.isOpen)
			{
				return;
			}
			if (this.references.defaultSelection == null)
			{
				this.SetUISelection(null);
				return;
			}
			this.SetUISelection(this.references.defaultSelection.gameObject);
		}

		// Token: 0x06001C1B RID: 7195 RVA: 0x000CFF4C File Offset: 0x000CE14C
		private void SelectDefaultMapCategory(bool redraw)
		{
			this.currentMapCategoryId = this.GetDefaultMapCategoryId();
			this.OnMapCategorySelected(this.currentMapCategoryId, redraw);
			if (!this.showMapCategories)
			{
				return;
			}
			for (int i = 0; i < this._mappingSets.Length; i++)
			{
				if (ReInput.mapping.GetMapCategory(this._mappingSets[i].mapCategoryId) != null)
				{
					this.currentMapCategoryId = this._mappingSets[i].mapCategoryId;
					break;
				}
			}
			if (this.currentMapCategoryId < 0)
			{
				return;
			}
			for (int j = 0; j < this._mappingSets.Length; j++)
			{
				bool flag = this._mappingSets[j].mapCategoryId != this.currentMapCategoryId;
				this.mapCategoryButtons[j].SetInteractible(flag, false);
			}
		}

		// Token: 0x06001C1C RID: 7196 RVA: 0x000155BA File Offset: 0x000137BA
		private void CheckUISelection()
		{
			if (!this.isFocused)
			{
				return;
			}
			if (this.currentUISelection == null)
			{
				this.RestoreLastUISelection();
			}
		}

		// Token: 0x06001C1D RID: 7197 RVA: 0x000155D9 File Offset: 0x000137D9
		private void OnUIElementSelected(GameObject selectedObject)
		{
			this.lastUISelection = selectedObject;
		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x000155E2 File Offset: 0x000137E2
		private void SetIsFocused(bool state)
		{
			this.references.mainCanvasGroup.interactable = state;
			if (state)
			{
				this.Redraw(false, false);
				this.RestoreLastUISelection();
				this.blockInputOnFocusEndTime = Time.unscaledTime + 0.1f;
			}
		}

		// Token: 0x06001C1F RID: 7199 RVA: 0x00015617 File Offset: 0x00013817
		public void Toggle()
		{
			if (this.isOpen)
			{
				this.Close(true);
				return;
			}
			this.Open();
		}

		// Token: 0x06001C20 RID: 7200 RVA: 0x0001562F File Offset: 0x0001382F
		public void Open()
		{
			this.Open(false);
		}

		// Token: 0x06001C21 RID: 7201 RVA: 0x000D0008 File Offset: 0x000CE208
		private void Open(bool force)
		{
			if (!this.initialized)
			{
				this.Initialize();
			}
			if (!this.initialized)
			{
				return;
			}
			if (!force && this.isOpen)
			{
				return;
			}
			this.Clear();
			this.canvas.SetActive(true);
			this.OnPlayerSelected(0, false);
			this.SelectDefaultMapCategory(false);
			this.SetDefaultUISelection();
			this.Redraw(true, false);
			if (this._ScreenOpenedEvent != null)
			{
				this._ScreenOpenedEvent();
			}
			if (this._onScreenOpened != null)
			{
				this._onScreenOpened.Invoke();
			}
		}

		// Token: 0x06001C22 RID: 7202 RVA: 0x000D0090 File Offset: 0x000CE290
		public void Close(bool save)
		{
			if (!this.initialized)
			{
				return;
			}
			if (!this.isOpen)
			{
				return;
			}
			if (save && ReInput.userDataStore != null)
			{
				ReInput.userDataStore.Save();
			}
			this.Clear();
			this.canvas.SetActive(false);
			this.SetUISelection(null);
			if (this._ScreenClosedEvent != null)
			{
				this._ScreenClosedEvent();
			}
			if (this._onScreenClosed != null)
			{
				this._onScreenClosed.Invoke();
			}
		}

		// Token: 0x06001C23 RID: 7203 RVA: 0x00015638 File Offset: 0x00013838
		private void Clear()
		{
			this.windowManager.CancelAll();
			this.lastUISelection = null;
			this.pendingInputMapping = null;
			this.pendingAxisCalibration = null;
			this.InputPollingStopped();
		}

		// Token: 0x06001C24 RID: 7204 RVA: 0x00015660 File Offset: 0x00013860
		private void ClearCompletely()
		{
			this.Clear();
			this.ClearSpawnedObjects();
			this.ClearAllVars();
		}

		// Token: 0x06001C25 RID: 7205 RVA: 0x000D0104 File Offset: 0x000CE304
		private void ClearSpawnedObjects()
		{
			this.windowManager.ClearCompletely();
			this.inputGrid.ClearAll();
			foreach (ControlMapper.GUIButton guibutton in this.playerButtons)
			{
				global::UnityEngine.Object.Destroy(guibutton.gameObject);
			}
			this.playerButtons.Clear();
			foreach (ControlMapper.GUIButton guibutton2 in this.mapCategoryButtons)
			{
				global::UnityEngine.Object.Destroy(guibutton2.gameObject);
			}
			this.mapCategoryButtons.Clear();
			foreach (ControlMapper.GUIButton guibutton3 in this.assignedControllerButtons)
			{
				global::UnityEngine.Object.Destroy(guibutton3.gameObject);
			}
			this.assignedControllerButtons.Clear();
			if (this.assignedControllerButtonsPlaceholder != null)
			{
				global::UnityEngine.Object.Destroy(this.assignedControllerButtonsPlaceholder.gameObject);
				this.assignedControllerButtonsPlaceholder = null;
			}
			foreach (GameObject gameObject in this.miscInstantiatedObjects)
			{
				global::UnityEngine.Object.Destroy(gameObject);
			}
			this.miscInstantiatedObjects.Clear();
		}

		// Token: 0x06001C26 RID: 7206 RVA: 0x00015674 File Offset: 0x00013874
		private void ClearVarsOnPlayerChange()
		{
			this.currentJoystickId = -1;
		}

		// Token: 0x06001C27 RID: 7207 RVA: 0x00015674 File Offset: 0x00013874
		private void ClearVarsOnJoystickChange()
		{
			this.currentJoystickId = -1;
		}

		// Token: 0x06001C28 RID: 7208 RVA: 0x000D0284 File Offset: 0x000CE484
		private void ClearAllVars()
		{
			this.initialized = false;
			ControlMapper.Instance = null;
			this.playerCount = 0;
			this.inputGrid = null;
			this.windowManager = null;
			this.currentPlayerId = -1;
			this.currentMapCategoryId = -1;
			this.playerButtons = null;
			this.mapCategoryButtons = null;
			this.miscInstantiatedObjects = null;
			this.canvas = null;
			this.lastUISelection = null;
			this.currentJoystickId = -1;
			this.pendingInputMapping = null;
			this.pendingAxisCalibration = null;
			this.inputFieldActivatedDelegate = null;
			this.inputFieldInvertToggleStateChangedDelegate = null;
			this.isPollingForInput = false;
		}

		// Token: 0x06001C29 RID: 7209 RVA: 0x0001567D File Offset: 0x0001387D
		public void Reset()
		{
			if (!this.initialized)
			{
				return;
			}
			this.ClearCompletely();
			this.Initialize();
			if (this.isOpen)
			{
				this.Open(true);
			}
		}

		// Token: 0x06001C2A RID: 7210 RVA: 0x000D0310 File Offset: 0x000CE510
		private void SetActionAxisInverted(bool state, ControllerType controllerType, int actionElementMapId)
		{
			if (this.currentPlayer == null)
			{
				return;
			}
			ControllerMapWithAxes controllerMapWithAxes = this.GetControllerMap(controllerType) as ControllerMapWithAxes;
			if (controllerMapWithAxes == null)
			{
				return;
			}
			ActionElementMap elementMap = controllerMapWithAxes.GetElementMap(actionElementMapId);
			if (elementMap == null)
			{
				return;
			}
			elementMap.invert = state;
		}

		// Token: 0x06001C2B RID: 7211 RVA: 0x000D034C File Offset: 0x000CE54C
		private ControllerMap GetControllerMap(ControllerType type)
		{
			if (this.currentPlayer == null)
			{
				return null;
			}
			int num = 0;
			switch (type)
			{
			case ControllerType.Keyboard:
			case ControllerType.Mouse:
				break;
			case ControllerType.Joystick:
				if (this.currentPlayer.controllers.joystickCount <= 0)
				{
					return null;
				}
				num = this.currentJoystick.id;
				break;
			default:
				throw new NotImplementedException();
			}
			return this.currentPlayer.controllers.maps.GetFirstMapInCategory(type, num, this.currentMapCategoryId);
		}

		// Token: 0x06001C2C RID: 7212 RVA: 0x000D03C0 File Offset: 0x000CE5C0
		private ControllerMap GetControllerMapOrCreateNew(ControllerType controllerType, int controllerId, int layoutId)
		{
			ControllerMap controllerMap = this.GetControllerMap(controllerType);
			if (controllerMap == null)
			{
				this.currentPlayer.controllers.maps.AddEmptyMap(controllerType, controllerId, this.currentMapCategoryId, layoutId);
				controllerMap = this.currentPlayer.controllers.maps.GetMap(controllerType, controllerId, this.currentMapCategoryId, layoutId);
			}
			return controllerMap;
		}

		// Token: 0x06001C2D RID: 7213 RVA: 0x000D0418 File Offset: 0x000CE618
		private int CountIEnumerable<T>(IEnumerable<T> enumerable)
		{
			if (enumerable == null)
			{
				return 0;
			}
			IEnumerator<T> enumerator = enumerable.GetEnumerator();
			if (enumerator == null)
			{
				return 0;
			}
			int num = 0;
			while (enumerator.MoveNext())
			{
				num++;
			}
			return num;
		}

		// Token: 0x06001C2E RID: 7214 RVA: 0x000D0448 File Offset: 0x000CE648
		private int GetDefaultMapCategoryId()
		{
			if (this._mappingSets.Length == 0)
			{
				return 0;
			}
			for (int i = 0; i < this._mappingSets.Length; i++)
			{
				if (ReInput.mapping.GetMapCategory(this._mappingSets[i].mapCategoryId) != null)
				{
					return this._mappingSets[i].mapCategoryId;
				}
			}
			return 0;
		}

		// Token: 0x06001C2F RID: 7215 RVA: 0x000D049C File Offset: 0x000CE69C
		private void SubscribeFixedUISelectionEvents()
		{
			if (this.references.fixedSelectableUIElements == null)
			{
				return;
			}
			GameObject[] fixedSelectableUIElements = this.references.fixedSelectableUIElements;
			for (int i = 0; i < fixedSelectableUIElements.Length; i++)
			{
				UIElementInfo component = UnityTools.GetComponent<UIElementInfo>(fixedSelectableUIElements[i]);
				if (!(component == null))
				{
					component.OnSelectedEvent += this.OnUIElementSelected;
				}
			}
		}

		// Token: 0x06001C30 RID: 7216 RVA: 0x000D04F8 File Offset: 0x000CE6F8
		private void SubscribeMenuControlInputEvents()
		{
			this.SubscribeRewiredInputEventAllPlayers(this._screenToggleAction, new Action<InputActionEventData>(this.OnScreenToggleActionPressed));
			this.SubscribeRewiredInputEventAllPlayers(this._screenOpenAction, new Action<InputActionEventData>(this.OnScreenOpenActionPressed));
			this.SubscribeRewiredInputEventAllPlayers(this._screenCloseAction, new Action<InputActionEventData>(this.OnScreenCloseActionPressed));
			this.SubscribeRewiredInputEventAllPlayers(this._universalCancelAction, new Action<InputActionEventData>(this.OnUniversalCancelActionPressed));
		}

		// Token: 0x06001C31 RID: 7217 RVA: 0x000D0568 File Offset: 0x000CE768
		private void UnsubscribeMenuControlInputEvents()
		{
			this.UnsubscribeRewiredInputEventAllPlayers(this._screenToggleAction, new Action<InputActionEventData>(this.OnScreenToggleActionPressed));
			this.UnsubscribeRewiredInputEventAllPlayers(this._screenOpenAction, new Action<InputActionEventData>(this.OnScreenOpenActionPressed));
			this.UnsubscribeRewiredInputEventAllPlayers(this._screenCloseAction, new Action<InputActionEventData>(this.OnScreenCloseActionPressed));
			this.UnsubscribeRewiredInputEventAllPlayers(this._universalCancelAction, new Action<InputActionEventData>(this.OnUniversalCancelActionPressed));
		}

		// Token: 0x06001C32 RID: 7218 RVA: 0x000D05D8 File Offset: 0x000CE7D8
		private void SubscribeRewiredInputEventAllPlayers(int actionId, Action<InputActionEventData> callback)
		{
			if (actionId < 0 || callback == null)
			{
				return;
			}
			if (ReInput.mapping.GetAction(actionId) == null)
			{
				Debug.LogWarning("Rewired Control Mapper: " + actionId.ToString() + " is not a valid Action id!");
				return;
			}
			foreach (Player player in ReInput.players.AllPlayers)
			{
				player.AddInputEventDelegate(callback, UpdateLoopType.Update, InputActionEventType.ButtonJustPressed, actionId);
			}
		}

		// Token: 0x06001C33 RID: 7219 RVA: 0x000D065C File Offset: 0x000CE85C
		private void UnsubscribeRewiredInputEventAllPlayers(int actionId, Action<InputActionEventData> callback)
		{
			if (actionId < 0 || callback == null)
			{
				return;
			}
			if (!ReInput.isReady)
			{
				return;
			}
			if (ReInput.mapping.GetAction(actionId) == null)
			{
				Debug.LogWarning("Rewired Control Mapper: " + actionId.ToString() + " is not a valid Action id!");
				return;
			}
			foreach (Player player in ReInput.players.AllPlayers)
			{
				player.RemoveInputEventDelegate(callback, UpdateLoopType.Update, InputActionEventType.ButtonJustPressed, actionId);
			}
		}

		// Token: 0x06001C34 RID: 7220 RVA: 0x000156A3 File Offset: 0x000138A3
		private int GetMaxControllersPerPlayer()
		{
			if (this._rewiredInputManager.userData.ConfigVars.autoAssignJoysticks)
			{
				return this._rewiredInputManager.userData.ConfigVars.maxJoysticksPerPlayer;
			}
			return this._maxControllersPerPlayer;
		}

		// Token: 0x06001C35 RID: 7221 RVA: 0x000156D8 File Offset: 0x000138D8
		private bool ShowAssignedControllers()
		{
			return this._showControllers && (this._showAssignedControllers || this.GetMaxControllersPerPlayer() != 1);
		}

		// Token: 0x06001C36 RID: 7222 RVA: 0x000156FA File Offset: 0x000138FA
		private void InspectorPropertyChanged(bool reset = false)
		{
			if (reset)
			{
				this.Reset();
			}
		}

		// Token: 0x06001C37 RID: 7223 RVA: 0x000D06E8 File Offset: 0x000CE8E8
		private void AssignController(Player player, int controllerId)
		{
			if (player == null)
			{
				return;
			}
			if (player.controllers.ContainsController(ControllerType.Joystick, controllerId))
			{
				return;
			}
			if (this.GetMaxControllersPerPlayer() == 1)
			{
				this.RemoveAllControllers(player);
				this.ClearVarsOnJoystickChange();
			}
			foreach (Player player2 in ReInput.players.Players)
			{
				if (player2 != player)
				{
					this.RemoveController(player2, controllerId);
				}
			}
			player.controllers.AddController(ControllerType.Joystick, controllerId, false);
			if (ReInput.userDataStore != null)
			{
				ReInput.userDataStore.LoadControllerData(player.id, ControllerType.Joystick, controllerId);
			}
		}

		// Token: 0x06001C38 RID: 7224 RVA: 0x000D0790 File Offset: 0x000CE990
		private void RemoveAllControllers(Player player)
		{
			if (player == null)
			{
				return;
			}
			IList<Joystick> joysticks = player.controllers.Joysticks;
			for (int i = joysticks.Count - 1; i >= 0; i--)
			{
				this.RemoveController(player, joysticks[i].id);
			}
		}

		// Token: 0x06001C39 RID: 7225 RVA: 0x00015705 File Offset: 0x00013905
		private void RemoveController(Player player, int controllerId)
		{
			if (player == null)
			{
				return;
			}
			if (!player.controllers.ContainsController(ControllerType.Joystick, controllerId))
			{
				return;
			}
			if (ReInput.userDataStore != null)
			{
				ReInput.userDataStore.SaveControllerData(player.id, ControllerType.Joystick, controllerId);
			}
			player.controllers.RemoveController(ControllerType.Joystick, controllerId);
		}

		// Token: 0x06001C3A RID: 7226 RVA: 0x00015741 File Offset: 0x00013941
		private bool IsAllowedAssignment(ControlMapper.InputMapping pendingInputMapping, ControllerPollingInfo pollingInfo)
		{
			return pendingInputMapping != null && (pendingInputMapping.axisRange != AxisRange.Full || this._showSplitAxisInputFields || pollingInfo.elementType != ControllerElementType.Button);
		}

		// Token: 0x06001C3B RID: 7227 RVA: 0x00015765 File Offset: 0x00013965
		private void InputPollingStarted()
		{
			bool flag = this.isPollingForInput;
			this.isPollingForInput = true;
			if (!flag)
			{
				if (this._InputPollingStartedEvent != null)
				{
					this._InputPollingStartedEvent();
				}
				if (this._onInputPollingStarted != null)
				{
					this._onInputPollingStarted.Invoke();
				}
			}
		}

		// Token: 0x06001C3C RID: 7228 RVA: 0x0001579C File Offset: 0x0001399C
		private void InputPollingStopped()
		{
			bool flag = this.isPollingForInput;
			this.isPollingForInput = false;
			if (flag)
			{
				if (this._InputPollingEndedEvent != null)
				{
					this._InputPollingEndedEvent();
				}
				if (this._onInputPollingEnded != null)
				{
					this._onInputPollingEnded.Invoke();
				}
			}
		}

		// Token: 0x06001C3D RID: 7229 RVA: 0x000157D3 File Offset: 0x000139D3
		private int GetControllerInputFieldCount(ControllerType controllerType)
		{
			switch (controllerType)
			{
			case ControllerType.Keyboard:
				return this._keyboardInputFieldCount;
			case ControllerType.Mouse:
				return this._mouseInputFieldCount;
			case ControllerType.Joystick:
				return this._controllerInputFieldCount;
			default:
				throw new NotImplementedException();
			}
		}

		// Token: 0x06001C3E RID: 7230 RVA: 0x000D07D4 File Offset: 0x000CE9D4
		private bool ShowSwapButton(int windowId, ControlMapper.InputMapping mapping, ElementAssignment assignment, bool skipOtherPlayers)
		{
			if (this.currentPlayer == null)
			{
				return false;
			}
			if (!this._allowElementAssignmentSwap)
			{
				return false;
			}
			if (mapping == null || mapping.aem == null)
			{
				return false;
			}
			ElementAssignmentConflictCheck elementAssignmentConflictCheck;
			if (!this.CreateConflictCheck(mapping, assignment, out elementAssignmentConflictCheck))
			{
				Debug.LogError("Rewired Control Mapper: Error creating conflict check!");
				return false;
			}
			List<ElementAssignmentConflictInfo> list = new List<ElementAssignmentConflictInfo>();
			list.AddRange(this.currentPlayer.controllers.conflictChecking.ElementAssignmentConflicts(elementAssignmentConflictCheck));
			list.AddRange(ReInput.players.SystemPlayer.controllers.conflictChecking.ElementAssignmentConflicts(elementAssignmentConflictCheck));
			if (list.Count == 0)
			{
				return false;
			}
			ActionElementMap aem2 = mapping.aem;
			ElementAssignmentConflictInfo elementAssignmentConflictInfo = list[0];
			int actionId = elementAssignmentConflictInfo.elementMap.actionId;
			Pole axisContribution = elementAssignmentConflictInfo.elementMap.axisContribution;
			AxisRange axisRange = aem2.axisRange;
			ControllerElementType elementType = aem2.elementType;
			if (elementType == elementAssignmentConflictInfo.elementMap.elementType && elementType == ControllerElementType.Axis)
			{
				if (axisRange != elementAssignmentConflictInfo.elementMap.axisRange)
				{
					if (axisRange == AxisRange.Full)
					{
						axisRange = AxisRange.Positive;
					}
					else if (elementAssignmentConflictInfo.elementMap.axisRange == AxisRange.Full)
					{
					}
				}
			}
			else if (elementType == ControllerElementType.Axis && (elementAssignmentConflictInfo.elementMap.elementType == ControllerElementType.Button || (elementAssignmentConflictInfo.elementMap.elementType == ControllerElementType.Axis && elementAssignmentConflictInfo.elementMap.axisRange != AxisRange.Full)) && axisRange == AxisRange.Full)
			{
				axisRange = AxisRange.Positive;
			}
			int num = 0;
			if (assignment.actionId == elementAssignmentConflictInfo.actionId && mapping.map == elementAssignmentConflictInfo.controllerMap)
			{
				Controller controller = ReInput.controllers.GetController(mapping.controllerType, mapping.controllerId);
				if (this.SwapIsSameInputRange(elementType, axisRange, axisContribution, controller.GetElementById(assignment.elementIdentifierId).type, assignment.axisRange, assignment.axisContribution))
				{
					num++;
				}
			}
			using (IEnumerator<ActionElementMap> enumerator = elementAssignmentConflictInfo.controllerMap.ElementMapsWithAction(actionId).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ActionElementMap aem = enumerator.Current;
					if (aem.id != aem2.id && list.FindIndex((ElementAssignmentConflictInfo x) => x.elementMapId == aem.id) < 0 && this.SwapIsSameInputRange(elementType, axisRange, axisContribution, aem.elementType, aem.axisRange, aem.axisContribution))
					{
						num++;
					}
				}
			}
			return num < this.GetControllerInputFieldCount(mapping.controllerType);
		}

		// Token: 0x06001C3F RID: 7231 RVA: 0x00015803 File Offset: 0x00013A03
		private bool SwapIsSameInputRange(ControllerElementType origElementType, AxisRange origAxisRange, Pole origAxisContribution, ControllerElementType conflictElementType, AxisRange conflictAxisRange, Pole conflictAxisContribution)
		{
			return ((origElementType == ControllerElementType.Button || (origElementType == ControllerElementType.Axis && origAxisRange != AxisRange.Full)) && (conflictElementType == ControllerElementType.Button || (conflictElementType == ControllerElementType.Axis && conflictAxisRange != AxisRange.Full)) && conflictAxisContribution == origAxisContribution) || (origElementType == ControllerElementType.Axis && origAxisRange == AxisRange.Full && conflictElementType == ControllerElementType.Axis && conflictAxisRange == AxisRange.Full);
		}

		// Token: 0x06001C40 RID: 7232 RVA: 0x00015834 File Offset: 0x00013A34
		public static void ApplyTheme(ThemedElement.ElementInfo[] elementInfo)
		{
			if (ControlMapper.Instance == null)
			{
				return;
			}
			if (ControlMapper.Instance._themeSettings == null)
			{
				return;
			}
			if (!ControlMapper.Instance._useThemeSettings)
			{
				return;
			}
			ControlMapper.Instance._themeSettings.Apply(elementInfo);
		}

		// Token: 0x06001C41 RID: 7233 RVA: 0x00015874 File Offset: 0x00013A74
		public static LanguageDataBase GetLanguage()
		{
			if (ControlMapper.Instance == null)
			{
				return null;
			}
			return ControlMapper.Instance._language;
		}

		// Token: 0x0400133E RID: 4926
		public const int versionMajor = 1;

		// Token: 0x0400133F RID: 4927
		public const int versionMinor = 1;

		// Token: 0x04001340 RID: 4928
		public const bool usesTMPro = true;

		// Token: 0x04001341 RID: 4929
		private const float blockInputOnFocusTimeout = 0.1f;

		// Token: 0x04001342 RID: 4930
		private const string buttonIdentifier_playerSelection = "PlayerSelection";

		// Token: 0x04001343 RID: 4931
		private const string buttonIdentifier_removeController = "RemoveController";

		// Token: 0x04001344 RID: 4932
		private const string buttonIdentifier_assignController = "AssignController";

		// Token: 0x04001345 RID: 4933
		private const string buttonIdentifier_calibrateController = "CalibrateController";

		// Token: 0x04001346 RID: 4934
		private const string buttonIdentifier_editInputBehaviors = "EditInputBehaviors";

		// Token: 0x04001347 RID: 4935
		private const string buttonIdentifier_mapCategorySelection = "MapCategorySelection";

		// Token: 0x04001348 RID: 4936
		private const string buttonIdentifier_assignedControllerSelection = "AssignedControllerSelection";

		// Token: 0x04001349 RID: 4937
		private const string buttonIdentifier_done = "Done";

		// Token: 0x0400134A RID: 4938
		private const string buttonIdentifier_restoreDefaults = "RestoreDefaults";

		// Token: 0x0400134B RID: 4939
		[SerializeField]
		private TextMeshProUGUI informationText;

		// Token: 0x0400134C RID: 4940
		[SerializeField]
		private TextMeshProUGUI windowTitleText;

		// Token: 0x0400134D RID: 4941
		[SerializeField]
		private TextMeshProUGUI playersSectionTitleText;

		// Token: 0x0400134E RID: 4942
		[SerializeField]
		private TextMeshProUGUI controllerSectionTitleText;

		// Token: 0x0400134F RID: 4943
		[SerializeField]
		private TextMeshProUGUI assignedControllersSectionTitle;

		// Token: 0x04001350 RID: 4944
		[SerializeField]
		[Tooltip("Must be assigned a Rewired Input Manager scene object or prefab.")]
		private InputManager _rewiredInputManager;

		// Token: 0x04001351 RID: 4945
		[SerializeField]
		[Tooltip("Set to True to prevent the Game Object from being destroyed when a new scene is loaded.\n\nNOTE: Changing this value from True to False at runtime will have no effect because Object.DontDestroyOnLoad cannot be undone once set.")]
		private bool _dontDestroyOnLoad;

		// Token: 0x04001352 RID: 4946
		[SerializeField]
		[Tooltip("Open the control mapping screen immediately on start. Mainly used for testing.")]
		private bool _openOnStart;

		// Token: 0x04001353 RID: 4947
		[SerializeField]
		[Tooltip("The Layout of the Keyboard Maps to be displayed.")]
		private int _keyboardMapDefaultLayout;

		// Token: 0x04001354 RID: 4948
		[Tooltip("The Layout of the Mouse Maps to be displayed.")]
		[SerializeField]
		private int _mouseMapDefaultLayout;

		// Token: 0x04001355 RID: 4949
		[SerializeField]
		[Tooltip("The Layout of the Mouse Maps to be displayed.")]
		private int _joystickMapDefaultLayout;

		// Token: 0x04001356 RID: 4950
		[SerializeField]
		private ControlMapper.MappingSet[] _mappingSets = new ControlMapper.MappingSet[] { ControlMapper.MappingSet.Default };

		// Token: 0x04001357 RID: 4951
		[Tooltip("Display a selectable list of Players. If your game only supports 1 player, you can disable this.")]
		[SerializeField]
		private bool _showPlayers = true;

		// Token: 0x04001358 RID: 4952
		[SerializeField]
		[Tooltip("Display the Controller column for input mapping.")]
		private bool _showControllers = true;

		// Token: 0x04001359 RID: 4953
		[Tooltip("Display the Keyboard column for input mapping.")]
		[SerializeField]
		private bool _showKeyboard = true;

		// Token: 0x0400135A RID: 4954
		[Tooltip("Display the Mouse column for input mapping.")]
		[SerializeField]
		private bool _showMouse = true;

		// Token: 0x0400135B RID: 4955
		[SerializeField]
		[Tooltip("The maximum number of controllers allowed to be assigned to a Player. If set to any value other than 1, a selectable list of currently-assigned controller will be displayed to the user. [0 = infinite]")]
		private int _maxControllersPerPlayer = 1;

		// Token: 0x0400135C RID: 4956
		[SerializeField]
		[Tooltip("Display section labels for each Action Category in the input field grid. Only applies if Action Categories are used to display the Action list.")]
		private bool _showActionCategoryLabels;

		// Token: 0x0400135D RID: 4957
		[Tooltip("The number of input fields to display for the keyboard. If you want to support alternate mappings on the same device, set this to 2 or more.")]
		[SerializeField]
		private int _keyboardInputFieldCount = 2;

		// Token: 0x0400135E RID: 4958
		[Tooltip("The number of input fields to display for the mouse. If you want to support alternate mappings on the same device, set this to 2 or more.")]
		[SerializeField]
		private int _mouseInputFieldCount = 1;

		// Token: 0x0400135F RID: 4959
		[Tooltip("The number of input fields to display for joysticks. If you want to support alternate mappings on the same device, set this to 2 or more.")]
		[SerializeField]
		private int _controllerInputFieldCount = 1;

		// Token: 0x04001360 RID: 4960
		[SerializeField]
		[Tooltip("Display a full-axis input assignment field for every axis-type Action in the input field grid. Also displays an invert toggle for the user  to invert the full-axis assignment direction.\n\n*IMPORTANT*: This field is required if you have made any full-axis assignments in the Rewired Input Manager or in saved XML user data. Disabling this field when you have full-axis assignments will result in the inability for the user to view, remove, or modify these full-axis assignments. In addition, these assignments may cause conflicts when trying to remap the same axes to Actions.")]
		private bool _showFullAxisInputFields = true;

		// Token: 0x04001361 RID: 4961
		[SerializeField]
		[Tooltip("Display a positive and negative input assignment field for every axis-type Action in the input field grid.\n\n*IMPORTANT*: These fields are required to assign buttons, keyboard keys, and hat or D-Pad directions to axis-type Actions. If you have made any split-axis assignments or button/key/D-pad assignments to axis-type Actions in the Rewired Input Manager or in saved XML user data, disabling these fields will result in the inability for the user to view, remove, or modify these assignments. In addition, these assignments may cause conflicts when trying to remap the same elements to Actions.")]
		private bool _showSplitAxisInputFields = true;

		// Token: 0x04001362 RID: 4962
		[SerializeField]
		[Tooltip("If enabled, when an element assignment conflict is found, an option will be displayed that allows the user to make the conflicting assignment anyway.")]
		private bool _allowElementAssignmentConflicts;

		// Token: 0x04001363 RID: 4963
		[SerializeField]
		[Tooltip("If enabled, when an element assignment conflict is found, an option will be displayed that allows the user to swap conflicting assignments. This only applies to the first conflicting assignment found. This option will not be displayed if allowElementAssignmentConflicts is true.")]
		private bool _allowElementAssignmentSwap;

		// Token: 0x04001364 RID: 4964
		[Tooltip("The width in relative pixels of the Action label column.")]
		[SerializeField]
		private int _actionLabelWidth = 200;

		// Token: 0x04001365 RID: 4965
		[SerializeField]
		[Tooltip("The width in relative pixels of the Keyboard column.")]
		private int _keyboardColMaxWidth = 360;

		// Token: 0x04001366 RID: 4966
		[SerializeField]
		[Tooltip("The width in relative pixels of the Mouse column.")]
		private int _mouseColMaxWidth = 200;

		// Token: 0x04001367 RID: 4967
		[SerializeField]
		[Tooltip("The width in relative pixels of the Controller column.")]
		private int _controllerColMaxWidth = 200;

		// Token: 0x04001368 RID: 4968
		[Tooltip("The height in relative pixels of the input grid button rows.")]
		[SerializeField]
		private int _inputRowHeight = 40;

		// Token: 0x04001369 RID: 4969
		[Tooltip("The padding of the input grid button rows.")]
		[SerializeField]
		private RectOffset _inputRowPadding = new RectOffset();

		// Token: 0x0400136A RID: 4970
		[Tooltip("The width in relative pixels of spacing between input fields in a single column.")]
		[SerializeField]
		private int _inputRowFieldSpacing;

		// Token: 0x0400136B RID: 4971
		[Tooltip("The width in relative pixels of spacing between columns.")]
		[SerializeField]
		private int _inputColumnSpacing = 40;

		// Token: 0x0400136C RID: 4972
		[Tooltip("The height in relative pixels of the space between Action Category sections. Only applicable if Show Action Category Labels is checked.")]
		[SerializeField]
		private int _inputRowCategorySpacing = 20;

		// Token: 0x0400136D RID: 4973
		[SerializeField]
		[Tooltip("The width in relative pixels of the invert toggle buttons.")]
		private int _invertToggleWidth = 40;

		// Token: 0x0400136E RID: 4974
		[SerializeField]
		[Tooltip("The width in relative pixels of generated popup windows.")]
		private int _defaultWindowWidth = 500;

		// Token: 0x0400136F RID: 4975
		[Tooltip("The height in relative pixels of generated popup windows.")]
		[SerializeField]
		private int _defaultWindowHeight = 400;

		// Token: 0x04001370 RID: 4976
		[Tooltip("The time in seconds the user has to press an element on a controller when assigning a controller to a Player. If this time elapses with no user input a controller, the assignment will be canceled.")]
		[SerializeField]
		private float _controllerAssignmentTimeout = 5f;

		// Token: 0x04001371 RID: 4977
		[SerializeField]
		[Tooltip("The time in seconds the user has to press an element on a controller while waiting for axes to be centered before assigning input.")]
		private float _preInputAssignmentTimeout = 5f;

		// Token: 0x04001372 RID: 4978
		[SerializeField]
		[Tooltip("The time in seconds the user has to press an element on a controller when assigning input. If this time elapses with no user input on the target controller, the assignment will be canceled.")]
		private float _inputAssignmentTimeout = 5f;

		// Token: 0x04001373 RID: 4979
		[SerializeField]
		[Tooltip("The time in seconds the user has to press an element on a controller during calibration.")]
		private float _axisCalibrationTimeout = 5f;

		// Token: 0x04001374 RID: 4980
		[SerializeField]
		[Tooltip("If checked, mouse X-axis movement will always be ignored during input assignment. Check this if you don't want the horizontal mouse axis to be user-assignable to any Actions.")]
		private bool _ignoreMouseXAxisAssignment = true;

		// Token: 0x04001375 RID: 4981
		[Tooltip("If checked, mouse Y-axis movement will always be ignored during input assignment. Check this if you don't want the vertical mouse axis to be user-assignable to any Actions.")]
		[SerializeField]
		private bool _ignoreMouseYAxisAssignment = true;

		// Token: 0x04001376 RID: 4982
		[SerializeField]
		[Tooltip("An Action that when activated will alternately close or open the main screen as long as no popup windows are open.")]
		private int _screenToggleAction = -1;

		// Token: 0x04001377 RID: 4983
		[SerializeField]
		[Tooltip("An Action that when activated will open the main screen if it is closed.")]
		private int _screenOpenAction = -1;

		// Token: 0x04001378 RID: 4984
		[SerializeField]
		[Tooltip("An Action that when activated will close the main screen as long as no popup windows are open.")]
		private int _screenCloseAction = -1;

		// Token: 0x04001379 RID: 4985
		[Tooltip("An Action that when activated will cancel and close any open popup window. Use with care because the element assigned to this Action can never be mapped by the user (because it would just cancel his assignment).")]
		[SerializeField]
		private int _universalCancelAction = -1;

		// Token: 0x0400137A RID: 4986
		[SerializeField]
		[Tooltip("If enabled, Universal Cancel will also close the main screen if pressed when no windows are open.")]
		private bool _universalCancelClosesScreen = true;

		// Token: 0x0400137B RID: 4987
		[SerializeField]
		[Tooltip("If checked, controls will be displayed which will allow the user to customize certain Input Behavior settings.")]
		private bool _showInputBehaviorSettings;

		// Token: 0x0400137C RID: 4988
		[Tooltip("Customizable settings for user-modifiable Input Behaviors. This can be used for settings like Mouse Look Sensitivity.")]
		[SerializeField]
		private ControlMapper.InputBehaviorSettings[] _inputBehaviorSettings;

		// Token: 0x0400137D RID: 4989
		[Tooltip("If enabled, UI elements will be themed based on the settings in Theme Settings.")]
		[SerializeField]
		private bool _useThemeSettings = true;

		// Token: 0x0400137E RID: 4990
		[SerializeField]
		[Tooltip("Must be assigned a ThemeSettings object. Used to theme UI elements.")]
		private ThemeSettings _themeSettings;

		// Token: 0x0400137F RID: 4991
		[Tooltip("Must be assigned a LanguageData object. Used to retrieve language entries for UI elements.")]
		[SerializeField]
		private LanguageDataBase _language;

		// Token: 0x04001380 RID: 4992
		[Tooltip("A list of prefabs. You should not have to modify this.")]
		[SerializeField]
		private ControlMapper.Prefabs prefabs;

		// Token: 0x04001381 RID: 4993
		[Tooltip("A list of references to elements in the hierarchy. You should not have to modify this.")]
		[SerializeField]
		private ControlMapper.References references;

		// Token: 0x04001382 RID: 4994
		[Tooltip("Show the label for the Players button group?")]
		[SerializeField]
		private bool _showPlayersGroupLabel = true;

		// Token: 0x04001383 RID: 4995
		[Tooltip("Show the label for the Controller button group?")]
		[SerializeField]
		private bool _showControllerGroupLabel = true;

		// Token: 0x04001384 RID: 4996
		[Tooltip("Show the label for the Assigned Controllers button group?")]
		[SerializeField]
		private bool _showAssignedControllersGroupLabel = true;

		// Token: 0x04001385 RID: 4997
		[Tooltip("Show the label for the Settings button group?")]
		[SerializeField]
		private bool _showSettingsGroupLabel = true;

		// Token: 0x04001386 RID: 4998
		[Tooltip("Show the label for the Map Categories button group?")]
		[SerializeField]
		private bool _showMapCategoriesGroupLabel = true;

		// Token: 0x04001387 RID: 4999
		[SerializeField]
		[Tooltip("Show the label for the current controller name?")]
		private bool _showControllerNameLabel = true;

		// Token: 0x04001388 RID: 5000
		[Tooltip("Show the Assigned Controllers group? If joystick auto-assignment is enabled in the Rewired Input Manager and the max joysticks per player is set to any value other than 1, the Assigned Controllers group will always be displayed.")]
		[SerializeField]
		private bool _showAssignedControllers = true;

		// Token: 0x04001389 RID: 5001
		private Action _ScreenClosedEvent;

		// Token: 0x0400138A RID: 5002
		private Action _ScreenOpenedEvent;

		// Token: 0x0400138B RID: 5003
		private Action _PopupWindowOpenedEvent;

		// Token: 0x0400138C RID: 5004
		private Action _PopupWindowClosedEvent;

		// Token: 0x0400138D RID: 5005
		private Action _InputPollingStartedEvent;

		// Token: 0x0400138E RID: 5006
		private Action _InputPollingEndedEvent;

		// Token: 0x0400138F RID: 5007
		[Tooltip("Event sent when the UI is closed.")]
		[SerializeField]
		private UnityEvent _onScreenClosed;

		// Token: 0x04001390 RID: 5008
		[SerializeField]
		[Tooltip("Event sent when the UI is opened.")]
		private UnityEvent _onScreenOpened;

		// Token: 0x04001391 RID: 5009
		[SerializeField]
		[Tooltip("Event sent when a popup window is closed.")]
		private UnityEvent _onPopupWindowClosed;

		// Token: 0x04001392 RID: 5010
		[SerializeField]
		[Tooltip("Event sent when a popup window is opened.")]
		private UnityEvent _onPopupWindowOpened;

		// Token: 0x04001393 RID: 5011
		[SerializeField]
		[Tooltip("Event sent when polling for input has started.")]
		private UnityEvent _onInputPollingStarted;

		// Token: 0x04001394 RID: 5012
		[SerializeField]
		[Tooltip("Event sent when polling for input has ended.")]
		private UnityEvent _onInputPollingEnded;

		// Token: 0x04001395 RID: 5013
		private static ControlMapper Instance;

		// Token: 0x04001396 RID: 5014
		private bool initialized;

		// Token: 0x04001397 RID: 5015
		private int playerCount;

		// Token: 0x04001398 RID: 5016
		private ControlMapper.InputGrid inputGrid;

		// Token: 0x04001399 RID: 5017
		private ControlMapper.WindowManager windowManager;

		// Token: 0x0400139A RID: 5018
		private int currentPlayerId;

		// Token: 0x0400139B RID: 5019
		private int currentMapCategoryId;

		// Token: 0x0400139C RID: 5020
		private List<ControlMapper.GUIButton> playerButtons;

		// Token: 0x0400139D RID: 5021
		private List<ControlMapper.GUIButton> mapCategoryButtons;

		// Token: 0x0400139E RID: 5022
		private List<ControlMapper.GUIButton> assignedControllerButtons;

		// Token: 0x0400139F RID: 5023
		private ControlMapper.GUIButton assignedControllerButtonsPlaceholder;

		// Token: 0x040013A0 RID: 5024
		private List<GameObject> miscInstantiatedObjects;

		// Token: 0x040013A1 RID: 5025
		private GameObject canvas;

		// Token: 0x040013A2 RID: 5026
		private GameObject lastUISelection;

		// Token: 0x040013A3 RID: 5027
		private int currentJoystickId = -1;

		// Token: 0x040013A4 RID: 5028
		private float blockInputOnFocusEndTime;

		// Token: 0x040013A5 RID: 5029
		private bool isPollingForInput;

		// Token: 0x040013A6 RID: 5030
		private ControlMapper.InputMapping pendingInputMapping;

		// Token: 0x040013A7 RID: 5031
		private ControlMapper.AxisCalibrator pendingAxisCalibration;

		// Token: 0x040013A8 RID: 5032
		private Action<InputFieldInfo> inputFieldActivatedDelegate;

		// Token: 0x040013A9 RID: 5033
		private Action<ToggleInfo, bool> inputFieldInvertToggleStateChangedDelegate;

		// Token: 0x040013AA RID: 5034
		private Action _restoreDefaultsDelegate;

		// Token: 0x040013AB RID: 5035
		private Dictionary<int, int> tomCymMap = new Dictionary<int, int>
		{
			{ 0, 39 },
			{ 2, 37 },
			{ 3, 38 },
			{ 39, 0 },
			{ 37, 2 },
			{ 38, 3 }
		};

		// Token: 0x02000289 RID: 649
		private abstract class GUIElement
		{
			// Token: 0x1700030C RID: 780
			// (get) Token: 0x06001C43 RID: 7235 RVA: 0x0001588F File Offset: 0x00013A8F
			// (set) Token: 0x06001C44 RID: 7236 RVA: 0x00015897 File Offset: 0x00013A97
			public RectTransform rectTransform { get; private set; }

			// Token: 0x06001C45 RID: 7237 RVA: 0x000D0BFC File Offset: 0x000CEDFC
			public GUIElement(GameObject gameObject)
			{
				if (gameObject == null)
				{
					Debug.LogError("Rewired Control Mapper: gameObject is null!");
					return;
				}
				this.selectable = gameObject.GetComponent<Selectable>();
				if (this.selectable == null)
				{
					Debug.LogError("Rewired Control Mapper: Selectable is null!");
					return;
				}
				this.gameObject = gameObject;
				this.rectTransform = gameObject.GetComponent<RectTransform>();
				this.text = UnityTools.GetComponentInSelfOrChildren<TMP_Text>(gameObject);
				this.uiElementInfo = gameObject.GetComponent<UIElementInfo>();
				this.children = new List<ControlMapper.GUIElement>();
			}

			// Token: 0x06001C46 RID: 7238 RVA: 0x000158A0 File Offset: 0x00013AA0
			public virtual void SetInteractible(bool state, bool playTransition)
			{
				this.SetInteractible(state, playTransition, false);
			}

			// Token: 0x06001C47 RID: 7239 RVA: 0x000D0C80 File Offset: 0x000CEE80
			public virtual void SetInteractible(bool state, bool playTransition, bool permanent)
			{
				for (int i = 0; i < this.children.Count; i++)
				{
					if (this.children[i] != null)
					{
						this.children[i].SetInteractible(state, playTransition, permanent);
					}
				}
				if (this.permanentStateSet)
				{
					return;
				}
				if (this.selectable == null)
				{
					return;
				}
				if (permanent)
				{
					this.permanentStateSet = true;
				}
				if (this.selectable.interactable == state)
				{
					return;
				}
				UITools.SetInteractable(this.selectable, state, playTransition);
			}

			// Token: 0x06001C48 RID: 7240 RVA: 0x000D0D04 File Offset: 0x000CEF04
			public virtual void SetFirstChildObjectWidth(ControlMapper.LayoutElementSizeType type, int value)
			{
				if (this.rectTransform.childCount == 0)
				{
					return;
				}
				Transform child = this.rectTransform.GetChild(0);
				LayoutElement layoutElement = child.GetComponent<LayoutElement>();
				if (layoutElement == null)
				{
					layoutElement = child.gameObject.AddComponent<LayoutElement>();
				}
				if (type == ControlMapper.LayoutElementSizeType.MinSize)
				{
					layoutElement.minWidth = (float)value;
					return;
				}
				if (type == ControlMapper.LayoutElementSizeType.PreferredSize)
				{
					layoutElement.preferredWidth = (float)value;
					return;
				}
				throw new NotImplementedException();
			}

			// Token: 0x06001C49 RID: 7241 RVA: 0x000158AB File Offset: 0x00013AAB
			public virtual void SetLabel(string label)
			{
				if (this.text == null)
				{
					return;
				}
				this.text.text = label;
			}

			// Token: 0x06001C4A RID: 7242 RVA: 0x000158C8 File Offset: 0x00013AC8
			public virtual string GetLabel()
			{
				if (this.text == null)
				{
					return string.Empty;
				}
				return this.text.text;
			}

			// Token: 0x06001C4B RID: 7243 RVA: 0x000158E9 File Offset: 0x00013AE9
			public void SetElementInfoData(string identifier, int intData)
			{
				if (this.uiElementInfo == null)
				{
					return;
				}
				this.uiElementInfo.identifier = identifier;
				this.uiElementInfo.intData = intData;
			}

			// Token: 0x06001C4C RID: 7244 RVA: 0x00015912 File Offset: 0x00013B12
			public virtual void SetActive(bool state)
			{
				if (this.gameObject == null)
				{
					return;
				}
				this.gameObject.SetActive(state);
			}

			// Token: 0x06001C4D RID: 7245 RVA: 0x000D0D68 File Offset: 0x000CEF68
			protected virtual bool Init()
			{
				bool flag = true;
				for (int i = 0; i < this.children.Count; i++)
				{
					if (this.children[i] != null && !this.children[i].Init())
					{
						flag = false;
					}
				}
				if (this.selectable == null)
				{
					Debug.LogError("Rewired Control Mapper: UI Element is missing Selectable component!");
					flag = false;
				}
				if (this.rectTransform == null)
				{
					Debug.LogError("Rewired Control Mapper: UI Element is missing RectTransform component!");
					flag = false;
				}
				if (this.uiElementInfo == null)
				{
					Debug.LogError("Rewired Control Mapper: UI Element is missing UIElementInfo component!");
					flag = false;
				}
				return flag;
			}

			// Token: 0x040013AC RID: 5036
			public readonly GameObject gameObject;

			// Token: 0x040013AD RID: 5037
			protected readonly TMP_Text text;

			// Token: 0x040013AE RID: 5038
			public readonly Selectable selectable;

			// Token: 0x040013AF RID: 5039
			protected readonly UIElementInfo uiElementInfo;

			// Token: 0x040013B0 RID: 5040
			protected bool permanentStateSet;

			// Token: 0x040013B1 RID: 5041
			protected readonly List<ControlMapper.GUIElement> children;
		}

		// Token: 0x0200028A RID: 650
		private class GUIButton : ControlMapper.GUIElement
		{
			// Token: 0x1700030D RID: 781
			// (get) Token: 0x06001C4E RID: 7246 RVA: 0x0001592F File Offset: 0x00013B2F
			protected Button button
			{
				get
				{
					return this.selectable as Button;
				}
			}

			// Token: 0x1700030E RID: 782
			// (get) Token: 0x06001C4F RID: 7247 RVA: 0x0001593C File Offset: 0x00013B3C
			public ButtonInfo buttonInfo
			{
				get
				{
					return this.uiElementInfo as ButtonInfo;
				}
			}

			// Token: 0x06001C50 RID: 7248 RVA: 0x00015949 File Offset: 0x00013B49
			public GUIButton(GameObject gameObject)
				: base(gameObject)
			{
				this.Init();
			}

			// Token: 0x06001C51 RID: 7249 RVA: 0x00015959 File Offset: 0x00013B59
			public void SetButtonInfoData(string identifier, int intData)
			{
				base.SetElementInfoData(identifier, intData);
			}

			// Token: 0x06001C52 RID: 7250 RVA: 0x000D0E00 File Offset: 0x000CF000
			public void SetOnClickCallback(Action<ButtonInfo> callback)
			{
				if (this.button == null)
				{
					return;
				}
				this.button.onClick.AddListener(delegate
				{
					callback(this.buttonInfo);
				});
			}
		}

		// Token: 0x0200028C RID: 652
		private class GUIInputField : ControlMapper.GUIElement
		{
			// Token: 0x1700030F RID: 783
			// (get) Token: 0x06001C55 RID: 7253 RVA: 0x0001592F File Offset: 0x00013B2F
			protected Button button
			{
				get
				{
					return this.selectable as Button;
				}
			}

			// Token: 0x17000310 RID: 784
			// (get) Token: 0x06001C56 RID: 7254 RVA: 0x0001597B File Offset: 0x00013B7B
			public InputFieldInfo fieldInfo
			{
				get
				{
					return this.uiElementInfo as InputFieldInfo;
				}
			}

			// Token: 0x17000311 RID: 785
			// (get) Token: 0x06001C57 RID: 7255 RVA: 0x00015988 File Offset: 0x00013B88
			public bool hasToggle
			{
				get
				{
					return this.toggle != null;
				}
			}

			// Token: 0x17000312 RID: 786
			// (get) Token: 0x06001C58 RID: 7256 RVA: 0x00015993 File Offset: 0x00013B93
			// (set) Token: 0x06001C59 RID: 7257 RVA: 0x0001599B File Offset: 0x00013B9B
			public ControlMapper.GUIToggle toggle { get; private set; }

			// Token: 0x17000313 RID: 787
			// (set) Token: 0x06001C5A RID: 7258 RVA: 0x000159A4 File Offset: 0x00013BA4
			public int actionElementMapId
			{
				set
				{
					if (this.fieldInfo == null)
					{
						return;
					}
					this.fieldInfo.actionElementMapId = value;
				}
			}

			// Token: 0x17000314 RID: 788
			// (set) Token: 0x06001C5B RID: 7259 RVA: 0x000159C1 File Offset: 0x00013BC1
			public int controllerId
			{
				set
				{
					if (this.fieldInfo == null)
					{
						return;
					}
					this.fieldInfo.controllerId = value;
				}
			}

			// Token: 0x06001C5C RID: 7260 RVA: 0x00015949 File Offset: 0x00013B49
			public GUIInputField(GameObject gameObject)
				: base(gameObject)
			{
				this.Init();
			}

			// Token: 0x06001C5D RID: 7261 RVA: 0x000D0E4C File Offset: 0x000CF04C
			public void SetFieldInfoData(int actionId, AxisRange axisRange, ControllerType controllerType, int intData)
			{
				base.SetElementInfoData(string.Empty, intData);
				if (this.fieldInfo == null)
				{
					return;
				}
				this.fieldInfo.actionId = actionId;
				this.fieldInfo.axisRange = axisRange;
				this.fieldInfo.controllerType = controllerType;
			}

			// Token: 0x06001C5E RID: 7262 RVA: 0x000D0E9C File Offset: 0x000CF09C
			public void SetOnClickCallback(Action<InputFieldInfo> callback)
			{
				if (this.button == null)
				{
					return;
				}
				this.button.onClick.AddListener(delegate
				{
					callback(this.fieldInfo);
				});
			}

			// Token: 0x06001C5F RID: 7263 RVA: 0x000159DE File Offset: 0x00013BDE
			public void AddToggle(ControlMapper.GUIToggle toggle)
			{
				if (toggle == null)
				{
					return;
				}
				this.toggle = toggle;
			}
		}

		// Token: 0x0200028E RID: 654
		private class GUIToggle : ControlMapper.GUIElement
		{
			// Token: 0x17000315 RID: 789
			// (get) Token: 0x06001C62 RID: 7266 RVA: 0x00015A03 File Offset: 0x00013C03
			protected Toggle toggle
			{
				get
				{
					return this.selectable as Toggle;
				}
			}

			// Token: 0x17000316 RID: 790
			// (get) Token: 0x06001C63 RID: 7267 RVA: 0x00015A10 File Offset: 0x00013C10
			public ToggleInfo toggleInfo
			{
				get
				{
					return this.uiElementInfo as ToggleInfo;
				}
			}

			// Token: 0x17000317 RID: 791
			// (get) Token: 0x06001C64 RID: 7268 RVA: 0x00015A1D File Offset: 0x00013C1D
			// (set) Token: 0x06001C65 RID: 7269 RVA: 0x00015A3A File Offset: 0x00013C3A
			public int actionElementMapId
			{
				get
				{
					if (this.toggleInfo == null)
					{
						return -1;
					}
					return this.toggleInfo.actionElementMapId;
				}
				set
				{
					if (this.toggleInfo == null)
					{
						return;
					}
					this.toggleInfo.actionElementMapId = value;
				}
			}

			// Token: 0x06001C66 RID: 7270 RVA: 0x00015949 File Offset: 0x00013B49
			public GUIToggle(GameObject gameObject)
				: base(gameObject)
			{
				this.Init();
			}

			// Token: 0x06001C67 RID: 7271 RVA: 0x000D0EE8 File Offset: 0x000CF0E8
			public void SetToggleInfoData(int actionId, AxisRange axisRange, ControllerType controllerType, int intData)
			{
				base.SetElementInfoData(string.Empty, intData);
				if (this.toggleInfo == null)
				{
					return;
				}
				this.toggleInfo.actionId = actionId;
				this.toggleInfo.axisRange = axisRange;
				this.toggleInfo.controllerType = controllerType;
			}

			// Token: 0x06001C68 RID: 7272 RVA: 0x000D0F38 File Offset: 0x000CF138
			public void SetOnSubmitCallback(Action<ToggleInfo, bool> callback)
			{
				if (this.toggle == null)
				{
					return;
				}
				EventTrigger eventTrigger = this.toggle.GetComponent<EventTrigger>();
				if (eventTrigger == null)
				{
					eventTrigger = this.toggle.gameObject.AddComponent<EventTrigger>();
				}
				EventTrigger.TriggerEvent triggerEvent = new EventTrigger.TriggerEvent();
				triggerEvent.AddListener(delegate(BaseEventData data)
				{
					PointerEventData pointerEventData = data as PointerEventData;
					if (pointerEventData != null && pointerEventData.button != PointerEventData.InputButton.Left)
					{
						return;
					}
					callback(this.toggleInfo, this.toggle.isOn);
				});
				EventTrigger.Entry entry = new EventTrigger.Entry
				{
					callback = triggerEvent,
					eventID = EventTriggerType.Submit
				};
				EventTrigger.Entry entry2 = new EventTrigger.Entry
				{
					callback = triggerEvent,
					eventID = EventTriggerType.PointerClick
				};
				if (eventTrigger.triggers != null)
				{
					eventTrigger.triggers.Clear();
				}
				else
				{
					eventTrigger.triggers = new List<EventTrigger.Entry>();
				}
				eventTrigger.triggers.Add(entry);
				eventTrigger.triggers.Add(entry2);
			}

			// Token: 0x06001C69 RID: 7273 RVA: 0x00015A57 File Offset: 0x00013C57
			public void SetToggleState(bool state)
			{
				if (this.toggle == null)
				{
					return;
				}
				this.toggle.isOn = state;
			}
		}

		// Token: 0x02000290 RID: 656
		private class GUILabel
		{
			// Token: 0x17000318 RID: 792
			// (get) Token: 0x06001C6C RID: 7276 RVA: 0x00015A74 File Offset: 0x00013C74
			// (set) Token: 0x06001C6D RID: 7277 RVA: 0x00015A7C File Offset: 0x00013C7C
			public GameObject gameObject { get; private set; }

			// Token: 0x17000319 RID: 793
			// (get) Token: 0x06001C6E RID: 7278 RVA: 0x00015A85 File Offset: 0x00013C85
			// (set) Token: 0x06001C6F RID: 7279 RVA: 0x00015A8D File Offset: 0x00013C8D
			private TMP_Text text { get; set; }

			// Token: 0x1700031A RID: 794
			// (get) Token: 0x06001C70 RID: 7280 RVA: 0x00015A96 File Offset: 0x00013C96
			// (set) Token: 0x06001C71 RID: 7281 RVA: 0x00015A9E File Offset: 0x00013C9E
			public RectTransform rectTransform { get; private set; }

			// Token: 0x06001C72 RID: 7282 RVA: 0x00015AA7 File Offset: 0x00013CA7
			public GUILabel(GameObject gameObject)
			{
				if (gameObject == null)
				{
					Debug.LogError("Rewired Control Mapper: gameObject is null!");
					return;
				}
				this.text = UnityTools.GetComponentInSelfOrChildren<TMP_Text>(gameObject);
				this.Check();
			}

			// Token: 0x06001C73 RID: 7283 RVA: 0x00015AD6 File Offset: 0x00013CD6
			public void SetFontStyle(FontStyles style)
			{
				if (this.text == null)
				{
					return;
				}
				this.text.fontStyle = style;
			}

			// Token: 0x06001C74 RID: 7284 RVA: 0x00015AF3 File Offset: 0x00013CF3
			public void SetTextAlignment(TextAlignmentOptions alignment)
			{
				if (this.text == null)
				{
					return;
				}
				this.text.alignment = alignment;
			}

			// Token: 0x06001C75 RID: 7285 RVA: 0x00015B10 File Offset: 0x00013D10
			public void SetActive(bool state)
			{
				if (this.gameObject == null)
				{
					return;
				}
				this.gameObject.SetActive(state);
			}

			// Token: 0x06001C76 RID: 7286 RVA: 0x000D1054 File Offset: 0x000CF254
			private bool Check()
			{
				bool flag = true;
				if (this.text == null)
				{
					Debug.LogError("Rewired Control Mapper: Button is missing Text child component!");
					flag = false;
				}
				this.gameObject = this.text.gameObject;
				this.rectTransform = this.text.GetComponent<RectTransform>();
				return flag;
			}
		}

		// Token: 0x02000291 RID: 657
		[Serializable]
		public class MappingSet
		{
			// Token: 0x1700031B RID: 795
			// (get) Token: 0x06001C77 RID: 7287 RVA: 0x00015B2D File Offset: 0x00013D2D
			public int mapCategoryId
			{
				get
				{
					return this._mapCategoryId;
				}
			}

			// Token: 0x1700031C RID: 796
			// (get) Token: 0x06001C78 RID: 7288 RVA: 0x00015B35 File Offset: 0x00013D35
			public ControlMapper.MappingSet.ActionListMode actionListMode
			{
				get
				{
					return this._actionListMode;
				}
			}

			// Token: 0x1700031D RID: 797
			// (get) Token: 0x06001C79 RID: 7289 RVA: 0x00015B3D File Offset: 0x00013D3D
			public IList<int> actionCategoryIds
			{
				get
				{
					if (this._actionCategoryIds == null)
					{
						return null;
					}
					if (this._actionCategoryIdsReadOnly == null)
					{
						this._actionCategoryIdsReadOnly = new ReadOnlyCollection<int>(this._actionCategoryIds);
					}
					return this._actionCategoryIdsReadOnly;
				}
			}

			// Token: 0x1700031E RID: 798
			// (get) Token: 0x06001C7A RID: 7290 RVA: 0x00015B68 File Offset: 0x00013D68
			public IList<int> actionIds
			{
				get
				{
					if (this._actionIds == null)
					{
						return null;
					}
					if (this._actionIdsReadOnly == null)
					{
						this._actionIdsReadOnly = new ReadOnlyCollection<int>(this._actionIds);
					}
					return this._actionIds;
				}
			}

			// Token: 0x1700031F RID: 799
			// (get) Token: 0x06001C7B RID: 7291 RVA: 0x00015B93 File Offset: 0x00013D93
			public bool isValid
			{
				get
				{
					return this._mapCategoryId >= 0 && ReInput.mapping.GetMapCategory(this._mapCategoryId) != null;
				}
			}

			// Token: 0x06001C7C RID: 7292 RVA: 0x00015BB3 File Offset: 0x00013DB3
			public MappingSet()
			{
				this._mapCategoryId = -1;
				this._actionCategoryIds = new int[0];
				this._actionIds = new int[0];
				this._actionListMode = ControlMapper.MappingSet.ActionListMode.ActionCategory;
			}

			// Token: 0x06001C7D RID: 7293 RVA: 0x00015BE1 File Offset: 0x00013DE1
			private MappingSet(int mapCategoryId, ControlMapper.MappingSet.ActionListMode actionListMode, int[] actionCategoryIds, int[] actionIds)
			{
				this._mapCategoryId = mapCategoryId;
				this._actionListMode = actionListMode;
				this._actionCategoryIds = actionCategoryIds;
				this._actionIds = actionIds;
			}

			// Token: 0x17000320 RID: 800
			// (get) Token: 0x06001C7E RID: 7294 RVA: 0x00015C06 File Offset: 0x00013E06
			public static ControlMapper.MappingSet Default
			{
				get
				{
					return new ControlMapper.MappingSet(0, ControlMapper.MappingSet.ActionListMode.ActionCategory, new int[1], new int[0]);
				}
			}

			// Token: 0x040013BD RID: 5053
			[Tooltip("The Map Category that will be displayed to the user for remapping.")]
			[SerializeField]
			private int _mapCategoryId;

			// Token: 0x040013BE RID: 5054
			[SerializeField]
			[Tooltip("Choose whether you want to list Actions to display for this Map Category by individual Action or by all the Actions in an Action Category.")]
			private ControlMapper.MappingSet.ActionListMode _actionListMode;

			// Token: 0x040013BF RID: 5055
			[SerializeField]
			private int[] _actionCategoryIds;

			// Token: 0x040013C0 RID: 5056
			[SerializeField]
			private int[] _actionIds;

			// Token: 0x040013C1 RID: 5057
			private IList<int> _actionCategoryIdsReadOnly;

			// Token: 0x040013C2 RID: 5058
			private IList<int> _actionIdsReadOnly;

			// Token: 0x02000292 RID: 658
			public enum ActionListMode
			{
				// Token: 0x040013C4 RID: 5060
				ActionCategory,
				// Token: 0x040013C5 RID: 5061
				Action
			}
		}

		// Token: 0x02000293 RID: 659
		[Serializable]
		public class InputBehaviorSettings
		{
			// Token: 0x17000321 RID: 801
			// (get) Token: 0x06001C7F RID: 7295 RVA: 0x00015C1B File Offset: 0x00013E1B
			public int inputBehaviorId
			{
				get
				{
					return this._inputBehaviorId;
				}
			}

			// Token: 0x17000322 RID: 802
			// (get) Token: 0x06001C80 RID: 7296 RVA: 0x00015C23 File Offset: 0x00013E23
			public bool showJoystickAxisSensitivity
			{
				get
				{
					return this._showJoystickAxisSensitivity;
				}
			}

			// Token: 0x17000323 RID: 803
			// (get) Token: 0x06001C81 RID: 7297 RVA: 0x00015C2B File Offset: 0x00013E2B
			public bool showMouseXYAxisSensitivity
			{
				get
				{
					return this._showMouseXYAxisSensitivity;
				}
			}

			// Token: 0x17000324 RID: 804
			// (get) Token: 0x06001C82 RID: 7298 RVA: 0x00015C33 File Offset: 0x00013E33
			public string labelLanguageKey
			{
				get
				{
					return this._labelLanguageKey;
				}
			}

			// Token: 0x17000325 RID: 805
			// (get) Token: 0x06001C83 RID: 7299 RVA: 0x00015C3B File Offset: 0x00013E3B
			public string joystickAxisSensitivityLabelLanguageKey
			{
				get
				{
					return this._joystickAxisSensitivityLabelLanguageKey;
				}
			}

			// Token: 0x17000326 RID: 806
			// (get) Token: 0x06001C84 RID: 7300 RVA: 0x00015C43 File Offset: 0x00013E43
			public string mouseXYAxisSensitivityLabelLanguageKey
			{
				get
				{
					return this._mouseXYAxisSensitivityLabelLanguageKey;
				}
			}

			// Token: 0x17000327 RID: 807
			// (get) Token: 0x06001C85 RID: 7301 RVA: 0x00015C4B File Offset: 0x00013E4B
			public Sprite joystickAxisSensitivityIcon
			{
				get
				{
					return this._joystickAxisSensitivityIcon;
				}
			}

			// Token: 0x17000328 RID: 808
			// (get) Token: 0x06001C86 RID: 7302 RVA: 0x00015C53 File Offset: 0x00013E53
			public Sprite mouseXYAxisSensitivityIcon
			{
				get
				{
					return this._mouseXYAxisSensitivityIcon;
				}
			}

			// Token: 0x17000329 RID: 809
			// (get) Token: 0x06001C87 RID: 7303 RVA: 0x00015C5B File Offset: 0x00013E5B
			public float joystickAxisSensitivityMin
			{
				get
				{
					return this._joystickAxisSensitivityMin;
				}
			}

			// Token: 0x1700032A RID: 810
			// (get) Token: 0x06001C88 RID: 7304 RVA: 0x00015C63 File Offset: 0x00013E63
			public float joystickAxisSensitivityMax
			{
				get
				{
					return this._joystickAxisSensitivityMax;
				}
			}

			// Token: 0x1700032B RID: 811
			// (get) Token: 0x06001C89 RID: 7305 RVA: 0x00015C6B File Offset: 0x00013E6B
			public float mouseXYAxisSensitivityMin
			{
				get
				{
					return this._mouseXYAxisSensitivityMin;
				}
			}

			// Token: 0x1700032C RID: 812
			// (get) Token: 0x06001C8A RID: 7306 RVA: 0x00015C73 File Offset: 0x00013E73
			public float mouseXYAxisSensitivityMax
			{
				get
				{
					return this._mouseXYAxisSensitivityMax;
				}
			}

			// Token: 0x1700032D RID: 813
			// (get) Token: 0x06001C8B RID: 7307 RVA: 0x00015C7B File Offset: 0x00013E7B
			public bool isValid
			{
				get
				{
					return this._inputBehaviorId >= 0 && (this._showJoystickAxisSensitivity || this._showMouseXYAxisSensitivity);
				}
			}

			// Token: 0x040013C6 RID: 5062
			[SerializeField]
			[Tooltip("The Input Behavior that will be displayed to the user for modification.")]
			private int _inputBehaviorId = -1;

			// Token: 0x040013C7 RID: 5063
			[SerializeField]
			[Tooltip("If checked, a slider will be displayed so the user can change this value.")]
			private bool _showJoystickAxisSensitivity = true;

			// Token: 0x040013C8 RID: 5064
			[Tooltip("If checked, a slider will be displayed so the user can change this value.")]
			[SerializeField]
			private bool _showMouseXYAxisSensitivity = true;

			// Token: 0x040013C9 RID: 5065
			[Tooltip("If set to a non-blank value, this key will be used to look up the name in Language to be displayed as the title for the Input Behavior control set. Otherwise, the name field of the InputBehavior will be used.")]
			[SerializeField]
			private string _labelLanguageKey = string.Empty;

			// Token: 0x040013CA RID: 5066
			[Tooltip("If set to a non-blank value, this name will be displayed above the individual slider control. Otherwise, no name will be displayed.")]
			[SerializeField]
			private string _joystickAxisSensitivityLabelLanguageKey = string.Empty;

			// Token: 0x040013CB RID: 5067
			[Tooltip("If set to a non-blank value, this key will be used to look up the name in Language to be displayed above the individual slider control. Otherwise, no name will be displayed.")]
			[SerializeField]
			private string _mouseXYAxisSensitivityLabelLanguageKey = string.Empty;

			// Token: 0x040013CC RID: 5068
			[SerializeField]
			[Tooltip("The icon to display next to the slider. Set to none for no icon.")]
			private Sprite _joystickAxisSensitivityIcon;

			// Token: 0x040013CD RID: 5069
			[SerializeField]
			[Tooltip("The icon to display next to the slider. Set to none for no icon.")]
			private Sprite _mouseXYAxisSensitivityIcon;

			// Token: 0x040013CE RID: 5070
			[SerializeField]
			[Tooltip("Minimum value the user is allowed to set for this property.")]
			private float _joystickAxisSensitivityMin;

			// Token: 0x040013CF RID: 5071
			[SerializeField]
			[Tooltip("Maximum value the user is allowed to set for this property.")]
			private float _joystickAxisSensitivityMax = 2f;

			// Token: 0x040013D0 RID: 5072
			[Tooltip("Minimum value the user is allowed to set for this property.")]
			[SerializeField]
			private float _mouseXYAxisSensitivityMin;

			// Token: 0x040013D1 RID: 5073
			[Tooltip("Maximum value the user is allowed to set for this property.")]
			[SerializeField]
			private float _mouseXYAxisSensitivityMax = 2f;
		}

		// Token: 0x02000294 RID: 660
		[Serializable]
		private class Prefabs
		{
			// Token: 0x1700032E RID: 814
			// (get) Token: 0x06001C8D RID: 7309 RVA: 0x00015C98 File Offset: 0x00013E98
			public GameObject button
			{
				get
				{
					return this._button;
				}
			}

			// Token: 0x1700032F RID: 815
			// (get) Token: 0x06001C8E RID: 7310 RVA: 0x00015CA0 File Offset: 0x00013EA0
			public GameObject fitButton
			{
				get
				{
					return this._fitButton;
				}
			}

			// Token: 0x17000330 RID: 816
			// (get) Token: 0x06001C8F RID: 7311 RVA: 0x00015CA8 File Offset: 0x00013EA8
			public GameObject inputGridLabel
			{
				get
				{
					return this._inputGridLabel;
				}
			}

			// Token: 0x17000331 RID: 817
			// (get) Token: 0x06001C90 RID: 7312 RVA: 0x00015CB0 File Offset: 0x00013EB0
			public GameObject inputGridHeaderLabel
			{
				get
				{
					return this._inputGridHeaderLabel;
				}
			}

			// Token: 0x17000332 RID: 818
			// (get) Token: 0x06001C91 RID: 7313 RVA: 0x00015CB8 File Offset: 0x00013EB8
			public GameObject inputGridFieldButton
			{
				get
				{
					return this._inputGridFieldButton;
				}
			}

			// Token: 0x17000333 RID: 819
			// (get) Token: 0x06001C92 RID: 7314 RVA: 0x00015CC0 File Offset: 0x00013EC0
			public GameObject inputGridFieldInvertToggle
			{
				get
				{
					return this._inputGridFieldInvertToggle;
				}
			}

			// Token: 0x17000334 RID: 820
			// (get) Token: 0x06001C93 RID: 7315 RVA: 0x00015CC8 File Offset: 0x00013EC8
			public GameObject window
			{
				get
				{
					return this._window;
				}
			}

			// Token: 0x17000335 RID: 821
			// (get) Token: 0x06001C94 RID: 7316 RVA: 0x00015CD0 File Offset: 0x00013ED0
			public GameObject windowTitleText
			{
				get
				{
					return this._windowTitleText;
				}
			}

			// Token: 0x17000336 RID: 822
			// (get) Token: 0x06001C95 RID: 7317 RVA: 0x00015CD8 File Offset: 0x00013ED8
			public GameObject windowContentText
			{
				get
				{
					return this._windowContentText;
				}
			}

			// Token: 0x17000337 RID: 823
			// (get) Token: 0x06001C96 RID: 7318 RVA: 0x00015CE0 File Offset: 0x00013EE0
			public GameObject fader
			{
				get
				{
					return this._fader;
				}
			}

			// Token: 0x17000338 RID: 824
			// (get) Token: 0x06001C97 RID: 7319 RVA: 0x00015CE8 File Offset: 0x00013EE8
			public GameObject calibrationWindow
			{
				get
				{
					return this._calibrationWindow;
				}
			}

			// Token: 0x17000339 RID: 825
			// (get) Token: 0x06001C98 RID: 7320 RVA: 0x00015CF0 File Offset: 0x00013EF0
			public GameObject inputBehaviorsWindow
			{
				get
				{
					return this._inputBehaviorsWindow;
				}
			}

			// Token: 0x1700033A RID: 826
			// (get) Token: 0x06001C99 RID: 7321 RVA: 0x00015CF8 File Offset: 0x00013EF8
			public GameObject centerStickGraphic
			{
				get
				{
					return this._centerStickGraphic;
				}
			}

			// Token: 0x1700033B RID: 827
			// (get) Token: 0x06001C9A RID: 7322 RVA: 0x00015D00 File Offset: 0x00013F00
			public GameObject moveStickGraphic
			{
				get
				{
					return this._moveStickGraphic;
				}
			}

			// Token: 0x06001C9B RID: 7323 RVA: 0x000D1100 File Offset: 0x000CF300
			public bool Check()
			{
				return !(this._button == null) && !(this._fitButton == null) && !(this._inputGridLabel == null) && !(this._inputGridHeaderLabel == null) && !(this._inputGridFieldButton == null) && !(this._inputGridFieldInvertToggle == null) && !(this._window == null) && !(this._windowTitleText == null) && !(this._windowContentText == null) && !(this._fader == null) && !(this._calibrationWindow == null) && !(this._inputBehaviorsWindow == null);
			}

			// Token: 0x040013D2 RID: 5074
			[SerializeField]
			private GameObject _button;

			// Token: 0x040013D3 RID: 5075
			[SerializeField]
			private GameObject _fitButton;

			// Token: 0x040013D4 RID: 5076
			[SerializeField]
			private GameObject _inputGridLabel;

			// Token: 0x040013D5 RID: 5077
			[SerializeField]
			private GameObject _inputGridHeaderLabel;

			// Token: 0x040013D6 RID: 5078
			[SerializeField]
			private GameObject _inputGridFieldButton;

			// Token: 0x040013D7 RID: 5079
			[SerializeField]
			private GameObject _inputGridFieldInvertToggle;

			// Token: 0x040013D8 RID: 5080
			[SerializeField]
			private GameObject _window;

			// Token: 0x040013D9 RID: 5081
			[SerializeField]
			private GameObject _windowTitleText;

			// Token: 0x040013DA RID: 5082
			[SerializeField]
			private GameObject _windowContentText;

			// Token: 0x040013DB RID: 5083
			[SerializeField]
			private GameObject _fader;

			// Token: 0x040013DC RID: 5084
			[SerializeField]
			private GameObject _calibrationWindow;

			// Token: 0x040013DD RID: 5085
			[SerializeField]
			private GameObject _inputBehaviorsWindow;

			// Token: 0x040013DE RID: 5086
			[SerializeField]
			private GameObject _centerStickGraphic;

			// Token: 0x040013DF RID: 5087
			[SerializeField]
			private GameObject _moveStickGraphic;
		}

		// Token: 0x02000295 RID: 661
		[Serializable]
		private class References
		{
			// Token: 0x1700033C RID: 828
			// (get) Token: 0x06001C9D RID: 7325 RVA: 0x00015D08 File Offset: 0x00013F08
			public Canvas canvas
			{
				get
				{
					return this._canvas;
				}
			}

			// Token: 0x1700033D RID: 829
			// (get) Token: 0x06001C9E RID: 7326 RVA: 0x00015D10 File Offset: 0x00013F10
			public CanvasGroup mainCanvasGroup
			{
				get
				{
					return this._mainCanvasGroup;
				}
			}

			// Token: 0x1700033E RID: 830
			// (get) Token: 0x06001C9F RID: 7327 RVA: 0x00015D18 File Offset: 0x00013F18
			public UIGroup playersGroup
			{
				get
				{
					return this._playersGroup;
				}
			}

			// Token: 0x1700033F RID: 831
			// (get) Token: 0x06001CA0 RID: 7328 RVA: 0x00015D20 File Offset: 0x00013F20
			public Transform controllerGroup
			{
				get
				{
					return this._controllerGroup;
				}
			}

			// Token: 0x17000340 RID: 832
			// (get) Token: 0x06001CA1 RID: 7329 RVA: 0x00015D28 File Offset: 0x00013F28
			public Transform controllerGroupLabelGroup
			{
				get
				{
					return this._controllerGroupLabelGroup;
				}
			}

			// Token: 0x17000341 RID: 833
			// (get) Token: 0x06001CA2 RID: 7330 RVA: 0x00015D30 File Offset: 0x00013F30
			public UIGroup controllerSettingsGroup
			{
				get
				{
					return this._controllerSettingsGroup;
				}
			}

			// Token: 0x17000342 RID: 834
			// (get) Token: 0x06001CA3 RID: 7331 RVA: 0x00015D38 File Offset: 0x00013F38
			public UIGroup assignedControllersGroup
			{
				get
				{
					return this._assignedControllersGroup;
				}
			}

			// Token: 0x17000343 RID: 835
			// (get) Token: 0x06001CA4 RID: 7332 RVA: 0x00015D40 File Offset: 0x00013F40
			public Transform settingsAndMapCategoriesGroup
			{
				get
				{
					return this._settingsAndMapCategoriesGroup;
				}
			}

			// Token: 0x17000344 RID: 836
			// (get) Token: 0x06001CA5 RID: 7333 RVA: 0x00015D48 File Offset: 0x00013F48
			public UIGroup settingsGroup
			{
				get
				{
					return this._settingsGroup;
				}
			}

			// Token: 0x17000345 RID: 837
			// (get) Token: 0x06001CA6 RID: 7334 RVA: 0x00015D50 File Offset: 0x00013F50
			public UIGroup mapCategoriesGroup
			{
				get
				{
					return this._mapCategoriesGroup;
				}
			}

			// Token: 0x17000346 RID: 838
			// (get) Token: 0x06001CA7 RID: 7335 RVA: 0x00015D58 File Offset: 0x00013F58
			public Transform inputGridContainer
			{
				get
				{
					return this._inputGridContainer;
				}
			}

			// Token: 0x17000347 RID: 839
			// (get) Token: 0x06001CA8 RID: 7336 RVA: 0x00015D60 File Offset: 0x00013F60
			public Transform inputGridHeadersGroup
			{
				get
				{
					return this._inputGridHeadersGroup;
				}
			}

			// Token: 0x17000348 RID: 840
			// (get) Token: 0x06001CA9 RID: 7337 RVA: 0x00015D68 File Offset: 0x00013F68
			public Scrollbar inputGridVScrollbar
			{
				get
				{
					return this._inputGridVScrollbar;
				}
			}

			// Token: 0x17000349 RID: 841
			// (get) Token: 0x06001CAA RID: 7338 RVA: 0x00015D70 File Offset: 0x00013F70
			public ScrollRect inputGridScrollRect
			{
				get
				{
					return this._inputGridScrollRect;
				}
			}

			// Token: 0x1700034A RID: 842
			// (get) Token: 0x06001CAB RID: 7339 RVA: 0x00015D78 File Offset: 0x00013F78
			public Transform inputGridInnerGroup
			{
				get
				{
					return this._inputGridInnerGroup;
				}
			}

			// Token: 0x1700034B RID: 843
			// (get) Token: 0x06001CAC RID: 7340 RVA: 0x00015D80 File Offset: 0x00013F80
			public TMP_Text controllerNameLabel
			{
				get
				{
					return this._controllerNameLabel;
				}
			}

			// Token: 0x1700034C RID: 844
			// (get) Token: 0x06001CAD RID: 7341 RVA: 0x00015D88 File Offset: 0x00013F88
			public Button removeControllerButton
			{
				get
				{
					return this._removeControllerButton;
				}
			}

			// Token: 0x1700034D RID: 845
			// (get) Token: 0x06001CAE RID: 7342 RVA: 0x00015D90 File Offset: 0x00013F90
			public Button assignControllerButton
			{
				get
				{
					return this._assignControllerButton;
				}
			}

			// Token: 0x1700034E RID: 846
			// (get) Token: 0x06001CAF RID: 7343 RVA: 0x00015D98 File Offset: 0x00013F98
			public Button calibrateControllerButton
			{
				get
				{
					return this._calibrateControllerButton;
				}
			}

			// Token: 0x1700034F RID: 847
			// (get) Token: 0x06001CB0 RID: 7344 RVA: 0x00015DA0 File Offset: 0x00013FA0
			public Button doneButton
			{
				get
				{
					return this._doneButton;
				}
			}

			// Token: 0x17000350 RID: 848
			// (get) Token: 0x06001CB1 RID: 7345 RVA: 0x00015DA8 File Offset: 0x00013FA8
			public Button restoreDefaultsButton
			{
				get
				{
					return this._restoreDefaultsButton;
				}
			}

			// Token: 0x17000351 RID: 849
			// (get) Token: 0x06001CB2 RID: 7346 RVA: 0x00015DB0 File Offset: 0x00013FB0
			public Selectable defaultSelection
			{
				get
				{
					return this._defaultSelection;
				}
			}

			// Token: 0x17000352 RID: 850
			// (get) Token: 0x06001CB3 RID: 7347 RVA: 0x00015DB8 File Offset: 0x00013FB8
			public GameObject[] fixedSelectableUIElements
			{
				get
				{
					return this._fixedSelectableUIElements;
				}
			}

			// Token: 0x17000353 RID: 851
			// (get) Token: 0x06001CB4 RID: 7348 RVA: 0x00015DC0 File Offset: 0x00013FC0
			// (set) Token: 0x06001CB5 RID: 7349 RVA: 0x00015DC8 File Offset: 0x00013FC8
			public LayoutElement inputGridLayoutElement { get; set; }

			// Token: 0x17000354 RID: 852
			// (get) Token: 0x06001CB6 RID: 7350 RVA: 0x00015DD1 File Offset: 0x00013FD1
			// (set) Token: 0x06001CB7 RID: 7351 RVA: 0x00015DD9 File Offset: 0x00013FD9
			public Transform inputGridActionColumn { get; set; }

			// Token: 0x17000355 RID: 853
			// (get) Token: 0x06001CB8 RID: 7352 RVA: 0x00015DE2 File Offset: 0x00013FE2
			// (set) Token: 0x06001CB9 RID: 7353 RVA: 0x00015DEA File Offset: 0x00013FEA
			public Transform inputGridKeyboardColumn { get; set; }

			// Token: 0x17000356 RID: 854
			// (get) Token: 0x06001CBA RID: 7354 RVA: 0x00015DF3 File Offset: 0x00013FF3
			// (set) Token: 0x06001CBB RID: 7355 RVA: 0x00015DFB File Offset: 0x00013FFB
			public Transform inputGridMouseColumn { get; set; }

			// Token: 0x17000357 RID: 855
			// (get) Token: 0x06001CBC RID: 7356 RVA: 0x00015E04 File Offset: 0x00014004
			// (set) Token: 0x06001CBD RID: 7357 RVA: 0x00015E0C File Offset: 0x0001400C
			public Transform inputGridControllerColumn { get; set; }

			// Token: 0x17000358 RID: 856
			// (get) Token: 0x06001CBE RID: 7358 RVA: 0x00015E15 File Offset: 0x00014015
			// (set) Token: 0x06001CBF RID: 7359 RVA: 0x00015E1D File Offset: 0x0001401D
			public Transform inputGridHeader1 { get; set; }

			// Token: 0x17000359 RID: 857
			// (get) Token: 0x06001CC0 RID: 7360 RVA: 0x00015E26 File Offset: 0x00014026
			// (set) Token: 0x06001CC1 RID: 7361 RVA: 0x00015E2E File Offset: 0x0001402E
			public Transform inputGridHeader2 { get; set; }

			// Token: 0x1700035A RID: 858
			// (get) Token: 0x06001CC2 RID: 7362 RVA: 0x00015E37 File Offset: 0x00014037
			// (set) Token: 0x06001CC3 RID: 7363 RVA: 0x00015E3F File Offset: 0x0001403F
			public Transform inputGridHeader3 { get; set; }

			// Token: 0x1700035B RID: 859
			// (get) Token: 0x06001CC4 RID: 7364 RVA: 0x00015E48 File Offset: 0x00014048
			// (set) Token: 0x06001CC5 RID: 7365 RVA: 0x00015E50 File Offset: 0x00014050
			public Transform inputGridHeader4 { get; set; }

			// Token: 0x06001CC6 RID: 7366 RVA: 0x000D11C0 File Offset: 0x000CF3C0
			public bool Check()
			{
				return !(this._canvas == null) && !(this._mainCanvasGroup == null) && !(this._mainContent == null) && !(this._mainContentInner == null) && !(this._playersGroup == null) && !(this._controllerGroup == null) && !(this._controllerGroupLabelGroup == null) && !(this._controllerSettingsGroup == null) && !(this._assignedControllersGroup == null) && !(this._settingsAndMapCategoriesGroup == null) && !(this._settingsGroup == null) && !(this._mapCategoriesGroup == null) && !(this._inputGridGroup == null) && !(this._inputGridContainer == null) && !(this._inputGridHeadersGroup == null) && !(this._inputGridVScrollbar == null) && !(this._inputGridScrollRect == null) && !(this._inputGridInnerGroup == null) && !(this._controllerNameLabel == null) && !(this._removeControllerButton == null) && !(this._assignControllerButton == null) && !(this._calibrateControllerButton == null) && !(this._doneButton == null) && !(this._restoreDefaultsButton == null) && !(this._defaultSelection == null);
			}

			// Token: 0x040013E0 RID: 5088
			[SerializeField]
			private Canvas _canvas;

			// Token: 0x040013E1 RID: 5089
			[SerializeField]
			private CanvasGroup _mainCanvasGroup;

			// Token: 0x040013E2 RID: 5090
			[SerializeField]
			private Transform _mainContent;

			// Token: 0x040013E3 RID: 5091
			[SerializeField]
			private Transform _mainContentInner;

			// Token: 0x040013E4 RID: 5092
			[SerializeField]
			private UIGroup _playersGroup;

			// Token: 0x040013E5 RID: 5093
			[SerializeField]
			private Transform _controllerGroup;

			// Token: 0x040013E6 RID: 5094
			[SerializeField]
			private Transform _controllerGroupLabelGroup;

			// Token: 0x040013E7 RID: 5095
			[SerializeField]
			private UIGroup _controllerSettingsGroup;

			// Token: 0x040013E8 RID: 5096
			[SerializeField]
			private UIGroup _assignedControllersGroup;

			// Token: 0x040013E9 RID: 5097
			[SerializeField]
			private Transform _settingsAndMapCategoriesGroup;

			// Token: 0x040013EA RID: 5098
			[SerializeField]
			private UIGroup _settingsGroup;

			// Token: 0x040013EB RID: 5099
			[SerializeField]
			private UIGroup _mapCategoriesGroup;

			// Token: 0x040013EC RID: 5100
			[SerializeField]
			private Transform _inputGridGroup;

			// Token: 0x040013ED RID: 5101
			[SerializeField]
			private Transform _inputGridContainer;

			// Token: 0x040013EE RID: 5102
			[SerializeField]
			private Transform _inputGridHeadersGroup;

			// Token: 0x040013EF RID: 5103
			[SerializeField]
			private Scrollbar _inputGridVScrollbar;

			// Token: 0x040013F0 RID: 5104
			[SerializeField]
			private ScrollRect _inputGridScrollRect;

			// Token: 0x040013F1 RID: 5105
			[SerializeField]
			private Transform _inputGridInnerGroup;

			// Token: 0x040013F2 RID: 5106
			[SerializeField]
			private TMP_Text _controllerNameLabel;

			// Token: 0x040013F3 RID: 5107
			[SerializeField]
			private Button _removeControllerButton;

			// Token: 0x040013F4 RID: 5108
			[SerializeField]
			private Button _assignControllerButton;

			// Token: 0x040013F5 RID: 5109
			[SerializeField]
			private Button _calibrateControllerButton;

			// Token: 0x040013F6 RID: 5110
			[SerializeField]
			private Button _doneButton;

			// Token: 0x040013F7 RID: 5111
			[SerializeField]
			private Button _restoreDefaultsButton;

			// Token: 0x040013F8 RID: 5112
			[SerializeField]
			private Selectable _defaultSelection;

			// Token: 0x040013F9 RID: 5113
			[SerializeField]
			private GameObject[] _fixedSelectableUIElements;

			// Token: 0x040013FA RID: 5114
			[SerializeField]
			private Image _mainBackgroundImage;
		}

		// Token: 0x02000296 RID: 662
		private class InputActionSet
		{
			// Token: 0x1700035C RID: 860
			// (get) Token: 0x06001CC8 RID: 7368 RVA: 0x00015E59 File Offset: 0x00014059
			public int actionId
			{
				get
				{
					return this._actionId;
				}
			}

			// Token: 0x1700035D RID: 861
			// (get) Token: 0x06001CC9 RID: 7369 RVA: 0x00015E61 File Offset: 0x00014061
			public AxisRange axisRange
			{
				get
				{
					return this._axisRange;
				}
			}

			// Token: 0x06001CCA RID: 7370 RVA: 0x00015E69 File Offset: 0x00014069
			public InputActionSet(int actionId, AxisRange axisRange)
			{
				this._actionId = actionId;
				this._axisRange = axisRange;
			}

			// Token: 0x04001404 RID: 5124
			private int _actionId;

			// Token: 0x04001405 RID: 5125
			private AxisRange _axisRange;
		}

		// Token: 0x02000297 RID: 663
		private class InputMapping
		{
			// Token: 0x1700035E RID: 862
			// (get) Token: 0x06001CCB RID: 7371 RVA: 0x00015E7F File Offset: 0x0001407F
			// (set) Token: 0x06001CCC RID: 7372 RVA: 0x00015E87 File Offset: 0x00014087
			public string actionName { get; private set; }

			// Token: 0x1700035F RID: 863
			// (get) Token: 0x06001CCD RID: 7373 RVA: 0x00015E90 File Offset: 0x00014090
			// (set) Token: 0x06001CCE RID: 7374 RVA: 0x00015E98 File Offset: 0x00014098
			public InputFieldInfo fieldInfo { get; private set; }

			// Token: 0x17000360 RID: 864
			// (get) Token: 0x06001CCF RID: 7375 RVA: 0x00015EA1 File Offset: 0x000140A1
			// (set) Token: 0x06001CD0 RID: 7376 RVA: 0x00015EA9 File Offset: 0x000140A9
			public ControllerMap map { get; private set; }

			// Token: 0x17000361 RID: 865
			// (get) Token: 0x06001CD1 RID: 7377 RVA: 0x00015EB2 File Offset: 0x000140B2
			// (set) Token: 0x06001CD2 RID: 7378 RVA: 0x00015EBA File Offset: 0x000140BA
			public ActionElementMap aem { get; private set; }

			// Token: 0x17000362 RID: 866
			// (get) Token: 0x06001CD3 RID: 7379 RVA: 0x00015EC3 File Offset: 0x000140C3
			// (set) Token: 0x06001CD4 RID: 7380 RVA: 0x00015ECB File Offset: 0x000140CB
			public ControllerType controllerType { get; private set; }

			// Token: 0x17000363 RID: 867
			// (get) Token: 0x06001CD5 RID: 7381 RVA: 0x00015ED4 File Offset: 0x000140D4
			// (set) Token: 0x06001CD6 RID: 7382 RVA: 0x00015EDC File Offset: 0x000140DC
			public int controllerId { get; private set; }

			// Token: 0x17000364 RID: 868
			// (get) Token: 0x06001CD7 RID: 7383 RVA: 0x00015EE5 File Offset: 0x000140E5
			// (set) Token: 0x06001CD8 RID: 7384 RVA: 0x00015EED File Offset: 0x000140ED
			public ControllerPollingInfo pollingInfo { get; set; }

			// Token: 0x17000365 RID: 869
			// (get) Token: 0x06001CD9 RID: 7385 RVA: 0x00015EF6 File Offset: 0x000140F6
			// (set) Token: 0x06001CDA RID: 7386 RVA: 0x00015EFE File Offset: 0x000140FE
			public ModifierKeyFlags modifierKeyFlags { get; set; }

			// Token: 0x17000366 RID: 870
			// (get) Token: 0x06001CDB RID: 7387 RVA: 0x000D135C File Offset: 0x000CF55C
			public AxisRange axisRange
			{
				get
				{
					AxisRange axisRange = AxisRange.Positive;
					if (this.pollingInfo.elementType == ControllerElementType.Axis)
					{
						if (this.fieldInfo.axisRange == AxisRange.Full)
						{
							axisRange = AxisRange.Full;
						}
						else
						{
							axisRange = ((this.pollingInfo.axisPole == Pole.Positive) ? AxisRange.Positive : AxisRange.Negative);
						}
					}
					return axisRange;
				}
			}

			// Token: 0x17000367 RID: 871
			// (get) Token: 0x06001CDC RID: 7388 RVA: 0x000D13A4 File Offset: 0x000CF5A4
			public string elementName
			{
				get
				{
					if (this.controllerType == ControllerType.Keyboard)
					{
						return ControlMapper.GetLanguage().GetElementIdentifierName(this.pollingInfo.keyboardKey, this.modifierKeyFlags);
					}
					return ControlMapper.GetLanguage().GetElementIdentifierName(this.pollingInfo.controller, this.pollingInfo.elementIdentifierId, (this.pollingInfo.axisPole == Pole.Positive) ? AxisRange.Positive : AxisRange.Negative);
				}
			}

			// Token: 0x06001CDD RID: 7389 RVA: 0x00015F07 File Offset: 0x00014107
			public InputMapping(string actionName, InputFieldInfo fieldInfo, ControllerMap map, ActionElementMap aem, ControllerType controllerType, int controllerId)
			{
				this.actionName = actionName;
				this.fieldInfo = fieldInfo;
				this.map = map;
				this.aem = aem;
				this.controllerType = controllerType;
				this.controllerId = controllerId;
			}

			// Token: 0x06001CDE RID: 7390 RVA: 0x00015F3C File Offset: 0x0001413C
			public ElementAssignment ToElementAssignment(ControllerPollingInfo pollingInfo)
			{
				this.pollingInfo = pollingInfo;
				return this.ToElementAssignment();
			}

			// Token: 0x06001CDF RID: 7391 RVA: 0x00015F4B File Offset: 0x0001414B
			public ElementAssignment ToElementAssignment(ControllerPollingInfo pollingInfo, ModifierKeyFlags modifierKeyFlags)
			{
				this.pollingInfo = pollingInfo;
				this.modifierKeyFlags = modifierKeyFlags;
				return this.ToElementAssignment();
			}

			// Token: 0x06001CE0 RID: 7392 RVA: 0x000D1414 File Offset: 0x000CF614
			public ElementAssignment ToElementAssignment()
			{
				return new ElementAssignment(this.controllerType, this.pollingInfo.elementType, this.pollingInfo.elementIdentifierId, this.axisRange, this.pollingInfo.keyboardKey, this.modifierKeyFlags, this.fieldInfo.actionId, (this.fieldInfo.axisRange == AxisRange.Negative) ? Pole.Negative : Pole.Positive, false, (this.aem != null) ? this.aem.id : (-1));
			}
		}

		// Token: 0x02000298 RID: 664
		private class AxisCalibrator
		{
			// Token: 0x17000368 RID: 872
			// (get) Token: 0x06001CE1 RID: 7393 RVA: 0x00015F61 File Offset: 0x00014161
			public bool isValid
			{
				get
				{
					return this.axis != null;
				}
			}

			// Token: 0x06001CE2 RID: 7394 RVA: 0x000D1498 File Offset: 0x000CF698
			public AxisCalibrator(Joystick joystick, int axisIndex)
			{
				this.data = default(AxisCalibrationData);
				this.joystick = joystick;
				this.axisIndex = axisIndex;
				if (joystick != null && axisIndex >= 0 && joystick.axisCount > axisIndex)
				{
					this.axis = joystick.Axes[axisIndex];
					this.data = joystick.calibrationMap.GetAxis(axisIndex).GetData();
				}
				this.firstRun = true;
			}

			// Token: 0x06001CE3 RID: 7395 RVA: 0x000D1508 File Offset: 0x000CF708
			public void RecordMinMax()
			{
				if (this.axis == null)
				{
					return;
				}
				float valueRaw = this.axis.valueRaw;
				if (this.firstRun || valueRaw < this.data.min)
				{
					this.data.min = valueRaw;
				}
				if (this.firstRun || valueRaw > this.data.max)
				{
					this.data.max = valueRaw;
				}
				this.firstRun = false;
			}

			// Token: 0x06001CE4 RID: 7396 RVA: 0x00015F6C File Offset: 0x0001416C
			public void RecordZero()
			{
				if (this.axis == null)
				{
					return;
				}
				this.data.zero = this.axis.valueRaw;
			}

			// Token: 0x06001CE5 RID: 7397 RVA: 0x000D1578 File Offset: 0x000CF778
			public void Commit()
			{
				if (this.axis == null)
				{
					return;
				}
				AxisCalibration axisCalibration = this.joystick.calibrationMap.GetAxis(this.axisIndex);
				if (axisCalibration == null)
				{
					return;
				}
				if ((double)Mathf.Abs(this.data.max - this.data.min) < 0.1)
				{
					return;
				}
				axisCalibration.SetData(this.data);
			}

			// Token: 0x0400140E RID: 5134
			public AxisCalibrationData data;

			// Token: 0x0400140F RID: 5135
			public readonly Joystick joystick;

			// Token: 0x04001410 RID: 5136
			public readonly int axisIndex;

			// Token: 0x04001411 RID: 5137
			private Controller.Axis axis;

			// Token: 0x04001412 RID: 5138
			private bool firstRun;
		}

		// Token: 0x02000299 RID: 665
		private class IndexedDictionary<TKey, TValue>
		{
			// Token: 0x17000369 RID: 873
			// (get) Token: 0x06001CE6 RID: 7398 RVA: 0x00015F8D File Offset: 0x0001418D
			public int Count
			{
				get
				{
					return this.list.Count;
				}
			}

			// Token: 0x06001CE7 RID: 7399 RVA: 0x00015F9A File Offset: 0x0001419A
			public IndexedDictionary()
			{
				this.list = new List<ControlMapper.IndexedDictionary<TKey, TValue>.Entry>();
			}

			// Token: 0x1700036A RID: 874
			public TValue this[int index]
			{
				get
				{
					return this.list[index].value;
				}
			}

			// Token: 0x06001CE9 RID: 7401 RVA: 0x000D15E0 File Offset: 0x000CF7E0
			public TValue Get(TKey key)
			{
				int num = this.IndexOfKey(key);
				if (num < 0)
				{
					throw new Exception("Key does not exist!");
				}
				return this.list[num].value;
			}

			// Token: 0x06001CEA RID: 7402 RVA: 0x000D1618 File Offset: 0x000CF818
			public bool TryGet(TKey key, out TValue value)
			{
				value = default(TValue);
				int num = this.IndexOfKey(key);
				if (num < 0)
				{
					return false;
				}
				value = this.list[num].value;
				return true;
			}

			// Token: 0x06001CEB RID: 7403 RVA: 0x00015FC0 File Offset: 0x000141C0
			public void Add(TKey key, TValue value)
			{
				if (this.ContainsKey(key))
				{
					throw new Exception("Key " + key.ToString() + " is already in use!");
				}
				this.list.Add(new ControlMapper.IndexedDictionary<TKey, TValue>.Entry(key, value));
			}

			// Token: 0x06001CEC RID: 7404 RVA: 0x000D1654 File Offset: 0x000CF854
			public int IndexOfKey(TKey key)
			{
				int count = this.list.Count;
				for (int i = 0; i < count; i++)
				{
					if (EqualityComparer<TKey>.Default.Equals(this.list[i].key, key))
					{
						return i;
					}
				}
				return -1;
			}

			// Token: 0x06001CED RID: 7405 RVA: 0x000D169C File Offset: 0x000CF89C
			public bool ContainsKey(TKey key)
			{
				int count = this.list.Count;
				for (int i = 0; i < count; i++)
				{
					if (EqualityComparer<TKey>.Default.Equals(this.list[i].key, key))
					{
						return true;
					}
				}
				return false;
			}

			// Token: 0x06001CEE RID: 7406 RVA: 0x00015FFF File Offset: 0x000141FF
			public void Clear()
			{
				this.list.Clear();
			}

			// Token: 0x04001413 RID: 5139
			private List<ControlMapper.IndexedDictionary<TKey, TValue>.Entry> list;

			// Token: 0x0200029A RID: 666
			private class Entry
			{
				// Token: 0x06001CEF RID: 7407 RVA: 0x0001600C File Offset: 0x0001420C
				public Entry(TKey key, TValue value)
				{
					this.key = key;
					this.value = value;
				}

				// Token: 0x04001414 RID: 5140
				public TKey key;

				// Token: 0x04001415 RID: 5141
				public TValue value;
			}
		}

		// Token: 0x0200029B RID: 667
		private enum LayoutElementSizeType
		{
			// Token: 0x04001417 RID: 5143
			MinSize,
			// Token: 0x04001418 RID: 5144
			PreferredSize
		}

		// Token: 0x0200029C RID: 668
		private class InputGrid
		{
			// Token: 0x06001CF0 RID: 7408 RVA: 0x00016022 File Offset: 0x00014222
			public InputGrid()
			{
				this.list = new ControlMapper.InputGridEntryList();
				this.groups = new List<GameObject>();
			}

			// Token: 0x06001CF1 RID: 7409 RVA: 0x00016040 File Offset: 0x00014240
			public void AddMapCategory(int mapCategoryId)
			{
				this.list.AddMapCategory(mapCategoryId);
			}

			// Token: 0x06001CF2 RID: 7410 RVA: 0x0001604E File Offset: 0x0001424E
			public void AddAction(int mapCategoryId, InputAction action, AxisRange axisRange)
			{
				this.list.AddAction(mapCategoryId, action, axisRange);
			}

			// Token: 0x06001CF3 RID: 7411 RVA: 0x0001605E File Offset: 0x0001425E
			public void AddActionCategory(int mapCategoryId, int actionCategoryId)
			{
				this.list.AddActionCategory(mapCategoryId, actionCategoryId);
			}

			// Token: 0x06001CF4 RID: 7412 RVA: 0x0001606D File Offset: 0x0001426D
			public void AddInputFieldSet(int mapCategoryId, InputAction action, AxisRange axisRange, ControllerType controllerType, GameObject fieldSetContainer)
			{
				this.list.AddInputFieldSet(mapCategoryId, action, axisRange, controllerType, fieldSetContainer);
			}

			// Token: 0x06001CF5 RID: 7413 RVA: 0x00016081 File Offset: 0x00014281
			public void AddInputField(int mapCategoryId, InputAction action, AxisRange axisRange, ControllerType controllerType, int fieldIndex, ControlMapper.GUIInputField inputField)
			{
				this.list.AddInputField(mapCategoryId, action, axisRange, controllerType, fieldIndex, inputField);
			}

			// Token: 0x06001CF6 RID: 7414 RVA: 0x00016097 File Offset: 0x00014297
			public void AddGroup(GameObject group)
			{
				this.groups.Add(group);
			}

			// Token: 0x06001CF7 RID: 7415 RVA: 0x000160A5 File Offset: 0x000142A5
			public void AddActionLabel(int mapCategoryId, int actionId, AxisRange axisRange, ControlMapper.GUILabel label)
			{
				this.list.AddActionLabel(mapCategoryId, actionId, axisRange, label);
			}

			// Token: 0x06001CF8 RID: 7416 RVA: 0x000160B7 File Offset: 0x000142B7
			public void AddActionCategoryLabel(int mapCategoryId, int actionCategoryId, ControlMapper.GUILabel label)
			{
				this.list.AddActionCategoryLabel(mapCategoryId, actionCategoryId, label);
			}

			// Token: 0x06001CF9 RID: 7417 RVA: 0x000160C7 File Offset: 0x000142C7
			public ControlMapper.GUIInputField GetGUIInputField(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int fieldIndex)
			{
				return this.list.GetGUIInputField(mapCategoryId, actionId, axisRange, controllerType, fieldIndex);
			}

			// Token: 0x06001CFA RID: 7418 RVA: 0x000160DB File Offset: 0x000142DB
			public IEnumerable<ControlMapper.InputActionSet> GetActionSets(int mapCategoryId)
			{
				return this.list.GetActionSets(mapCategoryId);
			}

			// Token: 0x06001CFB RID: 7419 RVA: 0x000160E9 File Offset: 0x000142E9
			public void SetColumnHeight(int mapCategoryId, float height)
			{
				this.list.SetColumnHeight(mapCategoryId, height);
			}

			// Token: 0x06001CFC RID: 7420 RVA: 0x000160F8 File Offset: 0x000142F8
			public float GetColumnHeight(int mapCategoryId)
			{
				return this.list.GetColumnHeight(mapCategoryId);
			}

			// Token: 0x06001CFD RID: 7421 RVA: 0x00016106 File Offset: 0x00014306
			public void SetFieldsActive(int mapCategoryId, bool state)
			{
				this.list.SetFieldsActive(mapCategoryId, state);
			}

			// Token: 0x06001CFE RID: 7422 RVA: 0x000D16E4 File Offset: 0x000CF8E4
			public void PopulateField(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int controllerId, int index, int actionElementMapId, string label, bool invert)
			{
				this.list.PopulateField(mapCategoryId, actionId, axisRange, controllerType, controllerId, index, actionElementMapId, label, invert);
			}

			// Token: 0x06001CFF RID: 7423 RVA: 0x00016115 File Offset: 0x00014315
			public void SetFixedFieldData(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int controllerId)
			{
				this.list.SetFixedFieldData(mapCategoryId, actionId, axisRange, controllerType, controllerId);
			}

			// Token: 0x06001D00 RID: 7424 RVA: 0x00016129 File Offset: 0x00014329
			public void InitializeFields(int mapCategoryId)
			{
				this.list.InitializeFields(mapCategoryId);
			}

			// Token: 0x06001D01 RID: 7425 RVA: 0x00016137 File Offset: 0x00014337
			public void Show(int mapCategoryId)
			{
				this.list.Show(mapCategoryId);
			}

			// Token: 0x06001D02 RID: 7426 RVA: 0x00016145 File Offset: 0x00014345
			public void HideAll()
			{
				this.list.HideAll();
			}

			// Token: 0x06001D03 RID: 7427 RVA: 0x000D170C File Offset: 0x000CF90C
			private void ClearGroups()
			{
				for (int i = 0; i < this.groups.Count; i++)
				{
					if (!(this.groups[i] == null))
					{
						global::UnityEngine.Object.Destroy(this.groups[i]);
					}
				}
			}

			// Token: 0x06001D04 RID: 7428 RVA: 0x00016152 File Offset: 0x00014352
			public void ClearAll()
			{
				this.ClearGroups();
				this.list.Clear();
			}

			// Token: 0x04001419 RID: 5145
			private ControlMapper.InputGridEntryList list;

			// Token: 0x0400141A RID: 5146
			private List<GameObject> groups;
		}

		// Token: 0x0200029D RID: 669
		private class InputGridEntryList
		{
			// Token: 0x06001D05 RID: 7429 RVA: 0x00016165 File Offset: 0x00014365
			public InputGridEntryList()
			{
				this.entries = new ControlMapper.IndexedDictionary<int, ControlMapper.InputGridEntryList.MapCategoryEntry>();
			}

			// Token: 0x06001D06 RID: 7430 RVA: 0x00016178 File Offset: 0x00014378
			public void AddMapCategory(int mapCategoryId)
			{
				if (mapCategoryId < 0)
				{
					return;
				}
				if (this.entries.ContainsKey(mapCategoryId))
				{
					return;
				}
				this.entries.Add(mapCategoryId, new ControlMapper.InputGridEntryList.MapCategoryEntry());
			}

			// Token: 0x06001D07 RID: 7431 RVA: 0x0001619F File Offset: 0x0001439F
			public void AddAction(int mapCategoryId, InputAction action, AxisRange axisRange)
			{
				this.AddActionEntry(mapCategoryId, action, axisRange);
			}

			// Token: 0x06001D08 RID: 7432 RVA: 0x000D1754 File Offset: 0x000CF954
			private ControlMapper.InputGridEntryList.ActionEntry AddActionEntry(int mapCategoryId, InputAction action, AxisRange axisRange)
			{
				if (action == null)
				{
					return null;
				}
				ControlMapper.InputGridEntryList.MapCategoryEntry mapCategoryEntry;
				if (!this.entries.TryGet(mapCategoryId, out mapCategoryEntry))
				{
					return null;
				}
				return mapCategoryEntry.AddAction(action, axisRange);
			}

			// Token: 0x06001D09 RID: 7433 RVA: 0x000D1780 File Offset: 0x000CF980
			public void AddActionLabel(int mapCategoryId, int actionId, AxisRange axisRange, ControlMapper.GUILabel label)
			{
				ControlMapper.InputGridEntryList.MapCategoryEntry mapCategoryEntry;
				if (!this.entries.TryGet(mapCategoryId, out mapCategoryEntry))
				{
					return;
				}
				ControlMapper.InputGridEntryList.ActionEntry actionEntry = mapCategoryEntry.GetActionEntry(actionId, axisRange);
				if (actionEntry == null)
				{
					return;
				}
				actionEntry.SetLabel(label);
			}

			// Token: 0x06001D0A RID: 7434 RVA: 0x000161AB File Offset: 0x000143AB
			public void AddActionCategory(int mapCategoryId, int actionCategoryId)
			{
				this.AddActionCategoryEntry(mapCategoryId, actionCategoryId);
			}

			// Token: 0x06001D0B RID: 7435 RVA: 0x000D17B4 File Offset: 0x000CF9B4
			private ControlMapper.InputGridEntryList.ActionCategoryEntry AddActionCategoryEntry(int mapCategoryId, int actionCategoryId)
			{
				ControlMapper.InputGridEntryList.MapCategoryEntry mapCategoryEntry;
				if (!this.entries.TryGet(mapCategoryId, out mapCategoryEntry))
				{
					return null;
				}
				return mapCategoryEntry.AddActionCategory(actionCategoryId);
			}

			// Token: 0x06001D0C RID: 7436 RVA: 0x000D17DC File Offset: 0x000CF9DC
			public void AddActionCategoryLabel(int mapCategoryId, int actionCategoryId, ControlMapper.GUILabel label)
			{
				ControlMapper.InputGridEntryList.MapCategoryEntry mapCategoryEntry;
				if (!this.entries.TryGet(mapCategoryId, out mapCategoryEntry))
				{
					return;
				}
				ControlMapper.InputGridEntryList.ActionCategoryEntry actionCategoryEntry = mapCategoryEntry.GetActionCategoryEntry(actionCategoryId);
				if (actionCategoryEntry == null)
				{
					return;
				}
				actionCategoryEntry.SetLabel(label);
			}

			// Token: 0x06001D0D RID: 7437 RVA: 0x000D1810 File Offset: 0x000CFA10
			public void AddInputFieldSet(int mapCategoryId, InputAction action, AxisRange axisRange, ControllerType controllerType, GameObject fieldSetContainer)
			{
				ControlMapper.InputGridEntryList.ActionEntry actionEntry = this.GetActionEntry(mapCategoryId, action, axisRange);
				if (actionEntry == null)
				{
					return;
				}
				actionEntry.AddInputFieldSet(controllerType, fieldSetContainer);
			}

			// Token: 0x06001D0E RID: 7438 RVA: 0x000D1838 File Offset: 0x000CFA38
			public void AddInputField(int mapCategoryId, InputAction action, AxisRange axisRange, ControllerType controllerType, int fieldIndex, ControlMapper.GUIInputField inputField)
			{
				ControlMapper.InputGridEntryList.ActionEntry actionEntry = this.GetActionEntry(mapCategoryId, action, axisRange);
				if (actionEntry == null)
				{
					return;
				}
				actionEntry.AddInputField(controllerType, fieldIndex, inputField);
			}

			// Token: 0x06001D0F RID: 7439 RVA: 0x000D1860 File Offset: 0x000CFA60
			public void SetColumnHeight(int mapCategoryId, float height)
			{
				ControlMapper.InputGridEntryList.MapCategoryEntry mapCategoryEntry;
				if (!this.entries.TryGet(mapCategoryId, out mapCategoryEntry))
				{
					return;
				}
				mapCategoryEntry.columnHeight = height;
			}

			// Token: 0x06001D10 RID: 7440 RVA: 0x000D1888 File Offset: 0x000CFA88
			public float GetColumnHeight(int mapCategoryId)
			{
				ControlMapper.InputGridEntryList.MapCategoryEntry mapCategoryEntry;
				if (!this.entries.TryGet(mapCategoryId, out mapCategoryEntry))
				{
					return 0f;
				}
				return mapCategoryEntry.columnHeight;
			}

			// Token: 0x06001D11 RID: 7441 RVA: 0x000D18B4 File Offset: 0x000CFAB4
			public ControlMapper.GUIInputField GetGUIInputField(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int fieldIndex)
			{
				ControlMapper.InputGridEntryList.ActionEntry actionEntry = this.GetActionEntry(mapCategoryId, actionId, axisRange);
				if (actionEntry == null)
				{
					return null;
				}
				return actionEntry.GetGUIInputField(controllerType, fieldIndex);
			}

			// Token: 0x06001D12 RID: 7442 RVA: 0x000D18DC File Offset: 0x000CFADC
			private ControlMapper.InputGridEntryList.ActionEntry GetActionEntry(int mapCategoryId, int actionId, AxisRange axisRange)
			{
				if (actionId < 0)
				{
					return null;
				}
				ControlMapper.InputGridEntryList.MapCategoryEntry mapCategoryEntry;
				if (!this.entries.TryGet(mapCategoryId, out mapCategoryEntry))
				{
					return null;
				}
				return mapCategoryEntry.GetActionEntry(actionId, axisRange);
			}

			// Token: 0x06001D13 RID: 7443 RVA: 0x000161B6 File Offset: 0x000143B6
			private ControlMapper.InputGridEntryList.ActionEntry GetActionEntry(int mapCategoryId, InputAction action, AxisRange axisRange)
			{
				if (action == null)
				{
					return null;
				}
				return this.GetActionEntry(mapCategoryId, action.id, axisRange);
			}

			// Token: 0x06001D14 RID: 7444 RVA: 0x000161CB File Offset: 0x000143CB
			public IEnumerable<ControlMapper.InputActionSet> GetActionSets(int mapCategoryId)
			{
				ControlMapper.InputGridEntryList.MapCategoryEntry mapCategoryEntry;
				if (!this.entries.TryGet(mapCategoryId, out mapCategoryEntry))
				{
					yield break;
				}
				List<ControlMapper.InputGridEntryList.ActionEntry> list = mapCategoryEntry.actionList;
				int count = ((list != null) ? list.Count : 0);
				int num;
				for (int i = 0; i < count; i = num + 1)
				{
					yield return list[i].actionSet;
					num = i;
				}
				yield break;
			}

			// Token: 0x06001D15 RID: 7445 RVA: 0x000D190C File Offset: 0x000CFB0C
			public void SetFieldsActive(int mapCategoryId, bool state)
			{
				ControlMapper.InputGridEntryList.MapCategoryEntry mapCategoryEntry;
				if (!this.entries.TryGet(mapCategoryId, out mapCategoryEntry))
				{
					return;
				}
				List<ControlMapper.InputGridEntryList.ActionEntry> actionList = mapCategoryEntry.actionList;
				int num = ((actionList != null) ? actionList.Count : 0);
				for (int i = 0; i < num; i++)
				{
					actionList[i].SetFieldsActive(state);
				}
			}

			// Token: 0x06001D16 RID: 7446 RVA: 0x000D1958 File Offset: 0x000CFB58
			public void PopulateField(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int controllerId, int index, int actionElementMapId, string label, bool invert)
			{
				ControlMapper.InputGridEntryList.ActionEntry actionEntry = this.GetActionEntry(mapCategoryId, actionId, axisRange);
				if (actionEntry == null)
				{
					return;
				}
				actionEntry.PopulateField(controllerType, controllerId, index, actionElementMapId, label, invert);
			}

			// Token: 0x06001D17 RID: 7447 RVA: 0x000D1988 File Offset: 0x000CFB88
			public void SetFixedFieldData(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int controllerId)
			{
				ControlMapper.InputGridEntryList.ActionEntry actionEntry = this.GetActionEntry(mapCategoryId, actionId, axisRange);
				if (actionEntry == null)
				{
					return;
				}
				actionEntry.SetFixedFieldData(controllerType, controllerId);
			}

			// Token: 0x06001D18 RID: 7448 RVA: 0x000D19B0 File Offset: 0x000CFBB0
			public void InitializeFields(int mapCategoryId)
			{
				ControlMapper.InputGridEntryList.MapCategoryEntry mapCategoryEntry;
				if (!this.entries.TryGet(mapCategoryId, out mapCategoryEntry))
				{
					return;
				}
				List<ControlMapper.InputGridEntryList.ActionEntry> actionList = mapCategoryEntry.actionList;
				int num = ((actionList != null) ? actionList.Count : 0);
				for (int i = 0; i < num; i++)
				{
					actionList[i].Initialize();
				}
			}

			// Token: 0x06001D19 RID: 7449 RVA: 0x000D19FC File Offset: 0x000CFBFC
			public void Show(int mapCategoryId)
			{
				ControlMapper.InputGridEntryList.MapCategoryEntry mapCategoryEntry;
				if (!this.entries.TryGet(mapCategoryId, out mapCategoryEntry))
				{
					return;
				}
				mapCategoryEntry.SetAllActive(true);
			}

			// Token: 0x06001D1A RID: 7450 RVA: 0x000D1A24 File Offset: 0x000CFC24
			public void HideAll()
			{
				for (int i = 0; i < this.entries.Count; i++)
				{
					this.entries[i].SetAllActive(false);
				}
			}

			// Token: 0x06001D1B RID: 7451 RVA: 0x000161E2 File Offset: 0x000143E2
			public void Clear()
			{
				this.entries.Clear();
			}

			// Token: 0x0400141B RID: 5147
			private ControlMapper.IndexedDictionary<int, ControlMapper.InputGridEntryList.MapCategoryEntry> entries;

			// Token: 0x0200029E RID: 670
			private class MapCategoryEntry
			{
				// Token: 0x1700036B RID: 875
				// (get) Token: 0x06001D1C RID: 7452 RVA: 0x000161EF File Offset: 0x000143EF
				public List<ControlMapper.InputGridEntryList.ActionEntry> actionList
				{
					get
					{
						return this._actionList;
					}
				}

				// Token: 0x1700036C RID: 876
				// (get) Token: 0x06001D1D RID: 7453 RVA: 0x000161F7 File Offset: 0x000143F7
				// (set) Token: 0x06001D1E RID: 7454 RVA: 0x000161FF File Offset: 0x000143FF
				public float columnHeight
				{
					get
					{
						return this._columnHeight;
					}
					set
					{
						this._columnHeight = value;
					}
				}

				// Token: 0x06001D1F RID: 7455 RVA: 0x00016208 File Offset: 0x00014408
				public MapCategoryEntry()
				{
					this._actionList = new List<ControlMapper.InputGridEntryList.ActionEntry>();
					this._actionCategoryList = new ControlMapper.IndexedDictionary<int, ControlMapper.InputGridEntryList.ActionCategoryEntry>();
				}

				// Token: 0x06001D20 RID: 7456 RVA: 0x000D1A5C File Offset: 0x000CFC5C
				public ControlMapper.InputGridEntryList.ActionEntry GetActionEntry(int actionId, AxisRange axisRange)
				{
					int num = this.IndexOfActionEntry(actionId, axisRange);
					if (num < 0)
					{
						return null;
					}
					return this._actionList[num];
				}

				// Token: 0x06001D21 RID: 7457 RVA: 0x000D1A84 File Offset: 0x000CFC84
				public int IndexOfActionEntry(int actionId, AxisRange axisRange)
				{
					int count = this._actionList.Count;
					for (int i = 0; i < count; i++)
					{
						if (this._actionList[i].Matches(actionId, axisRange))
						{
							return i;
						}
					}
					return -1;
				}

				// Token: 0x06001D22 RID: 7458 RVA: 0x00016226 File Offset: 0x00014426
				public bool ContainsActionEntry(int actionId, AxisRange axisRange)
				{
					return this.IndexOfActionEntry(actionId, axisRange) >= 0;
				}

				// Token: 0x06001D23 RID: 7459 RVA: 0x000D1AC4 File Offset: 0x000CFCC4
				public ControlMapper.InputGridEntryList.ActionEntry AddAction(InputAction action, AxisRange axisRange)
				{
					if (action == null)
					{
						return null;
					}
					if (this.ContainsActionEntry(action.id, axisRange))
					{
						return null;
					}
					this._actionList.Add(new ControlMapper.InputGridEntryList.ActionEntry(action, axisRange));
					return this._actionList[this._actionList.Count - 1];
				}

				// Token: 0x06001D24 RID: 7460 RVA: 0x00016236 File Offset: 0x00014436
				public ControlMapper.InputGridEntryList.ActionCategoryEntry GetActionCategoryEntry(int actionCategoryId)
				{
					if (!this._actionCategoryList.ContainsKey(actionCategoryId))
					{
						return null;
					}
					return this._actionCategoryList.Get(actionCategoryId);
				}

				// Token: 0x06001D25 RID: 7461 RVA: 0x00016254 File Offset: 0x00014454
				public ControlMapper.InputGridEntryList.ActionCategoryEntry AddActionCategory(int actionCategoryId)
				{
					if (actionCategoryId < 0)
					{
						return null;
					}
					if (this._actionCategoryList.ContainsKey(actionCategoryId))
					{
						return null;
					}
					this._actionCategoryList.Add(actionCategoryId, new ControlMapper.InputGridEntryList.ActionCategoryEntry(actionCategoryId));
					return this._actionCategoryList.Get(actionCategoryId);
				}

				// Token: 0x06001D26 RID: 7462 RVA: 0x000D1B14 File Offset: 0x000CFD14
				public void SetAllActive(bool state)
				{
					for (int i = 0; i < this._actionCategoryList.Count; i++)
					{
						this._actionCategoryList[i].SetActive(state);
					}
					for (int j = 0; j < this._actionList.Count; j++)
					{
						this._actionList[j].SetActive(state);
					}
				}

				// Token: 0x0400141C RID: 5148
				private List<ControlMapper.InputGridEntryList.ActionEntry> _actionList;

				// Token: 0x0400141D RID: 5149
				private ControlMapper.IndexedDictionary<int, ControlMapper.InputGridEntryList.ActionCategoryEntry> _actionCategoryList;

				// Token: 0x0400141E RID: 5150
				private float _columnHeight;
			}

			// Token: 0x0200029F RID: 671
			private class ActionEntry
			{
				// Token: 0x06001D27 RID: 7463 RVA: 0x0001628A File Offset: 0x0001448A
				public ActionEntry(InputAction action, AxisRange axisRange)
				{
					this.action = action;
					this.axisRange = axisRange;
					this.actionSet = new ControlMapper.InputActionSet(action.id, axisRange);
					this.fieldSets = new ControlMapper.IndexedDictionary<int, ControlMapper.InputGridEntryList.FieldSet>();
				}

				// Token: 0x06001D28 RID: 7464 RVA: 0x000162BD File Offset: 0x000144BD
				public void SetLabel(ControlMapper.GUILabel label)
				{
					this.label = label;
				}

				// Token: 0x06001D29 RID: 7465 RVA: 0x000162C6 File Offset: 0x000144C6
				public bool Matches(int actionId, AxisRange axisRange)
				{
					return this.action.id == actionId && this.axisRange == axisRange;
				}

				// Token: 0x06001D2A RID: 7466 RVA: 0x000162E4 File Offset: 0x000144E4
				public void AddInputFieldSet(ControllerType controllerType, GameObject fieldSetContainer)
				{
					if (this.fieldSets.ContainsKey((int)controllerType))
					{
						return;
					}
					this.fieldSets.Add((int)controllerType, new ControlMapper.InputGridEntryList.FieldSet(fieldSetContainer));
				}

				// Token: 0x06001D2B RID: 7467 RVA: 0x000D1B74 File Offset: 0x000CFD74
				public void AddInputField(ControllerType controllerType, int fieldIndex, ControlMapper.GUIInputField inputField)
				{
					if (!this.fieldSets.ContainsKey((int)controllerType))
					{
						return;
					}
					ControlMapper.InputGridEntryList.FieldSet fieldSet = this.fieldSets.Get((int)controllerType);
					if (fieldSet.fields.ContainsKey(fieldIndex))
					{
						return;
					}
					fieldSet.fields.Add(fieldIndex, inputField);
				}

				// Token: 0x06001D2C RID: 7468 RVA: 0x000D1BBC File Offset: 0x000CFDBC
				public ControlMapper.GUIInputField GetGUIInputField(ControllerType controllerType, int fieldIndex)
				{
					if (!this.fieldSets.ContainsKey((int)controllerType))
					{
						return null;
					}
					if (!this.fieldSets.Get((int)controllerType).fields.ContainsKey(fieldIndex))
					{
						return null;
					}
					return this.fieldSets.Get((int)controllerType).fields.Get(fieldIndex);
				}

				// Token: 0x06001D2D RID: 7469 RVA: 0x000D1C0C File Offset: 0x000CFE0C
				public void PopulateField(ControllerType controllerType, int controllerId, int index, int actionElementMapId, string label, bool invert)
				{
					if (!this.fieldSets.ContainsKey((int)controllerType))
					{
						return;
					}
					if (!this.fieldSets.Get((int)controllerType).fields.ContainsKey(index))
					{
						return;
					}
					ControlMapper.GUIInputField guiinputField = this.fieldSets.Get((int)controllerType).fields.Get(index);
					guiinputField.SetLabel(label);
					guiinputField.actionElementMapId = actionElementMapId;
					guiinputField.controllerId = controllerId;
					if (guiinputField.hasToggle)
					{
						guiinputField.toggle.SetInteractible(true, false);
						guiinputField.toggle.SetToggleState(invert);
						guiinputField.toggle.actionElementMapId = actionElementMapId;
					}
				}

				// Token: 0x06001D2E RID: 7470 RVA: 0x000D1CA0 File Offset: 0x000CFEA0
				public void SetFixedFieldData(ControllerType controllerType, int controllerId)
				{
					if (!this.fieldSets.ContainsKey((int)controllerType))
					{
						return;
					}
					ControlMapper.InputGridEntryList.FieldSet fieldSet = this.fieldSets.Get((int)controllerType);
					int count = fieldSet.fields.Count;
					for (int i = 0; i < count; i++)
					{
						fieldSet.fields[i].controllerId = controllerId;
					}
				}

				// Token: 0x06001D2F RID: 7471 RVA: 0x000D1CF4 File Offset: 0x000CFEF4
				public void Initialize()
				{
					for (int i = 0; i < this.fieldSets.Count; i++)
					{
						ControlMapper.InputGridEntryList.FieldSet fieldSet = this.fieldSets[i];
						int count = fieldSet.fields.Count;
						for (int j = 0; j < count; j++)
						{
							ControlMapper.GUIInputField guiinputField = fieldSet.fields[j];
							if (guiinputField.hasToggle)
							{
								guiinputField.toggle.SetInteractible(false, false);
								guiinputField.toggle.SetToggleState(false);
								guiinputField.toggle.actionElementMapId = -1;
							}
							guiinputField.SetLabel("");
							guiinputField.actionElementMapId = -1;
							guiinputField.controllerId = -1;
						}
					}
				}

				// Token: 0x06001D30 RID: 7472 RVA: 0x000D1DA0 File Offset: 0x000CFFA0
				public void SetActive(bool state)
				{
					if (this.label != null)
					{
						this.label.SetActive(state);
					}
					int count = this.fieldSets.Count;
					for (int i = 0; i < count; i++)
					{
						this.fieldSets[i].groupContainer.SetActive(state);
					}
				}

				// Token: 0x06001D31 RID: 7473 RVA: 0x000D1DF0 File Offset: 0x000CFFF0
				public void SetFieldsActive(bool state)
				{
					for (int i = 0; i < this.fieldSets.Count; i++)
					{
						ControlMapper.InputGridEntryList.FieldSet fieldSet = this.fieldSets[i];
						int count = fieldSet.fields.Count;
						for (int j = 0; j < count; j++)
						{
							ControlMapper.GUIInputField guiinputField = fieldSet.fields[j];
							guiinputField.SetInteractible(state, false);
							if (guiinputField.hasToggle && (!state || guiinputField.toggle.actionElementMapId >= 0))
							{
								guiinputField.toggle.SetInteractible(state, false);
							}
						}
					}
				}

				// Token: 0x0400141F RID: 5151
				private ControlMapper.IndexedDictionary<int, ControlMapper.InputGridEntryList.FieldSet> fieldSets;

				// Token: 0x04001420 RID: 5152
				public ControlMapper.GUILabel label;

				// Token: 0x04001421 RID: 5153
				public readonly InputAction action;

				// Token: 0x04001422 RID: 5154
				public readonly AxisRange axisRange;

				// Token: 0x04001423 RID: 5155
				public readonly ControlMapper.InputActionSet actionSet;
			}

			// Token: 0x020002A0 RID: 672
			private class FieldSet
			{
				// Token: 0x06001D32 RID: 7474 RVA: 0x00016307 File Offset: 0x00014507
				public FieldSet(GameObject groupContainer)
				{
					this.groupContainer = groupContainer;
					this.fields = new ControlMapper.IndexedDictionary<int, ControlMapper.GUIInputField>();
				}

				// Token: 0x04001424 RID: 5156
				public readonly GameObject groupContainer;

				// Token: 0x04001425 RID: 5157
				public readonly ControlMapper.IndexedDictionary<int, ControlMapper.GUIInputField> fields;
			}

			// Token: 0x020002A1 RID: 673
			private class ActionCategoryEntry
			{
				// Token: 0x06001D33 RID: 7475 RVA: 0x00016321 File Offset: 0x00014521
				public ActionCategoryEntry(int actionCategoryId)
				{
					this.actionCategoryId = actionCategoryId;
				}

				// Token: 0x06001D34 RID: 7476 RVA: 0x00016330 File Offset: 0x00014530
				public void SetLabel(ControlMapper.GUILabel label)
				{
					this.label = label;
				}

				// Token: 0x06001D35 RID: 7477 RVA: 0x00016339 File Offset: 0x00014539
				public void SetActive(bool state)
				{
					if (this.label != null)
					{
						this.label.SetActive(state);
					}
				}

				// Token: 0x04001426 RID: 5158
				public readonly int actionCategoryId;

				// Token: 0x04001427 RID: 5159
				public ControlMapper.GUILabel label;
			}
		}

		// Token: 0x020002A3 RID: 675
		private class WindowManager
		{
			// Token: 0x1700036F RID: 879
			// (get) Token: 0x06001D3E RID: 7486 RVA: 0x000D1F88 File Offset: 0x000D0188
			public bool isWindowOpen
			{
				get
				{
					for (int i = this.windows.Count - 1; i >= 0; i--)
					{
						if (!(this.windows[i] == null))
						{
							return true;
						}
					}
					return false;
				}
			}

			// Token: 0x17000370 RID: 880
			// (get) Token: 0x06001D3F RID: 7487 RVA: 0x000D1FC4 File Offset: 0x000D01C4
			public Window topWindow
			{
				get
				{
					for (int i = this.windows.Count - 1; i >= 0; i--)
					{
						if (!(this.windows[i] == null))
						{
							return this.windows[i];
						}
					}
					return null;
				}
			}

			// Token: 0x06001D40 RID: 7488 RVA: 0x000D200C File Offset: 0x000D020C
			public WindowManager(GameObject windowPrefab, GameObject faderPrefab, Transform parent)
			{
				this.windowPrefab = windowPrefab;
				this.parent = parent;
				this.windows = new List<Window>();
				this.fader = global::UnityEngine.Object.Instantiate<GameObject>(faderPrefab);
				this.fader.transform.SetParent(parent, false);
				this.fader.GetComponent<RectTransform>().localScale = Vector2.one;
				this.SetFaderActive(false);
			}

			// Token: 0x06001D41 RID: 7489 RVA: 0x00016379 File Offset: 0x00014579
			public Window OpenWindow(string name, int width, int height)
			{
				Window window = this.InstantiateWindow(name, width, height);
				this.UpdateFader();
				return window;
			}

			// Token: 0x06001D42 RID: 7490 RVA: 0x0001638A File Offset: 0x0001458A
			public Window OpenWindow(GameObject windowPrefab, string name)
			{
				if (windowPrefab == null)
				{
					Debug.LogError("Rewired Control Mapper: Window Prefab is null!");
					return null;
				}
				Window window = this.InstantiateWindow(name, windowPrefab);
				this.UpdateFader();
				return window;
			}

			// Token: 0x06001D43 RID: 7491 RVA: 0x000D2078 File Offset: 0x000D0278
			public void CloseTop()
			{
				for (int i = this.windows.Count - 1; i >= 0; i--)
				{
					if (!(this.windows[i] == null))
					{
						this.DestroyWindow(this.windows[i]);
						this.windows.RemoveAt(i);
						break;
					}
					this.windows.RemoveAt(i);
				}
				this.UpdateFader();
			}

			// Token: 0x06001D44 RID: 7492 RVA: 0x000163AF File Offset: 0x000145AF
			public void CloseWindow(int windowId)
			{
				this.CloseWindow(this.GetWindow(windowId));
			}

			// Token: 0x06001D45 RID: 7493 RVA: 0x000D20E8 File Offset: 0x000D02E8
			public void CloseWindow(Window window)
			{
				if (window == null)
				{
					return;
				}
				for (int i = this.windows.Count - 1; i >= 0; i--)
				{
					if (this.windows[i] == null)
					{
						this.windows.RemoveAt(i);
					}
					else if (!(this.windows[i] != window))
					{
						this.DestroyWindow(this.windows[i]);
						this.windows.RemoveAt(i);
						break;
					}
				}
				this.UpdateFader();
				this.FocusTopWindow();
			}

			// Token: 0x06001D46 RID: 7494 RVA: 0x000D217C File Offset: 0x000D037C
			public void CloseAll()
			{
				this.SetFaderActive(false);
				for (int i = this.windows.Count - 1; i >= 0; i--)
				{
					if (this.windows[i] == null)
					{
						this.windows.RemoveAt(i);
					}
					else
					{
						this.DestroyWindow(this.windows[i]);
						this.windows.RemoveAt(i);
					}
				}
				this.UpdateFader();
			}

			// Token: 0x06001D47 RID: 7495 RVA: 0x000D21F0 File Offset: 0x000D03F0
			public void CancelAll()
			{
				if (!this.isWindowOpen)
				{
					return;
				}
				for (int i = this.windows.Count - 1; i >= 0; i--)
				{
					if (!(this.windows[i] == null))
					{
						this.windows[i].Cancel();
					}
				}
				this.CloseAll();
			}

			// Token: 0x06001D48 RID: 7496 RVA: 0x000D224C File Offset: 0x000D044C
			public Window GetWindow(int windowId)
			{
				if (windowId < 0)
				{
					return null;
				}
				for (int i = this.windows.Count - 1; i >= 0; i--)
				{
					if (!(this.windows[i] == null) && this.windows[i].id == windowId)
					{
						return this.windows[i];
					}
				}
				return null;
			}

			// Token: 0x06001D49 RID: 7497 RVA: 0x000163BE File Offset: 0x000145BE
			public bool IsFocused(int windowId)
			{
				return windowId >= 0 && !(this.topWindow == null) && this.topWindow.id == windowId;
			}

			// Token: 0x06001D4A RID: 7498 RVA: 0x000163E4 File Offset: 0x000145E4
			public void Focus(Window window)
			{
				if (window == null)
				{
					return;
				}
				window.TakeInputFocus();
				this.DefocusOtherWindows(window.id);
			}

			// Token: 0x06001D4B RID: 7499 RVA: 0x000D22B0 File Offset: 0x000D04B0
			private void DefocusOtherWindows(int focusedWindowId)
			{
				if (focusedWindowId < 0)
				{
					return;
				}
				for (int i = this.windows.Count - 1; i >= 0; i--)
				{
					if (!(this.windows[i] == null) && this.windows[i].id != focusedWindowId)
					{
						this.windows[i].Disable();
					}
				}
			}

			// Token: 0x06001D4C RID: 7500 RVA: 0x000D2314 File Offset: 0x000D0514
			private void UpdateFader()
			{
				if (!this.isWindowOpen)
				{
					this.SetFaderActive(false);
					return;
				}
				if (this.topWindow.transform.parent == null)
				{
					return;
				}
				this.SetFaderActive(true);
				this.fader.transform.SetAsLastSibling();
				int siblingIndex = this.topWindow.transform.GetSiblingIndex();
				this.fader.transform.SetSiblingIndex(siblingIndex);
			}

			// Token: 0x06001D4D RID: 7501 RVA: 0x00016402 File Offset: 0x00014602
			private void FocusTopWindow()
			{
				if (this.topWindow == null)
				{
					return;
				}
				this.topWindow.TakeInputFocus();
			}

			// Token: 0x06001D4E RID: 7502 RVA: 0x0001641E File Offset: 0x0001461E
			private void SetFaderActive(bool state)
			{
				this.fader.SetActive(state);
			}

			// Token: 0x06001D4F RID: 7503 RVA: 0x000D2384 File Offset: 0x000D0584
			private Window InstantiateWindow(string name, int width, int height)
			{
				if (string.IsNullOrEmpty(name))
				{
					name = "Window";
				}
				GameObject gameObject = UITools.InstantiateGUIObject<Window>(this.windowPrefab, this.parent, name);
				if (gameObject == null)
				{
					return null;
				}
				Window component = gameObject.GetComponent<Window>();
				if (component != null)
				{
					component.Initialize(this.GetNewId(), new Func<int, bool>(this.IsFocused));
					this.windows.Add(component);
					component.SetSize(width, height);
				}
				return component;
			}

			// Token: 0x06001D50 RID: 7504 RVA: 0x000D23FC File Offset: 0x000D05FC
			private Window InstantiateWindow(string name, GameObject windowPrefab)
			{
				if (string.IsNullOrEmpty(name))
				{
					name = "Window";
				}
				if (windowPrefab == null)
				{
					return null;
				}
				GameObject gameObject = UITools.InstantiateGUIObject<Window>(windowPrefab, this.parent, name);
				if (gameObject == null)
				{
					return null;
				}
				Window component = gameObject.GetComponent<Window>();
				if (component != null)
				{
					component.Initialize(this.GetNewId(), new Func<int, bool>(this.IsFocused));
					this.windows.Add(component);
				}
				return component;
			}

			// Token: 0x06001D51 RID: 7505 RVA: 0x0001642C File Offset: 0x0001462C
			private void DestroyWindow(Window window)
			{
				if (window == null)
				{
					return;
				}
				global::UnityEngine.Object.Destroy(window.gameObject);
			}

			// Token: 0x06001D52 RID: 7506 RVA: 0x00016443 File Offset: 0x00014643
			private int GetNewId()
			{
				int num = this.idCounter;
				this.idCounter++;
				return num;
			}

			// Token: 0x06001D53 RID: 7507 RVA: 0x00016459 File Offset: 0x00014659
			public void ClearCompletely()
			{
				this.CloseAll();
				if (this.fader != null)
				{
					global::UnityEngine.Object.Destroy(this.fader);
				}
			}

			// Token: 0x04001431 RID: 5169
			private List<Window> windows;

			// Token: 0x04001432 RID: 5170
			private GameObject windowPrefab;

			// Token: 0x04001433 RID: 5171
			private Transform parent;

			// Token: 0x04001434 RID: 5172
			private GameObject fader;

			// Token: 0x04001435 RID: 5173
			private int idCounter;
		}
	}
}
