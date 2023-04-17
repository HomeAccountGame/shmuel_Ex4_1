using UnityEngine;

/**
 * This component increases a given "score" field whenever it is triggered.
 */
public class ScoreAdder : MonoBehaviour {
    [Tooltip("Every object tagged with this tag will trigger adding score to the score field.")]
    [SerializeField] string triggeringTag;
    [SerializeField] NumberField scoreField;
    [SerializeField] int pointsToAdd;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag && scoreField!=null) {
            Mover otherComponent = other.GetComponent<Mover>();
            int value = 0;
            value = otherComponent.get_value();
            if (value == 0)
            {
                friendMover otherCo = other.GetComponent<friendMover>();
                value = otherCo.get_value();
            }
            else
            Debug.Log("Value from component: " + value + other.tag);
            scoreField.AddNumber(value);
        }
    }

    public void SetScoreField(NumberField newTextField) {
        this.scoreField = newTextField;
    }
}
