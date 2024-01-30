using System.Collections;
using UnityEngine;

public class Wrap : MonoBehaviour
{

private void Update() {
    Vector3 viewportPosition = Camera.main.WorldToViewportPoint(transform.position);

    Vector3 moveAjustment = Vector3.zero;
    if (viewportPosition.x < 0) {
        moveAjustment.x += 1;
    } else if (viewportPosition.x > 1) {
        moveAjustment.x -= 1;
    } else if (viewportPosition.y < 0) {
        moveAjustment.y += 1;
    } else if (viewportPosition.y > 1) {
        moveAjustment.y -= 1;
    }

    transform.position = Camera.main.ViewportToWorldPoint(viewportPosition + moveAjustment);

}




}
