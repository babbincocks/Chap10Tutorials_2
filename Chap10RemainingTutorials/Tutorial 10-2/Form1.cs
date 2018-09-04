using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial_10_2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowAnimalInfo(Animal animal)
        {
            MessageBox.Show("Species: " + animal.Species);
            animal.MakeSound();
        }

        private void btnAnimal_Click(object sender, EventArgs e)
        {
            Animal myAnimal = new Animal("Regular animal");
            ShowAnimalInfo(myAnimal);
        }

        private void btnDog_Click(object sender, EventArgs e)
        {
            Dog myDog = new Dog("Scout");
            MessageBox.Show("The dog's name is " + myDog.Name);
            ShowAnimalInfo(myDog);
        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            Cat myCat = new Cat("Sadie");
            MessageBox.Show("The cat's name is " + myCat.Name);
            ShowAnimalInfo(myCat);
        }
    }
}
