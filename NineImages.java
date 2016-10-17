//create nine cropped images

import java.awt.*;
import java.awt.image.*;
import java.io.*;
import javax.imageio.*;

public class NineImages {

    static BufferedImage img;
    static String name;
    static String ext;
    static String[] parts;

    public static void main(String[] args) {
        parts = args[0].split("\\.");
        name = parts[0];
        ext = parts[1];
        img = LoadImage(args[0]);
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                int index = 1 + i + j * 3;
                saveImg(name + index, ext, cropImage(img, i, j));
            }
        }
        System.out.println("Done");
    }

    public static BufferedImage cropImage(BufferedImage img, int tx, int ty) {
        int w = img.getWidth() / 3;
        int h = img.getHeight() / 3;
        BufferedImage dest = img.getSubimage(w * tx, h * ty, w, h);
        return dest;
    }

    public static BufferedImage LoadImage(String image) {
       try {
           img = ImageIO.read(new File(image));
       } catch (IOException e) {
       }
       return img;
   } //close method

   public static void saveImg(String name, String ext, BufferedImage img) {
       File outputfile = new File(name + "." + ext);
       try {
           ImageIO.write(img, ext, outputfile);
       } catch (IOException e) {
       }
   }
}
