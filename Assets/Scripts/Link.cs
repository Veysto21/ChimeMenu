using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class Link : MonoBehaviour
{

    public void OpenYouTubeChannel()
    {
#if !UNITY_EDITOR
		openWindow("https://www.youtube.com/@hurleypiano3953");
#endif
    }

    public void OpenFacebook()
    {
#if !UNITY_EDITOR
		openWindow("https://www.facebook.com/groups/2253683604947579");
#endif
    }

    public void OpenInstagram()
    {
#if !UNITY_EDITOR
		openWindow("https://www.instagram.com/chimecandy/");
#endif
    }

    public void OpenTwitter()
    {
#if !UNITY_EDITOR
		openWindow("https://twitter.com/HurleyPiano");
#endif
    }

    public void OpenTikTok()
    {
#if !UNITY_EDITOR
		openWindow("https://www.tiktok.com/@chimecandy");
#endif
    }

    [DllImport("__Internal")]
    private static extern void openWindow(string url);

}