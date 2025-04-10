using UnityEngine;

public class funkymusic : MonoBehaviour
{
    public AudioClip edm;
    private AudioSource AudioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AudioSource = gameObject.AddComponent<AudioSource>();

        if (edm == null)
        {
            edm = Resources.Load<AudioClip>("edm");
        }
        if (edm != null)
        {
            AudioSource.clip = edm;
            AudioSource.loop = true;
        }


        // Update is called once per frame
        void Update()
        {
            if (AudioSource != null)
            {
                AudioSource.Play();
            }

        }
    }
}
