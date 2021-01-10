using Burgerownia.Back.Interface;
using System.Windows.Forms;

namespace Burgerownia.Winforms
{
    public partial class Form1 : Form
    {
        IContext _context;
        IServiceable<Back.Model.Burger> _burgers;

        public Form1(IContext context)
        {
            _context = context;
            _burgers = _context.BurgerService;

            InitializeComponent();

            _burgers.Items.ForEach(b => listBox1.Items.Add(b));
            textBox1.Text = "Nosz kurwa jego mac";
        }


    }
}
