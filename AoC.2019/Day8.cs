using System;
using System.Collections.Generic;
using System.Linq;
using AoC.Common;
using static AoC.Common.SantaHelper;

namespace AoC2019
{
    /*

    */

    public class Day8 : Day
    {
        public override string Title => "";

        public override void PartOne()
        {
            base.PartOne();
            return;
            var input = Inputs.Day8;
            //input = "123456789012";

            var layers = new List<ImageLayers>();

            var skip = 0;
            var take = ImageLayers.Total;

            while (skip < input.Length)
            {
                var layerData = input.Skip(skip).Take(take).ToArray();
                layers.Add(new ImageLayers(layerData));
                skip += take;
            }

            var fewest = layers.Select(s => s.Layer).OrderBy(o => ImageLayers.CountDigit(o, '0')).ToList();
            var first = fewest.First();
            var result = ImageLayers.CountDigit(first, '1') * ImageLayers.CountDigit(first, '2');
            Console.WriteLine(result);
        }

        public override void PartTwo()
        {
            base.PartTwo();
            var input = Inputs.Day8;
            //input = "0222112222120000";

            var layers = new List<ImageLayers>();

            var skip = 0;
            var take = ImageLayers.Total;

            while (skip < input.Length)
            {
                var layerData = input.Skip(skip).Take(take).ToArray();
                layers.Add(new ImageLayers(layerData));
                skip += take;
            }

            var currentPos = 0;
            for (int y = 0; y < ImageLayers.Height; y++)
            {
                for (int x = 0; x < ImageLayers.Width; x++)
                {
                    foreach (var imageLayer in layers)
                    {
                        var pixel = imageLayer.AsString[currentPos];
                        if (pixel == '0')
                        {
                            Console.Write('#');
                            break;
                        }
                        else if (pixel == '1')
                        {
                            Console.Write('|');
                            break;
                        }
                    }

                    currentPos += 1;
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }

    public class ImageLayers
    {
        public static int Width = 25;
        public static int Height = 6;
        public static int Total = Width * Height;

        public List<char[]> Layers = new List<char[]>(6);
        public string AsString;

        public ImageLayers(char[] layerData)
        {
            AsString = string.Join("", layerData);

            var skip = 0;
            for (int i = 0; i < Height; i++)
            {
                var currentLayer = layerData.Skip(skip).Take(Width).ToArray();
                Layers.Add(currentLayer);
                skip += Width;
            }
        }

        public char[] Layer => Layers.SelectMany(s => s).ToArray();

        public static int CountDigit(char[] layer, char digit)
        {
            return layer.Count(c => c == digit);
        }
    }
}