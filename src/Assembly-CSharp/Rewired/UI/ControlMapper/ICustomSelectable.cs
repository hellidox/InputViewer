using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Rewired.UI.ControlMapper
{
	public interface ICustomSelectable : ICancelHandler, IEventSystemHandler
	{
		Sprite disabledHighlightedSprite { set; }

		Color disabledHighlightedColor { set; }

		string disabledHighlightedTrigger { set; }

		event UnityAction CancelEvent;
	}
}
