using UnityEngine;

public class Test_AudioCtl : MonoBehaviour
{
    AudioCtl _audioCtl;

    // Start is called before the first frame update
    void awake()
    {
        _audioCtl = FindObjectOfType<AudioCtl>();
    }

    public void TestAudioCtl(int index)
    {
        _audioCtl.Effect(index);
    }
}
