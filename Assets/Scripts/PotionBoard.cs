using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionBoard : MonoBehaviour
{
      public int width = 6;
      public int height = 8;

      public float spacingX;
      public float spacingY;

      public GameObject[] potionPrefabs;

      private Node[,] potionBoard;
      public GameObject potionBoardGO;

      //public ArrayLayout arrayLayout;

      public static PotionBoard instance;

      private void Awake()
      {
            instance = this;
      }

      private void Start()
      {
            InitializeBoard();
      }

      void InitializeBoard()
      {
            potionBoard = new Node[width, height];

            spacingX = (float) (width - 1) / 2;
            spacingY = (float) (height - 1) / 2;

            for (int y = 0; y < height; y++)
            {
                  for (int x = 0; x < width; x++)
                  {
                        Vector2 postion = new Vector2(x - spacingX, y - spacingY);

                        int randomIndex = Random.Range(0, potionPrefabs.Length);

                        GameObject potion = Instantiate(potionPrefabs[randomIndex], postion, Quaternion.identity);
                        potion.GetComponent<Potion>().SetIndicies(x, y);
                        potionBoard[x, y] = new Node(true, potion);
                  }
            }
      }
}
