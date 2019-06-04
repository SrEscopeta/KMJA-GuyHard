using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class Video : MonoBehaviour
{
    public Camera camera;
    public VideoPlayer videoPlayer;
    public string NombreEscena;

    void Awake()
    {
        camera = Camera.FindObjectOfType<Camera>();

        videoPlayer = GetComponent<VideoPlayer>();
        
    }
    // Start is called before the first frame update
    void Start()
    {
        videoPlayer.Play();
        videoPlayer.renderMode = VideoRenderMode.CameraNearPlane;
        videoPlayer.targetCamera = camera;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(NombreEscena);
        }
    }

}
