using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpGL;
using SharpGL.SceneGraph.Effects;
using SharpGL.SceneGraph.Primitives;
using SharpGL.Serialization.Wavefront;

namespace Cuadrados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openGLControl1_OpenGLInitialized(object sender, EventArgs e)
        {
            OpenGL GL = openGLControl1.OpenGL;
            GL.ClearColor(0, 0, 0, 0);
        }

        private void openGLControl1_Resize(object sender, EventArgs e)
        {
            OpenGL GL = openGLControl1.OpenGL;
            GL.MatrixMode(OpenGL.GL_PROJECTION);
            GL.LoadIdentity();
            GL.Perspective(30.0f, (Double)Width / (Double)Height, 5, 100);
            GL.LookAt(-5, 5, -5, 0, 0, 0, 0, 1, 0);
            GL.MatrixMode(OpenGL.GL_PROJECTION);
            GL.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
        }

        private void openGLControl1_OpenGLDraw(object sender, SharpGL.RenderEventArgs args)
        {
            SharpGL.OpenGL GL = this.openGLControl1.OpenGL;
            GL.LoadIdentity();

            GL.Translate(-1.5f, 0f, -6f);
            GL.Begin(OpenGL.GL_QUADS);
            {
                GL.Vertex(-0.5f, 2.0f, 0.0f);
                GL.Vertex(1.0f, 2.0f, 0.0f);
                GL.Vertex(1.0f, -2.0f, 0.0f);
                GL.Vertex(-0.5f, -2.0f, 0.0f);

            }
            GL.End();


            GL.Translate(1.51f, 0f, 0f);
            GL.Begin(OpenGL.GL_QUADS);
            {
                GL.Vertex(-0.5f, 2.0f, 0.0f);
                GL.Vertex(1.0f, 2.0f, 0.0f);
                GL.Vertex(1.0f, -2.0f, 0.0f);
                GL.Vertex(-0.5f, -2.0f, 0.0f);
            }
            GL.End();


            GL.Translate(1.511f, 0f, 0f);
            GL.Begin(OpenGL.GL_QUADS);
            {
                GL.Vertex(-0.5f, 2.0f, 0.0f);
                GL.Vertex(1.0f, 2.0f, 0.0f);
                GL.Vertex(1.0f, -2.0f, 0.0f);
                GL.Vertex(-0.5f, -2.0f, 0.0f);
            }
            GL.End();


            GL.Translate(1.5111f, 0f, 0f);
            GL.Begin(OpenGL.GL_QUADS);
            {
                GL.Vertex(-0.5f, 2.0f, 0.0f);
                GL.Vertex(1.0f, 2.0f, 0.0f);
                GL.Vertex(1.0f, -2.0f, 0.0f);
                GL.Vertex(-0.5f, -2.0f, 0.0f);
            }
            GL.End();

            GL.Flush();

        }

    }
}
