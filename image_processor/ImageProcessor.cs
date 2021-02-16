using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading.Tasks;

class ImageProcessor
{
    public static void Inverse(string[] filenames)
    {
        Parallel.ForEach(filenames, (path) =>
        {
            {
                // Console.WriteLine(path);
                Bitmap image = new Bitmap(path);

                BitmapData bmd = image.LockBits(
                    new Rectangle(0, 0, image.Width, image.Height),
                    ImageLockMode.ReadWrite, image.PixelFormat);

                int bytes = bmd.Stride * bmd.Height;

                byte[] rgbBuffer = new byte[bytes];
                System.Runtime.InteropServices.Marshal.Copy(bmd.Scan0, rgbBuffer, 0, bytes);

                for (var i = 0; i < bytes; i++)
                    rgbBuffer[i] = (byte)(255 - rgbBuffer[i]);

                System.Runtime.InteropServices.Marshal.Copy(rgbBuffer, 0, bmd.Scan0, bytes);

                image.UnlockBits(bmd);

                string[] namesplit = path.Split(new char[] {'/', '.'});
                String newname = namesplit[namesplit.Length - 2] + "_inverse." + namesplit[namesplit.Length - 1];

                image.Save(newname);
            }
        });
    }
}
