using UnityEngine;

public class urlbutton : MonoBehaviour
{
    public string Url;
    public void Open()
    {
        Application.OpenURL(Url);
    }
}