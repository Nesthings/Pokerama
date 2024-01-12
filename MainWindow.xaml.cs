using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Memorama
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();



        }



        //Funciones encargadas de contraer y extender los botones al colocar el mouse encima
        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            ToggleButton button = (ToggleButton)sender;

            // Reducir el tamaño del botón
            ScaleTransform scaleTransform = new ScaleTransform(0.9, 0.9);
            button.RenderTransform = scaleTransform; // Usar 'button' en lugar de 'ToggleButton'

            // Agregar una animación para volver al tamaño original
            DoubleAnimation animation = new DoubleAnimation(1, TimeSpan.FromSeconds(0.5));
            scaleTransform.BeginAnimation(ScaleTransform.ScaleXProperty, animation);
            scaleTransform.BeginAnimation(ScaleTransform.ScaleYProperty, animation);
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            ToggleButton button = (ToggleButton)sender;

            // Restaurar el tamaño original del botón
            ScaleTransform scaleTransform = new ScaleTransform(1, 1);
            button.RenderTransform = scaleTransform;
        }

        private void RandomizeToggleButtons()
        {
            List<ToggleButton> toggleButtons = new List<ToggleButton>();

            foreach (UIElement element in Greedy.Children)

            {
                if (element is ToggleButton toggleButton)
                {
                    toggleButtons.Add(toggleButton);

                }
            }

            Random random = new Random();
            toggleButtons.Sort((a, b) => random.Next(-1, 2));

            Greedy.Children.Clear();


            foreach (ToggleButton toggleButton in toggleButtons)
            {

                Greedy.Children.Add(toggleButton);

            }






        }

    }

}


 /*
       private void Randomizar_Click(object sender, RoutedEventArgs e)
        {

            RandomizeToggleButtons();

        };

        private void Randomizar_Click_1(object sender, RoutedEventArgs e)
        {

        }

       private void Mostrar_Click(object sender, RoutedEventArgs e)
        {
            // Itera a través de los ToggleButtons y cambia la visibilidad de las imágenes
            foreach (var control in Greedy.Children)
            {
                if (control is ToggleButton toggleButton)
                {
                    if (toggleButton.IsChecked == true)
                    {
                        if (Greedy.Children[])
                        {
                            // Cambiar la visibilidad de la imagen actual
                            ((Image)toggleButton.Template.FindName("Image", toggleButton)).Visibility = Visibility.Visible;
                        }
                        else
                        {
                            // Ocultar la imagen actual
                            ((Image)toggleButton.Template.FindName("Image", toggleButton)).Visibility = Visibility.Collapsed;
                        }
                    }
                }
            }

            // Cambiar el estado de la variable para la próxima vez que se haga clic
            imagenesVisibles = !imagenesVisibles;
        }
    }
}
 */
        
    





   




