using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    class Field
    {

    }
    abstract class GameObject
    {
        
    }
    abstract class StaticObject : GameObject
    {

    }
    abstract class MovableObject : GameObject, IMovable
    {
        public void Move()
        {

        }
    }

    class Player : MovableObject
    {

    }
    class Enemy : MovableObject
    {

    }
    class Barrier : StaticObject
    {

    }
    class Bonus : StaticObject
    {
        public void IncreaseStat()
        {

        }
    }


    internal interface IMovable
    {
        void Move();
    }

    class Wolf : Enemy
    {
    }

    class Lion : Enemy
    {
    }
}
