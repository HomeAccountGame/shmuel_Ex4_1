using UnityEngine;

/**
 * This component moves its object in a fixed velocity.
 * NOTE: velocity is defined as speed+direction.
 *       speed is a number; velocity is a vector.
 */
public class Mover: MonoBehaviour {
    [Tooltip("Movement vector in meters per second")]
    [SerializeField] Vector3 velocity;
    [SerializeField] float speed;
    void Start ()
    {
        speed = (float)Random.Range(0f, 1f);
    }
    void Update() {
        transform.position += velocity * Time.deltaTime*speed;
    }

    public void SetVelocity(Vector3 newVelocity) {
        this.velocity = newVelocity;
    }
    public int get_value() {
        Debug.Log("Value from component: " + speed * 10);
        return (int)(speed*10); }
}
