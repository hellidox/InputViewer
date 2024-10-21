using System;
using System.Collections.Generic;
using Rewired.Integration.UnityUI;
using Rewired.Utils;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x02000282 RID: 642
	[AddComponentMenu("")]
	public class CalibrationWindow : Window
	{
		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06001AF7 RID: 6903 RVA: 0x000144AB File Offset: 0x000126AB
		private bool axisSelected
		{
			get
			{
				return this.joystick != null && this.selectedAxis >= 0 && this.selectedAxis < this.joystick.calibrationMap.axisCount;
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06001AF8 RID: 6904 RVA: 0x000144DB File Offset: 0x000126DB
		private AxisCalibration axisCalibration
		{
			get
			{
				if (!this.axisSelected)
				{
					return null;
				}
				return this.joystick.calibrationMap.GetAxis(this.selectedAxis);
			}
		}

		// Token: 0x06001AF9 RID: 6905 RVA: 0x000CA698 File Offset: 0x000C8898
		public override void Initialize(int id, Func<int, bool> isFocusedCallback)
		{
			if (this.rightContentContainer == null || this.valueDisplayGroup == null || this.calibratedValueMarker == null || this.rawValueMarker == null || this.calibratedZeroMarker == null || this.deadzoneArea == null || this.deadzoneSlider == null || this.sensitivitySlider == null || this.zeroSlider == null || this.invertToggle == null || this.axisScrollAreaContent == null || this.doneButton == null || this.calibrateButton == null || this.axisButtonPrefab == null || this.doneButtonLabel == null || this.cancelButtonLabel == null || this.defaultButtonLabel == null || this.deadzoneSliderLabel == null || this.zeroSliderLabel == null || this.sensitivitySliderLabel == null || this.invertToggleLabel == null || this.calibrateButtonLabel == null)
			{
				Debug.LogError("Rewired Control Mapper: All inspector values must be assigned!");
				return;
			}
			this.axisButtons = new List<Button>();
			this.buttonCallbacks = new Dictionary<int, Action<int>>();
			this.doneButtonLabel.text = ControlMapper.GetLanguage().done;
			this.cancelButtonLabel.text = ControlMapper.GetLanguage().cancel;
			this.defaultButtonLabel.text = ControlMapper.GetLanguage().default_;
			this.deadzoneSliderLabel.text = ControlMapper.GetLanguage().calibrateWindow_deadZoneSliderLabel;
			this.zeroSliderLabel.text = ControlMapper.GetLanguage().calibrateWindow_zeroSliderLabel;
			this.sensitivitySliderLabel.text = ControlMapper.GetLanguage().calibrateWindow_sensitivitySliderLabel;
			this.invertToggleLabel.text = ControlMapper.GetLanguage().calibrateWindow_invertToggleLabel;
			this.calibrateButtonLabel.text = ControlMapper.GetLanguage().calibrateWindow_calibrateButtonLabel;
			base.Initialize(id, isFocusedCallback);
		}

		// Token: 0x06001AFA RID: 6906 RVA: 0x000CA8D0 File Offset: 0x000C8AD0
		public void SetJoystick(int playerId, Joystick joystick)
		{
			if (!base.initialized)
			{
				return;
			}
			this.playerId = playerId;
			this.joystick = joystick;
			if (joystick == null)
			{
				Debug.LogError("Rewired Control Mapper: Joystick cannot be null!");
				return;
			}
			float num = 0f;
			for (int i = 0; i < joystick.axisCount; i++)
			{
				int index = i;
				GameObject gameObject = UITools.InstantiateGUIObject<Button>(this.axisButtonPrefab, this.axisScrollAreaContent, "Axis" + i.ToString());
				Button button = gameObject.GetComponent<Button>();
				button.onClick.AddListener(delegate
				{
					this.OnAxisSelected(index, button);
				});
				TMP_Text componentInSelfOrChildren = UnityTools.GetComponentInSelfOrChildren<TMP_Text>(gameObject);
				if (componentInSelfOrChildren != null)
				{
					componentInSelfOrChildren.text = ControlMapper.GetLanguage().GetElementIdentifierName(joystick, joystick.AxisElementIdentifiers[i].id, AxisRange.Full);
				}
				if (num == 0f)
				{
					num = UnityTools.GetComponentInSelfOrChildren<LayoutElement>(gameObject).minHeight;
				}
				this.axisButtons.Add(button);
			}
			float spacing = this.axisScrollAreaContent.GetComponent<VerticalLayoutGroup>().spacing;
			this.axisScrollAreaContent.sizeDelta = new Vector2(this.axisScrollAreaContent.sizeDelta.x, Mathf.Max((float)joystick.axisCount * (num + spacing) - spacing, this.axisScrollAreaContent.sizeDelta.y));
			this.origCalibrationData = joystick.calibrationMap.ToXmlString();
			this.displayAreaWidth = this.rightContentContainer.sizeDelta.x;
			this.rewiredStandaloneInputModule = base.gameObject.transform.root.GetComponentInChildren<RewiredStandaloneInputModule>();
			if (this.rewiredStandaloneInputModule != null)
			{
				this.menuHorizActionId = ReInput.mapping.GetActionId(this.rewiredStandaloneInputModule.horizontalAxis);
				this.menuVertActionId = ReInput.mapping.GetActionId(this.rewiredStandaloneInputModule.verticalAxis);
			}
			if (joystick.axisCount > 0)
			{
				this.SelectAxis(0);
			}
			base.defaultUIElement = this.doneButton.gameObject;
			this.RefreshControls();
			this.Redraw();
		}

		// Token: 0x06001AFB RID: 6907 RVA: 0x000144FD File Offset: 0x000126FD
		public void SetButtonCallback(CalibrationWindow.ButtonIdentifier buttonIdentifier, Action<int> callback)
		{
			if (!base.initialized)
			{
				return;
			}
			if (callback == null)
			{
				return;
			}
			if (this.buttonCallbacks.ContainsKey((int)buttonIdentifier))
			{
				this.buttonCallbacks[(int)buttonIdentifier] = callback;
				return;
			}
			this.buttonCallbacks.Add((int)buttonIdentifier, callback);
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x000CAAE4 File Offset: 0x000C8CE4
		public override void Cancel()
		{
			if (!base.initialized)
			{
				return;
			}
			if (this.joystick != null)
			{
				this.joystick.ImportCalibrationMapFromXmlString(this.origCalibrationData);
			}
			Action<int> action;
			if (!this.buttonCallbacks.TryGetValue(1, out action))
			{
				if (this.cancelCallback != null)
				{
					this.cancelCallback();
				}
				return;
			}
			action(base.id);
		}

		// Token: 0x06001AFD RID: 6909 RVA: 0x00014535 File Offset: 0x00012735
		protected override void Update()
		{
			if (!base.initialized)
			{
				return;
			}
			base.Update();
			this.UpdateDisplay();
		}

		// Token: 0x06001AFE RID: 6910 RVA: 0x000CAB44 File Offset: 0x000C8D44
		public void OnDone()
		{
			if (!base.initialized)
			{
				return;
			}
			Action<int> action;
			if (!this.buttonCallbacks.TryGetValue(0, out action))
			{
				return;
			}
			action(base.id);
		}

		// Token: 0x06001AFF RID: 6911 RVA: 0x0001454C File Offset: 0x0001274C
		public void OnCancel()
		{
			this.Cancel();
		}

		// Token: 0x06001B00 RID: 6912 RVA: 0x00014554 File Offset: 0x00012754
		public void OnRestoreDefault()
		{
			if (!base.initialized)
			{
				return;
			}
			if (this.joystick == null)
			{
				return;
			}
			this.joystick.calibrationMap.Reset();
			this.RefreshControls();
			this.Redraw();
		}

		// Token: 0x06001B01 RID: 6913 RVA: 0x000CAB78 File Offset: 0x000C8D78
		public void OnCalibrate()
		{
			if (!base.initialized)
			{
				return;
			}
			Action<int> action;
			if (!this.buttonCallbacks.TryGetValue(3, out action))
			{
				return;
			}
			action(this.selectedAxis);
		}

		// Token: 0x06001B02 RID: 6914 RVA: 0x00014584 File Offset: 0x00012784
		public void OnInvert(bool state)
		{
			if (!base.initialized)
			{
				return;
			}
			if (!this.axisSelected)
			{
				return;
			}
			this.axisCalibration.invert = state;
		}

		// Token: 0x06001B03 RID: 6915 RVA: 0x000145A4 File Offset: 0x000127A4
		public void OnZeroValueChange(float value)
		{
			if (!base.initialized)
			{
				return;
			}
			if (!this.axisSelected)
			{
				return;
			}
			this.axisCalibration.calibratedZero = value;
			this.RedrawCalibratedZero();
		}

		// Token: 0x06001B04 RID: 6916 RVA: 0x000145CA File Offset: 0x000127CA
		public void OnZeroCancel()
		{
			if (!base.initialized)
			{
				return;
			}
			if (!this.axisSelected)
			{
				return;
			}
			this.axisCalibration.calibratedZero = this.origSelectedAxisCalibrationData.zero;
			this.RedrawCalibratedZero();
			this.RefreshControls();
		}

		// Token: 0x06001B05 RID: 6917 RVA: 0x000CABAC File Offset: 0x000C8DAC
		public void OnDeadzoneValueChange(float value)
		{
			if (!base.initialized)
			{
				return;
			}
			if (!this.axisSelected)
			{
				return;
			}
			this.axisCalibration.deadZone = Mathf.Clamp(value, 0f, 0.8f);
			if (value > 0.8f)
			{
				this.deadzoneSlider.value = 0.8f;
			}
			this.RedrawDeadzone();
		}

		// Token: 0x06001B06 RID: 6918 RVA: 0x00014600 File Offset: 0x00012800
		public void OnDeadzoneCancel()
		{
			if (!base.initialized)
			{
				return;
			}
			if (!this.axisSelected)
			{
				return;
			}
			this.axisCalibration.deadZone = this.origSelectedAxisCalibrationData.deadZone;
			this.RedrawDeadzone();
			this.RefreshControls();
		}

		// Token: 0x06001B07 RID: 6919 RVA: 0x00014636 File Offset: 0x00012836
		public void OnSensitivityValueChange(float value)
		{
			if (!base.initialized)
			{
				return;
			}
			if (!this.axisSelected)
			{
				return;
			}
			this.SetSensitivity(this.axisCalibration, value);
		}

		// Token: 0x06001B08 RID: 6920 RVA: 0x00014657 File Offset: 0x00012857
		public void OnSensitivityCancel(float value)
		{
			if (!base.initialized)
			{
				return;
			}
			if (!this.axisSelected)
			{
				return;
			}
			this.axisCalibration.sensitivity = this.origSelectedAxisCalibrationData.sensitivity;
			this.RefreshControls();
		}

		// Token: 0x06001B09 RID: 6921 RVA: 0x00014687 File Offset: 0x00012887
		public void OnAxisScrollRectScroll(Vector2 pos)
		{
			bool initialized = base.initialized;
		}

		// Token: 0x06001B0A RID: 6922 RVA: 0x00014690 File Offset: 0x00012890
		private void OnAxisSelected(int axisIndex, Button button)
		{
			if (!base.initialized)
			{
				return;
			}
			if (this.joystick == null)
			{
				return;
			}
			this.SelectAxis(axisIndex);
			this.RefreshControls();
			this.Redraw();
		}

		// Token: 0x06001B0B RID: 6923 RVA: 0x000146B7 File Offset: 0x000128B7
		private void UpdateDisplay()
		{
			this.RedrawValueMarkers();
		}

		// Token: 0x06001B0C RID: 6924 RVA: 0x000146BF File Offset: 0x000128BF
		private void Redraw()
		{
			this.RedrawCalibratedZero();
			this.RedrawValueMarkers();
		}

		// Token: 0x06001B0D RID: 6925 RVA: 0x000CAC04 File Offset: 0x000C8E04
		private void RefreshControls()
		{
			if (!this.axisSelected)
			{
				this.deadzoneSlider.value = 0f;
				this.zeroSlider.value = 0f;
				this.sensitivitySlider.value = 0f;
				this.invertToggle.isOn = false;
				return;
			}
			this.deadzoneSlider.value = this.axisCalibration.deadZone;
			this.zeroSlider.value = this.axisCalibration.calibratedZero;
			this.sensitivitySlider.value = this.GetSliderSensitivity(this.axisCalibration);
			this.invertToggle.isOn = this.axisCalibration.invert;
		}

		// Token: 0x06001B0E RID: 6926 RVA: 0x000CACB0 File Offset: 0x000C8EB0
		private void RedrawDeadzone()
		{
			if (!this.axisSelected)
			{
				return;
			}
			float num = this.displayAreaWidth * this.axisCalibration.deadZone;
			this.deadzoneArea.sizeDelta = new Vector2(num, this.deadzoneArea.sizeDelta.y);
			this.deadzoneArea.anchoredPosition = new Vector2(this.axisCalibration.calibratedZero * -this.deadzoneArea.parent.localPosition.x, this.deadzoneArea.anchoredPosition.y);
		}

		// Token: 0x06001B0F RID: 6927 RVA: 0x000CAD3C File Offset: 0x000C8F3C
		private void RedrawCalibratedZero()
		{
			if (!this.axisSelected)
			{
				return;
			}
			this.calibratedZeroMarker.anchoredPosition = new Vector2(this.axisCalibration.calibratedZero * -this.deadzoneArea.parent.localPosition.x, this.calibratedZeroMarker.anchoredPosition.y);
			this.RedrawDeadzone();
		}

		// Token: 0x06001B10 RID: 6928 RVA: 0x000CAD9C File Offset: 0x000C8F9C
		private void RedrawValueMarkers()
		{
			if (!this.axisSelected)
			{
				this.calibratedValueMarker.anchoredPosition = new Vector2(0f, this.calibratedValueMarker.anchoredPosition.y);
				this.rawValueMarker.anchoredPosition = new Vector2(0f, this.rawValueMarker.anchoredPosition.y);
				return;
			}
			float axis = this.joystick.GetAxis(this.selectedAxis);
			float num = Mathf.Clamp(this.joystick.GetAxisRaw(this.selectedAxis), -1f, 1f);
			this.calibratedValueMarker.anchoredPosition = new Vector2(this.displayAreaWidth * 0.5f * axis, this.calibratedValueMarker.anchoredPosition.y);
			this.rawValueMarker.anchoredPosition = new Vector2(this.displayAreaWidth * 0.5f * num, this.rawValueMarker.anchoredPosition.y);
		}

		// Token: 0x06001B11 RID: 6929 RVA: 0x000CAE8C File Offset: 0x000C908C
		private void SelectAxis(int index)
		{
			if (index < 0 || index >= this.axisButtons.Count)
			{
				return;
			}
			if (this.axisButtons[index] == null)
			{
				return;
			}
			this.axisButtons[index].interactable = false;
			this.axisButtons[index].Select();
			for (int i = 0; i < this.axisButtons.Count; i++)
			{
				if (i != index)
				{
					this.axisButtons[i].interactable = true;
				}
			}
			this.selectedAxis = index;
			this.origSelectedAxisCalibrationData = this.axisCalibration.GetData();
			this.SetMinSensitivity();
		}

		// Token: 0x06001B12 RID: 6930 RVA: 0x000146CD File Offset: 0x000128CD
		public override void TakeInputFocus()
		{
			base.TakeInputFocus();
			if (this.selectedAxis >= 0)
			{
				this.SelectAxis(this.selectedAxis);
			}
			this.RefreshControls();
			this.Redraw();
		}

		// Token: 0x06001B13 RID: 6931 RVA: 0x000CAF30 File Offset: 0x000C9130
		private void SetMinSensitivity()
		{
			if (!this.axisSelected)
			{
				return;
			}
			this.minSensitivity = 0.1f;
			if (this.rewiredStandaloneInputModule != null)
			{
				if (this.IsMenuAxis(this.menuHorizActionId, this.selectedAxis))
				{
					this.GetAxisButtonDeadZone(this.playerId, this.menuHorizActionId, ref this.minSensitivity);
					return;
				}
				if (this.IsMenuAxis(this.menuVertActionId, this.selectedAxis))
				{
					this.GetAxisButtonDeadZone(this.playerId, this.menuVertActionId, ref this.minSensitivity);
				}
			}
		}

		// Token: 0x06001B14 RID: 6932 RVA: 0x000CAFB8 File Offset: 0x000C91B8
		private bool IsMenuAxis(int actionId, int axisIndex)
		{
			if (this.rewiredStandaloneInputModule == null)
			{
				return false;
			}
			IList<Player> allPlayers = ReInput.players.AllPlayers;
			int count = allPlayers.Count;
			for (int i = 0; i < count; i++)
			{
				IList<JoystickMap> maps = allPlayers[i].controllers.maps.GetMaps<JoystickMap>(this.joystick.id);
				if (maps != null)
				{
					int count2 = maps.Count;
					for (int j = 0; j < count2; j++)
					{
						IList<ActionElementMap> axisMaps = maps[j].AxisMaps;
						if (axisMaps != null)
						{
							int count3 = axisMaps.Count;
							for (int k = 0; k < count3; k++)
							{
								ActionElementMap actionElementMap = axisMaps[k];
								if (actionElementMap.actionId == actionId && actionElementMap.elementIndex == axisIndex)
								{
									return true;
								}
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x06001B15 RID: 6933 RVA: 0x000CB088 File Offset: 0x000C9288
		private void GetAxisButtonDeadZone(int playerId, int actionId, ref float value)
		{
			InputAction action = ReInput.mapping.GetAction(actionId);
			if (action == null)
			{
				return;
			}
			int behaviorId = action.behaviorId;
			InputBehavior inputBehavior = ReInput.mapping.GetInputBehavior(playerId, behaviorId);
			if (inputBehavior == null)
			{
				return;
			}
			value = inputBehavior.buttonDeadZone + 0.1f;
		}

		// Token: 0x06001B16 RID: 6934 RVA: 0x000146F6 File Offset: 0x000128F6
		private float GetSliderSensitivity(AxisCalibration axisCalibration)
		{
			if (axisCalibration.sensitivityType == AxisSensitivityType.Multiplier)
			{
				return axisCalibration.sensitivity;
			}
			if (axisCalibration.sensitivityType == AxisSensitivityType.Power)
			{
				return CalibrationWindow.ProcessPowerValue(axisCalibration.sensitivity, 0f, this.sensitivitySlider.maxValue);
			}
			return axisCalibration.sensitivity;
		}

		// Token: 0x06001B17 RID: 6935 RVA: 0x000CB0CC File Offset: 0x000C92CC
		public void SetSensitivity(AxisCalibration axisCalibration, float sliderValue)
		{
			if (axisCalibration.sensitivityType == AxisSensitivityType.Multiplier)
			{
				axisCalibration.sensitivity = Mathf.Clamp(sliderValue, this.minSensitivity, float.PositiveInfinity);
				if (sliderValue < this.minSensitivity)
				{
					this.sensitivitySlider.value = this.minSensitivity;
					return;
				}
			}
			else
			{
				if (axisCalibration.sensitivityType == AxisSensitivityType.Power)
				{
					axisCalibration.sensitivity = CalibrationWindow.ProcessPowerValue(sliderValue, 0f, this.sensitivitySlider.maxValue);
					return;
				}
				axisCalibration.sensitivity = sliderValue;
			}
		}

		// Token: 0x06001B18 RID: 6936 RVA: 0x000CB140 File Offset: 0x000C9340
		private static float ProcessPowerValue(float value, float minValue, float maxValue)
		{
			value = Mathf.Clamp(value, minValue, maxValue);
			if (value > 1f)
			{
				value = MathTools.ValueInNewRange(value, 1f, maxValue, 1f, 0f);
			}
			else if (value < 1f)
			{
				value = MathTools.ValueInNewRange(value, 0f, 1f, maxValue, 1f);
			}
			return value;
		}

		// Token: 0x0400130A RID: 4874
		private const float minSensitivityOtherAxes = 0.1f;

		// Token: 0x0400130B RID: 4875
		private const float maxDeadzone = 0.8f;

		// Token: 0x0400130C RID: 4876
		[SerializeField]
		private RectTransform rightContentContainer;

		// Token: 0x0400130D RID: 4877
		[SerializeField]
		private RectTransform valueDisplayGroup;

		// Token: 0x0400130E RID: 4878
		[SerializeField]
		private RectTransform calibratedValueMarker;

		// Token: 0x0400130F RID: 4879
		[SerializeField]
		private RectTransform rawValueMarker;

		// Token: 0x04001310 RID: 4880
		[SerializeField]
		private RectTransform calibratedZeroMarker;

		// Token: 0x04001311 RID: 4881
		[SerializeField]
		private RectTransform deadzoneArea;

		// Token: 0x04001312 RID: 4882
		[SerializeField]
		private Slider deadzoneSlider;

		// Token: 0x04001313 RID: 4883
		[SerializeField]
		private Slider zeroSlider;

		// Token: 0x04001314 RID: 4884
		[SerializeField]
		private Slider sensitivitySlider;

		// Token: 0x04001315 RID: 4885
		[SerializeField]
		private Toggle invertToggle;

		// Token: 0x04001316 RID: 4886
		[SerializeField]
		private RectTransform axisScrollAreaContent;

		// Token: 0x04001317 RID: 4887
		[SerializeField]
		private Button doneButton;

		// Token: 0x04001318 RID: 4888
		[SerializeField]
		private Button calibrateButton;

		// Token: 0x04001319 RID: 4889
		[SerializeField]
		private TMP_Text doneButtonLabel;

		// Token: 0x0400131A RID: 4890
		[SerializeField]
		private TMP_Text cancelButtonLabel;

		// Token: 0x0400131B RID: 4891
		[SerializeField]
		private TMP_Text defaultButtonLabel;

		// Token: 0x0400131C RID: 4892
		[SerializeField]
		private TMP_Text deadzoneSliderLabel;

		// Token: 0x0400131D RID: 4893
		[SerializeField]
		private TMP_Text zeroSliderLabel;

		// Token: 0x0400131E RID: 4894
		[SerializeField]
		private TMP_Text sensitivitySliderLabel;

		// Token: 0x0400131F RID: 4895
		[SerializeField]
		private TMP_Text invertToggleLabel;

		// Token: 0x04001320 RID: 4896
		[SerializeField]
		private TMP_Text calibrateButtonLabel;

		// Token: 0x04001321 RID: 4897
		[SerializeField]
		private GameObject axisButtonPrefab;

		// Token: 0x04001322 RID: 4898
		private Joystick joystick;

		// Token: 0x04001323 RID: 4899
		private string origCalibrationData;

		// Token: 0x04001324 RID: 4900
		private int selectedAxis = -1;

		// Token: 0x04001325 RID: 4901
		private AxisCalibrationData origSelectedAxisCalibrationData;

		// Token: 0x04001326 RID: 4902
		private float displayAreaWidth;

		// Token: 0x04001327 RID: 4903
		private List<Button> axisButtons;

		// Token: 0x04001328 RID: 4904
		private Dictionary<int, Action<int>> buttonCallbacks;

		// Token: 0x04001329 RID: 4905
		private int playerId;

		// Token: 0x0400132A RID: 4906
		private RewiredStandaloneInputModule rewiredStandaloneInputModule;

		// Token: 0x0400132B RID: 4907
		private int menuHorizActionId = -1;

		// Token: 0x0400132C RID: 4908
		private int menuVertActionId = -1;

		// Token: 0x0400132D RID: 4909
		private float minSensitivity;

		// Token: 0x02000283 RID: 643
		public enum ButtonIdentifier
		{
			// Token: 0x0400132F RID: 4911
			Done,
			// Token: 0x04001330 RID: 4912
			Cancel,
			// Token: 0x04001331 RID: 4913
			Default,
			// Token: 0x04001332 RID: 4914
			Calibrate
		}
	}
}
