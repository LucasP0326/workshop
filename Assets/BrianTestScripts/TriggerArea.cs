using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerArea : MonoBehaviour
{
 private void OnTriggerEnter(Collider other)
 {
    GameEvents.current.DoorwayTriggerEnter();
 }

 private void OnTriggerExit(Collider other)
 {
   GameEvetns.current.DoorwayTriggerExit();
 }
}
