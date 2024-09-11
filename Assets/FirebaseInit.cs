using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*using Firebase;
using Firebase.Analytics;
using Firebase.Auth;
using Firebase.Extensions;*/


public class FirebaseInit : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
       /* FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(task =>
        {
            FirebaseAnalytics.SetAnalyticsCollectionEnabled(true);
        });*/
       
    }

    public void Auth() // Metodo de Autnticacion anonima;
    {
       /* FirebaseAuth auth = FirebaseAuth.DefaultInstance;

        auth.SignInAnonymouslyAsync().ContinueWith(task => {
            if (task.IsCanceled)
            {
                Debug.LogError("SignInAnonymouslyAsync was canceled.");
                return;
            }
            if (task.IsFaulted)
            {
                Debug.LogError("SignInAnonymouslyAsync encountered an error: " + task.Exception);
                return;
            }

            AuthResult result = task.Result;
            Debug.LogFormat("User signed in successfully: {0} ({1})",
                result.User.DisplayName, result.User.UserId);
        });*/
    }
}
