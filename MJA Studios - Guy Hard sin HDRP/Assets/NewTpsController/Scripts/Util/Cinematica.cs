using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class Cinematica : MonoBehaviour
{
    public Camera camera;
    public VideoPlayer videoPlayer;
    public GameObject canvas;

    public string canvasPlayer;
    public bool dentro;
    public bool apreteE;
    void Awake()
    {
        camera = Camera.FindObjectOfType<Camera>();

        videoPlayer = GetComponent<VideoPlayer>();
        canvas = GameObject.Find(canvasPlayer);

    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            dentro = true;
            if (Input.GetKeyDown(KeyCode.E))
            {
                apreteE = true;
                videoPlayer.Play();
                videoPlayer.renderMode = VideoRenderMode.CameraNearPlane;
                videoPlayer.targetCamera = camera;

                canvas.SetActive(false);
            }
        }
    }


}
