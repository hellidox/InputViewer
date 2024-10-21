using System;
using System.Collections.Generic;
using System.ComponentModel;
using Rewired.Internal;
using Rewired.Internal.Windows;
using Rewired.Utils.Interfaces;
using Rewired.Utils.Platforms.Windows;
using UnityEngine.UI;

namespace Rewired.Utils
{
	// Token: 0x0200026D RID: 621
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class ExternalTools : IExternalTools
	{
		// Token: 0x060019CC RID: 6604 RVA: 0x00005F91 File Offset: 0x00004191
		public void Destroy()
		{
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060019CD RID: 6605 RVA: 0x000137E3 File Offset: 0x000119E3
		// (remove) Token: 0x060019CE RID: 6606 RVA: 0x000137FC File Offset: 0x000119FC
		public event Action<bool> EditorPausedStateChangedEvent
		{
			add
			{
				this._EditorPausedStateChangedEvent = (Action<bool>)Delegate.Combine(this._EditorPausedStateChangedEvent, value);
			}
			remove
			{
				this._EditorPausedStateChangedEvent = (Action<bool>)Delegate.Remove(this._EditorPausedStateChangedEvent, value);
			}
		}

		// Token: 0x060019CF RID: 6607 RVA: 0x00013815 File Offset: 0x00011A15
		public object GetPlatformInitializer()
		{
			return Main.GetPlatformInitializer();
		}

		// Token: 0x060019D0 RID: 6608 RVA: 0x0001381C File Offset: 0x00011A1C
		public string GetFocusedEditorWindowTitle()
		{
			return string.Empty;
		}

		// Token: 0x060019D1 RID: 6609 RVA: 0x0000C609 File Offset: 0x0000A809
		public bool IsEditorSceneViewFocused()
		{
			return false;
		}

		// Token: 0x060019D2 RID: 6610 RVA: 0x0000C609 File Offset: 0x0000A809
		public bool LinuxInput_IsJoystickPreconfigured(string name)
		{
			return false;
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060019D3 RID: 6611 RVA: 0x000C6D04 File Offset: 0x000C4F04
		// (remove) Token: 0x060019D4 RID: 6612 RVA: 0x000C6D3C File Offset: 0x000C4F3C
		public event Action<uint, bool> XboxOneInput_OnGamepadStateChange;

		// Token: 0x060019D5 RID: 6613 RVA: 0x00013823 File Offset: 0x00011A23
		public ulong XboxOneInput_GetControllerId(uint unityJoystickId)
		{
			return 0UL;
		}

		// Token: 0x060019D6 RID: 6614 RVA: 0x0000C609 File Offset: 0x0000A809
		public bool XboxOneInput_IsGamepadActive(uint unityJoystickId)
		{
			return false;
		}

		// Token: 0x060019D7 RID: 6615 RVA: 0x0001381C File Offset: 0x00011A1C
		public string XboxOneInput_GetControllerType(ulong xboxControllerId)
		{
			return string.Empty;
		}

		// Token: 0x060019D8 RID: 6616 RVA: 0x0000C609 File Offset: 0x0000A809
		public uint XboxOneInput_GetJoystickId(ulong xboxControllerId)
		{
			return 0U;
		}

		// Token: 0x060019D9 RID: 6617 RVA: 0x00005F91 File Offset: 0x00004191
		public void XboxOne_Gamepad_UpdatePlugin()
		{
		}

		// Token: 0x060019DA RID: 6618 RVA: 0x0000C609 File Offset: 0x0000A809
		public bool XboxOne_Gamepad_SetGamepadVibration(ulong xboxOneJoystickId, float leftMotor, float rightMotor, float leftTriggerLevel, float rightTriggerLevel)
		{
			return false;
		}

		// Token: 0x060019DB RID: 6619 RVA: 0x00013827 File Offset: 0x00011A27
		public void GetDeviceVIDPIDs(out List<int> vids, out List<int> pids)
		{
			vids = new List<int>();
			pids = new List<int>();
		}

		// Token: 0x060019DC RID: 6620 RVA: 0x00013837 File Offset: 0x00011A37
		public int GetAndroidAPILevel()
		{
			return -1;
		}

		// Token: 0x060019DD RID: 6621 RVA: 0x0001383A File Offset: 0x00011A3A
		public void WindowsStandalone_ForwardRawInput(IntPtr rawInputHeaderIndices, IntPtr rawInputDataIndices, uint indicesCount, IntPtr rawInputData, uint rawInputDataSize)
		{
			Functions.ForwardRawInput(rawInputHeaderIndices, rawInputDataIndices, indicesCount, rawInputData, rawInputDataSize);
		}

		// Token: 0x060019DE RID: 6622 RVA: 0x00013848 File Offset: 0x00011A48
		public bool UnityUI_Graphic_GetRaycastTarget(object graphic)
		{
			return !(graphic as Graphic == null) && (graphic as Graphic).raycastTarget;
		}

		// Token: 0x060019DF RID: 6623 RVA: 0x00013865 File Offset: 0x00011A65
		public void UnityUI_Graphic_SetRaycastTarget(object graphic, bool value)
		{
			if (graphic as Graphic == null)
			{
				return;
			}
			(graphic as Graphic).raycastTarget = value;
		}

		// Token: 0x060019E0 RID: 6624 RVA: 0x00013882 File Offset: 0x00011A82
		public IControllerTemplate CreateControllerTemplate(Guid typeGuid, object payload)
		{
			return ControllerTemplateFactory.Create(typeGuid, payload);
		}

		// Token: 0x060019E1 RID: 6625 RVA: 0x0001388B File Offset: 0x00011A8B
		public Type[] GetControllerTemplateTypes()
		{
			return ControllerTemplateFactory.templateTypes;
		}

		// Token: 0x060019E2 RID: 6626 RVA: 0x00013892 File Offset: 0x00011A92
		public Type[] GetControllerTemplateInterfaceTypes()
		{
			return ControllerTemplateFactory.templateInterfaceTypes;
		}

		// Token: 0x040012A1 RID: 4769
		private Action<bool> _EditorPausedStateChangedEvent;
	}
}
