using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace NetBasicsDemo
{
    public class HashCodeDemo
    {
        public static void Main(string[] args)
        {
            List<TwoDPoint> points = new List<TwoDPoint>(100000);
            int[] hashOfPoints = new int[points.Capacity];
            Random rn = new Random();

            for (int i = 0; i < points.Capacity; i++)
            {
                TwoDPoint point = new TwoDPoint(0, 0);

                do
                {
                    point.x = rn.Next(-100000, 100000);
                    point.y = rn.Next(-100000, 100000);
                }
                while (points.Contains(point));
                points.Add(point);
                hashOfPoints[i] = point.GetHashCode();
            }

            for (int i = 0; i < hashOfPoints.Length - 1; i++)
            {
                for (int j = i + 1; j < hashOfPoints.Length; j++)
                {
                    if (hashOfPoints[i] == hashOfPoints[j])
                    {
                        for (int k = j + 1; k < hashOfPoints.Length; k++)
                        {
                            hashOfPoints[k - 1] = hashOfPoints[k];
                        }
                        Array.Resize(ref hashOfPoints, hashOfPoints.Length - 1);
                        j--;
                    }
                }
            }

            TwoDPoint point1 = new TwoDPoint(10, 10);
            TwoDPoint point2 = new TwoDPoint(10, 10);

            if (point1.GetHashCode() == point2.GetHashCode())
            {
                Console.WriteLine("У одинаковых точек хеш совпадает");
            }
            else
            {
                Console.WriteLine("!!!У одинаковых точек хеш не совпадает");
            }

            double accuracy = 100 * Convert.ToDouble(hashOfPoints.Length) / Convert.ToDouble(points.Capacity);

            Console.WriteLine($"Уникальность хеш-функции {accuracy}%");
        }
    }
}
