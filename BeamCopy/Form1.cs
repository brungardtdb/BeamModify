using System;
using System.Windows.Forms;
// Tekla Structures Namespace References
using Tekla.Structures.Model;

namespace BeamCopy
{
    public partial class frmBeamCopy : Form
    {
        // Instantiate model in class so model doesn't need to be specifically called out in form
        Model Model;

        public frmBeamCopy()
        {
            InitializeComponent();
        }

        private void frmBeamCopy_Load(object sender, EventArgs e)
        {
            // Try to connect to model
            try
            {
                // Connect Model
                Model = new Model();
            }
            catch
            {
                // Inform user model is not connected if connection fails
                MessageBox.Show("Please Open Tekla Structures");
            }         
        }

        private void btnModifySelected_Click(object sender, EventArgs e)
        {

            //Instantiate new class of CurrentSelectedObjects and modify beam
            CurrentSelectedObjects thisSelectedObjects = new CurrentSelectedObjects("C10X25", "6", Model);

            // Commit Changes
            this.Model.CommitChanges();

        }

        private void btnModifyPick_Click(object sender, EventArgs e)
        {
            //Instantiate new class of PickedObjects and modify beam following user selections
            PickedObjects currentPickedObjects = new PickedObjects("C10X25","6",Model);
        }
    }
}
