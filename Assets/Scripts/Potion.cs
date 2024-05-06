using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour
{

      public PotionType PotionType;

      public int xIndex;
      public int yIndex;

      public bool isMatched;
      private Vector2 currentpos;
      private Vector2 targetpos;

      public bool isMoving;

      public Potion(int _x, int _y)
      {
            xIndex = _x;
            yIndex = _y;
      }

      public void SetIndicies(int _x, int _y)
      {
            xIndex = _x;
            yIndex = _y;
      }
}

public enum PotionType
{
      Blue,
      Orange,
      Lightblue,
      Green,
      Pink,
      Yellow,
}