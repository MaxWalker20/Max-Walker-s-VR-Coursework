// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
//
// public class NewBehaviourScript : ScriptableObject
// {
//     void RatioChanged(int dropdownChange)
//     {
//       Debug.Log("function called");
//       float[] ratio = {0f, 0f};
//       ratio = RatioDecider(dropdownChange, ratio);
//       Debug.Log(ratio[0] + " and " + ratio[1]);
//       // Graph graph = new Graph();
//       // Graph.ratioNumerator = ratio[0];
//       // Graph.ratioDenominator = ratio[1];
//     }
//
//     float[] RatioDecider(int change, float[] ratio){
//       Debug.Log(change);
//       ratio[0] = 0f;
//       ratio[1] = 1f;
//       //https://en.wikipedia.org/wiki/Interval_(music)#Size_of_intervals_used_in_different_tuning_systems
//       switch(change)
//       {
//         case 0:
//           ratio[0] = 0f;
//           ratio[1] = 1f;
//           break;
//         case 1:
//           ratio[0] = 1f;
//           ratio[1] = 1f;
//           break;
//         case 2:
//           ratio[0] = 16f;
//           ratio[1] = 15f;
//           break;
//         case 3:
//           ratio[0] = 9f;
//           ratio[1] = 8f;
//           break;
//         case 4:
//           ratio[0] = 6f;
//           ratio[1] = 5f;
//           break;
//         case 5:
//           ratio[0] = 5f;
//           ratio[1] = 4f;
//           break;
//         case 6:
//           ratio[0] = 4f;
//           ratio[1] = 3f;
//           break;
//         case 7:
//           ratio[0] = 45f;
//           ratio[1] = 32f;
//           break;
//         case 8:
//           ratio[0] = 3f;
//           ratio[1] = 2f;
//           break;
//         case 9:
//           ratio[0] = 8f;
//           ratio[1] = 5f;
//           break;
//         case 10:
//           ratio[0] = 5f;
//           ratio[1] = 3f;
//           break;
//         case 11:
//           ratio[0] = 16f;
//           ratio[1] = 9f;
//           break;
//         case 12:
//           ratio[0] = 15f;
//           ratio[1] = 8f;
//           break;
//         case 13:
//           ratio[0] = 2f;
//           ratio[1] = 1f;
//           break;
//       }
//       Debug.Log("decision successfully made");
//       return ratio;
//     }
// }
