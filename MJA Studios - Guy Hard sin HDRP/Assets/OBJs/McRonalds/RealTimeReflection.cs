using UnityEngine;
[ExecuteInEditMode]
public class RealTimeReflection : MonoBehaviour
{
    ReflectionProbe probe;

    private void Awake()
    {
        probe = GetComponent<ReflectionProbe>();
    }

    private void Update()
    {
        probe.transform.position = new Vector3(
        Camera.main.transform.position.x,
        Camera.main.transform.position.y * -1,
        Camera.main.transform.position.z
        );
        probe.RenderProbe();
    }
}
