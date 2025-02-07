﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace Rewired.UI.ControlMapper
{
	[Serializable]
	public class LanguageData : LanguageDataBase
	{
		public override void Initialize()
		{
			if (this._initialized)
			{
				return;
			}
			this.customDict = LanguageData.CustomEntry.ToDictionary(this._customEntries);
			this._initialized = true;
		}

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

		public override bool ContainsCustomEntryKey(string key)
		{
			return !string.IsNullOrEmpty(key) && this.customDict.ContainsKey(key);
		}

		public override string yes
		{
			get
			{
				return LanguageManager.instance.GetString(this._yes);
			}
		}

		public override string no
		{
			get
			{
				return LanguageManager.instance.GetString(this._no);
			}
		}

		public override string add
		{
			get
			{
				return LanguageManager.instance.GetString(this._add);
			}
		}

		public override string replace
		{
			get
			{
				return LanguageManager.instance.GetString(this._replace);
			}
		}

		public override string remove
		{
			get
			{
				return LanguageManager.instance.GetString(this._remove);
			}
		}

		public override string swap
		{
			get
			{
				return LanguageManager.instance.GetString(this._swap);
			}
		}

		public override string cancel
		{
			get
			{
				return LanguageManager.instance.GetString(this._cancel);
			}
		}

		public override string none
		{
			get
			{
				return LanguageManager.instance.GetString(this._none);
			}
		}

		public override string okay
		{
			get
			{
				return LanguageManager.instance.GetString(this._okay);
			}
		}

		public override string done
		{
			get
			{
				return LanguageManager.instance.GetString(this._done);
			}
		}

		public override string default_
		{
			get
			{
				return LanguageManager.instance.GetString(this._default);
			}
		}

		public override string assignControllerWindowTitle
		{
			get
			{
				return LanguageManager.instance.GetString(this._assignControllerWindowTitle);
			}
		}

		public override string assignControllerWindowMessage
		{
			get
			{
				return LanguageManager.instance.GetString(this._assignControllerWindowMessage);
			}
		}

		public override string controllerAssignmentConflictWindowTitle
		{
			get
			{
				return LanguageManager.instance.GetString(this._controllerAssignmentConflictWindowTitle);
			}
		}

		public override string elementAssignmentPrePollingWindowMessage
		{
			get
			{
				return LanguageManager.instance.GetString(this._elementAssignmentPrePollingWindowMessage);
			}
		}

		public override string elementAssignmentConflictWindowMessage
		{
			get
			{
				return LanguageManager.instance.GetString(this._elementAssignmentConflictWindowMessage);
			}
		}

		public override string mouseAssignmentConflictWindowTitle
		{
			get
			{
				return LanguageManager.instance.GetString(this._mouseAssignmentConflictWindowTitle);
			}
		}

		public override string calibrateControllerWindowTitle
		{
			get
			{
				return LanguageManager.instance.GetString(this._calibrateControllerWindowTitle);
			}
		}

		public override string calibrateAxisStep1WindowTitle
		{
			get
			{
				return LanguageManager.instance.GetString(this._calibrateAxisStep1WindowTitle);
			}
		}

		public override string calibrateAxisStep2WindowTitle
		{
			get
			{
				return LanguageManager.instance.GetString(this._calibrateAxisStep2WindowTitle);
			}
		}

		public override string inputBehaviorSettingsWindowTitle
		{
			get
			{
				return LanguageManager.instance.GetString(this._inputBehaviorSettingsWindowTitle);
			}
		}

		public override string restoreDefaultsWindowTitle
		{
			get
			{
				return LanguageManager.instance.GetString(this._restoreDefaultsWindowTitle);
			}
		}

		public override string actionColumnLabel
		{
			get
			{
				return LanguageManager.instance.GetString(this._actionColumnLabel);
			}
		}

		public override string keyboardColumnLabel
		{
			get
			{
				return LanguageManager.instance.GetString(this._keyboardColumnLabel);
			}
		}

		public override string mouseColumnLabel
		{
			get
			{
				return LanguageManager.instance.GetString(this._mouseColumnLabel);
			}
		}

		public override string controllerColumnLabel
		{
			get
			{
				return LanguageManager.instance.GetString(this._controllerLabel);
			}
		}

		public override string removeControllerButtonLabel
		{
			get
			{
				return LanguageManager.instance.GetString(this._removeControllerButtonLabel);
			}
		}

		public override string calibrateControllerButtonLabel
		{
			get
			{
				return LanguageManager.instance.GetString(this._calibrateLabel);
			}
		}

		public override string assignControllerButtonLabel
		{
			get
			{
				return LanguageManager.instance.GetString(this._assignControllerButtonLabel);
			}
		}

		public override string inputBehaviorSettingsButtonLabel
		{
			get
			{
				return LanguageManager.instance.GetString(this._inputBehaviorSettingsButtonLabel);
			}
		}

		public override string doneButtonLabel
		{
			get
			{
				return LanguageManager.instance.GetString(this._done);
			}
		}

		public override string restoreDefaultsButtonLabel
		{
			get
			{
				return LanguageManager.instance.GetString(this._restoreDefaultsButtonLabel);
			}
		}

		public override string controllerSettingsGroupLabel
		{
			get
			{
				return LanguageManager.instance.GetString(this._controllerLabel) + ":";
			}
		}

		public override string playersGroupLabel
		{
			get
			{
				return LanguageManager.instance.GetString(this._playersLabel) + ":";
			}
		}

		public override string assignedControllersGroupLabel
		{
			get
			{
				return LanguageManager.instance.GetString(this._assignedControllersGroupLabel);
			}
		}

		public override string settingsGroupLabel
		{
			get
			{
				return LanguageManager.instance.GetString(this._settingsGroupLabel) + ":";
			}
		}

		public override string mapCategoriesGroupLabel
		{
			get
			{
				return LanguageManager.instance.GetString(this._mapCategoriesGroupLabel) + ":";
			}
		}

		public override string restoreDefaultsWindowMessage
		{
			get
			{
				if (ReInput.players.playerCount > 1)
				{
					return LanguageManager.instance.GetString(this._restoreDefaultsWindowMessage_multiPlayer);
				}
				return LanguageManager.instance.GetString(this._restoreDefaultsWindowMessage_onePlayer);
			}
		}

		public override string calibrateWindow_deadZoneSliderLabel
		{
			get
			{
				return LanguageManager.instance.GetString(this._calibrateWindow_deadZoneSliderLabel) + ":";
			}
		}

		public override string calibrateWindow_zeroSliderLabel
		{
			get
			{
				return LanguageManager.instance.GetString(this._calibrateWindow_zeroSliderLabel) + ":";
			}
		}

		public override string calibrateWindow_sensitivitySliderLabel
		{
			get
			{
				return LanguageManager.instance.GetString(this._inputBehaviorSettingsButtonLabel) + ":";
			}
		}

		public override string calibrateWindow_invertToggleLabel
		{
			get
			{
				return LanguageManager.instance.GetString(this._calibrateWindow_invertToggleLabel);
			}
		}

		public override string calibrateWindow_calibrateButtonLabel
		{
			get
			{
				return LanguageManager.instance.GetString(this._calibrateLabel);
			}
		}

		public override string GetControllerAssignmentConflictWindowMessage(string joystickName, string otherPlayerName, string currentPlayerName)
		{
			return string.Format(LanguageManager.instance.GetString(this._controllerAssignmentConflictWindowMessage), joystickName, otherPlayerName, currentPlayerName);
		}

		public override string GetJoystickElementAssignmentPollingWindowMessage(string actionName)
		{
			return string.Format(LanguageManager.instance.GetString(this._joystickElementAssignmentPollingWindowMessage), actionName);
		}

		public override string GetJoystickElementAssignmentPollingWindowMessage_FullAxisFieldOnly(string actionName)
		{
			return string.Format(LanguageManager.instance.GetString(this._joystickElementAssignmentPollingWindowMessage_fullAxisFieldOnly), actionName);
		}

		public override string GetKeyboardElementAssignmentPollingWindowMessage(string actionName)
		{
			return string.Format(LanguageManager.instance.GetString(this._keyboardElementAssignmentPollingWindowMessage), actionName);
		}

		public override string GetMouseElementAssignmentPollingWindowMessage(string actionName)
		{
			return string.Format(LanguageManager.instance.GetString(this._mouseElementAssignmentPollingWindowMessage), actionName);
		}

		public override string GetMouseElementAssignmentPollingWindowMessage_FullAxisFieldOnly(string actionName)
		{
			return string.Format(LanguageManager.instance.GetString(this._mouseElementAssignmentPollingWindowMessage_fullAxisFieldOnly), actionName);
		}

		public override string GetElementAlreadyInUseBlocked(string elementName)
		{
			return string.Format(LanguageManager.instance.GetString(this._elementAlreadyInUseBlocked), elementName);
		}

		public override string GetElementAlreadyInUseCanReplace(string elementName, bool allowConflicts)
		{
			if (!allowConflicts)
			{
				return string.Format(LanguageManager.instance.GetString(this._elementAlreadyInUseCanReplace), elementName);
			}
			return string.Format(LanguageManager.instance.GetString(this._elementAlreadyInUseCanReplace_conflictAllowed), elementName);
		}

		public override string GetMouseAssignmentConflictWindowMessage(string otherPlayerName, string thisPlayerName)
		{
			return string.Format(LanguageManager.instance.GetString(this._mouseAssignmentConflictWindowMessage), otherPlayerName, thisPlayerName);
		}

		public override string GetCalibrateAxisStep1WindowMessage(string axisName)
		{
			return string.Format(LanguageManager.instance.GetString(this._calibrateAxisStep1WindowMessage), axisName);
		}

		public override string GetCalibrateAxisStep2WindowMessage(string axisName)
		{
			return string.Format(LanguageManager.instance.GetString(this._calibrateAxisStep2WindowMessage), axisName);
		}

		public override string GetPlayerName(int playerId)
		{
			Player player = ReInput.players.GetPlayer(playerId);
			if (player == null)
			{
				throw new ArgumentException("Invalid player id: " + playerId.ToString());
			}
			return LanguageManager.instance.GetString(player.descriptiveName);
		}

		public override string GetControllerName(Controller controller)
		{
			if (controller == null)
			{
				throw new ArgumentNullException("controller");
			}
			return LanguageManager.instance.GetString(controller.name);
		}

		public override string GetElementIdentifierName(ActionElementMap actionElementMap)
		{
			if (actionElementMap == null)
			{
				throw new ArgumentNullException("actionElementMap");
			}
			if (actionElementMap.controllerMap.controllerType == ControllerType.Keyboard)
			{
				return LanguageManager.instance.GetString(this.GetElementIdentifierName(actionElementMap.keyCode, actionElementMap.modifierKeyFlags));
			}
			return LanguageManager.instance.GetString(this.GetElementIdentifierName(actionElementMap.controllerMap.controller, actionElementMap.elementIdentifierId, actionElementMap.axisRange));
		}

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
				return LanguageManager.instance.GetString(elementIdentifierById.GetDisplayName(elementById.type, axisRange));
			}
			if (type != ControllerElementType.Button)
			{
				return LanguageManager.instance.GetString(elementIdentifierById.name);
			}
			return LanguageManager.instance.GetString(elementIdentifierById.name);
		}

		public override string GetElementIdentifierName(KeyCode keyCode, ModifierKeyFlags modifierKeyFlags)
		{
			if (modifierKeyFlags != ModifierKeyFlags.None)
			{
				return string.Format("{0}{1}{2}", this.ModifierKeyFlagsToString(modifierKeyFlags), this._modifierKeys.separator, Keyboard.GetKeyName(keyCode));
			}
			return Keyboard.GetKeyName(keyCode);
		}

		public override string GetActionName(int actionId)
		{
			InputAction action = ReInput.mapping.GetAction(actionId);
			if (action == null)
			{
				throw new ArgumentException("Invalid action id: " + actionId.ToString());
			}
			return LanguageManager.instance.GetString(action.descriptiveName);
		}

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
				return LanguageManager.instance.GetString(action.descriptiveName);
			case AxisRange.Positive:
				if (string.IsNullOrEmpty(action.positiveDescriptiveName))
				{
					return LanguageManager.instance.GetString(action.descriptiveName) + "+";
				}
				return LanguageManager.instance.GetString(action.positiveDescriptiveName);
			case AxisRange.Negative:
				if (string.IsNullOrEmpty(action.negativeDescriptiveName))
				{
					return LanguageManager.instance.GetString(action.descriptiveName) + "-";
				}
				return LanguageManager.instance.GetString(action.negativeDescriptiveName);
			default:
				throw new NotImplementedException();
			}
		}

		public override string GetMapCategoryName(int id)
		{
			InputMapCategory mapCategory = ReInput.mapping.GetMapCategory(id);
			if (mapCategory == null)
			{
				throw new ArgumentException("Invalid map category id: " + id.ToString());
			}
			return LanguageManager.instance.GetString(mapCategory.descriptiveName);
		}

		public override string GetActionCategoryName(int id)
		{
			InputCategory actionCategory = ReInput.mapping.GetActionCategory(id);
			if (actionCategory == null)
			{
				throw new ArgumentException("Invalid action category id: " + id.ToString());
			}
			return LanguageManager.instance.GetString(actionCategory.descriptiveName);
		}

		public override string GetLayoutName(ControllerType controllerType, int id)
		{
			InputLayout layout = ReInput.mapping.GetLayout(controllerType, id);
			if (layout == null)
			{
				throw new ArgumentException("Invalid " + controllerType.ToString() + " layout id: " + id.ToString());
			}
			return LanguageManager.instance.GetString(layout.descriptiveName);
		}

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

		[SerializeField]
		private string _yes = "Yes";

		[SerializeField]
		private string _no = "No";

		[SerializeField]
		private string _add = "Add";

		[SerializeField]
		private string _replace = "Replace";

		[SerializeField]
		private string _remove = "Remove";

		[SerializeField]
		private string _swap = "Swap";

		[SerializeField]
		private string _cancel = "Cancel";

		[SerializeField]
		private string _none = "None";

		[SerializeField]
		private string _okay = "Okay";

		[SerializeField]
		private string _done = "Done";

		[SerializeField]
		private string _default = "Default";

		[SerializeField]
		private string _assignControllerWindowTitle = "mapperAssignControllerTitle";

		[SerializeField]
		private string _assignControllerWindowMessage = "mapperAssignControllerMessage";

		[SerializeField]
		private string _controllerAssignmentConflictWindowTitle = "mapperAssignControllerAltTitle";

		[Tooltip("{0} = Joystick Name\n{1} = Other Player Name\n{2} = This Player Name")]
		[SerializeField]
		private string _controllerAssignmentConflictWindowMessage = "mapperAssignConflict";

		[SerializeField]
		private string _elementAssignmentPrePollingWindowMessage = "mapperElementAssignPre";

		[SerializeField]
		[Tooltip("{0} = Action Name")]
		private string _joystickElementAssignmentPollingWindowMessage = "mapperJoystickElementAssign";

		[Tooltip("This text is only displayed when split-axis fields have been disabled and the user clicks on the full-axis field. Button/key/D-pad input cannot be assigned to a full-axis field.\n{0} = Action Name")]
		[SerializeField]
		private string _joystickElementAssignmentPollingWindowMessage_fullAxisFieldOnly = "mapperJoystickAssignAxisOnly";

		[Tooltip("{0} = Action Name")]
		[SerializeField]
		private string _keyboardElementAssignmentPollingWindowMessage = "mapperKeyboardElementAssign";

		[SerializeField]
		[Tooltip("{0} = Action Name")]
		private string _mouseElementAssignmentPollingWindowMessage = "mapperMouseElementAssign";

		[SerializeField]
		[Tooltip("This text is only displayed when split-axis fields have been disabled and the user clicks on the full-axis field. Button/key/D-pad input cannot be assigned to a full-axis field.\n{0} = Action Name")]
		private string _mouseElementAssignmentPollingWindowMessage_fullAxisFieldOnly = "mapperMouseAssignAxisOnly";

		[SerializeField]
		private string _elementAssignmentConflictWindowMessage = "mapperElementAssignConflict";

		[Tooltip("{0} = Element Name")]
		[SerializeField]
		private string _elementAlreadyInUseBlocked = "mapperElementInUseAndBlocked";

		[SerializeField]
		[Tooltip("{0} = Element Name")]
		private string _elementAlreadyInUseCanReplace = "mapperElementInUse";

		[SerializeField]
		[Tooltip("{0} = Element Name")]
		private string _elementAlreadyInUseCanReplace_conflictAllowed = "mapperElementInUseAllowDuplicate";

		[SerializeField]
		private string _mouseAssignmentConflictWindowTitle = "mapperMouseAssignTitle";

		[Tooltip("{0} = Other Player Name\n{1} = This Player Name")]
		[SerializeField]
		private string _mouseAssignmentConflictWindowMessage = "mapperMouseAssignConflict";

		[SerializeField]
		private string _calibrateControllerWindowTitle = "mapperCalibrateControllerTitle";

		[SerializeField]
		private string _calibrateAxisStep1WindowTitle = "mapperCalibrateCenterTitle";

		[Tooltip("{0} = Axis Name")]
		[SerializeField]
		private string _calibrateAxisStep1WindowMessage = "mapperCalibrateCenterMessage";

		[SerializeField]
		private string _calibrateAxisStep2WindowTitle = "mapperCalibrateRangeTitle";

		[Tooltip("{0} = Axis Name")]
		[SerializeField]
		private string _calibrateAxisStep2WindowMessage = "mapperCalibrateRangeMessage";

		[SerializeField]
		private string _inputBehaviorSettingsWindowTitle = "SensitivitySettings";

		[SerializeField]
		private string _restoreDefaultsWindowTitle = "RestoreDefaults";

		[SerializeField]
		[Tooltip("Message for a single player game.")]
		private string _restoreDefaultsWindowMessage_onePlayer = "mapperRestoreDefaultSinglePlayer";

		[SerializeField]
		[Tooltip("Message for a multi-player game.")]
		private string _restoreDefaultsWindowMessage_multiPlayer = "mapperRestoreDefaultMultiPlayer";

		[SerializeField]
		private string _actionColumnLabel = "Actions";

		[SerializeField]
		private string _keyboardColumnLabel = "Keyboard";

		[SerializeField]
		private string _mouseColumnLabel = "Mouse";

		[SerializeField]
		private string _controllerLabel = "Controller";

		[SerializeField]
		private string _removeControllerButtonLabel = "Remove";

		[SerializeField]
		private string _calibrateLabel = "Calibrate";

		[SerializeField]
		private string _assignControllerButtonLabel = "Assign Controller";

		[SerializeField]
		private string _inputBehaviorSettingsButtonLabel = "Sensitivity";

		[SerializeField]
		private string _restoreDefaultsButtonLabel = "RestoreDefaults";

		[SerializeField]
		private string _playersLabel = "Players";

		[SerializeField]
		private string _assignedControllersGroupLabel = "Assigned Controllers";

		[SerializeField]
		private string _settingsGroupLabel = "Settings";

		[SerializeField]
		private string _mapCategoriesGroupLabel = "Categories";

		[SerializeField]
		private string _calibrateWindow_deadZoneSliderLabel = "Dead Zone";

		[SerializeField]
		private string _calibrateWindow_zeroSliderLabel = "Zero";

		[SerializeField]
		private string _calibrateWindow_invertToggleLabel = "Invert";

		[SerializeField]
		private LanguageData.ModifierKeys _modifierKeys;

		[SerializeField]
		private LanguageData.CustomEntry[] _customEntries;

		private bool _initialized;

		private Dictionary<string, string> customDict;

		[Serializable]
		protected class CustomEntry
		{
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

			public string key;

			public string value;
		}

		[Serializable]
		protected class ModifierKeys
		{
			public string control = "Control";

			public string alt = "Alt";

			public string shift = "Shift";

			public string command = "Command";

			public string separator = " + ";
		}
	}
}
