using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class DatabaseManager : MonoBehaviour
{
    /*public string userID;
    public TMP_InputField Name;
    public TMP_InputField Level;
    [Space]
    public TextMeshProUGUI nameTXT;
    public TextMeshProUGUI levelTXT;

    private DatabaseReference dbReference;

    // Start is called before the first frame update
    void Start()
    {
        userID = SystemInfo.deviceUniqueIdentifier;
        dbReference = FirebaseDatabase.DefaultInstance.RootReference;
    }

    // Update is called once per frame
    public void CreateUser()
    {
        User newUser = new User(Name.text, int.Parse(Level.text));
        string json = JsonUtility.ToJson(newUser);

        dbReference.Child("User").Child(userID).SetRawJsonValueAsync(json);
    }

    public IEnumerator GetName(Action<string> onCallBack)
    {
        var userNameData = dbReference.Child("User").Child(userID).Child("name").GetValueAsync();

        yield return new WaitUntil(predicate: () => userNameData.IsCompleted);


        if(userNameData != null)
        {
            DataSnapshot snapShot = userNameData.Result;

            onCallBack.Invoke(snapShot.Value.ToString());
        }
    }

    public IEnumerator GetLevel(Action<int> onCallBack)
    {
        var userLevelData = dbReference.Child("User").Child(userID).Child("level").GetValueAsync();

        yield return new WaitUntil(predicate: () => userLevelData.IsCompleted);


        if (userLevelData != null)
        {
            DataSnapshot snapShot = userLevelData.Result;

            onCallBack.Invoke(int.Parse(snapShot.Value.ToString()));
        }
    }

    public void GetUserInfo()
    {
        StartCoroutine(GetName((string name) =>
        {
            nameTXT.text = "Name : " + name;

        }));

        StartCoroutine(GetLevel((int level) =>
        {
            levelTXT.text = "Level : " + level;

        }));
    }
    */
}
