using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Algorithm_I.Easy
{
    internal class FloodFillClass
    {
        public int[][] FloodFill(int[][] image, int sr, int sc, int color)
        {

            if (image[sr][sc] == color) return image;

            var previousColor = image[sr][sc];
            image[sr][sc] = color;

            if (sc - 1 >= 0)
                if (image[sr][sc - 1] == previousColor) FloodFill(image, sr, sc - 1, color);

            if (sr - 1 >= 0)
                if (image[sr - 1][sc] == previousColor) FloodFill(image, sr - 1, sc, color);

            if (sr + 1 < image.Length)
                if (image[sr + 1][sc] == previousColor) FloodFill(image, sr + 1, sc, color);

            if (sc + 1 < image[sr].Length)
                if (image[sr][sc + 1] == previousColor) FloodFill(image, sr, sc + 1, color);

            return image;
        }
    }
}
