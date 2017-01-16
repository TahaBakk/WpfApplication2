using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfApplication2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer dispatcherTimer;
        private DateTimeOffset lastTime;
        private DateTimeOffset startTime;

        public MainWindow()
        {
            InitializeComponent();
            Actualizar_setup();

        }



        public void Actualizar_setup()
        {
            dispatcherTimer = new DispatcherTimer();//creamos un objeto
            dispatcherTimer.Tick += dispatcherTimer_Tick;//le decimos que nos llame la funcion dispatcherTimer_Tick
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);//le decimos cada cuando queremos que lo vaya actualizando (hora/minuto/segundo)

            startTime = new DateTimeOffset();// le da la hora y fecha del pc en el que estamos
            lastTime = startTime;
            dispatcherTimer.Start();
        }

        void dispatcherTimer_Tick(object sender, object e)
        {
            mostrar_hora.Text = DateTime.Now.ToString();
        }
    }
}