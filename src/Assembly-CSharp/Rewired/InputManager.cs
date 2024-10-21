using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using Rewired.Platforms;
using Rewired.Utils;
using Rewired.Utils.Interfaces;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Rewired
{
	// Token: 0x0200026C RID: 620
	[AddComponentMenu("Rewired/Input Manager")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public sealed class InputManager : InputManager_Base
	{
		// Token: 0x060019C1 RID: 6593 RVA: 0x0001377A File Offset: 0x0001197A
		protected override void OnInitialized()
		{
			this.SubscribeEvents();
		}

		// Token: 0x060019C2 RID: 6594 RVA: 0x00013782 File Offset: 0x00011982
		protected override void OnDeinitialized()
		{
			this.UnsubscribeEvents();
		}

		// Token: 0x060019C3 RID: 6595 RVA: 0x000C6C9C File Offset: 0x000C4E9C
		protected override void DetectPlatform()
		{
			this.scriptingBackend = ScriptingBackend.Mono;
			this.scriptingAPILevel = ScriptingAPILevel.Net20;
			this.editorPlatform = EditorPlatform.None;
			this.platform = Platform.Unknown;
			this.webplayerPlatform = WebplayerPlatform.None;
			this.isEditor = false;
			if (SystemInfo.deviceName == null)
			{
				string empty = string.Empty;
			}
			if (SystemInfo.deviceModel == null)
			{
				string empty2 = string.Empty;
			}
			this.platform = Platform.Windows;
			this.scriptingBackend = ScriptingBackend.Mono;
			this.scriptingAPILevel = ScriptingAPILevel.NetStandard20;
		}

		// Token: 0x060019C4 RID: 6596 RVA: 0x00005F91 File Offset: 0x00004191
		protected override void CheckRecompile()
		{
		}

		// Token: 0x060019C5 RID: 6597 RVA: 0x0001378A File Offset: 0x0001198A
		protected override IExternalTools GetExternalTools()
		{
			return new ExternalTools();
		}

		// Token: 0x060019C6 RID: 6598 RVA: 0x00013791 File Offset: 0x00011991
		private bool CheckDeviceName(string searchPattern, string deviceName, string deviceModel)
		{
			return Regex.IsMatch(deviceName, searchPattern, RegexOptions.IgnoreCase) || Regex.IsMatch(deviceModel, searchPattern, RegexOptions.IgnoreCase);
		}

		// Token: 0x060019C7 RID: 6599 RVA: 0x000137A7 File Offset: 0x000119A7
		private void SubscribeEvents()
		{
			this.UnsubscribeEvents();
			SceneManager.sceneLoaded += this.OnSceneLoaded;
		}

		// Token: 0x060019C8 RID: 6600 RVA: 0x000137C0 File Offset: 0x000119C0
		private void UnsubscribeEvents()
		{
			SceneManager.sceneLoaded -= this.OnSceneLoaded;
		}

		// Token: 0x060019C9 RID: 6601 RVA: 0x000137D3 File Offset: 0x000119D3
		private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
			base.OnSceneLoaded();
		}

		// Token: 0x040012A0 RID: 4768
		private bool ignoreRecompile;
	}
}
