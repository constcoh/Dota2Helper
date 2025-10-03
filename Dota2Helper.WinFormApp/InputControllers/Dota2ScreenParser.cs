using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Tesseract;

namespace Dota2Helper.WinFormApp.InputControllers
{
    public class Dota2ScreenParser
    {
        public Dota2ScreenParser()
        {
        }

        public string[] GetGame(byte[] memory)
        {
            // https://tesseract.patagames.com/Downloads/
            using var engine = new TesseractEngine(@"source-best", "eng", EngineMode.Default);
            engine.DefaultPageSegMode = PageSegMode.SingleBlock;

            // Load the image into a Pix object
            using (var img = Pix.LoadFromMemory(memory))
            {
                var xMin = 152;
                var xMax = 255;

                var yBaseWhite = 75;
                var yBaseBlack = 394;
                var dyHero = 59;

                var dyHeroToMin = 22;
                var dyHeroToMax = 33;
                var dy2LineHeroToMin = 16;
                var dy2LineHeroToMax = 42;

                var height = dyHeroToMax - dyHeroToMin + 1;
                var height2Line = dy2LineHeroToMax - dy2LineHeroToMin + 1;
                var width = xMax - xMin + 1;

                var rectWhite1 = new Rect(xMin, yBaseWhite + dyHero * 0 + dyHeroToMin, width, height);
                var rectWhite2 = new Rect(xMin, yBaseWhite + dyHero * 1 + dyHeroToMin, width, height);
                var rectWhite3 = new Rect(xMin, yBaseWhite + dyHero * 2 + dyHeroToMin, width, height);
                var rectWhite4 = new Rect(xMin, yBaseWhite + dyHero * 3 + dyHeroToMin, width, height);
                var rectWhite5 = new Rect(xMin, yBaseWhite + dyHero * 4 + dyHeroToMin, width, height);

                var rectBlack1 = new Rect(xMin, yBaseBlack + dyHero * 0 + dyHeroToMin, width, height);
                var rectBlack2 = new Rect(xMin, yBaseBlack + dyHero * 1 + dyHeroToMin, width, height);
                var rectBlack3 = new Rect(xMin, yBaseBlack + dyHero * 2 + dyHeroToMin, width, height);
                var rectBlack4 = new Rect(xMin, yBaseBlack + dyHero * 3 + dyHeroToMin, width, height);
                var rectBlack5 = new Rect(xMin, yBaseBlack + dyHero * 4 + dyHeroToMin, width, height);

                var rect2LineWhite1 = new Rect(xMin, yBaseWhite + dyHero * 0 + dy2LineHeroToMin, width, height2Line);
                var rect2LineWhite2 = new Rect(xMin, yBaseWhite + dyHero * 1 + dy2LineHeroToMin, width, height2Line);
                var rect2LineWhite3 = new Rect(xMin, yBaseWhite + dyHero * 2 + dy2LineHeroToMin, width, height2Line);
                var rect2LineWhite4 = new Rect(xMin, yBaseWhite + dyHero * 3 + dy2LineHeroToMin, width, height2Line);
                var rect2LineWhite5 = new Rect(xMin, yBaseWhite + dyHero * 4 + dy2LineHeroToMin, width, height2Line);

                var rect2LineBlack1 = new Rect(xMin, yBaseBlack + dyHero * 0 + dy2LineHeroToMin, width, height2Line);
                var rect2LineBlack2 = new Rect(xMin, yBaseBlack + dyHero * 1 + dy2LineHeroToMin, width, height2Line);
                var rect2LineBlack3 = new Rect(xMin, yBaseBlack + dyHero * 2 + dy2LineHeroToMin, width, height2Line);
                var rect2LineBlack4 = new Rect(xMin, yBaseBlack + dyHero * 3 + dy2LineHeroToMin, width, height2Line);
                var rect2LineBlack5 = new Rect(xMin, yBaseBlack + dyHero * 4 + dy2LineHeroToMin, width, height2Line);

                return new string[]
                {
                    // White
                    Parse(engine, img, rectWhite1, rect2LineWhite1),
                    Parse(engine, img, rectWhite2, rect2LineWhite2),
                    Parse(engine, img, rectWhite3, rect2LineWhite3),
                    Parse(engine, img, rectWhite4, rect2LineWhite4),
                    Parse(engine, img, rectWhite5, rect2LineWhite5),
                    // Black
                    Parse(engine, img, rectBlack1, rect2LineBlack1),
                    Parse(engine, img, rectBlack2, rect2LineBlack2),
                    Parse(engine, img, rectBlack3, rect2LineBlack3),
                    Parse(engine, img, rectBlack4, rect2LineBlack4),
                    Parse(engine, img, rectBlack5, rect2LineBlack5)
                };

                ////var rect = new Rect(152, 77, 101, 15);
                ////var rect = new Rect(400, 90, 50, 30);
                // Process the image to perform OCR
                ////using (var page = engine.Process(img))
                ////{

                ////    var zoneWhite1 = engine.Process(img , )

                ////    // Get the recognized text
                ////    string recognizedText = page.GetText();

                ////    // Get the mean confidence for the page
                ////    float confidence = page.GetMeanConfidence();

                ////    Console.WriteLine("Recognized Text:");
                ////    Console.WriteLine(recognizedText);
                ////    Console.WriteLine($"Mean Confidence: {confidence:P2}"); // Display as percentage
                ////}
            }
        }

        private string Parse(TesseractEngine engine, Pix image, Rect rect, Rect rect2Line)
        {
            var res = string.Empty;

            using (var page = engine.Process(image, rect))
            {
                res = page.GetText();

                Console.WriteLine($"{rect.X1}, {rect.Y1}, {rect.X2}, {rect.Y2}, {JsonSerializer.Serialize(res)}");

                if (!string.IsNullOrWhiteSpace(res)) return res;
            }

            using (var page = engine.Process(image, rect2Line))
            {
                res = page.GetText();

                Console.WriteLine($"{rect2Line.X1}, {rect2Line.Y1}, {rect2Line.X2}, {rect2Line.Y2}, {JsonSerializer.Serialize(res)}");

                return res;
            }
        }
    }
}
