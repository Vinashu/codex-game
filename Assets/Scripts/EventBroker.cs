using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventBroker : MonoBehaviour
{
    public static event Action<Player>OnPlayerUpdate;
    public static event Action<Player> OnNewPlayer;
    public static event Action<String> OnPostmanError;
    public static event Action<String> OnPostmanSuccess;

    public static void CallOnPlayerUpdate (Player player)
    {
        OnPlayerUpdate?.Invoke(player);
    }

    public static void CallOnNewPlayer (Player player)
    {
        OnNewPlayer?.Invoke(player);
    }

    public static void CallOnPostmanError (string error)
    {
        OnPostmanError?.Invoke(error);
    }

    public static void CallOnPostmanSuccess(string result)
    {
        OnPostmanSuccess?.Invoke(result);
    }


}
