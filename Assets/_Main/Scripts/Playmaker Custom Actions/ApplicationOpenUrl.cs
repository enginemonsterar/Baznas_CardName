﻿// (c) Copyright HutongGames, LLC 2010-2012. All rights reserved.

using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Application)]
	[Tooltip("Open a Url link in the browser")]
	public class ApplicationOpenUrl : FsmStateAction
	{
		
		[RequiredField]
		public FsmString url;
		
		[Tooltip("When in webPlayer, will open a new window, define the name of that window here.")]
		public FsmString WebWindowTitle;
		
		public override void Reset()
		{
			url ="";
		}

		public override void OnEnter()
		{
			
            Application.OpenURL(url.Value);
			
			Finish();
		}
	}
}