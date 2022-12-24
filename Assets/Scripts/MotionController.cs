using UnityEngine;
using System.Collections;

public class MotionController : MonoBehaviour
{
        public float speed = 5.0f; 
        public float cellSize = 2.41868f;//размер ячейки, а также расстояни на которое нужно сдвинуться если была нажата кнопка 1.20934
        bool isMoving = false;//находимся ли в движении
        Vector3 direction;//направление движения
        Vector3 destPos;//позиция куда двигаемся

        void Update ()
        {
                if (isMoving == true)
                {
                        float step = speed * Time.deltaTime;//расстояние, которое нужно пройти в текущем кадре
                        transform.position = Vector3.MoveTowards(transform.position, destPos, step);//двигаем персонажа
                        //достигли нужной позиции - отключаем движение, включаем ловлю нажатых клавиш
                        if (transform.position == destPos) isMoving = false;
                }
                else
                {
                        if (Input.GetKeyDown(KeyCode.W))
                        {
                                //move up
                                //direction = Vector3.up;
                                direction = new Vector3(0, 0, 1);
                                destPos = transform.position + direction * cellSize;
                                isMoving = true;
                        }
                        else if (Input.GetKeyDown(KeyCode.A))
                        {
                                //move left
                                //direction = Vector3.left;
                                direction = new Vector3(-1, 0, 0);
                                destPos = transform.position + direction * cellSize;
                                isMoving = true;
                        }
                        else if (Input.GetKeyDown(KeyCode.S))
                        {
                                //move down
                                //direction = Vector3.down;
                                direction = new Vector3(0, 0, -1);
                                destPos = transform.position + direction * cellSize;
                                isMoving = true;
                        }
                        else if (Input.GetKeyDown(KeyCode.D))
                        {
                                //move right
                                //direction = Vector3.right;
                                direction = new Vector3(1, 0, 0);
                                destPos = transform.position + direction * cellSize;
                                isMoving = true;
                        }
                }
        }
}