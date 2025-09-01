using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource sfxSource;
    public AudioClip ballHit;
    public AudioClip score;
    public AudioClip win;
    public AudioClip countdown;
    public AudioClip countdownEnd;
    public AudioClip button;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySFX(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip);
    }
}
