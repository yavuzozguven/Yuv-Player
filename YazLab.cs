using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazLab
{
    public partial class YazLab : Form
    {
        
        OpenFileDialog op = new OpenFileDialog();
        int boyut,frame,max_frame,en,boy,sayac=0;
        byte[] y, u, v;
        Bitmap bmp;
        FileStream fs;
        BinaryReader br;

        public YazLab()
        {
            InitializeComponent();
        }

        private void Dosyaac_Click(object sender, EventArgs e)
        {
            if (op.ShowDialog() == DialogResult.OK)
            {
                FileInfo fi = new FileInfo(op.FileName);
                
                
                
                
                if (fi.Exists)
                {
                    Dosya_yolu.Text = fi.Name;
                }
                else
                {
                    Dosya_yolu.Text = "Dosya açılamadı.";
                }
            }
        }

        private void play_stop_Click(object sender, EventArgs e)
        {
            
            frame = 1;
            while (frame != max_frame)
            {
                String path = "C:\\Users\\Yavuz\\Desktop\\Yuvoutput\\deneme" + frame + ".bmp";
                frame_label.Text = frame + "/" + max_frame;
                frame_label.Update();
                Thread.Sleep(200);
                resim.Image = new Bitmap(path);
                resim.Update();
                frame++;
            }
            frame_label.Text = frame + "/" + max_frame;
            frame_label.Update();
        }

        public void yuv2rgb(byte[] y,byte[] u,byte []v,int boyut)
        {
            byte[] r = new byte[boyut];
            byte[] g = new byte[boyut];
            byte[] b = new byte[boyut];

            for (int i = 0; i < boyut; i++)
            {
                //r[i] =(byte)(y[i] + (114*v[i]/100));
                //r[i] = (byte)(1.164*(y[i]-16) +  1.596*(v[i]-128));
                r[i] = (byte)(1.164 * (y[i] - 16));
                if (r[i] > 255)
                    r[i] = 255;
                if(r[i] < 0)
                {
                    r[i] = 0;
                }
                //g[i] =(byte) (y[i] - (u[i]*0.395) - (v[i]*0.581));
                //g[i] = (byte)(1.164*(y[i]-16) - ((u[i]-128) * 0.391) - ((v[i]-128) * 0.813));
                g[i] = (byte)(1.164 * (y[i] - 16));
                if (g[i] > 255)
                    g[i] = 255;
                if (g[i] < 0)
                {
                    g[i] = 0;
                }
                //b[i] =(byte) (1.164*(y[i]-16) + (2.018 * (u[i]-128)));
                b[i] = (byte)(1.164 * (y[i] - 16));
                if (b[i] > 255)
                    b[i] = 255;
                if (b[i] < 0)
                {
                    b[i] = 0;
                }
            }
            rgb2bmp(r, g, b);
            //BytesToBitmap(r,g,b);
        }

        public Bitmap rgb2bmp(byte[] r,byte[] g,byte []b)
        {
            bmp = new Bitmap(en, boy, PixelFormat.Format24bppRgb);
            Rectangle rect = new Rectangle(0, 0, en, boy);
            BitmapData bmpd = bmp.LockBits(rect, ImageLockMode.WriteOnly, bmp.PixelFormat);
            int padding = bmpd.Stride - 3 * en;
            unsafe
            {
                byte* ptr = (byte*)bmpd.Scan0;
                for (int i = 0; i < boy; i++)
                {
                    for (int j = 0; j < en; j++)
                    {
                        ptr[2] =  r[i * en + j];
                        ptr[1] =  g[i * en + j];
                        ptr[0] =  b[i * en + j];
                        ptr += 3;
                    }
                    ptr += padding;
                }
            }
            bmp.UnlockBits(bmpd);
            resim.SizeMode = PictureBoxSizeMode.CenterImage;
            
            resim.SizeMode = PictureBoxSizeMode.StretchImage;
            
            resim.Image = bmp;
            sayac++;
            bmp.Save("C:\\Users\\Yavuz\\Desktop\\Yuvoutput\\deneme"+sayac+".bmp");
            return bmp;
        }

        



        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Bitmap |*.bmp";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(sf.FileName,ImageFormat.Bmp);
            }
        }

        private void goster_Click(object sender, EventArgs e)
        {
            boyut = Int32.Parse(en_al.Text) * Int32.Parse(boy_al.Text);
            en = Int32.Parse(en_al.Text);
            boy = Int32.Parse(boy_al.Text);
            
            u = new byte[boyut];
            v = new byte[boyut];
            int cnt = 0;

                fs = new FileStream(op.FileName, FileMode.Open);
                br = new BinaryReader(fs);
                

                frame = 0;

                if (format.SelectedIndex == 0)
                {
                y = new byte[boyut*3];
                for (int i = 0; i < fs.Length; i += boyut)
                    {
                        if (i % boyut == 0)
                            max_frame++;
                    }
                    max_frame = max_frame / 3;

                while (cnt != max_frame)
                {
                    for (int i = 0; i < boyut*3; i++)
                    { 
                        y[i] = br.ReadByte();
                    }
                    cnt++;
                    yuv2rgb(y, u, v, boyut);
                    frame++;
                    frame_label.Text = (frame) + "/" + max_frame;
                }
                
                }
                if (format.SelectedIndex == 1)
                {
                    byte[] y = new byte[boyut*2];
                    
                    for (int i = 0; i < fs.Length; i += boyut)
                    {
                        if (i % boyut == 0)
                            max_frame++;
                    }
                    max_frame = (int) (max_frame / 3 * 1.5);
                while (cnt != max_frame)
                {
                    for (int i = 0; i < boyut * 2; i++)
                    {
                        y[i] = br.ReadByte();
                    }
                    cnt++;
                    yuv2rgb(y, u, v, boyut);
                    frame++;
                    frame_label.Text = (frame) + "/" + max_frame;
                }
                }
                if (format.SelectedIndex == 2)
                {
                y = new byte[boyut * 3];
                for (int i = 0; i < fs.Length; i += boyut)
                    {
                        if (i % boyut == 0)
                            max_frame++;
                    }
                    max_frame = max_frame / 3 * 2;

                
                while (cnt != max_frame)
                {
                    for (int i = 0; i < boyut * 3 / 2; i++)
                    {
                        y[i] = br.ReadByte();
                    }
                    cnt++;
                    yuv2rgb(y, u, v, boyut);
                    frame++;
                    frame_label.Text = (frame) + "/" + max_frame;
                }
                

                fs.Close();
               
                }


            
            //fs.Close();
           

        }

        

        
    }
}
