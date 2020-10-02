using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBuildingBlueprint
{
    bool IsPlaceable(Vector3 position, Vector3 rotation, Vector3 size);
    bool Place(Vector3 position, Vector3 rotation);
    bool IsDestroyable();
    void Damage(int value);
    void Heal(int value);
    bool Destroy();
    bool ReadyToUse();
    void Construct();
}
