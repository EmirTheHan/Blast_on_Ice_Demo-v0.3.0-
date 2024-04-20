using System.Collections;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private bool p1shaked, p2shaked = false;
    public AnimationCurve curve;
    private float duration = 1.5f;

    public GameObject p1, p2, ball;
    [SerializeField] private float speed1 = .3f;
    private float bpX, brZ, xPosition;
    private int firstRefP1, lastRefP1, firstRefP2, lastRefP2;

    private new Camera camera;
    int zoom = 17;
    int normal = 70;
    public float smooth = 5;
    private bool isZoomed = false;
    private void Start()
    {
        camera = GetComponent<Camera>();
        firstRefP1 = 0;
        firstRefP2 = 0;
    }
    void Update()
    {
        if (StartTimer.isStart)
        {
            if (!p1.activeSelf)
            {
                if (!p1shaked)
                {
                    StartCoroutine(Shaking());
                    p1shaked = true;
                }
            }
            else
            {
                p1shaked = false;
            }

            if (!p2.activeSelf)
            {
                if (!p2shaked)
                {
                    StartCoroutine(Shaking());
                    p2shaked = true;
                }
            }
            else
            {
                p2shaked = false;
            }
        }

        if (ball.activeSelf)
        {
            bpX = ball.transform.position.x;
            brZ = ball.transform.position.z;

            Vector3 newPosition = new Vector3(bpX, transform.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, newPosition, speed1 * Time.deltaTime);

            xPosition = Mathf.Clamp(transform.position.x, -10, 10);
            transform.position = new Vector3(xPosition, transform.position.y, transform.position.z);

            Vector3 newRotation = new Vector3((65.855f - brZ), transform.rotation.y, transform.rotation.z);
            transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, newRotation, Time.deltaTime);
        }
        else
        {
            lastRefP1 = GoalControl2.puan2;
            lastRefP2 = GoalControl1.puan1;
            if (firstRefP1 != lastRefP1)
            {
                if (p1.activeSelf)
                {
                    StartCoroutine(FocusP1());
                }
                firstRefP1 = lastRefP1;

            }
            else if (firstRefP2 != lastRefP2)
            {
                if (p2.activeSelf)
                {
                    StartCoroutine(FocusP2());
                }
                firstRefP2 = lastRefP2;
            }
            else if (!isZoomed)
            {
                Vector3 newPosition = new Vector3(0, transform.position.y, transform.position.z);
                transform.position = Vector3.Lerp(transform.position, newPosition, 2 * Time.deltaTime);

                transform.eulerAngles = new Vector3(65.855f, 0, 0);
            }
        }

        if (isZoomed)
        {
            camera.fieldOfView = Mathf.Lerp(camera.fieldOfView, zoom, Time.deltaTime * smooth);
        }
        else
        {
            camera.fieldOfView = Mathf.Lerp(camera.fieldOfView, normal, Time.deltaTime * smooth);
        }
    }
    IEnumerator FocusP1()
    {
        yield return new WaitForSecondsRealtime(2);
        isZoomed = !isZoomed;
        float timePassed = 0;
        while (timePassed < 2f)
        {
            transform.LookAt(p1.transform);
            timePassed += Time.deltaTime;

            yield return null;
        }
        isZoomed = !isZoomed;
    }
    IEnumerator FocusP2()
    {
        yield return new WaitForSecondsRealtime(2);
        isZoomed = !isZoomed;
        float timePassed = 0;
        while (timePassed <= 2f)
        {
            transform.LookAt(p2.transform);
            timePassed += Time.deltaTime;

            yield return null;
        }
        isZoomed = !isZoomed;
    }
    IEnumerator Shaking()
    {
        Vector3 startPosition = transform.position;
        float elapsedTime = 0;
        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float strength = curve.Evaluate(elapsedTime / duration);
            transform.position = startPosition + Random.insideUnitSphere * strength;
            yield return null;
        }
        transform.position = startPosition;
    }
}


