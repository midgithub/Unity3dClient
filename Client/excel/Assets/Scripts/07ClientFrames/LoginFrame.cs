﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GameClient
{
    public class LoginFrame : ClientFrame
    {
        protected override void _OnOpenFrame()
        {
            Button btnClose = Utility.FindComponent<Button>(root, "Close");
            if(null != btnClose)
            {
                btnClose.onClick.AddListener(_OnClickCloseFrame);
            }

            RegisterEvent(ClientEvent.CE_LOGIN_TEST, _OnLoginTest);

            InvokeManager.Instance().Invoke(this, 5.0f, _OnInvokeCall);
        }

        void _OnInvokeCall()
        {
            LogManager.Instance().LogErrorFormat("_OnInvokeCall CALLED !!!");
        }

        protected void _OnLoginTest(object param)
        {
            LogManager.Instance().LogErrorFormat("On Recv Login Test Event !!!");
        }

        protected void _OnClickCloseFrame()
        {
            UIManager.Instance().CloseFrame(this);
        }

        protected override void _OnCloseFrame()
        {
            InvokeManager.Instance().RemoveInvoke(this, _OnInvokeCall);
        }
    }
}