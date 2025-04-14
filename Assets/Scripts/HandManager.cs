using UnityEngine;
using Scales;
public class HandManager : MonoBehavior
{
   [field: SerializedField] public GameObject cardPrefab {get;set;} // Assign card prefab in inspector

   [field: SerializedField] public Transform handTransform {get;set} // Root of the hand positions

   [f]
    void Start() 
    {

    }
}
