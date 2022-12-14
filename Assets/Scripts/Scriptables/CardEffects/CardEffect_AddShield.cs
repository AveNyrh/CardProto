using UnityEngine;

[CreateAssetMenu(fileName = "New add shield", menuName = "Card effects/Add shield")]
public class CardEffect_AddShield : CardEffect_SO
{
    public override bool DoEffect(Entity sender, Entity target, int[] values, GameObject fx)
    {
        if (values.Length != 1 || sender == null || fx == null) 
            return false;

        Instantiate(fx, sender.ShieldSpriteTransform.position, Quaternion.identity);

        sender.AddShield(values[0]);
        return true;
    }
}