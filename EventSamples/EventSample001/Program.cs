namespace EventSample001
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}

public class MyClass
{
    public EventHandler _xChanged;
    public event EventHandler XChanged
    {
        add { _xChanged += value; }
        remove { _xChanged -= value; }
    }

    protected virtual void OnXChanged()
    {
        _xChanged?.Invoke(this, EventArgs.Empty);
    }
    public int _x;
    public int X 
    {
        get { return _x; }
        set
        {
            if (_x != value)
            {
                _x = value;
                OnXChanged();
            }
        }
    }
}

public partial class Form1 : Form
{
    private MyClass obj;
    public Form1()
    {
        InitializeComponent();
        obj = new MyClass();
        obj.XChanged += Obj_XChanged;
    }
    private void Obj_XChanged(object sender, EventArgs e)
    {
        MessageBox.Show("X 的值改變了");
    }
    private void button1_Click(object sender, EventArgs e)
    {
        obj.X += 1;
    }
}