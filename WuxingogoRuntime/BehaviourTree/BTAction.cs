﻿#if UNITY_EDITOR || !UNITY_ANDROID && !UNITY_IPHONE
#define Wuxingogo_Core
#endif
using wuxingogo.Runtime;
using System;

namespace wuxingogo.btFsm
{
	public class BTAction : XScriptableObject
	{

		public BTState Owner = null;

		public virtual void OnEnter()
		{

		}

		public virtual void OnExit()
		{

		}

		public virtual void OnUpdate()
		{

		}

		public void Finish()
		{
			Owner.Finish();
		}

		//public static T CreateAction<T>(BTState parentState) where T : BTAction
		//{
		//	var action = XScriptableObject.CreateInstance<T>();
		//	action.Owner = parentState;
		//	parentState.totalActions.Add(action);
		//	action.AddObjectToObject();
		//	return action;
		//}

		public static BTAction CreateAction(BTAction source, BTState parentState)
		{
			BTAction action = XScriptableObject.CreateInstance(source.GetType()) as BTAction;
			action.Owner = parentState;
			parentState.totalActions.Add(action);
			action.name = source.GetType().Name;
			return action;
		}


	}

}