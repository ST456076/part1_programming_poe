using System.Drawing;//namesspace to work with the image
using System.IO;//name space for input; output
using System;//namespace for basic  functionalies 

namespace part1_programming_poe
{
    internal class logo_image
    {
        public logo_image()
        {
            //get full location of the project
            string full_location = AppDomain.CurrentDomain.BaseDirectory;
            // Replace "bin\\Debug" part of the path to get the root directory of the project
            string new_location = full_location.Replace("bin\\Debug\\", "");

            //combine the root directory path with the image file name to get the full path of the image
            string full_path = Path.Combine(new_location, "log.jpeg");

            //create ASCII image using Bitmap class (use small letter m)
            //after typing, press light bulb
            //select 'using System.Drawing(from System.Drawing)'
            Bitmap image = new Bitmap(full_path);

            // Resize the image to fit the console window
            image = new Bitmap(image, new Size(100, 50));

            //outer and inner loop
            for (int height = 0; height < image.Height; height++)

            {
                //inner loop
                for (int width = 0; width < image.Width; width++)
                {

                }
                for (int width = 0; width < image.Width; width++)
                {
                    // Get the color of the current pixel at (width, height)
                    Color pixelColor = image.GetPixel(width, height);
                    // Convert the color of the pixel to a grayscale value by averaging the RGB components
                    int gray = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    // This creates the ASCII representation based on the pixel's grayscale intensity
                    char assiChar = gray > 200 ? '.' : gray > 100 ? '*' : gray > 50 ? 'o' : gray > 80 ? '#' : '@';
                    // Write the corresponding ASCII character to the console (one character per pixel)

                    Console.Write(assiChar);
                }//end of inner loop

                // Move to the next line after printing all pixels in the current row
                Console.WriteLine();

            }//end of outer loop

        }// end of constructor
    }//end of  class
}//end of name space
